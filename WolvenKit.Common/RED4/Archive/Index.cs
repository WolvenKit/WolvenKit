using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using Catel.IO;
using Catel.IoC;
using WolvenKit.RED4.CR2W.Archive;
using RED.CRC64;
using WolvenKit.Common.Services;
using ZeroFormatter;

namespace CP77Tools.Model
{

    /// <summary>
    /// An entry in Index 3 (DependencyTable)
    /// </summary>
    [ZeroFormattable]
    public class Dependency
    {
        #region Constructors

        [JsonConstructor]
        public Dependency(ulong hash)
        {
            Hash = hash;
        }

        public Dependency(BinaryReader br, int idx)
        {
            var mainController = ServiceLocator.Default.ResolveType<IHashService>();

            Read(br, mainController);
        }

        #endregion Constructors

        #region Properties

        [Index(0)] public ulong Hash { get; set; }
        [Index(1)] public string HashStr { get; private set; }

        #endregion Properties

        #region Methods

        public void Write(BinaryWriter bw)
        {
            bw.Write(Hash);
        }

        private void Read(BinaryReader br, IHashService hashService)
        {
            Hash = br.ReadUInt64();
            HashStr = hashService?.Get(Hash);
        }

        #endregion Methods
    }

    /// <summary>
    /// An entry in Index 2 (OffsetTable)
    /// </summary>
    [ZeroFormattable]
    public class FileSegment
    {
        #region Constructors

        [JsonConstructor]
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

        #endregion Constructors

        #region Properties

        [Index(0)] public int Idx { get; private set; }
        [Index(1)] public ulong Offset { get; private set; }
        [Index(2)] public uint Size { get; private set; }
        [Index(3)] public uint ZSize { get; private set; }

        #endregion Properties

        #region Methods

        public void Write(BinaryWriter bw)
        {
            bw.Write(Offset);
            bw.Write(ZSize);
            bw.Write(Size);
        }

        private void Read(BinaryReader br)
        {
            Offset = br.ReadUInt64();

            ZSize = br.ReadUInt32();
            Size = br.ReadUInt32();
        }

        #endregion Methods
    }

    [ZeroFormattable]
    public class Index
    {
        #region Constructors

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

        #endregion Constructors

        #region Properties

        [Index(0)] public ulong Crc { get; private set; }
        [Index(1)] public List<Dependency> Dependencies { get; private set; }
        [Index(2)] public Dictionary<ulong, FileEntry> FileEntries { get; private set; }
        [Index(3)] public uint FileEntryCount { get; private set; }
        [Index(4)] public uint FileSegmentCount { get; private set; }
        [Index(5)] public List<FileSegment> FileSegments { get; private set; }
        [Index(6)] public uint FileTableOffset { get; private set; }
        [Index(7)] public uint FileTableSize { get; set; }
        [Index(8)] public uint ResourceDependencyCount { get; private set; }

        #endregion Properties

        #region Methods

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

            foreach (var fileEntry in FileEntries)
            {
                var startIndex = (int)fileEntry.Value.SegmentsStart;
                var nextIndex = (int)fileEntry.Value.SegmentsEnd;

                fileEntry.Value.Size = FileSegments[startIndex].Size;
                fileEntry.Value.ZSize = FileSegments[startIndex].ZSize;

                for (var j = startIndex + 1; j < nextIndex; j++)
                {
                    fileEntry.Value.Size += FileSegments[j].Size;
                    fileEntry.Value.ZSize += FileSegments[j].ZSize;
                }
            }
        }

        #endregion Methods
    }
}
