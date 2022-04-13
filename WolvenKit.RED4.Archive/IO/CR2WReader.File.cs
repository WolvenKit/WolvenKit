using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.IO
{
    public partial class CR2WReader
    {
        private CR2WFile _cr2wFile => (CR2WFile)_outputFile;
        private bool _parseBuffer;

        private readonly Dictionary<int, RedBaseClass> _chunks = new();
        private readonly Dictionary<int, RedBuffer> _buffers = new();

        private static readonly Dictionary<string, Type> _bufferReaders = new();

        static CR2WReader()
        {
            _bufferReaders.Add("appearanceAppearanceDefinition.compiledData", typeof(PackageReader));
            _bufferReaders.Add("entEntityTemplate.compiledData", typeof(PackageReader));
            _bufferReaders.Add("inkWidgetLibraryItem.packageData", typeof(PackageReader));
            _bufferReaders.Add("entEntityInstanceData.buffer", typeof(PackageReader));
            _bufferReaders.Add("gamePersistentStateDataResource.buffer", typeof(PackageReader));
            _bufferReaders.Add("meshMeshMaterialBuffer.rawData", typeof(CR2WListReader));
            _bufferReaders.Add("entEntityParametersBuffer.parameterBuffers", typeof(CR2WListReader));
            _bufferReaders.Add("animAnimDataChunk.buffer", typeof(AnimationReader));
            _bufferReaders.Add("worldNavigationTileData.tilesBuffer", typeof(TilesReader));
            _bufferReaders.Add("worldSharedDataBuffer.buffer", typeof(WorldSharedDataBufferReader));
            _bufferReaders.Add("worldStreamingSector.transforms", typeof(StreamingSectorTransformReader));
            _bufferReaders.Add("worldCollisionNode.compiledData", typeof(CollisionReader));
            _bufferReaders.Add("physicsGeometryCache.bufferTableSectors", typeof(GeometryCacheReader));
            _bufferReaders.Add("physicsGeometryCache.alwaysLoadedSectorDDB", typeof(GeometryCacheReader));
            _bufferReaders.Add("CGIDataResource.data", typeof(CGIDataReader));
        }

        public EFileReadErrorCodes ReadFileInfo(out CR2WFileInfo info)
        {
            var id = BaseStream.ReadStruct<uint>();
            if (id != CR2WFile.MAGIC)
            {
                info = null;
                return EFileReadErrorCodes.NoCr2w;
            }

            var result = new CR2WFileInfo
            {
                FileHeader = BaseStream.ReadStruct<CR2WFileHeader>()
            };

            if (result.FileHeader.version > 195 || result.FileHeader.version < 163)
            {
                info = null;
                return EFileReadErrorCodes.UnsupportedVersion;
            }

            // Tables [7-9] are not used in cr2w so far.
            var tableHeaders = BaseStream.ReadStructs<CR2WTable>(10);

            // read strings - block 1 (index 0)
            result.StringDict = ReadStringDict(tableHeaders[0]);
            if (CollectData)
            {
                foreach (var pair in result.StringDict)
                {
                    DataCollection.RawStringList.Add(pair.Value);
                }
            }

            // read the other tables

            result.NameInfo = ReadTable<CR2WNameInfo>(tableHeaders[1]); // block 2
            result.ImportInfo = ReadTable<CR2WImportInfo>(tableHeaders[2]); // block 3
            result.PropertyInfo = ReadTable<CR2WPropertyInfo>(tableHeaders[3]); // block 4
            result.ExportInfo = ReadTable<CR2WExportInfo>(tableHeaders[4]); // block 5
            result.BufferInfo = ReadTable<CR2WBufferInfo>(tableHeaders[5]);  // block 6
            result.EmbeddedInfo = ReadTable<CR2WEmbeddedInfo>(tableHeaders[6]); // block 7

            info = result;
            return EFileReadErrorCodes.NoError;
        }

        public EFileReadErrorCodes ReadFile(out CR2WFile file, bool parseBuffer = true)
        {
            var result = ReadFileInfo(out var info);
            if (result != EFileReadErrorCodes.NoError)
            {
                file = null;
                return result;
            }

            _outputFile = new CR2WFile();
            _parseBuffer = parseBuffer;

            _cr2wFile.Info = info;
            _cr2wFile.MetaData.Version = _cr2wFile.Info.FileHeader.version;
            _cr2wFile.MetaData.BuildVersion = _cr2wFile.Info.FileHeader.buildVersion;
            _cr2wFile.MetaData.ObjectsEnd = _cr2wFile.Info.FileHeader.objectsEnd;

            // use 1 as 0 is always empty
            _cr2wFile.MetaData.HashVersion = IdentifyHash(_cr2wFile.Info.StringDict[1], _cr2wFile.Info.NameInfo[1].hash);
            if (_cr2wFile.MetaData.HashVersion == EHashVersion.Unknown)
            {
                throw new Exception();
            }

            #region Read Data

            foreach (var nameInfo in _cr2wFile.Info.NameInfo)
            {
                _namesList.Add(ReadName(nameInfo, _cr2wFile.Info.StringDict));
            }

            foreach (var importInfo in _cr2wFile.Info.ImportInfo)
            {
                importsList.Add(ReadImport(importInfo, _cr2wFile.Info.StringDict));
            }

            foreach (var propertyInfo in _cr2wFile.Info.PropertyInfo)
            {
                _cr2wFile.Properties.Add(ReadProperty(propertyInfo));
            }

            if (_cr2wFile.Info.PropertyInfo.Length > 1)
            {
                throw new TodoException();
            }

            for (var i = 0; i < _cr2wFile.Info.ExportInfo.Length; i++)
            {
                var chunk = ReadChunk(_cr2wFile.Info.ExportInfo[i]);
                if (i == 0)
                {
                    _cr2wFile.RootChunk = chunk;
                }

                _chunks.Add(i, chunk);
            }

            for (var i = _chunks.Count - 1; i >= 0; i--)
            {
                if (!HandleQueue.ContainsKey(i))
                {
                    continue;
                }

                foreach (var handle in HandleQueue[i])
                {
                    handle.SetValue(_chunks[i]);
                }

                //_chunks.Remove(i);
            }

            for (var i = 0; i < _cr2wFile.Info.BufferInfo.Length; i++)
            {
                var buffer = ReadBuffer(_cr2wFile.Info.BufferInfo[i]);
                buffer.RootChunk = _cr2wFile.RootChunk;

                if (!BufferQueue.ContainsKey(i))
                {
                    throw new TodoException("Unused buffer");
                }

                foreach (var pointers in BufferQueue[i])
                {
                    foreach (var parentType in pointers.GetValue().ParentTypes)
                    {
                        buffer.ParentTypes.Add(parentType);
                    }
                    buffer.Parent = pointers.GetValue().Parent;

                    pointers.SetValue(buffer);
                }

                ParseBuffer(buffer);
            }

            foreach (var embeddedInfo in _cr2wFile.Info.EmbeddedInfo)
            {
                _cr2wFile.EmbeddedFiles.Add(ReadEmbedded(embeddedInfo));
            }

            #endregion Read Data

            //if (BaseStream.Position != BaseStream.Length)
            //{
            //    throw new TodoException();
            //}

            /*if (_chunks.Count > 1)
            {
                throw new TodoException();
            }*/

            file = _cr2wFile;
            //_cr2wFile.AttachEventHandler();

            return EFileReadErrorCodes.NoError;
        }

        #region Read Sections

        private CName ReadName(CR2WNameInfo info, Dictionary<uint, CName> stringDict)
        {
            if (!stringDict.ContainsKey(info.offset))
            {
                throw new TodoException();
            }

            return stringDict[info.offset];
        }

        private CR2WImport ReadImport(CR2WImportInfo info, IDictionary<uint, CName> stringDict)
        {
            var ret = new CR2WImport
            {
                ClassName = _namesList[info.className],
                DepotPath = stringDict[info.offset],
                Flags = (InternalEnums.EImportFlags)info.flags
            };

            if (CollectData)
            {
                DataCollection.RawStringList.Remove(ret.DepotPath);
                DataCollection.RawImportList.Add(ret.DepotPath);
            }

            return ret;
        }

        private CR2WProperty ReadProperty(CR2WPropertyInfo info) => new CR2WProperty();

        private RedBaseClass ReadChunk(CR2WExportInfo info)
        {
            Debug.Assert(BaseStream.Position == info.dataOffset);

            var result = RedTypeManager.Create(GetStringValue(info.className));

            var startPos = BaseStream.Position;
            ReadClass(result, info.dataSize);
            var bytesRead = BaseStream.Position - startPos;

            if (bytesRead != info.dataSize)
            {
                throw new TodoException($"Chunk size mismatch");
            }

            return result;
        }

        private RedBuffer ReadBuffer(CR2WBufferInfo info)
        {
            Debug.Assert(BaseStream.Position == info.offset);

            var buffer = BaseReader.ReadBytes((int)info.diskSize);
            return RedBuffer.CreateBuffer(info.flags, buffer);
        }

        private void ParseBuffer(RedBuffer buffer)
        {
            if (!_parseBuffer)
            {
                return;
            }

            if (buffer.ParentTypes.Count != 1)
            {
                return;
            }

            var parentType = buffer.ParentTypes.First();
            if (_bufferReaders.ContainsKey(parentType))
            {
                var ms = new MemoryStream(buffer.GetBytes());
                var reader = (IBufferReader)System.Activator.CreateInstance(_bufferReaders[parentType], ms);
                var baseReader = reader as Red4Reader;
                if (baseReader != null)
                {
                    baseReader.CollectData = CollectData;
                }

                reader.ReadBuffer(buffer, _cr2wFile.RootChunk.GetType());

                if (baseReader is { CollectData: true })
                {
                    DataCollection.Buffers ??= new List<DataCollection>();
                    DataCollection.Buffers.Add(baseReader.DataCollection);
                }
            }
        }

        private CR2WEmbedded ReadEmbedded(CR2WEmbeddedInfo info)
        {
            if (info.pathHash != 0)
            {
                throw new TodoException();
            }

            var result = new CR2WEmbedded
            {
                FileName = importsList[(int)info.importIndex - 1].DepotPath,
                Content = _chunks[(int)info.chunkIndex]
            };

            _chunks.Remove((int)info.chunkIndex);

            return result;
        }

        #endregion Read Sections

        #region Support

        private Dictionary<uint, CName> ReadStringDict(CR2WTable stringInfoTable)
        {
            Debug.Assert(BaseStream.Position == stringInfoTable.offset);

            var result = new Dictionary<uint, CName>();
            while (BaseStream.Position < (stringInfoTable.offset + stringInfoTable.itemCount))
            {
                result.Add((uint)BaseStream.Position - stringInfoTable.offset, _reader.ReadNullTerminatedString());
            }

            return result;
        }

        private T[] ReadTable<T>(CR2WTable tableHeader) where T : struct => BaseStream.ReadStructs<T>(tableHeader.itemCount);

        public EHashVersion IdentifyHash(CName value, uint hash)
        {
            if (value.GetShortRedHash() == hash)
            {
                return EHashVersion.Latest;
            }

#pragma warning disable CS0618 // Typ oder Element ist veraltet
            if (value.GetOldRedHash() == hash)
#pragma warning restore CS0618 // Typ oder Element ist veraltet
            {
                return EHashVersion.Pre120;
            }

            return EHashVersion.Unknown;
        }

        #endregion Support
    }
}
