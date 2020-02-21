using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using WolvenKit.CR2W.Types;
using RED.CRC32;
using System.Runtime.InteropServices;

namespace WolvenKit.CR2W
{
    public class CR2WFile
    {
        #region Constructor
        public CR2WFile()
        {
            names = new List<CR2WString> {new CR2WString()};
            imports = new List<CR2WHandle>();
            chunks = new List<CR2WChunk>();
            //table4 = new List<CR2WHeaderBlock4>();
            buffers = new List<CR2WBuffer>();
            embedded = new List<CR2WEmbedded>();

            m_fileheader = new CR2WFileHeader();
            m_fileheader.version = 162;
        }

        public CR2WFile(BinaryReader file)
        {
            Read(file);
        }
        #endregion

        #region Fields
        private const uint MAGIC = 0x57325243;
        private const uint DEADBEEF = 0xDEADBEEF;

        private bool m_hasInternalBuffer;
        private Stream m_stream; //handle this better?
        private string m_filePath;

        private CR2WFileHeader m_fileheader;
        private CR2WTableHeader[] m_tableheaders;
        private Byte[] m_strings;
        private CR2WName[] m_names;
        private CR2WImportHeader[] m_imports;
        private CR2WTable4Item[] m_table4;
        private CR2WExportHeader[] m_exports;
        private CR2WBufferHeader[] m_buffers;
        private CR2WEmbeddedHeader[] m_embedded;

        private Dictionary<uint, string> m_dictionary;

        private uint headerOffset;
        #endregion

        #region Properties

        public List<CLocalizedString> LocalizedStrings = new List<CLocalizedString>();
        public List<string> UnknownTypes = new List<string>();
        public byte[] bufferdata { get; set; }
        public string FileName { get; set; }

        public List<CR2WString> names { get; set; }
        public List<CR2WHandle> imports { get; set; }
        public List<CR2WChunk> chunks { get; set; }
        public List<CR2WBuffer> buffers { get; set; }
        public List<CR2WEmbedded> embedded { get; set; }
        /// <summary>
        ///     LocalizedStringSource
        /// </summary>
        public ILocalizedStringSource LocalizedStringSource { get; set; }

        /// <summary>
        ///     EditorController
        /// </summary>
        public IVariableEditor EditorController { get; set; }
        #endregion

        public string GetLocalizedString(uint val)
        {
            if (LocalizedStringSource != null)
                return LocalizedStringSource.GetLocalizedString(val);

            return null;
        }

        public void CreateVariableEditor(CVariable editvar, EVariableEditorAction action)
        {
            if (EditorController != null)
            {
                EditorController.CreateVariableEditor(editvar, action);
            }
        }

        #region Read
        public void Read(BinaryReader file)
        {
            m_stream = file.BaseStream;

            #region Read Headers
            var id = ReadStruct<uint>();
            if (id != MAGIC)
                throw new FormatException($"Not a CR2W file, Magic read as 0x{id:X8}");

            m_fileheader = ReadStruct<CR2WFileHeader>();
            if (m_fileheader.version > 163 || m_fileheader.version < 159)
                throw new FormatException($"Unknown Version {m_fileheader.version}. Supported versions: 159 - 163.");

            var dt = new CDateTime(m_fileheader.timeStamp);

            m_hasInternalBuffer = m_fileheader.bufferSize > m_fileheader.fileSize;
            m_tableheaders = ReadStructs<CR2WTableHeader>(10);

            m_strings = ReadStringsBuffer();
            m_names = ReadTable<CR2WName>(1);
            m_imports = ReadTable<CR2WImportHeader>(2);
            m_table4 = ReadTable<CR2WTable4Item>(3);
            m_exports = ReadTable<CR2WExportHeader>(4);
            m_buffers = ReadTable<CR2WBufferHeader>(5);
            m_embedded = ReadTable<CR2WEmbeddedHeader>(6);
            #endregion

            #region Read Data
            // read Name data
            names = (from n in m_names
                        let str = new CR2WString()
                        {
                            hash = n.hash,
                            offset = n.value,
                            str = m_dictionary[n.value]
                        }
                        select str).ToList();
            // Read Handle data (imports)
            imports = (from i in m_imports
                       let handle = new CR2WHandle()
                       {
                           offset = i.depotPath,
                           filetype = i.className,
                           flags = i.flags,
                           str = m_dictionary[i.depotPath]
                       }
                       select handle).ToList();
            // Read Chunk data (exports)
            chunks = new List<CR2WChunk>();
            foreach (var c in m_exports)
            {
                var chunk = new CR2WChunk(this)
                      {
                          typeId = c.className,
                          Flags = c.objectFlags,
                          ParentChunkId = c.parentID,
                          size = c.dataSize,
                          offset = c.dataOffset,
                          template = c.template,
                          crc = c.crc32
                      };
                chunks.Add(chunk);
                chunk.ReadData(file);
            }

            // Read Buffer Data (block 6)
            buffers = new List<CR2WBuffer>();
            foreach (var b in m_buffers)
            {
                var buffer = new CR2WBuffer()
                       {
                           flags = b.flags,
                           index = b.index,
                           offset = b.offset,
                           size = b.diskSize,
                           memsize = b.memSize,
                           crc = b.crc32
                       };
                buffers.Add(buffer);
            }
            // Read Embedded Data (Block 7)
            embedded = new List<CR2WEmbedded>();
            foreach (var e in m_embedded)
            {
                var emb = new CR2WEmbedded()
                        {
                            handle_name_count = e.importIndex,
                            handle_name_offset = e.path,
                            pathHash = e.pathHash,
                            offset = e.dataOffset,
                            size = e.dataSize
                        };
                var offset = e.path;
                for (int i = 0; i < e.importIndex; i++)
                {
                    if (offset > m_dictionary.Last().Key)
                    {
                        continue;
                    }
                    emb.handles.Add(m_dictionary[offset]);
                    offset += (uint)m_dictionary[offset].Length + 1;
                }
                embedded.Add(emb);
                emb.ReadData(file);
            }
            #endregion

            #region Read Buffer

            file.BaseStream.Seek(m_fileheader.fileSize, SeekOrigin.Begin);

            var actualbuffersize = (int) (m_fileheader.bufferSize - m_fileheader.fileSize);
            if (actualbuffersize > 0)
            {
                bufferdata = new byte[actualbuffersize];
                file.BaseStream.Read(bufferdata, 0, actualbuffersize);
            }
            #endregion

            m_stream = null;
        }
        #endregion

        public CVariable ReadVariable(BinaryReader file)
        {
            var nameId = file.ReadUInt16();
            if (nameId == 0)
            {
                return null;
            }

            var typepos = file.BaseStream.Position;
            var typeId = file.ReadUInt16();

            var size = file.ReadUInt32() - 4;
            var typename = names[typeId].str;
            var varname = names[nameId].str;

            var parsedvar = CR2WTypeManager.Get().GetByName(typename, varname, this);
            parsedvar.Read(file, size);

            parsedvar.nameId = nameId;
            parsedvar.typeId = typeId;

            return parsedvar;
        }
        
        public static void WriteVariable(BinaryWriter file, CVariable var)
        {
            file.Write(var.nameId);
            file.Write(var.typeId);

            var pos = file.BaseStream.Position;
            file.Write((uint) 0); // size placeholder


            var.Write(file);
            var endpos = file.BaseStream.Position;

            file.Seek((int) pos, SeekOrigin.Begin);
            var actualsize = (uint) (endpos - pos);
            file.Write(actualsize); // Write size
            file.Seek((int) endpos, SeekOrigin.Begin);
        }

        #region Write
        public void Write(BinaryWriter file)
        {
            m_stream = file.BaseStream;

            // update data
            #region Update Data
            m_fileheader.timeStamp = CDateTime.Now.ToUInt64(); //this will change any vanilla assets simply by opening and saving in wkit
            m_fileheader.numChunks = (uint)chunks.Count;

            foreach (var c in chunks)
            {
                GetStringIndex(c.Type, true);
            }

            // Update strings
            uint stringbuffer_offset = 160; // always 160
            m_tableheaders[0].offset = stringbuffer_offset;
            m_strings = GetNewStrings();
            UpdateDictionary();
            
            // Update Offsets
            var inverseDictionary = m_dictionary.ToDictionary(x => x.Value, x => x.Key);
            for (var i = 0; i < names.Count; i++)
            {
                var newoffset = inverseDictionary[names[i].str];
                if (names[i].offset != newoffset)
                {
                    names[i].offset = newoffset;
                }
            }
            for (var i = 0; i < imports.Count; i++)
            {
                var newoffset = inverseDictionary[imports[i].str];
                if (newoffset != imports[i].offset)
                {
                    imports[i].offset = newoffset;
                }
            }
            for (var i = 0; i < embedded.Count; i++)
            {
                for (var j = 0; j < embedded[i].handles.Count; j++)
                {
                    var newoffset = inverseDictionary[embedded[i].handles[j]];
                    if (newoffset != embedded[i].handle_name_offset)
                    {
                        embedded[i].handle_name_offset = newoffset;
                    }
                }
            }
            
            m_names = names.Select(_ => _.ToCR2WName()).ToArray();
            m_imports = imports.Select(_ => _.ToCR2WImport()).ToArray();
            //m_table4 = table4.Select(_ => _.ToCR2WTable4Item()).ToArray();
            m_exports = chunks.Select(_ => _.ToCR2WExport()).ToArray();
            m_buffers = buffers.Select(_ => _.ToCR2WBuffer()).ToArray();
            m_embedded = embedded.Select(_ => _.ToCR2WEmbedded()).ToArray();
            #endregion

            headerOffset = 0;
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                // first write the file to memory
                // this also sets m_fileheader.fileSize and m_fileheader.bufferSize, offsets
                WriteBuffers(bw);

                // Write headers once to allocate the space for it
                WriteHeader(file);

                headerOffset = (uint)file.BaseStream.Position;

                // Write buffers
                ms.Seek(0, SeekOrigin.Begin);
                ms.WriteTo(file.BaseStream);
            }

            #region Update Offsets
            m_exports = chunks.Select(_ => _.ToCR2WExport()).ToArray();
            m_embedded = embedded.Select(_ => _.ToCR2WEmbedded()).ToArray();

            for (var i = 0; i < m_exports.Length; i++)
            {
                m_exports[i].dataOffset += headerOffset;
            }
            for (var i = 0; i < m_embedded.Length; i++)
            {
                m_embedded[i].dataOffset += headerOffset;
            }
            m_fileheader.fileSize += headerOffset;
            m_fileheader.bufferSize += headerOffset;
            #endregion

            for (int i = 0; i < m_exports.Length; i++)
                FixExportCRC32(ref m_exports[i]);
            for (int i = 0; i < m_buffers.Length; i++)
                FixBufferCRC32(ref m_buffers[i]);

            // Write headers again with fixed offsets
            //m_fileheader.crc32 = CalculateHeaderCRC32();
            WriteHeader(file);
            m_fileheader.crc32 = CalculateHeaderCRC32();
            WriteFileHeader(file);

            m_stream = null;

            // LOCAL METHODS
            void UpdateDictionary()
            {
                var size = m_strings.Length;
                m_tableheaders[0].size = (uint)size;
                m_tableheaders[0].crc32 = Crc32Algorithm.Compute(m_strings);

                m_dictionary = new Dictionary<uint, string>();
                StringBuilder sb = new StringBuilder();
                uint offset = 0;
                for (uint i = 0; i < size; i++)
                {
                    var b = m_strings[i];
                    if (b == 0)
                    {
                        m_dictionary.Add(offset, sb.ToString());
                        sb.Clear();
                        offset = i + 1;
                    }
                    else
                    {
                        sb.Append((char)b);
                    }
                }
            }

            byte[] GetNewStrings()
            {
                var newnames = new List<string>();
                var newstrings = new List<byte>();
                foreach (CR2WString name in names)
                {
                    if (!newnames.Contains(name.str))
                        newnames.Add(name.str);
                }
                foreach (CR2WHandle import in imports)
                {
                    if (!newnames.Contains(import.str))
                        newnames.Add(import.str);
                }
                for (var i = 0; i < embedded.Count; i++)
                {
                    foreach (var str in embedded[i].handles)
                    {
                        if (!newnames.Contains(str))
                            newnames.Add(str);
                    }
                }

                foreach (var str in newnames)
                {
                    if (str != null)
                    {
                        var bytes = Encoding.Default.GetBytes(str);
                        foreach (var b in bytes)
                        {
                            newstrings.Add(b);
                        }
                    }
                    newstrings.Add((byte)0);
                }

                return newstrings.ToArray();
            }

            void FixExportCRC32(ref CR2WExportHeader export)
            {
                m_stream.Seek(export.dataOffset, SeekOrigin.Begin);
                var m_temp = new byte[export.dataSize];
                m_stream.Read(m_temp, 0, m_temp.Length);
                export.crc32 = Crc32Algorithm.Compute(m_temp);
            }

            void FixBufferCRC32(ref CR2WBufferHeader buffer)
            {
                //This might throw errors, the way it should be checked for is by reading
                //the object tree to find the deferred data buffers that will point to a buffer.
                //The flag of the parent object indicates where to read the data from.
                //For now this is a crude workaround.
                if (m_hasInternalBuffer)
                {
                    m_stream.Seek(buffer.offset, SeekOrigin.Begin);
                    var m_temp = new byte[buffer.diskSize];
                    m_stream.Read(m_temp, 0, m_temp.Length);
                    buffer.crc32 = Crc32Algorithm.Compute(m_temp);
                }
                else
                {
                    /*var path = String.Format("{0}.{1}.buffer", m_filePath, buffer.index);
                    if (!File.Exists(path))
                    {
                        return;
                    }
                    m_temp = File.ReadAllBytes(path);
                    buffer.crc32 = Crc32Algorithm.Compute(m_temp);*/
                }
            }

            uint CalculateHeaderCRC32()
            {
                var hash = new Crc32Algorithm(false);
                hash.Append(BitConverter.GetBytes(MAGIC));
                hash.Append(BitConverter.GetBytes(m_fileheader.version));
                hash.Append(BitConverter.GetBytes(m_fileheader.flags));
                hash.Append(BitConverter.GetBytes(m_fileheader.timeStamp));
                hash.Append(BitConverter.GetBytes(m_fileheader.buildVersion));
                hash.Append(BitConverter.GetBytes(m_fileheader.fileSize));
                hash.Append(BitConverter.GetBytes(m_fileheader.bufferSize));
                hash.Append(BitConverter.GetBytes(DEADBEEF));
                hash.Append(BitConverter.GetBytes(m_fileheader.numChunks));
                foreach (var h in m_tableheaders)
                {
                    hash.Append(BitConverter.GetBytes(h.offset));
                    hash.Append(BitConverter.GetBytes(h.size));
                    hash.Append(BitConverter.GetBytes(h.crc32));
                }
                return hash.HashUInt32;
            }
        }

        private void WriteHeader(BinaryWriter file)
        {
            WriteFileHeader(file);

            #region Write Tables
            m_tableheaders[1].size = (uint)m_names.Length;
            m_tableheaders[1].offset = (uint) file.BaseStream.Position;
            WriteTable<CR2WName>(m_names, 1);

            m_tableheaders[2].size = (uint)m_imports.Length;
            m_tableheaders[2].offset = (uint) file.BaseStream.Position;
            WriteTable<CR2WImportHeader>(m_imports, 2);

            m_tableheaders[3].size = (uint)m_table4.Length;
            m_tableheaders[3].offset = (uint) file.BaseStream.Position;
            WriteTable<CR2WTable4Item>(m_table4, 3);

            m_tableheaders[4].size = (uint)m_exports.Length;
            m_tableheaders[4].offset = (uint) file.BaseStream.Position;
            WriteTable<CR2WExportHeader>(m_exports, 4);

            if (m_buffers.Length > 0)
            {
                m_tableheaders[5].size = (uint)m_buffers.Length;
                m_tableheaders[5].offset = (uint)file.BaseStream.Position;
                WriteTable<CR2WBufferHeader>(m_buffers, 5);
            }

            if (m_embedded.Length > 0)
            {
                m_tableheaders[6].size = (uint)m_embedded.Length;
                m_tableheaders[6].offset = (uint)file.BaseStream.Position;
                WriteTable<CR2WEmbeddedHeader>(m_embedded, 6);
            }
            #endregion
        }

        private void WriteFileHeader(BinaryWriter file)
        {
            file.BaseStream.Seek(0, SeekOrigin.Begin);

            WriteStruct<uint>(MAGIC);
            WriteStruct<CR2WFileHeader>(m_fileheader);
            WriteStructs<CR2WTableHeader>(m_tableheaders); // offsets change if stringtable changes
            WriteStringBuffer();
        }

        private void WriteBuffers(BinaryWriter bw)
        {
            // Write chunk buffers
            for (var i = 0; i < chunks.Count; i++)
            {
                chunks[i].WriteData(bw);
            }

            // Write block7
            for (var i = 0; i < embedded.Count; i++)
            {
                embedded[i].WriteData(bw);
            }

            m_fileheader.fileSize = (uint) bw.BaseStream.Position;

            if (bufferdata != null)
            {
                bw.Write(bufferdata);
            }
            m_fileheader.bufferSize = (uint) bw.BaseStream.Position;
        }
        #endregion

        #region Table Reading
        private byte[] ReadStringsBuffer()
        {
            var start = m_tableheaders[0].offset;
            var size = m_tableheaders[0].size;
            var crc = m_tableheaders[0].crc32;

            var m_temp = new byte[size];
            m_stream.Read(m_temp, 0, m_temp.Length);

            m_dictionary = new Dictionary<uint, string>();
            StringBuilder sb = new StringBuilder();
            uint offset = 0;
            for (uint i = 0; i < size; i++)
            {
                var b = m_temp[i];
                if (b == 0)
                {
                    m_dictionary.Add(offset, sb.ToString());
                    sb.Clear();
                    offset = i + 1;
                }
                else
                {
                    sb.Append((char)b);
                }
            }

            return m_temp;
        }
        private void WriteStringBuffer()
        {
            m_tableheaders[0].crc32 = Crc32Algorithm.Compute(m_strings);
            m_stream.Write(m_strings, 0, m_strings.Length);
        }

        private T[] ReadTable<T>(int index) where T : struct
        {
            m_stream.Seek(m_tableheaders[index].offset, SeekOrigin.Begin);

            var hash = new Crc32Algorithm(false);
            var table = ReadStructs<T>(m_tableheaders[index].size, hash);

            return table;
        }
        private void WriteTable<T>(T[] array, int index) where T : struct
        {
            if (array.Length == 0)
                return;

            var crc = new Crc32Algorithm(false);
            WriteStructs<T>(array, crc);
            m_tableheaders[index].crc32 = crc.HashUInt32;
        }
        #endregion

        #region Supporting Functions
        private T ReadStruct<T>(Crc32Algorithm crc32 = null) where T : struct
        {
            var size = Marshal.SizeOf<T>();

            var m_temp = new byte[size];
            m_stream.Read(m_temp, 0, size);

            var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);
            var item = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());

            if (crc32 != null)
                crc32.Append(m_temp);

            handle.Free();

            return item;
        }
        private T[] ReadStructs<T>(uint count, Crc32Algorithm crc32 = null) where T : struct
        {
            var size = Marshal.SizeOf<T>();
            var items = new T[count];

            var m_temp = new byte[size];
            for (uint i = 0; i < count; i++)
            {
                m_stream.Read(m_temp, 0, size);

                var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);
                items[i] = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());

                if (crc32 != null)
                    crc32.Append(m_temp);

                handle.Free();
            }

            return items;
        }
        private void WriteStruct<T>(T value, Crc32Algorithm crc32 = null) where T : struct
        {
            var m_temp = new byte[Marshal.SizeOf<T>()];
            var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);

            Marshal.StructureToPtr(value, handle.AddrOfPinnedObject(), true);
            m_stream.Write(m_temp, 0, m_temp.Length);

            if (crc32 != null)
                crc32.Append(m_temp);

            handle.Free();
        }
        private void WriteStructs<T>(T[] array, Crc32Algorithm crc32 = null) where T : struct
        {
            var size = Marshal.SizeOf<T>();
            var m_temp = new byte[size];
            for (int i = 0; i < array.Length; i++)
            {
                var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);

                Marshal.StructureToPtr(array[i], handle.AddrOfPinnedObject(), true);
                m_stream.Write(m_temp, 0, m_temp.Length);

                if (crc32 != null)
                    crc32.Append(m_temp);

                handle.Free();
            }
        }
        #endregion

        #region Create
        public CR2WChunk CreateChunk(string type, CR2WChunk parent = null)
        {
            var chunk = new CR2WChunk(this);
            chunk.Type = type;
            chunk.CreateDefaultData();
            if (parent != null)
            {
                chunk.ParentChunkId = (uint)chunks.IndexOf(parent) + 1;
            }

            chunks.Add(chunk);
            return chunk;
        }

        public CR2WChunk CreateChunk(string type, CVariable data, CR2WChunk parent = null)
        {
            var chunk = new CR2WChunk(this);
            chunk.Type = type;
            chunk.data = data;
            if (parent != null)
            {
                chunk.ParentChunkId = (uint)chunks.IndexOf(parent) + 1;
            }

            chunks.Add(chunk);
            return chunk;
        }

        public int GetStringIndex(string name, bool addnew = false)
        {
            for (var i = 0; i < names.Count; i++)
            {
                if (names[i].str == name || (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(names[i].str)))
                    return i;
            }

            if (addnew)
            {
                var newstring = new CR2WString();
                newstring.str = name;
                names.Add(newstring);

                return names.Count - 1;
            }

            return -1;
        }

        public int GetHandleIndex(string name, ushort filetype, ushort flags, bool addnew = false)
        {
            for (var i = 0; i < imports.Count; i++)
            {
                if (imports[i].filetype == filetype && imports[i].flags == flags &&
                    (imports[i].str == name || (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(imports[i].str))))
                    return i;
            }

            if (addnew)
            {
                var newstring = new CR2WHandle();
                newstring.str = name;
                newstring.filetype = filetype;
                newstring.flags = flags;
                imports.Add(newstring);

                return imports.Count - 1;
            }

            return -1;
        }

        public CR2WChunk GetChunkByType(string type)
        {
            for (var i = 0; i < chunks.Count; i++)
            {
                if (chunks[i].Type == type)
                    return chunks[i];
            }

            return null;
        }

        public CVector CreateVector(CR2WChunk in_chunk, string type, string varname = "")
        {
            var var = CreateVector(type, varname);
            in_chunk.data.AddVariable(var);
            return var;
        }

        public CVector CreateVector(CArray in_array, string varname = "")
        {
            var var = CreateVector("", varname);
            in_array.AddVariable(var);
            return var;
        }

        public CVector CreateVector(string type, string varname = "")
        {
            var var = new CVector(this);
            var.Type = type;
            var.Name = varname;
            return var;
        }

        public CVariable CreateVariable(CVector in_vector, string type, string varname = "")
        {
            var var = CreateVariable(type, varname);
            in_vector.AddVariable(var);
            return var;
        }

        public CVariable CreateVariable(CR2WChunk in_chunk, string type, string varname = "")
        {
            var var = CreateVariable(type, varname);
            in_chunk.data.AddVariable(var);
            return var;
        }

        public CVariable CreateVariable(string type, string varname = "")
        {
            var var = CR2WTypeManager.Get().GetByName(type, varname, this, false);
            var.Type = type;
            var.Name = varname;
            return var;
        }

        public CVariable CreateVariable(CArray in_array, string type)
        {
            var var = CreateVariable(type);
            in_array.AddVariable(var);
            return var;
        }

        public CHandle CreateHandle(CArray in_array, string type, string handle, string varname = "")
        {
            var var = CreateHandle(type, handle, varname);
            in_array.AddVariable(var);
            return var;
        }

        public CHandle CreateHandle(CVector in_vector, string type, string handle, string varname = "")
        {
            var var = CreateHandle(type, handle, varname);
            in_vector.AddVariable(var);
            return var;
        }

        public CHandle CreateHandle(CR2WChunk in_chunk, string type, string handle, string varname = "")
        {
            var var = CreateHandle(type, handle, varname);
            in_chunk.data.AddVariable(var);
            return var;
        }

        public CHandle CreateHandle(string type, string handle, string varname = "")
        {
            var reg = new Regex(@"(\w+):(.+)");
            var match = reg.Match(type);
            var targetType = type;

            if (match.Success)
            {
                targetType = match.Groups[2].Value;
            }

            if (handle != null)
            {
                handle = handle.Replace('/', '\\');
            }
            var ptr = new CHandle(this);
            ptr.Name = varname;
            ptr.Type = type;

            ptr.Handle = handle;
            ptr.FileType = targetType;

            return ptr;
        }

        public CSoft CreateSoft(CArray in_array, string type, string handle, string varname = "")
        {
            var var = CreateSoft(type, handle, varname);
            in_array.AddVariable(var);
            return var;
        }

        public CSoft CreateSoft(CVector in_vector, string type, string handle, string varname = "")
        {
            var var = CreateSoft(type, handle, varname);
            in_vector.AddVariable(var);
            return var;
        }

        public CSoft CreateSoft(CR2WChunk in_chunk, string type, string handle, string varname = "")
        {
            var var = CreateSoft(type, handle, varname);
            in_chunk.data.AddVariable(var);
            return var;
        }

        public CSoft CreateSoft(string type, string handle, string varname = "")
        {
            var reg = new Regex(@"(\w+):(.+)");
            var match = reg.Match(type);
            var targetType = type;

            if (match.Success)
            {
                targetType = match.Groups[2].Value;
            }

            handle = handle.Replace('/', '\\');
            var ptr = new CSoft(this);
            ptr.Name = varname;
            ptr.Type = type;

            ptr.FileType = targetType;
            ptr.Flags = 4;
            ptr.Handle = handle;
            return ptr;
        }

        public CPtr CreatePtr(CArray in_array, CR2WChunk to_chunk, string varname = "")
        {
            var var = CreatePtr("", to_chunk, varname);
            in_array.AddVariable(var);
            return var;
        }

        public CPtr CreatePtr(CVector in_vector, string type, CR2WChunk to_chunk, string varname = "")
        {
            var var = CreatePtr(type, to_chunk, varname);
            in_vector.AddVariable(var);
            return var;
        }

        public CPtr CreatePtr(CR2WChunk in_chunk, string type, CR2WChunk to_chunk, string varname = "")
        {
            var var = CreatePtr(type, to_chunk, varname);
            in_chunk.data.AddVariable(var);
            return var;
        }

        public CPtr CreatePtr(string type, CR2WChunk tochunk, string varname = "")
        {
            var ptr = new CPtr(this);
            ptr.Name = varname;
            ptr.Type = type;

            if (tochunk != null)
            {
                ptr.val = chunks.IndexOf(tochunk) + 1;
            }
            return ptr;
        }

        public bool RemoveChunk(CR2WChunk chunk)
        {
            return chunks.Remove(chunk);
        }
        #endregion
    }
}