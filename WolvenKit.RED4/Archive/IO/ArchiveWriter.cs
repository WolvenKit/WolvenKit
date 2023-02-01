using System.Security.Cryptography;
using System.Text.RegularExpressions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Core.Compression;
using WolvenKit.Core.CRC;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;

namespace WolvenKit.RED4.Archive.IO;

public class ArchiveWriter
{
    public ILoggerService LoggerService { get; set; }

    #region Fields

    // The first 4 files need to be aligned to 0x1000, added .bin because of unknown file type
    private static readonly List<string> s_alignedFiles = new()
    {
        ".bk2",
        ".bnk",
        ".opusinfo",
        ".wem",
        ".bin"
    };

    // same as above + dat and opuspak, (only one .dat, don't know if it can be compressed)
    private static readonly List<string> s_uncompressedFiles = new()
    {
        ".bk2",
        ".bnk",
        ".opusinfo",
        ".wem",
        ".bin",
        ".dat",
        ".opuspak"
    };

    private readonly IHashService _hashService;

    #endregion

    public ArchiveWriter(IHashService hashService)
    {
        _hashService = hashService;
    }

    public Archive WriteArchive(DirectoryInfo infolder, DirectoryInfo outpath, string modname = null)
    {
        if (!infolder.Exists)
        {
            return null;
        }

        if (!outpath.Exists)
        {
            return null;
        }

        if (LoggerService != null && !CompressionSettings.Get().UseOodle)
        {
            LoggerService.Warning("Oodle couldn't be loaded. Using Kraken.dll instead could cause errors.");
        }

        // get files
        var includedExtensions = Enum.GetNames<ERedExtension>().ToList();
        includedExtensions.Add("bin");
        var allfiles = infolder.GetFiles("*", SearchOption.AllDirectories);
        var parentfiles = allfiles
            .Where(_ => includedExtensions.Any(x => _.Extension.TrimStart('.').ToLower() == x));
        var fileInfos = parentfiles
            .OrderBy(_ => FNV1A64HashAlgorithm.HashString(_.FullName[(infolder.FullName.Length + 1)..]))
            .ToList();

        var customPaths = (from fileInfo in fileInfos
                           select fileInfo.FullName[(infolder.FullName.Length + 1)..]
                           into relpath
                           let hash = FNV1A64HashAlgorithm.HashString(relpath)
                           where !_hashService.Contains(hash)
                           select relpath).ToList();


        var outfile = Path.Combine(outpath.FullName, $"{infolder.Name}.archive");
        if (modname != null)
        {
            outfile = Path.Combine(outpath.FullName, $"{modname}.archive");
        }

        var ar = new Archive { ArchiveAbsolutePath = outfile };
        using var fs = new FileStream(outfile, FileMode.Create);
        using var bw = new BinaryWriter(fs);

        #region write header

        WriteHeader(bw, ar.Header);
        bw.Write(new byte[132]); // some weird padding


        #region write custom data

        long customDataLength = 0;
        if (customPaths.Count > 0)
        {
            var wfooter = new LxrsFooter(customPaths);
            wfooter.Write(bw);
            customDataLength = bw.BaseStream.Position - Header.EXTENDED_SIZE;
        }

        #endregion

        #endregion write header

        #region write files

        HashSet<ulong> importsHashSet = new();
        var regex = new Regex("^(\\d+)\\.");

        var progress = 0;
        foreach (var fileInfo in fileInfos)
        {
            var relpath = fileInfo.FullName[(infolder.FullName.Length + 1)..];

            ulong hash;
            var match = regex.Match(relpath);
            if (match.Success)
            {
                if (!ulong.TryParse(match.Groups[1].Value, out hash))
                {
                    continue;
                }
            }
            else
            {
                hash = FNV1A64HashAlgorithm.HashString(relpath);
            }

            if (!_hashService.Contains(hash))
            {
                if (!_hashService.GetMissingHashes().Contains(hash))
                {
                    customPaths.Add(relpath);
                }
            }

            using var fileStream = new FileStream(fileInfo.FullName, FileMode.Open);
            using var fileBinaryReader = new BinaryReader(fileStream);
            using var reader = new CR2WReader(fileBinaryReader);

            // fileinfo data
            var firstimportidx = (uint)importsHashSet.Count;
            var lastimportidx = (uint)importsHashSet.Count;
            var firstoffsetidx = (uint)ar.Index.FileSegments.Count;
            uint lastoffsetidx;
            var flags = 0;

            if (reader.ReadFileInfo(out var info) == EFileReadErrorCodes.NoError)
            {
                // kraken the file and write
                var cr2wfilesize = (int)info.FileHeader.objectsEnd;
                fileBinaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                var cr2winbuffer = fileBinaryReader.ReadBytes(cr2wfilesize);
                var offset = bw.BaseStream.Position;

                var (zsize, _) = CompressAndWrite(bw, cr2winbuffer);
                ar.Index.FileSegments.Add(new FileSegment(
                    (ulong)offset,
                    zsize,
                    (uint)cr2winbuffer.Length));

                var savedSpace = cr2winbuffer.Length - zsize;

                // HINT: each cr2w needs to have the buffer already kraken'd
                // foreach buffer write
                foreach (var bufferInfo in info.BufferInfo)
                {
                    var bufferBuffer = fileBinaryReader.ReadBytes((int)bufferInfo.diskSize);

                    var bsize = bufferInfo.memSize;
                    var bzsize = bufferInfo.diskSize;
                    var boffset = bw.BaseStream.Position;

                    bw.Write(bufferBuffer);
                    ar.Index.FileSegments.Add(new FileSegment(
                        (ulong)boffset,
                        bzsize,
                        bsize));
                }

                //register imports
                foreach (var cr2WImportWrapper in reader.ImportsList)
                {
                    if (cr2WImportWrapper.Flags != WolvenKit.RED4.Types.InternalEnums.EImportFlags.Soft)
                    {
                        importsHashSet.Add(FNV1A64HashAlgorithm.HashString(cr2WImportWrapper.DepotPath));
                    }
                }

                lastimportidx = (uint)importsHashSet.Count;

                lastoffsetidx = (uint)ar.Index.FileSegments.Count;

                flags = info.BufferInfo.Length > 0 ? info.BufferInfo.Length - 1 : 0;
            }
            else
            {
                fileStream.Seek(0, SeekOrigin.Begin);
                var cr2winbuffer = fileStream.ToByteArray();
                var offset = (ulong)bw.BaseStream.Position;
                var size = (uint)cr2winbuffer.Length;

                if (s_alignedFiles.Contains(fileInfo.Extension.ToLower()))
                {
                    bw.PadUntilPage();
                    offset = (ulong)bw.BaseStream.Position;
                }

                if (s_uncompressedFiles.Contains(fileInfo.Extension.ToLower()))
                {
                    bw.Write(cr2winbuffer);
                    ar.Index.FileSegments.Add(new FileSegment(offset, size, size));
                }
                else
                {
                    // kraken the file and write
                    var (zsize, _) = CompressAndWrite(bw, cr2winbuffer);
                    ar.Index.FileSegments.Add(new FileSegment(offset, zsize, size));
                }

                lastoffsetidx = (uint)ar.Index.FileSegments.Count;
            }

            // save table data
            using var sha1 = SHA1.Create();
            var sha1hash =
                sha1.ComputeHash(fileBinaryReader.BaseStream
                    .ToByteArray()); //TODO: this is only correct for files with no buffer
            var item = new FileEntry(
                _hashService,
                hash,
                DateTime.Now,
                (uint)flags,
                firstoffsetidx,
                lastoffsetidx,
                firstimportidx,
                lastimportidx,
                sha1hash);
            ar.Index.FileEntries.Add(hash, item);

            Interlocked.Increment(ref progress);
        }

        ar.Index.Dependencies = importsHashSet.Select(_ => new Dependency(_)).ToList();


        #endregion write files

        #region write footer

        bw.PadUntilPage();

        // write tables
        var tableoffset = bw.BaseStream.Position;
        WriteIndex(bw, ar.Index);
        var tablesize = bw.BaseStream.Position - tableoffset;

        // padding to page (4096 bytes)
        bw.PadUntilPage();
        var filesize = bw.BaseStream.Position;

        #endregion write footer


        // write the header again
        ar.Header.IndexPosition = (ulong)tableoffset;
        ar.Header.IndexSize = (uint)tablesize;
        ar.Header.Filesize = (ulong)filesize;
        bw.BaseStream.Seek(0, SeekOrigin.Begin);
        WriteHeader(bw, ar.Header);
        bw.Write(customDataLength);

        return ar;
    }

    private void WriteDependency(BinaryWriter bw, Dependency dependency) => bw.Write(dependency.Hash);

    private void WriteIndex(BinaryWriter bw, Index index)
    {
        // write the table to a stream to calculate the size
        using var ms = new MemoryStream();
        using var tablewriter = new BinaryWriter(ms);

        index.FileEntryCount = (uint)index.FileEntries.Count;
        index.FileSegmentCount = (uint)index.FileSegments.Count;
        index.ResourceDependencyCount = (uint)index.Dependencies.Count;
        //tablewriter.Write(Crc);
        tablewriter.Write(index.FileEntryCount);
        tablewriter.Write(index.FileSegmentCount);
        tablewriter.Write(index.ResourceDependencyCount);

        foreach (var archiveItem in index.FileEntries)
        {
            WriteFileEntry(tablewriter, archiveItem.Value);
        }

        foreach (var offsetEntry in index.FileSegments)
        {
            WriteFileSegment(tablewriter, offsetEntry);
        }

        foreach (var dependency in index.Dependencies)
        {
            WriteDependency(tablewriter, dependency);
        }

        index.FileTableOffset = 8; //TODO
        bw.Write(index.FileTableOffset);
        bw.Write((uint)ms.Length + 8);
        //crc64 calculate
        bw.Write(Crc64.Compute(tablewriter.BaseStream.ToByteArray()));
        bw.Write(tablewriter.BaseStream.ToByteArray());
    }

    private void WriteHeader(BinaryWriter bw, Header header)
    {
        bw.Write(Header.MAGIC);
        bw.Write(header.Version);
        bw.Write(header.IndexPosition);
        bw.Write(header.IndexSize);
        bw.Write(header.DebugPosition);
        bw.Write(header.DebugSize);
        bw.Write(header.Filesize);
    }

    private void WriteFileSegment(BinaryWriter bw, FileSegment fileSegment)
    {
        bw.Write(fileSegment.Offset);
        bw.Write(fileSegment.ZSize);
        bw.Write(fileSegment.Size);
    }

    private void WriteFileEntry(BinaryWriter bw, FileEntry fileEntry)
    {
        bw.Write(fileEntry.NameHash64);
        bw.Write(fileEntry.Timestamp.ToFileTime());
        bw.Write(fileEntry.NumInlineBufferSegments);
        bw.Write(fileEntry.SegmentsStart);
        bw.Write(fileEntry.SegmentsEnd);
        bw.Write(fileEntry.ResourceDependenciesStart);
        bw.Write(fileEntry.ResourceDependenciesEnd);
        bw.Write(fileEntry.SHA1Hash);
    }

    private (uint, uint) CompressAndWrite(BinaryWriter bw, byte[] inbuffer)
    {
        var size = (uint)inbuffer.Length;
        if (size < 256)
        {
            var crc = Crc32Algorithm.Compute(inbuffer);
            bw.Write(inbuffer);

            return (size, crc);
        }
        else
        {
            IEnumerable<byte> outBuffer = new List<byte>();
            var r = Oodle.Compress(inbuffer, ref outBuffer, true);

            var b = outBuffer.ToArray();

            var crc = Crc32Algorithm.Compute(b);
            bw.Write(b);

            return ((uint)r, crc);
        }
    }
}
