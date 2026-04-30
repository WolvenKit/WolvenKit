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

        private static IEnumerable<RedImage> GetRedImages(rendRenderMultilayerMaskBlobPC blob, bool preserveNativeResolutions = true)
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
                throw new Exception("Failed to decode BC4 atlas data");

            var tileBuffer = blob.TilesData.Buffer;
            var tiles = new uint[tileBuffer.MemSize / 4];
            using (var ms = new MemoryStream(tileBuffer.GetBytes()))
            using (var br = new BinaryReader(ms))
            {
                ms.Seek(0, SeekOrigin.Begin);
                for (var i = 0; i < tiles.Length; i++)
                    tiles[i] = br.ReadUInt32();
            }

            for (var layerIndex = 0; layerIndex < maskCount; layerIndex++)
            {
                byte[] layerPixels;
                uint finalWidth;
                uint finalHeight;

                if (preserveNativeResolutions)
                {
                    bool hasHighRes = HasLayerHighResolutionData(tiles, maskWidth, maskHeight, maskTileSize, layerIndex);

                    if (hasHighRes)
                    {
                        layerPixels = new byte[maskWidth * maskHeight];
                        DecodeWithCorruptionPrevention(ref layerPixels, maskWidth, maskHeight,
                            maskWidthLow, maskHeightLow, atlasRaw, atlasWidth, atlasHeight,
                            tiles, maskTileSize, layerIndex);
                        finalWidth = maskWidth;
                        finalHeight = maskHeight;
                    }
                    else if (maskWidthLow > 0 && maskHeightLow > 0 && maskWidthLow != maskWidth)
                    {
                        layerPixels = new byte[maskWidthLow * maskHeightLow];
                        DecodeWithCorruptionPrevention(ref layerPixels, maskWidthLow, maskHeightLow,
                            maskWidthLow, maskHeightLow, atlasRaw, atlasWidth, atlasHeight,
                            tiles, maskTileSize, layerIndex);
                        finalWidth = maskWidthLow;
                        finalHeight = maskHeightLow;
                    }
                    else
                    {
                        layerPixels = new byte[maskWidth * maskHeight];
                        DecodeWithCorruptionPrevention(ref layerPixels, maskWidth, maskHeight,
                            maskWidthLow, maskHeightLow, atlasRaw, atlasWidth, atlasHeight,
                            tiles, maskTileSize, layerIndex);
                        finalWidth = maskWidth;
                        finalHeight = maskHeight;
                    }
                }
                else
                {
                    layerPixels = new byte[maskWidth * maskHeight];
                    DecodeWithCorruptionPrevention(ref layerPixels, maskWidth, maskHeight,
                        maskWidthLow, maskHeightLow, atlasRaw, atlasWidth, atlasHeight,
                        tiles, maskTileSize, layerIndex);
                    finalWidth = maskWidth;
                    finalHeight = maskHeight;
                }

                var info = new DDSUtils.DDSInfo
                {
                    Compression = Enums.ETextureCompression.TCM_None,
                    RawFormat = Enums.ETextureRawFormat.TRF_Grayscale,
                    IsGamma = false,
                    Width = finalWidth,
                    Height = finalHeight,
                    Depth = 1,
                    MipCount = 1,
                    SliceCount = 1,
                    TextureType = Enums.GpuWrapApieTextureType.TEXTYPE_2D
                };

                yield return RedImage.Create(info, layerPixels);
            }
        }

        private static bool HasLayerHighResolutionData(uint[] tiles, uint maskWidth, uint maskHeight, uint maskTileSize, int layerIndex)
        {
            var widthInTiles = DivCeil(maskWidth, maskTileSize);
            var heightInTiles = DivCeil(maskHeight, maskTileSize);
            var highResTileCount = widthInTiles * heightInTiles;

            for (uint tileIdx = 0; tileIdx < highResTileCount; tileIdx++)
            {
                int bitIndex = (int)((tileIdx * 2) + 1);
                if (bitIndex >= tiles.Length) continue;
                if ((tiles[bitIndex] & (1u << layerIndex)) != 0) return true;
            }
            return false;
        }

        private static void DecodeWithCorruptionPrevention(ref byte[] maskData, uint maskWidth, uint maskHeight,
            uint mWidthLow, uint mHeightLow, byte[] atlasData, uint atlasWidth, uint atlasHeight,
            uint[] tileData, uint maskTileSize, int maskIndex)
        {
            var widthInTiles0 = DivCeil(maskWidth, maskTileSize);
            var heightInTiles0 = DivCeil(maskHeight, maskTileSize);
            var smallOffset = widthInTiles0 * heightInTiles0;

            var smallScale = (mWidthLow == 0 || maskWidth < mWidthLow) ? 1u : maskWidth / mWidthLow;
            bool hasHighResData = HasLayerHighResolutionData(tileData, maskWidth, maskHeight, maskTileSize, maskIndex);

            for (uint x = 0; x < maskWidth; x++)
            {
                for (uint y = 0; y < maskHeight; y++)
                {
                    DecodeSingle(ref maskData, maskWidth, maskHeight, atlasData, atlasWidth, atlasHeight,
                        x, y, tileData, maskTileSize, maskIndex, smallOffset, smallScale);

                    if (hasHighResData)
                    {
                        DecodeSingle(ref maskData, maskWidth, maskHeight, atlasData, atlasWidth, atlasHeight,
                            x, y, tileData, maskTileSize, maskIndex, 0, 1);
                    }
                }
            }
        }

        private static void DecodeSingle(ref byte[] maskData, uint maskWidth, uint maskHeight, byte[] atlasData,
            uint atlasWidth, uint atlasHeight, uint x, uint y, uint[] tilesData, uint maskTileSize,
            int maskIndex, uint tilesOffset, uint smallScale)
        {
            var widthInTiles = DivCeil(maskWidth / smallScale, maskTileSize);
            var xTile = x / maskTileSize / smallScale;
            var yTile = y / maskTileSize / smallScale;

            var tileIndex = (widthInTiles * yTile) + xTile + tilesOffset;
            if ((tileIndex * 2) + 1 >= tilesData.Length) return;

            var paramOffset = tilesData[tileIndex * 2];
            var paramBits = tilesData[(tileIndex * 2) + 1];

            if ((paramBits & (1u << maskIndex)) == 0) return;

            var extraAdd = CountBits((uint)(paramBits & ((1u << maskIndex) - 1)));

            uint tileDecl = 0;
            if (paramOffset + extraAdd < tilesData.Length)
                tileDecl = tilesData[paramOffset + extraAdd];

            var dx = tileDecl & 0x3ff;
            var dy = (tileDecl >> 10) & 0x3ff;
            var sx = (tileDecl >> 20) & 0xf;
            var sy = (tileDecl >> 24) & 0xf;

            var atlasTileSize = maskTileSize + 2;

            var ux = ((x >> (int)sx) % maskTileSize) + 1 + (dx * atlasTileSize);
            var uy = ((y >> (int)sy) % maskTileSize) + 1 + (dy * atlasTileSize);

            byte p = atlasData[ux + (uy * atlasWidth)]; // Nearest neighbor
            maskData[x + (y * maskWidth)] = p;
        }

        private static uint DivCeil(uint l, uint r) => (l + r - 1) / r;

        private static uint CountBits(uint v)
        {
            uint count = 0;
            for (uint i = 0; i < 32; i++)
            {
                if ((v & 1) == 1) count++;
                v >>= 1;
            }
            return count;
        }

        public bool UncookMlmask(Multilayer_Mask mlmask, FileInfo outfile, MlmaskExportArgs args)
        {
            if (mlmask.RenderResourceBlob.RenderResourceBlobPC.Chunk is not rendRenderMultilayerMaskBlobPC blob)
                return false;

            DirectoryInfo? subDir = null;
            if (args.AsList)
            {
                subDir = new DirectoryInfo(Path.ChangeExtension(outfile.FullName, null) + "_layers");
                if (!subDir.Exists)
                    Directory.CreateDirectory(subDir.FullName);
            }

            if ((args.AsList && subDir is null) || (!args.AsList && outfile.Directory is null))
            {
                _loggerService.Error("directory was null");
                return false;
            }

            var cnt = 0;
            var masks = new List<string>();

            foreach (var img in GetRedImages(blob, args.PreserveNativeResolutions))
            {
                var mFilename = Path.GetFileNameWithoutExtension(outfile.FullName) + $"_{cnt++}";
                var newPath = Path.Combine(args.AsList ? subDir!.FullName : outfile.Directory!.FullName,
                                           $"{mFilename}.{args.UncookExtension}");

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
                    masks.Add($"{subDir!.Name}/{mFilename}.{args.UncookExtension}");
            }

            if (args.AsList)
            {
                var maskListPath = Path.ChangeExtension(outfile.FullName, "masklist");

                var headerLines = new List<string>
                {
                    "# MLMask Export v2",
                    "# Original file header values - do not modify unless you know what you are doing",
                    $"AtlasWidth={blob.Header.AtlasWidth}",
                    $"AtlasHeight={blob.Header.AtlasHeight}",
                    $"MaskWidth={blob.Header.MaskWidth}",
                    $"MaskHeight={blob.Header.MaskHeight}",
                    $"MaskWidthLow={blob.Header.MaskWidthLow}",
                    $"MaskHeightLow={blob.Header.MaskHeightLow}",
                    $"MaskTileSize={blob.Header.MaskTileSize}",
                    $"NumLayers={blob.Header.NumLayers}",
                    $"PreserveNativeResolutions={args.PreserveNativeResolutions}",
                    "",
                    "# Layer image files (must be in correct order)"
                };

                headerLines.AddRange(masks);
                File.WriteAllLines(maskListPath, headerLines);
            }

            return true;
        }

        public static bool ConvertMultilayerMaskToDdsStreams(Multilayer_Mask mask, out List<Stream> streams)
        {
            streams = new List<Stream>();
            if (mask.RenderResourceBlob.RenderResourceBlobPC.GetValue() is not rendRenderMultilayerMaskBlobPC blob)
                return false;

            foreach (var img in GetRedImages(blob, preserveNativeResolutions: true))
            {
                streams.Add(new MemoryStream(img.SaveToDDSMemory()));
                img.Dispose();
            }
            return true;
        }

        #endregion
    }
}
