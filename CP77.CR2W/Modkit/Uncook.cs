using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.CR2W.Archive;
using CP77.CR2W.Extensions;
using CP77.CR2W.Types;
using CP77.CR2W.Uncooker;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Oodle;
using WolvenKit.Common.Services;

namespace CP77.CR2W
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public static partial class ModTools
    {
        #region Methods

        /// <summary>
        /// Extracts and decompresses buffers of a cr2wstream
        /// uncooks buffers to raw format and
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static bool Uncook(Stream cr2wStream, FileInfo cr2wFileName, string ext,
            EUncookExtension uncookext = EUncookExtension.dds, bool flip = false)
        {
            if (!Enum.GetNames(typeof(ECookedFileFormat)).Contains(ext))
            {
                return GenerateBuffers(cr2wStream, cr2wFileName);
            }

            if (!Enum.TryParse(ext, true, out ECookedFileFormat extAsEnum))
            {
                return false;
            }

            // read the cr2wfile
            var cr2w = ModTools.TryReadCr2WFile(cr2wStream);
            if (cr2w == null)
            {
                Logger.LogString($"Failed to read cr2w file {cr2wFileName.FullName}", Logtype.Error);
                return false;
            }
            cr2w.FileName = cr2wFileName.FullName;

            // uncook textures, meshes etc
            return extAsEnum switch
            {
                ECookedFileFormat.mesh => GenerateBuffers(cr2wStream, cr2wFileName),
                ECookedFileFormat.xbm => UncookXbm(cr2wStream, cr2w, uncookext, flip),
                ECookedFileFormat.csv => UncookCsv(cr2wStream, cr2w),
                ECookedFileFormat.json => false,
                ECookedFileFormat.mlmask => Mlmask.Uncook(cr2wStream, cr2w, uncookext),
                ECookedFileFormat.cubemap => UncookCubeMap(cr2wStream, cr2w),
                ECookedFileFormat.envprobe => UncookEnvprobe(cr2wStream, cr2w),
                ECookedFileFormat.texarray => UncookTexarray(cr2wStream, cr2w),
                _ => throw new ArgumentOutOfRangeException($"Uncooking failed for extension: {extAsEnum}.")
            };
        }

        /// <summary>
        /// Uncooks all Files to the specified directory.
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="outDir"></param>
        /// <param name="pattern"></param>
        /// <param name="regex"></param>
        /// <param name="uncookext"></param>
        /// <param name="flip"></param>
        /// <returns></returns>
        public static (List<string>, int) UncookAll(this Archive.Archive ar, DirectoryInfo outDir, string pattern = "",
            string regex = "", EUncookExtension uncookext = EUncookExtension.dds, bool flip = false)
        {
            var logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();

            // using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open);

            // check search pattern then regex
            IEnumerable<FileEntry> finalmatches = ar.Files.Values;
            if (!string.IsNullOrEmpty(pattern))
            {
                finalmatches = ar.Files.Values.MatchesWildcard(item => item.FileName, pattern);
            }

            if (!string.IsNullOrEmpty(regex))
            {
                var searchTerm = new System.Text.RegularExpressions.Regex($@"{regex}");
                var queryMatchingFiles =
                    from file in finalmatches
                    let matches = searchTerm.Matches(file.FileName)
                    where matches.Count > 0
                    select file;

                finalmatches = queryMatchingFiles;
            }

            var finalMatchesList = finalmatches.Where(_ => ar.CanUncook(_.NameHash64)).ToList();
            logger.LogString($"Found {finalMatchesList.Count} bundle entries to uncook.", Logtype.Important);

            Thread.Sleep(1000);
            int progress = 0;
            logger.LogProgress(0);
            Parallel.ForEach(finalMatchesList, info =>
            {
                if (ar.UncookSingle(info.NameHash64, outDir, uncookext, flip))
                    extractedList.Add(info.FileName);
                else
                    failedList.Add(info.FileName);
                Interlocked.Increment(ref progress);
                logger.LogProgress(progress / (float)finalMatchesList.Count);
            });

            foreach (var failed in failedList)
            {
                logger.LogString($"Failed to uncook {failed}.", Logtype.Error);
            }

            return (extractedList.ToList(), finalMatchesList.Count);
        }

        /// <summary>
        /// Uncooks a single file by hash. This will both extract and uncook the redengine file
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="hash"></param>
        /// <param name="outDir"></param>
        /// <param name="uncookext"></param>
        /// <param name="flip"></param>
        /// <returns></returns>
        public static bool UncookSingle(this Archive.Archive ar, ulong hash, DirectoryInfo outDir,
            EUncookExtension uncookext = EUncookExtension.dds, bool flip = false)
        {
            // checks
            if (!ar.Files.ContainsKey(hash))
                return false;

            // extract the main file with uncompressed buffers

            #region unbundle main file

            using var ms = new MemoryStream();
            ar.CopyFileToStream(ms, hash, false);

            var name = ar.Files[hash].FileName;
            var outfile = new FileInfo(Path.Combine(outDir.FullName, $"{name}"));
            if (outfile.Directory == null)
                return false;
            Directory.CreateDirectory(outfile.Directory.FullName);
            using var fs = new FileStream(outfile.FullName, FileMode.Create, FileAccess.Write);
            ms.Seek(0, SeekOrigin.Begin);
            ms.CopyTo(fs);

            #endregion unbundle main file

            var ext = Path.GetExtension(name)[1..];
            return Uncook(ms, outfile, ext, uncookext, flip);
        }

        private static bool GenerateBuffers(Stream cr2wStream, FileInfo cr2wFileName)
        {
            // read the cr2wfile
            var cr2w = ModTools.TryReadCr2WFileHeaders(cr2wStream);
            if (cr2w == null)
            {
                Logger.LogString($"Failed to read cr2w {cr2wFileName.FullName}", Logtype.Error);
                return false;
            }
            cr2w.FileName = cr2wFileName.FullName;

            // decompress buffers
            var buffers = cr2w.Buffers;
            for (var i = 0; i < buffers.Count; i++)
            {
                if (cr2wFileName.Directory != null)
                {
                    Directory.CreateDirectory(cr2wFileName.Directory.FullName);
                }

                var bufferpath = $"{cr2wFileName}.{i}.buffer";
                using var fs = new FileStream(bufferpath, FileMode.Create, FileAccess.Write);
                var b = buffers[i];
                cr2wStream.Seek(b.Offset, SeekOrigin.Begin);
                cr2wStream.DecompressAndCopySegment(fs, b.DiskSize, b.MemSize);
            }

            return true;
        }

        private static bool UncookCsv(Stream cr2wStream, CR2WFile cr2w)
        {
            if (cr2w.StringDictionary[1] != "C2dArray")
            {
                return false;
            }

            if (!(cr2w.Chunks.FirstOrDefault() is { data: C2dArray redcsv }))
            {
                return false;
            }

            // write

            var cr2wFileName = new FileInfo(cr2w.FileName);
            if (cr2wFileName.Directory != null)
            {
                Directory.CreateDirectory(cr2wFileName.Directory.FullName);
            }
            var newpath = $"{cr2wFileName.FullName}.csv";

            using var nstream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
            redcsv.ToCsvStream(nstream);
            return true;
        }

        private static bool UncookCubeMap(Stream cr2wStream, CR2WFile cr2w)
        {
            if (!(cr2w.Chunks.FirstOrDefault()?.data is CCubeTexture ctex) ||
                !(cr2w.Chunks[1]?.data is rendRenderTextureBlobPC blob))
            {
                return false;
            }

            var sliceCount = blob.Header.TextureInfo.SliceCount.Value;
            var mipCount = blob.Header.TextureInfo.MipCount.Value;
            var alignment = blob.Header.TextureInfo.DataAlignment.Value;

            var height = blob.Header.SizeInfo.Height.Value;
            var width = blob.Header.SizeInfo.Width.Value;

            var compression = Enums.ETextureCompression.TCM_None;
            var rawfmt = Enums.ETextureRawFormat.TRF_Invalid;
            if (texa.Setup.RawFormat?.Value != null)
            {
                rawfmt = texa.Setup.RawFormat.Value;
            }

            var compression = Enums.ETextureCompression.TCM_None;
            if (texa.Setup.Compression?.Value != null)
            {
                compression = texa.Setup.Compression.Value;
            }

            var texformat = CommonFunctions.GetDXGIFormat(compression, rawfmt);

            var cr2wFileName = new FileInfo(cr2w.FileName);
            if (cr2wFileName.Directory != null)
            {
                Directory.CreateDirectory(cr2wFileName.Directory.FullName);
            }

            var newpath = Path.ChangeExtension(cr2wFileName.FullName, "dds");

            using var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
            DDSUtils.GenerateAndWriteHeader(ddsStream,
                new DDSMetadata(width, height, mipCount, texformat, alignment, false, sliceCount,
                    true));
            var b = cr2w.Buffers[0];
            cr2wStream.Seek(b.Offset, SeekOrigin.Begin);
            cr2wStream.DecompressAndCopySegment(ddsStream, b.DiskSize, b.MemSize);

            return true;
        }

        private static bool UncookEnvprobe(Stream cr2wStream, CR2WFile cr2w)
        {
            if (!(cr2w.Chunks.FirstOrDefault()?.data is CReflectionProbeDataResource probe) ||
                !(cr2w.Chunks[1]?.data is rendRenderTextureBlobPC blob))
            {
                return false;
            }

            var sliceCount = blob.Header.TextureInfo.SliceCount.Value;
            var mipCount = blob.Header.TextureInfo.MipCount.Value;
            var alignment = blob.Header.TextureInfo.DataAlignment.Value;

            var height = blob.Header.SizeInfo.Height.Value;
            var width = blob.Header.SizeInfo.Width.Value;

            const EFormat texformat = EFormat.R8G8B8A8_UNORM;

            var cr2wFileName = new FileInfo(cr2w.FileName);
            if (cr2wFileName.Directory != null)
            {
                Directory.CreateDirectory(cr2wFileName.Directory.FullName);
            }

            var newpath = Path.ChangeExtension(cr2wFileName.FullName, "dds");

            using var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
            DDSUtils.GenerateAndWriteHeader(ddsStream,
                new DDSMetadata(width, height, mipCount, texformat, alignment, false, sliceCount,
                    true));
            var b = cr2w.Buffers[0];
            cr2wStream.Seek(b.Offset, SeekOrigin.Begin);
            cr2wStream.DecompressAndCopySegment(ddsStream, b.DiskSize, b.MemSize);

            return true;
        }

        private static bool UncookTexarray(Stream cr2wStream, CR2WFile cr2w)
        {
            if (!(cr2w.Chunks.FirstOrDefault()?.data is CTextureArray texa) ||
                !(cr2w.Chunks[1]?.data is rendRenderTextureBlobPC blob))
            {
                return false;
            }

            var sliceCount = blob.Header.TextureInfo.SliceCount.Value;
            var mipCount = blob.Header.TextureInfo.MipCount.Value;
            var alignment = blob.Header.TextureInfo.DataAlignment.Value;

            var height = blob.Header.SizeInfo.Height.Value;
            var width = blob.Header.SizeInfo.Width.Value;

            var rawfmt = Enums.ETextureRawFormat.TRF_Invalid;

            if (ctex.Setup.RawFormat?.Value != null)
            {
                rawfmt = ctex.Setup.RawFormat.Value;
            }

            if (ctex.Setup.Compression?.Value != null)
            {
                compression = ctex.Setup.Compression.Value;
            }

            var texformat = CommonFunctions.GetDXGIFormat(compression, rawfmt);

            var cr2wFileName = new FileInfo(cr2w.FileName);
            if (cr2wFileName.Directory != null)
            {
                Directory.CreateDirectory(cr2wFileName.Directory.FullName);
            }

            var newpath = Path.ChangeExtension(cr2wFileName.FullName, "dds");

            using var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
            DDSUtils.GenerateAndWriteHeader(ddsStream,
                new DDSMetadata(width, height, mipCount, texformat, alignment, false, sliceCount,
                    true));

            var b = cr2w.Buffers[0];
            cr2wStream.Seek(b.Offset, SeekOrigin.Begin);
            cr2wStream.DecompressAndCopySegment(ddsStream, b.DiskSize, b.MemSize);

            return true;
        }

        private static bool UncookXbm(Stream cr2wStream, CR2WFile cr2w, EUncookExtension uncookext, bool flip)
        {
            if (cr2w.StringDictionary[1] != "CBitmapTexture")
            {
                return false;
            }

            if (!(cr2w.Chunks.FirstOrDefault()?.data is CBitmapTexture xbm) ||
                !(cr2w.Chunks[1]?.data is rendRenderTextureBlobPC blob))
            {
                return false;
            }

            // create dds header
            var cr2wFileName = new FileInfo(cr2w.FileName);
            if (cr2wFileName.Directory != null)
            {
                Directory.CreateDirectory(cr2wFileName.Directory.FullName);
            }
            var newpath = Path.ChangeExtension(cr2wFileName.FullName, "dds");

            #region get xbm data

            var width = blob.Header.SizeInfo.Width.Value;
            var height = blob.Header.SizeInfo.Height.Value;
            var mips = blob.Header.TextureInfo.MipCount.Value;
            var slicecount = blob.Header.TextureInfo.SliceCount.Value;
            var alignment = blob.Header.TextureInfo.DataAlignment.Value;

            var rawfmt = Enums.ETextureRawFormat.TRF_Invalid;
            if (xbm.Setup.RawFormat?.Value != null)
            {
                rawfmt = xbm.Setup.RawFormat.Value;
            }
            else
            {
            }

            var compression = Enums.ETextureCompression.TCM_None;
            if (xbm.Setup.Compression?.Value != null)
            {
                compression = xbm.Setup.Compression.Value;
            }
            else
            {
            }

            var texformat = CommonFunctions.GetDXGIFormat(compression, rawfmt);

            #endregion get xbm data

            // extract and write buffer
            using (var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write))
            {
                DDSUtils.GenerateAndWriteHeader(ddsStream,
                    new DDSMetadata(width, height, mips, texformat, alignment, false, slicecount,
                        true));
                var b = cr2w.Buffers[0];
                cr2wStream.Seek(b.Offset, SeekOrigin.Begin);
                cr2wStream.DecompressAndCopySegment(ddsStream, b.DiskSize, b.MemSize);
            }

            if (flip && RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                TexconvWrapper.VFlip(cr2wFileName.Directory.FullName, newpath, texformat);
            }

            // convert to texture
            if (uncookext == EUncookExtension.dds || !RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return true;
            }

            try
            {
                var di = new FileInfo(cr2wFileName.FullName).Directory;
                TexconvWrapper.Convert(di.FullName, $"{newpath}", uncookext);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        #endregion Methods
    }
}
