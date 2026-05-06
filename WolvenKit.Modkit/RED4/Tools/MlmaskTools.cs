using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CP77.Common.Image;
using WolvenKit.Core.Exceptions;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4;

public partial class ModTools
{
    private const uint ATLAS_TILE_PADDING = 2;

    // Bit layout of tileDecl (from multilayer mask tiles data)
    private const uint TILE_PARAM_MASK = 0x3FF;   // 10 bits (0-9)
    private const int  TILE_DX_SHIFT   = 0;       // bits 0-9  → X offset in atlas
    private const int  TILE_DY_SHIFT   = 10;      // bits 10-19 → Y offset in atlas
    private const int  TILE_SX_SHIFT   = 20;      // bits 20-23 → X scale/shift
    private const int  TILE_SY_SHIFT   = 24;      // bits 24-27 → Y scale/shift
    private const uint TILE_S_MASK     = 0xF;     // 4 bits

    #region Methods

    // Decode each grayscale layer to RedImage (always outputs linear R8G8B8A8_UNORM)
    private static IEnumerable<RedImage> GetRedImages(rendRenderMultilayerMaskBlobPC blob)
    {
        uint atlasWidth = blob.Header.AtlasWidth;
        uint atlasHeight = blob.Header.AtlasHeight;
        uint maskWidth = blob.Header.MaskWidth;
        uint maskHeight = blob.Header.MaskHeight;
        uint maskWidthLow = blob.Header.MaskWidthLow;
        uint maskHeightLow = blob.Header.MaskHeightLow;
        uint maskTileSize = blob.Header.MaskTileSize;

        var atlasRaw = new byte[atlasWidth * atlasHeight];
        if (!BlockCompression.DecodeBC(blob.AtlasData.Buffer.GetBytes(), ref atlasRaw, atlasWidth, atlasHeight, BlockCompression.BlockCompressionType.BC4))
        {
            throw new WolvenKitException(0x3001, "BC4 decode failed for multilayer mask atlas.");
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

        foreach (var layer in DecodeLayerBuffers(blob))
        {
            var (layerBuffer, outWidth, outHeight) = layer;

            var info = new DDSUtils.DDSInfo
            {
                Compression = Enums.ETextureCompression.TCM_None,
                RawFormat = Enums.ETextureRawFormat.TRF_Grayscale,
                IsGamma = false,
                Width = outWidth,
                Height = outHeight,
                Depth = 1,
                MipCount = 1,
                SliceCount = 1,
                TextureType = Enums.GpuWrapApieTextureType.TEXTYPE_2D
            };

            var img = RedImage.Create(info, layerBuffer);

            try
            {
                var targetLinear = Common.DDS.DXGI_FORMAT.DXGI_FORMAT_R8G8B8A8_UNORM;
                if (img.Metadata.Format != (DXGI_FORMAT)targetLinear)
                {
                    img.Convert(targetLinear);
                }
            }
            catch
            {
                // Conversion failed — yield original image
            }

            yield return img;
        }
    }

    /// <summary>
    /// Decodes each layer from the multilayer mask.
    /// Layers are exported either at full high resolution or at the reduced low resolution,
    /// depending on whether the layer has dedicated high-resolution tile data.
    /// </summary>
    private static IEnumerable<(byte[] buffer, uint width, uint height)> DecodeLayerBuffers(rendRenderMultilayerMaskBlobPC blob)
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
            throw new WolvenKitException(0x3001, "BC4 decode failed for multilayer mask atlas.");
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

        var fullResBuffer = new byte[maskWidth * maskHeight];

        for (var i = 0; i < maskCount; i++)
        {
            Array.Clear(fullResBuffer, 0, fullResBuffer.Length);
            Decode(ref fullResBuffer, maskWidth, maskHeight, maskWidthLow, maskHeightLow, atlasRaw, atlasWidth, atlasHeight, tiles, maskTileSize, i);

            var hasHighRes = HasLayerHighResolutionData(tiles, maskWidth, maskHeight, maskTileSize, i);

            byte[] layerBuffer;
            uint outWidth;
            uint outHeight;

            if (hasHighRes || maskWidthLow == 0 || maskHeightLow == 0 || maskWidthLow == maskWidth)
            {
                layerBuffer = (byte[])fullResBuffer.Clone();
                outWidth = maskWidth;
                outHeight = maskHeight;
            }
            else
            {
                outWidth = maskWidthLow;
                outHeight = maskHeightLow;
                layerBuffer = DownscaleNearest(fullResBuffer, maskWidth, maskHeight, outWidth, outHeight);
            }

            yield return (layerBuffer, outWidth, outHeight);
        }
    }

    /// <summary>
    /// Checks whether a specific layer has any high-resolution tile data.
    /// This determines if the layer should be exported at full resolution or downscaled.
    /// </summary>
    private static bool HasLayerHighResolutionData(uint[] tiles, uint maskWidth, uint maskHeight, uint maskTileSize, int layerIndex)
    {
        var widthInTiles = DivCeil(maskWidth, maskTileSize);
        var heightInTiles = DivCeil(maskHeight, maskTileSize);
        var highResTileCount = widthInTiles * heightInTiles;

        for (uint tileIdx = 0; tileIdx < highResTileCount; tileIdx++)
        {
            if ((tileIdx * 2) + 1 >= tiles.Length)
            {
                continue;
            }

            var paramBits = tiles[(tileIdx * 2) + 1];

            if ((paramBits & (1 << layerIndex)) != 0)
            {
                return true;
            }
        }

        return false;
    }

    private static void Decode(ref byte[] maskData, uint maskWidth, uint maskHeight, uint maskWidthLow, uint maskHeightLow, byte[] atlasData, uint atlasWidth, uint atlasHeight, uint[] tileData, uint maskTileSize, int maskIndex)
    {
        var widthInTiles0 = DivCeil(maskWidth, maskTileSize);
        var heightInTiles0 = DivCeil(maskHeight, maskTileSize);
        var smallOffset = widthInTiles0 * heightInTiles0;
        var smallScale = (maskWidthLow == 0 || maskWidth < maskWidthLow) ? 1u : maskWidth / maskWidthLow;

        var widthInTilesScaled = DivCeil(maskWidth / smallScale, maskTileSize);
        var widthInTilesFull = DivCeil(maskWidth, maskTileSize);

        for (uint y = 0; y < maskHeight; y++)
        {
            for (uint x = 0; x < maskWidth; x++)
            {
                DecodeSingle(ref maskData, maskWidth, maskHeight, atlasData, atlasWidth, atlasHeight, x, y, tileData, maskTileSize, maskIndex, smallOffset, smallScale, widthInTilesScaled);
                DecodeSingle(ref maskData, maskWidth, maskHeight, atlasData, atlasWidth, atlasHeight, x, y, tileData, maskTileSize, maskIndex, 0, 1, widthInTilesFull);
            }
        }
    }

    private static void DecodeSingle(ref byte[] maskData, uint maskWidth, uint maskHeight, byte[] atlasData, uint atlasWidth, uint atlasHeight, uint x, uint y, uint[] tilesData, uint maskTileSize, int maskIndex, uint tilesOffset, uint smallScale, uint widthInTiles)
    {
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

        // Extract atlas position and scaling factors from the packed tile declaration.
        // dx/dy = tile position in the atlas, sx/sy = bit-shift scaling for this layer.
        var dx = (tileDecl >> TILE_DX_SHIFT) & TILE_PARAM_MASK;
        var dy = (tileDecl >> TILE_DY_SHIFT) & TILE_PARAM_MASK;
        var sx = (tileDecl >> TILE_SX_SHIFT) & TILE_S_MASK;
        var sy = (tileDecl >> TILE_SY_SHIFT) & TILE_S_MASK;

        var atlasTileSize = maskTileSize + ATLAS_TILE_PADDING;

        var ux = ((x >> (int)sx) % maskTileSize) + 1 + (dx * atlasTileSize);
        var uy = ((y >> (int)sy) % maskTileSize) + 1 + (dy * atlasTileSize);

        var p = atlasData[ux + (uy * atlasWidth)];
        maskData[x + (y * maskWidth)] = p;
    }

    private static uint DivCeil(uint l, uint r)
    {
        return (l + r - 1) / r;
    }

    private static uint CountBits(uint v)
    {
        return (uint)System.Numerics.BitOperations.PopCount(v);
    }

    private static byte[] DownscaleNearest(byte[] src, uint srcW, uint srcH, uint dstW, uint dstH)
    {
        var dst = new byte[dstW * dstH];
        var factorX = (double)srcW / dstW;
        var factorY = (double)srcH / dstH;

        for (uint y = 0; y < dstH; y++)
        {
            var rowOffset = y * dstW;
            for (uint x = 0; x < dstW; x++)
            {
                var srcX = (uint)(x * factorX);
                var srcY = (uint)(y * factorY);

                if (srcX >= srcW)
                {
                    srcX = srcW - 1;
                }

                if (srcY >= srcH)
                {
                    srcY = srcH - 1;
                }

                dst[rowOffset + x] = src[srcX + srcY * srcW];
            }
        }
        return dst;
    }

    private static byte[] CreateWkPreviewPng(byte[] gray, int width, int height)
    {
        var imgData = new byte[width * height * 4];
        for (int i = 0; i < width * height; i++)
        {
            var v = gray[i];
            var baseIdx = i * 4;
            imgData[baseIdx + 0] = v;
            imgData[baseIdx + 1] = v;
            imgData[baseIdx + 2] = v;
            imgData[baseIdx + 3] = 255;
        }

        var info = new DDSUtils.DDSInfo
        {
            Compression = Enums.ETextureCompression.TCM_None,
            RawFormat = Enums.ETextureRawFormat.TRF_TrueColor,
            IsGamma = false,
            Width = (uint)width,
            Height = (uint)height,
            Depth = 1,
            MipCount = 1,
            SliceCount = 1,
            TextureType = Enums.GpuWrapApieTextureType.TEXTYPE_2D
        };

        var img = RedImage.Create(info, imgData);
        var png = img.SaveToPNGMemory();
        img.Dispose();
        return png;
    }

    public bool UncookMlmask(Multilayer_Mask mlmask, FileInfo outfile, MlmaskExportArgs args)
    {
        if (mlmask.RenderResourceBlob.RenderResourceBlobPC.Chunk is not rendRenderMultilayerMaskBlobPC blob)
        {
            return false;
        }

        try
        {
            uint atlasWidth = blob.Header.AtlasWidth;
            uint atlasHeight = blob.Header.AtlasHeight;
            uint maskTileSize = blob.Header.MaskTileSize;

            if (maskTileSize == 0)
            {
                _loggerService.Error("Invalid MaskTileSize: 0");
                return false;
            }

            var atlasTileSize = maskTileSize + ATLAS_TILE_PADDING;
            if (atlasWidth % atlasTileSize != 0 || atlasHeight % atlasTileSize != 0)
            {
                _loggerService.Error($"Atlas dimensions {atlasWidth}x{atlasHeight} are not divisible by (MaskTileSize+2) = {atlasTileSize}.");
                return false;
            }
        }
        catch
        {
            _loggerService.Error("Failed to validate multilayer mask header.");
            return false;
        }

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
        var layerResolutions = new List<string>();

        foreach (var layer in DecodeLayerBuffers(blob))
        {
            var (layerBuffer, outWidth, outHeight) = layer;

            var layerFileName = Path.GetFileNameWithoutExtension(outfile.FullName) + $"_{cnt++}";
            var newPath = Path.Combine(args.AsList ? subDir!.FullName : outfile.Directory!.FullName, $"{layerFileName}.{args.UncookExtension}");

            if (args.UncookExtension == EUncookExtension.png)
            {
                var preview = CreateWkPreviewPng(layerBuffer, (int)outWidth, (int)outHeight);
                File.WriteAllBytes(newPath, preview);

                if (args.AsList)
                {
                    masks.Add($"{subDir!.Name}/{layerFileName}.{args.UncookExtension}");
                }

                layerResolutions.Add($"{outWidth}x{outHeight}");
                continue;
            }

            var info = new DDSUtils.DDSInfo
            {
                Compression = Enums.ETextureCompression.TCM_None,
                RawFormat = Enums.ETextureRawFormat.TRF_Grayscale,
                IsGamma = false,
                Width = outWidth,
                Height = outHeight,
                Depth = 1,
                MipCount = 1,
                SliceCount = 1,
                TextureType = Enums.GpuWrapApieTextureType.TEXTYPE_2D
            };

            var img = RedImage.Create(info, layerBuffer);

            byte[] buffer;
            switch (args.UncookExtension)
            {
                case EUncookExtension.dds:
                    buffer = img.SaveToDDSMemory();
                    break;
                case EUncookExtension.tga:
                    buffer = img.SaveToTGAMemory();
                    break;
                case EUncookExtension.bmp:
                    buffer = img.SaveToBMPMemory();
                    break;
                case EUncookExtension.jpg:
                    buffer = img.SaveToJPEGMemory();
                    break;
                case EUncookExtension.tiff:
                    buffer = img.SaveToTIFFMemory();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(args.UncookExtension), $"Unsupported uncook extension: {args.UncookExtension}");
            }

            File.WriteAllBytes(newPath, buffer);

            if (args.AsList)
            {
                masks.Add($"{subDir!.Name}/{layerFileName}.{args.UncookExtension}");
            }

            layerResolutions.Add($"{img.Metadata.Width}x{img.Metadata.Height}");
            img.Dispose();
        }

        if (args.AsList)
        {
            var maskListPath = Path.ChangeExtension(outfile.FullName, "masklist");

            var headerLines = new List<string>
            {
                "# MLMask Export v2",
                "# Original file header values",
                $"# AtlasWidth={blob.Header.AtlasWidth}",
                $"# AtlasHeight={blob.Header.AtlasHeight}",
                $"# MaskWidth={blob.Header.MaskWidth}",
                $"# MaskHeight={blob.Header.MaskHeight}",
                $"# MaskWidthLow={blob.Header.MaskWidthLow}",
                $"# MaskHeightLow={blob.Header.MaskHeightLow}",
                $"# MaskTileSize={blob.Header.MaskTileSize}",
                $"# NumLayers={blob.Header.NumLayers}",
                "",
                $"# LayerResolutions={string.Join(",", layerResolutions)}",
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

    #endregion Methods
}
