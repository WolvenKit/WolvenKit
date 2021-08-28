using System.IO;
using System.Runtime.InteropServices;
using WolvenKit.Core.Extensions;
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
        private static readonly uint s_magic = 0xBB1DB47;
        private static readonly uint s_blobVersion = 5;
        private static readonly uint s_parserVersion = 4;

        private readonly FlatsPool _flats = new();

        /// <summary>
        /// Add a new flat value to the pool.
        /// </summary>
        /// <param name="name">The flat's name.</param>
        /// <param name="value">The value.</param>
        public void Add(string name, IType value) => _flats.Add(name, value);

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
            writer.Write(0);

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
    }

    public class TweakFlatDto
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public object Value { get; set; }
    }

    public enum EIType
    {
        CName,
        CString,
        CFloat,
        CBool,
        CUint8,
        CUint16,
        CUint32,
        CUint64,
        CInt8,
        CInt16,
        CInt32,
        CInt64
    }
}
