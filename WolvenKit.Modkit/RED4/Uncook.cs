using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Oodle;
using WolvenKit.RED4.CR2W;
using System.Diagnostics;
using WolvenKit.Common.Model.Arguments;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        /// <summary>
        /// Uncooks a single file by hash. This will both extract and uncook the redengine file
        /// </summary>
        /// <param name="archive"></param>
        /// <param name="hash"></param>
        /// <param name="outDir"></param>
        /// <param name="rawOutDir"></param>
        /// <param name="args"></param>
        /// <param name="forcebuffers"></param>
        /// <returns></returns>
        public bool UncookSingle(Archive archive, ulong hash, DirectoryInfo outDir, GlobalExportArgs args,
            DirectoryInfo rawOutDir = null, ECookedFileFormat forcebuffers = ECookedFileFormat.NONE)
        {
            if (!archive.Files.ContainsKey(hash))
            {
                return false;
            }

            Directory.CreateDirectory(outDir.FullName);

            // extract the main file with uncompressed buffers
            #region unbundle main file
            using var cr2WStream = new MemoryStream();
            ExtractSingleToStream(archive, hash, cr2WStream);

            // write main file
            var entry = archive.Files[hash] as FileEntry;
            var relFileFullName = entry.FileName;
            if (string.IsNullOrEmpty(Path.GetExtension(relFileFullName)))
            {
                relFileFullName += ".bin";
            }

            var cr2WExtractedFullPath = new FileInfo(Path.Combine(outDir.FullName, $"{relFileFullName}"));
            if (cr2WExtractedFullPath.Directory == null)
            {
                return false;
            }
            Directory.CreateDirectory(cr2WExtractedFullPath.Directory.FullName);

            using var fs = new FileStream(cr2WExtractedFullPath.FullName, FileMode.Create, FileAccess.Write);
            cr2WStream.Seek(0, SeekOrigin.Begin);
            cr2WStream.CopyTo(fs);
            #endregion

            var hasBuffers = (entry.SegmentsEnd - entry.SegmentsStart) > 1;
            if (!hasBuffers)
            {
                return true;
            }

            // uncook main file buffers to raw out dir
            if (rawOutDir is null or { Exists: false })
            {
                rawOutDir = outDir;
            }

            try
            {
                return UncookBuffers(cr2WStream, relFileFullName, args, rawOutDir, forcebuffers);
            }
            catch (Exception e)
            {
                _loggerService.Error($"{relFileFullName} And unexpected error occured while uncooking: {e.Message}");
                return false;
            }
        }

        /// <summary>
        /// Uncooks all Files to the specified directory.
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="outDir"></param>
        /// <param name="args"></param>
        /// <param name="unbundle"></param>
        /// <param name="pattern"></param>
        /// <param name="regex"></param>
        /// <param name="rawOutDir"></param>
        /// <param name="forcebuffers"></param>
        /// <returns></returns>
        public void UncookAll(
            Archive ar,
            DirectoryInfo outDir,
            GlobalExportArgs args,
            bool unbundle = false,
            string pattern = "",
            string regex = "",
            DirectoryInfo rawOutDir = null,
            ECookedFileFormat forcebuffers = ECookedFileFormat.NONE)
        {
            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();

            // using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open);

            // check search pattern then regex
            var finalmatches = ar.Files.Values.Cast<FileEntry>();
            var totalInArchiveCount = ar.FileCount;
            if (!string.IsNullOrEmpty(pattern))
            {
                finalmatches = ar.Files.Values.Cast<FileEntry>().MatchesWildcard(item => item.FileName, pattern);
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

            var finalMatchesList = finalmatches.ToList();
            if (!unbundle)
            {
                finalMatchesList = finalMatchesList.Where(_ => ar.CanUncook(_.NameHash64)).ToList();
            }

            _loggerService.Info($" {ar.ArchiveAbsolutePath}: Found {finalMatchesList.Count}/{totalInArchiveCount} entries to uncook");
            if (finalMatchesList.Count == 0)
            {
                return;
            }

            var progress = 0;
            _progressService.Report(0);

            //foreach (var info in finalMatchesList)
            Parallel.ForEach(finalMatchesList, info =>
            {
                if (UncookSingle(ar, info.NameHash64, outDir, args, rawOutDir, forcebuffers))
                {
                    extractedList.Add(info.FileName);
                }
                else
                {
                    failedList.Add(info.FileName);
                }

                Interlocked.Increment(ref progress);
                _progressService.Report(progress / (float)finalMatchesList.Count);
            });
            //}

            foreach (var failed in failedList)
            {
                _loggerService.Warning($"Failed to uncook {failed}.");
            }

            _loggerService.Success($" {ar.ArchiveAbsolutePath}: Uncooked {extractedList.Count}/{finalMatchesList.Count} files.");
        }


        /// <summary>
        /// Extracts and decompresses buffers of a cr2wstream
        /// uncooks buffers to raw format
        /// </summary>
        /// <param name="cr2wStream">the cooked redengine file input stream</param>
        /// <param name="relPath">if a depot is used the relpath is a relative base path, if no depot is used, the relapth is simply the filename</param>
        /// <param name="settings">GlobalExportSettings</param>
        /// <param name="rawOutDir">the output directory. the outfile is conbined from the rawoutdir and the relative path</param>
        /// <returns></returns>
        private bool UncookBuffers(Stream cr2wStream, string relPath, GlobalExportArgs settings,
            DirectoryInfo rawOutDir, ECookedFileFormat forcebuffers = ECookedFileFormat.NONE)
        {
            var outfile = new FileInfo(Path.Combine(rawOutDir.FullName, relPath));
            if (outfile.Directory == null)
            {
                return false;
            }
            Directory.CreateDirectory(outfile.Directory.FullName);

            var ext = Path.GetExtension(relPath).TrimStart('.');

            // files where uncook methods are NOT implemented: just extract buffers
            if (!Enum.GetNames(typeof(ECookedFileFormat)).Contains(ext) || forcebuffers.ToString() == ext)
            {
                var i = 0;
                foreach (var stream in GenerateBuffers(cr2wStream))
                {
                    var bufferpath = $"{outfile.FullName}.{i}.buffer";
                    using var fs = new FileStream(bufferpath, FileMode.Create, FileAccess.Write);
                    i++;
                    stream.Seek(0, SeekOrigin.Begin);
                    stream.CopyTo(fs);
                    stream.Dispose();
                }

                return true;
            }

            // handle files where uncook methods ARE implemented
            if (!Enum.TryParse(ext, true, out ECookedFileFormat extAsEnum))
            {
                return false;
            }

            // wems are not cr2w files, need to be handled first
            if (extAsEnum == ECookedFileFormat.wem)
            {
                if (settings.Get<WemExportArgs>() is { } wemaArgs)
                {
                    if (!File.Exists(wemaArgs.FileName))
                    {
                        throw new NotImplementedException();
                    }

                    var wemoutfile = Path.ChangeExtension(outfile.FullName, wemaArgs.ToString());
                    UncookWem(wemaArgs.FileName, wemoutfile);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // uncook textures, meshes etc
            //args.FileName = outFileInfo.FullName;
            switch (extAsEnum)
            {
                case ECookedFileFormat.mlmask:
                {
                    return UncookMlmask(cr2wStream, outfile, settings.Get<MlmaskExportArgs>());
                }
                case ECookedFileFormat.mesh:
                    return (HandleMesh(cr2wStream, outfile, settings.Get<MeshExportArgs>()));
                case ECookedFileFormat.morphtarget:
                    return _targetTools.ExportTargets(cr2wStream, outfile);
                case ECookedFileFormat.xbm:
                {
                    if (settings.Get<XbmExportArgs>() is not { } xbmargs)
                    {
                        return false;
                    }

                    EFormat texformat;
                    var ddspath = Path.ChangeExtension(outfile.FullName, "dds");
                    using (var fs = new FileStream(ddspath, FileMode.Create, FileAccess.Write))
                    {

                        if (!UncookXbm(cr2wStream, fs, out texformat))
                        {
                            return false;
                        }
                    }

                    // flip the physical file
                    if (xbmargs.Flip && RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        TexconvWrapper.VFlip(outfile.Directory.FullName, ddspath, texformat);
                    }

                    // convert the texture
                    if (xbmargs.UncookExtension == EUncookExtension.dds || !RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        return true;
                    }
                    try
                    {

                        TexconvWrapper.Convert(outfile.Directory.FullName, $"{ddspath}", xbmargs.UncookExtension);
                    }
                    catch (Exception)
                    {
                        return false;
                    }

                    return true;
                }
                case ECookedFileFormat.csv:
                {
                    using var fs = new FileStream($"{outfile.FullName}.csv", FileMode.Create, FileAccess.Write);
                    return UncookCsv(cr2wStream, fs);
                }
                //case ECookedFileFormat.json:
                //    return true;
                case ECookedFileFormat.cubemap:
                {
                    var newpath = Path.ChangeExtension(outfile.FullName, "dds");
                    using var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                    return UncookCubeMap(cr2wStream, ddsStream);
                }
                case ECookedFileFormat.envprobe:
                {
                    var newpath = Path.ChangeExtension(outfile.FullName, "dds");
                    using var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                    return UncookEnvprobe(cr2wStream, ddsStream);
                }
                case ECookedFileFormat.texarray:
                {
                    var newpath = Path.ChangeExtension(outfile.FullName, "dds");
                    using var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                    return UncookTexarray(cr2wStream, ddsStream);
                }
                default:
                    throw new ArgumentOutOfRangeException($"Uncooking failed for extension: {extAsEnum}.");
            }
        }


        private bool HandleMesh(Stream cr2wStream , FileInfo cr2wFileName, MeshExportArgs meshargs)
        {
            var meshName = Path.GetFileNameWithoutExtension(cr2wFileName.Name);

            switch (meshargs.meshExportType)
            {
                case MeshExportType.Default:
                    return _meshTools.ExportMesh(cr2wStream, meshName, cr2wFileName);
                case MeshExportType.WithMaterials:
                    return ExportMeshWithMaterialsUsingArchives(cr2wStream, meshName, cr2wFileName, meshargs.Archives,
                        meshargs.isGLBinary, meshargs.WithMaterialMeshargs.MaterialUncookExtension, meshargs.LodFilter);
                case MeshExportType.WithRig:
                    return _meshTools.ExportMeshWithRig(cr2wStream, meshargs.WithRigMeshargs.RigStream, meshName, cr2wFileName);
            }
            return false;
        }

        private bool UncookWem(string infile, string outfile)
        {
            var arg = infile + " -o " + outfile;
            var si = new ProcessStartInfo(
                    AppDomain.CurrentDomain.BaseDirectory + "\\vgmstream\\test.exe",
                    arg
                )
            {
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                Verb = "runas"
            };
            var proc = Process.Start(si);
            proc.WaitForExit();
            Trace.WriteLine(proc.StandardOutput.ReadToEnd());

            return true;
        }

        public IEnumerable<Stream> GenerateBuffers(Stream cr2wStream)
        {
            // read the cr2wfile
            var cr2w = _wolvenkitFileService.TryReadCr2WFileHeaders(cr2wStream);
            if (cr2w == null)
            {
                yield break;
            }

            var buffers = cr2w.Buffers;
            foreach (var b in buffers)
            {
                var ms = new MemoryStream();
                cr2wStream.Seek(b.Offset, SeekOrigin.Begin);
                cr2wStream.DecompressAndCopySegment(ms, b.DiskSize, b.MemSize);

                yield return ms;
            }
        }

        private bool UncookTexarray(Stream cr2wStream, Stream outstream)
        {
            // read the cr2wfile
            var cr2w = _wolvenkitFileService.TryReadCr2WFile(cr2wStream);
            if (cr2w == null)
            {
                return false;
            }

            if (!(cr2w.Chunks.FirstOrDefault()?.Data is CTextureArray texa) ||
                !(cr2w.Chunks[1]?.Data is rendRenderTextureBlobPC blob))
            {
                return false;
            }

            var sliceCount = blob.Header.TextureInfo.SliceCount.Value;
            var mipCount = blob.Header.TextureInfo.MipCount.Value;
            var alignment = blob.Header.TextureInfo.DataAlignment.Value;

            var height = blob.Header.SizeInfo.Height.Value;
            var width = blob.Header.SizeInfo.Width.Value;

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

            var texformat = CommonFunctions.GetDXGIFormat(compression, rawfmt, _loggerService);


            DDSUtils.GenerateAndWriteHeader(outstream,
                new DDSMetadata(width, height, mipCount, texformat, alignment, false, sliceCount,
                    true));

            var b = cr2w.Buffers[0];
            cr2wStream.Seek(b.Offset, SeekOrigin.Begin);
            cr2wStream.DecompressAndCopySegment(outstream, b.DiskSize, b.MemSize);

            return true;
        }

        private bool UncookEnvprobe(Stream cr2wStream, Stream outstream)
        {
            // read the cr2wfile
            var cr2w = _wolvenkitFileService.TryReadCr2WFile(cr2wStream);
            if (cr2w == null)
            {
                return false;
            }

            if (!(cr2w.Chunks.FirstOrDefault()?.Data is CReflectionProbeDataResource probe) ||
                !(cr2w.Chunks[1]?.Data is rendRenderTextureBlobPC blob))
            {
                return false;
            }

            var sliceCount = blob.Header.TextureInfo.SliceCount.Value;
            var mipCount = blob.Header.TextureInfo.MipCount.Value;
            var alignment = blob.Header.TextureInfo.DataAlignment.Value;

            var height = blob.Header.SizeInfo.Height.Value;
            var width = blob.Header.SizeInfo.Width.Value;

            const EFormat texformat = EFormat.R8G8B8A8_UNORM;


            DDSUtils.GenerateAndWriteHeader(outstream,
                new DDSMetadata(width, height, mipCount, texformat, alignment, false, sliceCount,
                    true));
            var b = cr2w.Buffers[0];
            cr2wStream.Seek(b.Offset, SeekOrigin.Begin);
            cr2wStream.DecompressAndCopySegment(outstream, b.DiskSize, b.MemSize);

            return true;
        }

        private bool UncookCubeMap(Stream cr2wStream, Stream outstream)
        {
            // read the cr2wfile
            var cr2w = _wolvenkitFileService.TryReadCr2WFile(cr2wStream);
            if (cr2w == null)
            {
                return false;
            }

            if (!(cr2w.Chunks.FirstOrDefault()?.Data is CCubeTexture ctex) ||
                !(cr2w.Chunks[1]?.Data is rendRenderTextureBlobPC blob))
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

            if (ctex.Setup.RawFormat?.Value != null)
            {
                rawfmt = ctex.Setup.RawFormat.Value;
            }

            if (ctex.Setup.Compression?.Value != null)
            {
                compression = ctex.Setup.Compression.Value;
            }

            var texformat = CommonFunctions.GetDXGIFormat(compression, rawfmt, _loggerService);

            DDSUtils.GenerateAndWriteHeader(outstream,
                new DDSMetadata(width, height, mipCount, texformat, alignment, false, sliceCount,
                    true));
            var b = cr2w.Buffers[0];
            cr2wStream.Seek(b.Offset, SeekOrigin.Begin);
            cr2wStream.DecompressAndCopySegment(outstream, b.DiskSize, b.MemSize);

            return true;
        }

        private bool UncookCsv(Stream cr2wStream, Stream outstream)
        {
            // read the cr2wfile
            var cr2w = _wolvenkitFileService.TryReadRED4File(cr2wStream);
            if (cr2w == null)
            {
                return false;
            }

            if (cr2w.StringDictionary[1] != "C2dArray")
            {
                return false;
            }

            if (!(cr2w.Chunks.FirstOrDefault() is {Data: C2dArray redcsv}))
            {
                return false;
            }

            redcsv.ToCsvStream(outstream);
            return true;
        }

        public bool UncookXbm(Stream cr2wStream, Stream outstream, out EFormat texformat)
        {
            texformat = EFormat.R8G8B8A8_UNORM;

            // read the cr2wfile
            var cr2w = _wolvenkitFileService.TryReadRED4File(cr2wStream);
            if (cr2w == null)
            {
                return false;
            }

            if (cr2w.StringDictionary[1] != "CBitmapTexture")
            {
                return false;
            }


            if (cr2w.Chunks.FirstOrDefault()?.Data is not CBitmapTexture xbm ||
                cr2w.Chunks[1]?.Data is not rendRenderTextureBlobPC blob)
            {
                return false;
            }

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

            texformat = CommonFunctions.GetDXGIFormat(compression, rawfmt, _loggerService);

            #endregion

            // extract and write buffer
            DDSUtils.GenerateAndWriteHeader(outstream, new DDSMetadata(width, height, mips, texformat, alignment, false,
                slicecount, true));
            var b = cr2w.Buffers[0];
            cr2wStream.Seek(b.Offset, SeekOrigin.Begin);
            cr2wStream.DecompressAndCopySegment(outstream, b.DiskSize, b.MemSize);

            return true;
        }
    }
}
