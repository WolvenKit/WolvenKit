using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IO;
using Catel.IoC;
using WolvenKit.Common.Services;
using CP77.CR2W.Archive;
using Newtonsoft.Json;
using CP77.CR2W.Types;
using RED.CRC64;

namespace CP77Tools.Model
{
    public class Index
    {
        public uint FileTableOffset { get; private set; }
        public uint FileTableSize { get; set; }


        public ulong Crc { get; private set; }
        public uint FileEntryCount { get; private set; }
        public uint FileSegmentCount { get; private set; }
        public uint ResourceDependencyCount { get; private set; }

        public Dictionary<ulong, FileEntry> FileEntries { get; private set; }
        public List<FileSegment> FileSegments { get; private set; }
        public List<Dependency> Dependencies { get; private set; }

        public Index()
        {
            FileSegments = new List<FileSegment>();
            Dependencies = new List<Dependency>();
            FileEntries = new Dictionary<ulong, FileEntry>();
        }
        
        public Index(BinaryReader br, Archive parent)
        {
            FileEntries = new Dictionary<ulong, FileEntry>();
            FileSegments = new List<FileSegment>();
            Dependencies = new List<Dependency>();


            Read(br, parent);
        }

        private void Read(BinaryReader br, Archive parent)
        {
            FileTableOffset = br.ReadUInt32();
            FileTableSize = br.ReadUInt32();

            Crc = br.ReadUInt64();
            FileEntryCount = br.ReadUInt32();
            FileSegmentCount = br.ReadUInt32();
            ResourceDependencyCount = br.ReadUInt32();

            // read tables
            for (int i = 0; i < FileEntryCount; i++)
            {
                var entry = new FileEntry(br, parent);

                if (!FileEntries.ContainsKey(entry.NameHash64))
                {
                    FileEntries.Add(entry.NameHash64, entry);
                }
                else
                {
                    // TODO
                }
            }

            for (int i = 0; i < FileSegmentCount; i++)
            {
                FileSegments.Add(new FileSegment(br, i));
            }

            for (int i = 0; i < ResourceDependencyCount; i++)
            {
                Dependencies.Add(new Dependency(br, i));
            }
        }

        public void Write(BinaryWriter bw)
        {
            // write the table to a stream to calculate the size
            using var ms = new MemoryStream();
            using var tablewriter = new BinaryWriter(ms);
            
            FileEntryCount = (uint)FileEntries.Count;
            FileSegmentCount = (uint)FileSegments.Count;
            ResourceDependencyCount = (uint)Dependencies.Count;
            //tablewriter.Write(Crc);
            tablewriter.Write(FileEntryCount);
            tablewriter.Write(FileSegmentCount);
            tablewriter.Write(ResourceDependencyCount);

            foreach (var archiveItem in FileEntries)
            {
                archiveItem.Value.Write(tablewriter);
            }

            foreach (var offsetEntry in FileSegments)
            {
                offsetEntry.Write(tablewriter);
            }

            foreach (var dependency in Dependencies)
            {
                dependency.Write(tablewriter);
            }

            FileTableOffset = 8; //TODO
            bw.Write(FileTableOffset);
            bw.Write((uint)ms.Length + 8);
            //crc64 calculate
            bw.Write(Crc64.Compute(tablewriter.BaseStream.ToByteArray()));
            bw.Write(tablewriter.BaseStream.ToByteArray());
        }
    }
    

    /// <summary>
    /// An entry in Index 2 (OffsetTable)
    /// </summary>
    public class FileSegment
    {
        public int Idx { get; private set; }

        public ulong Offset { get; private set; }
        public uint ZSize { get; private set; }
        public uint Size { get; private set; }

        public FileSegment(ulong offset, uint zsize, uint size)
        {
            Offset = offset;
            ZSize = zsize;
            Size = size;
        }
        
        public FileSegment(BinaryReader br, int idx)
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
    /// An entry in Index 3 (DependencyTable)
    /// </summary>
    public class Dependency
    {
        
        public string HashStr { get; private set; }

        private ulong _hash;
        [JsonProperty]
        private int _idx;
        
        public Dependency(ulong hash)
        {
            _hash = hash;
        }
        
        public Dependency(BinaryReader br, int idx)
        {
            _idx = idx;
            var mainController = ServiceLocator.Default.ResolveType<IHashService>();

            Read(br, mainController);
            
        }

        private void Read(BinaryReader br, IHashService hashService)
        {
            _hash = br.ReadUInt64();
            HashStr = hashService?.Get(_hash);
        }

        public void Write(BinaryWriter bw)
        {
            bw.Write(_hash);
        }
    }

}
