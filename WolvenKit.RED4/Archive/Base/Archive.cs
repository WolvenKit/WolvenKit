using System.IO.MemoryMappedFiles;
using WolvenKit.Common;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.RED4.Archive;

public class Archive : ICyberGameArchive, IDisposable
{
    private MemoryMappedFile _mmf;
    private bool _bulkExtract;
    private int _handleCount;

    private bool _disposed;

    #region constructors

    public Archive()
    {
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

    public EArchiveType TypeName => EArchiveType.Archive;

    public int FileCount => Files?.Count ?? 0;

    #endregion properties

    #region methods

    public MemoryMappedViewStream GetViewStream(ulong offset, uint size)
    {
        _mmf = MemoryMappedFile.CreateFromFile(ArchiveAbsolutePath, FileMode.Open, null, 0, MemoryMappedFileAccess.Read);
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

    public void SetBulkExtract(bool enable)
    {
        _bulkExtract = enable;

        if (enable && _mmf == null)
        {
            _mmf = MemoryMappedFile.CreateFromFile(ArchiveAbsolutePath, FileMode.Open, null, 0, MemoryMappedFileAccess.Read);
        }

        if (!enable && _mmf != null)
        {
            _mmf.Dispose();
            _mmf = null;
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="hash"></param>
    /// <returns></returns>
    public bool CanUncook(ulong hash)
    {
        if (!Files.ContainsKey(hash))
        {
            return false;
        }

        var archiveItem = Files[hash] as FileEntry;
        var hasBuffers = (archiveItem.SegmentsEnd - archiveItem.SegmentsStart) > 1;

        var values = Enum.GetNames(typeof(ECookedFileFormat));
        var b = values.Any(e => e == archiveItem.Extension) || hasBuffers;
        return b;
    }

    public void CopyFileToStreamWithoutBuffers(Stream stream, ulong hash)
    {
        if (!Files.ContainsKey(hash))
        {
            return;
        }

        var entry = Files[hash] as FileEntry;
        var startIndex = (int)entry.SegmentsStart;
        var nextIndex = (int)entry.SegmentsEnd;

        // decompress main file
        CopyFileSegmentToStream(stream, Index.FileSegments[startIndex], true);
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="stream"></param>
    /// <param name="hash"></param>
    /// <param name="decompressBuffers"></param>
    public void CopyFileToStream(Stream stream, ulong hash, bool decompressBuffers)
    {
        if (!Files.ContainsKey(hash))
        {
            return;
        }

        var entry = Files[hash] as FileEntry;
        var startIndex = (int)entry.SegmentsStart;
        var nextIndex = (int)entry.SegmentsEnd;

        // decompress main file
        CopyFileSegmentToStream(stream, Index.FileSegments[startIndex], true);

        //var bufferSegments = new List<FileSegment>();
        for (var j = startIndex + 1; j < nextIndex; j++)
        {
            var offsetEntry = Index.FileSegments[j];
            CopyFileSegmentToStream(stream, offsetEntry, decompressBuffers);
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
        if (!Files.ContainsKey(hash))
        {
            return;
        }

        var entry = Files[hash] as FileEntry;
        var startIndex = (int)entry.SegmentsStart;
        var nextIndex = (int)entry.SegmentsEnd;

        // decompress main file
        await CopyFileSegmentToStreamAsync(stream, Index.FileSegments[startIndex], true);

        //var bufferSegments = new List<FileSegment>();
        for (var j = startIndex + 1; j < nextIndex; j++)
        {
            var offsetEntry = Index.FileSegments[j];
            await CopyFileSegmentToStreamAsync(stream, offsetEntry, decompressBuffers);
        }
    }


    /// <summary>
    /// Extracts a FileSegment from the archive to a stream
    /// </summary>
    /// <param name="outStream"></param>
    /// <param name="offsetEntry"></param>
    /// <param name="decompress"></param>
    private void CopyFileSegmentToStream(Stream outStream, FileSegment offsetEntry, bool decompress)
    {
        var zSize = offsetEntry.ZSize;

        if (!_bulkExtract)
        {
            _handleCount++;
        }

        using var vs = GetViewStream(offsetEntry.Offset, zSize);
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

        if (!_bulkExtract)
        {
            _handleCount--;
            if (_handleCount == 0)
            {
                ReleaseFileHandle();
            }
        }
    }

    /// <summary>
    /// Extracts a FileSegment from the archive to a stream
    /// </summary>
    /// <param name="outStream"></param>
    /// <param name="offsetEntry"></param>
    /// <param name="decompress"></param>
    private async Task CopyFileSegmentToStreamAsync(Stream outStream, FileSegment offsetEntry, bool decompress)
    {
        var zSize = offsetEntry.ZSize;

        if (!_bulkExtract)
        {
            _handleCount++;
        }

        await using var vs = GetViewStream(offsetEntry.Offset, zSize);
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

        if (!_bulkExtract)
        {
            _handleCount--;
            if (_handleCount == 0)
            {
                ReleaseFileHandle();
            }
        }
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
                _mmf.Dispose();
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