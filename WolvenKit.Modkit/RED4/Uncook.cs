using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using WolvenKit.Common;
using WolvenKit.Common.Conversion;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.Modkit.Extensions;
using WolvenKit.Modkit.RED4.Opus;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;
using static System.Net.Mime.MediaTypeNames;

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
        public bool UncookSingle(
            ICyberGameArchive archive,
            ulong hash,
            DirectoryInfo outDir,
            GlobalExportArgs args,
            DirectoryInfo rawOutDir = null,
            ECookedFileFormat[] forcebuffers = null,
            bool serialize = false)
        {
            if (!archive.Files.TryGetValue(hash, out var gameFile))
            {
                return false;
            }

            #region unbundle main file

            using var cr2WStream = new MemoryStream();
            gameFile.Extract(cr2WStream);

            if (archive.Files[hash] is FileEntry entry)
            {
                var relFileFullName = entry.FileName;
                if (string.IsNullOrEmpty(Path.GetExtension(relFileFullName)))
                {
                    relFileFullName += ".bin";
                }

                var mainFileInfo = new FileInfo(Path.Combine(outDir.FullName, $"{relFileFullName.Replace('\\', Path.DirectorySeparatorChar)}"));

                // write mainFile
                if (!WolvenTesting.IsTesting)
                {
                    if (mainFileInfo.Directory != null)
                    {
                        Directory.CreateDirectory(mainFileInfo.Directory.FullName);
                    }

                    // prevents batch extract to create write conflicts when a single file is referrenced by multiple items
                    if (!File.Exists(mainFileInfo.FullName))
                    {
                        using var fs = new FileStream(mainFileInfo.FullName, FileMode.Create, FileAccess.Write);
                        cr2WStream.Seek(0, SeekOrigin.Begin);
                        cr2WStream.CopyTo(fs);
                    }
                }

                #endregion unbundle main file

                #region serialize

                if (serialize)
                {
                    try
                    {
                        var jsonOutput = SerializeMainFile(cr2WStream);
                        var outpath = Path.Combine(outDir.FullName, $"{relFileFullName.Replace('\\', Path.DirectorySeparatorChar)}.json");
                        File.WriteAllText(outpath, jsonOutput);
                        return true;
                    }
                    catch (Exception e)
                    {
                        _loggerService.Error($"{relFileFullName} And unexpected error occured while converting to json: {e.Message}");
                        _loggerService.Error(e);
                        return false;
                    }
                }

                #endregion serialize

                #region extract buffers

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
                    // wems need the physical infile path
                    args.Get<WemExportArgs>().FileName = mainFileInfo.FullName;
                    return UncookBuffers(cr2WStream, relFileFullName, args, rawOutDir, forcebuffers);
                }
                catch (Exception e)
                {
                    _loggerService.Error($"{relFileFullName} And unexpected error occured while uncooking: {e.Message}");
                    _loggerService.Error(e);
                    return false;
                }
            }

            return false;

            #endregion extract buffers
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
            ICyberGameArchive ar,
            DirectoryInfo outDir,
            GlobalExportArgs args,
            bool unbundle = false,
            string pattern = "",
            string regex = "",
            DirectoryInfo rawOutDir = null,
            ECookedFileFormat[] forcebuffers = null,
            bool serialize = false)
        {
            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();

            // check search pattern then regex
            var finalmatches = ar.Files.Values.Cast<FileEntry>();
            var totalInArchiveCount = ar.Files?.Count ?? 0;
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

            // check hashes before parallel unbundling
            for (var i = 0; i < finalMatchesList.Count; i++)
            {
                var item = finalMatchesList[i];
                _hashService.Contains(item.Key);
            }

            //foreach (var info in finalMatchesList)
            Parallel.ForEach(finalMatchesList, info =>
            {
                if (UncookSingle(ar, info.NameHash64, outDir, args, rawOutDir, forcebuffers, serialize))
                {
                    extractedList.Add(info.FileName);
                }
                else
                {
                    failedList.Add(info.FileName);
                }

                Interlocked.Increment(ref progress);
                _progressService.Report(progress / (float)finalMatchesList.Count);
            }
            );

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
        /// <param name="forcebuffers"></param>
        /// <returns></returns>
        private bool UncookBuffers(Stream cr2wStream, string relPath, GlobalExportArgs settings, DirectoryInfo rawOutDir, ECookedFileFormat[] forcebuffers = null)
        {
            var outfile = new FileInfo(Path.Combine(rawOutDir.FullName, $"{relPath.Replace('\\', Path.DirectorySeparatorChar)}"));
            if (outfile.Directory == null)
            {
                return false;
            }

            var ext = Path.GetExtension(relPath).TrimStart('.');

            // files where uncook methods are NOT implemented: just extract buffers
            if (!WolvenTesting.IsTesting)
            {
                Directory.CreateDirectory(outfile.Directory.FullName);
            }

            var isForcedBuffer = forcebuffers != null && forcebuffers.Any() && forcebuffers.Select(_ => _.ToString()).Contains(ext);
            if (!Enum.GetNames(typeof(ECookedFileFormat)).Contains(ext) || isForcedBuffer)
            {
                var i = 0;
                foreach (var stream in GenerateBuffers(cr2wStream))
                {
                    var bufferpath = $"{outfile.FullName}.{i}.buffer";

                    if (!WolvenTesting.IsTesting)
                    {
                        using var fs = new FileStream(bufferpath, FileMode.Create, FileAccess.Write);
                        i++;
                        stream.Seek(0, SeekOrigin.Begin);
                        stream.CopyTo(fs);
                    }

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
                    var wemoutfile = Path.ChangeExtension(outfile.FullName, wemaArgs.wemExportType.ToString());
                    UncookWem(wemaArgs.FileName, wemoutfile);
                    return true;
                }

                return false;
            }

            // uncook textures, meshes etc
            //args.FileName = outFileInfo.FullName;
            switch (extAsEnum)
            {
                case ECookedFileFormat.ent:
                    return ExportEntity(cr2wStream, "default", outfile);
                //case ECookedFileFormat.app:
                //    return HandleEntity(cr2wStream, outfile, settings.Get<EntityExportArgs>());
                case ECookedFileFormat.opusinfo:
                    return HandleOpus(settings.Get<OpusExportArgs>());

                case ECookedFileFormat.mlmask:
                    return UncookMlmask(cr2wStream, outfile, settings.Get<MlmaskExportArgs>());

                case ECookedFileFormat.mesh:
                    try
                    {
                        return HandleMesh(cr2wStream, outfile, settings.Get<MeshExportArgs>());
                    }
                    catch (Exception e)
                    {
                        _loggerService.Error($"{relPath} - {e.Message}");
                        _loggerService.Error(e);

                        return false;
                    }

                case ECookedFileFormat.morphtarget:
                    // WolvenKit.CLI does not use (i.e. set) the App's settings configuration, resulting in a null value for
                    // settings.Get<MorphTargetExportArgs>().ModFolderPath.  In the context of the CLI, output directory
                    // (i.e. -o argument) can be used to provide the correct absolute pathname.
                    var modFolderPath = settings.Get<MorphTargetExportArgs>().ModFolderPath;
                    modFolderPath ??= rawOutDir.FullName;
                    return ExportMorphTargets(cr2wStream, outfile, settings.Get<MorphTargetExportArgs>().Archives, modFolderPath, settings.Get<MorphTargetExportArgs>().IsBinary);
                case ECookedFileFormat.anims:
                    try
                    {
                        return ExportAnim(cr2wStream, settings.Get<AnimationExportArgs>().Archives, outfile, settings.Get<AnimationExportArgs>().IsBinary, settings.Get<AnimationExportArgs>().incRootMotion);
                    }
                    catch (Exception e)
                    {
                        _loggerService.Error($"{relPath} - {e.Message}");
                        _loggerService.Error(e);

                        return false;
                    }
                case ECookedFileFormat.xbm:
                {
                    if (settings.Get<XbmExportArgs>() is not { } xbmargs)
                    {
                        return false;
                    }

                    if (WolvenTesting.IsTesting)
                    {
                        using var ms = new MemoryStream();
                        return ConvertXbmToDdsStream(cr2wStream, ms, out _, out _);
                    }

                    using (var ms = new MemoryStream())
                    {
                        if (!ConvertXbmToDdsStream(cr2wStream, ms, out _, out var decompressedFormat))
                        {
                            return false;
                        }

                        // convert if needed else save to file
                        var ddsPath = Path.ChangeExtension(outfile.FullName, ERawFileFormat.dds.ToString());
                        if (xbmargs.UncookExtension != EUncookExtension.dds)
                        {
                            ms.Seek(0, SeekOrigin.Begin);
                            return Texconv.ConvertFromDdsAndSave(ms, ddsPath, xbmargs, decompressedFormat);
                        }
                        else
                        {
                            //TODO: flip dds

                            using var fs = new FileStream(ddsPath, FileMode.Create, FileAccess.Write);
                            ms.Seek(0, SeekOrigin.Begin);
                            ms.CopyTo(fs);
                        }
                    }

                    return true;
                }
                case ECookedFileFormat.csv:
                {
                    if (WolvenTesting.IsTesting)
                    {
                        using var ms = new MemoryStream();
                        return UncookCsv(cr2wStream, ms);
                    }

                    using var fs = new FileStream($"{outfile.FullName}.csv", FileMode.Create, FileAccess.Write);
                    return UncookCsv(cr2wStream, fs);
                }
                //case ECookedFileFormat.json:
                //    return true;
                case ECookedFileFormat.cubemap:
                case ECookedFileFormat.xcube:
                {
                    if (WolvenTesting.IsTesting)
                    {
                        using var ms = new MemoryStream();
                        return UncookCubeMap(cr2wStream, ms);
                    }
                    var newpath = Path.ChangeExtension(outfile.FullName, ERawFileFormat.dds.ToString());
                    using var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                    return UncookCubeMap(cr2wStream, ddsStream);
                }
                case ECookedFileFormat.envprobe:
                {
                    if (WolvenTesting.IsTesting)
                    {
                        using var ms = new MemoryStream();
                        return UncookEnvprobe(cr2wStream, ms);
                    }
                    var newpath = Path.ChangeExtension(outfile.FullName, ERawFileFormat.dds.ToString());
                    using var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                    return UncookEnvprobe(cr2wStream, ddsStream);
                }
                case ECookedFileFormat.texarray:
                {
                    if (WolvenTesting.IsTesting)
                    {
                        using var ms = new MemoryStream();
                        return UncookTexarray(cr2wStream, ms);
                    }
                    var newpath = Path.ChangeExtension(outfile.FullName, ERawFileFormat.dds.ToString());
                    using var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                    return UncookTexarray(cr2wStream, ddsStream);
                }
                case ECookedFileFormat.fnt:
                {
                    if (WolvenTesting.IsTesting)
                    {
                        using var ms = new MemoryStream();
                        return UncookFont(cr2wStream, ms);
                    }
                    var newpath = Path.ChangeExtension(outfile.FullName, ERawFileFormat.ttf.ToString());
                    using var ttfStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                    return UncookFont(cr2wStream, ttfStream);
                }
                case ECookedFileFormat.inkatlas:
                {
                    return UncookInkAtlas(cr2wStream, outfile);
                }
                default:
                    throw new ArgumentOutOfRangeException($"Uncooking failed for extension: {extAsEnum}.");
            }
        }

        private bool HandleEntity(Stream cr2wStream, FileInfo cr2wFileName, EntityExportArgs entExportArgs)
        {
            try
            {
                switch (entExportArgs.ExportType)
                {
                    case EntityExportType.Json:
                        return DumpEntityPackageAsJson(cr2wStream, cr2wFileName);
                    case EntityExportType.Gltf:
                        throw new NotImplementedException("Uncooking Entity/Appearance Resources To Gltf Not Implemented");
                    default:
                        break;
                }

            }
            catch (Exception ex)
            {
                _loggerService.Error(ex);
            }
            return false;
        }

        private static bool HandleOpus(OpusExportArgs opusExportArgs)
        {
            OpusTools opusTools = new(
                opusExportArgs.SoundbanksArchive,
                opusExportArgs.ModFolderPath,
                opusExportArgs.RawFolderPath,
                opusExportArgs.UseMod);

            // If More than 0 selected from opusinfo export to wem.
            if (opusExportArgs.SelectedForExport.Count > 0)
            {
                foreach (var audiofile in opusExportArgs.SelectedForExport)
                {
                    opusTools.ExportOpusUsingHash(audiofile);
                }
            }

            return true;
        }

        private string SerializeMainFile(Stream redstream)
        {
            var cr2w = _wolvenkitFileService.ReadRed4File(redstream);
            var dto = new RedFileDto(cr2w);
            var json = RedJsonSerializer.Serialize(dto);

            return json;
        }

        private bool UncookInkAtlas(Stream redStream, FileInfo outFile)
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return false;
            }

            if (!_wolvenkitFileService.TryReadRed4File(redStream, out var cr2w))
            {
                return false;
            }

            if (cr2w.RootChunk is not inkTextureAtlas inkTextureAtlas)
            {
                return false;
            }

            if (inkTextureAtlas.ActiveTexture != Enums.inkTextureType.StaticTexture)
            {
                // only static for now
                return false;
            }

            if (inkTextureAtlas.Texture.DepotPath != 0)
            {
                ExtractParts(inkTextureAtlas.Texture.DepotPath, inkTextureAtlas.Parts, Path.Combine(outFile.FullName, "main"));
            }

            if (inkTextureAtlas.Slots[0] != null && inkTextureAtlas.Slots[0].Texture.DepotPath != 0)
            {
                ExtractParts(inkTextureAtlas.Slots[0].Texture.DepotPath, inkTextureAtlas.Slots[0].Parts, Path.Combine(outFile.FullName, "2160p"));
            }

            if (inkTextureAtlas.Slots[1] != null && inkTextureAtlas.Slots[1].Texture.DepotPath != 0)
            {
                ExtractParts(inkTextureAtlas.Slots[1].Texture.DepotPath, inkTextureAtlas.Slots[1].Parts, Path.Combine(outFile.FullName, "1080p"));
            }

            if (inkTextureAtlas.Slots[2] != null && inkTextureAtlas.Slots[2].Texture.DepotPath != 0)
            {
                ExtractParts(inkTextureAtlas.Slots[2].Texture.DepotPath, inkTextureAtlas.Slots[2].Parts, Path.Combine(outFile.FullName, "720p"));
            }

            return false;

            void ExtractParts(CName texturePath, CArray<inkTextureAtlasMapper> parts, string outDir)
            {
                var xbmFile = _archiveManager.Lookup(texturePath);
                if (xbmFile.HasValue)
                {
                    Directory.CreateDirectory(outDir);

                    using var ms = new MemoryStream();
                    xbmFile.Value.Extract(ms);
                    ms.Seek(0, SeekOrigin.Begin);

                    var img = RedImage.FromRedFile(_wolvenkitFileService.ReadRed4File(ms));

                    foreach (var part in parts)
                    {
                        var x = Math.Round(part.ClippingRectInUVCoords.Left * img.Metadata.Width);
                        var y = Math.Round(part.ClippingRectInUVCoords.Top * img.Metadata.Height);
                        var width = Math.Round(part.ClippingRectInUVCoords.Right * img.Metadata.Width) - x;
                        var height = Math.Round(part.ClippingRectInUVCoords.Bottom * img.Metadata.Height) - y;

                        var croppedImg = img.Crop((int)x, (int)y, (int)width, (int)height);
                        croppedImg.SaveToPNG(Path.Combine(outDir, $"{part.PartName}.png"));
                    }
                }
            }
        }

        private bool UncookFont(Stream redstream, Stream outstream)
        {
            if (!_wolvenkitFileService.TryReadRed4File(redstream, out var cr2w))
            {
                return false;
            }

            if (cr2w.RootChunk is not rendFont font)
            {
                return false;
            }

            outstream.Write(font.FontBuffer.Buffer.GetBytes());

            return true;
        }

        private bool HandleMesh(Stream cr2wStream, FileInfo cr2wFileName, MeshExportArgs meshargs)
        {
            switch (meshargs.meshExportType)
            {
                case MeshExportType.Default:
                    return _meshTools.ExportMesh(cr2wStream, cr2wFileName, meshargs.LodFilter, meshargs.isGLBinary);

                case MeshExportType.WithMaterials:
                    return ExportMeshWithMaterials(cr2wStream, cr2wFileName, meshargs.Archives, meshargs.MaterialRepo,
                        meshargs.MaterialUncookExtension, meshargs.isGLBinary, meshargs.LodFilter);

                case MeshExportType.WithRig:
                {
                    var entry = meshargs.Rig.FirstOrDefault();
                    if (entry == null)
                    {
                        return false;
                    }

                    var ar = entry.Archive as Archive;
                    using var ms = new MemoryStream();
                    ar?.CopyFileToStream(ms, entry.NameHash64, false);

                    return _meshTools.ExportMeshWithRig(cr2wStream, ms, cr2wFileName, meshargs.LodFilter, meshargs.isGLBinary);
                }
                case MeshExportType.Multimesh:
                {
                    var meshes = meshargs.MultiMeshMeshes;
                    var rigs = meshargs.MultiMeshRigs;
                    if (!meshes.Any() || !rigs.Any())
                    {
                        return false;
                    }

                    var meshstreams = meshes.Select(
                            delegate (FileEntry entry)
                            {
                                var ar = entry.Archive as Archive;
                                var ms = new MemoryStream();
                                ar?.CopyFileToStream(ms, entry.NameHash64, false);
                                return (Stream)ms;
                            })
                        .ToList();

                    var rigstreams = rigs.Select(
                            delegate (FileEntry entry)
                            {
                                var ar = entry.Archive as Archive;
                                var ms = new MemoryStream();
                                ar?.CopyFileToStream(ms, entry.NameHash64, false);
                                return (Stream)ms;
                            })
                        .ToList();

                    return _meshTools.ExportMultiMeshWithRig(meshstreams, rigstreams, cr2wFileName, meshargs.LodFilter, meshargs.isGLBinary);
                }
                default:
                    return false;
            }
        }

        private static void UncookWem(string infile, string outfile)
        {
            if (WolvenTesting.IsTesting)
            {
                return;
            }

            var arg = infile.ToEscapedPath() + " -o " + outfile.ToEscapedPath();
            var si = new ProcessStartInfo(
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "lib", "test.exe"),
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
            if (proc != null)
            {
                proc.WaitForExit();
                Trace.WriteLine(proc.StandardOutput.ReadToEnd());
            }
        }

        public IEnumerable<Stream> GenerateBuffers(Stream cr2wStream)
        {
            // read the cr2wfile
            if (!_wolvenkitFileService.TryReadRed4File(cr2wStream, out var cr2w))
            {
                yield break;
            }

            foreach (var buffer in cr2w.GetBuffers())
            {
                var ms = new MemoryStream();
                ms.Write(buffer.GetBytes());

                yield return ms;
            }
        }

        private bool UncookTexarray(Stream cr2wStream, Stream outstream)
        {
            // read the cr2wfile
            var cr2w = _wolvenkitFileService.ReadRed4File(cr2wStream);
            if (cr2w == null || cr2w.RootChunk is not CTextureArray texa || texa.RenderTextureResource.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC blob)
            {
                return false;
            }

            var image = RedImage.FromTexArray(texa);
            outstream.Write(image.SaveToDDSMemory());

            return true;
        }

        private bool UncookEnvprobe(Stream cr2wStream, Stream outstream)
        {
            // read the cr2wfile
            var cr2w = _wolvenkitFileService.ReadRed4File(cr2wStream);
            if (cr2w == null || cr2w.RootChunk is not CReflectionProbeDataResource refl || refl.TextureData.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC blob)
            {
                return false;
            }

            var image = RedImage.FromEnvProbe(refl);
            outstream.Write(image.SaveToDDSMemory());

            return true;
        }

        private bool UncookCubeMap(Stream cr2wStream, Stream outstream)
        {
            // read the cr2wfile
            var cr2w = _wolvenkitFileService.ReadRed4File(cr2wStream);
            if (cr2w == null || cr2w.RootChunk is not CCubeTexture ctex || ctex.RenderTextureResource.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC blob)
            {
                return false;
            }

            var image = RedImage.FromCubeMap(ctex);
            outstream.Write(image.SaveToDDSMemory());

            return true;
        }

        private bool UncookCsv(Stream cr2wStream, Stream outstream)
        {
            // read the cr2wfile
            if (!_wolvenkitFileService.TryReadRed4File(cr2wStream, out var cr2w))
            {
                return false;
            }

            if (cr2w.RootChunk is not C2dArray redcsv)
            {
                return false;
            }


            redcsv.ToCsvStream(outstream);
            return true;
        }

        public bool ConvertXbmToDdsStream(Stream redInFile, Stream outstream, out DXGI_FORMAT texformat, out DXGI_FORMAT decompressedFormat)
        {
            texformat = DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM;
            decompressedFormat = DXGI_FORMAT.DXGI_FORMAT_UNKNOWN;

            // read the cr2wfile
            return _wolvenkitFileService.TryReadRed4File(redInFile, out var cr2w)
&& ConvertRedClassToDdsStream(cr2w.RootChunk, outstream, out texformat, out decompressedFormat);
        }

        public static bool ConvertRedClassToDdsStream(RedBaseClass cls, Stream outstream, out DXGI_FORMAT texformat, out DXGI_FORMAT decompressedFormat)
        {
            texformat = DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM;
            decompressedFormat = DXGI_FORMAT.DXGI_FORMAT_UNKNOWN;

            try
            {
                var img = RedImage.FromRedClass(cls);

                texformat = img.Metadata.Format;
                decompressedFormat = img.Metadata.Format;
                if (img.CompressionFormat != null)
                {
                    texformat = (DXGI_FORMAT)img.CompressionFormat;
                }

                outstream.Write(img.SaveToDDSMemory());

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
