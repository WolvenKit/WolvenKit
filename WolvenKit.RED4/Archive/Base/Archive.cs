using System.IO.MemoryMappedFiles;
using WolvenKit.Common;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.RED4.Archive;

public class Archive : ICyberGameArchive, IDisposable
{
    private MemoryMappedFile? _mmf;

    private bool _disposed;

    #region constructors

    public Archive(string archiveAbsolutePath)
    {
        ArchiveAbsolutePath = archiveAbsolutePath;

        Header = new Header();
        Index = new Index();
        Files = new Dictionary<ulong, IGameFile>();
    }

    #endregion constructors

    #region properties

    public string ArchiveAbsolutePath { get; set; }

    public Header Header { get; set; }

    public Index Index { get; set; }

    public string ArchiveRelativePath { get; set; }

    public Dictionary<ulong, IGameFile> Files { get; }

    public string Name => Path.GetFileName(ArchiveAbsolutePath);

    public EArchiveSource Source { get; set; } = EArchiveSource.Unknown;

    public EArchiveType TypeName => EArchiveType.Archive;

    public int FileCount => Files?.Count ?? 0;

    #endregion properties

    #region methods

    public MemoryMappedViewStream GetViewStream(ulong offset, uint size)
    {
        _mmf ??= MemoryMappedFile.CreateFromFile(ArchiveAbsolutePath, FileMode.Open, null, 0, MemoryMappedFileAccess.Read);
        return _mmf.CreateViewStream((long)offset, size, MemoryMappedFileAccess.Read);
    }

    public void ReleaseFileHandle()
    {
        if (_mmf != null)
        {
            _mmf.Dispose();
            _mmf = null;
        }
    }

    public void ExtractFile(IGameFile gameFile, Stream output)
    {
        _mmf ??= MemoryMappedFile.CreateFromFile(ArchiveAbsolutePath, FileMode.Open, null, 0, MemoryMappedFileAccess.Read);
        CopyFileToStream(output, gameFile.Key, false, _mmf);
    }

    public Task ExtractFileAsync(IGameFile gameFile, Stream output)
    {
        _mmf ??= MemoryMappedFile.CreateFromFile(ArchiveAbsolutePath, FileMode.Open, null, 0, MemoryMappedFileAccess.Read);
        return CopyFileToStreamAsync(output, gameFile.Key, false, _mmf);
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="hash"></param>
    /// <returns></returns>
    public bool CanUncook(ulong hash)
    {
        if (!Files.TryGetValue(hash, out var file) || file is not FileEntry archiveItem)
        {
            return false;
        }

        var hasBuffers = (archiveItem.SegmentsEnd - archiveItem.SegmentsStart) > 1;

        var values = Enum.GetNames(typeof(ECookedFileFormat));
        var b = values.Any(e => e == archiveItem.Extension[1..]) || hasBuffers;
        return b;
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="hash"></param>
    /// <param name="decompressBuffers"></param>
    public void CopyFileToStream(Stream stream, ulong hash, bool decompressBuffers)
    {
        using var mmf = MemoryMappedFile.CreateFromFile(ArchiveAbsolutePath, FileMode.Open, null, 0, MemoryMappedFileAccess.Read);
        CopyFileToStream(stream, hash, decompressBuffers, mmf);
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="hash"></param>
    /// <param name="decompressBuffers"></param>
    public void CopyFileToStream(Stream stream, ulong hash, bool decompressBuffers, MemoryMappedFile mmf)
    {
        if (!Files.TryGetValue(hash, out var file) || file is not FileEntry archiveItem)
        {
            return;
        }

        var startIndex = (int)archiveItem.SegmentsStart;
        var nextIndex = (int)archiveItem.SegmentsEnd;

        // decompress main file
        CopyFileSegmentToStream(stream, Index.FileSegments[startIndex], true, mmf);

        //var bufferSegments = new List<FileSegment>();
        for (var j = startIndex + 1; j < nextIndex; j++)
        {
            var offsetEntry = Index.FileSegments[j];
            CopyFileSegmentToStream(stream, offsetEntry, decompressBuffers, mmf);
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="hash"></param>
    /// <param name="decompressBuffers"></param>
    public async Task CopyFileToStreamAsync(Stream stream, ulong hash, bool decompressBuffers)
    {
        using var mmf = MemoryMappedFile.CreateFromFile(ArchiveAbsolutePath, FileMode.Open, null, 0, MemoryMappedFileAccess.Read);
        await CopyFileToStreamAsync(stream, hash, decompressBuffers, mmf);
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="hash"></param>
    /// <param name="decompressBuffers"></param>
    /// <param name="mmf"></param>
    public async Task CopyFileToStreamAsync(Stream stream, ulong hash, bool decompressBuffers, MemoryMappedFile mmf)
    {
        if (!Files.TryGetValue(hash, out var file) || file is not FileEntry archiveItem)
        {
            return;
        }

        var startIndex = (int)archiveItem.SegmentsStart;
        var nextIndex = (int)archiveItem.SegmentsEnd;

        // decompress main file
        await CopyFileSegmentToStreamAsync(stream, Index.FileSegments[startIndex], true, mmf);

        //var bufferSegments = new List<FileSegment>();
        for (var j = startIndex + 1; j < nextIndex; j++)
        {
            var offsetEntry = Index.FileSegments[j];
            await CopyFileSegmentToStreamAsync(stream, offsetEntry, decompressBuffers, mmf);
        }
    }


    /// <summary>
    /// Extracts a FileSegment from the archive to a stream
    /// </summary>
    /// <param name="outStream"></param>
    /// <param name="offsetEntry"></param>
    /// <param name="decompress"></param>
    private void CopyFileSegmentToStream(Stream outStream, FileSegment offsetEntry, bool decompress, MemoryMappedFile mmf)
    {
        var zSize = offsetEntry.ZSize;

        using var vs = mmf.CreateViewStream((long)offsetEntry.Offset, zSize, MemoryMappedFileAccess.Read);
        if (!decompress)
        {
            vs.CopyTo(outStream);
        }
        else
        {
            var size = offsetEntry.Size;
            vs.DecompressAndCopySegment(outStream, zSize, size);
        }
        vs.Dispose();
    }

    /// <summary>
    /// Extracts a FileSegment from the archive to a stream
    /// </summary>
    /// <param name="outStream"></param>
    /// <param name="offsetEntry"></param>
    /// <param name="decompress"></param>
    private async Task CopyFileSegmentToStreamAsync(Stream outStream, FileSegment offsetEntry, bool decompress, MemoryMappedFile mmf)
    {
        var zSize = offsetEntry.ZSize;

        await using var vs = mmf.CreateViewStream((long)offsetEntry.Offset, zSize, MemoryMappedFileAccess.Read);
        if (!decompress)
        {
            await vs.CopyToAsync(outStream);
        }
        else
        {
            var size = offsetEntry.Size;
            await vs.DecompressAndCopySegmentAsync(outStream, zSize, size);
        }
        await vs.DisposeAsync();
    }

    #region IDisposable

    public void Dispose()
    {
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _mmf?.Dispose();
            }

            _disposed = true;
        }
    }

    ~Archive()
    {
        Dispose(disposing: false);
    }

    #endregion

    #endregion methods
}