using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DynamicData.Kernel;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Helpers;
using WolvenKit.Modkit.Extensions;
using WolvenKit.Modkit.RED4.MLMask;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;
using static WolvenKit.Modkit.RED4.MLMask.MLMASK;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.Modkit.RED4
{
    /// <summary>
    /// Collection of common modding utilities.
    /// </summary>
    public partial class ModTools
    {
        /// <summary>
        /// Imports a raw File to a RedEngine file (e.g. .dds to .xbm, .fbx to .mesh)
        /// </summary>
        /// <param name="rawRelative"></param>
        /// <param name="args"></param>
        /// <param name="outDir">can be a depotpath, or if null the parent directory of the rawfile</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<bool> Import(RedRelativePath rawRelative, GlobalImportArgs args, DirectoryInfo? outDir = null)
        {
            #region checks

            if (rawRelative is null or { Exists: false })
            {
                return false;
            }
            if (outDir is not { Exists: true })
            {
                outDir = rawRelative.BaseDirectory;
            }

            #endregion

            // check if the file can be directly imported
            // if not, rebuild buffers
            if (!Enum.TryParse(rawRelative.Extension, true, out ERawFileFormat extAsEnum))
            {
                return RebuildBuffer(rawRelative, outDir);
            }

            // import files
            return extAsEnum switch
            {
                ERawFileFormat.bmp or ERawFileFormat.jpg or ERawFileFormat.png or ERawFileFormat.tiff or ERawFileFormat.tga or ERawFileFormat.dds or ERawFileFormat.cube => HandleTextures(rawRelative, outDir, args),
                ERawFileFormat.gltf or ERawFileFormat.glb => ImportGltf(rawRelative, outDir, args.Get<GltfImportArgs>()),
                ERawFileFormat.fbx => ImportFbx(rawRelative, outDir, args.Get<CommonImportArgs>()),
                ERawFileFormat.masklist => ImportMlmask(rawRelative, outDir),
                ERawFileFormat.ttf => ImportTtf(rawRelative, outDir, args.Get<CommonImportArgs>()),
                ERawFileFormat.wav => ImportWav(rawRelative, outDir, args.Get<OpusImportArgs>()),
                ERawFileFormat.csv => ImportCsv(rawRelative, outDir, args),
                ERawFileFormat.re => await ImportAnims(rawRelative, outDir, args.Get<ReImportArgs>()),
                _ => throw new ArgumentOutOfRangeException(),
            };
        }

        private void EnsureFolder(string path)
        {
            var directoryName = Path.GetDirectoryName(path);
            if (directoryName?.Length > 0)
            {
                Directory.CreateDirectory(directoryName);
            }
        }

        private bool ImportFbx(RedRelativePath rawRelative, DirectoryInfo outDir, CommonImportArgs commonImportArgs)
        {
            _loggerService.Warning($"Use WolvenKit or REDmod to import fbx.");
            return false;
        }

        private Task<bool> ImportAnims(RedRelativePath rawRelative, DirectoryInfo outDir, ReImportArgs importArgs)
        {
            var ext = rawRelative.Extension;
            if (Enum.TryParse(ext, true, out ERawFileFormat extAsEnum))
            {
                var redModPath = importArgs.RedMod;
                if (File.Exists(redModPath))
                {
                    importArgs.Input = rawRelative.FullPath;
                    var args = importArgs.GetReImportArgs();
                    var workingDir = Path.GetDirectoryName(redModPath);

                    _loggerService.Info($"WorkDir: {workingDir}");
                    _loggerService.Info($"Running commandlet: {args}");
                    return ProcessUtil.RunProcessAsync(redModPath, args, workingDir);
                }
                else
                {
                    _loggerService.Error("redMod.exe not found");
                }
            }

            return Task.FromResult(false);
        }

        private bool ImportCsv(RedRelativePath rawRelative, DirectoryInfo outDir, GlobalImportArgs args)
        {
            // community_system2.csv.csv
            var ext = rawRelative.Extension;
            if (Enum.TryParse(ext, true, out ERawFileFormat extAsEnum))
            {

                // create redfile
                var red = new CR2WFile();

                var c2dArray = new C2dArray
                {
                    CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC
                };

                // from csv
                using (var infs = new FileStream(rawRelative.FullPath, FileMode.Open))
                {
                    c2dArray.FromCsvStream(infs);
                }

                // add chunk
                red.RootChunk = c2dArray;

                // write
                var outpath = new RedRelativePath(rawRelative)
                    .ChangeBaseDir(outDir)
                    .ChangeExtension("");
                EnsureFolder(outpath.FullPath);
                using var fs = new FileStream(outpath.FullPath, FileMode.Create, FileAccess.ReadWrite);
                using var writer = new CR2WWriter(fs) { LoggerService = _loggerService };
                writer.WriteFile(red);

                return true;
            }

            return false;
        }

        private bool ImportWav(RedRelativePath rawRelative, DirectoryInfo outDir, OpusImportArgs opusImportArgs)
        {
            _loggerService.Warning($"Use WolvenKit to import opus.");
            return false;
        }

        private bool ImportMlmask(RedRelativePath rawRelative, DirectoryInfo outDir)
        {
            var mlmask = new MLMASK(new MlMaskContainer(), _loggerService);
            var ext = rawRelative.Extension;
            if (Enum.TryParse(ext, true, out ERawFileFormat extAsEnum))
            {
                if (extAsEnum != ERawFileFormat.masklist)
                {
                    return false;
                }

                var redfile = new RedRelativePath(rawRelative)
                    .ChangeBaseDir(outDir)
                    .ChangeExtension(ERedExtension.mlmask.ToString());

                try
                {
                    mlmask.Import(rawRelative.ToFileInfo(), redfile.ToFileInfo());
                    _loggerService.Success($"Successfully created {redfile}");
                    return true;
                }
                catch (Exception e)
                {
                    _loggerService.Error(e);
                    return false;
                }
            }

            _loggerService.Error($"Unexpected error occured while importing {rawRelative}");
            return false;
        }

        private bool HandleTextures(RedRelativePath rawRelative, DirectoryInfo outDir, GlobalImportArgs args)
        {
            // dds can be imported to cubemap, envprobe, texarray, xbm, mlmask

            // check for keep

            // find redparents
            foreach (var cookedTextureFormat in Enum.GetValues<ECookedTextureFormat>())
            {
                // check for mlmaskparent
                if (cookedTextureFormat == ECookedTextureFormat.mlmask)
                {

                }
                else
                {
                    // find the first matching redfile
                    var redfile = FindRedFile(rawRelative, outDir, cookedTextureFormat.ToString());
                    if (!string.IsNullOrEmpty(redfile))
                    {
                        return cookedTextureFormat == ECookedTextureFormat.xbm
                            ? ImportXbm(rawRelative, outDir, args.Get<XbmImportArgs>())
                            : RebuildTexture(redfile);
                    }
                    else
                    {
                        return ImportXbm(rawRelative, outDir, args.Get<XbmImportArgs>());
                    }
                }
            }

            _loggerService.Warning($"No existing redfile found to rebuild for {rawRelative.Name}");
            return false;

            bool RebuildTexture(string redparent)
            {
                var ddsPath = Path.ChangeExtension(rawRelative.FullName, ERawFileFormat.dds.ToString());

                using var fileStream = new FileStream(redparent, FileMode.Open, FileAccess.ReadWrite);
                var result = Rebuild(fileStream, new List<FileInfo>() { new(ddsPath ?? throw new InvalidOperationException()) });

                if (result)
                {
                    _loggerService.Success($"Rebuilt {redparent} with buffers");
                }
                else
                {
                    _loggerService.Error($"Failed to rebuild {redparent} with buffers");
                }

                return result;
            }
        }

        /// <summary>
        ///  Imports or rebuilds a folder
        /// </summary>
        /// <param name="inDir"></param>
        /// <param name="args"></param>
        /// <param name="outDir">must match the relative paths in indir!</param>
        /// <returns></returns>
        public async Task<bool> ImportFolder(DirectoryInfo inDir, GlobalImportArgs args, DirectoryInfo? outDir = null)
        {
            #region checks

            if (inDir is not { Exists: true })
            {
                return false;
            }
            if (outDir is not { Exists: true })
            {
                outDir = inDir;
            }

            #endregion

            // process buffers
            // buffers need an existing redengine file to rebuild/import
            if (args.Get<CommonImportArgs>().Keep)
            {
                RebuildFolder(inDir, outDir);
            }

            // process all other raw files
            var allFiles = inDir.GetFiles("*", SearchOption.AllDirectories).ToList();
            var rawFilesList = allFiles
                .Where(_ => Enum.GetNames<ERawFileFormat>().Contains(_.TrimmedExtension().ToLower()))
                .ToList();
            var failsCount = 0;

            foreach (var fi in rawFilesList)
            {
                var ext = fi.TrimmedExtension();
                if (!Enum.TryParse(ext, true, out ERawFileFormat _))
                {
                    failsCount++;
                    continue;
                }

                var redrelative = new RedRelativePath(inDir, fi.GetRelativePath(inDir));
                if (!await Import(redrelative, args, outDir))
                {
                    failsCount++;
                }
            }

            _loggerService.Info($"Imported {rawFilesList.Count - failsCount}/{rawFilesList.Count} file(s)");

            return true;
        }

        private bool ImportTtf(RedRelativePath rawRelative, DirectoryInfo outDir, CommonImportArgs args)
        {
            var inbuffer = File.ReadAllBytes(rawRelative.FullName);

            // create redengine file
            var red = new CR2WFile();
            var font = new rendFont
            {
                CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC,
                FontBuffer = new DataBuffer(inbuffer)
            };

            // add chunk
            red.RootChunk = font;

            // write to file
            var outpath = new RedRelativePath(rawRelative)
                .ChangeBaseDir(outDir)
                .ChangeExtension(ERedExtension.fnt.ToString());
            EnsureFolder(outpath.FullPath);
            using var fs = new FileStream(outpath.FullPath, FileMode.Create, FileAccess.Write);
            using var writer = new CR2WWriter(fs) { LoggerService = _loggerService };
            writer.WriteFile(red);

            return true;
        }

        // app: texture group is set from filename in args
        // cli: TODO
        private bool ImportXbm(RedRelativePath rawRelative, DirectoryInfo outDir, XbmImportArgs args)
        {
            var infilePath = rawRelative.FullName;

            if (ImportExportArgs.IsCLI && args.Keep)
            {
                var redfile = FindRedFile(rawRelative, outDir, ERedExtension.xbm.ToString());

                if (string.IsNullOrEmpty(redfile))
                {
                    _loggerService.Warning($"No existing redfile found to rebuild for {rawRelative.Name}");
                    return false;
                }

                using var redstream = new FileStream(redfile, FileMode.Open);
                using var fileReader = new BinaryReader(redstream);

                var cr2w = _parserService.ReadRed4File(fileReader);
                if (cr2w == null || cr2w.RootChunk is not CBitmapTexture xbm || xbm.RenderTextureResource == null || xbm.RenderTextureResource.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC)
                {
                    return false;
                }

                args = new XbmImportArgs
                {
                    //AllowTextureDowngrade = xbm.Setup.AllowTextureDowngrade,
                    //AlphaToCoverageThreshold = xbm.Setup.AlphaToCoverageThreshold,
                    Compression = Enum.Parse<ETextureCompression>(xbm.Setup.Compression.ToString()),
                    GenerateMipMaps = xbm.Setup.HasMipchain,
                    IsGamma = xbm.Setup.IsGamma,
                    //IsStreamable = xbm.Setup.IsStreamable,
                    //PlatformMipBiasConsole = xbm.Setup.PlatformMipBiasConsole,
                    //PlatformMipBiasPC = xbm.Setup.PlatformMipBiasPC,
                    RawFormat = Enum.Parse<ETextureRawFormat>(xbm.Setup.RawFormat.ToString()),
                    TextureGroup = xbm.Setup.Group
                };
            }

            var extension = Path.GetExtension(infilePath);
            if (args.TextureGroup != GpuWrapApieTextureGroup.TEXG_Generic_LUT && extension == ".cube")
            {
                _loggerService.Error("Wrong import settings. cube files only work with \"TextureGroup = TEXG_Generic_LUT\"");
                return false;
            }

            if (args.TextureGroup == GpuWrapApieTextureGroup.TEXG_Generic_LUT && extension != ".cube" && extension != ".dds")
            {
                _loggerService.Error($"Wrong import settings. LUT import only works with dds or cube. Got \"{extension}\"");
                return false;
            }

            var image = RedImage.LoadFromFile(infilePath);
            if (image == null)
            {
                _loggerService.Error($"\"{infilePath}\" could not be loaded!");
                return false;
            }

            if (image.Metadata.Width % 2 != 0 || image.Metadata.Height % 2 != 0)
            {
                if (args.Compression != ETextureCompression.TCM_None)
                {
                    _loggerService.Error("Image dimension (width and/or height) is an odd number. To import regardless, set Compression to TCM_None at own risk.");
                    return false;
                }

                if (args.TextureGroup != GpuWrapApieTextureGroup.TEXG_Generic_Data)
                {
                    _loggerService.Warning("Image dimension (width and/or height) is an odd number. Texture might not work as expected.");
                }
            }

            // create resource
            var bitmap = image.SaveToXBM(args, true);

            var outpath = new RedRelativePath(rawRelative)
                .ChangeBaseDir(outDir)
                .ChangeExtension(ERedExtension.xbm.ToString());
            if (!File.Exists(outpath.FullPath))
            {
                EnsureFolder(outpath.FullPath);
            }
            using var fs = new FileStream(outpath.FullPath, FileMode.Create, FileAccess.ReadWrite);
            using var writer = new CR2WWriter(fs) { LoggerService = _loggerService };
            writer.WriteFile(new CR2WFile { RootChunk = bitmap });

            return true;
        }

        private bool ImportGltf(RedRelativePath rawRelative, DirectoryInfo outDir, GltfImportArgs args)
        {
            var maybeType = TypeFromFileExt(rawRelative.Name);

            var (internalExt, importFormat) =
                maybeType.HasValue
                ? (InternalExtForType(maybeType.Value), ImportFormatFor(maybeType.Value))
                : args.ImportFormat == GltfImportAsFormat.MeshWithRig
                    ? ($".mesh", args.ImportFormat)
                    : ($".{args.ImportFormat.ToString().ToLower()}", args.ImportFormat);

            // Drops the .glb/.gltf, and either adds or replaces the already present type ext
            var possibleRedPath =
                Path.ChangeExtension(Path.ChangeExtension(Path.Join(outDir.FullName, rawRelative.RelativePath), null), internalExt);

            var maybeMatchingRedFile =
                File.Exists(possibleRedPath)
                ? Optional.Some<string>(possibleRedPath)
                : Optional.None<string>();

            string redfile;

            if (args.SelectBase)
            {
                if (args.BaseMesh is null)
                {
                    _loggerService.Warning($"Please select a base mesh");
                    return false;
                }

                var m = args.BaseMesh.FirstOrDefault();
                if (m is null)
                {
                    _loggerService.Error($"Could not find any base mesh.");
                    return false;
                }

                if (_archiveManager.Lookup(m.NameHash64).Value
                    is Core.Interfaces.IGameFile file)
                {
                    var name = rawRelative.NameWithoutExtension.ToLower() + ".mesh";
                    var rr = new RedRelativePath(rawRelative);
                    rr.ChangeBaseDir(outDir);
                    var path = Path.GetDirectoryName(rr.FullName) ?? throw new DirectoryNotFoundException();
                    var outpath = Path.Combine(path, name);
                    EnsureFolder(outpath);
                    using var fs = new FileStream(outpath, FileMode.Create);
                    file.Extract(fs);

                    redfile = FindRedFile(rr, outDir, internalExt);

                }
                else
                {
                    _loggerService.Error($"Could not open base mesh {m.FileName}");
                    return false;
                }

            }
            else if (args.Keep)
            {
                if (!maybeMatchingRedFile.HasValue)
                {
                    _loggerService.Warning($"No existing redfile found to rebuild for {rawRelative.Name} (tried {possibleRedPath})");
                    return false;
                }

                redfile = maybeMatchingRedFile.Value;
            }
            else
            {
                _loggerService.Warning($"{rawRelative.Name} - Direct mesh importing is not implemented");
                return false;
            }

            var redfileName = Path.GetFileName(redfile);
            using var redFs = new FileStream(redfile, FileMode.Open, FileAccess.ReadWrite);
            try
            {
                var result = false;
                switch (importFormat)
                {
                    case GltfImportAsFormat.Mesh:
                        result = ImportMesh(rawRelative.ToFileInfo(), redFs, args);
                        break;
                    case GltfImportAsFormat.Morphtarget:
                        result = ImportMorphTargets(rawRelative.ToFileInfo(), redFs, args);
                        break;
                    case GltfImportAsFormat.Anims:
                        result = ImportAnims(rawRelative.ToFileInfo(), redFs);
                        break;
                    case GltfImportAsFormat.MeshWithRig:
                        result = ImportMesh(rawRelative.ToFileInfo(), redFs, args);
                        break;
                    case GltfImportAsFormat.Rig:
                        result = ImportRig(rawRelative.ToFileInfo(), redFs, args);
                        break;
                    default:
                        break;
                }

                if (result)
                {
                    _loggerService.Success($"Rebuilt with buffers: {redfileName} (as {importFormat})");
                }
                else
                {
                    _loggerService.Error($"Failed to rebuild with buffers: {redfileName} (as {importFormat})");
                }
                return result;
            }
            catch (Exception e)
            {
                _loggerService.Error(e);
                return false;
            }
            finally
            {
                redFs.Close();
            }


        }

#pragma warning disable IDE0072 // Add missing cases
        private static ECookedFileFormat FromRawExtension(ERawFileFormat rawextension) =>
            rawextension switch
            {
                //ERawFileFormat.fbx => ECookedFileFormat.mesh,
                ERawFileFormat.gltf => ECookedFileFormat.mesh,
                ERawFileFormat.glb => ECookedFileFormat.mesh,
                ERawFileFormat.ttf => ECookedFileFormat.fnt,
                //ERawFileFormat.bmp => expr,
                //ERawFileFormat.jpg => expr,
                //ERawFileFormat.png => expr,
                //ERawFileFormat.tga => expr,
                //ERawFileFormat.tiff => expr,
                //ERawFileFormat.dds => expr,
                //ERawFileFormat.wav => expr,
                _ => throw new ArgumentOutOfRangeException(nameof(rawextension), rawextension, null)
            };
#pragma warning restore IDE0072 // Add missing cases

        private static string FindRedFile(RedRelativePath rawRelPath, DirectoryInfo outDir, string? overrideExt = null)
        {
            var ext = rawRelPath.Extension;
            if (!Enum.TryParse(ext, true, out ERawFileFormat extAsEnum))
            {
                return "";
            }
            var redfile = new RedRelativePath(rawRelPath)
                .ChangeBaseDir(outDir)
                .ChangeExtension(string.IsNullOrEmpty(overrideExt)
                    ? FromRawExtension(extAsEnum).ToString()
                    : overrideExt);

            return !File.Exists(redfile.FullPath) ? "" : redfile.FullPath;
        }


    }
}
