using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Core.Compression;
using WolvenKit.Core.CRC;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO;

public class ArchiveWriter
{
    private readonly ILoggerService _loggerService;

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

    public ArchiveWriter(IHashService hashService, ILoggerService loggerService)
    {
        _hashService = hashService;
        _loggerService = loggerService;
    }

    private record FileInfoEntry(string RelPath, FileInfo FileInfo);

    public bool WriteArchive(DirectoryInfo infolder, Stream outStream)
    {
        infolder = new DirectoryInfo(Path.GetFullPath(infolder.FullName).TrimEnd('\\'));
        if (!infolder.Exists)
        {
            return false;
        }

        if (!CompressionSettings.Get().UseOodle)
        {
            _loggerService.Warning("Oodle couldn't be loaded. Using Kraken.dll instead could cause errors.");
        }

        var regex = new Regex("^(\\d+)\\.");

        // get files
        var supportedExtensions = Enum.GetNames<ERedExtension>().ToList();
        supportedExtensions.Add("bin");

        var customPaths = new List<string>();

        var fileDict = new Dictionary<ulong, List<FileInfoEntry>>();
        foreach (var fileInfo in infolder.GetFiles("*", SearchOption.AllDirectories))
        {
            var relPath = fileInfo.FullName[(infolder.FullName.Length + 1)..];

            if (fileInfo.Extension.Length == 0 || !supportedExtensions.Contains(fileInfo.Extension[1..].ToLower()))
            {
                _loggerService.Warning($"Unknown file extension for \"{relPath}\". Skipping");
                continue;
            }

            ulong hash;
            var match = regex.Match(relPath);
            if (match.Success)
            {
                if (!ulong.TryParse(match.Groups[1].Value, out hash))
                {
                    _loggerService.Warning($"Couldn't extract hash for \"{relPath}\". Skipping");
                    continue;
                }
            }
            else
            {
                var sanitizedPath = ResourcePath.SanitizePath(relPath);
                hash = FNV1A64HashAlgorithm.HashString(sanitizedPath);

                if (!TweakDBIDPool.IsNative(sanitizedPath))
                {
                    customPaths.Add(sanitizedPath);
                }
            }

            if (!fileDict.ContainsKey(hash))
            {
                fileDict.Add(hash, new List<FileInfoEntry>());
            }
            fileDict[hash].Add(new FileInfoEntry(relPath, fileInfo));
        }

        var duplicateFound = false;
        foreach (var (hash, fileEntries) in fileDict)
        {
            if (fileEntries.Count == 1)
            {
                continue;
            }

            duplicateFound = true;

            _loggerService.Error($"The following files have the same hash ({hash}):");
            foreach (var (relPath, _) in fileEntries)
            {
                _loggerService.Error($"\t{relPath}");
            }
        }

        if (duplicateFound)
        {
            _loggerService.Error($"Duplicated files found. Aborting");
            return false;
        }

        fileDict = fileDict.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

        var ar = new Archive(string.Empty);
        using var bw = new BinaryWriter(outStream, Encoding.UTF8, true);

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
        

        var progress = 0;
        foreach (var (hash, fileEntries) in fileDict)
        {
            var fileInfo = fileEntries[0].FileInfo;

            if (s_uncompressedFiles.Contains(fileInfo.Extension.ToLower()) && fileInfo.Length > uint.MaxValue)
            {
                _loggerService.Error($"{fileInfo.FullName} is too large. Maximum size for uncompressed files is {uint.MaxValue} bytes.");
                return false;
            }

            // TODO: This is due to max byte[] size (MS also uses byte[]) is int.MaxValue - 56 and we need it for compression
            if (!s_uncompressedFiles.Contains(fileInfo.Extension.ToLower()) && fileInfo.Length > int.MaxValue - 57)
            {
                _loggerService.Error($"{fileInfo.FullName} is too large. Maximum size for compressed files is {int.MaxValue - 57} bytes.");
                return false;
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

            EFileReadErrorCodes readStatus;
            CR2WFileInfo? info;

            try
            {
                readStatus = reader.ReadFileInfo(out info, _loggerService);
            }
            catch (Exception e)
            {
                _loggerService.Error($"Could not read \"{fileInfo.FullName}\".");
                return false;
            }

            if (readStatus == EFileReadErrorCodes.NoError)
            {
                // kraken the file and write
                var cr2wfilesize = (int)info!.FileHeader.objectsEnd;
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

                // Disable this. Prevents other mods to overwrite files in this archive if present

                //register imports
                //foreach (var cr2WImportWrapper in reader.ImportsList)
                //{
                //    // maybe only .Default, not sure as nothing else is used
                //    if (cr2WImportWrapper.Flags is not InternalEnums.EImportFlags.Soft and not InternalEnums.EImportFlags.Embedded)
                //    {
                //        importsHashSet.Add(cr2WImportWrapper.DepotPath);
                //    }
                //}

                lastimportidx = (uint)importsHashSet.Count;

                lastoffsetidx = (uint)ar.Index.FileSegments.Count;

                flags = info.BufferInfo.Length > 0 ? info.BufferInfo.Length - 1 : 0;
            }
            else
            {
                fileStream.Seek(0, SeekOrigin.Begin);

                if (s_alignedFiles.Contains(fileInfo.Extension.ToLower()))
                {
                    bw.PadUntilPage();
                }

                var offset = (ulong)bw.BaseStream.Position;

                if (s_uncompressedFiles.Contains(fileInfo.Extension.ToLower()))
                {
                    fileStream.CopyTo(outStream);
                    var size = (uint)fileStream.Length;

                    ar.Index.FileSegments.Add(new FileSegment(offset, size, size));
                }
                else
                {
                    var cr2winbuffer = fileStream.ToByteArray();
                    var size = (uint)cr2winbuffer.Length;

                    // kraken the file and write
                    var (zsize, _) = CompressAndWrite(bw, cr2winbuffer);
                    ar.Index.FileSegments.Add(new FileSegment(offset, zsize, size));
                }

                lastoffsetidx = (uint)ar.Index.FileSegments.Count;
            }

            // save table data
            using var sha1 = SHA1.Create();
            var sha1hash = sha1.ComputeHash(fileStream); //TODO: this is only correct for files with no buffer
            var item = new FileEntry(
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

        bw.Flush();

        return true;
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
