using WolvenKit.Common.Services;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive;
public class FileEntry : ICyberGameFile
{
    private IHashService _hashService;

    #region Constructors

    public FileEntry()
    {

    }

    public FileEntry(IHashService hashService) => _hashService = hashService;

    public FileEntry(
        IHashService hashService,
        ulong hash,
        DateTime datetime,
        uint flags,
        uint segmentsStart,
        uint segmentsEnd,
        uint resourceDependenciesStart,
        uint resourceDependenciesEnd,
        byte[] sha1hash)
    {
        _hashService = hashService;

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

    public Archive Archive { get; set; }


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

    public ulong Key => NameHash64;
    public string Name => !string.IsNullOrEmpty(GetNameString()) ? GetNameString() : NameHash64.ToString();
    public string BytesAsString => BitConverter.ToString(SHA1Hash);
    public string FileName => string.IsNullOrEmpty(GetNameString()) ? $"{NameHash64}.bin" : GetNameString();
    public string NameOrHash => string.IsNullOrEmpty(GetNameString()) ? $"{NameHash64}" : GetNameString();
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

    public void SetHashService(IHashService hashService) => _hashService = hashService;


    public void Extract(Stream output) => Extract(output, false);

    public Task ExtractAsync(Stream output) => ExtractAsync(output, false);

    public void Extract(Stream output, bool decompressBuffers)
    {
        if (Archive is not ICyberGameArchive ar)
        {
            throw new InvalidParsingException($"{Archive.ArchiveAbsolutePath} is not a cyberpunk77 archive.");
        }

        ar.CopyFileToStream(output, NameHash64, decompressBuffers);
    }

    public async Task ExtractAsync(Stream output, bool decompressBuffers = false)
    {
        if (Archive is not ICyberGameArchive ar)
        {
            throw new InvalidParsingException($"{Archive.ArchiveAbsolutePath} is not a cyberpunk77 archive.");
        }

        await ar.CopyFileToStreamAsync(output, NameHash64, decompressBuffers);
    }

    private string GetNameString()
    {
        var _nameStr = _hashService?.Get(NameHash64);
        // x-platform support
        if (System.Runtime.InteropServices.RuntimeInformation
            .IsOSPlatform(System.Runtime.InteropServices.OSPlatform.OSX))
        {
            if (!string.IsNullOrEmpty(_nameStr) && _nameStr.Contains('\\'))
            {
                _nameStr = _nameStr.Replace('\\', Path.DirectorySeparatorChar);
            }
        }
        return _nameStr;
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