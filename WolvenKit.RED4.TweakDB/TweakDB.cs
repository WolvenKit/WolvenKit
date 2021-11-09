using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using RED.CRC32;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Murmur3;
using WolvenKit.RED4.TweakDB.Types;

namespace WolvenKit.RED4.TweakDB
{
    /// <summary>
    /// A Tweak Database.
    /// </summary>
    /// <remarks>
    /// How to use:
    /// <code>
    /// var db = new TweakDB();
    /// 
    /// db.Add("WolvenKit.Var1", new CBool { Value = true });
    /// db.Add("WolvenKit.Var2", new CBool { Value = false });
    /// db.Add("WolvenKit.Var3", new CBool { Value = true });
    /// db.Add("WolvenKit.Var4", new CInt32 { Value = 20210818 });
    /// db.Add("WolvenKit.Var5", new CFloat { Value = 123.321f });
    /// db.Add("WolvenKit.Var6", new CName { Text = "Hello rfuzzo!" });
    /// db.Add("WolvenKit.Var7", new CString { Text = "I hate this :(" });
    /// 
    /// db.Save("tweakdb_delta.bin");
    /// </code>
    /// </remarks>
    public class TweakDB
    {
        private const uint s_magic = 0xBB1DB47;
        private const uint s_blobVersion = 5;
        private const uint s_parserVersion = 4;

        private const uint s_recordsSeed = 0x5EEDBA5E;

        private readonly FlatsPool _flats = new();
        private readonly Dictionary<string, string> _records = new();

        /// <summary>
        /// Add a new flat value to the pool.
        /// </summary>
        /// <param name="name">The flat's name.</param>
        /// <param name="value">The value.</param>
        public void Add(string name, IType value) => _flats.Add(name, value);

        /// <summary>
        /// Add a new record to the pool.
        /// </summary>
        /// <param name="name">The flat's name.</param>
        /// <param name="record">The value.</param>
        public void Add(string name, Record record)
        {
            foreach (var (key, flat) in record.Members)
            {
                _flats.Add($"{name}.{key}", flat);
            }

            var recordParent = record.Inherits; //unused
            var recordType = record.Type;

            _records.Add(name, recordType);
        }

        /// <summary>
        /// Save the database to a file.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        public void Save(string path)
        {
            using var file = File.Open(path, FileMode.Create);
            using var writer = new BinaryWriter(file);
            Save(writer);
        }

        /// <summary>
        /// Save the database to the a stream.
        /// </summary>
        /// <param name="writer">The writer.</param>
        public void Save(BinaryWriter writer)
        {
            var header = new FileHeader
            {
                Magic = s_magic,
                BlobVersion = s_blobVersion,
                ParserVersion = s_parserVersion
            };

            // Skip the header for now, it will be written last when we know all offsets.
            writer.Seek(Marshal.SizeOf(typeof(FileHeader)), SeekOrigin.Begin);

            // Save flats.
            header.Offsets.Flats = (uint)writer.BaseStream.Position;
            _flats.Serialize(writer);

            // Save records.
            header.Offsets.Records = (uint)writer.BaseStream.Position;
            SerializeRecords(writer);

            // Save queries.
            header.Offsets.Queries = (uint)writer.BaseStream.Position;
            writer.Write(0);

            // Save group tags.
            header.Offsets.GroupTags = (uint)writer.BaseStream.Position;
            writer.Write(0);

            // Now the header should be written.
            writer.Seek(0, SeekOrigin.Begin);
            writer.Write(header);
        }

        private void SerializeRecords(BinaryWriter writer)
        {
            writer.Write(_records.Count);
            foreach (var (name, type) in _records)
            {
                TweakDBID tdbid = name;
                tdbid.Serialize(writer);

                writer.Write(Murmur32.Hash(type, s_recordsSeed));
            }
        }
    }
}
