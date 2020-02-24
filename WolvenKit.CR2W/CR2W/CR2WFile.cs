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
            names = new List<CR2WNameWrapper>();            //block 1
            imports = new List<CR2WImportWrapper>();        //block 2
            chunks = new List<CR2WExportWrapper>();         //block 3
            properties = new List<CR2WPropertyWrapper>();   //block 4
            properties = new List<CR2WPropertyWrapper>();   //block 5
            buffers = new List<CR2WBufferWrapper>();        //block 6
            embedded = new List<CR2WEmbeddedWrapper>();     //block 7

            m_fileheader = new CR2WFileHeader(){
                version = 162,
            };
        }

        public CR2WFile(BinaryReader file)
        {
            Read(file);
            //m_filePath = 
        }
        #endregion

        #region Fields
        // constants
        private const uint MAGIC = 0x57325243;
        private const uint DEADBEEF = 0xDEADBEEF;

        // IO
        private CR2WFileHeader m_fileheader;
        private CR2WTable[] m_tableheaders;
        private Byte[] m_strings;
        private Dictionary<uint, string> m_dictionary;

        // misc
        private uint headerOffset = 0;
        private bool m_hasInternalBuffer;
        private Stream m_stream; //handle this better?
        private string m_filePath;
        #endregion

        #region Properties
        // Tables
        public List<CR2WNameWrapper> names { get; set; }
        public List<CR2WImportWrapper> imports { get; set; }
        public List<CR2WPropertyWrapper> properties { get; set; }
        public List<CR2WExportWrapper> chunks { get; set; }
        public List<CR2WBufferWrapper> buffers { get; set; }
        public List<CR2WEmbeddedWrapper> embedded { get; set; }


        public List<CLocalizedString> LocalizedStrings = new List<CLocalizedString>();
        public List<string> UnknownTypes = new List<string>();
        //public byte[] bufferdata { get; set; }
        public string FileName { get; set; }

       
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
            // read file header
            var id = ReadStruct<uint>();
            if (id != MAGIC)
                throw new FormatException($"Not a CR2W file, Magic read as 0x{id:X8}");

            m_fileheader = ReadStruct<CR2WFileHeader>();
            if (m_fileheader.version > 163 || m_fileheader.version < 159)
                throw new FormatException($"Unknown Version {m_fileheader.version}. Supported versions: 159 - 163.");

            var dt = new CDateTime(m_fileheader.timeStamp);

            m_hasInternalBuffer = m_fileheader.bufferSize > m_fileheader.fileSize;
            m_tableheaders = ReadStructs<CR2WTable>(10);
            
            // read strings
            m_strings = ReadStringsBuffer();
            
            // read tables
            names = ReadTable<CR2WName>(1).Select(_ => new CR2WNameWrapper(_)
            {
                str = m_dictionary[_.value],
            }).ToList();
            imports = ReadTable<CR2WImport>(2).Select(_ => new CR2WImportWrapper(_)
            {
                str = m_dictionary[_.depotPath],
            }).ToList();
            properties = ReadTable<CR2WProperty>(3).Select(_ => new CR2WPropertyWrapper(_)).ToList();
            chunks = ReadTable<CR2WExport>(4).Select(_ => new CR2WExportWrapper(this, _)
            {
                ParentChunkId = _.parentID
            }).ToList();
            buffers = ReadTable<CR2WBuffer>(5).Select(_ => new CR2WBufferWrapper(_)).ToList();
            embedded = ReadTable<CR2WEmbedded>(6).Select(_ => new CR2WEmbeddedWrapper(_)
            {
                Handle = m_dictionary[_.path],
            }).ToList();
            #endregion

            #region Read Data
            // Read object data //block 5
            foreach (var chunk in chunks)
            {
                chunk.ReadData(file);
            }
            // Read buffer data //block 6
            foreach (var buffer in buffers)
            {
                buffer.ReadData(file);
            }
            // Read embedded files //block 7
            foreach (var emb in embedded)
            {
                emb.ReadData(file);
            }
            #endregion


            //old
            /*file.BaseStream.Seek(m_fileheader.fileSize, SeekOrigin.Begin);

            var actualbuffersize = (int) (m_fileheader.bufferSize - m_fileheader.fileSize);
            if (actualbuffersize > 0)
            {
                bufferdata = new byte[actualbuffersize];
                file.BaseStream.Read(bufferdata, 0, actualbuffersize);
            }*/

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
                if (names[i].Name.value != newoffset)
                {
                    names[i].SetOffset(newoffset);
                }
            }
            for (var i = 0; i < imports.Count; i++)
            {
                var newoffset = inverseDictionary[imports[i].str];
                if (newoffset != imports[i].Import.depotPath)
                {
                    imports[i].SetOffset(newoffset);
                }
            }
            for (var i = 0; i < embedded.Count; i++)
            {
                var newoffset = inverseDictionary[embedded[i].Handle];
                if (newoffset != embedded[i].Embedded.path)
                {
                    embedded[i].SetOffset(newoffset);
                }
            }
            
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

            for (var i = 0; i < chunks.Count; i++)
            {
                var newoffset = chunks[i].Export.dataOffset + headerOffset;
                chunks[i].SetOffset(newoffset);
            }
            for (var i = 0; i < embedded.Count; i++)
            {
                var newoffset = embedded[i].Embedded.dataOffset + headerOffset;
                embedded[i].SetOffset(newoffset);
            }
            m_fileheader.fileSize += headerOffset;
            m_fileheader.bufferSize += headerOffset;
            #endregion

            for (int i = 0; i < chunks.Count; i++)
                FixExportCRC32(chunks[i].Export);
            for (int i = 0; i < buffers.Count; i++)
                FixBufferCRC32(buffers[i].Buffer);

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
                foreach (CR2WNameWrapper name in names)
                {
                    if (!newnames.Contains(name.str))
                        newnames.Add(name.str);
                }
                foreach (CR2WImportWrapper import in imports)
                {
                    if (!newnames.Contains(import.str))
                        newnames.Add(import.str);
                }
                foreach (CR2WEmbeddedWrapper emb in embedded)
                {
                    if (!newnames.Contains(emb.Handle))
                            newnames.Add(emb.Handle);
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

            void FixExportCRC32(CR2WExport export) //FIXME do I wann keep the ref?
            {
                m_stream.Seek(export.dataOffset, SeekOrigin.Begin);
                var m_temp = new byte[export.dataSize];
                m_stream.Read(m_temp, 0, m_temp.Length);
                export.crc32 = Crc32Algorithm.Compute(m_temp);
            }

            void FixBufferCRC32(CR2WBuffer buffer) //FIXME do I wann keep the ref?
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
            m_tableheaders[1].size = (uint)names.Count;
            m_tableheaders[1].offset = (uint) file.BaseStream.Position;
            WriteTable<CR2WName>(names.Select(_ => _.Name).ToArray(), 1);

            m_tableheaders[2].size = (uint)imports.Count;
            m_tableheaders[2].offset = (uint) file.BaseStream.Position;
            WriteTable<CR2WImport>(imports.Select(_ => _.Import).ToArray(), 2);

            m_tableheaders[3].size = (uint)properties.Count;
            m_tableheaders[3].offset = (uint) file.BaseStream.Position;
            WriteTable<CR2WProperty>(properties.Select(_ => _.Property).ToArray(), 3);

            m_tableheaders[4].size = (uint)chunks.Count;
            m_tableheaders[4].offset = (uint) file.BaseStream.Position;
            WriteTable<CR2WExport>(chunks.Select(_ => _.Export).ToArray(), 4);

            if (buffers.Count > 0)
            {
                m_tableheaders[5].size = (uint)buffers.Count;
                m_tableheaders[5].offset = (uint)file.BaseStream.Position;
                WriteTable<CR2WBuffer>(buffers.Select(_ => _.Buffer).ToArray(), 5);
            }

            if (embedded.Count > 0)
            {
                m_tableheaders[6].size = (uint)embedded.Count;
                m_tableheaders[6].offset = (uint)file.BaseStream.Position;
                WriteTable<CR2WEmbedded>(embedded.Select(_ => _.Embedded).ToArray(), 6);
            }
            #endregion
        }

        private void WriteFileHeader(BinaryWriter file)
        {
            file.BaseStream.Seek(0, SeekOrigin.Begin);

            WriteStruct<uint>(MAGIC);
            WriteStruct<CR2WFileHeader>(m_fileheader);
            WriteStructs<CR2WTable>(m_tableheaders); // offsets change if stringtable changes
            WriteStringBuffer();
        }

        private void WriteBuffers(BinaryWriter bw)
        {
            // Write chunk data
            for (var i = 0; i < chunks.Count; i++)
            {
                chunks[i].WriteData(bw);
            }
            // Write embedded data
            for (var i = 0; i < embedded.Count; i++)
            {
                embedded[i].WriteData(bw);
            }

            m_fileheader.fileSize = (uint) bw.BaseStream.Position;

            //Write Buffer data
            for (var i = 0; i < buffers.Count; i++)
            {
                buffers[i].WriteData(bw);
            }
            /*if (bufferdata != null)
            {
                bw.Write(bufferdata);
            }*/
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
        public CR2WExportWrapper CreateChunk(string type, CR2WExportWrapper parent = null)
        {
            var chunk = new CR2WExportWrapper(this);
            chunk.Type = type;
            chunk.CreateDefaultData();
            if (parent != null)
            {
                chunk.ParentChunkId = (uint)chunks.IndexOf(parent) + 1;
            }

            chunks.Add(chunk);
            return chunk;
        }

        public CR2WExportWrapper CreateChunk(string type, CVariable data, CR2WExportWrapper parent = null)
        {
            var chunk = new CR2WExportWrapper(this);
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
                var newstring = new CR2WNameWrapper();
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
                if (imports[i].Import.className == filetype && imports[i].Import.flags == flags &&
                    (imports[i].str == name || (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(imports[i].str))))
                    return i;
            }

            if (addnew)
            {
                var import = new CR2WImport()
                {
                    flags = flags,
                    depotPath = depotpath,
                    className = filetype
                };
                var newstring = new CR2WImportWrapper(import)
                {
                    str = name,
                };
                imports.Add(newstring);

                return imports.Count - 1;
            }

            return -1;
        }

        public CR2WExportWrapper GetChunkByType(string type)
        {
            for (var i = 0; i < chunks.Count; i++)
            {
                if (chunks[i].Type == type)
                    return chunks[i];
            }

            return null;
        }

        public CVector CreateVector(CR2WExportWrapper in_chunk, string type, string varname = "")
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

        public CVariable CreateVariable(CR2WExportWrapper in_chunk, string type, string varname = "")
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

        public CHandle CreateHandle(CR2WExportWrapper in_chunk, string type, string handle, string varname = "")
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

        public CSoft CreateSoft(CR2WExportWrapper in_chunk, string type, string handle, string varname = "")
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

        public CPtr CreatePtr(CArray in_array, CR2WExportWrapper to_chunk, string varname = "")
        {
            var var = CreatePtr("", to_chunk, varname);
            in_array.AddVariable(var);
            return var;
        }

        public CPtr CreatePtr(CVector in_vector, string type, CR2WExportWrapper to_chunk, string varname = "")
        {
            var var = CreatePtr(type, to_chunk, varname);
            in_vector.AddVariable(var);
            return var;
        }

        public CPtr CreatePtr(CR2WExportWrapper in_chunk, string type, CR2WExportWrapper to_chunk, string varname = "")
        {
            var var = CreatePtr(type, to_chunk, varname);
            in_chunk.data.AddVariable(var);
            return var;
        }

        public CPtr CreatePtr(string type, CR2WExportWrapper tochunk, string varname = "")
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

        public bool RemoveChunk(CR2WExportWrapper chunk)
        {
            return chunks.Remove(chunk);
        }
        #endregion
    }
}