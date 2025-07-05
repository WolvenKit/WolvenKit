using System;
using System.Collections.Generic;
using System.IO;
using CP77.Common.Image;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        #region Methods

        private static IEnumerable<RedImage> GetRedImages(rendRenderMultilayerMaskBlobPC blob)
        {
            uint atlasWidth = blob.Header.AtlasWidth;
            uint atlasHeight = blob.Header.AtlasHeight;

            uint maskWidth = blob.Header.MaskWidth;
            uint maskHeight = blob.Header.MaskHeight;

            uint maskWidthLow = blob.Header.MaskWidthLow;
            uint maskHeightLow = blob.Header.MaskHeightLow;

            uint maskTileSize = blob.Header.MaskTileSize;

            uint maskCount = blob.Header.NumLayers;

            var atlasRaw = new byte[atlasWidth * atlasHeight];

            if (!BlockCompression.DecodeBC(blob.AtlasData.Buffer.GetBytes(), ref atlasRaw, atlasWidth, atlasHeight, BlockCompression.BlockCompressionType.BC4))
            {
                throw new Exception();
            }

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

                Decode(ref maskData, maskWidth, maskHeight, maskWidthLow, maskHeightLow, atlasRaw, atlasWidth,
                    atlasHeight, tiles, maskTileSize, i);

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
                    TextureType = Enums.GpuWrapApieTextureType.TEXTYPE_2D
                };

                yield return RedImage.Create(info, maskData);
            }
        }

        public bool UncookMlmask(Multilayer_Mask mlmask, FileInfo outfile, MlmaskExportArgs args)
        {
            // read the cr2wfile
            if (mlmask.RenderResourceBlob.RenderResourceBlobPC.Chunk is not rendRenderMultilayerMaskBlobPC blob)
            {
                return false;
            }

            // write texture to file
            DirectoryInfo? subDir = null;
            if (args.AsList)
            {
                subDir = new DirectoryInfo(Path.ChangeExtension(outfile.FullName, null) + "_layers");
                if (!subDir.Exists)
                {
                    Directory.CreateDirectory(subDir.FullName);
                }
            }

            if ((args.AsList && subDir is null) || (!args.AsList && outfile.Directory is null))
            {
                _loggerService.Error("directory was null");
                return false;
            }

            var cnt = 0;
            var masks = new List<string>();

            foreach (var img in GetRedImages(blob))
            {
                var mFilename = Path.GetFileNameWithoutExtension(outfile.FullName) + $"_{cnt++}";
                var newPath = Path.Combine(args.AsList ? subDir!.FullName : outfile.Directory!.FullName, $"{mFilename}.{args.UncookExtension}");

                var buffer = args.UncookExtension switch
                {
                    EUncookExtension.dds => img.SaveToDDSMemory(),
                    EUncookExtension.tga => img.SaveToTGAMemory(),
                    EUncookExtension.bmp => img.SaveToBMPMemory(),
                    EUncookExtension.jpg => img.SaveToJPEGMemory(),
                    EUncookExtension.png => img.SaveToPNGMemory(),
                    EUncookExtension.tiff => img.SaveToTIFFMemory(),
                    _ => throw new ArgumentOutOfRangeException()
                };
                img.Dispose();

                File.WriteAllBytes(newPath, buffer);
                if (args.AsList)
                {
                    masks.Add($"{subDir!.Name}/{mFilename}.{args.UncookExtension}");
                }
            }

            if (args.AsList)
            {
                // write metadata
                var maskList = Path.ChangeExtension(outfile.FullName, "masklist");
                File.WriteAllLines(maskList, masks.ToArray());
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

            foreach (var img in GetRedImages(blob))
            {
                streams.Add(new MemoryStream(img.SaveToDDSMemory()));
                img.Dispose();
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

        private static void Decode(ref byte[] maskData, uint maskWidth, uint maskHeight, uint mWidthLow, uint mHeightLow, byte[] atlasData, uint atlasWidth, uint atlasHeight, uint[] tileData, uint maskTileSize, int maskIndex)
        {
            var widthInTiles0 = DivCeil(maskWidth, maskTileSize);
            var heightInTiles0 = DivCeil(maskHeight, maskTileSize);
            var smallOffset = widthInTiles0 * heightInTiles0;

            // DivideByZero preventions.
            // maskWidthLow == 0
            // maskWidth < mWidthLow => maskWidth / mWidthLow = 0 because (int) Math
            var smallScale =
                mWidthLow == 0 || maskWidth < mWidthLow
                    ? 1
                    : maskWidth / mWidthLow;

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

            if ((tileIndex * 2) + 1 >= tilesData.Length)
            {
                return;
            }

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
