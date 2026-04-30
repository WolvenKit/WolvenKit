using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
using WolvenKit.Common.Exceptions;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4.MLMask
{
    public class MLMASK
    {
        private const uint s_headerLength = 148;
        private MlMaskContainer _mlmask;
        private readonly ILoggerService _logger;

        public MLMASK(MlMaskContainer mlMask, ILoggerService logger)
        {
            _mlmask = mlMask;
            _logger = logger;
        }

        public void Import(FileInfo txtImageList, FileInfo outFile)
        {
            var lines = File.ReadAllLines(txtImageList.FullName);
            var baseDir = txtImageList.Directory.NotNull();

            // Parse header
            uint targetMaskWidth = 0;
            uint targetMaskHeight = 0;
            uint targetAtlasWidth = 0;
            uint targetAtlasHeight = 0;
            uint targetTileSize = 16;
            bool preserveNative = true;

            var filePaths = new List<string>();

            foreach (var line in lines)
            {
                var trimmed = line.Trim();
                if (string.IsNullOrWhiteSpace(trimmed)) continue;

                if (trimmed.StartsWith("#"))
                {
                    if (trimmed.Contains("AtlasWidth=")) targetAtlasWidth = ParseHeaderValue(trimmed);
                    else if (trimmed.Contains("AtlasHeight=")) targetAtlasHeight = ParseHeaderValue(trimmed);
                    else if (trimmed.Contains("MaskWidth=")) targetMaskWidth = ParseHeaderValue(trimmed);
                    else if (trimmed.Contains("MaskHeight=")) targetMaskHeight = ParseHeaderValue(trimmed);
                    else if (trimmed.Contains("MaskTileSize=")) targetTileSize = ParseHeaderValue(trimmed);
                    else if (trimmed.Contains("PreserveNativeResolutions="))
                        preserveNative = bool.Parse(trimmed.Split('=')[1].Trim());
                    continue;
                }
                filePaths.Add(trimmed);
            }

            var files = filePaths.Select(x => Path.Combine(baseDir.FullName, x)).ToList();

            #region Init and Verify

            _mlmask = new MlMaskContainer();
            var textures = new List<RawTexContainer>();

            var firstLayerName = Path.GetFileNameWithoutExtension(files[0]);
            if (!firstLayerName.EndsWith("_0"))
            {
                var white = new RawTexContainer { Pixels = new byte[16], Width = 4, Height = 4 };
                Array.Fill(white.Pixels, (byte)255);
                textures.Add(white);
            }

            uint finalWidth = targetMaskWidth;
            uint finalHeight = targetMaskHeight;

            foreach (var f in files)
            {
                if (!File.Exists(f))
                    throw new FileNotFoundException($"Line: \"{f}\" - file not found");

                RedImage? image = null;
                try { image = RedImage.LoadFromFile(f); }
                catch (WolvenKitException e)
                {
                    throw new WolvenKitException(0x2001, $"{e.Message} (must be grayscale)");
                }

                if (image == null) { _logger.Error($"Could not load: {f}"); continue; }

                if (image.Metadata.Format != DXGI_FORMAT.DXGI_FORMAT_R8_UNORM)
                    image.Convert(DXGI_FORMAT.DXGI_FORMAT_R8_UNORM);

                uint imgW = (uint)image.Metadata.Width;
                uint imgH = (uint)image.Metadata.Height;

                // Auto-upscale smaller layers
                if (finalWidth > 0 && finalHeight > 0 && (imgW != finalWidth || imgH != finalHeight))
                {
                    if (imgW > finalWidth || imgH > finalHeight)
                        throw new WolvenKitException(0x2003, $"Layer {f} is larger than target {finalWidth}x{finalHeight}");

                    var upscaled = UpscaleNearest(image.SaveToDDSMemory(), imgW, imgH, finalWidth, finalHeight);
                    image = RedImage.Create(new DDSUtils.DDSInfo
                    {
                        Width = finalWidth,
                        Height = finalHeight,
                        RawFormat = Enums.ETextureRawFormat.TRF_Grayscale
                    }, upscaled);

                    _logger.Info($"Upscaled {Path.GetFileName(f)}: {imgW}x{imgH} → {finalWidth}x{finalHeight}");
                }

                if (finalWidth == 0) { finalWidth = imgW; finalHeight = imgH; }

                using var ms = new MemoryStream(image.SaveToDDSMemory());
                using var br = new BinaryReader(ms);
                ms.Seek(s_headerLength, SeekOrigin.Begin);
                var bytes = br.ReadBytes((int)(finalWidth * finalHeight));

                textures.Add(new RawTexContainer { Width = finalWidth, Height = finalHeight, Pixels = bytes });
            }

            _mlmask.Layers = textures.ToArray();

            #endregion

            Create();
            Write(outFile);
        }

        private static uint ParseHeaderValue(string line)
        {
            var parts = line.Split('=');
            return parts.Length > 1 ? uint.Parse(parts[1].Trim()) : 0;
        }

        private static byte[] UpscaleNearest(byte[] src, uint srcW, uint srcH, uint dstW, uint dstH)
        {
            var dst = new byte[dstW * dstH];
            var scaleX = (double)srcW / dstW;
            var scaleY = (double)srcH / dstH;

            for (uint y = 0; y < dstH; y++)
                for (uint x = 0; x < dstW; x++)
                {
                    var srcX = (uint)(x * scaleX);
                    var srcY = (uint)(y * scaleY);
                    dst[x + y * dstW] = src[srcX + srcY * srcW];
                }
            return dst;
        }

        // === Keep all your existing methods below (Create, Write, PutTiles, InitializeMaskLayers, etc.) ===

        private void Write(FileInfo f) { /* your existing code */ }
        private void PutTiles(ref List<uint> tilesDataList, MaskTile[] tileZ, uint basisTileIdx, uint widthInTiles0, uint heightInTiles0) { /* your existing code */ }
        private void InitializeMaskLayers() { /* your existing code */ }
        private byte GetPixelFromLayer(uint layerIdx, uint tx, uint ty, int x, int y) { /* your existing code */ }
        private void Create() { /* your existing code */ }
        private void CleanTileLayers() { /* your existing code */ }
        private uint PackTileInAtlas(uint layerIdx, uint tx, uint ty) { /* your existing code */ }
        private void CalculateAtlasProportionForPacking() { /* your existing code */ }
        private void CreateAtlasBuffer() { /* your existing code */ }
        private void BlockCompressLocalTile(ref RawTexContainer layer, uint tileIdx) { /* your existing code */ }
        private void PushBlockReferenceData(ref List<float> referenceData, RawTexContainer layer, uint tx, uint ty, uint xBlock, uint yBlock) { /* your existing code */ }
        private static uint RoundUpPowerOf2(uint v) { /* your existing code */ }

        // Keep all structs (RawTexContainer, Tile, MaskTile, TileView, MlMaskContainer) and FNV1A + D3DX classes
    }
}
