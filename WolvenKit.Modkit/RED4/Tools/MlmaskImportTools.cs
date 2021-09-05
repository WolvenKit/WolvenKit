using System;
using System.IO;
using System.Collections.Generic;
using WolvenKit.Common.DDS;
using System.Diagnostics;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;
using System.Runtime.InteropServices;
using WolvenKit.Common;
using System.Text.RegularExpressions;

namespace WolvenKit.Modkit.RED4.MLMask
{
    class MLMASK
    {
        private const UInt32 headerLength = 148;
        //assuming DDSUtils.ConvertToDdsMemory always creates a dx10 dds,
        //if it creates a dx9 or both we will have to check for it, headerlength = 128, if(dx10) headerlength += 20

        private MLMaskContainer mlmask;
        public void Import(FileInfo txtimageList, FileInfo outFile)
        {
            var files = File.ReadAllLines(txtimageList.FullName);

            #region InitandVerify

            mlmask = new MLMaskContainer();
            List<RawTexContainer> textures = new List<RawTexContainer>();
            RawTexContainer white = new RawTexContainer();
            white._pixels = new Byte[16];
            Array.Fill<Byte>(white._pixels, 255);
            white._width = 4;
            white._height = 4;
            textures.Add(white);

            int lineIdx = 1;
            foreach (var f in files)
            {
                if (!File.Exists(f))
                    throw new FileNotFoundException($"Line{{lineIdx}}: \"{f}\" Make sure the file path is valid and exists (paths are specified line by line in ascending layer order in masklist)");

                var ms = new MemoryStream(File.ReadAllBytes(f));
                var s = Path.GetExtension(f).ToLower();
                var euncook = Enum.Parse<EUncookExtension>(Path.GetExtension(f).ToLower().Replace(".",""));
                if(euncook != EUncookExtension.dds)
                {
                    ms = new MemoryStream(DDSUtils.ConvertToDdsMemory(ms, euncook, DXGI_FORMAT.DXGI_FORMAT_R8_UNORM));
                }
                else
                {
                    // why dds to dds?, to make sure format is r8_unorm
                    ms = new MemoryStream(DDSUtils.ConvertToDdsMemory(new MemoryStream(DDSUtils.ConvertFromDdsMemory(ms, EUncookExtension.tga)), EUncookExtension.tga, DXGI_FORMAT.DXGI_FORMAT_R8_UNORM));
                }
                ms.Seek(0, SeekOrigin.Begin);
                DDS_HEADER header;
                DDSUtils.TryReadDdsHeader(ms, out header);
                if (header.dwWidth != header.dwHeight)
                    throw new Exception($"Texture {f}: width={header.dwWidth},height={header.dwHeight} must have an aspect ratio of 1:1");
                
                // One bitset check
                if ((((header.dwWidth - 1) & header.dwHeight) != 0) || (header.dwWidth == 0))
                    throw new Exception($"Texture {f}: width={header.dwWidth},height={header.dwHeight} must have dimensions in powers of 2");


                //if (header.dwMipMapCount > 1)
                //    throw new Exception($"Texture {f}: Mipmaps={header.dwMipMapCount}, mimap count must be equal to 1");

                //if ((ms.Length - headerLength) != (header.dwWidth * header.dwHeight))
                //    throw new Exception("Not R8_UNORM 8bpp image format or more than 1mipmaps or rowstride is not equal to width or its a dx10 dds(unsupported)");

                var br = new BinaryReader(ms);
                ms.Seek(headerLength, SeekOrigin.Begin);
                Byte[] bytes = br.ReadBytes((int)(header.dwWidth * header.dwHeight));
                bool whiteCheck = true;
                for(int i = 0; i < bytes.Length; i++)
                {
                    if(bytes[i] != 255)
                    {
                        whiteCheck = false;
                        break;
                    }
                }
                if (whiteCheck)
                    throw new Exception("No need to provide the 1st/any blank white mask layer, tool will generate 1st blank white layer automatically");

                RawTexContainer tex = new RawTexContainer();
                tex._width = header.dwWidth;
                tex._height = header.dwHeight;
                tex._pixels = bytes;
                textures.Add(tex);
                lineIdx++;
            }
            mlmask.layers = textures.ToArray();
            #endregion

            Create();
            Write(outFile);
        }
        #region Methods
        void Write(FileInfo f)
        {
            CR2WFile cr2w = new CR2WFile();
            {
                var blob = new Multilayer_Mask(cr2w, null, "Multilayer_Mask") { IsSerialized = true };
                blob.CookingPlatform = new CEnum<Enums.ECookingPlatform>(cr2w, blob, "cookingPlatform") { IsSerialized = true, Value = Enums.ECookingPlatform.PLATFORM_PC };
                blob.CookingPlatform.EnumValueList.Add("PLATFORM_PC");
                blob.RenderResourceBlob.RenderResourceBlobPC = new CHandle<IRenderResourceBlob>(cr2w, blob.RenderResourceBlob, "renderResourceBlobPC") { IsSerialized = true };
                cr2w.CreateChunk(blob, 0);
            }
            {
                var blob = new rendRenderMultilayerMaskBlobPC(cr2w, null, "rendRenderMultilayerMaskBlobPC") { IsSerialized = true };
                blob.Header = new rendRenderMultilayerMaskBlobHeader(cr2w, blob, "header") { IsSerialized = true };
                blob.Header.Version = new CUInt32(cr2w, blob.Header, "version") { IsSerialized = true, Value = 3 };
                blob.Header.AtlasWidth = new CUInt32(cr2w, blob.Header, "atlasWidth") { IsSerialized = true, Value = mlmask._atlasWidth };
                blob.Header.AtlasHeight = new CUInt32(cr2w, blob.Header, "atlasHeight") { IsSerialized = true, Value = mlmask._atlasHeight };
                blob.Header.NumLayers = new CUInt32(cr2w, blob.Header, "numLayers") { IsSerialized = true, Value = (uint)mlmask.layers.Length };
                blob.Header.MaskWidth = new CUInt32(cr2w, blob.Header, "maskWidth") { IsSerialized = true, Value = mlmask._widthHigh };
                blob.Header.MaskHeight = new CUInt32(cr2w, blob.Header, "maskHeight") { IsSerialized = true, Value = mlmask._heightHigh };
                blob.Header.MaskWidthLow = new CUInt32(cr2w, blob.Header, "maskWidthLow") { IsSerialized = true, Value = mlmask._widthLow };
                blob.Header.MaskHeightLow = new CUInt32(cr2w, blob.Header, "maskHeightLow") { IsSerialized = true, Value = mlmask._heightLow };
                blob.Header.MaskTileSize = new CUInt32(cr2w, blob.Header, "maskTileSize") { IsSerialized = true, Value = mlmask._tileSize };
                blob.Header.Flags = new CUInt32(cr2w, blob.Header, "flags") { IsSerialized = true, Value = 2 };
                blob.AtlasData = new serializationDeferredDataBuffer(cr2w, blob, "atlasData") { IsSerialized = true };
                blob.AtlasData.Buffer = new CUInt16(cr2w, blob.AtlasData, "Buffer") { IsSerialized = true, Value = 1 };
                blob.TilesData = new serializationDeferredDataBuffer(cr2w, blob, "tilesData") { IsSerialized = true };
                blob.TilesData.Buffer = new CUInt16(cr2w, blob.TilesData, "Buffer") { IsSerialized = true, Value = 2 };

                cr2w.CreateChunk(blob, 1);
            }
    (cr2w.Chunks[0].Data as Multilayer_Mask).RenderResourceBlob.RenderResourceBlobPC.SetReference(cr2w.Chunks[1]);

            //test write
            var ms = new MemoryStream();
            var bw = new BinaryWriter(ms);

            using (var compressed = new MemoryStream())
            {
                using var buff = new BinaryWriter(compressed);
                var (zsize, crc) = buff.CompressAndWrite(mlmask._AtlasBuffer);

                cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                {
                    flags = 0,
                    index = 0,
                    offset = 0,
                    diskSize = zsize,
                    memSize = (UInt32)mlmask._AtlasBuffer.Length,
                    crc32 = crc
                }));

                cr2w.Buffers[0].ReadData(new BinaryReader(compressed));
                // to get offset
                cr2w.Write(bw);
                cr2w.Buffers[0].Offset = (uint)ms.Length;
            }
            using (var compressed = new MemoryStream())
            {
                using var buff = new BinaryWriter(compressed);
                var (zsize, crc) = buff.CompressAndWrite(mlmask._tilesBuffer);

                cr2w.Buffers.Add(new CR2WBufferWrapper(new CR2WBuffer()
                {
                    flags = 0,
                    index = 1,
                    offset = 0,
                    diskSize = zsize,
                    memSize = (UInt32)mlmask._tilesBuffer.Length,
                    crc32 = crc
                }));

                cr2w.Buffers[1].ReadData(new BinaryReader(compressed));
                cr2w.Buffers[1].Offset = cr2w.Buffers[0].Offset + cr2w.Buffers[0].DiskSize;
            }

            cr2w.Write(bw);
            if (!Directory.Exists(f.Directory.FullName))
            {
                Directory.CreateDirectory(f.Directory.FullName);
            }
            File.WriteAllBytes(f.FullName, ms.ToArray());
        }
        void PutTiles(ref List<uint> tilesDataList, MaskTile[] Tilez, uint basisTileIdx, uint widthInTiles0, uint heightInTiles0)
        {
            uint atlasTileSize = mlmask._atlasWidth / mlmask._atlasTileSize;
            uint widthInTilesShift0 = (uint)Math.Log2(atlasTileSize);
            uint widthInTilesGrayUP = Convert.ToUInt32((1 << Convert.ToInt32(widthInTilesShift0)) - 1);

            for (uint ty = 0; ty < heightInTiles0; ty++)
            {
                for (uint tx = 0; tx < widthInTiles0; tx++)
                {
                    uint tileIdx = (tx + ty * widthInTiles0);
                    uint layersBeg = Convert.ToUInt32(tilesDataList.Count);
                    uint numLayers = Convert.ToUInt32(Tilez[tileIdx]._layers.Count);

                    tilesDataList[Convert.ToInt32((basisTileIdx + tileIdx) * 2 + 0)] = layersBeg;

                    uint layersMask = 0;
                    for (int I = 0; I < numLayers; I++)
                    {
                        uint layerIdx = Tilez[tileIdx]._layers[I]._layerIndex;
                        uint position = Tilez[tileIdx]._layers[I]._atlasInPosition;
                        uint atlasX = position & widthInTilesGrayUP;
                        uint atlasY = Convert.ToUInt32(Convert.ToInt32(position) >> Convert.ToInt32(widthInTilesShift0));
                        uint widthShift = mlmask.layers[layerIdx]._widthShift;
                        uint heightShift = mlmask.layers[layerIdx]._heightShift;

                        uint puts = 0;
                        puts = puts | atlasX;
                        puts = puts | (atlasY << 10);
                        puts = puts | (widthShift << 20);
                        puts = puts | (heightShift << 24);

                        tilesDataList.Add(puts);

                        layersMask = layersMask | Convert.ToUInt32(1 << Convert.ToInt32(layerIdx));
                    }

                    tilesDataList[Convert.ToInt32((basisTileIdx + tileIdx) * 2 + 1)] = layersMask;
                }
            }
        }
        void InitializeMaskLayers()
        {
            for (uint I = 0; I < mlmask.layers.Length; I++)
            {
                mlmask.layers[I]._widthInTiles0 = (mlmask.layers[I]._width + (mlmask._tileSize - 1)) / mlmask._tileSize;
                mlmask.layers[I]._heightInTiles0 = (mlmask.layers[I]._height + (mlmask._tileSize - 1)) / mlmask._tileSize;
                mlmask.layers[I].tiles = new List<Tile>();

                for (uint y = 0; y < mlmask.layers[I]._heightInTiles0; y++)
                {
                    for (uint x = 0; x < mlmask.layers[I]._widthInTiles0; x++)
                    {
                        Tile tile = new Tile();
                        tile._atlasInPosition = uint.MaxValue;
                        tile._atlasUnCompressed = new Byte[mlmask._atlasTileSize * mlmask._atlasTileSize];

                        if(I == 0)
                        {
                            tile._rangeMin = 255;
                            tile._rangeMax = 255;
                            Array.Fill<Byte>(tile._atlasUnCompressed, 255);
                        }
                        else
                        {
                            tile._rangeMin = 255;
                            tile._rangeMax = 0;

                            for (uint yy = 0; yy < mlmask._atlasTileSize; yy++)
                            {
                                for (uint xx = 0; xx < mlmask._atlasTileSize; xx++)
                                {
                                    Byte v = GetPixelFromLayer(I, x, y, Convert.ToInt32(xx) - 1, Convert.ToInt32(yy) - 1);
                                    tile._atlasUnCompressed[xx + yy * mlmask._atlasTileSize] = v;
                                    tile._rangeMin = Math.Min(tile._rangeMin, v);
                                    tile._rangeMax = Math.Max(tile._rangeMax, v);
                                }
                            }
                        }

                        mlmask.layers[I].tiles.Add(tile);
                    }
                }
            }
        }
        Byte GetPixelFromLayer(uint layerIdx, uint tx, uint ty, int x, int y)
        {
            if(layerIdx == 0)
                return 255;

            int xx = Convert.ToInt32(tx * mlmask._tileSize) + x;
            int yy = Convert.ToInt32(ty * mlmask._tileSize) + y;
            xx = Math.Clamp(xx, 0, Convert.ToInt32(mlmask.layers[layerIdx]._width - 1));
            yy = Math.Clamp(yy, 0, Convert.ToInt32(mlmask.layers[layerIdx]._height - 1));
            return mlmask.layers[layerIdx]._pixels[xx + yy * Convert.ToInt32(mlmask.layers[layerIdx]._width)];
        }
        void Create()
        {
            mlmask._widthHigh = 0;
            mlmask._heightHigh = 0;
            mlmask._widthLow = 0;
            mlmask._heightLow = 0;
            foreach (var lay in mlmask.layers)
            {
                if (lay._width < mlmask._widthHigh)
                {
                    mlmask._widthLow = Math.Max(mlmask._widthLow, lay._width);
                    mlmask._heightLow = Math.Max(mlmask._heightLow, lay._height);
                }
                else if (lay._width > mlmask._widthHigh)
                {
                    mlmask._widthLow = Math.Max(mlmask._widthLow, mlmask._widthHigh);
                    mlmask._heightLow = Math.Max(mlmask._heightLow, mlmask._heightHigh);

                    mlmask._widthHigh = Math.Max(mlmask._widthHigh, lay._width);
                    mlmask._heightHigh = Math.Max(mlmask._heightHigh, lay._height);
                }
            }

            for (int i = 0; i < mlmask.layers.Length; i++)
            {
                mlmask.layers[i]._widthShift = (uint)Math.Log2(mlmask._widthHigh / mlmask.layers[i]._width);
                mlmask.layers[i]._heightShift = (uint)Math.Log2(mlmask._heightHigh / mlmask.layers[i]._height);
            }

            uint tempAtlasTileSize = 16;
            while (true)
            {
                mlmask._atlasTileSize = tempAtlasTileSize;
                mlmask._tileSize = (mlmask._atlasTileSize - 2);

                tempAtlasTileSize += 16;

                mlmask._maskTilesHigh = null;
                mlmask._maskTilesLow = null;
                mlmask._atlasTiles.Clear();
                mlmask._atlasWidth = 0;
                mlmask._atlasHeight = 0;
                mlmask._atlasTilesCount = 0;

                InitializeMaskLayers();

                mlmask._widthInTilesHigh = (mlmask._widthHigh + (mlmask._tileSize - 1)) / mlmask._tileSize;
                mlmask._heightInTilesHigh = (mlmask._heightHigh + (mlmask._tileSize - 1)) / mlmask._tileSize;
                mlmask._widthInTilesLow = (mlmask._widthLow + (mlmask._tileSize - 1)) / mlmask._tileSize;
                mlmask._heightInTilesLow = (mlmask._heightLow + (mlmask._tileSize - 1)) / mlmask._tileSize;

                mlmask._maskTilesHigh = new MaskTile[mlmask._widthInTilesHigh * mlmask._heightInTilesHigh];
                for (uint i = 0; i < mlmask._widthInTilesHigh * mlmask._heightInTilesHigh; i++)
                {
                    mlmask._maskTilesHigh[i]._layers = new List<TileView>();
                }

                mlmask._maskTilesLow = new MaskTile[mlmask._widthInTilesLow * mlmask._heightInTilesLow];
                for (uint i = 0; i < mlmask._widthInTilesLow * mlmask._heightInTilesLow; i++)
                {
                    mlmask._maskTilesLow[i]._layers = new List<TileView>();
                }
                CleanTileLayers();

                if (mlmask._atlasTiles.Count <= 0x20000)
                    break;
            }

            CalculateAtlasProportionForPacking();
            CreateAtlasBuffer();

            uint numtilesHigh = mlmask._widthInTilesHigh * mlmask._heightInTilesHigh;
            uint numtilesLow = mlmask._widthInTilesLow * mlmask._heightInTilesLow;
            List<uint> tilesDataList = new List<uint>();

            for (uint i = 0; i < ((numtilesHigh + numtilesLow) * 2); i++)
            {
                tilesDataList.Add(0U);
            }

            PutTiles(ref tilesDataList, mlmask._maskTilesHigh, 0, mlmask._widthInTilesHigh, mlmask._heightInTilesHigh);
            PutTiles(ref tilesDataList, mlmask._maskTilesLow, numtilesHigh, mlmask._widthInTilesLow, mlmask._heightInTilesLow);

            var ms = new MemoryStream();
            var bw = new BinaryWriter(ms);
            for (int i = 0; i < tilesDataList.Count; i++)
            {
                bw.Write(tilesDataList[i]);
            }
            mlmask._tilesBuffer = ms.ToArray();
        }
        void CleanTileLayers()
        {
            for (uint I = 0; I < mlmask.layers.Length; I++)
            {

                if (mlmask.layers[I]._width < mlmask._widthHigh)
                {
                    for (uint y = 0; y < mlmask._heightInTilesLow; y++)
                    {
                        for (uint x = 0; x < mlmask._widthInTilesLow; x++)
                        {
                            uint tx = (x * mlmask.layers[I]._width) / mlmask._widthLow;
                            uint ty = (y * mlmask.layers[I]._height) / mlmask._heightLow;

                            if (mlmask.layers[I].tiles[Convert.ToInt32(tx + ty * mlmask.layers[I]._widthInTiles0)]._rangeMax > 0)
                            {
                                TileView layer = new TileView();
                                layer._layerIndex = I;
                                layer._layerTileIndex = (tx + ty * mlmask.layers[I]._widthInTiles0);
                                layer._atlasInPosition = PackTileInAtlas(I, tx, ty);
                                mlmask._maskTilesLow[x + y * mlmask._widthInTilesLow]._layers.Add(layer);
                            }
                        }
                    }
                }
                else
                {
                    for (uint y = 0; y < mlmask._heightInTilesHigh; y++)
                    {
                        for (uint x = 0; x < mlmask._widthInTilesHigh; x++)
                        {
                            uint tx = (x * mlmask.layers[I]._width) / mlmask._widthHigh;
                            uint ty = (y * mlmask.layers[I]._height) / mlmask._heightHigh;

                            if (mlmask.layers[I].tiles[Convert.ToInt32(tx + ty * mlmask.layers[I]._widthInTiles0)]._rangeMax > 0)
                            {
                                TileView layer = new TileView();
                                layer._layerIndex = I;
                                layer._layerTileIndex = (tx + ty * mlmask.layers[I]._widthInTiles0);
                                layer._atlasInPosition = PackTileInAtlas(I, tx, ty);
                                mlmask._maskTilesHigh[x + y * mlmask._widthInTilesHigh]._layers.Add(layer);
                            }
                        }
                    }
                }
            }
        }
        uint PackTileInAtlas(uint layerIdx, uint tx, uint ty)
        {
            uint tileIndex = (tx + ty * mlmask.layers[layerIdx]._widthInTiles0);

            if (mlmask.layers[layerIdx].tiles[Convert.ToInt32(tileIndex)]._atlasInPosition == uint.MaxValue)
            {
                BlockCompressLocalTile(ref mlmask.layers[layerIdx], tileIndex);

                UInt64 recursiveHash = FNV1A.FnvHashInitial;
                for (uint y = 0; y < mlmask._atlasTileSize / 4; y++)
                {
                    for (uint x = 0; x < mlmask._atlasTileSize / 4; x++)
                    {
                        UInt64 compressedBlock = mlmask.layers[layerIdx].tiles[Convert.ToInt32(tileIndex)]._atlasBlockCompressed[x + y * mlmask._atlasTileSize / 4];
                        float[] color32 = new float[16];
                        D3DX.D3DXDecodeBC4U(ref color32, compressedBlock);
                        Byte[] color8 = new Byte[16];
                        for (uint i = 0; i < 16; ++i)
                        {
                            color8[i] = Convert.ToByte(color32[i] * 255.0f);
                        }

                        recursiveHash = FNV1A.HashReadOnlySpan(color8, recursiveHash);
                    }
                }

                TileView atlasView = new TileView();
                if (!mlmask._atlasTiles.TryGetValue(recursiveHash, out atlasView))
                {

                    TileView atlasTile = new TileView();
                    atlasTile._atlasInPosition = mlmask._atlasTilesCount++;
                    atlasTile._layerIndex = layerIdx;
                    atlasTile._layerTileIndex = tileIndex;

                    atlasView = atlasTile;
                    mlmask._atlasTiles.Add(recursiveHash, atlasTile);
                }

                var z = mlmask.layers[layerIdx].tiles[Convert.ToInt32(tileIndex)];
                z._atlasInPosition = atlasView._atlasInPosition;
                mlmask.layers[layerIdx].tiles[Convert.ToInt32(tileIndex)] = z;
            }

            return mlmask.layers[layerIdx].tiles[Convert.ToInt32(tileIndex)]._atlasInPosition;
        }
        void CalculateAtlasProportionForPacking()
        {
            mlmask._atlasWidth = 0;
            mlmask._atlasHeight = 0;

            uint WidthTry = 16384;
            uint emptyArea = uint.MaxValue;
            while (WidthTry >= mlmask._atlasTileSize)
            {
                uint widthInTiles0 = (WidthTry / mlmask._atlasTileSize);
                uint HeightTry = ((mlmask._atlasTilesCount + widthInTiles0 - 1) / widthInTiles0) * mlmask._atlasTileSize;

                uint widthUP = RoundUpPowerOf2(WidthTry);
                uint heightUP = RoundUpPowerOf2(HeightTry);

                uint currEmptyArea = (widthUP * heightUP) - (mlmask._atlasTilesCount * mlmask._atlasTileSize * mlmask._atlasTileSize);
                if (currEmptyArea <= emptyArea)
                {
                    mlmask._atlasWidth = WidthTry;
                    mlmask._atlasHeight = HeightTry;
                    emptyArea = currEmptyArea;
                }

                if (WidthTry <= HeightTry)
                {
                    break;
                }
                else
                {
                    WidthTry = WidthTry / 2;
                }
            }

            if (mlmask._atlasWidth > 16384 || mlmask._atlasHeight > 16384)
            {
                throw new Exception("Whoa Whoa, Way too many layers or way large mask dimensions which exceeded the max 16k DDS resolution limit for the atlas");
            }
        }
        void CreateAtlasBuffer()
        {
            if(mlmask._atlasWidth <= 0 || mlmask._atlasHeight <= 0)
            {
                throw new Exception("Unable to generate MLmask atlas data");
            }

            uint tileSizeInBlocks0 = mlmask._atlasTileSize / 4;
            uint WidthInBlocks0 = mlmask._atlasWidth / 4;
            uint HeightInBlocks0 = mlmask._atlasHeight / 4;
            uint WidthInTiles0 = mlmask._atlasWidth / mlmask._atlasTileSize;

            var Data = new UInt64[(WidthInBlocks0 * HeightInBlocks0)];

            foreach (var atlasTile in mlmask._atlasTiles.Values)
            {
                RawTexContainer sourceLayer = mlmask.layers[atlasTile._layerIndex];
                Tile tileSource = sourceLayer.tiles[Convert.ToInt32(atlasTile._layerTileIndex)];

                uint position = atlasTile._atlasInPosition;
                uint tx = position % WidthInTiles0;
                uint ty = position / WidthInTiles0;
                uint bx = tx * tileSizeInBlocks0;
                uint by = ty * tileSizeInBlocks0;

                uint destinationIdx = bx + by * WidthInBlocks0;
                for (uint i = 0; i < tileSizeInBlocks0; i++)
                {
                    Array.Copy(tileSource._atlasBlockCompressed, i * tileSizeInBlocks0, Data, destinationIdx, tileSizeInBlocks0);
                    destinationIdx += WidthInBlocks0;
                }
            }
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);
            for (int i = 0; i < Data.Length; i++)
            {
                bw.Write(Data[i]);
            }
            mlmask._AtlasBuffer = ms.ToArray();
        }
        void BlockCompressLocalTile(ref RawTexContainer layer, uint tileIdx)
        {
            uint tileSizeInBlocks0 = mlmask._atlasTileSize / 4;

            uint tx = (tileIdx % layer._widthInTiles0);
            uint ty = (tileIdx / layer._widthInTiles0);

            var layerTile = layer.tiles[Convert.ToInt32(tileIdx)];
            layerTile._atlasBlockCompressed = new UInt64[(tileSizeInBlocks0 * tileSizeInBlocks0)];

            for (uint yBlock = 0; yBlock < tileSizeInBlocks0; yBlock++)
            {
                for (uint xBlock = 0; xBlock < tileSizeInBlocks0; xBlock++)
                {
                    List<float> referenceData = new List<float>();
                    float[] toBBCValues = new float[16];

                    for (uint j = 0; j < 4; j++)
                    {
                        for (uint i = 0; i < 4; i++)
                        {
                            uint px = xBlock * 4 + i;
                            uint py = yBlock * 4 + j;
                            float v = Convert.ToSingle(layerTile._atlasUnCompressed[px + py * mlmask._atlasTileSize]) / 255.0f;
                            toBBCValues[i + j * 4] = v;
                            referenceData.Add(v);
                        }
                    }

                    if ((tx > 0) && (xBlock == 0))
                    {
                        PushBlockReferenceData(ref referenceData, layer, tx - 1, ty, tileSizeInBlocks0 - 1, yBlock);
                    }
                    else if ((tx < layer._widthInTiles0 - 1) && (xBlock == tileSizeInBlocks0 - 1))
                    {
                        PushBlockReferenceData(ref referenceData, layer, tx + 1, ty, 0, yBlock);
                    }

                    if ((ty > 0) && (yBlock == 0))
                    {
                        PushBlockReferenceData(ref referenceData, layer, tx, ty - 1, xBlock, tileSizeInBlocks0 - 1);
                    }
                    else if ((ty < layer._heightInTiles0 - 1) && (yBlock == tileSizeInBlocks0 - 1))
                    {
                        PushBlockReferenceData(ref referenceData, layer, tx, ty + 1, xBlock, 0);
                    }

                    if (((tx > 0) && (xBlock == 0)) && ((ty > 0) && (yBlock == 0)))
                    {
                        PushBlockReferenceData(ref referenceData, layer, tx - 1, ty - 1, tileSizeInBlocks0 - 1, tileSizeInBlocks0 - 1);
                    }
                    else if (((tx < layer._widthInTiles0 - 1) && (xBlock == tileSizeInBlocks0 - 1)) && ((ty > 0) && (yBlock == 0)))
                    {
                        PushBlockReferenceData(ref referenceData, layer, tx + 1, ty - 1, 0, tileSizeInBlocks0 - 1);
                    }
                    else if (((tx > 0) && (xBlock == 0)) && ((ty < layer._heightInTiles0 - 1) && (yBlock == tileSizeInBlocks0 - 1)))
                    {
                        PushBlockReferenceData(ref referenceData, layer, tx - 1, ty + 1, tileSizeInBlocks0 - 1, 0);
                    }
                    else if (((tx < layer._widthInTiles0 - 1) && (xBlock == tileSizeInBlocks0 - 1)) && ((ty < layer._heightInTiles0 - 1) && (yBlock == tileSizeInBlocks0 - 1)))
                    {
                        PushBlockReferenceData(ref referenceData, layer, tx + 1, ty + 1, 0, 0);
                    }

                    UInt64 blockCompressed = 0;
                    D3DX.D3DXEncodeBC4U(ref blockCompressed, toBBCValues, referenceData);

                    layerTile._atlasBlockCompressed[xBlock + yBlock * tileSizeInBlocks0] = blockCompressed;
                }
            }

            layer.tiles[Convert.ToInt32(tileIdx)] = layerTile;
        }
        void PushBlockReferenceData(ref List<float> referenceData, RawTexContainer layer, uint tx, uint ty, uint xBlock, uint yBlock)
        {
            for (uint j = 0; j < 4; j++)
            {
                for (uint i = 0; i < 4; i++)
                {
                    uint px = (xBlock * 4 + i);
                    uint py = (yBlock * 4 + j);
                    float v = Convert.ToSingle(layer.tiles[Convert.ToInt32(tx + ty * layer._widthInTiles0)]._atlasUnCompressed[px + py * mlmask._atlasTileSize]) / 255.0f;
                    referenceData.Add(v);
                }
            }
        }
        //https://graphics.stanford.edu/~seander/bithacks.html#RoundUpPowerOf2
        uint RoundUpPowerOf2(uint v)
        {
            v--;
            v |= v >> 1;
            v |= v >> 2;
            v |= v >> 4;
            v |= v >> 8;
            v |= v >> 16;
            return ++v;
        }
        #endregion
        #region Structs
        struct RawTexContainer
        {
            public Byte[] _pixels;
            public uint _width;
            public uint _height;
            public List<Tile> tiles;
            public uint _widthShift;
            public uint _heightShift;
            public uint _widthInTiles0;
            public uint _heightInTiles0;
        }
        struct Tile
        {
            public Byte _rangeMin;
            public Byte _rangeMax;
            public Byte[] _atlasUnCompressed;
            public UInt64[] _atlasBlockCompressed;
            public uint _atlasInPosition;
        }
        struct MaskTile
        {
            public List<TileView> _layers;
        }
        struct TileView
        {
            public uint _layerIndex;
            public uint _atlasInPosition;
            public uint _layerTileIndex;
        }
        class MLMaskContainer
        {
            public RawTexContainer[] layers;

            public MaskTile[] _maskTilesHigh;
            public Dictionary<UInt64, TileView> _atlasTiles = new Dictionary<ulong, TileView>();
            public MaskTile[] _maskTilesLow;
            public uint _atlasTileSize;
            public uint _atlasWidth;
            public uint _atlasHeight;
            public uint _heightHigh;
            public uint _widthLow;
            public uint _heightInTilesHigh;
            public uint _widthInTilesLow;
            public uint _heightLow;
            public Byte[] _AtlasBuffer;
            public Byte[] _tilesBuffer;
            public uint _widthInTilesHigh;
            public uint _heightInTilesLow;
            public uint _tileSize;
            public uint _widthHigh;
            public uint _atlasTilesCount;
        }
        #endregion
    }
    #region FNV1A
    class FNV1A
    {
        public const ulong FnvHashInitial = 0xCBF29CE484222325;
        public const ulong FnvHashPrime = 0x00000100000001B3;
        public static ulong HashReadOnlySpan(ReadOnlySpan<byte> source, ulong hash = FnvHashInitial)
        {
            foreach (var b in source)
            {
                unchecked
                {
                    hash = (hash ^ b) * FnvHashPrime;
                }
            }

            return hash;
        }
    }
    #endregion

    #region DirectXTex
    class D3DX
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public struct BC4_UNORM
        {
            public float R(int offset)
            {
                uint index = GetIndex(offset);
                return DecodeFromIndex(index);
            }

            public float DecodeFromIndex(uint index)
            {
                if (index == 0)
                    return red_0 / 255.0f;
                if (index == 1)
                    return red_1 / 255.0f;
                float fred_0 = red_0 / 255.0f;
                float fred_1 = red_1 / 255.0f;

                if (red_0 > red_1)
                {
                    index--;
                    return (fred_0 * ((float)7 - index) + fred_1 * index) / 7.0f;
                }
                else
                {
                    if (index == 6)
                        return 0.0f;
                    if (index == 7)
                        return 1.0f;
                    index--;
                    return (fred_0 * ((float)5 - index) + fred_1 * index) / 5.0f;
                }
            }

            public uint GetIndex(int offset)
            {
                return (uint)(data >> (3 * offset + 16)) & 0x07;
            }

            public void SetIndex(int uOffset, int uIndex)
            {
                data &= ~((ulong)(0x07) << (3 * uOffset + 16));
                data |= ((UInt64)(uIndex) << (3 * uOffset + 16));
            }

            [FieldOffset(0)] public ulong data;

            [FieldOffset(0)] public byte red_0;
            [FieldOffset(1)] public byte red_1;

            [FieldOffset(2)] public byte index0;
            [FieldOffset(3)] public byte index1;
            [FieldOffset(4)] public byte index2;
            [FieldOffset(5)] public byte index3;
            [FieldOffset(6)] public byte index4;
            [FieldOffset(7)] public byte index5;
        }
        public static void D3DXEncodeBC4U(ref UInt64 resultantBlock, float[] refData, List<float> theTexelsU)
        {
            var pBC4 = new BC4_UNORM();

            FindEndPointsBC4U(theTexelsU, theTexelsU.Count, ref pBC4.red_0, ref pBC4.red_1);
            FindClosestUNORM(ref pBC4, refData);
            resultantBlock = pBC4.data;
        }
        static void FindEndPointsBC4U(List<float> theTexelsU, Int32 numTexels, ref Byte endpointU_0, ref Byte endpointU_1)
        {
            // The boundary of codec for signed/unsigned format
            const float MIN_NORM = 0f;
            const float MAX_NORM = 1f;

            // Find max/min of input texels
            float fBlockMax = theTexelsU[0];
            float fBlockMin = theTexelsU[0];
            for (int i = 0; i < numTexels; ++i)
            {
                if (theTexelsU[i] < fBlockMin)
                {
                    fBlockMin = theTexelsU[i];
                }
                else if (theTexelsU[i] > fBlockMax)
                {
                    fBlockMax = theTexelsU[i];
                }
            }

            //  If there are boundary values in input texels, should use 4 interpolated color values to guarantee
            //  the exact code of the boundary values.
            bool bUsing4BlockCodec = (MIN_NORM == fBlockMin || MAX_NORM == fBlockMax);

            // Using Optimize
            float fStart = 0, fEnd = 0;

            if (!bUsing4BlockCodec)
            {
                // 6 interpolated color values
                OptimizeAlpha(ref fStart, ref fEnd, theTexelsU, numTexels, 8);

                Byte iStart = Convert.ToByte(fStart * 255.0f);
                Byte iEnd = Convert.ToByte(fEnd * 255.0f);

                endpointU_0 = iEnd;
                endpointU_1 = iStart;
            }
            else
            {
                // 4 interpolated color values
                OptimizeAlpha(ref fStart, ref fEnd, theTexelsU, numTexels, 6);

                Byte iStart = Convert.ToByte(fStart * 255.0f);
                Byte iEnd = Convert.ToByte(fEnd * 255.0f);

                endpointU_1 = iEnd;
                endpointU_0 = iStart;
            }
        }
        static void OptimizeAlpha(ref float pX, ref float pY, List<float> pPoints, int numTexels, UInt32 cSteps)
        {

            float[] pC6 = { 5.0f / 5.0f, 4.0f / 5.0f, 3.0f / 5.0f, 2.0f / 5.0f, 1.0f / 5.0f, 0.0f / 5.0f };
            float[] pD6 = { 0.0f / 5.0f, 1.0f / 5.0f, 2.0f / 5.0f, 3.0f / 5.0f, 4.0f / 5.0f, 5.0f / 5.0f };
            float[] pC8 = { 7.0f / 7.0f, 6.0f / 7.0f, 5.0f / 7.0f, 4.0f / 7.0f, 3.0f / 7.0f, 2.0f / 7.0f, 1.0f / 7.0f, 0.0f / 7.0f };
            float[] pD8 = { 0.0f / 7.0f, 1.0f / 7.0f, 2.0f / 7.0f, 3.0f / 7.0f, 4.0f / 7.0f, 5.0f / 7.0f, 6.0f / 7.0f, 7.0f / 7.0f };

            float[] pC = (6 == cSteps) ? pC6 : pC8;
            float[] pD = (6 == cSteps) ? pD6 : pD8;

            float MAX_VALUE = 1.0f;
            float MIN_VALUE = 0.0f;

            // Find Min and Max points, as starting point
            float fX = MAX_VALUE;
            float fY = MIN_VALUE;

            if (8 == cSteps)
            {
                for (int iPoint = 0; iPoint < numTexels; iPoint++)
                {
                    if (pPoints[iPoint] < fX)
                        fX = pPoints[iPoint];

                    if (pPoints[iPoint] > fY)
                        fY = pPoints[iPoint];
                }
            }

            else
            {
                for (int iPoint = 0; iPoint < numTexels; iPoint++)
                {
                    if (pPoints[iPoint] < fX && pPoints[iPoint] > MIN_VALUE)
                        fX = pPoints[iPoint];

                    if (pPoints[iPoint] > fY && pPoints[iPoint] < MAX_VALUE)
                        fY = pPoints[iPoint];
                }

                if (fX == fY)
                {
                    fY = MAX_VALUE;
                }
            }

            // Use Newton's Method to find local minima of sum-of-squares error.
            float fSteps = Convert.ToSingle(cSteps - 1);

            for (int iIteration = 0; iIteration < 8; iIteration++)
            {
                float fScale;

                if ((fY - fX) < (1.0f / 256.0f))
                    break;

                fScale = fSteps / (fY - fX);

                // Calculate new steps
                float[] pSteps = new float[8];

                for (int iStep = 0; iStep < cSteps; iStep++)
                    pSteps[iStep] = pC[iStep] * fX + pD[iStep] * fY;

                if (6 == cSteps)
                {
                    pSteps[6] = MIN_VALUE;
                    pSteps[7] = MAX_VALUE;
                }

                // Evaluate function, and derivatives
                float dX = 0.0f;
                float dY = 0.0f;
                float d2X = 0.0f;
                float d2Y = 0.0f;

                for (UInt32 iPoint = 0; iPoint < numTexels; iPoint++)
                {
                    float fDot = (pPoints[(int)iPoint] - fX) * fScale;

                    UInt32 iStep;

                    if (fDot <= 0.0f)
                    {
                        // D3DX10 / D3DX11 didn't take into account the proper minimum value for the bRange (BC4S/BC5S) case
                        iStep = ((6 == cSteps) && (pPoints[(int)iPoint] <= fX * 0.5f)) ? (UInt32)6 : 0;
                    }
                    else if (fDot >= fSteps)
                    {
                        iStep = ((6 == cSteps) && (pPoints[(int)iPoint] >= (fY + 1.0f) * 0.5f)) ? 7 : (cSteps - 1);
                    }
                    else
                    {
                        iStep = (UInt32)(fDot + 0.5f);
                    }

                    if (iStep < cSteps)
                    {
                        // D3DX had this computation backwards (pPoints[iPoint] - pSteps[iStep])
                        // this fix improves RMS of the alpha component
                        float fDiff = pSteps[iStep] - pPoints[(int)iPoint];

                        dX += pC[iStep] * fDiff;
                        d2X += pC[iStep] * pC[iStep];

                        dY += pD[iStep] * fDiff;
                        d2Y += pD[iStep] * pD[iStep];
                    }
                }

                // Move endpoints
                if (d2X > 0.0f)
                    fX -= dX / d2X;

                if (d2Y > 0.0f)
                    fY -= dY / d2Y;

                if (fX > fY)
                {
                    float f = fX; fX = fY; fY = f;
                }

                if ((dX * dX < (1.0f / 64.0f)) && (dY * dY < (1.0f / 64.0f)))
                    break;
            }

            pX = (fX < MIN_VALUE) ? MIN_VALUE : (fX > MAX_VALUE) ? MAX_VALUE : fX;
            pY = (fY < MIN_VALUE) ? MIN_VALUE : (fY > MAX_VALUE) ? MAX_VALUE : fY;
        }
        static void FindClosestUNORM(ref BC4_UNORM pBC, float[] theTexelsU)
        {
            UInt32 NUM_PIXELS_PER_BLOCK = 16;
            float[] rGradient = new float[8];
            for (UInt32 i = 0; i < 8; ++i)
            {
                rGradient[i] = pBC.DecodeFromIndex(i);
            }

            for (UInt32 i = 0; i < NUM_PIXELS_PER_BLOCK; ++i)
            {
                UInt32 uBestIndex = 0;
                float fBestDelta = 100000;
                for (UInt32 uIndex = 0; uIndex < 8; uIndex++)
                {
                    float fCurrentDelta = Math.Abs(rGradient[uIndex] - theTexelsU[i]);
                    if (fCurrentDelta < fBestDelta)
                    {
                        uBestIndex = uIndex;
                        fBestDelta = fCurrentDelta;
                    }
                }
                pBC.SetIndex((int)i, (int)uBestIndex);
            }
        }
        public static void D3DXDecodeBC4U(ref float[] pColor, UInt64 pBC)
        {

            UInt32 NUM_PIXELS_PER_BLOCK = 16;
            var pBC4 = new BC4_UNORM();
            pBC4.data = pBC;
            for (int i = 0; i < NUM_PIXELS_PER_BLOCK; ++i)
            {
                pColor[i] = pBC4.R(i);
            }
        }
    }
    #endregion
}
