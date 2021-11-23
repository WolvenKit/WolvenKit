using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Compression;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.IO
{
    public partial class CR2WReader
    {
        private CR2WFile _cr2wFile => (CR2WFile)_outputFile;

        public EFileReadErrorCodes ReadFile(out CR2WFile file, bool decompressBuffers = true)
        {
            _outputFile = new CR2WFile();

            #region Read Headers

            // read file header
            var id = BaseStream.ReadStruct<uint>();
            if (id != CR2WFile.MAGIC)
            {
                file = null;
                return EFileReadErrorCodes.NoCr2w;
            }

            var fileHeader = BaseStream.ReadStruct<CR2WFileHeader>();

            _cr2wFile.MetaData.Version = fileHeader.version;
            _cr2wFile.MetaData.BuildVersion = fileHeader.buildVersion;
            _cr2wFile.MetaData.ObjectsEnd = fileHeader.objectsEnd;

            if (fileHeader.version > 195 || fileHeader.version < 163)
            {
                file = null;
                return EFileReadErrorCodes.UnsupportedVersion;
            }


            // Tables [7-9] are not used in cr2w so far.
            var tableHeaders = BaseStream.ReadStructs<CR2WTable>(10);

            // read strings - block 1 (index 0)
            var stringDict = ReadStringDict(tableHeaders[0]);
            _cr2wFile.Debug.Strings = new List<CName>(_namesList);

            // read the other tables

            var nameInfoList = ReadTable<CR2WNameInfo>(tableHeaders[1]); // block 2
            var importInfoList = ReadTable<CR2WImportInfo>(tableHeaders[2]); // block 3
            var propertyInfoList = ReadTable<CR2WPropertyInfo>(tableHeaders[3]); // block 4
            var chunkInfoList = ReadTable<CR2WExportInfo>(tableHeaders[4]); // block 5
            var bufferInfoList = ReadTable<CR2WBufferInfo>(tableHeaders[5]);  // block 6
            var embeddedInfoList = ReadTable<CR2WEmbeddedInfo>(tableHeaders[6]); // block 7

            #endregion

            // use 1 as 0 is always empty
            _cr2wFile.MetaData.HashVersion = IdentifyHash(stringDict[1], nameInfoList[1].hash);
            if (_cr2wFile.MetaData.HashVersion == EHashVersion.Unknown)
            {
                throw new Exception();
            }

            #region Read Data

            _cr2wFile.Debug.NameInfos = nameInfoList;
            foreach (var nameInfo in nameInfoList)
            {
                _namesList.Add(ReadName(nameInfo, stringDict));
            }

            _cr2wFile.Debug.ImportInfos = importInfoList;
            foreach (var importInfo in importInfoList)
            {
                importsList.Add(ReadImport(importInfo, stringDict));
            }

            _cr2wFile.Debug.PropertyInfos = propertyInfoList;
            foreach (var propertyInfo in propertyInfoList)
            {
                _cr2wFile.Properties.Add(ReadProperty(propertyInfo));
            }

            if (propertyInfoList.Length > 1)
            {
                throw new TodoException();
            }

            _cr2wFile.Debug.ChunkInfos = chunkInfoList;
            foreach (var chunkInfo in chunkInfoList)
            {
                _cr2wFile.Chunks.Add(ReadChunk(chunkInfo));
            }

            _cr2wFile.Debug.BufferInfos = bufferInfoList;
            foreach (var bufferInfo in bufferInfoList)
            {
                _cr2wFile.Buffers.Add(ReadBuffer(bufferInfo, decompressBuffers));
            }

            _cr2wFile.Debug.EmbeddedInfos = embeddedInfoList;
            foreach (var embeddedInfo in embeddedInfoList)
            {
                _cr2wFile.EmbeddedFiles.Add(ReadEmbedded(embeddedInfo));
            }

            #endregion Read Data

            if (BaseStream.Position != BaseStream.Length)
            {
                throw new TodoException();
            }

            file = _cr2wFile;
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
            return new CR2WImport
            {
                ClassName = _namesList[info.className],
                DepotPath = stringDict[info.offset],
                Flags = (InternalEnums.EImportFlags)info.flags
            };
        }

        private CR2WProperty ReadProperty(CR2WPropertyInfo info)
        {
            return new CR2WProperty();
        }

        private IRedClass ReadChunk(CR2WExportInfo info)
        {
            Debug.Assert(BaseStream.Position == info.dataOffset);

            var result = RedTypeManager.Create(_namesList[info.className]);

            var startPos = BaseStream.Position;
            ReadClass(result, info.dataSize);
            var bytesRead = BaseStream.Position - startPos;

            if (bytesRead < info.dataSize)
            {
                throw new TodoException();
            }

            return result;
        }

        private RedBuffer ReadBuffer(CR2WBufferInfo info, bool decompress)
        {
            Debug.Assert(BaseStream.Position == info.offset);

            var buffer = BaseReader.ReadBytes((int)info.diskSize);
            if (info.memSize == info.diskSize)
            {
                return RedBuffer.CreateBuffer(info.flags, buffer);
            }

            var result = RedBuffer.CreateCompressedBuffer(info.flags, buffer, info.memSize);
            if (decompress)
            {
                result.Decompress();
            }

            return result;
        }

        private CR2WEmbedded ReadEmbedded(CR2WEmbeddedInfo info)
        {
            if (info.pathHash != 0)
            {
                throw new TodoException();
            }

            return new CR2WEmbedded
            {
                FileName = importsList[(int)info.importIndex - 1].DepotPath,
                Content = _cr2wFile.Chunks[(int)info.chunkIndex]
            };
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

        private T[] ReadTable<T>(CR2WTable tableHeader) where T : struct
        {
            var hash = new Crc32Algorithm(false);
            return BaseStream.ReadStructs<T>(tableHeader.itemCount, hash);
        }

        public EHashVersion IdentifyHash(CName value, uint hash)
        {
            if (value.GetRedHash() == hash)
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
