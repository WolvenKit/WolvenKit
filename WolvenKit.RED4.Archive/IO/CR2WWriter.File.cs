using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Compression;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.IO
{
    public partial class CR2WWriter
    {
        private CR2WFile _file;

        public void WriteFile(CR2WFile file)
        {
            _file = file;

            BaseStream.WriteStruct(CR2WFile.MAGIC);

            var fileHeader = new CR2WFileHeader { version = _file.MetaData.Version, buildVersion = _file.MetaData.BuildVersion, numChunks = 6 };
            var tableHeaders = new CR2WTable[10];

            var headerPos = BaseStream.Position;
            // Write empty header, fill it later
            BaseStream.WriteStruct(fileHeader);
            BaseStream.WriteStructs(tableHeaders);

            Debug.Assert(BaseStream.Position == 160);

            var dataCollection = GenerateData();

            foreach (var embedded in _file.EmbeddedFiles)
            {
                var tuple = ("", (CName)embedded.FileName, (ushort)8);
                if (!dataCollection.ImportList.Contains(tuple))
                {
                    dataCollection.ImportList.Add(tuple);
                }
            }

            fileHeader.objectsEnd = (uint)BaseStream.Position;

            var combinedList = new List<CName>(dataCollection.StringList);
            combinedList.AddRange(dataCollection.ImportList.Select(x => x.Item2).ToList());

            var (stringBuffer, stringOffsets) = GenerateStringBuffer(combinedList);

            tableHeaders[0] = new CR2WTable()
            {
                offset = (uint)BaseStream.Position,
                itemCount = (uint)stringBuffer.Length,
                crc32 = Crc32Algorithm.Compute(stringBuffer)
            };

            BaseWriter.Write(stringBuffer);

            if (_file.Properties.Count < 1)
            {
                _file.Properties.Add(new CR2WProperty());
            }

            var afterHeaderPosition = CalculateHeaderLength(dataCollection);
            fileHeader.objectsEnd += (uint)afterHeaderPosition;

            #region Names

            tableHeaders[1].offset = (uint)BaseStream.Position;
            tableHeaders[1].itemCount = (uint)dataCollection.StringList.Count;

            var crc = new Crc32Algorithm(false);
            foreach (var str in dataCollection.StringList)
            {
                if (_file.MetaData.HashVersion == EHashVersion.Pre120)
                {
#pragma warning disable CS0618 // Typ oder Element ist veraltet
                    BaseStream.WriteStruct(new CR2WNameInfo { hash = str.GetOldRedHash(), offset = stringOffsets[str] }, crc);
#pragma warning restore CS0618 // Typ oder Element ist veraltet
                }
                else
                {
                    BaseStream.WriteStruct(new CR2WNameInfo { hash = str.GetShortRedHash(), offset = stringOffsets[str] }, crc);
                }
            }
            tableHeaders[1].crc32 = crc.HashUInt32;

            #endregion Names

            #region Imports

            if (dataCollection.ImportList.Count > 0)
            {
                tableHeaders[2].offset = (uint)BaseStream.Position;
                tableHeaders[2].itemCount = (uint)dataCollection.ImportList.Count;

                crc = new Crc32Algorithm(false);
                foreach (var import in dataCollection.ImportList)
                {
                    var entry = new CR2WImportInfo()
                    {
                        className = (ushort)dataCollection.StringList.IndexOf(import.Item1),
                        offset = stringOffsets[import.Item2],
                        flags = import.Item3
                    };

                    BaseStream.WriteStruct(entry, crc);
                }

                tableHeaders[2].crc32 = crc.HashUInt32;
            }

            #endregion Imports

            #region Properties

            tableHeaders[3].offset = (uint)BaseStream.Position;
            tableHeaders[3].itemCount = (uint)_file.Properties.Count;

            crc = new Crc32Algorithm(false);
            foreach (var property in _file.Properties)
            {
                BaseStream.WriteStruct(new CR2WPropertyInfo(), crc);
            }

            tableHeaders[3].crc32 = crc.HashUInt32;

            #endregion

            #region Chunks

            if (dataCollection.ChunkInfoList.Count > 0)
            {
                tableHeaders[4].offset = (uint)BaseStream.Position;
                tableHeaders[4].itemCount = (uint)dataCollection.ChunkInfoList.Count;

                crc = new Crc32Algorithm(false);
                foreach (var chunkInfo in dataCollection.ChunkInfoList)
                {
                    var entry = chunkInfo;
                    entry.dataOffset += (uint)afterHeaderPosition;

                    BaseStream.WriteStruct(entry, crc);
                }
                tableHeaders[4].crc32 = crc.HashUInt32;
            }

            #endregion Chunks

            #region Buffers

            var beforeBufferTablePos = BaseStream.Position;
            if (dataCollection.BufferInfoList.Count > 0)
            {
                tableHeaders[5].offset = (uint)BaseStream.Position;
                tableHeaders[5].itemCount = (uint)dataCollection.BufferInfoList.Count;

                foreach (var buffer in dataCollection.BufferInfoList)
                {
                    BaseStream.WriteStruct(buffer, crc);
                }
            }

            #endregion Buffers

            #region Embedded

            var (embeddedInfoList, embeddedData) = GenerateEmbeddedData(dataCollection.ImportList);
            if (embeddedInfoList.Count > 0)
            {
                tableHeaders[6].offset = (uint)BaseStream.Position;
                tableHeaders[6].itemCount = (uint)embeddedInfoList.Count;

                crc = new Crc32Algorithm(false);
                foreach (var embedded in embeddedInfoList)
                {
                    BaseStream.WriteStruct(embedded, crc);
                }

                tableHeaders[6].crc32 = crc.HashUInt32;
            }

            #endregion Embedded

            Debug.Assert(BaseStream.Position == afterHeaderPosition);

            BaseStream.Write(dataCollection.ChunkData);
            fileHeader.objectsEnd = (uint)BaseStream.Position;

            if (dataCollection.BufferInfoList.Count > 0)
            {
                BaseStream.Position = beforeBufferTablePos;
                crc = new Crc32Algorithm(false);
                foreach (var buffer in dataCollection.BufferInfoList)
                {
                    var entry = buffer;
                    entry.offset += fileHeader.objectsEnd;

                    BaseStream.WriteStruct(entry, crc);
                }
                tableHeaders[5].crc32 = crc.HashUInt32;
            }

            BaseStream.Position = fileHeader.objectsEnd;
            BaseStream.Write(dataCollection.BufferData);
            fileHeader.buffersEnd = (uint)BaseStream.Position;

            fileHeader.crc32 = CalculateHeaderCRC32(fileHeader, tableHeaders);
            BaseStream.Position = headerPos;
            BaseStream.WriteStruct(fileHeader);
            BaseStream.WriteStructs(tableHeaders);

            /*for (int i = 0; i < dataCollection.ChunkInfoList.Count; i++)
            {
                var newInfo = dataCollection.ChunkInfoList[i];
                var oldInfo = _file.Debug.ChunkInfos[i];

                if ((newInfo.dataOffset + afterHeaderPosition) != oldInfo.dataOffset)
                {

                }

                if (newInfo.dataSize != oldInfo.dataSize)
                {

                }

                if (newInfo.parentID != oldInfo.parentID)
                {
                    throw new TodoException("Invalid parent id");
                }

                if (newInfo.className != oldInfo.className)
                {

                }

                if (newInfo.objectFlags != oldInfo.objectFlags)
                {

                }

                if (newInfo.template != oldInfo.template)
                {

                }

                dataCollection.ChunkInfoList[i] = oldInfo;
            }*/
        }

        #region Write Sections

        #region Buffers

        private CR2WBufferInfo WriteBuffer(BinaryWriter writer, RedBuffer buffer)
        {
            if (buffer.Data is Package04 p4)
            {
                using var ms = new MemoryStream();
                using var packageWriter = new PackageWriter(ms);

                packageWriter.WritePackage(p4);

                var newData = ms.ToArray();

                /*var oldData = buffer.GetBytes();
                if (!oldData.SequenceEqual(newData))
                {
                    File.WriteAllBytes(@"C:\Dev\C77\Buffer\OldBuffer.bin", oldData);
                    File.WriteAllBytes(@"C:\Dev\C77\Buffer\NewBuffer.bin", newData);
                }*/

                buffer.SetBytes(newData);
            }

            var result = new CR2WBufferInfo
            {
                flags = buffer.Flags,
                offset = (uint)writer.BaseStream.Position,
                memSize = buffer.MemSize
            };

            writer.Write(buffer.Bytes);

            result.diskSize = (uint)buffer.Bytes.Length;
            result.crc32 = Crc32Algorithm.Compute(buffer.Bytes);

            return result;
        }

        #endregion Buffers

        #region Embedded

        private CR2WEmbeddedInfo WriteEmbedded(CR2WWriter writer, ICR2WEmbeddedFile embeddedData, IList<(string, CName, ushort)> importsList)
        {
            var importIndex = -1;
            for (int i = 0; i < importsList.Count; i++)
            {
                if (importsList[i].Item2 == embeddedData.FileName)
                {
                    importIndex = i + 1;
                    break;
                }
            }

            if (importIndex == -1)
            {
                throw new TodoException();
            }

            return new CR2WEmbeddedInfo
            {
                chunkIndex = (uint)_chunkInfos[(RedBaseClass)embeddedData.Content].Id,
                importIndex = (uint)importIndex,
                pathHash = 0
            };
        }

        private (List<CR2WEmbeddedInfo>, byte[]) GenerateEmbeddedData(IList<(string, CName, ushort)> importsList)
        {
            using var ms = new MemoryStream();
            using var writer = new CR2WWriter(ms);

            var embeddedInfoList = new List<CR2WEmbeddedInfo>();
            foreach (var embedded in _file.EmbeddedFiles)
            {
                embeddedInfoList.Add(WriteEmbedded(writer, embedded, importsList));
            }

            return (embeddedInfoList, ms.ToArray());
        }

        #endregion Embedded

        private List<IRedClass> _chunks = new();

        private CR2WExportInfo WriteChunk(CR2WWriter file, IRedClass chunkData)
        {
            var tmpQueue = file.ChunkQueue;
            file.ChunkQueue = new LinkedList<RedBaseClass>();

            var redTypeName = RedReflection.GetTypeRedName(chunkData.GetType());
            var typeIndex = file.GetStringIndex(redTypeName);

            var result = new CR2WExportInfo
            {
                className = typeIndex,
                dataOffset = (uint)file.BaseStream.Position
            };

            file.WriteClass(chunkData);

            result.dataSize = (uint)(file.BaseStream.Position - result.dataOffset);

            foreach (var redClass in tmpQueue)
            {
                file.ChunkQueue.AddLast(redClass);
            }

            return result;
        }

        #endregion Write Sections

        #region Support

        private class DataCollection
        {
            public List<CName> StringList { get; set; }
            public List<(string, CName, ushort)> ImportList { get; set; }

            public List<CR2WExportInfo> ChunkInfoList { get; set; }
            public byte[] ChunkData { get; set; }

            public List<CR2WBufferInfo> BufferInfoList { get; set; }
            public byte[] BufferData { get; set; }
        }

        private DataCollection GenerateData()
        {
            var result = new DataCollection();

            using var ms = new MemoryStream();
            using var file = new CR2WWriter(ms);

            file._chunkInfos = _chunkInfos;

            var chunkCounter = 0;
            var chunkInfoList = new List<CR2WExportInfo>();
            var chunkClassNames = new List<string>();

            var bufferInfoList = new List<CR2WBufferInfo>();

            InternalWriteChunks((RedBaseClass)_file.RootChunk);
            foreach (var embeddedFile in _file.EmbeddedFiles)
            {
                InternalWriteChunks((RedBaseClass)embeddedFile.Content);
            }

            void InternalWriteChunks(RedBaseClass rootChunk)
            {
                file.ChunkQueue.AddFirst(rootChunk);
                while (file.ChunkQueue.Count > 0)
                {
                    var chunk = file.ChunkQueue.First.Value;
                    file.ChunkQueue.RemoveFirst();

                    if (!_chunkInfos.ContainsKey(chunk))
                    {
                        _chunkInfos.Add(chunk, new ChunkInfo());
                    }

                    if (_chunkInfos[chunk].Id != -1)
                    {
                        continue;
                    }

                    chunkClassNames.Add(RedReflection.GetTypeRedName(chunk.GetType()));

                    _chunkInfos[chunk].Id = chunkCounter;
                    file.StartChunk(chunk);
                    chunkInfoList.Add(WriteChunk(file, chunk));
                    _chunks.Add(chunk);

                    var guid = _chunkInfos[chunk].Guid;
                    if (guid != Guid.Empty && file.ChunkReferences.ContainsKey(guid))
                    {
                        var startPos = file.BaseStream.Position;
                        foreach (var (position, offset) in file.ChunkReferences[guid])
                        {
                            file.BaseStream.Position = position;
                            file.BaseWriter.Write(_chunkInfos[chunk].Id + offset);
                        }
                        file.BaseStream.Position = startPos;
                    }

                    chunkCounter++;
                }
            }

            var (stringDict, importDict) = file.GenerateStringDictionary();
            result.StringList = file.StringCacheList.ToList();
            result.ImportList = file.ImportCacheList.ToList();
            
            for (int i = 0; i < chunkInfoList.Count; i++)
            {
                var chunkInfo = chunkInfoList[i];
                chunkInfo.className = stringDict[chunkClassNames[i]];
                chunkInfoList[i] = chunkInfo;
            }

            if (_file.RootChunk is worldFoliageBrush)
            {
                SetParent(0);
            }

            foreach (var embeddedFile in _file.EmbeddedFiles)
            {
                var typeInfo = RedReflection.GetTypeInfo(((RedBaseClass)embeddedFile.Content).GetType());
                SetParent(_chunkInfos[(RedBaseClass)embeddedFile.Content].Id, maxDepth: typeInfo.ChildLevel);
            }

            var ms2 = new MemoryStream();
            var bw = new BinaryWriter(ms2);
            foreach (var redBuffer in file.BufferCacheList.ToList())
            {
                bufferInfoList.Add(WriteBuffer(bw, redBuffer));
            }

            result.BufferInfoList = bufferInfoList;
            result.BufferData = ms2.ToArray();

            var pos = file.BaseStream.Position;
            foreach (var kvp in file.CNameRef)
            {
                file.BaseStream.Position = kvp.Key;
                var index = stringDict[kvp.Value];
                file.BaseWriter.Write(index);
            }
            foreach (var kvp in file.ImportRef)
            {
                file.BaseStream.Position = kvp.Key;
                var index = (ushort)(importDict[kvp.Value] + 1);
                file.BaseWriter.Write(index);
            }

            var bufferDict = file.BufferCacheList.ToDictionary();
            foreach (var kvp in file.BufferRef)
            {
                file.BaseStream.Position = kvp.Key;
                var index = (ushort)(bufferDict[kvp.Value] + 1);
                file.BaseWriter.Write(index);
            }
            file.BaseStream.Position = pos;

            result.ChunkInfoList = chunkInfoList;
            result.ChunkData = ms.ToArray();

            return result;

            void SetParent(int currentIndex, int parent = -1, int depth = 0, int maxDepth = 1)
            {
                if (parent == -1)
                {
                    parent = currentIndex + 1;
                }

                foreach (var guid in file.ChildChunks[currentIndex])
                {
                    var child = file._chunkGuidToId[guid];
                    var chunkInfo = chunkInfoList[child];
                    chunkInfo.parentID = (uint)parent;
                    chunkInfoList[child] = chunkInfo;

                    if (depth < maxDepth)
                    {
                        SetParent(child, parent, depth + 1, maxDepth);
                    }
                }
            }
        }

        private (byte[], Dictionary<CName, uint>) GenerateStringBuffer(List<CName> strings, Encoding encoding = null)
        {
            encoding ??= Encoding.UTF8;

            var offsetDict = new Dictionary<CName, uint>();
            var bytes = new List<byte>();
            foreach (var str in strings)
            {
                offsetDict.Add(str, (uint)bytes.Count);
                bytes.AddRange(encoding.GetBytes(str));
                bytes.Add(0);
            }
            return (bytes.ToArray(), offsetDict);
        }

        private int CalculateHeaderLength(DataCollection dataCollection)
        {
            var result = BaseStream.Position;

            result += Marshal.SizeOf(typeof(CR2WNameInfo)) * dataCollection.StringList.Count;
            result += Marshal.SizeOf(typeof(CR2WImportInfo)) * dataCollection.ImportList.Count;
            result += Marshal.SizeOf(typeof(CR2WPropertyInfo)) * _file.Properties.Count;
            result += Marshal.SizeOf(typeof(CR2WExportInfo)) * dataCollection.ChunkInfoList.Count;
            result += Marshal.SizeOf(typeof(CR2WBufferInfo)) * dataCollection.BufferInfoList.Count;
            result += Marshal.SizeOf(typeof(CR2WEmbeddedInfo)) * _file.EmbeddedFiles.Count;

            return (int)result;
        }

        public uint CalculateHeaderCRC32(CR2WFileHeader fileHeader, CR2WTable[] tableHeaders)
        {
            var hash = new Crc32Algorithm(false);
            hash.Append(BitConverter.GetBytes(CR2WFile.MAGIC));
            hash.Append(BitConverter.GetBytes(fileHeader.version));
            hash.Append(BitConverter.GetBytes(fileHeader.flags));
            hash.Append(BitConverter.GetBytes(fileHeader.timeStamp));
            hash.Append(BitConverter.GetBytes(fileHeader.buildVersion));
            hash.Append(BitConverter.GetBytes(fileHeader.objectsEnd));
            hash.Append(BitConverter.GetBytes(fileHeader.buffersEnd));
            hash.Append(BitConverter.GetBytes(CR2WFile.DEADBEEF));
            hash.Append(BitConverter.GetBytes(fileHeader.numChunks));
            foreach (var h in tableHeaders)
            {
                hash.Append(BitConverter.GetBytes(h.offset));
                hash.Append(BitConverter.GetBytes(h.itemCount));
                hash.Append(BitConverter.GetBytes(h.crc32));
            }
            return hash.HashUInt32;
        }

        #endregion Support
    }
}
