using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.Common.Services;
using CP77.CR2W.Archive;
using Newtonsoft.Json;
using WolvenKit.CR2W.Types;

namespace CP77Tools.Model
{
    public class ArTable
    {
        public uint Num { get; private set; }
        public uint Size { get; private set; }
        public ulong Checksum { get; private set; }
        public uint Table1count { get; private set; }
        public uint Table2count { get; private set; }
        public uint Table3count { get; private set; }
        public Dictionary<ulong, ArchiveItem> FileInfo { get; private set; }
        public List<OffsetEntry> Offsets { get; private set; }
        public List<HashEntry> Dependencies { get; private set; }

        public ArTable(BinaryReader br, Archive parent)
        {
            Read(br);

            FileInfo = new Dictionary<ulong, ArchiveItem>();
            Offsets = new List<OffsetEntry>();
            Dependencies = new List<HashEntry> ();

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
                    
                }
            }

            for (int i = 0; i < Table2count; i++)
            {
                Offsets.Add(new OffsetEntry(br));
            }

            for (int i = 0; i < Table3count; i++)
            {
                Dependencies.Add(new HashEntry(br));
            }
        }

        private void Read(BinaryReader br)
        {
            Num = br.ReadUInt32();
            Size = br.ReadUInt32();
            Checksum = br.ReadUInt64();
            Table1count = br.ReadUInt32();
            Table2count = br.ReadUInt32();
            Table3count = br.ReadUInt32();
        }
    }
    

    /// <summary>
    /// An entry in Table 2 (OffsetTable)
    /// </summary>
    public class OffsetEntry
    {


        public ulong Offset { get; private set; }
        public uint ZSize { get; private set; }
        public uint Size { get; private set; }

        public OffsetEntry(BinaryReader br)
        {


            Read(br);
        }

        private void Read(BinaryReader br)
        {
            Offset = br.ReadUInt64();

            ZSize = br.ReadUInt32();
            Size = br.ReadUInt32();
        }
    }

    /// <summary>
    /// An entry in Table 3 (DependencyTable)
    /// </summary>
    public class HashEntry
    {
        public string HashStr { get; private set; }

        private ulong Hash;


        public HashEntry(BinaryReader br)
        {
            var mainController = ServiceLocator.Default.ResolveType<IMainController>();

            Read(br, mainController);
            
        }

        private void Read(BinaryReader br, IMainController mainController)
        {
            Hash = br.ReadUInt64();

            if (mainController != null && mainController.Hashdict.ContainsKey(Hash))
                HashStr = mainController.Hashdict[Hash];
        }
    }

}
