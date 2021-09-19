using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
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

            var (strings, imports, chunkInfoList, chunkData) = GenerateChunkData();

            foreach (var embedded in _file.EmbeddedFiles)
            {
                var tuple = ("", (CName)embedded.FileName, (ushort)8);
                if (!imports.Contains(tuple))
                {
                    imports.Add(tuple);
                }
            }

            fileHeader.objectsEnd = (uint)BaseStream.Position;

            var combinedList = new List<CName>(strings);
            combinedList.AddRange(imports.Select(x => x.Item2).ToList());

            var (stringBuffer, stringOffsets) = GenerateStringBuffer(combinedList);

            tableHeaders[0] = new CR2WTable()
            {
                offset = (uint)BaseStream.Position,
                itemCount = (uint)stringBuffer.Length,
                crc32 = Crc32Algorithm.Compute(stringBuffer)
            };

            BaseWriter.Write(stringBuffer);

            var afterHeaderPosition = CalculateHeaderLength(strings.Count, imports.Count);
            fileHeader.objectsEnd += (uint)afterHeaderPosition;

            #region Names

            tableHeaders[1].offset = (uint)BaseStream.Position;
            tableHeaders[1].itemCount = (uint)strings.Count;

            var crc = new Crc32Algorithm(false);
            foreach (var str in strings)
            {
                if (_file.MetaData.HashVersion == EHashVersion.Pre120)
                {
#pragma warning disable CS0618 // Typ oder Element ist veraltet
                    BaseStream.WriteStruct(new CR2WNameInfo { hash = str.GetOldRedHash(), offset = stringOffsets[str] }, crc);
#pragma warning restore CS0618 // Typ oder Element ist veraltet
                }
                else
                {
                    BaseStream.WriteStruct(new CR2WNameInfo { hash = str.GetRedHash(), offset = stringOffsets[str] }, crc);
                }
            }
            tableHeaders[1].crc32 = crc.HashUInt32;

            #endregion Names

            #region Imports

            if (imports.Count > 0)
            {
                tableHeaders[2].offset = (uint)BaseStream.Position;
                tableHeaders[2].itemCount = (uint)imports.Count;

                crc = new Crc32Algorithm(false);
                foreach (var import in imports)
                {
                    var entry = new CR2WImportInfo()
                    {
                        className = (ushort)strings.IndexOf(import.Item1),
                        offset = stringOffsets[import.Item2],
                        flags = import.Item3
                    };

                    BaseStream.WriteStruct(entry, crc);
                }

                tableHeaders[2].crc32 = crc.HashUInt32;
            }

            #endregion Imports

            #region Properties

            if (_file.Properties.Count < 1)
            {
                _file.Properties.Add(new CR2WProperty());
            }

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

            if (chunkInfoList.Count > 0)
            {
                tableHeaders[4].offset = (uint)BaseStream.Position;
                tableHeaders[4].itemCount = (uint)chunkInfoList.Count;

                crc = new Crc32Algorithm(false);
                foreach (var chunkInfo in chunkInfoList)
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
            var (bufferInfoList, bufferData) = GenerateBufferData();
            if (bufferInfoList.Count > 0)
            {
                tableHeaders[5].offset = (uint)BaseStream.Position;
                tableHeaders[5].itemCount = (uint)bufferInfoList.Count;

                foreach (var buffer in bufferInfoList)
                {
                    BaseStream.WriteStruct(buffer, crc);
                }
            }

            #endregion Buffers

            #region Embedded

            var (embeddedInfoList, embeddedData) = GenerateEmbeddedData(imports);
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

            BaseStream.Write(chunkData);
            fileHeader.objectsEnd = (uint)BaseStream.Position;

            if (bufferInfoList.Count > 0)
            {
                BaseStream.Position = beforeBufferTablePos;
                crc = new Crc32Algorithm(false);
                foreach (var buffer in bufferInfoList)
                {
                    var entry = buffer;
                    entry.offset += fileHeader.objectsEnd;

                    BaseStream.WriteStruct(entry, crc);
                }
                tableHeaders[5].crc32 = crc.HashUInt32;
            }
            
            BaseStream.Position = fileHeader.objectsEnd;
            BaseStream.Write(bufferData);
            fileHeader.buffersEnd = (uint)BaseStream.Position;

            fileHeader.crc32 = CalculateHeaderCRC32(fileHeader, tableHeaders);
            BaseStream.Position = headerPos;
            BaseStream.WriteStruct(fileHeader);
            BaseStream.WriteStructs(tableHeaders);

            for (int i = 0; i < chunkInfoList.Count; i++)
            {
                var newInfo = chunkInfoList[i];
                var oldInfo = _file.Debug.ChunkInfos[i];

                if ((newInfo.dataOffset + afterHeaderPosition) != oldInfo.dataOffset)
                {

                }

                if (newInfo.dataSize != oldInfo.dataSize)
                {

                }

                if (newInfo.parentID != oldInfo.parentID)
                {

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

                chunkInfoList[i] = oldInfo;
            }
        }

        #region Write Sections

        #region Buffers

        private CR2WBufferInfo WriteBuffer(CR2WWriter writer, ICR2WBuffer buffer)
        {
            var compressedBuffer = buffer.Data;

            var result = new CR2WBufferInfo
            {
                flags = buffer.Flags,
                offset = (uint)writer.BaseStream.Position,
                diskSize = (uint)compressedBuffer.Length,
                memSize = (uint)buffer.Data.Length,
                crc32 = Crc32Algorithm.Compute(compressedBuffer)
            };

            if (buffer.IsCompressed)
            {
                result.memSize = buffer.MemSize;
            }
            else
            {
                var status = OodleLZHelper.CompressBuffer(buffer.Data, out compressedBuffer);
            }
            
            writer.BaseWriter.Write(compressedBuffer);

            return result;
        }

        private (IList<CR2WBufferInfo>, byte[]) GenerateBufferData()
        {
            using var ms = new MemoryStream();
            using var writer = new CR2WWriter(ms);

            var bufferInfoList = new List<CR2WBufferInfo>();
            foreach (var buffer in _file.Buffers)
            {
                bufferInfoList.Add(WriteBuffer(writer, (ICR2WBuffer)buffer));
            }

            return (bufferInfoList, ms.ToArray());
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

            var chunkIndex = -1;
            for (int i = 0; i < _file.Chunks.Count; i++)
            {
                if (Equals(_file.Chunks[i], embeddedData.Content))
                {
                    chunkIndex = i;
                    break;
                }
            }

            if (importIndex == -1 || chunkIndex == -1)
            {
                throw new TodoException();
            }

            return new CR2WEmbeddedInfo
            {
                chunkIndex = (uint)chunkIndex,
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



        private CR2WChunkInfo WriteChunk(CR2WWriter file, IRedClass chunkData)
        {
            var redTypeName = RedReflection.GetTypeRedName(chunkData.GetType());
            var typeIndex = file.GetStringIndex(redTypeName);

            var result = new CR2WChunkInfo
            {
                className = typeIndex,
                dataOffset = (uint)file.BaseStream.Position
            };

            file.WriteClass(chunkData);

            result.dataSize = (uint)(file.BaseStream.Position - result.dataOffset);

            return result;
        }

        #endregion Write Sections

        #region Support

        private (IList<CName>, IList<(string, CName, ushort)>, List<CR2WChunkInfo>, byte[]) GenerateChunkData()
        {
            using var ms = new MemoryStream();
            using var file = new CR2WWriter(ms);

            var chunkInfoList = new List<CR2WChunkInfo>();
            for (int i = 0; i < _file.Chunks.Count; i++)
            {
                file.StartChunk(i);
                chunkInfoList.Add(WriteChunk(file, _file.Chunks[i]));
            }

            var (stringDict, importDict) = file.GenerateStringDictionary();

            for (int i = 0; i < _file.Chunks.Count; i++)
            {
                var chunkInfo = chunkInfoList[i];
                chunkInfo.className = stringDict[RedReflection.GetTypeRedName(_file.Chunks[i].GetType())];
                chunkInfoList[i] = chunkInfo;

                // TODO: Find a "better" way to determine that
                if (i != 0 || _file.Chunks[i] is worldFoliageBrush)
                {
                    var typeInfo = RedReflection.GetTypeInfo(_file.Chunks[i].GetType());
                    if (typeInfo.ChildLevel > 0)
                    {
                        SetParent(i, i, typeInfo.ChildLevel);
                    }
                }
            }

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
            file.BaseStream.Position = pos;

            return (file.StringCacheList.ToList(), file.ImportCacheList.ToList(), chunkInfoList, ms.ToArray());

            void SetParent(int chunkIndex, int parentIndex, int maxLevel = 1, int level = 0)
            {
                var targets = file.GetTargets(chunkIndex);
                foreach (var target in targets)
                {
                    var chunkInfo = chunkInfoList[target.Item2 - 1];
                    chunkInfo.parentID = (uint)(parentIndex + 1);
                    chunkInfoList[target.Item2 - 1] = chunkInfo;

                    if (level < maxLevel)
                    {
                        SetParent(target.Item2 - 1, parentIndex, maxLevel, level + 1);
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

        private int CalculateHeaderLength(int namesCount, int importsCount)
        {
            var result = BaseStream.Position;

            result += Marshal.SizeOf(typeof(CR2WNameInfo)) * namesCount;
            result += Marshal.SizeOf(typeof(CR2WImportInfo)) * importsCount;
            result += Marshal.SizeOf(typeof(CR2WPropertyInfo)) * _file.Properties.Count;
            result += Marshal.SizeOf(typeof(CR2WChunkInfo)) * _file.Chunks.Count;
            result += Marshal.SizeOf(typeof(CR2WBufferInfo)) * _file.Buffers.Count;
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
