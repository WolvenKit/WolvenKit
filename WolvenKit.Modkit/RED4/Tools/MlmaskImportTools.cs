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

            // === Parse header ===
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
                    throw new FileNotFoundException($"File not found: {f}");

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
                        throw new WolvenKitException(0x2003, $"Layer {f} is larger than target size");

                    var upscaled = UpscaleNearest(image.SaveToDDSMemory(), imgW, imgH, finalWidth, finalHeight);
                    image = RedImage.Create(new DDSUtils.DDSInfo
                    {
                        Width = finalWidth, Height = finalHeight,
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

        #region Existing Methods (Do Not Change)

        private void Write(FileInfo f)
        {
            var cr2w = new CR2WFile();
            var mask = new Multilayer_Mask { CookingPlatform = Enums.ECookingPlatform.PLATFORM_PC };
            cr2w.RootChunk = mask;

            var blob = new rendRenderMultilayerMaskBlobPC
            {
                Header = new rendRenderMultilayerMaskBlobHeader
                {
                    Version = 3,
                    AtlasWidth = _mlmask.AtlasWidth,
                    AtlasHeight = _mlmask.AtlasHeight,
                    NumLayers = (uint)_mlmask.Layers.Length,
                    MaskWidth = _mlmask.WidthHigh,
                    MaskHeight = _mlmask.HeightHigh,
                    MaskWidthLow = _mlmask.WidthLow,
                    MaskHeightLow = _mlmask.HeightLow,
                    MaskTileSize = _mlmask.TileSize,
                    Flags = 2
                },
                AtlasData = new SerializationDeferredDataBuffer(_mlmask.AtlasBuffer),
                TilesData = new SerializationDeferredDataBuffer(_mlmask.TilesBuffer)
            };

            mask.RenderResourceBlob.RenderResourceBlobPC = blob;

            var dir = f.Directory.NotNull();
            if (!Directory.Exists(dir.FullName)) Directory.CreateDirectory(dir.FullName);

            using var fs = new FileStream(f.FullName, FileMode.Create, FileAccess.Write);
            using var writer = new CR2WWriter(fs) { LoggerService = _logger };
            writer.WriteFile(cr2w);
        }

        private void PutTiles(ref List<uint> tilesDataList, MaskTile[] tileZ, uint basisTileIdx, uint widthInTiles0, uint heightInTiles0)
        {
            var atlasTileSize = _mlmask.AtlasWidth / _mlmask.AtlasTileSize;
            var widthInTilesShift0 = (uint)Math.Log2(atlasTileSize);
            var widthInTilesGrayUp = (1u << (int)widthInTilesShift0) - 1;

            for (uint ty = 0; ty < heightInTiles0; ty++)
            {
                for (uint tx = 0; tx < widthInTiles0; tx++)
                {
                    var tileIdx = tx + (ty * widthInTiles0);
                    var layersBeg = (uint)tilesDataList.Count;
                    var numLayers = (uint)tileZ[tileIdx].Layers.Count;

                    tilesDataList[(int)((basisTileIdx + tileIdx) * 2 + 0)] = layersBeg;

                    uint layersMask = 0;
                    for (var i = 0; i < numLayers; i++)
                    {
                        var layerIdx = tileZ[tileIdx].Layers[i].LayerIndex;
                        var position = tileZ[tileIdx].Layers[i].AtlasInPosition;
                        var atlasX = position & widthInTilesGrayUp;
                        var atlasY = (uint)((int)position >> (int)widthInTilesShift0);
                        var widthShift = _mlmask.Layers[layerIdx].WidthShift;
                        var heightShift = _mlmask.Layers[layerIdx].HeightShift;

                        uint puts = 0;
                        puts |= atlasX;
                        puts |= atlasY << 10;
                        puts |= widthShift << 20;
                        puts |= heightShift << 24;

                        tilesDataList.Add(puts);
                        layersMask |= 1u << (int)layerIdx;
                    }
                    tilesDataList[(int)((basisTileIdx + tileIdx) * 2 + 1)] = layersMask;
                }
            }
        }

        private void InitializeMaskLayers()
        {
            if (_mlmask.Layers == null) return;

            for (uint i = 0; i < _mlmask.Layers.Length; i++)
            {
                _mlmask.Layers[i].WidthInTiles0 = (_mlmask.Layers[i].Width + (_mlmask.TileSize - 1)) / _mlmask.TileSize;
                _mlmask.Layers[i].HeightInTiles0 = (_mlmask.Layers[i].Height + (_mlmask.TileSize - 1)) / _mlmask.TileSize;
                _mlmask.Layers[i].Tiles = new List<Tile>();

                for (uint y = 0; y < _mlmask.Layers[i].HeightInTiles0; y++)
                {
                    for (uint x = 0; x < _mlmask.Layers[i].WidthInTiles0; x++)
                    {
                        var tile = new Tile
                        {
                            AtlasInPosition = uint.MaxValue,
                            AtlasUnCompressed = new byte[_mlmask.AtlasTileSize * _mlmask.AtlasTileSize]
                        };

                        if (i == 0)
                        {
                            tile.RangeMin = 255;
                            tile.RangeMax = 255;
                            Array.Fill(tile.AtlasUnCompressed, (byte)255);
                        }
                        else
                        {
                            tile.RangeMin = 255;
                            tile.RangeMax = 0;
                            for (uint yy = 0; yy < _mlmask.AtlasTileSize; yy++)
                            {
                                for (uint xx = 0; xx < _mlmask.AtlasTileSize; xx++)
                                {
                                    var v = GetPixelFromLayer(i, x, y, (int)xx - 1, (int)yy - 1);
                                    tile.AtlasUnCompressed[xx + (yy * _mlmask.AtlasTileSize)] = v;
                                    tile.RangeMin = Math.Min(tile.RangeMin, v);
                                    tile.RangeMax = Math.Max(tile.RangeMax, v);
                                }
                            }
                        }
                        _mlmask.Layers[i].Tiles.Add(tile);
                    }
                }
            }
        }

        private byte GetPixelFromLayer(uint layerIdx, uint tx, uint ty, int x, int y)
        {
            if (layerIdx == 0) return 255;

            var xx = (int)(tx * _mlmask.TileSize) + x;
            var yy = (int)(ty * _mlmask.TileSize) + y;
            xx = Math.Clamp(xx, 0, (int)_mlmask.Layers[layerIdx].Width - 1);
            yy = Math.Clamp(yy, 0, (int)_mlmask.Layers[layerIdx].Height - 1);
            return _mlmask.Layers[layerIdx].Pixels[xx + (yy * (int)_mlmask.Layers[layerIdx].Width)];
        }

        private void Create()
        {
            if (_mlmask.Layers == null) return;

            _mlmask.WidthHigh = 0;
            _mlmask.HeightHigh = 0;
            _mlmask.WidthLow = uint.MaxValue;
            _mlmask.HeightLow = uint.MaxValue;

            foreach (var lay in _mlmask.Layers)
            {
                _mlmask.WidthLow = Math.Min(_mlmask.WidthLow, lay.Width);
                _mlmask.HeightLow = Math.Min(_mlmask.HeightLow, lay.Height);
                _mlmask.WidthHigh = Math.Max(_mlmask.WidthHigh, lay.Width);
                _mlmask.HeightHigh = Math.Max(_mlmask.HeightHigh, lay.Height);
            }

            for (var i = 0; i < _mlmask.Layers.Length; i++)
            {
                _mlmask.Layers[i].WidthShift = (uint)Math.Ceiling(Math.Log2(_mlmask.WidthHigh / (double)_mlmask.Layers[i].Width));
                _mlmask.Layers[i].HeightShift = (uint)Math.Ceiling(Math.Log2(_mlmask.HeightHigh / (double)_mlmask.Layers[i].Height));
            }

            uint tempAtlasTileSize = 16;
            while (true)
            {
                _mlmask.AtlasTileSize = tempAtlasTileSize;
                _mlmask.TileSize = _mlmask.AtlasTileSize - 2;
                tempAtlasTileSize += 16;

                _mlmask.MaskTilesHigh = null;
                _mlmask.MaskTilesLow = null;
                _mlmask.AtlasTiles.Clear();
                _mlmask.AtlasWidth = 0;
                _mlmask.AtlasHeight = 0;
                _mlmask.AtlasTilesCount = 0;

                InitializeMaskLayers();

                _mlmask.WidthInTilesHigh = (_mlmask.WidthHigh + (_mlmask.TileSize - 1)) / _mlmask.TileSize;
                _mlmask.HeightInTilesHigh = (_mlmask.HeightHigh + (_mlmask.TileSize - 1)) / _mlmask.TileSize;
                _mlmask.WidthInTilesLow = (_mlmask.WidthLow + (_mlmask.TileSize - 1)) / _mlmask.TileSize;
                _mlmask.HeightInTilesLow = (_mlmask.HeightLow + (_mlmask.TileSize - 1)) / _mlmask.TileSize;

                _mlmask.MaskTilesHigh = new MaskTile[_mlmask.WidthInTilesHigh * _mlmask.HeightInTilesHigh];
                for (uint i = 0; i < _mlmask.MaskTilesHigh.Length; i++)
                    _mlmask.MaskTilesHigh[i].Layers = new List<TileView>();

                _mlmask.MaskTilesLow = new MaskTile[_mlmask.WidthInTilesLow * _mlmask.HeightInTilesLow];
                for (uint i = 0; i < _mlmask.MaskTilesLow.Length; i++)
                    _mlmask.MaskTilesLow[i].Layers = new List<TileView>();

                CleanTileLayers();

                if (_mlmask.AtlasTiles.Count <= 0x20000) break;
            }

            CalculateAtlasProportionForPacking();
            CreateAtlasBuffer();

            var numTilesHigh = _mlmask.WidthInTilesHigh * _mlmask.HeightInTilesHigh;
            var numTilesLow = _mlmask.WidthInTilesLow * _mlmask.HeightInTilesLow;
            var tilesDataList = new List<uint>();

            for (uint i = 0; i < (numTilesHigh + numTilesLow) * 2; i++)
                tilesDataList.Add(0U);

            PutTiles(ref tilesDataList, _mlmask.MaskTilesHigh, 0, _mlmask.WidthInTilesHigh, _mlmask.HeightInTilesHigh);
            PutTiles(ref tilesDataList, _mlmask.MaskTilesLow, numTilesHigh, _mlmask.WidthInTilesLow, _mlmask.HeightInTilesLow);

            using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);
            foreach (var l in tilesDataList) bw.Write(l);
            _mlmask.TilesBuffer = ms.ToArray();
        }

        private void CleanTileLayers()
        {
            if (_mlmask.Layers == null || _mlmask.MaskTilesHigh == null || _mlmask.MaskTilesLow == null) return;

            for (uint I = 0; I < _mlmask.Layers.Length; I++)
            {
                if (_mlmask.Layers[I].Width < _mlmask.WidthHigh)
                {
                    for (uint y = 0; y < _mlmask.HeightInTilesLow; y++)
                    {
                        for (uint x = 0; x < _mlmask.WidthInTilesLow; x++)
                        {
                            var tx = x * _mlmask.Layers[I].Width / _mlmask.WidthLow;
                            var ty = y * _mlmask.Layers[I].Height / _mlmask.HeightLow;

                            if (_mlmask.Layers[I].Tiles[(int)(tx + (ty * _mlmask.Layers[I].WidthInTiles0))].RangeMax > 0)
                            {
                                var layer = new TileView
                                {
                                    LayerIndex = I,
                                    LayerTileIndex = tx + (ty * _mlmask.Layers[I].WidthInTiles0),
                                    AtlasInPosition = PackTileInAtlas(I, tx, ty)
                                };
                                _mlmask.MaskTilesLow[x + (y * _mlmask.WidthInTilesLow)].Layers.Add(layer);
                            }
                        }
                    }
                }
                else
                {
                    for (uint y = 0; y < _mlmask.HeightInTilesHigh; y++)
                    {
                        for (uint x = 0; x < _mlmask.WidthInTilesHigh; x++)
                        {
                            var tx = x * _mlmask.Layers[I].Width / _mlmask.WidthHigh;
                            var ty = y * _mlmask.Layers[I].Height / _mlmask.HeightHigh;

                            if (_mlmask.Layers[I].Tiles[(int)(tx + (ty * _mlmask.Layers[I].WidthInTiles0))].RangeMax > 0)
                            {
                                var layer = new TileView
                                {
                                    LayerIndex = I,
                                    LayerTileIndex = tx + (ty * _mlmask.Layers[I].WidthInTiles0),
                                    AtlasInPosition = PackTileInAtlas(I, tx, ty)
                                };
                                _mlmask.MaskTilesHigh[x + (y * _mlmask.WidthInTilesHigh)].Layers.Add(layer);
                            }
                        }
                    }
                }
            }
        }

        private uint PackTileInAtlas(uint layerIdx, uint tx, uint ty)
        {
            if (_mlmask.Layers == null) return 0;

            var tileIndex = tx + (ty * _mlmask.Layers[layerIdx].WidthInTiles0);

            if (_mlmask.Layers[layerIdx].Tiles[(int)tileIndex].AtlasInPosition == uint.MaxValue)
            {
                BlockCompressLocalTile(ref _mlmask.Layers[layerIdx], tileIndex);

                var recursiveHash = FNV1A.FnvHashInitial;
                for (uint y = 0; y < _mlmask.AtlasTileSize / 4; y++)
                {
                    for (uint x = 0; x < _mlmask.AtlasTileSize / 4; x++)
                    {
                        var compressedBlock = _mlmask.Layers[layerIdx].Tiles[(int)tileIndex].AtlasBlockCompressed[x + (y * _mlmask.AtlasTileSize / 4)];
                        var color32 = new float[16];
                        D3DX.D3DXDecodeBC4U(ref color32, compressedBlock);
                        var color8 = new byte[16];
                        for (uint i = 0; i < 16; i++) color8[i] = (byte)(color32[i] * 255.0f);
                        recursiveHash = FNV1A.HashReadOnlySpan(color8, recursiveHash);
                    }
                }

                if (!_mlmask.AtlasTiles.TryGetValue(recursiveHash, out var atlasView))
                {
                    atlasView = new TileView
                    {
                        AtlasInPosition = _mlmask.AtlasTilesCount++,
                        LayerIndex = layerIdx,
                        LayerTileIndex = tileIndex
                    };
                    _mlmask.AtlasTiles.Add(recursiveHash, atlasView);
                }

                var z = _mlmask.Layers[layerIdx].Tiles[(int)tileIndex];
                z.AtlasInPosition = atlasView.AtlasInPosition;
                _mlmask.Layers[layerIdx].Tiles[(int)tileIndex] = z;
            }
            return _mlmask.Layers[layerIdx].Tiles[(int)tileIndex].AtlasInPosition;
        }

        private void CalculateAtlasProportionForPacking()
        {
            _mlmask.AtlasWidth = 0;
            _mlmask.AtlasHeight = 0;

            uint widthTry = 16384;
            var emptyArea = uint.MaxValue;

            while (widthTry >= _mlmask.AtlasTileSize)
            {
                var widthInTiles0 = widthTry / _mlmask.AtlasTileSize;
                var heightTry = (_mlmask.AtlasTilesCount + widthInTiles0 - 1) / widthInTiles0 * _mlmask.AtlasTileSize;

                var widthUp = RoundUpPowerOf2(widthTry);
                var heightUp = RoundUpPowerOf2(heightTry);

                var currEmptyArea = (widthUp * heightUp) - (_mlmask.AtlasTilesCount * _mlmask.AtlasTileSize * _mlmask.AtlasTileSize);
                if (currEmptyArea <= emptyArea)
                {
                    _mlmask.AtlasWidth = widthTry;
                    _mlmask.AtlasHeight = heightTry;
                    emptyArea = currEmptyArea;
                }

                if (widthTry <= heightTry) break;
                widthTry /= 2;
            }

            if (_mlmask.AtlasWidth > 16384 || _mlmask.AtlasHeight > 16384)
                throw new Exception("Atlas too large (over 16k)");
        }

        private void CreateAtlasBuffer()
        {
            if (_mlmask.Layers == null || _mlmask.AtlasWidth <= 0 || _mlmask.AtlasHeight <= 0)
                throw new Exception("Unable to generate MLmask atlas data");

            var tileSizeInBlocks0 = _mlmask.AtlasTileSize / 4;
            var widthInBlocks0 = _mlmask.AtlasWidth / 4;
            var heightInBlocks0 = _mlmask.AtlasHeight / 4;
            var widthInTiles0 = _mlmask.AtlasWidth / _mlmask.AtlasTileSize;

            var data = new ulong[widthInBlocks0 * heightInBlocks0];

            foreach (var atlasTile in _mlmask.AtlasTiles.Values)
            {
                var sourceLayer = _mlmask.Layers[atlasTile.LayerIndex];
                var tileSource = sourceLayer.Tiles[(int)atlasTile.LayerTileIndex];

                var position = atlasTile.AtlasInPosition;
                var tx = position % widthInTiles0;
                var ty = position / widthInTiles0;
                var bx = tx * tileSizeInBlocks0;
                var by = ty * tileSizeInBlocks0;

                var destinationIdx = bx + (by * widthInBlocks0);
                for (uint i = 0; i < tileSizeInBlocks0; i++)
                {
                    Array.Copy(tileSource.AtlasBlockCompressed, i * tileSizeInBlocks0, data, destinationIdx, tileSizeInBlocks0);
                    destinationIdx += widthInBlocks0;
                }
            }

            using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);
            foreach (var d in data) bw.Write(d);
            _mlmask.AtlasBuffer = ms.ToArray();
        }

        private void BlockCompressLocalTile(ref RawTexContainer layer, uint tileIdx)
        {
            var tileSizeInBlocks0 = _mlmask.AtlasTileSize / 4;
            var tx = tileIdx % layer.WidthInTiles0;
            var ty = tileIdx / layer.WidthInTiles0;

            var layerTile = layer.Tiles[(int)tileIdx];
            layerTile.AtlasBlockCompressed = new ulong[tileSizeInBlocks0 * tileSizeInBlocks0];

            for (uint yBlock = 0; yBlock < tileSizeInBlocks0; yBlock++)
            {
                for (uint xBlock = 0; xBlock < tileSizeInBlocks0; xBlock++)
                {
                    var referenceData = new List<float>();
                    var toBBCValues = new float[16];

                    for (uint j = 0; j < 4; j++)
                    {
                        for (uint i = 0; i < 4; i++)
                        {
                            var px = (xBlock * 4) + i;
                            var py = (yBlock * 4) + j;
                            var v = layerTile.AtlasUnCompressed[px + (py * _mlmask.AtlasTileSize)] / 255.0f;
                            toBBCValues[i + (j * 4)] = v;
                            referenceData.Add(v);
                        }
                    }

                    // Neighbor padding for better BC4 quality
                    if (tx > 0 && xBlock == 0) PushBlockReferenceData(ref referenceData, layer, tx - 1, ty, tileSizeInBlocks0 - 1, yBlock);
                    else if (tx < layer.WidthInTiles0 - 1 && xBlock == tileSizeInBlocks0 - 1) PushBlockReferenceData(ref referenceData, layer, tx + 1, ty, 0, yBlock);

                    if (ty > 0 && yBlock == 0) PushBlockReferenceData(ref referenceData, layer, tx, ty - 1, xBlock, tileSizeInBlocks0 - 1);
                    else if (ty < layer.HeightInTiles0 - 1 && yBlock == tileSizeInBlocks0 - 1) PushBlockReferenceData(ref referenceData, layer, tx, ty + 1, xBlock, 0);

                    ulong blockCompressed = 0;
                    D3DX.D3DXEncodeBC4U(ref blockCompressed, toBBCValues, referenceData);
                    layerTile.AtlasBlockCompressed[xBlock + (yBlock * tileSizeInBlocks0)] = blockCompressed;
                }
            }
            layer.Tiles[(int)tileIdx] = layerTile;
        }

        private void PushBlockReferenceData(ref List<float> referenceData, RawTexContainer layer, uint tx, uint ty, uint xBlock, uint yBlock)
        {
            for (uint j = 0; j < 4; j++)
            {
                for (uint i = 0; i < 4; i++)
                {
                    var px = (xBlock * 4) + i;
                    var py = (yBlock * 4) + j;
                    var v = layer.Tiles[(int)(tx + (ty * layer.WidthInTiles0))].AtlasUnCompressed[px + (py * _mlmask.AtlasTileSize)] / 255.0f;
                    referenceData.Add(v);
                }
            }
        }

        private static uint RoundUpPowerOf2(uint v)
        {
            v--; v |= v >> 1; v |= v >> 2; v |= v >> 4; v |= v >> 8; v |= v >> 16;
            return ++v;
        }

        #endregion

        #region Structs & Helpers

        public struct RawTexContainer
        {
            public byte[] Pixels;
            public uint Width;
            public uint Height;
            public List<Tile> Tiles;
            public uint WidthShift;
            public uint HeightShift;
            public uint WidthInTiles0;
            public uint HeightInTiles0;
        }

        public struct Tile
        {
            public byte RangeMin;
            public byte RangeMax;
            public byte[] AtlasUnCompressed;
            public ulong[] AtlasBlockCompressed;
            public uint AtlasInPosition;
        }

        public struct MaskTile
        {
            public List<TileView> Layers;
        }

        public struct TileView
        {
            public uint LayerIndex;
            public uint AtlasInPosition;
            public uint LayerTileIndex;
        }

        public class MlMaskContainer
        {
            public RawTexContainer[]? Layers;
            public MaskTile[]? MaskTilesHigh;
            public Dictionary<ulong, TileView> AtlasTiles = new();
            public MaskTile[]? MaskTilesLow;
            public uint AtlasTileSize;
            public uint AtlasWidth;
            public uint AtlasHeight;
            public uint HeightHigh;
            public uint WidthLow;
            public uint HeightInTilesHigh;
            public uint WidthInTilesLow;
            public uint HeightLow;
            public byte[]? AtlasBuffer;
            public byte[]? TilesBuffer;
            public uint WidthInTilesHigh;
            public uint HeightInTilesLow;
            public uint TileSize;
            public uint WidthHigh;
            public uint AtlasTilesCount;
        }

        #endregion

        #region FNV1A & D3DX (Keep as is)

        internal class FNV1A
        {
            public const ulong FnvHashInitial = 0xCBF29CE484222325;
            public const ulong FnvHashPrime = 0x00000100000001B3;
            public static ulong HashReadOnlySpan(ReadOnlySpan<byte> source, ulong hash = FnvHashInitial)
            {
                foreach (var b in source)
                    unchecked { hash = (hash ^ b) * FnvHashPrime; }
                return hash;
            }
        }

        internal class D3DX { /* Keep your full D3DX class exactly as it was in the original file */ }

        #endregion
    }
}
