using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
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
        public bool Import(RedRelativePath rawRelative, GlobalImportArgs args, DirectoryInfo outDir = null)
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
            switch (extAsEnum)
            {
                case ERawFileFormat.bmp:
                case ERawFileFormat.jpg:
                case ERawFileFormat.png:
                case ERawFileFormat.tiff:
                case ERawFileFormat.tga:
                case ERawFileFormat.dds:
                    return HandleTextures(rawRelative, outDir, args);
                case ERawFileFormat.fbx:
                case ERawFileFormat.gltf:
                case ERawFileFormat.glb:
                    return ImportGltf(rawRelative, outDir, args.Get<GltfImportArgs>());
                case ERawFileFormat.masklist:
                    return ImportMlmask(rawRelative, outDir);
                case ERawFileFormat.ttf:
                    return ImportTtf(rawRelative, outDir, args.Get<CommonImportArgs>());
                case ERawFileFormat.wav:
                    return ImportWav(rawRelative, outDir, args.Get<OpusImportArgs>());
                case ERawFileFormat.csv:
                    return ImportCsv(rawRelative, outDir, args);
                default:
                    throw new ArgumentOutOfRangeException();
            }
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
            }

            return true;
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
                if (!Enum.TryParse(ext, true, out ERawFileFormat _))
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
            var rawExt = rawRelative.Extension;
            var redfile = "";
            var infile = rawRelative.FullName;

            CR2WFile cr2w = null;

            // checks
            if (args.Keep)
            {
                redfile = FindRedFile(rawRelative, outDir, ERedExtension.xbm.ToString());

                if (string.IsNullOrEmpty(redfile))
                {
                    _loggerService.Warning($"No existing redfile found to rebuild for {rawRelative.Name}");
                    return false;
                }

                using var redstream = new FileStream(redfile, FileMode.Open);
                using var fileReader = new BinaryReader(redstream);

                cr2w = _wolvenkitFileService.ReadRed4File(fileReader);
                if (cr2w == null || cr2w.RootChunk is not CBitmapTexture xbm || xbm.RenderTextureResource == null || xbm.RenderTextureResource.RenderResourceBlobPC.Chunk is not rendRenderTextureBlobPC)
                {
                    return false;
                }
            }

            using var ms = new MemoryStream();

            // convert to dds if not already
            if (rawExt != EUncookExtension.dds.ToString())
            {
                if (!Enum.TryParse(rawExt, true, out EUncookExtension extAsEnum))
                {
                    _loggerService.Warning($"Can not convert file to dds: {rawRelative.Name}");
                    return false;
                }

                DXGI_FORMAT? format;

                if (args.Keep)
                {
                    var xbm = (CBitmapTexture)cr2w.RootChunk;

                    format = CommonFunctions.GetDXGIFormat(xbm.Setup.Compression, xbm.Setup.RawFormat, _loggerService);
                }
                else
                {
                    // TODO
                    if (rawExt == EUncookExtension.tga.ToString())
                    {
                        var md = Texconv.GetMetadataFromTGAFile(infile);
                        format = md.Format;
                    }
                    else if (rawExt == EUncookExtension.png.ToString())
                    {
                        using (var stream = new FileStream(infile, FileMode.Open, FileAccess.Read, FileShare.Read))
                        {
                            // need to figure out how to decide format/etc from png header
                            //var image = Png.Open(stream);
                            //image.Header.ColorType;
                            //var md = new DDSMetadata(new DirectXTexSharp.TexMetadata(), image.Header.BitDepth, true);

                            //format = md.Format;
                            format = DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM;
                        }
                    }
                    else
                    {
                        _loggerService.Error($"Direct {rawExt} import is not supported yet.");
                        return false;
                    }
                }

                using var fs = new FileStream(infile, FileMode.Open);
                var ddsbuffer = Texconv.ConvertToDds(fs, extAsEnum, format);
                ms.Write(ddsbuffer);
            }
            else
            {
                using var fs = new FileStream(infile, FileMode.Open);
                fs.Seek(0, SeekOrigin.Begin);
                fs.CopyTo(ms);
            }

            // read dds metadata
            ms.Seek(0, SeekOrigin.Begin);

            var span = new Span<byte>(new byte[148]);
            ms.Read(span);

            var metadata = Texconv.GetMetadataFromDDSMemory(span.ToArray());

            // create xbm
            if (args.Keep)
            {
                var xbm = (CBitmapTexture)cr2w.RootChunk;
                if (!Equals((uint)xbm.Width, metadata.Width) || !Equals((uint)xbm.Height, metadata.Height))
                {
                    _loggerService.Error($"Resolution doesn't match. Aborting.");
                    return false;
                }

                var rend = (rendRenderTextureBlobPC)xbm.RenderTextureResource.RenderResourceBlobPC.Chunk;
                rend.TextureData.Buffer = RedBuffer.CreateBuffer(rend.TextureData.Buffer.Flags, ms.ToByteArray().Skip(148).ToArray());

                using var fs = new FileStream(redfile, FileMode.Create, FileAccess.ReadWrite);
                using var writer = new CR2WWriter(fs);
                writer.WriteFile(cr2w);

                return true;
            }
            else
            {
                var width = metadata.Width;
                var height = metadata.Height;
                var mipCount = metadata.Mipscount;
                var slicecount = metadata.Slicecount;
                var alignment = metadata.Bpp;
                var fmt = metadata.Format;
                var textureDataSize = ms.Length - 148; //GetBlockSize(width, fmt);

                // create cr2wfile
                cr2w = new CR2WFile();

                // xbm chunk
                var (compression, rawFormat) = CommonFunctions.GetRedFormatsFromDxgiFormat(metadata.Format);

                var xbm = new CBitmapTexture
                {
                    CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC,
                    Width = width,
                    Height = height,
                    Setup =
                            {
                                Group = args.TextureGroup,
                                Compression = compression,
                                RawFormat = rawFormat,
                                IsGamma = args.IsGamma
                            }
                };


                // SetTextureGroupSetup(xbm.Setup, cr2w);

                // blob chunk
                var blob = new rendRenderTextureBlobPC();

                xbm.RenderTextureResource = new rendRenderTextureResource
                {
                    RenderResourceBlobPC = blob
                };

                // create rendRenderTextureBlobPC chunk

                // header
                var header = new rendRenderTextureBlobHeader
                {
                    Version = 2,
                    Flags = 1,
                    SizeInfo = new rendRenderTextureBlobSizeInfo
                    {
                        Width = (ushort)width,
                        Height = (ushort)height
                    },
                    TextureInfo = new rendRenderTextureBlobTextureInfo
                    {
                        TextureDataSize = (uint)textureDataSize,
                        SliceSize = (uint)textureDataSize,
                        DataAlignment = alignment,
                        SliceCount = (ushort)slicecount,
                        MipCount = (byte)mipCount
                    }
                };

                // header.TextureInfo
                var mipMapInfo = new CArray<rendRenderTextureBlobMipMapInfo>();
                //var mipMapInfo = RedTypeManager.Create<CArray<rendRenderTextureBlobMipMapInfo>>();
                {
                    ms.Seek(148, SeekOrigin.Begin);

                    var mipsizeH = height;
                    var mipsizeW = width;
                    var offset = 0;
                    for (var i = 0; i < metadata.Mipscount; i++)
                    {
                        // slicepitch
                        var slicepitch = Texconv.ComputeSlicePitch((int)mipsizeW, (int)mipsizeH, fmt);

                        //rowpitch
                        var rowpitch = Texconv.ComputeRowPitch((int)mipsizeW, (int)mipsizeH, fmt);

                        var info = new rendRenderTextureBlobMipMapInfo
                        {
                            Layout = new rendRenderTextureBlobMemoryLayout()
                            {
                                RowPitch = (uint)rowpitch,
                                SlicePitch = (uint)slicepitch
                            },
                            Placement = new rendRenderTextureBlobPlacement()
                            {
                                Offset = (uint)offset,
                                Size = (uint)slicepitch
                            }
                        };

                        offset += slicepitch;

                        mipMapInfo.Add(info);

                        mipsizeH = Math.Max(4, mipsizeH / 2);
                        mipsizeW = Math.Max(4, mipsizeW / 2);
                    }
                }
                header.MipMapInfo = mipMapInfo;

                blob.Header = header;

                // texdata buffer ref

                // add chunks
                cr2w.RootChunk = xbm;

                // write
                blob.TextureData = new SerializationDeferredDataBuffer
                {
                    Buffer = RedBuffer.CreateBuffer(131072, ms.ToByteArray().Skip(148).ToArray())
                };

                var outpath = new RedRelativePath(rawRelative)
                    .ChangeBaseDir(outDir)
                    .ChangeExtension(ERedExtension.xbm.ToString());
                if (!File.Exists(outpath.FullPath))
                {
                    Directory.CreateDirectory(outpath.ToFileInfo().Directory.FullName);
                }

                using var fs = new FileStream(outpath.FullPath, FileMode.Create, FileAccess.ReadWrite);
                using var writer = new CR2WWriter(fs);
                writer.WriteFile(cr2w);
            }

#pragma warning disable CS0162 // Unreachable code detected
            return true;
#pragma warning restore CS0162 // Unreachable code detected

            #region local functions
#pragma warning disable CS8321 // Local function is declared but never used

            void SetTextureGroupSetup(STextureGroupSetup setup, CR2WFile cr2w)
            {
                // first check the user-texture group
                //var (compression, rawformat, flags) = CommonFunctions.GetRedFormatsFromTextureGroup(args.TextureGroup);



                setup.Group = args.TextureGroup;
                setup.Compression = Enums.ETextureCompression.TCM_None;
                setup.RawFormat = Enums.ETextureRawFormat.TRF_TrueColor;
                setup.IsGamma = args.IsGamma;

                //if (flags is CommonFunctions.ETexGroupFlags.Both or CommonFunctions.ETexGroupFlags.CompressionOnly)
                //{
                //    setup.Compression = new CEnum<Enums.ETextureCompression>(cr2w, setup.ParentVar as CVariable, "setup")
                //    {
                //        IsSerialized = true,
                //        Value = compression
                //    };
                //}

                //if (flags is CommonFunctions.ETexGroupFlags.Both or CommonFunctions.ETexGroupFlags.RawFormatOnly)
                //{
                //    setup.RawFormat = new CEnum<Enums.ETextureRawFormat>(cr2w, setup.ParentVar as CVariable, "rawFormat")
                //    {
                //        IsSerialized = true,
                //        Value = rawformat
                //    };
                //}

                //// if that didn't work, interpret the filename suffix
                //if (rawRelative.Name.Contains('_'))
                //{
                //    // try interpret suffix
                //    switch (rawRelative.Name.Split('_').Last())
                //    {
                //        case "d":
                //        case "d01":

                //            break;
                //        case "e":

                //            break;
                //        case "r":
                //        case "r01":

                //            break;
                //    }
                //}

                // if that also didn't work, just use default or skip
                //TODO
            }

#pragma warning restore CS8321 // Local function is declared but never used
            #endregion

        }

        private bool ImportGltf(RedRelativePath rawRelative, DirectoryInfo outDir, GltfImportArgs args)
        {
            var am = Locator.Current.GetService<IArchiveManager>();
            var somefile = am.Lookup(11327483717126307343); //some ice cube
                                                            //some cube 15966709641681476693
            var file = somefile.Value;
            

            if (args.Keep)
            {

                var ext = args.importFormat == GltfImportAsFormat.MeshWithRig ? $".mesh" : $".{args.importFormat.ToString().ToLower()}";
                var redfile = FindRedFile(rawRelative, outDir, ext);
                if (string.IsNullOrEmpty(redfile))
                {
                    var name = rawRelative.NameWithoutExtension + ".mesh";
                    var rr = new RedRelativePath(rawRelative);
                    rr.ChangeBaseDir(outDir);
                    var path = Path.GetDirectoryName(rr.FullName);
                    if (!Directory.Exists(path))
                    { Directory.CreateDirectory(path); }

                    using var fs = new FileStream(path + @"\" + name, FileMode.Create);
                    file.Extract(fs);

                    redfile = FindRedFile(rr, outDir, ext);
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


            _loggerService.Warning($"{rawRelative.Name} - Direct mesh importing is not implemented");
            return false;
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
