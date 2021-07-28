using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Modkit.RED4.Opus;
using WolvenKit.RED4.CR2W;

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
        /// <param name="rawFile">the raw file to be imported</param>
        /// <param name="args"></param>
        /// <param name="inDir"></param>
        /// <param name="outDir">can be a depotpath, or if null the parent directory of the rawfile</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Import(RedRelativePath rawRelative, GlobalImportArgs args, DirectoryInfo outDir = null)
        {
            #region checks

            if (rawRelative is null or {Exists: false})
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
            switch (extAsEnum)
            {
                case ERawFileFormat.tga:
                case ERawFileFormat.dds:
                    // check here for textures
                    return HandleTextures(rawRelative, outDir, args);
                case ERawFileFormat.fbx:
                case ERawFileFormat.gltf:
                case ERawFileFormat.glb:
                    return ImportMesh(rawRelative, outDir, args.Get<MeshImportArgs>());
                case ERawFileFormat.ttf:
                    return ImportTtf(rawRelative, outDir, args.Get<CommonImportArgs>());
                case ERawFileFormat.wav:
                    return ImportWav(rawRelative, outDir, args.Get<OpusImportArgs>());
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private bool ImportWav(RedRelativePath rawRelative, DirectoryInfo outDir, OpusImportArgs opusImportArgs)
        {
            _loggerService.Success($"Use WolvenKit to import opus.");
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
                    // ml_w_knife__combat__grip1_01_masksset_0.dds
                    // ml_w_knife__combat__grip1_01_masksset_10.dds
                    var mlmaskrelpath = $"{rawRelative.RelativePath[..^4]}"; //ml_w_knife__combat__grip1_01_masksset_10
                    var idx = mlmaskrelpath.LastIndexOf('_');
                    if (idx == -1)
                    {
                        continue;
                    }

                    mlmaskrelpath = $"{mlmaskrelpath[..idx]}.mlmask";


                    //var mlmaskrelpath2 = Path.ChangeExtension(rawRelative.RelativePath[..^4], ERedExtension.mlmask.ToString());
                    var mlmaskParent = new RedRelativePath(rawRelative)
                        .ChangeBaseDir(outDir)
                        .ChangeRelativePath(mlmaskrelpath);

                    if (File.Exists(mlmaskParent.FullPath))
                    {
                        return RebuildMlMask(mlmaskParent.FullPath);
                    }

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
                }
            }

            _loggerService.Warning($"No existing redfile found to rebuild for {rawRelative.Name}");
            return false;


            bool RebuildMlMask(string redparent)
            {
                _loggerService.Warning($"{rawRelative.Name} - Mlmask importing is not implemented yet");
                return false;

                // get all other buffers
#pragma warning disable 162
                var uncookedMaskRootPath = rawRelative.RelativePath[..^6];
                var uncookedRelative = new RedRelativePath(rawRelative)
                    .ChangeRelativePath(uncookedMaskRootPath);

                var buffers = rawRelative.ToFileInfo().Directory
                    .GetFiles($"{uncookedRelative.Name}_*.dds", SearchOption.TopDirectoryOnly);


                using var fileStream = new FileStream(redparent, FileMode.Open, FileAccess.ReadWrite);
                var result = Rebuild(fileStream, buffers);

                if (result)
                {
                    _loggerService.Success($"Rebuilt {redparent} with buffers");
                }
                else
                {
                    _loggerService.Error($"Failed to rebuild {redparent} with buffers");
                }

                return result;
#pragma warning restore 162
            }

            bool RebuildTexture(string redparent)
            {
                var ddsPath = Path.ChangeExtension(rawRelative.FullName, ERawFileFormat.dds.ToString());

                using var fileStream = new FileStream(redparent, FileMode.Open, FileAccess.ReadWrite);
                var result = Rebuild(fileStream, new List<FileInfo>() {new(ddsPath ?? throw new InvalidOperationException())});

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
        public bool ImportFolder(DirectoryInfo inDir, GlobalImportArgs args, DirectoryInfo outDir = null)
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
                if (!Enum.TryParse(ext, true, out ERawFileFormat extAsEnum))
                {
                    failsCount++;
                    continue;
                }

                var redrelative = new RedRelativePath(inDir, fi.GetRelativePath(inDir));
                if (!Import(redrelative, args, outDir))
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
                var redfile = FindRedFile(rawRelative,  outDir);

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
                // create redengine file
                var red = new CR2WFile();
                var font = new rendFont(red, null, nameof(rendFont));
                font.CookingPlatform = new CEnum<Enums.ECookingPlatform>(red, font, "cookingPlatform")
                {
                    Value = Enums.ECookingPlatform.PLATFORM_PC,
                    IsSerialized = true
                };
                font.FontBuffer = new DataBuffer(red, font, "fontBuffer"){IsSerialized = true};
                font.FontBuffer.Buffer.SetValue((ushort)1);

                // add chunk
                red.CreateChunk(font, 0);

                // add fake buffer
                red.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()));

                // write main file
                using var ms = new MemoryStream();
                using var bw = new BinaryWriter(ms);
                red.Write(bw);

                // write buffer
                var offset = (uint)bw.BaseStream.Position;
                var inbuffer = File.ReadAllBytes(rawRelative.FullName);
                var (zsize, crc) = bw.CompressAndWrite(inbuffer);

                // add buffer info
                red.Buffers[0] = new CR2WBufferWrapper(new CR2WBuffer()
                {
                    flags = 0xE0000, //TODO: find out what to set here, but for fnt files these are always 0xE0000
                    index = (uint)0,
                    offset = offset,
                    diskSize = zsize,
                    memSize = (uint)inbuffer.Length,
                    crc32 = crc
                });

                // write header again to update the buffer info
                bw.Seek(0, SeekOrigin.Begin);
                red.WriteHeader(bw);

                // write to file
                var redpath = Path.ChangeExtension(rawRelative.FullName, ECookedFileFormat.fnt.ToString());
                using var fs = new FileStream(redpath, FileMode.Create, FileAccess.Write);
                ms.Seek(0, SeekOrigin.Begin);
                ms.CopyTo(fs);

                return true;
            }



        }

        private static ECookedFileFormat FromRawExtension(ERawFileFormat rawextension) =>
            rawextension switch
            {
                ERawFileFormat.fbx => ECookedFileFormat.mesh,
                ERawFileFormat.gltf => ECookedFileFormat.mesh,
                ERawFileFormat.glb => ECookedFileFormat.mesh,
                ERawFileFormat.ttf => ECookedFileFormat.fnt,
                _ => throw new ArgumentOutOfRangeException(nameof(rawextension), rawextension, null)
            };


        public bool ImportXbm(RedRelativePath rawRelative, DirectoryInfo outDir, XbmImportArgs args)
        {
            var rawExt = rawRelative.Extension;
            // TODO: do this in a working directory?
            var ddsPath = Path.ChangeExtension(rawRelative.FullName, ERawFileFormat.dds.ToString());
            // convert to dds if not already
            if (rawExt != ERawFileFormat.dds.ToString())
            {
                try
                {
                    if (ddsPath.Length > 255)
                    {
                        _loggerService.Error($"{ddsPath} - Path length exceeds 255 chars. Please move the archive to a directory with a shorter path.");
                        return false;
                    }
                    TexconvWrapper.Convert(rawRelative.ToFileInfo().Directory.FullName, $"{ddsPath}", EUncookExtension.dds);
                }
                catch (Exception)
                {
                    //TODO: proper exception handling
                    return false;
                }

                if (!File.Exists(ddsPath))
                {
                    return false;
                }
            }

            if (args.Keep)
            {
                var buffer = new FileInfo(ddsPath);
                var redfile = FindRedFile(rawRelative, outDir, ERedExtension.xbm.ToString());

                if (string.IsNullOrEmpty(redfile))
                {
                    _loggerService.Warning($"No existing redfile found to rebuild for {rawRelative.Name}");
                    return false;
                }

                using var fileStream = new FileStream(redfile, FileMode.Open, FileAccess.ReadWrite);
                var result = Rebuild(fileStream, new List<FileInfo>() {buffer});

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
                _loggerService.Warning($"{rawRelative.Name} - Direct xbm importing is not implemented");




                // read dds metadata
                var metadata = DDSUtils.ReadHeader(ddsPath);
                var width = metadata.Width;
                var height = metadata.Height;

                // create cr2wfile
                var red = new CR2WFile();
                red.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()));
                // create xbm chunk
                var xbm = new CBitmapTexture(red, null, "CBitmapTexture");
                xbm.CookingPlatform = new CEnum<Enums.ECookingPlatform>(red, xbm, "cookingPlatform")
                {
                    Value = Enums.ECookingPlatform.PLATFORM_PC,
                    IsSerialized = true
                };
                xbm.Width = new CUInt32(red, xbm, "width") { Value = width, IsSerialized = true };
                xbm.Height = new CUInt32(red, xbm, "height") { Value = height, IsSerialized = true };
                xbm.Setup = new STextureGroupSetup(red, xbm, "setup")
                {
                    IsSerialized = true
                };
                SetTextureGroupSetup(xbm.Setup, red);
                xbm.RenderResourceBlob = new CHandle<IRenderResourceBlob>(red, xbm, "renderTextureResource")
                    .SetValue(2) as CHandle<IRenderResourceBlob>;

                // create rendRenderTextureBlobPC chunk
                var blob = new rendRenderTextureBlobPC(red, null, "rendRenderTextureBlobPC");
                blob.Header = new rendRenderTextureBlobHeader(red, blob.ParentVar as CVariable, "header")
                {
                    IsSerialized = true
                };
                blob.TextureData = new serializationDeferredDataBuffer(red, blob.ParentVar as CVariable, "textureData")
                    .SetValue(1) as serializationDeferredDataBuffer;



                // kraken ddsfile
                // remove dds header

                // compress file

                // append to cr2wfile

                // update cr2w headers

                throw new NotImplementedException();
            }

            #region local functions

            void SetTextureGroupSetup(STextureGroupSetup setup, CR2WFile cr2w)
            {
                // first check the user-texture group
                var (compression, rawformat, flags) = CommonFunctions.GetRedFormatsFromTextureGroup(args.TextureGroup);
                setup.Group = new CEnum<Enums.GpuWrapApieTextureGroup>(cr2w, setup.ParentVar as CVariable, "group")
                {
                    IsSerialized = true,
                    Value = args.TextureGroup
                };
                if (flags is CommonFunctions.ETexGroupFlags.Both or CommonFunctions.ETexGroupFlags.CompressionOnly)
                {
                    setup.Compression = new CEnum<Enums.ETextureCompression>(cr2w, setup.ParentVar as CVariable, "setup")
                    {
                        IsSerialized = true,
                        Value = compression
                    };
                }

                if (flags is CommonFunctions.ETexGroupFlags.Both or CommonFunctions.ETexGroupFlags.RawFormatOnly)
                {
                    setup.RawFormat = new CEnum<Enums.ETextureRawFormat>(cr2w, setup.ParentVar as CVariable, "rawFormat")
                    {
                        IsSerialized = true,
                        Value = rawformat
                    };
                }

                // if that didn't work, interpret the filename suffix
                if (rawRelative.Name.Contains('_'))
                {
                    // try interpret suffix
                    switch (rawRelative.Name.Split('_').Last())
                    {
                        case "d":
                        case "d01":

                            break;
                        case "e":

                            break;
                        case "r":
                        case "r01":

                            break;
                        default:
                            break;
                    }
                }

                // if that also didn't work, just use default or skip
                //TODO
            }

            #endregion

        }

        private static string FindRedFile(RedRelativePath rawRelPath,  DirectoryInfo outDir, string overrideExt = null)
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
                    : overrideExt );

            return !File.Exists(redfile.FullPath) ? "" : redfile.FullPath;
        }

        private bool ImportMesh(RedRelativePath rawRelative, DirectoryInfo outDir, MeshImportArgs args)
        {
            if (args.Keep)
            {
                var redfile = FindRedFile(rawRelative,  outDir);

                if (string.IsNullOrEmpty(redfile))
                {
                    _loggerService.Warning($"No existing redfile found to rebuild for {rawRelative.Name}");
                    return false;
                }

                var redfileName = Path.GetFileName(redfile);
                using var redFs = new FileStream(redfile, FileMode.Open, FileAccess.ReadWrite);
                try
                {
                    var result = ImportMesh(rawRelative.ToFileInfo(), redFs,args.Archive,args.importMaterialOnly);

                    if (result)
                    {
                        _loggerService.Success($"Rebuilt {redfileName} with buffers");
                    }
                    else
                    {
                        _loggerService.Error($"Failed to rebuild {redfileName} with buffers");
                    }
                    return result;
                }
                catch (Exception e)
                {
                    _loggerService.Error($"Unexpected error occured while importing {redfileName}: {e.Message}");
                    return false;
                }


            }


            _loggerService.Warning($"{rawRelative.Name} - Direct mesh importing is not implemented");
            return false;
        }
    }
}
