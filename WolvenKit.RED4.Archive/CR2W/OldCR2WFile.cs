using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive.Extensions;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.Archive.CR2W
{
    /*public class OldCR2WFile
    {
        public const uint MAGIC = 0x57325243; // "W2RC"
        public const uint DEADBEEF = 0xDEADBEEF;


        public string FileName { get; set; }
        

        public List<ICR2WName> Names { get; private set; }
        public List<ICR2WImport> Imports { get; private set; }
        public List<ICR2WProperty> Properties { get; private set; }
        public List<ICR2WChunk> Chunks { get; private set; }
        public List<ICR2WBuffer> Buffers { get; private set; }
        public List<ICR2WEmbedded> Embedded { get; private set; }


        public static Dictionary<string, List<KeyValuePair<int, int>>> Appendix { get; set; } = new();


        public OldCR2WFile()
        {
            Names = new List<ICR2WName>();              //block 2
            Imports = new List<ICR2WImport>();          //block 3
            Properties = new List<ICR2WProperty>();     //block 4
            Chunks = new List<ICR2WChunk>();            //block 5
            Buffers = new List<ICR2WBuffer>();          //block 6
            Embedded = new List<ICR2WEmbedded>();       //block 7
        }

        #region Read

        public (List<ICR2WImport>, bool, CR2WBufferInfo[]) ReadHeaders(BinaryReader file)
        {
            #region Read Headers
            // read file header
            var id = file.BaseStream.ReadStruct<uint>();
            if (id != MAGIC)
                throw new FormatException($"Not a CR2W file, Magic read as 0x{id:X8}");

            var fileHeader = file.BaseStream.ReadStruct<CR2WFileHeader>();

            //TODO: CP77


            if (fileHeader.version > 195 || fileHeader.version < 163)
                throw new FormatException($"Unknown Version {fileHeader.version}. Supported versions: 159 - 163.");

            //var dt = new CDateTime(m_fileheader.timeStamp, null, "");

            var tableHeaders = file.BaseStream.ReadStructs<CR2WTable>(10);
            //m_hasInternalBuffer = m_fileheader.bufferSize > m_fileheader.fileSize;

            // read strings
            m_strings = ReadStringsBuffer(file.BaseStream);

            // read tables
            var cnameInfoList = ReadTable<CR2WNameInfo>(file.BaseStream, 1); // block 2
            var importInfoList = ReadTable<CR2WImportInfo>(file.BaseStream, 2); // block 3
            var propertyInfoList = ReadTable<CR2WPropertyInfo>(file.BaseStream, 3); // block 4
            var chunkInfoList = ReadTable<CR2WChunkInfo>(file.BaseStream, 3); // block 5
            var bufferInfoList = ReadTable<CR2WBufferInfo>(file.BaseStream, 5);  // block 6
            var embeddedInfoList = ReadTable<CR2WEmbeddedInfo>(file.BaseStream, 6); // block 7

            #endregion

            IdentifyHash();

            return (Imports, false, bufferInfoList);
        }

        public EFileReadErrorCodes Read(byte[] data)
        {
            using var ms = new MemoryStream(data);
            using var br = new BinaryReader(ms);
            return Read(br);
        }

        public async Task<EFileReadErrorCodes> ReadAsync(byte[] data)
        {
            await using var ms = new MemoryStream(data);
            using var br = new BinaryReader(ms);
            return await Task.Run(() => Read(br));
        }

        #endregion Read

        #region Helper

        

        #endregion Helper

        /// <summary>
        /// Reads a Cr2wFile from a stream
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public EFileReadErrorCodes Read(Stream stream)
        {
            using var br = new CR2WReader(stream, this);
            return Read(br);
        }

        /// <summary>
        /// Reads a Cr2wFile from a BinaryReader stream
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public EFileReadErrorCodes Read(BinaryReader reader)
        {
            using var br = new CR2WReader(reader, this);
            return Read(br);
        }

        /// <summary>
        /// Reads a Cr2wFile from a Red4ReaderExt stream
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public EFileReadErrorCodes Read(CR2WReader file)
        {
            

            return EFileReadErrorCodes.NoError;
        }

        private IList<CName> ReadStringList(CR2WReader reader, CR2WTable stringInfoTable)
        {
            Debug.Assert(reader.Position == stringInfoTable.offset);

            var result = new List<CName>();
            while (reader.Position < (stringInfoTable.offset + stringInfoTable.itemCount))
            {
                result.Add(reader.ReadNullTerminatedString());
            }

            return result;
        }

        private byte[] ReadStringsBuffer(Stream stream)
        {
            var m_strings_size = m_tableheaders[0].itemCount;

            var m_temp = new byte[m_strings_size];
            stream.Read(m_temp, 0, m_temp.Length);


            uint offset = 0;
            var tempstring = new List<byte>();
            for (uint i = 0; i < m_strings_size; i++)
            {
                byte b = m_temp[i];
                if (b == 0)
                {
                    var text = Encoding.GetEncoding("iso-8859-1").GetString(tempstring.ToArray());
                    StringDictionary.Add(offset, text);
                    tempstring.Clear();
                    offset = i + 1;
                }
                else
                {
                    tempstring.Add(b);
                }
            }

            return m_temp;
        }

        private T[] ReadTable<T>(Stream stream, int index) where T : struct
        {
            //stream.Seek(m_tableheaders[index].offset, SeekOrigin.Begin);

            var hash = new Crc32Algorithm(false);
            var table = stream.ReadStructs<T>(m_tableheaders[index].itemCount, hash);

            return table;
        }

        public void Write(Stream stream)
        {
            using var bw = new CR2WWriter(stream, Encoding.UTF8, true, this);
            Write(bw);
        }

        public void Write(CR2WWriter file)
        {
            file.BaseStream.WriteStruct(MAGIC);

            var fileHeader = new CR2WFileHeader {version = 195, numChunks = 6};
            var tableHeaders = new CR2WTable[10];

            var headerPos = file.BaseStream.Position;
            // Write empty header, fill it later
            file.BaseStream.WriteStruct<CR2WFileHeader>(fileHeader);
            file.BaseStream.WriteStructs<CR2WTable>(tableHeaders);

            Debug.Assert(file.BaseStream.Position == 160);

            using var ms = new MemoryStream();
            using var dataWriter = new CR2WWriter(ms, this);

            var (strings, imports) = GenerateChunkData(dataWriter);

            fileHeader.objectsEnd = (uint)file.Position;

            var combinedList = strings.Cast<string>().ToList();
            combinedList.AddRange(imports.Select(x => x.Item2).ToList());

            var (stringBuffer, stringOffsets) = GenerateStringBuffer(combinedList);

            tableHeaders[0] = new CR2WTable()
            {
                offset = (uint)file.BaseStream.Position,
                itemCount = (uint)stringBuffer.Length,
                crc32 = Crc32Algorithm.Compute(stringBuffer)
            };

            file.BaseWriter.Write(stringBuffer);

            var afterHeaderPosition = CalculateHeaderLength(file.Position);
            fileHeader.objectsEnd += (uint)afterHeaderPosition;

            #region Names

            tableHeaders[1].offset = (uint)file.BaseStream.Position;
            tableHeaders[1].itemCount = (uint)strings.Count;

            uint offset = 0;
            var crc = new Crc32Algorithm(false);

            foreach (var str in strings)
            {
                file.BaseStream.WriteStruct(new CR2WNameInfo{hash = str.GetRedHash(), offset = offset}, crc);

                offset += (uint)(str.Length + 1);
            }

            tableHeaders[1].crc32 = crc.HashUInt32;

            #endregion Names

            #region Imports

            if (imports.Count > 0)
            {
                tableHeaders[2].offset = (uint)file.BaseStream.Position;
                tableHeaders[2].itemCount = (uint)imports.Count;

                crc = new Crc32Algorithm(false);
                foreach (var import in imports)
                {
                    var entry = new CR2WImport()
                    {
                        className = (ushort)strings.IndexOf(import.Item1),
                        depotPath = (uint)stringOffsets[combinedList.IndexOf(import.Item2)],
                        flags = import.Item3
                    };

                    file.BaseStream.WriteStruct(entry, crc);
                }

                tableHeaders[2].crc32 = crc.HashUInt32;
            }

            #endregion Imports

            #region Properties

            if (Properties.Count < 1)
            {
                Properties.Add(new CR2WPropertyWrapper(new CR2WProperty()));
            }

            tableHeaders[3].offset = (uint)file.BaseStream.Position;
            tableHeaders[3].itemCount = (uint)Properties.Count;

            crc = new Crc32Algorithm(false);
            foreach (var property in Properties)
            {
                file.BaseStream.WriteStruct(property.Property, crc);
            }

            tableHeaders[3].crc32 = crc.HashUInt32;

            #endregion

            #region Chunks

            var beforeChunkTablePos = file.BaseStream.Position;

            if (Chunks.Count > 0)
            {
                tableHeaders[4].offset = (uint)file.BaseStream.Position;
                tableHeaders[4].itemCount = (uint)Chunks.Count;

                foreach (var chunk in Chunks)
                {
                    file.BaseStream.WriteStruct(new CR2WExport());
                }
            }

            #endregion Chunks

            #region Buffers

            if (Buffers.Count > 0)
            {
                tableHeaders[5].offset = (uint)file.BaseStream.Position;
                tableHeaders[5].itemCount = (uint)Buffers.Count;

                crc = new Crc32Algorithm(false);
                foreach (var buffer in Buffers)
                {
                    var info = buffer.WriteData(dataWriter);
                    info.offset += (uint)afterHeaderPosition;

                    file.BaseStream.WriteStruct(info, crc);
                }
                tableHeaders[5].crc32 = crc.HashUInt32;
            }
            fileHeader.buffersEnd += (uint)file.Position;

            #endregion Buffers

            #region Embedded

            if (Embedded.Count > 0)
            {
                tableHeaders[6].offset = (uint)file.BaseStream.Position;
                tableHeaders[6].itemCount = (uint)Embedded.Count;

                crc = new Crc32Algorithm(false);
                foreach (var embedded in Embedded)
                {
                    var info = embedded.WriteData(dataWriter);

                    file.BaseStream.WriteStruct(info, crc);
                }

                tableHeaders[6].crc32 = crc.HashUInt32;
            }

            #endregion Embedded

            Debug.Assert(file.Position == afterHeaderPosition);

            var data = ms.ToArray();
            file.BaseStream.Write(data, 0, data.Length);

            file.BaseStream.Position = beforeChunkTablePos;
            crc = new Crc32Algorithm(false);
            foreach (CR2WExportWrapper chunk in Chunks)
            {
                chunk.NewExport.dataOffset += (uint)afterHeaderPosition;
                file.BaseStream.WriteStruct(chunk.NewExport, crc);
            }
            tableHeaders[4].crc32 = crc.HashUInt32;

            fileHeader.crc32 = CalculateHeaderCRC32(fileHeader, tableHeaders);
            file.BaseStream.Position = headerPos;
            file.BaseStream.WriteStruct(fileHeader);
            file.BaseStream.WriteStructs(tableHeaders);
        }

        private int CalculateHeaderLength(int currentPosition)
        {
            var result = currentPosition;

            result += Marshal.SizeOf(typeof(CR2WName)) * Names.Count;
            result += Marshal.SizeOf(typeof(CR2WImport)) * Imports.Count;
            result += Marshal.SizeOf(typeof(CR2WProperty)) * Properties.Count;
            result += Marshal.SizeOf(typeof(CR2WExport)) * Chunks.Count;
            result += Marshal.SizeOf(typeof(CR2WBufferInfo)) * Buffers.Count;
            result += Marshal.SizeOf(typeof(CR2WEmbedded)) * Embedded.Count;

            return result;
        }

        public uint CalculateHeaderCRC32(CR2WFileHeader fileHeader, CR2WTable[] tableHeaders)
        {
            var hash = new Crc32Algorithm(false);
            hash.Append(BitConverter.GetBytes(MAGIC));
            hash.Append(BitConverter.GetBytes(fileHeader.version));
            hash.Append(BitConverter.GetBytes(fileHeader.flags));
            hash.Append(BitConverter.GetBytes(fileHeader.timeStamp));
            hash.Append(BitConverter.GetBytes(fileHeader.buildVersion));
            hash.Append(BitConverter.GetBytes(fileHeader.objectsEnd));
            hash.Append(BitConverter.GetBytes(fileHeader.buffersEnd));
            hash.Append(BitConverter.GetBytes(DEADBEEF));
            hash.Append(BitConverter.GetBytes(fileHeader.numChunks));
            foreach (var h in tableHeaders)
            {
                hash.Append(BitConverter.GetBytes(h.offset));
                hash.Append(BitConverter.GetBytes(h.itemCount));
                hash.Append(BitConverter.GetBytes(h.crc32));
            }
            return hash.HashUInt32;
        }

        private (List<CName> strings, List<(string, string, ushort)> imports) GenerateChunkData(CR2WWriter file)
        {
            for (int i = 0; i < Chunks.Count; i++)
            {
                file.StartChunk(i);
                Chunks[i].WriteData(file);
            }

            var (stringDict, importDict) = file.GenerateStringDictionary();

            for (int i = 0; i < Chunks.Count; i++)
            {
                ((CR2WExportWrapper)Chunks[i]).NewExport.className = stringDict[RedReflection.GetTypeRedName(Chunks[i].NewData.GetType())];
                if (Chunks[i].NewData is CMesh mesh)
                {
                    SetParent(i, i);
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
                ushort index = (ushort)(importDict[kvp.Value] + 1);
                file.BaseWriter.Write(index);
            }
            file.BaseStream.Position = pos;

            return (file.StringCacheList.ToList(), file.ImportCacheList.ToList());

            void SetParent(int chunkIndex, int parentIndex, int level = 0)
            {
                var targets = file.GetTargets(chunkIndex);
                foreach (var target in targets)
                {
                    ((CR2WExportWrapper)Chunks[target.Item2 - 1]).NewExport.parentID = (uint)(parentIndex + 1);
                    if (level < 1)
                    {
                        SetParent(target.Item2 - 1, parentIndex, level + 1);
                    }
                }
            }
        }

        private (byte[], List<int>) GenerateStringBuffer(List<string> strings, Encoding encoding = null)
        {
            encoding ??= Encoding.UTF8;

            var offsets = new List<int>();
            var bytes = new List<byte>();
            foreach (var str in strings)
            {
                offsets.Add(bytes.Count);
                bytes.AddRange(encoding.GetBytes(str));
                bytes.Add(0);
            }
            return (bytes.ToArray(), offsets);
        }
    }*/
}

