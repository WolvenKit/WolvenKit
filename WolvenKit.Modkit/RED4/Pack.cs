using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Threading;
using CP77Tools.Model;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.RED4.Archive;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W.Archive;

namespace WolvenKit.Modkit.RED4
{
    /// <summary>
    ///     Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {
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

        #endregion

        #region Methods

        /// <summary>
        ///     Creates and archive from a folder and packs all files inside into it
        /// </summary>
        /// <param name="infolder"></param>
        /// <param name="outpath"></param>
        /// <param name="modname">Optional archivename</param>
        /// <returns></returns>
        public Archive Pack(DirectoryInfo infolder, DirectoryInfo outpath, string modname = null)
        {
            if (!infolder.Exists)
            {
                return null;
            }

            if (!outpath.Exists)
            {
                return null;
            }

            // get files
            var includedExtensions = Enum.GetNames<ERedExtension>().ToList();
            includedExtensions.Add("bin");
            var allfiles = infolder.GetFiles("*", SearchOption.AllDirectories);
            var parentfiles = allfiles
                .Where(_ => includedExtensions.Any(x => _.TrimmedExtension().ToLower() == x));
            var fileInfos = parentfiles
                .OrderBy(_ => FNV1A64HashAlgorithm.HashString(_.FullName.RelativePath(infolder)))
                .ToList();

            _loggerService.Info($"Found {fileInfos.Count} bundle entries to pack.");

            var customPaths = (from fileInfo in fileInfos
                select fileInfo.FullName.RelativePath(infolder)
                into relpath
                let hash = FNV1A64HashAlgorithm.HashString(relpath)
                where !_hashService.Contains(hash)
                select relpath).ToList();


            var outfile = Path.Combine(outpath.FullName, $"{infolder.Name}.archive");
            if (modname != null)
            {
                outfile = Path.Combine(outpath.FullName, $"{modname}.archive");
            }

            var sw = new Stopwatch();
            sw.Start();

            var ar = new Archive { ArchiveAbsolutePath = outfile };
            using var fs = new FileStream(outfile, FileMode.Create);
            using var bw = new BinaryWriter(fs);

            #region write header

            bw.WriteHeader(ar.Header);
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
            _progressService.Report(0);
            foreach (var fileInfo in fileInfos)
            {
                var relpath = fileInfo.FullName.RelativePath(infolder);
                _loggerService.Log($"packing {relpath}");

                var hash = FNV1A64HashAlgorithm.HashString(relpath);
                if (fileInfo.Extension.ToLower() == ".bin")
                {
                    if (!ulong.TryParse(Path.GetFileNameWithoutExtension(relpath), out hash))
                    {
                        continue;
                    }
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

                var isResource = _wolvenkitFileService.IsCr2wFile(fileBinaryReader.BaseStream);
                if (isResource)
                {
                    // read the file
                    _ = reader.ReadFile(out var cr2w, false);

                    // kraken the file and write
                    var cr2wfilesize = (int)cr2w.MetaData.ObjectsEnd;
                    fileBinaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    var cr2winbuffer = fileBinaryReader.ReadBytes(cr2wfilesize);
                    var offset = bw.BaseStream.Position;

                    var (zsize, _) = bw.CompressAndWrite(cr2winbuffer);
                    ar.Index.FileSegments.Add(new FileSegment(
                        (ulong)offset,
                        zsize,
                        (uint)cr2winbuffer.Length));

                    // HINT: each cr2w needs to have the buffer already kraken'd
                    // foreach buffer write
                    var bufferOffsets = cr2w.Buffers;
                    foreach (var buffer in bufferOffsets)
                    {
                        var bsize = buffer.MemSize;
                        
                        //var bzsize = buffer.DiskSize; //compressed size of the buffer inside the cr2wfile
                        //fileBinaryReader.BaseStream.Seek(buffer.Offset, SeekOrigin.Begin);
                        //var b = fileBinaryReader.ReadBytes((int)bzsize); //read bzsize bytes from the cr2w
                        var b = buffer.Data;
                        var bzsize = b.Length;
                        var boffset = bw.BaseStream.Position;

                        bw.Write(b);
                        ar.Index.FileSegments.Add(new FileSegment(
                            (ulong)boffset,
                            (uint)bzsize,
                            bsize));
                    }

                    //register imports
                    foreach (var cr2WImportWrapper in reader.ImportsList)
                    {
                        importsHashSet.Add(FNV1A64HashAlgorithm.HashString(cr2WImportWrapper.DepotPath));
                    }

                    lastimportidx = (uint)importsHashSet.Count;

                    lastoffsetidx = (uint)ar.Index.FileSegments.Count;

                    flags = cr2w.Buffers.Count > 0 ? cr2w.Buffers.Count - 1 : 0;
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
                        var (zsize, _) = bw.CompressAndWrite(cr2winbuffer);
                        ar.Index.FileSegments.Add(new FileSegment(offset, zsize, size));
                    }

                    lastoffsetidx = (uint)ar.Index.FileSegments.Count;
                }

                // save table data
                var sha1 = new SHA1Managed();
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
                _progressService.Report(progress / (float)fileInfos.Count);
            }

            ar.Index.Dependencies = importsHashSet.Select(_ => new Dependency(_)).ToList();


            #endregion write files

            #region write footer

            bw.PadUntilPage();

            // write tables
            var tableoffset = bw.BaseStream.Position;
            bw.WriteIndex(ar.Index);
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
            bw.WriteHeader(ar.Header);
            bw.Write(customDataLength);

            sw.Stop();
            _loggerService.Info($"Packing archive took {sw.ElapsedMilliseconds}ms.");

            return ar;
        }

        #endregion Methods
    }
}
