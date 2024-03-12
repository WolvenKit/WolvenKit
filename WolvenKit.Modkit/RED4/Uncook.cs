using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
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
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Wwise;
using WolvenKit.Modkit.Extensions;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.Opus;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.JSON;
using WolvenKit.RED4.Types;

using SharpGLTF.Schema2;
using SharpGLTF.Validation;
using NAudio.Wave;
using NAudio.Lame;
using WolvenKit.RED4.Archive.CR2W;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        private readonly ConcurrentDictionary<string, byte> _uncookedLookup = new();
        
        /// <summary>
        /// Uncooks a single file by hash. This will both extract and uncook the redengine file
        /// </summary>
        /// <param name="archive"></param>
        /// <param name="hash"></param>
        /// <param name="outDir"></param>
        /// <param name="rawOutDir"></param>
        /// <param name="args"></param>
        /// <param name="forceBuffers"></param>
        /// <param name="serialize"></param>
        /// <returns></returns>
        public bool UncookSingle(
            ICyberGameArchive archive,
            ulong hash,
            DirectoryInfo outDir,
            GlobalExportArgs args,
            DirectoryInfo? rawOutDir = null,
            ECookedFileFormat[]? forceBuffers = null,
            bool serialize = false)
        {
            if (!archive.Files.TryGetValue(hash, out var gameFile))
            {
                return false;
            }

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

                // Why is that here? Doesn't work with wem files - S. Eberoth
                //var hasBuffers = (entry.SegmentsEnd - entry.SegmentsStart) > 1;
                //if (!hasBuffers)
                //{
                //    return true;
                //}

                // uncook main file buffers to raw out dir
                if (rawOutDir is null or { Exists: false })
                {
                    rawOutDir = outDir;
                }

                try
                {
                    // wems need the physical infile path
                    args.Get<WemExportArgs>().FileName = mainFileInfo.FullName;
                    return UncookBuffers(cr2WStream, relFileFullName, args, rawOutDir, forceBuffers);
                }
                catch (Exception e)
                {
                    _loggerService.Error($"{relFileFullName} And unexpected error occured while uncooking: {e.Message}");
                    _loggerService.Error(e);
                    return false;
                }

                #endregion extract buffers
            }

            return false;
        }

        /// <summary>
        /// Uncooks a single file by hash. This will both extract and uncook the redengine file
        /// </summary>
        /// <param name="archive"></param>
        /// <param name="hash"></param>
        /// <param name="outDir"></param>
        /// <param name="rawOutDir"></param>
        /// <param name="args"></param>
        /// <param name="forceBuffers"></param>
        /// <param name="serialize"></param>
        /// <returns></returns>
        public async Task<bool> UncookSingleAsync(
            ICyberGameArchive archive,
            ulong hash,
            DirectoryInfo outDir,
            GlobalExportArgs args,
            DirectoryInfo? rawOutDir = null,
            ECookedFileFormat[]? forceBuffers = null,
            bool serialize = false)
        {
            if (!archive.Files.TryGetValue(hash, out var gameFile))
            {
                return false;
            }

            #region unbundle main file

            using var cr2WStream = new MemoryStream();
            await gameFile.ExtractAsync(cr2WStream);

            if (archive.Files[hash] is not FileEntry entry)
            {
                return false;
            }

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
                    await cr2WStream.CopyToAsync(fs);
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
                    await File.WriteAllTextAsync(outpath, jsonOutput);
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
                return UncookBuffers(cr2WStream, relFileFullName, args, rawOutDir, forceBuffers);
            }
            catch (Exception e)
            {
                _loggerService.Error($"{relFileFullName} And unexpected error occured while uncooking: {e.Message}");
                _loggerService.Error(e);
                return false;
            }

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
        /// <param name="forceBuffers"></param>
        /// <param name="serialize"></param>
        /// <returns></returns>
        public void UncookAll(
            ICyberGameArchive ar,
            DirectoryInfo outDir,
            GlobalExportArgs args,
            bool unbundle = false,
            string? pattern = null,
            string? regex = null,
            DirectoryInfo? rawOutDir = null,
            ECookedFileFormat[]? forceBuffers = null,
            bool serialize = false)
        {
            var extractedList = new ConcurrentBag<string>();
            var failedList = new ConcurrentBag<string>();

            // check search pattern then regex
            var finalmatches = ar.Files.Values.Cast<FileEntry>();
            var totalInArchiveCount = ar.Files.Count;
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
                finalMatchesList = finalMatchesList.Where(fileEntry => ar.CanUncook(fileEntry.NameHash64)).ToList();
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
                if (UncookSingle(ar, info.NameHash64, outDir, args, rawOutDir, forceBuffers, serialize))
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

            _progressService.Completed();

            foreach (var failed in failedList)
            {
                _loggerService.Warning($"Failed to uncook {failed}.");
            }

            _loggerService.Success($" {ar.ArchiveAbsolutePath}: Uncooked {extractedList.Count}/{finalMatchesList.Count} files.");
        }

        /// <summary>
        /// Extracts and decompresses buffers of a cr2w stream
        /// uncooks buffers to raw format
        /// </summary>
        /// <param name="cr2wStream">the cooked RedEngine file input stream</param>
        /// <param name="relPath">if a depot is used the relPath is a relative base path, if no depot is used, the relPath is simply the filename</param>
        /// <param name="settings">GlobalExportSettings</param>
        /// <param name="rawOutDir">the output directory. the outfile is combined from the rawOutDir and the relative path</param>
        /// <param name="forceBuffers"></param>
        /// <returns></returns>
        private bool UncookBuffers(Stream cr2wStream, string relPath, GlobalExportArgs settings, DirectoryInfo rawOutDir, ECookedFileFormat[]? forceBuffers = null)
        {
            if (IsUncooked(settings.Get<GeneralExportArgs>().MaterialRepositoryPath, rawOutDir.FullName, relPath))
            {
                return true;
            }

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

            if (!FileTypeHelper.IsCR2WFile(ext))
            {
                if (ext == "wem")
                {
                    if (settings.Get<WemExportArgs>() is { } wemaArgs && wemaArgs.FileName is not null)
                    {
                        UncookWem(outfile, wemaArgs);
                        return true;
                    }

                    return false;
                }

                if (ext == "opusinfo")
                {
                    return HandleOpus(rawOutDir, settings.Get<OpusExportArgs>());
                }

                return false;
            }

            if (!_parserService.TryReadRed4File(cr2wStream, out var cr2wFile))
            {
                return false;
            }

            cr2wFile.MetaData.FileName = relPath;

            return UncookBuffers(cr2wFile, relPath, settings, rawOutDir, forceBuffers, true);
        }

        /// <summary>
        /// Extracts and decompresses buffers of a cr2w file
        /// uncooks buffers to raw format
        /// </summary>
        /// <param name="cr2wFile">the cooked RedEngine file input</param>
        /// <param name="relPath">if a depot is used the relPath is a relative base path, if no depot is used, the relPath is simply the filename</param>
        /// <param name="settings">GlobalExportSettings</param>
        /// <param name="rawOutDir">the output directory. the outfile is combined from the rawOutDir and the relative path</param>
        /// <param name="forceBuffers"></param>
        /// <returns></returns>
        private bool UncookBuffers(CR2WFile cr2wFile, string relPath, GlobalExportArgs settings, DirectoryInfo rawOutDir, ECookedFileFormat[]? forceBuffers = null, bool ignoreLookup = false)
        {
            if (!ignoreLookup && IsUncooked(settings.Get<GeneralExportArgs>().MaterialRepositoryPath, rawOutDir.FullName, relPath))
            {
                return true;
            }

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

            var isForcedBuffer = forceBuffers != null && forceBuffers.Any() && forceBuffers.Select(format => format.ToString()).Contains(ext);
            if (!Enum.GetNames(typeof(ECookedFileFormat)).Contains(ext) || isForcedBuffer)
            {
                var i = 0;

                foreach (var buffer in cr2wFile.GetBuffers())
                {
                    var ms = new MemoryStream();
                    ms.Write(buffer.GetBytes());

                    var bufferpath = $"{outfile.FullName}.{i}.buffer";
                    if (!WolvenTesting.IsTesting)
                    {
                        using var fs = new FileStream(bufferpath, FileMode.Create, FileAccess.Write);
                        i++;
                        ms.Seek(0, SeekOrigin.Begin);
                        ms.CopyTo(fs);
                    }

                    ms.Dispose();
                }

                return true;
            }

            foreach (var embeddedFile in cr2wFile.EmbeddedFiles)
            {
                var embeddedFileName = $"{(ulong)embeddedFile.FileName}.{FileTypeHelper.GetFileExtensions(embeddedFile.Content)[0]}";

                var tmpCr2w = new CR2WFile
                {
                    MetaData = new CR2WMetaData
                    {
                        FileName = embeddedFile.FileName
                    },
                    RootChunk = embeddedFile.Content
                };

                UncookBuffers(tmpCr2w, $"{cr2wFile.MetaData.FileName}_embedded\\{embeddedFileName}", settings, rawOutDir, forceBuffers);
            }

            // handle files where uncook methods ARE implemented
            if (!Enum.TryParse(ext, true, out ECookedFileFormat extAsEnum))
            {
                return false;
            }

            return InternalUncookBuffers(cr2wFile, relPath, outfile, settings, rawOutDir);
        }

        public bool IsUncooked(string? depotPath, string destName, string relPath)
        {
            if (depotPath is not null &&
                destName.StartsWith(depotPath) &&
                !_uncookedLookup.TryAdd(relPath, 0))
            {
                return true;
            }

            return false;
        }

        private bool InternalUncookBuffers(CR2WFile cr2wFile, string relPath, FileInfo outfile, GlobalExportArgs settings, DirectoryInfo rawOutDir)
        {
            // uncook textures, meshes etc
            //args.FileName = outFileInfo.FullName;
            switch (cr2wFile.RootChunk)
            {
                case Multilayer_Mask mlMask:
                    return UncookMlmask(mlMask, outfile, settings.Get<MlmaskExportArgs>());

                case CMesh:
                    try
                    {
                        if (settings.Get<MeshExportArgs>().MeshExporter == MeshExporterType.Experimental)
                        {
                            _loggerService.Info("Using new mesh exporter.");
                            return HandleMeshesAndRigs(cr2wFile, outfile, settings.Get<MeshExportArgs>());
                        }

                        _loggerService.Info("Using classic mesh exporter.");
                        return HandleMesh(cr2wFile, outfile, settings.Get<MeshExportArgs>());
                    }
                    catch (Exception e)
                    {
                        _loggerService.Error($"{relPath} - {e.Message}");
                        _loggerService.Error(e);

                        return false;
                    }

                case MorphTargetMesh:
                    // We're tacking on an extra file ext because ***SharpGLTF*** cuts off the ext
                    // when actually writing to disk way down the line. This way it'll save the
                    // actual type extension we want it to...
                    var typePreservingOutfile = new FileInfo($"{outfile.FullName}.dummyextguardthatwillberemoved");

                    return ExportMorphTargets(cr2wFile, typePreservingOutfile, settings.Get<MorphTargetExportArgs>().IsBinary);

                case animAnimSet:
                    try
                    {
                        return ExportAnim(cr2wFile, outfile, settings.Get<AnimationExportArgs>().IsBinary, settings.Get<AnimationExportArgs>().incRootMotion);
                    }
                    catch (Exception e)
                    {
                        _loggerService.Error($"{relPath} - {e.Message}");
                        _loggerService.Error(e);

                        return false;
                    }
                case CBitmapTexture:
                    return HandleXbm(cr2wFile, outfile, settings.Get<XbmExportArgs>());
                case C2dArray:
                {
                    if (WolvenTesting.IsTesting)
                    {
                        using var ms = new MemoryStream();
                        return UncookCsv(cr2wFile, ms);
                    }

                    using var fs = new FileStream($"{outfile.FullName}.csv", FileMode.Create, FileAccess.Write);
                    return UncookCsv(cr2wFile, fs);
                }
                case CCubeTexture:
                {
                    if (WolvenTesting.IsTesting)
                    {
                        using var ms = new MemoryStream();
                        return UncookCubeMap(cr2wFile, ms);
                    }
                    var newpath = Path.ChangeExtension(outfile.FullName, ERawFileFormat.dds.ToString());
                    using var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                    return UncookCubeMap(cr2wFile, ddsStream);
                }
                case CReflectionProbeDataResource:
                {
                    if (WolvenTesting.IsTesting)
                    {
                        using var ms = new MemoryStream();
                        return UncookEnvprobe(cr2wFile, ms);
                    }
                    var newpath = Path.ChangeExtension(outfile.FullName, ERawFileFormat.dds.ToString());
                    using var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                    return UncookEnvprobe(cr2wFile, ddsStream);
                }
                case CTextureArray cTextureArray:
                {
                    if (WolvenTesting.IsTesting)
                    {
                        using var ms = new MemoryStream();
                        return UncookTexarray(cTextureArray, ms);
                    }
                    var newpath = Path.ChangeExtension(outfile.FullName, ERawFileFormat.dds.ToString());
                    using var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                    return UncookTexarray(cTextureArray, ddsStream);
                }
                case rendFont rendFont:
                {
                    if (WolvenTesting.IsTesting)
                    {
                        using var ms = new MemoryStream();
                        return UncookFont(rendFont, ms);
                    }
                    var newpath = Path.ChangeExtension(outfile.FullName, ERawFileFormat.ttf.ToString());
                    using var ttfStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write);
                    return UncookFont(rendFont, ttfStream);
                }
                case inkTextureAtlas inkTextureAtlas:
                {
                    return UncookInkAtlas(inkTextureAtlas, outfile);
                }

                default:
                    throw new ArgumentOutOfRangeException($"Uncooking failed for type: {cr2wFile.RootChunk.GetType().Name}.");
            }
        }
        
        private bool HandleXbm(CR2WFile cr2wFile, FileInfo outfile, XbmExportArgs xbmargs)
        {
            if (WolvenTesting.IsTesting)
            {
                using var ms = new MemoryStream();
                return ConvertRedClassToDdsStream(cr2wFile.RootChunk, ms, out _, out _, true);
            }

            if (cr2wFile.RootChunk is not CBitmapTexture bitmapTexture)
            {
                return false;
            }

            var redImage = RedImage.FromXBM(bitmapTexture);

            var destFile = Path.ChangeExtension(outfile.FullName, xbmargs.UncookExtension.ToString());

            if (bitmapTexture.Setup.Group == Enums.GpuWrapApieTextureGroup.TEXG_Generic_LUT)
            {
                switch (xbmargs.UncookExtension)
                {
                    case EUncookExtension.dds:
                        redImage.FlipV(); // Not sure yet
                        redImage.SaveToDDS(destFile);
                        break;
                    case EUncookExtension.png:
                        redImage.SaveToHald(destFile);
                        break;
                    case EUncookExtension.cube:
                        redImage.SaveToCube(destFile);
                        break;
                    case EUncookExtension.tga:
                    case EUncookExtension.bmp:
                    case EUncookExtension.jpg:
                    case EUncookExtension.tiff:
                        _loggerService.Error($"Exporting to \"{xbmargs.UncookExtension}\" is not supported for LUT files");
                        return false;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                redImage.FlipV();
                switch (xbmargs.UncookExtension)
                {
                    case EUncookExtension.dds:
                        redImage.SaveToDDS(destFile);
                        break;
                    case EUncookExtension.tga:
                        redImage.SaveToTGA(destFile);
                        break;
                    case EUncookExtension.bmp:
                        redImage.SaveToBMP(destFile);
                        break;
                    case EUncookExtension.jpg:
                        redImage.SaveToJPEG(destFile);
                        break;
                    case EUncookExtension.png:
                        redImage.SaveToPNG(destFile);
                        break;
                    case EUncookExtension.tiff:
                        redImage.SaveToTIFF(destFile);
                        break;
                    case EUncookExtension.cube:
                        _loggerService.Error($"Exporting to \"cube\" is not supported for non LUT files");
                        return false;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return true;
        }

        public bool UncookXBM(Stream cr2wStream, FileInfo outfile, GlobalExportArgs settings) => 
            _parserService.TryReadRed4File(cr2wStream, out var cr2w) && 
            cr2w.RootChunk is CBitmapTexture cBitmapTexture && 
            UncookXBM(cBitmapTexture, outfile, settings);

        public bool UncookXBM(CBitmapTexture cBitmapTexture, FileInfo outfile, GlobalExportArgs settings)
        {
            if (settings.Get<XbmExportArgs>() is not { } xbmargs)
            {
                return false;
            }

            if (WolvenTesting.IsTesting)
            {
                using var ms = new MemoryStream();
                return ConvertRedClassToDdsStream(cBitmapTexture, ms, out _, out _, true);
            }

            using (var ms = new MemoryStream())
            {
                // always flip on export
                if (!ConvertRedClassToDdsStream(cBitmapTexture, ms, out _, out var decompressedFormat, true))
                {
                    return false;
                }

                // convert if needed else save to file
                var ddsPath = Path.ChangeExtension(outfile.FullName, ERawFileFormat.dds.ToString());
                if (xbmargs.UncookExtension != EUncookExtension.dds)
                {
                    ms.Seek(0, SeekOrigin.Begin);
                    return Texconv.ConvertFromDdsAndSave(ms, ddsPath, xbmargs, false, decompressedFormat);
                }

                using var fs = new FileStream(ddsPath, FileMode.Create, FileAccess.Write);
                ms.Seek(0, SeekOrigin.Begin);
                ms.CopyTo(fs);
            }

            return true;
        }

        private bool HandleOpus(DirectoryInfo rawOutDir, OpusExportArgs opusExportArgs)
        {
            if (opusExportArgs.SelectedForExport.Count == 0)
            {
                return true;
            }
            
            OpusTools.ExportOpusUsingHash(_archiveManager, opusExportArgs.SelectedForExport, opusExportArgs.UseMod, rawOutDir);

            return true;
        }

        private string SerializeMainFile(Stream redstream)
        {
            if (_parserService.TryReadRed4File(redstream, out var cr2w))
            {
                var dto = new RedFileDto(cr2w);
                var json = RedJsonSerializer.Serialize(dto);
                return json;
            }
            throw new Red4ParserException();
        }

        private bool UncookInkAtlas(inkTextureAtlas inkTextureAtlas, FileInfo outFile)
        {
            if (!RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return false;
            }

            if (inkTextureAtlas.ActiveTexture != Enums.inkTextureType.StaticTexture)
            {
                // only static for now
                return false;
            }

            if (inkTextureAtlas.Texture.DepotPath != ResourcePath.Empty)
            {
                ExtractParts(inkTextureAtlas.Texture.DepotPath, inkTextureAtlas.Parts, Path.Combine(outFile.FullName, "main"));
            }

            if (inkTextureAtlas.Slots[0] != null && inkTextureAtlas.Slots[0]!.Texture.DepotPath != ResourcePath.Empty)
            {
                ExtractParts(inkTextureAtlas.Slots[0]!.Texture.DepotPath, inkTextureAtlas.Slots[0]!.Parts, Path.Combine(outFile.FullName, "2160p"));
            }

            if (inkTextureAtlas.Slots[1] != null && inkTextureAtlas.Slots[1]!.Texture.DepotPath != ResourcePath.Empty)
            {
                ExtractParts(inkTextureAtlas.Slots[1]!.Texture.DepotPath, inkTextureAtlas.Slots[1]!.Parts, Path.Combine(outFile.FullName, "1080p"));
            }

            if (inkTextureAtlas.Slots[2] != null && inkTextureAtlas.Slots[2]!.Texture.DepotPath != ResourcePath.Empty)
            {
                ExtractParts(inkTextureAtlas.Slots[2]!.Texture.DepotPath, inkTextureAtlas.Slots[2]!.Parts, Path.Combine(outFile.FullName, "720p"));
            }

            return true;

            void ExtractParts(ResourcePath texturePath, CArray<inkTextureAtlasMapper> parts, string outDir)
            {
                var xbmFile = _archiveManager.Lookup(texturePath);

                if (!xbmFile.HasValue)
                {
                    _loggerService.Error($"File: {texturePath} was not found in any archive.");
                    return;
                }

                Directory.CreateDirectory(outDir);

                using var ms = new MemoryStream();
                xbmFile.Value.Extract(ms);
                ms.Seek(0, SeekOrigin.Begin);

                if (_parserService.TryReadRed4File(ms, out var file))
                {
                    var img = RedImage.FromRedFile(file);
                    img.FlipV();

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

        private bool UncookFont(rendFont font, Stream outstream)
        {
            outstream.Write(font.FontBuffer.Buffer.GetBytes());

            return true;
        }

        public bool ExportMaterials(CR2WFile cr2w, FileInfo outfile, MeshExportArgs meshExportArgs)
        {
            if (meshExportArgs.MaterialRepo is null)
            {
                _loggerService.Error("Depot path is not set: Choose a Depot location within Settings for generating materials.");
                return false;
            }

            if (cr2w.RootChunk is not CMesh { RenderResourceBlob.Chunk: rendRenderMeshBlob rendblob } cMesh)
            {
                return false;
            }

            var meshesInfo = MeshTools.GetMeshesinfo(rendblob, cMesh);

            ParseMaterials(cr2w, outfile, meshExportArgs.MaterialRepo, meshesInfo, meshExportArgs.MaterialUncookExtension);

            return true;
        }
        
        public bool ExportMeshWithRig(CR2WFile cr2w, Stream rigStream, FileInfo outfile, MeshExportArgs meshExportArgs, ValidationMode vmode = ValidationMode.TryFix)
        {
            if (cr2w.RootChunk is not CMesh { RenderResourceBlob.Chunk: rendRenderMeshBlob rendblob } cMesh)
            {
                return false;
            }

            using var ms = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

            var meshesinfo = MeshTools.GetMeshesinfo(rendblob, cMesh);

            var expMeshes = MeshTools.ContainRawMesh(ms, meshesinfo, meshExportArgs.LodFilter);
            MeshTools.UpdateSkinningParamCloth(ref expMeshes, cr2w);

            MeshTools.WriteGarmentParametersToMesh(ref expMeshes, cMesh, meshExportArgs.ExportGarmentSupport);

            var meshRig = MeshTools.GetOrphanRig(cMesh);

            var Rig = RIG.ProcessRig(_parserService.ReadRed4File(rigStream));

            MeshTools.UpdateMeshJoints(ref expMeshes, Rig, meshRig);

            if (meshExportArgs.withMaterials)
            {
                if (meshExportArgs.MaterialRepo is null)
                {
                    _loggerService.Error("Depot path is not set: Choose a Depot location within Settings for generating materials.");
                    return false;
                }
                ParseMaterials(cr2w, outfile, meshExportArgs.MaterialRepo, meshesinfo, meshExportArgs.MaterialUncookExtension);
            }

            var model = MeshTools.RawMeshesToGLTF(expMeshes, Rig);

            if (WolvenTesting.IsTesting)
            {
                model.WriteGLB(new WriteSettings(vmode));
                return true;
            }

            if (meshExportArgs.isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vmode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vmode));
            }

            rigStream.Dispose();
            rigStream.Close();

            return true;
        }


        public bool ExportMultiMeshWithRig(Dictionary<CR2WFile, string> meshFiles, List<CR2WFile> rigFiles, FileInfo outfile, MeshExportArgs meshExportArgs, ValidationMode vmode = ValidationMode.TryFix)
        {
            var rigs = new List<RawArmature>();
            foreach (var cr2w in rigFiles)
            {
                rigs.Add(RIG.ProcessRig(cr2w).NotNull());
            }
            var expRig = RIG.CombineRigs(rigs);

            var expMeshes = new List<RawMeshContainer>();
            var matData = new List<MatData>();
            foreach (var (cr2w, meshName) in meshFiles)
            {
                if (cr2w.RootChunk is not CMesh { RenderResourceBlob.Chunk: rendRenderMeshBlob rendblob } cMesh)
                {
                    continue;
                }

                using var ms = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

                var meshesinfo = MeshTools.GetMeshesinfo(rendblob, cMesh, meshName);

                var Meshes = MeshTools.ContainRawMesh(ms, meshesinfo, meshExportArgs.LodFilter,  ulong.MaxValue,  false, meshName);
                MeshTools.UpdateSkinningParamCloth(ref Meshes, cr2w);

                MeshTools.WriteGarmentParametersToMesh(ref Meshes, cMesh, meshExportArgs.ExportGarmentSupport);

                var meshRig = MeshTools.GetOrphanRig(cMesh);

                MeshTools.UpdateMeshJoints(ref Meshes, expRig, meshRig, meshName);

                if (meshExportArgs.withMaterials)
                {
                    if (meshExportArgs.MaterialRepo is null)
                    {
                        _loggerService.Error("Depot path is not set: Choose a Depot location within Settings for generating materials.");
                        return false;
                    }
                    matData.Add(SetupMaterial(cr2w, meshExportArgs.MaterialRepo, meshesinfo, meshExportArgs.MaterialUncookExtension));
                }

                expMeshes.AddRange(Meshes);
            }
            var model = MeshTools.RawMeshesToGLTF(expMeshes, expRig, withMaterials: meshExportArgs.withMaterials);

            SaveMaterials(outfile, matData);

            if (WolvenTesting.IsTesting)
            {
                model.WriteGLB(new WriteSettings(vmode));
                return true;
            }

            if (meshExportArgs.isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vmode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vmode));
            }

            return true;
        }

        public bool ExportMesh(CR2WFile cr2w, FileInfo outfile, MeshExportArgs meshExportArgs, ValidationMode vmode = ValidationMode.TryFix)
        {
            var eUncookExtension = meshExportArgs.MaterialUncookExtension;

            if (cr2w.RootChunk is not CMesh { RenderResourceBlob.Chunk: rendRenderMeshBlob rendblob } cMesh)
            {
                return false;
            }

            using var ms = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

            var meshesinfo = MeshTools.GetMeshesinfo(rendblob, cMesh);

            if (meshExportArgs.withMaterials)
            {
                if (meshExportArgs.MaterialRepo is null)
                {
                    _loggerService.Error("Depot path is not set: Choose a Depot location within Settings for generating materials.");
                    return false;
                }
                ParseMaterials(cr2w, outfile, meshExportArgs.MaterialRepo, meshesinfo, eUncookExtension);
            }

            return MeshTools.ExportMesh(cr2w, outfile, meshExportArgs, vmode);
        }

        private bool HandleMesh(CR2WFile cr2wFile, FileInfo cr2wFileName, MeshExportArgs meshargs)
        {
            switch (meshargs.meshExportType)
            {
                case MeshExportType.MeshOnly:
                    return ExportMesh(cr2wFile, cr2wFileName, meshargs);

                case MeshExportType.WithRig:
                {
                    var entry = meshargs.Rig.FirstOrDefault();
                    if (entry is null)
                    {
                        _loggerService.Error("WithRig: No rig specified, add one to the export");
                        return false;
                    }

                    using var ms = new MemoryStream();
                    entry.Extract(ms);

                    return ExportMeshWithRig(cr2wFile, ms, cr2wFileName, meshargs);
                }
                case MeshExportType.Multimesh:
                {
                    var meshes = meshargs.MultiMeshMeshes;
                   
                    var rigs = meshargs.MultiMeshRigs;
                    if (!meshes.Any() || !rigs.Any())
                    {
                        _loggerService.Error($"MultiMesh: need at least 1 extra mesh ({meshes.Count}) or rig ({rigs.Count})");
                        return false;
                    }

                    var rigFiles = rigs.Select(
                            delegate (FileEntry entry)
                            {
                                var ms = new MemoryStream();
                                entry.Extract(ms);
                                return _parserService.ReadRed4File(ms)!;
                            })
                        .ToList();


                    var meshFiles = meshes.Select(
                              delegate (FileEntry entry)
                              {
                                  var ms = new MemoryStream();
                                  entry.Extract(ms);

                                  var cr2w = _parserService.ReadRed4File(ms)!;
                                  cr2w.MetaData.FileName = entry.FileName;

                                  return new KeyValuePair<CR2WFile, string>(_parserService.ReadRed4File(ms)!, entry.FileName);
                              }).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

                    if (!meshFiles.ContainsKey(cr2wFile))
                    {
                        meshFiles.Add(cr2wFile, cr2wFileName.Name);
                    }

                    return ExportMultiMeshWithRig(meshFiles, rigFiles, cr2wFileName, meshargs);
                }
                default:
                    return false;
            }
        }

#region NewMeshExporter

        // Unified Mesh exporter

        public bool ExportMeshesAndRigs(Dictionary<CR2WFile, string> meshFiles, List<CR2WFile> rigFiles, FileInfo outfile, MeshExportArgs meshExportArgs, ValidationMode validationMode = ValidationMode.TryFix)
        {
            if (meshExportArgs is { withMaterials: true, MaterialRepo: null })
            {
                _loggerService.Error("Materials requested but Depot path is not set: choose a Depot location within Settings for generating materials.");
                return false;
            }

            var rigsCombinedToExport = ProcessRigs(rigFiles);
            var (meshesToExport, materialDataToExport) = ProcessMeshesAndMaterials(meshFiles, rigsCombinedToExport);

            var modelsAndRigsCombinedToExport = MeshTools.RawMeshesToGLTF(meshesToExport, rigsCombinedToExport, withMaterials: meshExportArgs.withMaterials);

            SaveMaterials(outfile, materialDataToExport);
            SaveMeshes(outfile, modelsAndRigsCombinedToExport);

            _loggerService.Info($"Mesh export completed, {meshesToExport.Count} meshes, {materialDataToExport.Count} materials, {rigsCombinedToExport.Names?.Length ?? 0} bones");
            return true;


            // Helpers

            RawArmature ProcessRigs(List<CR2WFile> localRigFiles)
            {
                var rigs = localRigFiles.Select(rigFile => RIG.ProcessRig(rigFile).NotNull()).ToList();
                return RIG.CombineRigs(rigs);
            }

            (List<RawMeshContainer>, List<MatData>) ProcessMeshesAndMaterials(Dictionary<CR2WFile, string> localMeshFiles, RawArmature rigsCombined)
            {
                var expMeshes = new List<RawMeshContainer>();
                var matData = new List<MatData>();
                foreach (var (cr2w, streamName) in localMeshFiles)
                {
                    if (cr2w.RootChunk is not CMesh { RenderResourceBlob.Chunk: rendRenderMeshBlob rendBlob } cMesh)
                    {
                        _loggerService.Error($"Mesh stream does not look valid: {streamName}");
                        continue;
                    }

                    using var ms = new MemoryStream(rendBlob.RenderBuffer.Buffer.GetBytes());

                    var meshesInfo = MeshTools.GetMeshesinfo(rendBlob, cMesh);

                    var meshes = MeshTools.ContainRawMesh(ms, meshesInfo, meshExportArgs.LodFilter);
                    MeshTools.UpdateSkinningParamCloth(ref meshes, cr2w);

                    MeshTools.WriteGarmentParametersToMesh(ref meshes, cMesh, meshExportArgs.ExportGarmentSupport);

                    var meshRig = MeshTools.GetOrphanRig(cMesh);

                    MeshTools.UpdateMeshJoints(ref meshes, rigsCombined, meshRig, streamName);

                    if (meshExportArgs is { withMaterials: true, MaterialRepo: not null })
                    {
                        matData.Add(SetupMaterial(cr2w, meshExportArgs.MaterialRepo, meshesInfo, meshExportArgs.MaterialUncookExtension, meshExportArgs.MeshExporter == MeshExporterType.Experimental));
                    }

                    expMeshes.AddRange(meshes);
                }

                return (expMeshes, matData);
            }

            void SaveMeshes(FileInfo file, ModelRoot modelsAndRigs)
            {
                var typeExtPreservingFilename = $"{file.FullName}.thisextwillberemoved";

                if (meshExportArgs.isGLBinary)
                {
                    modelsAndRigs.SaveGLB(typeExtPreservingFilename, new WriteSettings(validationMode));
                }
                else
                {
                    modelsAndRigs.SaveGLTF(typeExtPreservingFilename, new WriteSettings(validationMode));
                }
            }
        }

        // Not sure if this really needs to be two separate functions,
        // but it keeps the line count a bit shorter at least.
        private bool HandleMeshesAndRigs(CR2WFile cr2wFile, FileInfo cr2wFileName, MeshExportArgs meshArgs)
        {
            var meshFiles = meshArgs.meshExportType switch {
                MeshExportType.Multimesh => FilesToCR2Ws(meshArgs.MultiMeshMeshes),
                MeshExportType.WithRig => new Dictionary<CR2WFile, string> { { cr2wFile, cr2wFileName.Name } },
                MeshExportType.MeshOnly => new Dictionary<CR2WFile, string> { { cr2wFile, cr2wFileName.Name } },
                _ => throw new ArgumentOutOfRangeException(nameof(meshArgs.meshExportType), meshArgs.meshExportType, "This isn't a mesh to export")
            };

            var rigFiles = meshArgs.meshExportType switch
            {
                MeshExportType.Multimesh => FilesToCR2Ws(meshArgs.MultiMeshRigs).Keys.ToList(),
                MeshExportType.WithRig => FilesToCR2Ws(meshArgs.Rig.GetRange(0, 1)).Keys.ToList(),
                MeshExportType.MeshOnly => new(),
                _ => throw new ArgumentOutOfRangeException(nameof(meshArgs.meshExportType), meshArgs.meshExportType, "This isn't a mesh to export")
            };

            if (!meshFiles.ContainsKey(cr2wFile))
            {
                meshFiles.Add(cr2wFile, cr2wFileName.Name);
            }

            if (!meshFiles.Any())
            {
                _loggerService.Warning("Export: no meshes found! Exporting just a rig is probably not supported but let's give it a try");
            }
            else if (!rigFiles.Any() && meshArgs.meshExportType != MeshExportType.MeshOnly)
            {
                _loggerService.Warning("Export: no rigs found, WithRig and Multimesh might require one! So if this fails, that might be why..");
            }
            else if (!meshFiles.Any() && !rigFiles.Any())
            {
                _loggerService.Warning("Export: neither meshes nor rigs found! This I can't work with");
                return false;
            }

            return ExportMeshesAndRigs(meshFiles, rigFiles, cr2wFileName, meshArgs);
            
            Dictionary<CR2WFile, string> FilesToCR2Ws(List<FileEntry> files) =>            
                files.Select(
                      delegate (FileEntry entry)
                      {
                          var ms = new MemoryStream();
                          entry.Extract(ms);

                          var cr2w = _parserService.ReadRed4File(ms)!;
                          cr2w.MetaData.FileName = entry.FileName;

                          return new KeyValuePair<CR2WFile, string>(cr2w, entry.FileName);
                      }).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            
        }

#endregion NewMeshExporter

        private static void UncookWem(FileInfo outfile, WemExportArgs args)
        {
            if (args.FileName is null)
            {
                return;
            }
            if (WolvenTesting.IsTesting)
            {
                return;
            }

            var wemOutFile = Path.ChangeExtension(outfile.FullName, args.wemExportType.ToString());

            if (!Wem.TryConvert(File.ReadAllBytes(args.FileName), out var oggBuffer))
            {
                return;
            }

            switch (args.wemExportType)
            {
                case WemExportTypes.Wav:
                {
                    using var ms = new MemoryStream(oggBuffer);
                    using var reader = new NAudio.Vorbis.VorbisWaveReader(ms);
                    WaveFileWriter.CreateWaveFile(wemOutFile, reader);

                    break;
                }
                case WemExportTypes.Mp3:
                {
                    using var ms = new MemoryStream(oggBuffer);
                    using var reader = new NAudio.Vorbis.VorbisWaveReader(ms);

                    var mp3Writer = new LameMP3FileWriter(wemOutFile, reader.WaveFormat, 128);
                    reader.CopyTo(mp3Writer);
                    mp3Writer.Flush();
                    mp3Writer.Close();

                    break;
                }
                case WemExportTypes.Ogg:
                {
                    File.WriteAllBytes(wemOutFile, oggBuffer);

                    break;
                }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private bool UncookTexarray(CTextureArray cTextureArray, Stream outStream)
        {
            if (cTextureArray.RenderTextureResource.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC)
            {
                return false;
            }

            var image = RedImage.FromTexArray(cTextureArray);
            outStream.Write(image.SaveToDDSMemory());

            return true;
        }

        private bool UncookEnvprobe(CR2WFile cr2w, Stream outStream)
        {
            if (cr2w.RootChunk is not CReflectionProbeDataResource refl || refl.TextureData.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC)
            {
                return false;
            }

            var image = RedImage.FromEnvProbe(refl);
            outStream.Write(image.SaveToDDSMemory());

            return true;
        }

        private bool UncookCubeMap(CR2WFile cr2w, Stream outStream)
        {
            if (cr2w.RootChunk is not CCubeTexture ctex || ctex.RenderTextureResource.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC)
            {
                return false;
            }

            var image = RedImage.FromCubeMap(ctex);
            outStream.Write(image.SaveToDDSMemory());

            return true;
        }

        private bool UncookCsv(CR2WFile cr2w, Stream outStream)
        {
            if (cr2w.RootChunk is not C2dArray redcsv)
            {
                return false;
            }


            redcsv.ToCsvStream(outStream);
            return true;
        }

        public static bool ConvertRedClassToDdsStream(RedBaseClass cls, Stream outStream, out DXGI_FORMAT texFormat, out DXGI_FORMAT decompressedFormat, bool flipV)
        {
            texFormat = DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM;
            decompressedFormat = DXGI_FORMAT.DXGI_FORMAT_UNKNOWN;

            try
            {
                var img = RedImage.FromRedClass(cls);

                texFormat = img.Metadata.Format;
                decompressedFormat = img.Metadata.Format;
                if (img.UncompressedFormat != null)
                {
                    decompressedFormat = (DXGI_FORMAT)img.UncompressedFormat;
                }

                if (flipV)
                {
                    img.FlipV();
                }

                outStream.Write(img.SaveToDDSMemory());

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
