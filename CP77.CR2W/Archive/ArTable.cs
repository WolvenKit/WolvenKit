using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IO;
using Catel.IoC;
using CP77.Common.Services;
using CP77.CR2W.Archive;
using Newtonsoft.Json;
using WolvenKit.CR2W.Types;
using RED.CRC64;

namespace CP77Tools.Model
{
    public class ArTable
    {
        public uint Num { get; private set; }
        public uint Size { get; set; }
        public ulong Checksum { get; private set; }
        public uint Table1count { get; private set; }
        public uint Table2count { get; private set; }
        public uint Table3count { get; private set; }
        public Dictionary<ulong, ArchiveItem> FileInfo { get; private set; }
        public List<OffsetEntry> Offsets { get; private set; }
        public List<HashEntry> Dependencies { get; private set; }

        public ArTable()
        {
            Offsets = new List<OffsetEntry>();
            Dependencies = new List<HashEntry>();
            FileInfo = new Dictionary<ulong, ArchiveItem>();
        }
        
        public ArTable(BinaryReader br, Archive parent)
        {
            FileInfo = new Dictionary<ulong, ArchiveItem>();
            Offsets = new List<OffsetEntry>();
            Dependencies = new List<HashEntry>();


            Read(br, parent);
        }

        private void Read(BinaryReader br, Archive parent)
        {
            Num = br.ReadUInt32();
            Size = br.ReadUInt32();
            Checksum = br.ReadUInt64();
            Table1count = br.ReadUInt32();
            Table2count = br.ReadUInt32();
            Table3count = br.ReadUInt32();

            // read tables
            for (int i = 0; i < Table1count; i++)
            {
                var entry = new ArchiveItem(br, parent);

                if (!FileInfo.ContainsKey(entry.NameHash64))
                {
                    FileInfo.Add(entry.NameHash64, entry);
                }
                else
                {
                    // TODO
                }
            }

            for (int i = 0; i < Table2count; i++)
            {
                Offsets.Add(new OffsetEntry(br, i));
            }

            for (int i = 0; i < Table3count; i++)
            {
                Dependencies.Add(new HashEntry(br, i));
            }
        }

        public void Write(BinaryWriter bw)
        {
            // write the table to a stream to calculate the size
            using var ms = new MemoryStream();
            using var tablewriter = new BinaryWriter(ms);
            
            Table1count = (uint)FileInfo.Count;
            Table2count = (uint)Offsets.Count;
            Table3count = (uint)Dependencies.Count;
            //tablewriter.Write(Checksum);
            tablewriter.Write(Table1count);
            tablewriter.Write(Table2count);
            tablewriter.Write(Table3count);

            foreach (var archiveItem in FileInfo)
            {
                archiveItem.Value.Write(tablewriter);
            }

            foreach (var offsetEntry in Offsets)
            {
                offsetEntry.Write(tablewriter);
            }

            foreach (var dependency in Dependencies)
            {
                dependency.Write(tablewriter);
            }

            Num = 8; //TODO
            bw.Write(Num);
            bw.Write((uint)ms.Length + 8);
            //crc64 calculate
            bw.Write(Crc64.Compute(tablewriter.BaseStream.ToByteArray()));
            bw.Write(tablewriter.BaseStream.ToByteArray());
        }
    }
    

    /// <summary>
    /// An entry in Table 2 (OffsetTable)
    /// </summary>
    public class OffsetEntry
    {
        public int Idx { get; private set; }

        public ulong Offset { get; private set; }
        public uint ZSize { get; private set; }
        public uint Size { get; private set; }

        public OffsetEntry(ulong offset, uint zsize, uint size)
        {
            Offset = offset;
            ZSize = zsize;
            Size = size;
        }
        
        public OffsetEntry(BinaryReader br, int idx)
        {
            Idx = idx;

            Read(br);
        }

        private void Read(BinaryReader br)
        {
            Offset = br.ReadUInt64();

            ZSize = br.ReadUInt32();
            Size = br.ReadUInt32();
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(Offset);
            bw.Write(ZSize);
            bw.Write(Size);
        }
    }

    /// <summary>
    /// An entry in Table 3 (DependencyTable)
    /// </summary>
    public class HashEntry
    {
        
        public string HashStr { get; private set; }

        private ulong _hash;
        [JsonProperty]
        private int _idx;
        
        public HashEntry(ulong hash)
        {
            _hash = hash;
        }
        
        public HashEntry(BinaryReader br, int idx)
        {
            _idx = idx;
            var mainController = ServiceLocator.Default.ResolveType<IMainController>();

            Read(br, mainController);
            
        }

        private void Read(BinaryReader br, IMainController mainController)
        {
            _hash = br.ReadUInt64();

            if (mainController != null && mainController.Hashdict.ContainsKey(_hash))
                HashStr = mainController.Hashdict[_hash];
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(_hash);
        }
    }

}
