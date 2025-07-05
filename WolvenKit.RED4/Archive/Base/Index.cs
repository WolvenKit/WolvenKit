namespace WolvenKit.RED4.Archive;

/// <summary>
/// An entry in Index 3 (DependencyTable)
/// </summary>
public struct Dependency
{ 
    public Dependency(ulong hash)
    {
        Hash = hash;
    }
    public ulong Hash { get; set; }
}

/// <summary>
/// An entry in Index 2 (OffsetTable)
/// </summary>
public struct FileSegment
{
    public FileSegment(ulong offset, uint zsize, uint size)
    {
        Offset = offset;
        ZSize = zsize;
        Size = size;
    }

    public ulong Offset { get; set; }
    public uint Size { get; set; }
    public uint ZSize { get; set; }
}

public class Index
{
    public Index()
    {
        FileSegments = new List<FileSegment>();
        Dependencies = new List<Dependency>();
        FileEntries = new Dictionary<ulong, FileEntry>();
    }

    public ulong Crc { get; set; }
    public List<Dependency> Dependencies { get; set; }
    public Dictionary<ulong, FileEntry> FileEntries { get; set; }
    public uint FileEntryCount { get; set; }
    public uint FileSegmentCount { get; set; }
    public List<FileSegment> FileSegments { get; set; }
    public uint FileTableOffset { get; set; }
    public uint FileTableSize { get; set; }
    public uint ResourceDependencyCount { get; set; }
}