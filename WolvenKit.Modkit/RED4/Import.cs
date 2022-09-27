using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using WolvenKit.Helpers;
using WolvenKit.Modkit.Extensions;
using WolvenKit.Modkit.RED4.MLMask;
using WolvenKit.RED4;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

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
        public async Task<bool> Import(RedRelativePath rawRelative, GlobalImportArgs args, DirectoryInfo outDir = null)
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

            //var rawRelative = new RedRelativePath(inDir, rawFile.GetRelativePath(inDir));

            // check if the file can be directly imported
            // if not, rebuild buffers
            if (!Enum.TryParse(rawRelative.Extension, true, out ERawFileFormat extAsEnum))
            {
                return RebuildBuffer(rawRelative, outDir);
            }

            // import files
            return extAsEnum switch
            {
                ERawFileFormat.bmp or ERawFileFormat.jpg or ERawFileFormat.png or ERawFileFormat.tiff or ERawFileFormat.tga or ERawFileFormat.dds => HandleTextures(rawRelative, outDir, args),
                ERawFileFormat.fbx or ERawFileFormat.gltf or ERawFileFormat.glb => ImportGltf(rawRelative, outDir, args.Get<GltfImportArgs>()),
                ERawFileFormat.masklist => ImportMlmask(rawRelative, outDir),
                ERawFileFormat.ttf => ImportTtf(rawRelative, outDir, args.Get<CommonImportArgs>()),
                ERawFileFormat.wav => ImportWav(rawRelative, outDir, args.Get<OpusImportArgs>()),
                ERawFileFormat.csv => ImportCsv(rawRelative, outDir, args),
                ERawFileFormat.re => await ImportAnims(rawRelative, outDir, args.Get<ReImportArgs>()),
                _ => throw new ArgumentOutOfRangeException(),
            };
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

                    _loggerService.Info($"WorkDir: {redModPath}");
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
                using var fs = new FileStream(outpath.FullPath, FileMode.Create, FileAccess.ReadWrite);
                using var writer = new CR2WWriter(fs);
                writer.WriteFile(red);

                return true;
            }

            return false;
        }

        private bool ImportWav(RedRelativePath rawRelative, DirectoryInfo outDir, OpusImportArgs opusImportArgs)
        {
            _loggerService.Success($"Use WolvenKit to import opus.");
            return false;
        }

        private bool ImportMlmask(RedRelativePath rawRelative, DirectoryInfo outDir)
        {
            var mlmask = new MLMASK();
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
                    return !string.IsNullOrEmpty(redfile)
                        ? cookedTextureFormat == ECookedTextureFormat.xbm
                            ? ImportXbm(rawRelative, outDir, args.Get<XbmImportArgs>())
                            : RebuildTexture(redfile)
                        : ImportXbm(rawRelative, outDir, args.Get<XbmImportArgs>());
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
        public async Task<bool> ImportFolder(DirectoryInfo inDir, GlobalImportArgs args, DirectoryInfo outDir = null)
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
            if (args.Keep)
            {
                var buffer = new FileInfo(rawRelative.FullName);
                var redfile = FindRedFile(rawRelative, outDir);

                if (string.IsNullOrEmpty(redfile))
                {
                    _loggerService.Warning($"No existing redfile found to rebuild for {rawRelative.Name}");
                    return false;
                }

                using var fileStream = new FileStream(redfile, FileMode.Open, FileAccess.ReadWrite);
                var result = Rebuild(fileStream, new List<FileInfo>() { buffer });

                if (result)
                {
                    _loggerService.Success($"Rebuilt {redfile} with buffers");
                }
                else
                {
                    _loggerService.Error($"Failed to rebuild {redfile} with buffers");
                }

                return result;
            }
            else
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
                var redpath = Path.ChangeExtension(rawRelative.FullName, ECookedFileFormat.fnt.ToString());
                if (redpath == null)
                {
                    return false;
                }

                using var fs = new FileStream(redpath, FileMode.Create, FileAccess.Write);
                using var writer = new CR2WWriter(fs);
                writer.WriteFile(red);

                return true;
            }
        }

        private bool ImportXbm(RedRelativePath rawRelative, DirectoryInfo outDir, XbmImportArgs args)
        {
            var infile = rawRelative.FullName;

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

                var cr2w = _wolvenkitFileService.ReadRed4File(fileReader);
                if (cr2w == null || cr2w.RootChunk is not CBitmapTexture xbm || xbm.RenderTextureResource == null || xbm.RenderTextureResource.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC)
                {
                    return false;
                }

                args = new XbmImportArgs();
                args.AllowTextureDowngrade = xbm.Setup.AllowTextureDowngrade;
                args.AlphaToCoverageThreshold = xbm.Setup.AlphaToCoverageThreshold;
                args.Compression = Enum.Parse<SupportedCompressionFormats>(xbm.Setup.Compression.ToString());
                args.HasMipchain = xbm.Setup.HasMipchain;
                args.IsGamma = xbm.Setup.IsGamma;
                args.IsStreamable = xbm.Setup.IsStreamable;
                args.PlatformMipBiasConsole = xbm.Setup.PlatformMipBiasConsole;
                args.PlatformMipBiasPC = xbm.Setup.PlatformMipBiasPC;
                args.RawFormat = Enum.Parse<SupportedRawFormats>(xbm.Setup.RawFormat.ToString());
                args.TextureGroup = xbm.Setup.Group;
            }

            RedImage image;
            switch (Enum.Parse<EUncookExtension>(rawRelative.Extension))
            {
                case EUncookExtension.dds:
                    image = RedImage.LoadFromDDSFile(infile);
                    break;
                case EUncookExtension.tga:
                    image = RedImage.LoadFromTGAFile(infile);
                    break;
                case EUncookExtension.bmp:
                    image = RedImage.LoadFromBMPFile(infile);
                    break;
                case EUncookExtension.jpg:
                    image = RedImage.LoadFromJPGFile(infile);
                    break;
                case EUncookExtension.png:
                    image = RedImage.LoadFromPNGFile(infile);
                    break;
                case EUncookExtension.tiff:
                    image = RedImage.LoadFromTIFFFile(infile);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            var bitmap = image.SaveToXBM(args);

            var outpath = new RedRelativePath(rawRelative)
                .ChangeBaseDir(outDir)
                .ChangeExtension(ERedExtension.xbm.ToString());
            if (!File.Exists(outpath.FullPath))
            {
                Directory.CreateDirectory(outpath.ToFileInfo().Directory.FullName);
            }

            using var fs = new FileStream(outpath.FullPath, FileMode.Create, FileAccess.ReadWrite);
            using var writer = new CR2WWriter(fs);
            writer.WriteFile(new CR2WFile {RootChunk = bitmap});

            return true;
        }

        private bool ImportGltf(RedRelativePath rawRelative, DirectoryInfo outDir, GltfImportArgs args)
        {
            string redfile;
            var ext = args.importFormat ==
                GltfImportAsFormat.MeshWithRig ? $".mesh" : $".{args.importFormat.ToString().ToLower()}";


            if (args.SelectBase)
            {
                if (args.BaseMesh is null)
                {
                    _loggerService.Warning($"Please select a base mesh");
                    return false;
                }

                if (_archiveManager.Lookup(args.BaseMesh.FirstOrDefault().NameHash64).Value
                    is Core.Interfaces.IGameFile file)
                {
                    var name = rawRelative.NameWithoutExtension.ToLower() + ".mesh";
                    var rr = new RedRelativePath(rawRelative);
                    rr.ChangeBaseDir(outDir);
                    var path = Path.GetDirectoryName(rr.FullName);
                    if (!Directory.Exists(path))
                    { Directory.CreateDirectory(path); }

                    using var fs = new FileStream(path + @"\" + name, FileMode.Create);
                    file.Extract(fs);

                    redfile = FindRedFile(rr, outDir, ext);

                }
                else
                {
                    _loggerService.Error($"Could not open base mesh {args.BaseMesh.FirstOrDefault().FileName}");
                    return false;
                }

            }
            else if (args.Keep)
            {
                redfile = FindRedFile(rawRelative, outDir, ext);
                if (string.IsNullOrEmpty(redfile))
                {
                    _loggerService.Warning($"No existing redfile found to rebuild for {rawRelative.Name}");
                    return false;
                }
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
                switch (args.importFormat)
                {
                    case GltfImportAsFormat.Mesh:
                        result = ImportMesh(rawRelative.ToFileInfo(), redFs, args);
                        break;
                    case GltfImportAsFormat.Morphtarget:
                        result = ImportMorphTargets(rawRelative.ToFileInfo(), redFs, args);
                        break;
                    case GltfImportAsFormat.Anims:
                        result = ImportAnims(rawRelative.ToFileInfo(), redFs, args.Archives);
                        break;
                    case GltfImportAsFormat.MeshWithRig:
                        result = ImportMesh(rawRelative.ToFileInfo(), redFs, args);
                        break;
                    case GltfImportAsFormat.Rig:
                        result = ImportRig(rawRelative.ToFileInfo(), redFs, args);
                        break;
                }

                if (result)
                {
                    _loggerService.Success($"Rebuilt with buffers: {redfileName} ");
                }
                else
                {
                    _loggerService.Error($"Failed to rebuild with buffers: {redfileName}");
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

        private static ECookedFileFormat FromRawExtension(ERawFileFormat rawextension) =>
            rawextension switch
            {
                ERawFileFormat.fbx => ECookedFileFormat.mesh,
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

        private static string FindRedFile(RedRelativePath rawRelPath, DirectoryInfo outDir, string overrideExt = null)
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
