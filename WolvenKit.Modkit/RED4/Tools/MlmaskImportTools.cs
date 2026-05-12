using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using WolvenKit.Common;
using WolvenKit.Common.DDS;
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

        /// <summary>
        /// Импорт .masklist → .mlmask
        /// Поддерживает как разные разрешения слоёв, так и одинаковые.
        /// .masklist теперь содержит только пути к файлам (без заголовка).
        /// </summary>
        public void Import(FileInfo txtImageList, FileInfo outFile)
        {
            var lines = File.ReadAllLines(txtImageList.FullName);
            var baseDir = txtImageList.Directory.NotNull();

            var filePaths = new List<string>();

            foreach (var line in lines)
            {
                var trimmed = line.Trim();
                if (string.IsNullOrWhiteSpace(trimmed) || trimmed.StartsWith("#"))
                    continue;
                if (trimmed.Contains("=")) continue; // совместимость со старыми файлами

                filePaths.Add(trimmed);
            }

            if (filePaths.Count == 0)
                throw new WolvenKitException(0x2002, "No layer files specified in masklist.");

            var files = filePaths.Select(x => Path.Combine(baseDir.FullName, x)).ToList();

            _mlmask = new MlMaskContainer
            {
                PreferredTileSize = 16,
                PreferredAtlasWidth = 0,
                PreferredAtlasHeight = 0
            };

            var textures = new List<RawTexContainer>();

            // Добавляем белый слой 0 (если первый слой не заканчивается на _0)
            var firstLayerName = Path.GetFileNameWithoutExtension(files[0]);
            var needsLayer0 = !firstLayerName.EndsWith("_0") && !firstLayerName.Equals("0");

            if (needsLayer0)
            {
                uint whiteW = 1024u;
                uint whiteH = 1024u;

                if (files.Count > 0 && File.Exists(files[0]))
                {
                    try
                    {
                        using var probe = RedImage.LoadFromFile(files[0]);
                        if (probe != null)
                        {
                            whiteW = (uint)probe.Metadata.Width;
                            whiteH = (uint)probe.Metadata.Height;
                        }
                    }
                    catch { }
                }

                var whitePixels = new byte[whiteW * whiteH];
                Array.Fill(whitePixels, (byte)255);
                textures.Add(new RawTexContainer { Width = whiteW, Height = whiteH, Pixels = whitePixels });
                _logger.Info($"Added white layer 0 at {whiteW}x{whiteH}");
            }

            // Загружаем все слои из файлов
            foreach (var f in files)
            {
                if (!File.Exists(f))
                    throw new FileNotFoundException($"File not found: {f}");

                try
                {
                    using var image = RedImage.LoadFromFile(f) ?? throw new WolvenKitException(0x2001, $"Could not load image: {f}");

                    if (image.Metadata.Format != DXGI_FORMAT.DXGI_FORMAT_R8_UNORM)
                        image.Convert(DXGI_FORMAT.DXGI_FORMAT_R8_UNORM);

                    uint imgW = (uint)image.Metadata.Width;
                    uint imgH = (uint)image.Metadata.Height;

                    using var ms = new MemoryStream(image.SaveToDDSMemory());
                    using var br = new BinaryReader(ms);
                    ms.Seek(s_headerLength, SeekOrigin.Begin);
                    var pixels = br.ReadBytes((int)(imgW * imgH));

                    textures.Add(new RawTexContainer { Width = imgW, Height = imgH, Pixels = pixels });
                }
                catch (WolvenKitException e)
                {
                    throw new WolvenKitException(0x2001, $"{e.Message} (must be grayscale R8)");
                }
            }

            _mlmask.Layers = textures.ToArray();

            Create();
            Write(outFile);

            _logger.Info("MLMask import completed successfully.");
        }

        internal static bool IsBlankLayer(byte[] pixels)
        {
            if (pixels == null || pixels.Length == 0) return true;
            var first = pixels[0];
            for (int i = 1; i < pixels.Length; i++)
                if (pixels[i] != first) return false;
            return true;
        }

        #region Core Methods

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
                    NumLayers = (uint)_mlmask.Layers!.Length,
                    MaskWidth = _mlmask.WidthHigh,
                    MaskHeight = _mlmask.HeightHigh,
                    MaskWidthLow = _mlmask.WidthLow,
                    MaskHeightLow = _mlmask.HeightLow,
                    MaskTileSize = _mlmask.TileSize,
                    Flags = 2
                },
                AtlasData = new SerializationDeferredDataBuffer(_mlmask.AtlasBuffer!),
                TilesData = new SerializationDeferredDataBuffer(_mlmask.TilesBuffer!)
            };

            mask.RenderResourceBlob.RenderResourceBlobPC = blob;

            var dir = f.Directory ?? throw new InvalidOperationException("File directory is null");
            if (!Directory.Exists(dir.FullName)) Directory.CreateDirectory(dir.FullName);

            using var fs = new FileStream(f.FullName, FileMode.Create, FileAccess.Write);
            using var writer = new CR2WWriter(fs) { LoggerService = _logger };
            writer.WriteFile(cr2w);
        }

        private void Create()
        {
            if (_mlmask.Layers == null || _mlmask.Layers.Length == 0) return;

            // High resolution
            _mlmask.WidthHigh = 0;
            _mlmask.HeightHigh = 0;
            foreach (var lay in _mlmask.Layers)
            {
                _mlmask.WidthHigh = Math.Max(_mlmask.WidthHigh, lay.Width);
                _mlmask.HeightHigh = Math.Max(_mlmask.HeightHigh, lay.Height);
            }

            // Low resolution
            _mlmask.WidthLow = _mlmask.WidthHigh;
            _mlmask.HeightLow = _mlmask.HeightHigh;

            bool hasDifferentResolutions = false;
            foreach (var lay in _mlmask.Layers)
            {
                if (lay.Width < _mlmask.WidthHigh || lay.Height < _mlmask.HeightHigh)
                {
                    hasDifferentResolutions = true;
                    _mlmask.WidthLow = Math.Min(_mlmask.WidthLow, lay.Width);
                    _mlmask.HeightLow = Math.Min(_mlmask.HeightLow, lay.Height);
                }
            }

            if (!hasDifferentResolutions)
            {
                _mlmask.WidthLow = _mlmask.WidthHigh;
                _mlmask.HeightLow = _mlmask.HeightHigh;
            }

            // Shifts
            for (var i = 0; i < _mlmask.Layers.Length; i++)
            {
                _mlmask.Layers[i].WidthShift = (uint)Math.Ceiling(Math.Log2(_mlmask.WidthHigh / (double)_mlmask.Layers[i].Width));
                _mlmask.Layers[i].HeightShift = (uint)Math.Ceiling(Math.Log2(_mlmask.HeightHigh / (double)_mlmask.Layers[i].Height));
            }

            // AtlasTileSize must be divisible by 4 (we split it into 4x4 BC4 blocks for compression).
            // Start at 16 (standard when maskTileSize=14) and increase by 4 to maintain divisibility.
            uint tempAtlasTileSize = 16u;
            while (true)
            {
                _mlmask.AtlasTileSize = tempAtlasTileSize;
                _mlmask.TileSize = _mlmask.AtlasTileSize - 2;

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

                tempAtlasTileSize += 4;   // keep the value divisible by 4
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

        private void CalculateAtlasProportionForPacking()
        {
            if (_mlmask.AtlasTilesCount == 0)
                throw new Exception("No tiles to pack into atlas.");

            uint tileSize = _mlmask.AtlasTileSize;
            uint tileCount = _mlmask.AtlasTilesCount;

            // The atlas size is independent of maskWidth/maskHeight.
            // It only needs to hold all *unique* compressed tiles (after hash deduplication).
            // Real game files often have atlas much smaller than mask resolution when content has repetition/empty areas.

            uint bestWidth = 0;
            uint bestHeight = 0;
            ulong bestWaste = ulong.MaxValue;

            // Start near square root for good aspect ratio
            uint startWidthInTiles = Math.Max(1u, (uint)Math.Ceiling(Math.Sqrt(tileCount)));

            // Try widths around the square root (good for most cases)
            for (uint wTiles = startWidthInTiles; wTiles <= startWidthInTiles + 48 && wTiles <= 512; wTiles++)
            {
                if (wTiles == 0) continue;

                uint hTiles = (tileCount + wTiles - 1) / wTiles; // ceil division
                uint w = wTiles * tileSize;
                uint h = hTiles * tileSize;

                if (w > 16384 || h > 16384) continue;

                ulong area = (ulong)w * h;
                ulong usedArea = (ulong)tileCount * tileSize * tileSize;
                ulong waste = area - usedArea;

                if (waste < bestWaste || bestWidth == 0)
                {
                    bestWaste = waste;
                    bestWidth = w;
                    bestHeight = h;
                }
            }

            // Also try a few power-of-two widths for potentially better cache/GPU behavior
            uint[] pow2Candidates = { 256, 512, 1024, 2048, 4096 };
            foreach (uint pw in pow2Candidates)
            {
                if (pw < tileSize) continue;
                uint pwTiles = pw / tileSize;
                uint phTiles = (tileCount + pwTiles - 1) / pwTiles;
                uint ph = phTiles * tileSize;

                if (ph > 16384) continue;

                ulong pWaste = (ulong)pw * ph - (ulong)tileCount * tileSize * tileSize;
                if (pWaste < bestWaste)
                {
                    bestWaste = pWaste;
                    bestWidth = pw;
                    bestHeight = ph;
                }
            }

            // Final fallback: simple horizontal strip (rarely needed)
            if (bestWidth == 0)
            {
                uint wTiles = Math.Min(128u, tileCount);
                if (wTiles == 0) wTiles = 1;
                uint hTiles = (tileCount + wTiles - 1) / wTiles;
                bestWidth = wTiles * tileSize;
                bestHeight = hTiles * tileSize;
            }

            _mlmask.AtlasWidth = bestWidth;
            _mlmask.AtlasHeight = bestHeight;

            if (_mlmask.AtlasWidth > 16384 || _mlmask.AtlasHeight > 16384)
                throw new Exception("Atlas too large (over 16k)");

            // Ensure the number of tiles horizontally is a power of 2 (required by PutTiles bit-packing).
            uint tilesX = _mlmask.AtlasWidth / tileSize;
            if (tilesX > 0 && (tilesX & (tilesX - 1)) != 0)
            {
                uint nextPow2 = 1u;
                while (nextPow2 < tilesX) nextPow2 <<= 1;

                uint newWidth = nextPow2 * tileSize;
                uint newHeight = ((tileCount + nextPow2 - 1) / nextPow2) * tileSize;

                // Try to prefer layouts where height >= width (more vertical/square, like most CDPR atlases)
                // when it doesn't increase waste too much.
                bool preferTaller = newHeight < newWidth;

                if (preferTaller && nextPow2 > 1)
                {
                    uint prevPow2 = nextPow2 / 2;
                    uint prevWidth = prevPow2 * tileSize;
                    uint prevHeight = ((tileCount + prevPow2 - 1) / prevPow2) * tileSize;

                    if (prevWidth <= 16384)
                    {
                        // Accept previous power of 2 if it gives height >= width or the waste increase is reasonable
                        ulong prevWaste = (ulong)prevWidth * prevHeight - (ulong)tileCount * tileSize * tileSize;
                        ulong currWaste = (ulong)newWidth * newHeight - (ulong)tileCount * tileSize * tileSize;

                        if (prevHeight >= prevWidth || prevWaste <= currWaste * 1.6)
                        {
                            newWidth = prevWidth;
                            newHeight = prevHeight;
                        }
                    }
                }

                if (newWidth <= 16384)
                {
                    _mlmask.AtlasWidth = newWidth;
                    _mlmask.AtlasHeight = newHeight;
                }
            }

            // Final pass: if we still have a very wide result (width > height), try one more time
            // to use a smaller power-of-2 width if it gives a better aspect ratio with acceptable waste.
            uint finalTilesX = _mlmask.AtlasWidth / tileSize;
            uint finalTilesY = _mlmask.AtlasHeight / tileSize;

            if (finalTilesX > finalTilesY && finalTilesX > 1)
            {
                uint smallerPow2 = finalTilesX / 2;
                while (smallerPow2 > 1 && (smallerPow2 & (smallerPow2 - 1)) != 0) smallerPow2 /= 2;

                if (smallerPow2 >= 1)
                {
                    uint tryWidth = smallerPow2 * tileSize;
                    uint tryHeight = ((tileCount + smallerPow2 - 1) / smallerPow2) * tileSize;

                    ulong tryWaste = (ulong)tryWidth * tryHeight - (ulong)tileCount * tileSize * tileSize;
                    ulong currWaste = (ulong)_mlmask.AtlasWidth * _mlmask.AtlasHeight - (ulong)tileCount * tileSize * tileSize;

                    // Accept if it makes height >= width or waste increase is small
                    if ((tryHeight >= tryWidth || tryWaste <= currWaste * 1.5) && tryWidth <= 16384)
                    {
                        _mlmask.AtlasWidth = tryWidth;
                        _mlmask.AtlasHeight = tryHeight;
                    }
                }
            }

            _logger.Info($"Atlas packed to {_mlmask.AtlasWidth}x{_mlmask.AtlasHeight} ({tileCount} unique tiles, tileSize={tileSize})");
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
            xx = Math.Clamp(xx, 0, (int)_mlmask.Layers![layerIdx].Width - 1);
            yy = Math.Clamp(yy, 0, (int)_mlmask.Layers[layerIdx].Height - 1);
            return _mlmask.Layers[layerIdx].Pixels[xx + (yy * (int)_mlmask.Layers[layerIdx].Width)];
        }

        private void CleanTileLayers()
        {
            if (_mlmask.Layers == null || _mlmask.MaskTilesHigh == null || _mlmask.MaskTilesLow == null) return;

            for (uint I = 0; I < _mlmask.Layers.Length; I++)
            {
                if (_mlmask.Layers[I].Width < _mlmask.WidthHigh)
                {
                    // Low-res layer
                    for (uint y = 0; y < _mlmask.HeightInTilesLow; y++)
                    {
                        for (uint x = 0; x < _mlmask.WidthInTilesLow; x++)
                        {
                            uint wTiles0 = _mlmask.Layers[I].WidthInTiles0;
                            uint hTiles0 = _mlmask.Layers[I].HeightInTiles0;

                            if (wTiles0 == 0 || hTiles0 == 0) continue;

                            var txRaw = x * _mlmask.Layers[I].Width / _mlmask.WidthLow;
                            var tyRaw = y * _mlmask.Layers[I].Height / _mlmask.HeightLow;

                            var tx = Math.Min(txRaw, wTiles0 - 1);
                            var ty = Math.Min(tyRaw, hTiles0 - 1);

                            var tileIdxCheck = tx + (ty * wTiles0);
                            if (tileIdxCheck < (uint)_mlmask.Layers[I].Tiles.Count &&
                                _mlmask.Layers[I].Tiles[(int)tileIdxCheck].RangeMax > 0)
                            {
                                var layer = new TileView
                                {
                                    LayerIndex = I,
                                    LayerTileIndex = tx + (ty * wTiles0),
                                    AtlasInPosition = PackTileInAtlas(I, tx, ty)
                                };
                                _mlmask.MaskTilesLow[x + (y * _mlmask.WidthInTilesLow)].Layers.Add(layer);
                            }
                        }
                    }
                }
                else
                {
                    // High-res layer
                    for (uint y = 0; y < _mlmask.HeightInTilesHigh; y++)
                    {
                        for (uint x = 0; x < _mlmask.WidthInTilesHigh; x++)
                        {
                            uint wTiles0 = _mlmask.Layers[I].WidthInTiles0;
                            uint hTiles0 = _mlmask.Layers[I].HeightInTiles0;

                            if (wTiles0 == 0 || hTiles0 == 0) continue;

                            var txRaw = x * _mlmask.Layers[I].Width / _mlmask.WidthHigh;
                            var tyRaw = y * _mlmask.Layers[I].Height / _mlmask.HeightHigh;

                            var tx = Math.Min(txRaw, wTiles0 - 1);
                            var ty = Math.Min(tyRaw, hTiles0 - 1);

                            var tileIdxCheck = tx + (ty * wTiles0);
                            if (tileIdxCheck < (uint)_mlmask.Layers[I].Tiles.Count &&
                                _mlmask.Layers[I].Tiles[(int)tileIdxCheck].RangeMax > 0)
                            {
                                var layer = new TileView
                                {
                                    LayerIndex = I,
                                    LayerTileIndex = tx + (ty * wTiles0),
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
            if (_mlmask.Layers == null || layerIdx >= _mlmask.Layers.Length) return 0;

            var layer = _mlmask.Layers[layerIdx];
            if (layer.Tiles == null || layer.WidthInTiles0 == 0 || layer.HeightInTiles0 == 0) return 0;

            // Extra safety clamp in case caller passed slightly out-of-range values
            if (tx >= layer.WidthInTiles0) tx = layer.WidthInTiles0 - 1;
            if (ty >= layer.HeightInTiles0) ty = layer.HeightInTiles0 - 1;

            var tileIndex = tx + (ty * layer.WidthInTiles0);
            if (tileIndex >= (uint)layer.Tiles.Count)
            {
                _logger?.Error($"PackTileInAtlas: calculated tileIndex {tileIndex} is out of range for layer {layerIdx} (Tiles.Count = {layer.Tiles.Count}, tx={tx}, ty={ty})");
                return 0;
            }

            if (layer.Tiles[(int)tileIndex].AtlasInPosition == uint.MaxValue)
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
            // Extra defensive bounds check for neighbor tiles
            uint w = layer.WidthInTiles0;
            uint h = layer.HeightInTiles0;
            if (w == 0 || h == 0) return;

            if (tx >= w || ty >= h) return; // neighbor is out of layer bounds — skip

            uint neighborTileIndex = tx + (ty * w);
            if (neighborTileIndex >= (uint)layer.Tiles.Count) return;

            for (uint j = 0; j < 4; j++)
            {
                for (uint i = 0; i < 4; i++)
                {
                    var px = (xBlock * 4) + i;
                    var py = (yBlock * 4) + j;
                    var v = layer.Tiles[(int)neighborTileIndex].AtlasUnCompressed[px + (py * _mlmask.AtlasTileSize)] / 255.0f;
                    referenceData.Add(v);
                }
            }
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
                        var widthShift = _mlmask.Layers![layerIdx].WidthShift;
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

        #endregion Core Methods

        #region Structs

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

            public uint PreferredTileSize;
            public uint PreferredAtlasWidth;
            public uint PreferredAtlasHeight;
        }

        #endregion Structs

        #region FNV1A

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

        #endregion FNV1A

        #region D3DX

        internal class D3DX
        {
            [StructLayout(LayoutKind.Explicit, Size = 8)]
            public struct BC4_UNORM
            {
                [FieldOffset(0)] public ulong Data;
                [FieldOffset(0)] public byte Red_0;
                [FieldOffset(1)] public byte Red_1;
                [FieldOffset(2)] public byte Index0;
                [FieldOffset(3)] public byte Index1;
                [FieldOffset(4)] public byte Index2;
                [FieldOffset(5)] public byte Index3;
                [FieldOffset(6)] public byte Index4;
                [FieldOffset(7)] public byte Index5;

                public uint GetIndex(int offset) => (uint)(Data >> ((3 * offset) + 16)) & 0x07;

                public void SetIndex(int uOffset, int uIndex)
                {
                    Data &= ~((ulong)0x07 << ((3 * uOffset) + 16));
                    Data |= (ulong)uIndex << ((3 * uOffset) + 16);
                }

                public float R(int offset)
                {
                    var index = GetIndex(offset);
                    return DecodeFromIndex(index);
                }

                public float DecodeFromIndex(uint index)
                {
                    if (index == 0) return Red_0 / 255.0f;
                    if (index == 1) return Red_1 / 255.0f;

                    var fred0 = Red_0 / 255.0f;
                    var fred1 = Red_1 / 255.0f;

                    if (Red_0 > Red_1)
                    {
                        index--;
                        return ((fred0 * ((float)7 - index)) + (fred1 * index)) / 7.0f;
                    }

                    if (index == 6) return 0.0f;
                    if (index == 7) return 1.0f;

                    index--;
                    return ((fred0 * ((float)5 - index)) + (fred1 * index)) / 5.0f;
                }
            }

            public static void D3DXEncodeBC4U(ref ulong resultantBlock, float[] refData, List<float> theTexelsU)
            {
                var pBC4 = new BC4_UNORM();
                FindEndPointsBC4U(theTexelsU, theTexelsU.Count, ref pBC4.Red_0, ref pBC4.Red_1);
                FindClosestUNORM(ref pBC4, refData);
                resultantBlock = pBC4.Data;
            }

            private static void FindEndPointsBC4U(List<float> theTexelsU, int numTexels, ref byte endpointU_0, ref byte endpointU_1)
            {
                var fBlockMax = theTexelsU[0];
                var fBlockMin = theTexelsU[0];
                for (var i = 0; i < numTexels; ++i)
                {
                    if (theTexelsU[i] < fBlockMin) fBlockMin = theTexelsU[i];
                    else if (theTexelsU[i] > fBlockMax) fBlockMax = theTexelsU[i];
                }

                var bUsing4BlockCodec = fBlockMin == 0f || fBlockMax == 1f;
                float fStart = 0, fEnd = 0;

                if (!bUsing4BlockCodec)
                {
                    OptimizeAlpha(ref fStart, ref fEnd, theTexelsU, numTexels, 8);
                    endpointU_0 = (byte)(fEnd * 255.0f);
                    endpointU_1 = (byte)(fStart * 255.0f);
                }
                else
                {
                    OptimizeAlpha(ref fStart, ref fEnd, theTexelsU, numTexels, 6);
                    endpointU_1 = (byte)(fEnd * 255.0f);
                    endpointU_0 = (byte)(fStart * 255.0f);
                }
            }

            private static void OptimizeAlpha(ref float pX, ref float pY, List<float> pPoints, int numTexels, uint cSteps)
            {
                float[] pC6 = { 5.0f / 5.0f, 4.0f / 5.0f, 3.0f / 5.0f, 2.0f / 5.0f, 1.0f / 5.0f, 0.0f / 5.0f };
                float[] pD6 = { 0.0f / 5.0f, 1.0f / 5.0f, 2.0f / 5.0f, 3.0f / 5.0f, 4.0f / 5.0f, 5.0f / 5.0f };
                float[] pC8 = { 7.0f / 7.0f, 6.0f / 7.0f, 5.0f / 7.0f, 4.0f / 7.0f, 3.0f / 7.0f, 2.0f / 7.0f, 1.0f / 7.0f, 0.0f / 7.0f };
                float[] pD8 = { 0.0f / 7.0f, 1.0f / 7.0f, 2.0f / 7.0f, 3.0f / 7.0f, 4.0f / 7.0f, 5.0f / 7.0f, 6.0f / 7.0f, 7.0f / 7.0f };

                var pC = (cSteps == 6) ? pC6 : pC8;
                var pD = (cSteps == 6) ? pD6 : pD8;

                float fX = 1.0f;
                float fY = 0.0f;

                if (cSteps == 8)
                {
                    for (var iPoint = 0; iPoint < numTexels; iPoint++)
                    {
                        if (pPoints[iPoint] < fX) fX = pPoints[iPoint];
                        if (pPoints[iPoint] > fY) fY = pPoints[iPoint];
                    }
                }
                else
                {
                    for (var iPoint = 0; iPoint < numTexels; iPoint++)
                    {
                        if (pPoints[iPoint] < fX && pPoints[iPoint] > 0.0f) fX = pPoints[iPoint];
                        if (pPoints[iPoint] > fY && pPoints[iPoint] < 1.0f) fY = pPoints[iPoint];
                    }
                    if (fX == fY) fY = 1.0f;
                }

                var fSteps = Convert.ToSingle(cSteps - 1);

                for (var iIteration = 0; iIteration < 8; iIteration++)
                {
                    if (fY - fX < 1.0f / 256.0f) break;

                    var fScale = fSteps / (fY - fX);
                    var pSteps = new float[8];

                    for (var iStep = 0; iStep < cSteps; iStep++)
                        pSteps[iStep] = (pC[iStep] * fX) + (pD[iStep] * fY);

                    if (cSteps == 6)
                    {
                        pSteps[6] = 0.0f;
                        pSteps[7] = 1.0f;
                    }

                    var dX = 0.0f;
                    var dY = 0.0f;
                    var d2X = 0.0f;
                    var d2Y = 0.0f;

                    for (uint iPoint = 0; iPoint < numTexels; iPoint++)
                    {
                        var fDot = (pPoints[(int)iPoint] - fX) * fScale;
                        uint iStep;

                        if (fDot <= 0.0f)
                            iStep = (cSteps == 6 && pPoints[(int)iPoint] <= fX * 0.5f) ? 6u : 0u;
                        else if (fDot >= fSteps)
                            iStep = (cSteps == 6 && pPoints[(int)iPoint] >= (fY + 1.0f) * 0.5f) ? 7u : cSteps - 1;
                        else
                            iStep = (uint)(fDot + 0.5f);

                        if (iStep < cSteps)
                        {
                            var fDiff = pSteps[iStep] - pPoints[(int)iPoint];
                            dX += pC[iStep] * fDiff;
                            d2X += pC[iStep] * pC[iStep];
                            dY += pD[iStep] * fDiff;
                            d2Y += pD[iStep] * pD[iStep];
                        }
                    }

                    if (d2X > 0.0f) fX -= dX / d2X;
                    if (d2Y > 0.0f) fY -= dY / d2Y;

                    if (fX > fY) (fY, fX) = (fX, fY);

                    if (dX * dX < 1.0f / 64.0f && dY * dY < 1.0f / 64.0f) break;
                }

                pX = Math.Clamp(fX, 0.0f, 1.0f);
                pY = Math.Clamp(fY, 0.0f, 1.0f);
            }

            private static void FindClosestUNORM(ref BC4_UNORM pBC, float[] theTexelsU)
            {
                const uint numPixelsPerBlock = 16;
                var rGradient = new float[8];
                for (uint i = 0; i < 8; ++i)
                    rGradient[i] = pBC.DecodeFromIndex(i);

                for (uint i = 0; i < numPixelsPerBlock; ++i)
                {
                    uint uBestIndex = 0;
                    float fBestDelta = 100000;
                    for (uint uIndex = 0; uIndex < 8; uIndex++)
                    {
                        var fCurrentDelta = Math.Abs(rGradient[uIndex] - theTexelsU[i]);
                        if (fCurrentDelta < fBestDelta)
                        {
                            uBestIndex = uIndex;
                            fBestDelta = fCurrentDelta;
                        }
                    }
                    pBC.SetIndex((int)i, (int)uBestIndex);
                }
            }

            public static void D3DXDecodeBC4U(ref float[] pColor, ulong pBC)
            {
                const uint numPixelsPerBlock = 16;
                var pBC4 = new BC4_UNORM { Data = pBC };
                for (var i = 0; i < numPixelsPerBlock; ++i)
                    pColor[i] = pBC4.R(i);
            }
        }

        #endregion D3DX
    }
}
