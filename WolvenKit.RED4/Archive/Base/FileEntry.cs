using WolvenKit.Common;
using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types.Exceptions;
using WolvenKit.RED4.Types.Pools;

namespace WolvenKit.RED4.Archive;
public class FileEntry : ICyberGameFile
{
    #region Constructors

    public FileEntry()
    {

    }

    public FileEntry(
        ulong hash,
        DateTime datetime,
        uint flags,
        uint segmentsStart,
        uint segmentsEnd,
        uint resourceDependenciesStart,
        uint resourceDependenciesEnd,
        byte[] sha1hash)
    {
        NameHash64 = hash;
        Timestamp = datetime;
        NumInlineBufferSegments = flags;
        ResourceDependenciesStart = resourceDependenciesStart;
        ResourceDependenciesEnd = resourceDependenciesEnd;
        SegmentsStart = segmentsStart;
        SegmentsEnd = segmentsEnd;
        SHA1Hash = sha1hash;
    }

    #endregion Constructors

    #region Properties

    public ICyberGameArchive Archive { get; set; }

    public ulong NameHash64 { get; set; }
    public DateTime Timestamp { get; set; }
    public uint NumInlineBufferSegments { get; set; }
    public uint SegmentsStart { get; set; }
    public uint SegmentsEnd { get; set; }
    public uint ResourceDependenciesStart { get; set; }
    public uint ResourceDependenciesEnd { get; set; }
    public byte[] SHA1Hash { get; set; }
    public uint Size { get; set; }
    public uint ZSize { get; set; }
    public string GuessedExtension { get; set; }

    public ArchiveManagerScope Scope { get; set; }

    public ulong Key => NameHash64;
    public string Name => GetNameString(NameHash64.ToString())!;
    public string BytesAsString => BitConverter.ToString(SHA1Hash);
    public string FileName => GetNameString($"{NameHash64}.bin")!;
    public string NameOrHash => GetNameString(NameHash64.ToString())!;
    public string Extension => GetExtension();

    public string ShortName => Path.GetFileName(FileName);

    #endregion Properties

    #region Methods

    public string GetExtension()
    {
        var ext = Path.GetExtension(FileName);
        if (ext == ".bin" && GuessedExtension != null)
        {
            ext = GuessedExtension;
        }

        return ext;
    }


    public void Extract(Stream output) => Extract(output, false);

    public Task ExtractAsync(Stream output) => ExtractAsync(output, false);

    public void Extract(Stream output, bool decompressBuffers)
    {
        if (Archive is not { } ar)
        {
            throw new InvalidParsingException($"{Archive.ArchiveAbsolutePath} is not a cyberpunk77 archive.");
        }

        ar.CopyFileToStream(output, NameHash64, decompressBuffers);
    }

    public async Task ExtractAsync(Stream output, bool decompressBuffers)
    {
        if (Archive is not { } ar)
        {
            throw new InvalidParsingException($"{Archive.ArchiveAbsolutePath} is not a cyberpunk77 archive.");
        }

        await ar.CopyFileToStreamAsync(output, NameHash64, decompressBuffers);
    }

    private string? GetNameString(string? defaultStr = null)
    {
        var nameStr = ResourcePathPool.ResolveHash(NameHash64);
        if (nameStr == null)
        {
            return defaultStr;
        }

        // x-platform support
        if (System.Runtime.InteropServices.RuntimeInformation
            .IsOSPlatform(System.Runtime.InteropServices.OSPlatform.OSX))
        {
            if (!string.IsNullOrEmpty(nameStr) && nameStr.Contains('\\'))
            {
                nameStr = nameStr.Replace('\\', Path.DirectorySeparatorChar);
            }
        }
        return nameStr;
    }



    #endregion Methods

    public override string ToString() => ShortName;

    public IGameArchive GetArchive() => Archive;

    public T GetArchive<T>() where T : IGameArchive
    {
        if (Archive is T ta)
        {
            return ta;
        }
        throw new ArgumentException();
    }
}