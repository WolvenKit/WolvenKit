using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.CR2W.Extensions;
using CP77Tools.Model;
using RED.CRC32;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.Services;
using WolvenKit.RED4.CR2W;
using Index = CP77Tools.Model.Index;

namespace CP77.CR2W
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public static partial class ModTools
    {
        #region Fields

        // The first 4 files need to be aligned to 0x1000, added .bin because of unknown file type
        private static readonly List<string> s_alignedFiles = new() { ".bk2", ".bnk", ".opusinfo", ".wem", ".bin" };

        // same as above + dat and opuspak, (only one .dat, don't know if it can be compressed)
        private static readonly List<string> s_uncompressedFiles = new() { ".bk2", ".bnk", ".opusinfo", ".wem", ".bin", ".dat", ".opuspak" };

        #endregion

        #region Methods

        /// <summary>
        /// Kraken-compresses a buffer and writes it to a stream.
        /// </summary>
        /// <param name="bw"></param>
        /// <param name="inbuffer"></param>
        /// <returns></returns>
        public static (uint, uint) CompressAndWrite(this BinaryWriter bw, byte[] inbuffer)
        {
            var size = (uint)inbuffer.Length;
            if (size < 255)
            {
                var crc = Crc32Algorithm.Compute(inbuffer);
                bw.Write(inbuffer);

                return (size, crc);
            }
            else
            {
                IEnumerable<byte> outBuffer = new List<byte>();
                var r = OodleHelper.Compress(
                    inbuffer,
                    (int)size,
                    ref outBuffer,
                    OodleNative.OodleLZ_Compressor.Kraken,
                    OodleNative.OodleLZ_Compression.Normal);

                var b = outBuffer.ToArray();

                var crc = Crc32Algorithm.Compute(b);
                bw.Write(b);

                return ((uint)r, crc);
            }
        }

        /// <summary>
        /// Creates and archive from a folder and packs all files inside into it
        /// </summary>
        /// <param name="infolder"></param>
        /// <param name="outpath"></param>
        /// <returns></returns>
        public static Archive Pack(DirectoryInfo infolder, DirectoryInfo outpath)
        {
            if (!infolder.Exists)
                return null;
            if (!outpath.Exists)
                return null;

            var outfile = Path.Combine(outpath.FullName, $"basegame_{infolder.Name}.archive");
            var ar = new Archive
            {
                ArchiveAbsolutePath = outfile,
                Index = new Index()
            };
            using var fs = new FileStream(outfile, FileMode.Create);
            using var bw = new BinaryWriter(fs);

            #region write header

            ar.Header.Write(bw);
            bw.Write(new byte[132]); // some weird padding

            #endregion write header

            #region write files

            var exludedExtensions = new[]
            {
                ".buffer",
                ".dds",
                ".DS_Store", //Hooray for OSX
            };
            var allfiles = infolder.GetFiles("*", SearchOption.AllDirectories);
            var parentfiles = allfiles
                .Where(_ => exludedExtensions.All(x => _.Extension.ToLower() != x));
            var fileInfos = parentfiles
                .OrderBy(_ => FNV1A64HashAlgorithm.HashString(_.FullName.RelativePath(infolder)))
                .ToList();

            Logger.LogString($"Found {fileInfos.Count} bundle entries to pack.", Logtype.Important);

            Thread.Sleep(1000);
            int progress = 0;
            Logger.LogProgress(0);
            foreach (var fileInfo in fileInfos)
            {
                var relpath = fileInfo.FullName.RelativePath(infolder);
                var hash = FNV1A64HashAlgorithm.HashString(relpath);
                if (fileInfo.Extension.ToLower() == ".bin")
                    hash = ulong.Parse(Path.GetFileNameWithoutExtension(relpath));

                using var fileStream = new FileStream(fileInfo.FullName, FileMode.Open);
                using var fileBinaryReader = new BinaryReader(fileStream);

                // fileinfo data
                uint firstimportidx = (uint)ar.Index.Dependencies.Count;
                uint lastimportidx = (uint)ar.Index.Dependencies.Count;
                uint firstoffsetidx = (uint)ar.Index.FileSegments.Count;
                uint lastoffsetidx = (uint)ar.Index.FileSegments.Count;
                int flags = 0;

                var cr2w = ModTools.TryReadCr2WFileHeaders(fileBinaryReader);
                if (cr2w != null)
                {
                    //register imports
                    foreach (var cr2WImportWrapper in cr2w.Imports)
                    {
                        if (!ar.Index.Dependencies.Select(_ => _.HashStr).Contains(cr2WImportWrapper.DepotPathStr))
                            ar.Index.Dependencies.Add(
                                new Dependency(FNV1A64HashAlgorithm.HashString(cr2WImportWrapper.DepotPathStr)));
                    }
                    lastimportidx = (uint)ar.Index.Dependencies.Count;

                    // kraken the file and write
                    var cr2wfilesize = (int)cr2w.Header.objectsEnd;
                    fileBinaryReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    var cr2winbuffer = fileBinaryReader.ReadBytes(cr2wfilesize);
                    var offset = bw.BaseStream.Position;

                    var (zsize, crc) = bw.CompressAndWrite(cr2winbuffer);
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
                        var bzsize = buffer.DiskSize;  //compressed size of the buffer inside the cr2wfile
                        fileBinaryReader.BaseStream.Seek(buffer.Offset, SeekOrigin.Begin);
                        var b = fileBinaryReader.ReadBytes((int)bzsize);   //read bzsize bytes from the cr2w
                        var boffset = bw.BaseStream.Position;

                        bw.Write(b);
                        ar.Index.FileSegments.Add(new FileSegment(
                            (ulong)boffset,
                            bzsize,
                            bsize));
                    }
                    lastoffsetidx = (uint)ar.Index.FileSegments.Count;

                    flags = cr2w.Buffers.Count > 0 ? cr2w.Buffers.Count - 1 : 0;
                }
                else
                {
                    fileStream.Seek(0, SeekOrigin.Begin);
                    var cr2winbuffer = Catel.IO.StreamExtensions.ToByteArray(fileStream);
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
                        var (zsize, crc) = bw.CompressAndWrite(cr2winbuffer);
                        ar.Index.FileSegments.Add(new FileSegment(offset, zsize, size));
                    }

                    lastoffsetidx = (uint)ar.Index.FileSegments.Count;
                }

                // save table data
                var sha1 = new System.Security.Cryptography.SHA1Managed();
                var sha1hash = sha1.ComputeHash(Catel.IO.StreamExtensions.ToByteArray(fileBinaryReader.BaseStream)); //TODO: this is only correct for files with no buffer
                var item = new FileEntry(hash, DateTime.Now, (uint)flags
                    , firstoffsetidx, lastoffsetidx,
                    firstimportidx, lastimportidx
                    , sha1hash);
                ar.Index.FileEntries.Add(hash, item);

                Interlocked.Increment(ref progress);
                Logger.LogProgress(progress / (float)fileInfos.Count);
            };

            #endregion write files

            #region write footer

            bw.PadUntilPage();

            // write tables
            var tableoffset = bw.BaseStream.Position;
            ar.Index.Write(bw);
            var tablesize = bw.BaseStream.Position - tableoffset;

            // padding to page (4096 bytes)
            bw.PadUntilPage();
            var filesize = bw.BaseStream.Position;

            // write the header again
            ar.Header.IndexPosition = (ulong)tableoffset;
            ar.Header.IndexSize = (uint)tablesize;
            ar.Header.Filesize = (ulong)filesize;
            bw.BaseStream.Seek(0, SeekOrigin.Begin);
            ar.Header.Write(bw);

            #endregion write footer

            return ar;
        }

        #endregion Methods
    }
}
