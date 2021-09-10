using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Compression;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.IO
{
    public partial class CR2WReader
    {
        private CR2WFile _file;

        public EFileReadErrorCodes ReadFile(out CR2WFile file, bool decompressBuffers = true)
        {
            file = new CR2WFile();
            _file = file;

            #region Read Headers

            // read file header
            var id = BaseStream.ReadStruct<uint>();
            if (id != CR2WFile.MAGIC)
                return EFileReadErrorCodes.NoCr2w;

            var fileHeader = BaseStream.ReadStruct<CR2WFileHeader>();

            _file.Version = fileHeader.version;

            if (fileHeader.version > 195 || fileHeader.version < 163)
                return EFileReadErrorCodes.UnsupportedVersion;


            // Tables [7-9] are not used in cr2w so far.
            var tableHeaders = BaseStream.ReadStructs<CR2WTable>(10);

            // read strings - block 1 (index 0)
            var stringDict = ReadStringDict(tableHeaders[0]);
            _stringList = stringDict.Values.ToList();

            // read the other tables

            var nameInfoList = ReadTable<CR2WNameInfo>(tableHeaders[1]); // block 2
            var importInfoList = ReadTable<CR2WImportInfo>(tableHeaders[2]); // block 3
            var propertyInfoList = ReadTable<CR2WPropertyInfo>(tableHeaders[3]); // block 4
            var chunkInfoList = ReadTable<CR2WChunkInfo>(tableHeaders[4]); // block 5
            var bufferInfoList = ReadTable<CR2WBufferInfo>(tableHeaders[5]);  // block 6
            var embeddedInfoList = ReadTable<CR2WEmbeddedInfo>(tableHeaders[6]); // block 7

            #endregion

            // use 1 as 0 is always empty
            _file.HashVersion = IdentifyHash(stringDict[1], nameInfoList[1].hash);
            if (_file.HashVersion == EHashVersion.Unknown)
            {
                throw new Exception();
            }

            #region Read Data

            var namesList = new List<CName>();

            foreach (var nameInfo in nameInfoList)
            {
                namesList.Add(ReadName(nameInfo, stringDict));
            }

            foreach (var importInfo in importInfoList)
            {
                file.Imports.Add(ReadImport(importInfo, namesList, stringDict));
            }

            foreach (var propertyInfo in propertyInfoList)
            {
                file.Properties.Add(ReadProperty(propertyInfo));
            }

            if (propertyInfoList.Length > 1)
            {
                throw new TodoException();
            }

            foreach (var chunkInfo in chunkInfoList)
            {
                file.Chunks.Add(ReadChunk(chunkInfo, namesList));
            }

            foreach (var bufferInfo in bufferInfoList)
            {
                file.Buffers.Add(ReadBuffer(bufferInfo, decompressBuffers));
            }

            foreach (var embeddedInfo in embeddedInfoList)
            {
                file.Embedded.Add(ReadEmbedded(embeddedInfo));
            }

            #endregion Read Data

            if (BaseStream.Position != BaseStream.Length)
            {
                throw new TodoException();
            }

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

        private CR2WImport ReadImport(CR2WImportInfo info, IList<CName> namesList, IDictionary<uint, CName> stringDict)
        {
            return new CR2WImport
            {
                ClassName = namesList[info.className],
                DepotPath = stringDict[info.offset],
                Flags = info.flags
            };
        }

        private CR2WProperty ReadProperty(CR2WPropertyInfo info)
        {
            return new CR2WProperty();
        }

        private IRedClass ReadChunk(CR2WChunkInfo info, IList<CName> namesList)
        {
            Debug.Assert(BaseStream.Position == info.dataOffset);

            var result = RedTypeManager.Create(namesList[info.className]);

            var startPos = BaseStream.Position;
            if (result is AreaShapeOutline)
            {
                ((IRedAppendix)result).Read(this, info.dataSize);
            }
            else
            {
                ReadClass(result, info.dataSize);
            }

            var bytesRead = BaseStream.Position - startPos;

            if (bytesRead < info.dataSize)
            {
                throw new TodoException();
            }

            return result;
        }

        private CR2WBuffer ReadBuffer(CR2WBufferInfo info, bool decompress)
        {
            Debug.Assert(BaseStream.Position == info.offset);

            var result = new CR2WBuffer();

            result.Flags = info.flags;

            var buffer = BaseReader.ReadBytes((int)info.diskSize);
            if (info.memSize == info.diskSize)
            {
                result.Data = buffer;
                return result;
            }

            if (!decompress)
            {
                result.Data = buffer;

                result.IsCompressed = true;
                result.MemSize = info.memSize;

                return result;
            }

            OodleLZHelper.DecompressBuffer(buffer, out var decompressedBuffer);
            result.Data = decompressedBuffer;
            return result;
        }

        private CR2WEmbedded ReadEmbedded(CR2WEmbeddedInfo info)
        {
            return new CR2WEmbedded
            {
                ImportPath = _file.Imports[(int)info.importIndex - 1].DepotPath,
                Export = _file.Chunks[(int)info.chunkIndex]
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
                result.Add((uint)BaseStream.Position - stringInfoTable.offset, ReadNullTerminatedString());
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

            if (value.GetOldRedHash() == hash)
            {
                return EHashVersion.Pre120;
            }

            return EHashVersion.Unknown;
        }

        #endregion Support
    }
}
