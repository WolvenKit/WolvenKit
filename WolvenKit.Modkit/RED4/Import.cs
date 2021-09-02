using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FmodAudio;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.Modkit.Exceptions;
using WolvenKit.RED4.CR2W;
using WolvenKit.Modkit.RED4.MLMask;
using WolvenKit.RED4.CR2W.Reflection;

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
                default:
                    throw new ArgumentOutOfRangeException();
            }
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
                var redfile = new RedRelativePath(rawRelative).ChangeBaseDir(outDir).ChangeExtension(string.IsNullOrEmpty(".mlmask")? FromRawExtension(extAsEnum).ToString(): ".mlmask");
                try
                {
                    mlmask.Import(rawRelative.ToFileInfo(), redfile.ToFileInfo());
                    _loggerService.Success($"Successfully created {redfile}");
                    return true;
                }
                catch(Exception ex)
                {
                    _loggerService.Error($"Unexpected error occured while importing {rawRelative}: {ex.Message}");
                    return false;
                }
            }
            else
            {
                _loggerService.Error($"Unexpected error occured while importing {rawRelative}");
                return false;
            }
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
                red.CreateChunk(font);

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
                    index = 0,
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
                if (redpath == null)
                {
                    return false;
                }

                using var fs = new FileStream(redpath, FileMode.Create, FileAccess.Write);
                ms.Seek(0, SeekOrigin.Begin);
                ms.CopyTo(fs);

                return true;
            }



        }

        private bool ImportXbm(RedRelativePath rawRelative, DirectoryInfo outDir, XbmImportArgs args)
        {
            var rawExt = rawRelative.Extension;
            var redfile = "";

            // checks
            if (args.Keep)
            {
                redfile = FindRedFile(rawRelative, outDir, ERedExtension.xbm.ToString());

                if (string.IsNullOrEmpty(redfile))
                {
                    _loggerService.Warning($"No existing redfile found to rebuild for {rawRelative.Name}");
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

                // get the format from the existing xbm
                EFormat? format = null;
                if (args.Keep)
                {
                    using var redstream = new FileStream(redfile, FileMode.Open);
                    using var fileReader = new BinaryReader(redstream);

                    var cr2w = _wolvenkitFileService.TryReadRED4File(fileReader);
                    if (cr2w == null)
                    {
                        return false;
                    }

                    if (cr2w.StringDictionary[1] != "CBitmapTexture")
                    {
                        return false;
                    }

                    if (cr2w.Chunks.FirstOrDefault()?.Data is not CBitmapTexture xbm ||
                        cr2w.Chunks[1]?.Data is not rendRenderTextureBlobPC)
                    {
                        return false;
                    }

                    var rawfmt = Enums.ETextureRawFormat.TRF_Invalid;
                    if (xbm.Setup.RawFormat?.Value != null)
                    {
                        rawfmt = xbm.Setup.RawFormat.Value;
                    }

                    var compression = Enums.ETextureCompression.TCM_None;
                    if (xbm.Setup.Compression?.Value != null)
                    {
                        compression = xbm.Setup.Compression.Value;
                    }

                    format = CommonFunctions.GetDXGIFormat(compression, rawfmt, _loggerService);


                }
                else
                {
                    // TODO
                    // get the format from texturegroup input or default
                }

                var infile = rawRelative.FullName;
                using var fs = new FileStream(infile, FileMode.Open);
                var ddsbuffer = DDSUtils.ConvertToDdsMemory(fs, extAsEnum, format);
                //ms.Write(ddsbuffer.Skip(148).ToArray());
                ms.Write(ddsbuffer);
                // remove first 148 bytes (dds header)
                //var buffer = new byte[ddsbuffer.Length - 148];
                //Buffer.BlockCopy(ddsbuffer, 148, buffer, 0, buffer.Length);
            }
            else
            {
                using var fs = new FileStream(rawRelative.FullPath, FileMode.Open);
                fs.Seek(0, SeekOrigin.Begin);
                fs.CopyTo(ms);
            }

            // create xbm
            if (args.Keep)
            {
                using var fileStream = new FileStream(redfile, FileMode.Open, FileAccess.ReadWrite);
                var result = Rebuild(fileStream, new List<byte[]>() {ms.ToByteArray().Skip(148).ToArray()});

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
                // read dds metadata
                ms.Seek(0, SeekOrigin.Begin);

                var span = new Span<byte>(new byte[148]);
                ms.Read(span);

                if (!DDSUtils.TryGetMetadataFromDDSMemory(span, out var metadata))
                {
                    return false;
                }

                var width = metadata.Width;
                var height = metadata.Height;
                var mipCount = metadata.Mipscount;
                var slicecount = metadata.Slicecount;
                var alignment = metadata.Bpp;
                var fmt = metadata.Format;
                var textureDataSize = ms.Length - 148; //GetBlockSize(width, fmt);



                // create cr2wfile
                var red = new CR2WFile();
                red.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()));

                // create xbm chunk
                var xbm = new CBitmapTexture(red, null, "CBitmapTexture");
                xbm.CookingPlatform = new CEnum<Enums.ECookingPlatform>(red, xbm, "cookingPlatform") { Value = Enums.ECookingPlatform.PLATFORM_PC, IsSerialized = true };
                xbm.Width = new CUInt32(red, xbm, "width") { Value = width, IsSerialized = true };
                xbm.Height = new CUInt32(red, xbm, "height") { Value = height, IsSerialized = true };
                xbm.Setup = new STextureGroupSetup(red, xbm, "setup") { IsSerialized = true };

                SetTextureGroupSetup(xbm.Setup, red);

                // blob
                var renderTextureResource = new rendRenderTextureResource(red, xbm, "renderTextureResource") { IsSerialized = true };
                renderTextureResource.RenderResourceBlobPC = new CHandle<IRenderResourceBlob>(red, renderTextureResource, "renderResourceBlobPC")
                    .SetValue(2) as CHandle<IRenderResourceBlob>;
                xbm.RenderTextureResource = renderTextureResource;

                // create rendRenderTextureBlobPC chunk
                var blob = new rendRenderTextureBlobPC(red, null, "rendRenderTextureBlobPC") { IsSerialized = true };
                // header
                var header = new rendRenderTextureBlobHeader(red, blob, "header")
                    {
                        IsSerialized = true,
                        Version = new CUInt32(red, blob.Header, "version").SetValue(2) as CUInt32,
                        Flags = new CUInt32(red, blob.Header, "flags").SetValue(1) as CUInt32
                    };
                // header.SizeInfo
                var sizeInfo = new rendRenderTextureBlobSizeInfo(red, blob.Header, "sizeInfo")
                    {
                        IsSerialized = true,
                        Width = new CUInt16(red, header.SizeInfo, "width").SetValue((ushort)width) as CUInt16,
                        Height = new CUInt16(red, header.SizeInfo, "height").SetValue((ushort)height) as CUInt16
                    };
                header.SizeInfo = sizeInfo;
                // header.TextureInfo
                var texInfo = new rendRenderTextureBlobTextureInfo(red, blob.Header, "textureInfo")
                    {
                        IsSerialized = true,
                        TextureDataSize = new CUInt32(red, header.TextureInfo, "textureDataSize").SetValue((uint)textureDataSize) as CUInt32,
                        SliceSize = new CUInt32(red, header.TextureInfo, "sliceSize").SetValue((uint)textureDataSize) as CUInt32,
                        DataAlignment = new CUInt32(red, header.TextureInfo, "dataAlignment").SetValue(alignment) as CUInt32,
                        SliceCount = new CUInt16(red, header.TextureInfo, "sliceCount").SetValue((ushort)slicecount) as CUInt16,
                        MipCount = new CUInt8(red, header.TextureInfo, "mipCount").SetValue((byte)mipCount) as CUInt8
                    };
                header.TextureInfo = texInfo;
                // header.TextureInfo
                var mipMapInfo = new CArray<rendRenderTextureBlobMipMapInfo>(red, blob.Header, "mipMapInfo") { IsSerialized = true };
                using (var reader = new BinaryReader(ms))
                {
                    ms.Seek(148, SeekOrigin.Begin);

                    var mipsizeH = height;
                    var mipsizeW = width;
                    var offset = 0;
                    for (int i = 0; i < metadata.Mipscount; i++)
                    {
                        // slicepitch
                        var slicepitch = (int)DDSUtils.GetMipMapSize(mipsizeW, mipsizeH, fmt);
                        offset += slicepitch;   
                        //rowpitch
                        var rowpitch = DDSUtils.GetBlockSize(mipsizeW, fmt);


                        var buffer = reader.ReadBytes(slicepitch);
                        var size = buffer.Length;

                        var info = new rendRenderTextureBlobMipMapInfo(red, mipMapInfo, i.ToString()) { IsSerialized = true };
                        info.Layout = new rendRenderTextureBlobMemoryLayout(red, info, "layout")
                        {
                            IsSerialized = true,
                            RowPitch = new CUInt32(red, info.Layout, "rowPitch").SetValue(rowpitch) as CUInt32,
                            SlicePitch = new CUInt32(red, info.Layout, "slicePitch").SetValue((uint)slicepitch) as CUInt32
                        };
                        info.Placement = new rendRenderTextureBlobPlacement(red, info, "placement")
                        {
                            IsSerialized = true,
                            Offset = new CUInt32(red, info.Layout, "offset").SetValue((uint)offset) as CUInt32,
                            Size = new CUInt32(red, info.Layout, "size").SetValue((uint)slicepitch) as CUInt32
                        };



                        mipMapInfo.Add(info);

                        mipsizeH = Math.Max(4, mipsizeH / 2);
                        mipsizeW = Math.Max(4, mipsizeW / 2);
                    }
                }
                header.MipMapInfo = mipMapInfo;
                blob.Header = header;
                // texdata buffer ref
                blob.TextureData = new serializationDeferredDataBuffer(red, blob, "textureData")
                    .SetValue(1) as serializationDeferredDataBuffer;

                red.CreateChunk(xbm);
                var parentChunk = red.Chunks.First();
                red.CreateChunk(blob, 1, parentChunk as CR2WExportWrapper);

                // write
                var outpath = new RedRelativePath(rawRelative)
                    .ChangeBaseDir(outDir)
                    .ChangeExtension(ERedExtension.xbm.ToString());
                using var fs = new FileStream(outpath.FullPath, FileMode.Create, FileAccess.ReadWrite);
                //using (var outms = new MemoryStream())
                using (var bw = new BinaryWriter(fs))
                {
                    // write cr2w file
                    red.Write(bw);

                    // add buffer
                    fs.Seek(0, SeekOrigin.Begin);
                    var result = Rebuild(fs, new List<byte[]>() {ms.ToByteArray()});
                    if (!result)
                    {
                        throw new ImportException();
                    }
                }
            }

            return true;

            #region local functions
#pragma warning disable CS8321 // Local function is declared but never used

            void SetTextureGroupSetup(STextureGroupSetup setup, IRed4EngineFile cr2w)
            {
                // first check the user-texture group
                //var (compression, rawformat, flags) = CommonFunctions.GetRedFormatsFromTextureGroup(args.TextureGroup);



                setup.Group = new CEnum<Enums.GpuWrapApieTextureGroup>(cr2w, setup, "group")
                {
                    IsSerialized = true,
                    Value = args.TextureGroup
                };
                setup.Compression = new CEnum<Enums.ETextureCompression>(cr2w, setup, "compression")
                {
                    IsSerialized = true,
                    Value = Enums.ETextureCompression.TCM_None
                };
                setup.RawFormat = new CEnum<Enums.ETextureRawFormat>(cr2w, setup, "rawFormat")
                {
                    IsSerialized = true,
                    Value = Enums.ETextureRawFormat.TRF_TrueColor
                };

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
            if (args.Keep)
            {
                var redfile = FindRedFile(rawRelative,  outDir,$".{args.importFormat.ToString().ToLower()}");

                if (string.IsNullOrEmpty(redfile))
                {
                    _loggerService.Warning($"No existing redfile found to rebuild for {rawRelative.Name}");
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
                            result = ImportMesh(rawRelative.ToFileInfo(), redFs, args.Archives, args.validationMode, args.importMaterialOnly);
                            break;
                        case GltfImportAsFormat.Morphtarget:
                            result = ImportTargetBaseMesh(rawRelative.ToFileInfo(), redFs, args.Archives, outDir.FullName, args.validationMode);
                            break;
                    }

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
