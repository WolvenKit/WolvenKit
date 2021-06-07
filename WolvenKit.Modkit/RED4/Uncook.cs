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
using CP77.CR2W.Uncooker;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Oodle;
using WolvenKit.RED4.CR2W;
using System.Diagnostics;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Modkit.RED4.Materials;
using WolvenKit.Modkit.RED4.MeshFile;
using WolvenKit.Modkit.RED4.MorphTargetFile;

namespace CP77.CR2W
{
    public static class ModToolsExtensions
    {

    }




    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {


        /// <summary>
        /// Extracts a single file (by hash) from an archive to a Stream
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="hash"></param>
        /// <param name="stream"></param>
        public void UncookSingleToStream(Archive ar, ulong hash, Stream stream)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Uncooks a single file by hash. This will both extract and uncook the redengine file
        /// </summary>
        /// <param name="ar"></param>
        /// <param name="hash"></param>
        /// <param name="outDir"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public bool UncookSingle(Archive ar, ulong hash, DirectoryInfo outDir, ExportArgs args)
        {
            if (!_hashService.Contains(hash))
            {
                return false;
            }

            if (!ar.Files.ContainsKey(hash))
            {
                return false;
            }

            // extract the main file with uncompressed buffers
            #region unbundle main file
            using var ms = new MemoryStream();
            ExtractSingleToStream(ar, hash, ms);

            // write main file
            var entry = ar.Files[hash] as FileEntry;
            var name = entry.FileName;
            if (string.IsNullOrEmpty(Path.GetExtension(name)))
            {
                name += ".bin";
            }
            var outfile = new FileInfo(Path.Combine(outDir.FullName, $"{name}"));
            if (outfile.Directory == null)
            {
                return false;
            }
            Directory.CreateDirectory(outfile.Directory.FullName);
            using var fs = new FileStream(outfile.FullName, FileMode.Create, FileAccess.Write);
            ms.Seek(0, SeekOrigin.Begin);
            ms.CopyTo(fs);
            #endregion

            // uncook from main file stream
            var ext = Path.GetExtension(name)[1..];
            return UncookInplace(ms, outfile, ext, args);
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
        public (List<string>, int) UncookAll(Archive ar, DirectoryInfo outDir, ExportArgs args,
            string pattern = "", string regex = "")
        {
            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();

            // using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open);

            // check search pattern then regex
            var finalmatches = ar.Files.Values.Cast<FileEntry>();
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

            var finalMatchesList = finalmatches.Where(_ => ar.CanUncook(_.NameHash64)).ToList();
            _loggerService.Info($"Found {finalMatchesList.Count} bundle entries to uncook.");

            Thread.Sleep(1000);
            var progress = 0;
            _progressService.Report(0);
            Parallel.ForEach(finalMatchesList, info =>
            {
                if (UncookSingle(ar, info.NameHash64, outDir, args))
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

            foreach (var failed in failedList)
            {
                _loggerService.Warning($"Failed to uncook {failed}.");
            }

            return (extractedList.ToList(), finalMatchesList.Count);
        }


        /// <summary>
        /// Extracts and decompresses buffers of a cr2wstream
        /// uncooks buffers to raw format and
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public bool UncookInplace(Stream cr2wStream, FileInfo inputFileInfo, string ext, ExportArgs args)
        {
            if (!Enum.GetNames(typeof(ECookedFileFormat)).Contains(ext))
            {
                if (inputFileInfo.Directory != null)
                {
                    Directory.CreateDirectory(inputFileInfo.Directory.FullName);
                }

                var i = 0;
                foreach (var stream in GenerateBuffers(cr2wStream))
                {
                    var bufferpath = $"{inputFileInfo}.{i}.buffer";
                    using var fs = new FileStream(bufferpath, FileMode.Create, FileAccess.Write);
                    i++;
                    stream.CopyTo(fs);
                    stream.Dispose();
                }
            }
            if (!Enum.TryParse(ext, true, out ECookedFileFormat extAsEnum))
            {
                return false;
            }


            if (extAsEnum == ECookedFileFormat.wem)
            {
                var q = args as WemExportArgs;
                string wemPath = inputFileInfo.FullName;
                UncookWem(wemPath, q.wemExportType);
                return true;

            }

            args.FileName = inputFileInfo.FullName;

            // uncook textures, meshes etc
            switch (extAsEnum)
            {
                case ECookedFileFormat.mlmask:
                {
                    // read the cr2wfile
                    var cr2w = TryReadCr2WFile(cr2wStream);
                    if (cr2w == null)
                    {
                        return false;
                    }

                    cr2w.FileName = inputFileInfo.FullName;
                    return Mlmask.Uncook(cr2wStream, cr2w, args);
                }
                case ECookedFileFormat.mesh:
                    return (HandleMesh(cr2wStream, inputFileInfo, args));
                case ECookedFileFormat.morphtarget:
                    return (new TARGET()).ExportTargets(cr2wStream, (new FileInfo(inputFileInfo.FullName)));


                case ECookedFileFormat.xbm:
                {
                    if (args is not XbmExportArgs xbmargs)
                    {
                        return false;
                    }

                    if (inputFileInfo.Directory != null)
                    {
                        Directory.CreateDirectory(inputFileInfo.Directory.FullName);
                    }
                    var di = inputFileInfo.Directory;

                    var ddspath = Path.ChangeExtension(inputFileInfo.FullName, "dds");
                    using var fs = new FileStream(ddspath, FileMode.Create, FileAccess.Write);
                    if (!UncookXbm(cr2wStream, fs, args, out var texformat))
                    {
                        return false;
                    }


                    // flip the physical file
                    if (xbmargs.Flip && RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        TexconvWrapper.VFlip(di.FullName, ddspath, texformat);
                    }

                    // convert the texture
                    if (xbmargs.UncookExtension == EUncookExtension.dds || !RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                    {
                        return true;
                    }
                    try
                    {

                        TexconvWrapper.Convert(di.FullName, $"{ddspath}", xbmargs.UncookExtension);
                    }
                    catch (Exception)
                    {
                        return false;
                    }

                    return true;
                }
                case ECookedFileFormat.csv:
                {
                    if (inputFileInfo.Directory != null)
                    {
                        Directory.CreateDirectory(inputFileInfo.Directory.FullName);
                    }
                    using var fs = new FileStream($"{inputFileInfo.FullName}.csv", FileMode.Create, FileAccess.Write);
                    return UncookCsv(cr2wStream, fs);
                }
                case ECookedFileFormat.json:
                    return false;
                case ECookedFileFormat.cubemap:
                {
                    if (inputFileInfo.Directory != null)
                    {
                        Directory.CreateDirectory(inputFileInfo.Directory.FullName);
                    }
                    var newpath = Path.ChangeExtension(inputFileInfo.FullName, "dds");
                    using var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                    return UncookCubeMap(cr2wStream, ddsStream);
                }
                case ECookedFileFormat.envprobe:
                {
                    if (inputFileInfo.Directory != null)
                    {
                        Directory.CreateDirectory(inputFileInfo.Directory.FullName);
                    }

                    var newpath = Path.ChangeExtension(inputFileInfo.FullName, "dds");

                    using var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                    return UncookEnvprobe(cr2wStream, ddsStream);
                }
                case ECookedFileFormat.texarray:
                {
                    if (inputFileInfo.Directory != null)
                    {
                        Directory.CreateDirectory(inputFileInfo.Directory.FullName);
                    }

                    var newpath = Path.ChangeExtension(inputFileInfo.FullName, "dds");

                    using var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                    return UncookTexarray(cr2wStream, ddsStream);
                }
                default:
                    throw new ArgumentOutOfRangeException($"Uncooking failed for extension: {extAsEnum}.");
            }
        }


        private bool HandleMesh(Stream cr2wStream , FileInfo cr2wFileName, ExportArgs args)
        {
            var meshargs = args as MeshExportArgs;
            switch (meshargs.meshExportType)
            {
                case MeshExportType.Default:
                    (new MESH()).ExportMesh(cr2wStream, Path.GetFileNameWithoutExtension(cr2wFileName.Name), (new FileInfo(cr2wFileName.FullName)));
                    break;
                case MeshExportType.WithMaterials:
                    (new MATERIAL(meshargs.Archives)).ExportMeshWithMaterialsUsingArchives(cr2wStream, Path.GetFileNameWithoutExtension(cr2wFileName.Name), (new FileInfo(cr2wFileName.FullName)));
                    break;

                case MeshExportType.WithRig:
                    (new MESH()).ExportMeshWithRig(cr2wStream, meshargs.RigStream, Path.GetFileNameWithoutExtension(cr2wFileName.Name), (new FileInfo(cr2wFileName.FullName)));
                    break;
            }
            return true;
        }

        private bool UncookWem(string path, WemExportTypes wemExportType )
        {

            var outf = path.Replace(".wem", "." + wemExportType.ToString());


            var arg = path + " -o " + outf;
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
            var cr2w = TryReadCr2WFileHeaders(cr2wStream);
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
            var cr2w = TryReadCr2WFile(cr2wStream);
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
            var cr2w = TryReadCr2WFile(cr2wStream);
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
            var cr2w = TryReadCr2WFile(cr2wStream);
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
            var cr2w = TryReadCr2WFile(cr2wStream);
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

        public bool UncookXbm(Stream cr2wStream, Stream outstream, ExportArgs args, out EFormat texformat)
        {
            if (args is not XbmExportArgs xbmargs)
            {
                throw new ArgumentException(nameof(ExportArgs));
            }

            texformat = EFormat.R8G8B8A8_UNORM;

            // read the cr2wfile
            var cr2w = TryReadCr2WFile(cr2wStream);
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
