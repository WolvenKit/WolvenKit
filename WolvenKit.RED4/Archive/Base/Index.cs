using System.Collections.Generic;
using ProtoBuf;

namespace WolvenKit.RED4.Archive
{

    /// <summary>
    /// An entry in Index 3 (DependencyTable)
    /// </summary>
    [ProtoContract]
    public struct Dependency
    {
        #region Constructors

        //private IHashService _hashService;

        //public Dependency()
        //{

        //}

        //public Dependency(IHashService hashService)
        //{
        //    _hashService = hashService;
        //}

        //public Dependency(IHashService hashService, ulong hash)
        //{
        //    _hashService = hashService;
        //    Hash = hash;
        //}

        public Dependency(ulong hash)
        {
            Hash = hash;
        }

        #endregion Constructors

        #region Properties

        [ProtoMember(1)] public ulong Hash { get; set; }
        ///*[ProtoMember(2)]*/ public string HashStr => _hashService != null ? _hashService.Get(Hash) : Hash.ToString();

        #endregion Properties
    }

    /// <summary>
    /// An entry in Index 2 (OffsetTable)
    /// </summary>
    [ProtoContract]
    public struct FileSegment
    {
        #region Constructors

        //public FileSegment()
        //{

        //}

        public FileSegment(ulong offset, uint zsize, uint size)
        {
            Offset = offset;
            ZSize = zsize;
            Size = size;
        }

        #endregion Constructors

        #region Properties

        [ProtoMember(1)] public ulong Offset { get; set; }
        [ProtoMember(2)] public uint Size { get; set; }
        [ProtoMember(3)] public uint ZSize { get; set; }

        #endregion Properties
    }

    [ProtoContract]
    public class Index
    {
        #region Constructors

        public Index()
        {
            FileSegments = new List<FileSegment>();
            Dependencies = new List<Dependency>();
            FileEntries = new Dictionary<ulong, FileEntry>();
        }

        #endregion Constructors

        #region Properties

        [ProtoMember(1)] public ulong Crc { get; set; }
        [ProtoMember(2)] public List<Dependency> Dependencies { get; set; }
        [ProtoMember(3)] public Dictionary<ulong, FileEntry> FileEntries { get; set; }
        [ProtoMember(4)] public uint FileEntryCount { get; set; }
        [ProtoMember(5)] public uint FileSegmentCount { get; set; }
        [ProtoMember(6)] public List<FileSegment> FileSegments { get; set; }
        [ProtoMember(7)] public uint FileTableOffset { get; set; }
        [ProtoMember(8)] public uint FileTableSize { get; set; }
        [ProtoMember(9)] public uint ResourceDependencyCount { get; set; }

        #endregion Properties
    }
}
