using System;
using System.Collections.Generic;
using System.IO;
using CP77.Common.Image;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Common.Services;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {

        #region Methods

        public bool UncookMlmask(Stream cr2wStream, FileInfo outfile, MlmaskExportArgs args)
        {
            // read the cr2wfile
            var cr2w = _wolvenkitFileService.ReadRed4File(cr2wStream);
            if (cr2w == null || cr2w.RootChunk is not Multilayer_Mask mlmask || mlmask.RenderResourceBlob.RenderResourceBlobPC.Chunk is not rendRenderMultilayerMaskBlobPC blob)
            {
                return false;
            }

            uint atlasWidth = blob.Header.AtlasWidth;
            uint atlasHeight = blob.Header.AtlasHeight;

            uint maskWidth = blob.Header.MaskWidth;
            uint maskHeight = blob.Header.MaskHeight;

            uint maskWidthLow = blob.Header.MaskWidthLow;
            uint maskHeightLow = blob.Header.MaskHeightLow;

            uint maskTileSize = blob.Header.MaskTileSize;

            uint maskCount = blob.Header.NumLayers;

            var atlasRaw = new byte[atlasWidth * atlasHeight];

            //Decode compressed data into single channel uncompressed
            //Mlmask always BC4?
            if (!BlockCompression.DecodeBC(blob.AtlasData.Buffer.GetBytes(), ref atlasRaw, atlasWidth, atlasHeight, BlockCompression.BlockCompressionType.BC4))
            {
                return false;
            }

            //{
            //    var mFilename = filename + $"__.dds";
            //    var newpath = Path.Combine(path, mFilename);
            //    using (var ddsStream = new FileStream($"{newpath}", FileMode.Create, FileAccess.Write))
            //    {
            //        DDSUtils.GenerateAndWriteHeader(ddsStream, new DDSMetadata(atlasWidth, atlasHeight, 0, EFormat.R8_UNORM, 8, false, 0, false));
            //
            //        ddsStream.Write(atlasRaw);
            //    }
            //}

            //Read tilesdata buffer into appropriate variable type
            var tileBuffer = blob.TilesData.Buffer;
            var tiles = new uint[tileBuffer.MemSize / 4];

            using (var ms = new MemoryStream(tileBuffer.GetBytes()))
            using (var br = new BinaryReader(ms))
            {
                ms.Seek(0, SeekOrigin.Begin);

                for (var i = 0; i < tiles.Length; i++)
                {
                    tiles[i] = br.ReadUInt32();
                }
            }

            // write texture to file
            DirectoryInfo subdir = null;
            if (args.AsList)
            {
                subdir = new DirectoryInfo(Path.ChangeExtension(outfile.FullName, null) + "_layers");
                if (!subdir.Exists)
                {
                    Directory.CreateDirectory(subdir.FullName);
                }
            }

            var maskData = new byte[maskWidth * maskHeight];
            var masks = new List<string>();
            for (var i = 0; i < maskCount; i++)
            {

                //Clear instead of allocate new is faster?
                //Mandatory cause decode does not always write to every pixel
                Array.Clear(maskData, 0, maskData.Length);
                try
                {
                    Decode(ref maskData, maskWidth, maskHeight, maskWidthLow, maskHeightLow, atlasRaw, atlasWidth,
                        atlasHeight, tiles, maskTileSize, i);
                }
                catch
                {
                    return false;
                }

                if (WolvenTesting.IsTesting)
                {
                    continue;
                }

                var info = new DDSUtils.DDSInfo
                {
                    Compression = Enums.ETextureCompression.TCM_None,
                    RawFormat = Enums.ETextureRawFormat.TRF_Grayscale,
                    IsGamma = false,
                    Width = maskWidth,
                    Height = maskHeight,
                    Depth = 1,
                    MipCount = 1,
                    SliceCount = 1,
                    TextureType = Enums.GpuWrapApieTextureType.TEXTYPE_2D,
                    FlipV = false
                };

                var img = RedImage.Create(info, maskData);


                var mFilename = Path.GetFileNameWithoutExtension(outfile.FullName) + $"_{i}";
                string newpath;
                if (args.AsList)
                {
                    newpath = Path.Combine(subdir.FullName, $"{mFilename}");
                }
                else
                {
                    newpath = Path.Combine(outfile.Directory.FullName, $"{mFilename}");
                }

                switch (args.UncookExtension)
                {
                    case EUncookExtension.dds:
                        img.SaveToDDS(newpath + ".dds");

                        if (args.AsList)
                        {
                            masks.Add($"{subdir.Name}/{mFilename}.dds");
                        }
                        break;
                    case EUncookExtension.tga:
                        img.SaveToTGA(newpath + ".tga");
                    
                        if (args.AsList)
                        {
                            masks.Add($"{subdir.Name}/{mFilename}.tga");
                        }
                        break;
                    case EUncookExtension.bmp:
                        img.SaveToBMP(newpath + ".bmp");
                    
                        if (args.AsList)
                        {
                            masks.Add($"{subdir.Name}/{mFilename}.bmp");
                        }
                        break;
                    case EUncookExtension.jpg:
                        img.SaveToJPEG(newpath + ".jpg");
                    
                        if (args.AsList)
                        {
                            masks.Add($"{subdir.Name}/{mFilename}.jpg");
                        }
                        break;
                    case EUncookExtension.png:
                        img.SaveToPNG(newpath + ".png");

                        if (args.AsList)
                        {
                            masks.Add($"{subdir.Name}/{mFilename}.png");
                        }
                        break;
                    case EUncookExtension.tiff:
                        img.SaveToTIFF(newpath + ".tiff");
                    
                        if (args.AsList)
                        {
                            masks.Add($"{subdir.Name}/{mFilename}.tiff");
                        }
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            if (args.AsList)
            {
                // write metadata
                var masklist = Path.ChangeExtension(outfile.FullName, "masklist");
                File.WriteAllLines(masklist, masks.ToArray());
            }

            return true;
        }

        public static bool ConvertMultilayerMaskToDdsStreams(Multilayer_Mask mask, out List<Stream> streams)
        {
            streams = new List<Stream>();
            if (mask.RenderResourceBlob.RenderResourceBlobPC.GetValue() is not rendRenderMultilayerMaskBlobPC blob)
            {
                return false;
            }

            uint atlasWidth = blob.Header.AtlasWidth;
            uint atlasHeight = blob.Header.AtlasHeight;

            uint maskWidth = blob.Header.MaskWidth;
            uint maskHeight = blob.Header.MaskHeight;

            uint maskWidthLow = blob.Header.MaskWidthLow;
            uint maskHeightLow = blob.Header.MaskHeightLow;

            uint maskTileSize = blob.Header.MaskTileSize;

            uint maskCount = blob.Header.NumLayers;

            var atlasRaw = new byte[atlasWidth * atlasHeight];

            //Decode compressed data into single channel uncompressed
            //Mlmask always BC4?
            if (!BlockCompression.DecodeBC(blob.AtlasData.Buffer.GetBytes(), ref atlasRaw, atlasWidth, atlasHeight, BlockCompression.BlockCompressionType.BC4))
            {
                return false;
            }

            //atlasRaw = blob.AtlasData.Buffer.GetBytes();

            //Read tilesdata buffer into appropriate variable type
            var tileBuffer = blob.TilesData.Buffer;
            var tiles = new uint[tileBuffer.MemSize / 4];

            using (var ms = new MemoryStream(tileBuffer.GetBytes()))
            using (var br = new BinaryReader(ms))
            {
                ms.Seek(0, SeekOrigin.Begin);

                for (var i = 0; i < tiles.Length; i++)
                {
                    tiles[i] = br.ReadUInt32();
                }
            }

            var maskData = new byte[maskWidth * maskHeight];

            for (var i = 0; i < maskCount; i++)
            {
                //Clear instead of allocate new is faster?
                //Mandatory cause decode does not always write to every pixel
                Array.Clear(maskData, 0, maskData.Length);
                try
                {
                    Decode(ref maskData, maskWidth, maskHeight, maskWidthLow, maskHeightLow, atlasRaw, atlasWidth,
                        atlasHeight, tiles, maskTileSize, i);
                }
                catch
                {
                    throw;
                }

                if (WolvenTesting.IsTesting)
                {
                    continue;
                }

                var ms = new MemoryStream();
                DDSUtils.GenerateAndWriteHeader(ms, new DDSMetadata(maskWidth, maskHeight,
                    1, 1, 0, 0, 0, DXGI_FORMAT.DXGI_FORMAT_R8_UNORM, TEX_DIMENSION.TEX_DIMENSION_TEXTURE2D, 8, true));
                ms.Write(maskData);
                ms.Seek(0, SeekOrigin.Begin);
                //var stream = new MemoryStream(DDSUtils.ConvertToDdsMemory(ms, EUncookExtension.tga, DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM, false, false));
                ms = new MemoryStream(
                    Texconv.ConvertToDds(
                        new MemoryStream(Texconv.ConvertFromDds(ms, EUncookExtension.tga)),
                        EUncookExtension.tga, DXGI_FORMAT.DXGI_FORMAT_BC4_UNORM));
                streams.Add(ms);
            }
            return true;
        }

        private static byte BilinearInterpolation(byte q00, byte q10, byte q01, byte q11, int x, int x1, int y, int y1)
        {
            const int sc = 256;

            if (x1 == 0 || y1 == 0)
            {
                return q00;
            }

            var q00s = q00 * sc;
            var q10s = q10 * sc;
            var q01s = q01 * sc;
            var q11s = q11 * sc;

            var a0 = q00s;
            var a1 = (q10s - q00s) * x / x1;
            var a2 = (q01s - q00s) * y / y1;
            var a3 = (q00s - q01s - q10s + q11s) * x * y / x1 / y1;

            var a = a0 + a1 + a2 + a3;
            var r = a / sc;
            if (r > 255)
            {
                r = 255;
            }

            return (byte)r;
        }

        private static uint CountBits(uint v)
        {
            var t = v;
            uint count = 0;
            for (uint i = 0; i < 32; i++)
            {
                if ((t & 1) == 1)
                {
                    count++;
                }
                t >>= 1;
            }
            return count;
        }

        public static void Decode(ref byte[] maskData, uint maskWidth, uint maskHeight, uint mWidthLow, uint mHeightLow, byte[] atlasData, uint atlasWidth, uint atlasHeight, uint[] tileData, uint maskTileSize, int maskIndex)
        {
            var widthInTiles0 = DivCeil(maskWidth, maskTileSize);
            var heightInTiles0 = DivCeil(maskHeight, maskTileSize);
            var smallOffset = widthInTiles0 * heightInTiles0;

            var smallScale = maskWidth / mWidthLow;

            for (uint x = 0; x < maskWidth; x++)
            {
                for (uint y = 0; y < maskHeight; y++)
                {
                    DecodeSingle(ref maskData, maskWidth, maskHeight, atlasData, atlasWidth, atlasHeight, x, y, tileData, maskTileSize, maskIndex, smallOffset, smallScale);
                    DecodeSingle(ref maskData, maskWidth, maskHeight, atlasData, atlasWidth, atlasHeight, x, y, tileData, maskTileSize, maskIndex, 0, 1);
                }
            }
        }

        private static void DecodeSingle(ref byte[] maskData, uint maskWidth, uint maskHeight, byte[] atlasData, uint atlasWidth, uint atlasHeight, uint x, uint y, uint[] tilesData, uint maskTileSize, int maskIndex, uint tilesOffset, uint smallScale)
        {
            var widthInTiles = DivCeil(maskWidth / smallScale, maskTileSize);

            var xTile = x / maskTileSize / smallScale;
            var yTile = y / maskTileSize / smallScale;

            var tileIndex = (widthInTiles * yTile) + xTile + tilesOffset;

            var paramOffset = tilesData[tileIndex * 2];
            var paramBits = tilesData[(tileIndex * 2) + 1];

            if ((uint)(paramBits & (1 << maskIndex)) == 0U)
            {
                return;
            }

            var extraAdd = CountBits((uint)(paramBits & ((1 << maskIndex) - 1)));

            uint tileDecl = 0;
            if (paramOffset + extraAdd < tilesData.Length)
            {
                tileDecl = tilesData[paramOffset + extraAdd];
            }

            var dx = tileDecl & 0x3ff;
            var dy = (tileDecl >> 10) & 0x3ff;
            var sx = (tileDecl >> 20) & 0xf;
            var sy = (tileDecl >> 24) & 0xf;

            var atlasTileSize = maskTileSize + 2;

            var x1 = (1 << (int)sx) - 1;
            var xi = (int)(x & x1);
            var y1 = (1 << (int)sy) - 1;
            var yi = (int)(y & y1);

            var ux = ((x >> (int)sx) % maskTileSize) + 1 + (dx * atlasTileSize);
            var uy = ((y >> (int)sy) % maskTileSize) + 1 + (dy * atlasTileSize);

            var q00 = atlasData[ux + 0 + ((uy + 0) * atlasWidth)];
            var q10 = atlasData[ux + 1 + ((uy + 0) * atlasWidth)];
            var q01 = atlasData[ux + 0 + ((uy + 1) * atlasWidth)];
            var q11 = atlasData[ux + 1 + ((uy + 1) * atlasWidth)];

            var p = BilinearInterpolation(q00, q10, q01, q11, xi, x1, yi, y1);

            maskData[x + (y * maskWidth)] = p;
        }

        private static uint DivCeil(uint l, uint r) => (l + r - 1) / r;

        #endregion Methods
    }
}
