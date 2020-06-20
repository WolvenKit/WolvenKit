using RED.CRC32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Types;
using WolvenKit.CR2W.Types.Utils;
using WolvenKit.Utils;

namespace WolvenKit.CR2W
{
    [ DataContract(Namespace = "") ]
    public class CR2WFile
    {
        #region Constants
        private const long MAGIC_SIZE = 4;
        private const long FILEHEADER_SIZE = 36;
        private const long TABLEHEADER_SIZE = 12 * 10;
        private readonly int[] TABLES_SIZES = new int[6] { 8, 8, 16, 24, 24, 24 };


        #endregion


        #region Constructor
        public CR2WFile()
        {
            names = new List<CR2WNameWrapper>();            //block 2
            imports = new List<CR2WImportWrapper>();        //block 3
            properties = new List<CR2WPropertyWrapper>();   //block 4
            chunks = new List<CR2WExportWrapper>();         //block 5
            buffers = new List<CR2WBufferWrapper>();        //block 6
            embedded = new List<CR2WEmbeddedWrapper>();     //block 7

            m_fileheader = new CR2WFileHeader(){
                version = 162,
            };

            Logger = new LoggerService();       //dummy that can't log to UI, not really needed bc we check later anyway. but hey
        }

        public CR2WFile(BinaryReader file, LoggerService logger = null)
        {
            if (logger == null)
                Logger = new LoggerService();   //dummy that can't log to UI, not really needed bc we check later anyway. but hey
            else
                Logger = logger;

            Read(file);
        }
        public CR2WFile(MemoryMappedFile file, LoggerService logger = null)
        {
            if (logger == null)
                Logger = new LoggerService();   //dummy that can't log to UI, not really needed bc we check later anyway. but hey
            else
                Logger = logger;

            //await Read(file);
        }
        public CR2WFile(byte[] data, LoggerService logger)
        {
            Logger = logger;
            using (var ms = new MemoryStream(data))
            using (var br = new BinaryReader(ms))
            {
                Read(br);
            }
        }
        #endregion

        #region Fields
        
        // constants
        private const uint MAGIC = 0x57325243;
        private const uint DEADBEEF = 0xDEADBEEF;

        // IO
        [DataMember(Order = 1, Name = "Header")]
        private CR2WFileHeader m_fileheader;

        private CR2WTable[] m_tableheaders;
        private Byte[] m_strings;
        public Dictionary<uint, string> StringDictionary { get; private set; }

        // misc
        private uint headerOffset = 0;
        private bool m_hasInternalBuffer;
        //private Stream m_stream; //handle this better?
        // private string m_filePath;
        #endregion

        #region Properties
        public LoggerService Logger { get; set; }

        // Tables
        public List<CR2WNameWrapper> names { get; set; }
        public List<CR2WImportWrapper> imports { get; set; }
        public List<CR2WPropertyWrapper> properties { get; set; }

        //[DataMember(Order = 2)]
        public List<CR2WExportWrapper> chunks { get; set; }
        public List<CR2WBufferWrapper> buffers { get; set; }
        public List<CR2WEmbeddedWrapper> embedded { get; set; }


        public List<LocalizedString> LocalizedStrings = new List<LocalizedString>();
        public List<string> UnknownTypes = new List<string>();
        //public byte[] bufferdata { get; set; }
        [DataMember(Order = 0)]
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
            //m_stream = file.BaseStream;

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();

            #region Read Headers
            if (Logger != null) Logger.LogProgress(1, "Reading headers...");
            // read file header
            var id = file.BaseStream.ReadStruct<uint>();
            if (id != MAGIC)
                throw new FormatException($"Not a CR2W file, Magic read as 0x{id:X8}");

            m_fileheader = file.BaseStream.ReadStruct<CR2WFileHeader>();
            if (m_fileheader.version > 163 || m_fileheader.version < 159)
                throw new FormatException($"Unknown Version {m_fileheader.version}. Supported versions: 159 - 163.");

            var dt = new CDateTime(m_fileheader.timeStamp, null, "");

            m_tableheaders = file.BaseStream.ReadStructs<CR2WTable>(10);
            m_hasInternalBuffer = m_fileheader.bufferSize > m_fileheader.fileSize;

            // read strings
            m_strings = ReadStringsBuffer(file.BaseStream);
            
            // read tables
            names = ReadTable<CR2WName>(file.BaseStream, 1).Select(_ => new CR2WNameWrapper(_, this)).ToList();
            imports = ReadTable<CR2WImport>(file.BaseStream, 2).Select(_ => new CR2WImportWrapper(_, this)).ToList();
            properties = ReadTable<CR2WProperty>(file.BaseStream, 3).Select(_ => new CR2WPropertyWrapper(_)).ToList();
            chunks = ReadTable<CR2WExport>(file.BaseStream, 4).Select(_ => new CR2WExportWrapper(_, this)).ToList();
            buffers = ReadTable<CR2WBuffer>(file.BaseStream, 5).Select(_ => new CR2WBufferWrapper(_)).ToList();
            embedded = ReadTable<CR2WEmbedded>(file.BaseStream, 6).Select(_ => new CR2WEmbeddedWrapper(_)
            {
                ParentFile = this,
                ParentImports = imports,
                Handle = StringDictionary[_.path],
            }).ToList();

            if (Logger != null) Logger.LogProgress(100);
            #endregion

            #region Read Data
            if (Logger != null) Logger.LogProgress(1, "Reading chunks...");
            // Read object data //block 5
            for (int i = 0; i < chunks.Count; i++)
            {
                CR2WExportWrapper chunk = chunks[i];

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                chunk.ReadData(file);

                if (Logger != null) Logger.LogString($"{stopwatch.Elapsed} CHUNK {chunk.REDName}\n");
                stopwatch.Stop();


                int percentprogress = (int)((float)i / (float)chunks.Count * 100.0);
                if (Logger != null) Logger.LogProgress(percentprogress, $"Reading chunk {chunk.REDName}...");
            }
            // Read buffer data //block 6
            if (m_hasInternalBuffer)
            {
                for (int i = 0; i < buffers.Count; i++)
                {
                    CR2WBufferWrapper buffer = buffers[i];
                    buffer.ReadData(file);

                    int percentprogress = (int)((float)i / (float)buffers.Count * 100.0);
                    if (Logger != null) Logger.LogProgress(percentprogress);
                }
            }
            // Read embedded files //block 7
            for (int i = 0; i < embedded.Count; i++)
            {
                CR2WEmbeddedWrapper emb = embedded[i];
                emb.ReadData(file);

                int percentprogress = (int)((float)i / (float)embedded.Count * 100.0);
                if (Logger != null) Logger.LogProgress(percentprogress, $"Reading embedded file {emb.ClassName}...");
            }
            #endregion

            // dbg
            // check self
            //(var nameslist, var importslist) = GenerateStringtable();

            //for (int i = 0; i < nameslist.Count; i++)
            //{
            //    if (nameslist[i] != this.StringDictionary.Values.ToList()[i])
            //    {
            //        throw new NotImplementedException();
            //    }
            //}

            if (Logger != null) Logger.LogString($"File {FileName} loaded in: {stopwatch1.Elapsed}\n");
            stopwatch1.Stop();

            //m_stream = null;
        }


        public CR2WFile Read(MemoryMappedFile mmf)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            long offset = 0;

            #region Magic
            long curviewstreamsize = MAGIC_SIZE;
            using (MemoryMappedViewStream viewstream = mmf.CreateViewStream(offset, curviewstreamsize, MemoryMappedFileAccess.Read))
            {
                if (Logger != null) Logger.LogProgress(1, "Reading headers...");
                // read file header
                var id = viewstream.ReadStruct<uint>();
                if (id != MAGIC)
                    throw new FormatException($"Not a CR2W file, Magic read as 0x{id:X8}");
                offset += curviewstreamsize;
            }
            #endregion

            #region FileHeader
            curviewstreamsize = FILEHEADER_SIZE;
            using (MemoryMappedViewStream viewstream = mmf.CreateViewStream(offset, curviewstreamsize, MemoryMappedFileAccess.Read))
            {
                m_fileheader = viewstream.ReadStruct<CR2WFileHeader>();
                if (m_fileheader.version > 163 || m_fileheader.version < 159)
                    throw new FormatException($"Unknown Version {m_fileheader.version}. Supported versions: 159 - 163.");

                offset += curviewstreamsize;
            }
            #endregion

            #region Read tableheaders
            curviewstreamsize = TABLEHEADER_SIZE;
            using (MemoryMappedViewStream viewstream = mmf.CreateViewStream(offset, curviewstreamsize, MemoryMappedFileAccess.Read))
            {
                var dt = new CDateTime(m_fileheader.timeStamp, null, "");

                m_tableheaders = viewstream.ReadStructs<CR2WTable>(10);
                m_hasInternalBuffer = m_fileheader.bufferSize > m_fileheader.fileSize;

                offset += curviewstreamsize;
            }
            #endregion

            #region Read StringsBuffer
            curviewstreamsize = (long)m_tableheaders[0].size;
            using (MemoryMappedViewStream viewstream = mmf.CreateViewStream(offset, curviewstreamsize, MemoryMappedFileAccess.Read))
            {
                // read strings
                m_strings = ReadStringsBuffer(viewstream);

                offset += curviewstreamsize;
            }
            #endregion

            #region Read tables
            int totalsize = 0;
            for (int i = 0; i < 6; i++)
            {
                totalsize += ((int)m_tableheaders[i + 1].size * TABLES_SIZES[i]);
            }

            curviewstreamsize = (long)totalsize;
            using (MemoryMappedViewStream viewstream = mmf.CreateViewStream(offset, curviewstreamsize, MemoryMappedFileAccess.Read))
            {
                // read tables
                names = ReadTable<CR2WName>(viewstream, 1).Select(_ => new CR2WNameWrapper(_, this)).ToList();
                imports = ReadTable<CR2WImport>(viewstream, 2).Select(_ => new CR2WImportWrapper(_, this)).ToList();
                properties = ReadTable<CR2WProperty>(viewstream, 3).Select(_ => new CR2WPropertyWrapper(_)).ToList();
                chunks = ReadTable<CR2WExport>(viewstream, 4).Select(_ => new CR2WExportWrapper(_, this)).ToList();
                buffers = ReadTable<CR2WBuffer>(viewstream, 5).Select(_ => new CR2WBufferWrapper(_)).ToList();
                embedded = ReadTable<CR2WEmbedded>(viewstream, 6).Select(_ => new CR2WEmbeddedWrapper(_)
                {
                    ParentFile = this,
                    ParentImports = imports,
                    Handle = StringDictionary[_.path],
                }).ToList();

                offset += curviewstreamsize;
            }
            #endregion

            if (Logger != null) Logger.LogProgress(25);

            #region Read Chunks
            

            var tasks = new List<Task>();

            if (Logger != null) Logger.LogProgress(1, "Reading chunks...");
            // Read object data //block 5
            for (int i = 0; i < chunks.Count; i++)
            {
                CR2WExportWrapper chunk = chunks[i];

                tasks.Add(Task.Run(() =>
                chunk.ReadData(mmf)
                    ))
                    ;
            }


            Task.WaitAll(tasks.ToArray());

            if (Logger != null) Logger.LogProgress(50);
            //if (Logger != null) Logger.LogString($"{stopwatch1.Elapsed} CHUNKS\n");


            #endregion




            #region Read Buffers
            // Read buffer data //block 6
            if (m_hasInternalBuffer)
            {
                for (int i = 0; i < buffers.Count; i++)
                {
                    CR2WBufferWrapper buffer = buffers[i];
                    buffer.ReadData(mmf);

                    int percentprogress = (int)((float)i / (float)buffers.Count * 100.0);
                    if (Logger != null) Logger.LogProgress(percentprogress);
                }
            }

            if (Logger != null) Logger.LogProgress(75);
            //if (Logger != null) Logger.LogString($"{stopwatch1.Elapsed} BUFFERS\n");
            #endregion



            #region Read embedded files
            // Read embedded files //block 7
            for (int i = 0; i < embedded.Count; i++)
            {
                CR2WEmbeddedWrapper emb = embedded[i];
                emb.ReadData(mmf);

                int percentprogress = (int)((float)i / (float)embedded.Count * 100.0);
                if (Logger != null) Logger.LogProgress(percentprogress, $"Reading embedded file {emb.ClassName}...");
            }

            if (Logger != null) Logger.LogProgress(100);
            //if (Logger != null) Logger.LogString($"{stopwatch1.Elapsed} EMBEDDED\n");
            #endregion


            stopwatch1.Stop();

            // dbg
            // check self
            (var nameslist, var importslist) = GenerateStringtable();

            for (int i = 0; i < nameslist.Count; i++)
            {
                if (nameslist[i] != this.StringDictionary.Values.ToList()[i])
                {
                    throw new NotImplementedException();
                }
            }

            if (Logger != null) Logger.LogString($"File {FileName} loaded in: {stopwatch1.Elapsed}\n");
            stopwatch1.Stop();


            return this;
        }

        #endregion



        public CVariable ReadVariable(BinaryReader file, CVariable parent)
        {
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            // Read Name
            var nameId = file.ReadUInt16();
            if (nameId == 0)
            {
                return null;
            }
            var varname = names[nameId].Str;

            // Read Type
            var typeId = file.ReadUInt16();
            var typename = names[typeId].Str;

            // Read Size
            var sizepos = file.BaseStream.Position;
            var size = file.ReadUInt32();
            
            // Read Value
            var parsedvar = CR2WTypeManager.Create(typename, varname, this, parent);
            parsedvar.Read(file, size - 4);

            var afterVarPos = file.BaseStream.Position;

            var bytesleft = size - (afterVarPos - sizepos);
            if (bytesleft > 0)
            {
                var unreadBytes = file.ReadBytes((int)bytesleft);
                //Debugger.Break();
            }
            else if (bytesleft < 0)
            {
                throw new InvalidParsingException("Parsing Variable read too far.");
            }

            //if (Logger != null) Logger.LogString($"{stopwatch.Elapsed} CVariable <{typename}>{varname}");
            //stopwatch.Stop();

            return parsedvar;
        }

        public static void WriteVariable(BinaryWriter file, IEditableVariable ivar)
        {
            if (ivar is CVariable cvar)
            {
                file.Write(cvar.GetnameId());
                file.Write(cvar.GettypeId());

                var pos = file.BaseStream.Position;
                file.Write((uint)0); // size placeholder


                cvar.Write(file);
                var endpos = file.BaseStream.Position;

                file.Seek((int)pos, SeekOrigin.Begin);
                var actualsize = (uint)(endpos - pos);
                file.Write(actualsize); // Write size
                file.Seek((int)endpos, SeekOrigin.Begin);
            }
            else
                throw new SerializationException();
        }


        #region Write
        public void Write(BinaryWriter file)
        {
            //m_stream = file.BaseStream;

            // update data
            //m_fileheader.timeStamp = CDateTime.Now.ToUInt64();    //this will change any vanilla assets simply by opening and saving in wkit
            //m_fileheader.numChunks = (uint)chunks.Count;          //this is weird, I don't think it actually is the number of chunks
            var nn = new List<CR2WNameWrapper>(names);

            #region Update Tables
            (var nameslist, var importslist) = GenerateStringtable();
            var stringlist = new List<string>(nameslist);
            foreach (var import in importslist)
            {
                if (!nameslist.Contains(import.Item1))
                    nameslist.Add(import.Item1);
                if (!stringlist.Contains(import.Item1))
                    stringlist.Add(import.Item1);
                if (!stringlist.Contains(import.Item2))
                    stringlist.Add(import.Item2);
            }
            //TODO add new embedded
            foreach (var emb in embedded)
            {
                if (!stringlist.Contains(emb.Handle))
                    stringlist.Add(emb.Handle);
            }

            #region Stringtable
            uint stringbuffer_offset = 160; // always 160
            m_tableheaders[0].offset = stringbuffer_offset;

            var newstrings = new List<byte>();
            foreach (var str in stringlist)
            {
                if (str != null)
                {
                    var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(str);
                    foreach (var b in bytes)
                    {
                        newstrings.Add(b);
                    }
                }
                newstrings.Add((byte)0);
                
            }
            m_strings = newstrings.ToArray();

            var stringscount = m_strings.Length;
            m_tableheaders[0].size = (uint)stringscount;
            m_tableheaders[0].crc32 = Crc32Algorithm.Compute(m_strings);

            StringDictionary.Clear();
            StringDictionary = new Dictionary<uint, string>();
            StringBuilder sb = new StringBuilder();
            var tempstring = new List<byte>();
            uint offset = 0;
            for (uint i = 0; i < stringscount; i++)
            {
                byte b = m_strings[i];
                if (b == 0)
                {
                    var text = Encoding.GetEncoding("iso-8859-1").GetString(tempstring.ToArray());
                    StringDictionary.Add(offset, text);
                    //StringDictionary.Add(offset, sb.ToString());
                    sb.Clear();
                    tempstring.Clear();
                    offset = i + 1;
                }
                else
                {
                    sb.Append((char)b);
                    tempstring.Add(b);
                }
            }
            #endregion

            var inverseDictionary = StringDictionary.ToDictionary(x => x.Value, x => x.Key);

            #region Names
            names.Clear();
            foreach (var name in nameslist)
            {
                //var encodedstring = Encoding.GetEncoding("iso-8859-1")
                var newoffset = inverseDictionary[name];
                var hash = FNV1A32HashAlgorithm.HashString(name, Encoding.GetEncoding("iso-8859-1"), true);
                names.Add(new CR2WNameWrapper(new CR2WName()
                {
                    hash = hash,
                    value = newoffset
                }, this));
            }
            #endregion
            #region Imports
            imports.Clear();
            foreach (var import in importslist)
            {
                var nw = names.First(_ => _.Str == import.Item1);
                ushort flag = (ushort)import.Item3;

                imports.Add(new CR2WImportWrapper(
                    new CR2WImport()
                    {
                        className = (ushort)names.IndexOf(nw),
                        depotPath = inverseDictionary[import.Item2],
                        flags = (ushort)import.Item3    //TODO finish all flags
                    }, this));
            }
            #endregion
            #region Embedded 
            for (var i = 0; i < embedded.Count; i++)
            {
                var emb = embedded[i];
                // update path index
                var handleoffset = inverseDictionary[emb.Handle];
                if (handleoffset != emb.Embedded.path)
                {
                    emb.SetPath(handleoffset);
                    // check path hash
                    var pathhash = FNV1A64HashAlgorithm.HashString(emb.Handle);
                    if (pathhash != emb.Embedded.pathHash)
                        emb.SetPathHash(pathhash);
                }
                // uddate import index
                int realidx = (int)emb.Embedded.importIndex - 1;
                if (imports[realidx].ClassNameStr != emb.ImportClass || emb.ImportPath != imports[realidx].DepotPathStr)
                {
                    var importindex = imports.FindIndex(_ => _.ClassNameStr == emb.ImportClass && _.DepotPathStr == emb.ImportPath);
                    if (importindex != -1)
                        emb.SetImportIndex((uint)importindex);
                }
            }
            #endregion
            #endregion


            headerOffset = 0;
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                // first write the file to memory
                // this also sets m_fileheader.fileSize and m_fileheader.bufferSize, offsets
                WriteData(bw);

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
                chunks[i].SetType( (ushort)GetStringIndex(chunks[i].REDType));
            }
            if (m_hasInternalBuffer)
            {
                for (var i = 0; i < buffers.Count; i++)
                {
                    var newoffset = buffers[i].Buffer.offset + headerOffset;
                    buffers[i].SetOffset(newoffset);
                }
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

            //m_stream = null;

            void FixExportCRC32(CR2WExport export) //FIXME do I wanna keep the ref?
            {
                file.BaseStream.Seek(export.dataOffset, SeekOrigin.Begin);
                var m_temp = new byte[export.dataSize];
                file.BaseStream.Read(m_temp, 0, m_temp.Length);
                export.crc32 = Crc32Algorithm.Compute(m_temp);
            }

            void FixBufferCRC32(CR2WBuffer buffer) //FIXME do I wanna keep the ref?
            {
                //This might throw errors, the way it should be checked for is by reading
                //the object tree to find the deferred data buffers that will point to a buffer.
                //The flag of the parent object indicates where to read the data from.
                //For now this is a crude workaround.
                if (m_hasInternalBuffer)
                {
                    file.BaseStream.Seek(buffer.offset, SeekOrigin.Begin);
                    var m_temp = new byte[buffer.diskSize];
                    file.BaseStream.Read(m_temp, 0, m_temp.Length);
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private (List<string>, List<Tuple<string, string, EImportFlags>>) GenerateStringtable()
        {
            var newnameslist = new List<string>
            {
                ""
            };
            var newimportslist = new List<Tuple<string,string, EImportFlags>>();
            var newsoftlist = new List<Tuple<string,string, EImportFlags>>();

            var guidlist = new List<Guid>();
            var chunkguidlist = new List<Guid>();

            foreach (var c in chunks)
            {
                chunkguidlist.Add(c.data.InternalGuid);
                LoopWrapper(new Tuple<string, IEditableVariable>("skipName", c.data));
            }
            
            newimportslist.AddRange(newsoftlist);

            return (newnameslist, newimportslist);

            void LoopWrapper(Tuple<string, IEditableVariable> var)
            {
                if (guidlist.Contains(var.Item2.InternalGuid))
                {
                    return;
                }

                //collection.Add(var);
                AddStrings(var);

                List<Tuple<string, IEditableVariable>> nextl = GetVariables(var.Item2);
                if (nextl == null)
                    return;
                foreach (var l in nextl)
                {
                    if (l.Item2 != null)
                        LoopWrapper(l);
                }
            }


            
            List<Tuple<string, IEditableVariable>> GetVariables(IEditableVariable ivar)
            {
                //check for looping references
                if (guidlist.Contains(ivar.InternalGuid))
                    return null;
                else
                    guidlist.Add(ivar.InternalGuid);

                var returnedVariables = new List<Tuple<string, IEditableVariable>>();

                // if variable is array
                if (ivar is IArrayAccessor a)
                {
                    if (a is CArray<CBool>
                        || a is CArray<CName>
                        || a is CArray<CUInt16>
                        || a is CArray<CInt16>
                        || a is CArray<CUInt32>
                        || a is CArray<CInt32>
                        || a is CArray<CUInt64>
                        || a is CArray<CInt64>
                        )
                    {
                        if (a is CArray<CName>)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("", a)); ///???
                    }
                    else
                    {
                        var elements = a.GetEditableVariables();
                        foreach (var item in elements)
                        {
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("skipName,skipType", item));
                        }
                    }

                }
                else if (ivar is IPtrAccessor p)
                {
                    if (p.Reference != null)
                        returnedVariables.Add(new Tuple<string, IEditableVariable>("", p.Reference.data));
                }
                else if (ivar is IHandleAccessor h)
                {
                    if (h.ChunkHandle)
                    {
                        if (h.Reference != null)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("", h.Reference.data));
                    }
                }
                else if (ivar is ISoftAccessor s)
                {
                }
                else if (ivar is IdHandle i)
                {
                    returnedVariables.Add(new Tuple<string, IEditableVariable>("", i));
                    returnedVariables.Add(new Tuple<string, IEditableVariable>("", i.handle.Reference?.data));
                }
                else if (ivar is CVariant cVariant)
                {
                    returnedVariables.Add(new Tuple<string, IEditableVariable>("", cVariant.Variant));
                }
                else if (ivar is CVariable cvar)
                {
                    #region Buffer Hacks Before Variables
                    if (cvar is CEntity ent)
                    {
                        var t = ent.Template;
                        if (t != null)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("skipName,skipType", t));
                    }
                    #endregion

                    // add parent
                    // don't add array type parents
                    // we can check for generc type here
                    if (cvar.Parent != null && !cvar.Parent.GetType().IsGenericType)
                    {
                        //check for looping references
                        if (!guidlist.Contains(cvar.Parent.InternalGuid))
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("", cvar.Parent));
                    }

                    // for all other variables 
                    var existingvars = cvar.GetExistingVariables(false, true);
                    foreach (var item in existingvars)
                    {
                        returnedVariables.Add(new Tuple<string, IEditableVariable>("", (item)));
                    }

                    #region Buffer Hacks After Variables
                    // hack for CUmbraScene *sigh*
                    if (cvar is CFoliageResource)
                    {
                        foreach (SFoliageResourceData item in (cvar as CFoliageResource).Trees)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("", (item)));
                        foreach (SFoliageResourceData item in (cvar as CFoliageResource).Grasses)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("", item));
                    }
                    // hack for CClipMap *sigh*
                    if (cvar is CClipMap)
                        returnedVariables.Add(new Tuple<string, IEditableVariable>("", (cvar as CClipMap).tiles));
                    // hack for CUmbraScene *sigh*
                    if (cvar is CUmbraScene)
                        foreach (SUmbraSceneData item in (cvar as CUmbraScene).tiles.elements) //handled in GetStrings
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("", item));

                    // hack for CSkeletalAnimationSetEntry *sigh*
                    if (cvar is CSkeletalAnimationSetEntry)
                        foreach (CVariantSizeType item in (cvar as CSkeletalAnimationSetEntry).Entries)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("", item));
                    // hack for CLayerInfo *sigh*
                    if (cvar is CLayerInfo)
                        returnedVariables.Add(new Tuple<string, IEditableVariable>("", (cvar as CLayerInfo).ParentGroup.Reference?.data));
                    // hack for CMaterialInstance *sigh*
                    if (cvar is CMaterialInstance)
                        foreach (CVariantSizeNameType iparam in (cvar as CMaterialInstance).InstanceParameters)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("", iparam));
                    // hack for CMesh *sigh*
                    if (cvar is CMesh)
                        returnedVariables.Add(new Tuple<string, IEditableVariable>("", (cvar as CMesh).BoneNames));
                    // hack for CBehaviorGraphContainerNode *sigh*
                    if (cvar is CBehaviorGraphContainerNode)
                    {
                        foreach (var item in (cvar as CBehaviorGraphContainerNode).Inputnodes)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("", (item.Reference?.data)));
                        returnedVariables.Add(new Tuple<string, IEditableVariable>("", (cvar as CBehaviorGraphContainerNode).Unk1));
                        returnedVariables.Add(new Tuple<string, IEditableVariable>("", (cvar as CBehaviorGraphContainerNode).Unk2));
                        returnedVariables.Add(new Tuple<string, IEditableVariable>("", (cvar as CBehaviorGraphContainerNode).Outputnode.Reference?.data));
                    }
                    // hack for CBehaviorGraphStateMachineNode *sigh*
                    if (cvar is CBehaviorGraphStateMachineNode)
                    {
                        foreach (var item in (cvar as CBehaviorGraphStateMachineNode).Inputnodes)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("", item.Reference?.data));
                        returnedVariables.Add(new Tuple<string, IEditableVariable>("", (cvar as CBehaviorGraphStateMachineNode).Unk1));
                        returnedVariables.Add(new Tuple<string, IEditableVariable>("", (cvar as CBehaviorGraphStateMachineNode).Unk2));
                    }
                    // hack for CBehaviorGraphStateMachineNode *sigh*
                    if (cvar is CBehaviorGraph)
                    {
                        var b = cvar as CBehaviorGraph;
                        returnedVariables.Add(new Tuple<string, IEditableVariable>("", b.Toplevelnode.Reference?.data));
                        foreach (IdHandle item in b.Variables1)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("", item));
                        foreach (CHandle<CBehaviorVariable> item in b.Descriptions)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("", item.Reference?.data));
                        foreach (IdHandle item in b.Vectorvariables1)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("", item));
                        foreach (IdHandle item in b.Variables2)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("", item));
                        foreach (IdHandle item in b.Vectorvariables2)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("", item));
                    }
                    // hack for CComponent *sigh*
                    if (cvar is CNode)
                    {
                        foreach (CHandle<IAttachment> att in (cvar as CNode).AttachmentsChild)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("skipName,skipType", att));
                        foreach (CHandle<IAttachment> att in (cvar as CNode).AttachmentsReference)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("skipName,skipType", att));
                    }
                    // hack for CEntity *sigh*
                    if (cvar is CEntity e)
                    {
                        foreach (CPtr<CComponent> component in e.Components)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("skipName,skipType", component));
                        foreach (SEntityBufferType1 buffer in e.buffer_v1)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("skipName,skipType", buffer));
                        foreach (SEntityBufferType2 item in e.buffer_v2.elements)
                        {
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("skipName,skipType", item.componentName));
                            foreach (CVariantSizeTypeName el in item.variables.elements)
                            {
                                returnedVariables.Add(new Tuple<string, IEditableVariable>("Typefirst", el.Variable));
                            }
                        }
                    }
                    // hack for SAppearanceAttachment *sigh*
                    if (cvar is SAppearanceAttachment aa)
                        foreach (CVariable item in aa.Data.elements)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("skipName", item));
                    // hack for CSkeletalAnimationSetEntry *sigh*
                    if (cvar is CSkeletalAnimationSetEntry)
                        foreach (CVariantSizeType item in (cvar as CSkeletalAnimationSetEntry).Entries)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("skipName,skipType", item));
                    // hack for SAppearanceAttachment *sigh*
                    if (cvar is CCutsceneTemplate)
                        foreach (CVariantSizeType item in (cvar as CCutsceneTemplate).animevents.elements)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("skipName,skipType", item.Variable));
                    // hack for CStorySceneSection *sigh*
                    if (cvar is CStorySceneSection)
                        foreach (var item in (cvar as CStorySceneSection).sceneEventElements)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("skipName,skipType", item));
                    // hack for CStorySceneScript *sigh*
                    if (cvar is CStorySceneScript)
                        foreach (CVariant item in (cvar as CStorySceneScript).parameters)
                            returnedVariables.Add(new Tuple<string, IEditableVariable>("skipName,skipType", item));
                    // hack for CFXTrackItem *sigh*
                    if (cvar is CFXTrackItem)
                        returnedVariables.Add(new Tuple<string, IEditableVariable>("skipName,skipType", (cvar as CFXTrackItem).buffername));
                    // hack for CPhysicalCollision *sigh*
                    if (cvar is CPhysicalCollision)
                    {
                        returnedVariables.Add(new Tuple<string, IEditableVariable>("", (cvar as CPhysicalCollision).Collisiontypes));
                    }
                    #endregion
                }
                

                return returnedVariables;
            }

            void AddStrings(Tuple<string, IEditableVariable> tvar)
            {
                var var = tvar.Item2;

                if (var.REDType.StartsWith("CEnum"))
                {

                }

                if (var is SFoliageInstance)
                    return;
                if (!(var is CBufferVLQ<CName> ||
                    var is IdHandle ||
                    var is SEntityBufferType1 ||
                    var is SUmbraSceneData)
                    )
                {
                    if (tvar.Item1.Contains("Typefirst"))
                    {
                        AddUniqueToTable(var.REDType);
                        AddUniqueToTable(var.REDName);
                    }
                    else if (tvar.Item1 == "skipName" || chunkguidlist.Contains(tvar.Item2.InternalGuid))
                    {
                        AddUniqueToTable(var.REDType);
                    }
                    else if (tvar.Item1 == "skipType")
                    {
                        AddUniqueToTable(var.REDName);
                    }
                    else if (!tvar.Item1.Contains("skipName,skipType"))
                    {
                        AddUniqueToTable(var.REDName);
                        AddUniqueToTable(var.REDType);
                    }
                }

                if (var is SUmbraSceneData)
                {
                    var h = (var as SUmbraSceneData).umbratile;
                    if (!h.ChunkHandle)
                    {
                        AddUniqueToTable(h.ClassName);
                        var importtuple = new Tuple<string, string, EImportFlags>(h.ClassName, h.DepotPath, EImportFlags.Default);
                        if (!newimportslist.Contains(importtuple))
                        {
                            newimportslist.Add(importtuple);
                        }
                    }
                }
                else if (var is CFlags)
                {
                    foreach (var flag in (var as CFlags).flags)
                    {
                        AddUniqueToTable(flag.Value);
                    }
                }
                else if (var is TagList)
                {
                    foreach (var tag in (var as TagList).tags)
                    {
                        AddUniqueToTable(tag.Value);
                    }
                }
                else if (var is IHandleAccessor h)
                {
                    if (!h.ChunkHandle)
                    {
                        AddUniqueToTable(h.ClassName);
                        var flags = EImportFlags.Default;
                        if (h.REDName == "template" && h.ClassName == "CEntityTemplate")
                            flags = EImportFlags.Template;
                        if (var.cr2w.embedded.Any(_ => _.ImportPath == h.DepotPath && _.ImportClass == h.ClassName))
                            flags = EImportFlags.Inplace;

                        var importtuple = new Tuple<string, string, EImportFlags>(h.ClassName, h.DepotPath, flags);
                        if (!newimportslist.Contains(importtuple))
                        {
                            newimportslist.Add(importtuple);
                        }
                    }
                }
                else if (var is ISoftAccessor s)
                {
                    if (!(string.IsNullOrEmpty(s.ClassName) && string.IsNullOrEmpty(s.DepotPath)))
                    {
                        AddUniqueToTable(s.REDType);
                        var stuple = new Tuple<string, string, EImportFlags>(s.ClassName, s.DepotPath, EImportFlags.Soft);
                        if (!newsoftlist.Contains(stuple))
                        {
                            newsoftlist.Add(stuple);
                        }
                    }
                }
                else if (var is CName)
                {
                    var n = var as CName;
                    AddUniqueToTable(n.Value);
                }
                else if (var is IArrayAccessor a)
                {
                    AddUniqueToTable(a.REDName);
                    AddUniqueToTable(a.REDType);

                    if (var is CArray<CName> aa)
                    {
                        foreach (var element in aa)
                        {
                            AddUniqueToTable(element.Value);
                        }
                    }
                    
                }
                else if (var is CBufferVLQ<CName>)
                {
                    foreach (var element in (var as CBufferVLQ<CName>).elements)
                    {
                        if (element is CName )
                        {
                            AddUniqueToTable((element as CName).Value);
                        }
                    }
                }
                else if (var is /*CBufferUInt32<IHandleAccessor>*/ IBufferAccessor buffer)
                {
                    foreach (IEditableVariable ivar in buffer.GetEditableVariables())
                    {
                        if (ivar is IHandleAccessor ha)
                        {
                            if (!ha.ChunkHandle)
                            {
                                AddUniqueToTable(ha.ClassName);
                                var flags = EImportFlags.Default;
                                if (ha.REDName == "template")
                                    flags = EImportFlags.Template;
                                var importtuple = new Tuple<string, string, EImportFlags>(ha.ClassName, ha.DepotPath, flags);
                                if (!newimportslist.Contains(importtuple))
                                {
                                    newimportslist.Add(importtuple);
                                }
                            }
                        }
                        
                    }
                }
                else if (var is IPtrAccessor)
                {
                }
                else if (var is IdHandle)
                {
                    AddUniqueToTable((var as IdHandle).handlename.Value);
                }
                else if (var is CString)
                {
                    AddUniqueToTable(var.REDName);
                    AddUniqueToTable(var.REDType);
                }
                else if (var is SEntityBufferType1)
                {
                    AddUniqueToTable((var as SEntityBufferType1).ComponentName.Value);
                }
                else if (var is IEnumAccessor enumAccessor)
                {
                    AddUniqueToTable(enumAccessor.Value);
                }
                else
                {
                    if (!tvar.Item1.Contains("skipName,skipType"))
                        AddUniqueToTable(var.REDType);
                }
            }

            void AddUniqueToTable(string str)
            {
                if (string.IsNullOrEmpty(str))
                {
                    // todo
                }
                else
                {
                    if (!newnameslist.Contains(str))
                    {
                        // hack for CApexClothResource *sigh*
                        if (str == "apexMaterialNames")
                        {
                            if (!newnameslist.Contains("apexBinaryAsset"))
                                newnameslist.Add("apexBinaryAsset");
                            if (!newnameslist.Contains("array: 95, 0, Uint8"))
                                newnameslist.Add("array:95,0,Uint8");
                        }

                        newnameslist.Add(str);
                    }
                }
            }
        }

        private void WriteHeader(BinaryWriter file)
        {
            WriteFileHeader(file);

            #region Write Tables
            m_tableheaders[1].size = (uint)names.Count;
            m_tableheaders[1].offset = (uint) file.BaseStream.Position;
            WriteTable<CR2WName>(file.BaseStream, names.Select(_ => _.Name).ToArray(), 1);
            
            m_tableheaders[2].size = (uint)imports.Count;
            m_tableheaders[2].offset = imports.Count > 0 ? (uint) file.BaseStream.Position : 0;
            WriteTable<CR2WImport>(file.BaseStream, imports.Select(_ => _.Import).ToArray(), 2);

            m_tableheaders[3].size = (uint)properties.Count;
            m_tableheaders[3].offset = (uint) file.BaseStream.Position;
            WriteTable<CR2WProperty>(file.BaseStream, properties.Select(_ => _.Property).ToArray(), 3);

            m_tableheaders[4].size = (uint)chunks.Count;
            m_tableheaders[4].offset = (uint) file.BaseStream.Position;
            WriteTable<CR2WExport>(file.BaseStream, chunks.Select(_ => _.Export).ToArray(), 4);

            if (buffers.Count > 0)
            {
                m_tableheaders[5].size = (uint)buffers.Count;
                m_tableheaders[5].offset = (uint)file.BaseStream.Position;
                WriteTable<CR2WBuffer>(file.BaseStream, buffers.Select(_ => _.Buffer).ToArray(), 5);
            }

            if (embedded.Count > 0)
            {
                m_tableheaders[6].size = (uint)embedded.Count;
                m_tableheaders[6].offset = (uint)file.BaseStream.Position;
                WriteTable<CR2WEmbedded>(file.BaseStream, embedded.Select(_ => _.Embedded).ToArray(), 6);
            }
            #endregion
        }

        private void WriteFileHeader(BinaryWriter file)
        {
            file.BaseStream.Seek(0, SeekOrigin.Begin);

            file.BaseStream.WriteStruct<uint>(MAGIC);
            file.BaseStream.WriteStruct<CR2WFileHeader>(m_fileheader);
            file.BaseStream.WriteStructs<CR2WTable>(m_tableheaders); // offsets change if stringtable changes
            WriteStringBuffer(file.BaseStream);
        }

        private void WriteData(BinaryWriter bw)
        {
            // Write chunk data
            for (var i = 0; i < chunks.Count; i++)
            {
                chunks[i].WriteData(bw);
            }

            m_fileheader.fileSize = (uint)bw.BaseStream.Position;

            //Write Buffer data
            if (m_hasInternalBuffer)
            {
                for (var i = 0; i < buffers.Count; i++)
                {
                    buffers[i].WriteData(bw);
                }
            }
            m_fileheader.bufferSize = (uint)bw.BaseStream.Position;

            // Write embedded data
            for (var i = 0; i < embedded.Count; i++)
            {
                embedded[i].WriteData(bw);
            }

            
        }
        #endregion

        #region Table Reading
        private byte[] ReadStringsBuffer(Stream stream)
        {
            var start = m_tableheaders[0].offset;
            var size = m_tableheaders[0].size;
            var crc = m_tableheaders[0].crc32;

            var m_temp = new byte[size];
            stream.Read(m_temp, 0, m_temp.Length);

            StringDictionary = new Dictionary<uint, string>();
            StringBuilder sb = new StringBuilder();
            uint offset = 0;
            var tempstring = new List<byte>();
            for (uint i = 0; i < size; i++)
            {
                byte b = m_temp[i];
                if (b == 0)
                {
                    var text = Encoding.GetEncoding("iso-8859-1").GetString(tempstring.ToArray());
                    StringDictionary.Add(offset, text);
                    //StringDictionary.Add(offset, sb.ToString());
                    sb.Clear();
                    tempstring.Clear();
                    offset = i + 1;
                }
                else
                {
                    sb.Append((char)b);
                    tempstring.Add(b);
                }
            }

            return m_temp;
        }
        private void WriteStringBuffer(Stream stream)
        {
            m_tableheaders[0].crc32 = Crc32Algorithm.Compute(m_strings);
            stream.Write(m_strings, 0, m_strings.Length);
        }

        private T[] ReadTable<T>(Stream stream, int index) where T : struct
        {
            //stream.Seek(m_tableheaders[index].offset, SeekOrigin.Begin);

            var hash = new Crc32Algorithm(false);
            var table = stream.ReadStructs<T>(m_tableheaders[index].size, hash);

            return table;
        }
        private void WriteTable<T>(Stream stream, T[] array, int index) where T : struct
        {
            if (array.Length == 0)
                return;

            var crc = new Crc32Algorithm(false);
            stream.WriteStructs<T>(array, crc);
            m_tableheaders[index].crc32 = crc.HashUInt32;
        }
        #endregion

        #region Supporting Functions
        public void SerializeToXml(Stream writer)
        {
            var settings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = "\t",
                NewLineOnAttributes = true
            };
            using (XmlWriter xw = XmlWriter.Create(writer, settings))
            {
                XmlSerializer.SerializeStartObject<CR2WFile>(xw, this);

                XmlSerializer.SerializeObject<CR2WFileHeader>(xw, m_fileheader);
                XmlSerializer.SerializeObject<CR2WTable[]>(xw, m_tableheaders);

                XmlSerializer.SerializeObject(xw, names.Select(_ => new Tuple<int, string>(names.IndexOf(_), _.Str)).ToArray());
                XmlSerializer.SerializeObject<CR2WName[]>(xw, names.Select(_ => _.Name).ToArray());
                XmlSerializer.SerializeObject<CR2WImport[]>(xw, imports.Select(_ => _.Import).ToArray());
                XmlSerializer.SerializeObject<CR2WProperty[]>(xw, properties.Select(_ => _.Property).ToArray());
                XmlSerializer.SerializeObject<CR2WExport[]>(xw, chunks.Select(_ => _.Export).ToArray());
                XmlSerializer.SerializeObject<CR2WBuffer[]>(xw, buffers.Select(_ => _.Buffer).ToArray());
                XmlSerializer.SerializeObject<CR2WEmbedded[]>(xw, embedded.Select(_ => _.Embedded).ToArray());

                XmlSerializer.SerializeEndObject<CR2WFile>(xw);


                xw.Flush();
                xw.Close();
            }
        }

        public void SerializeChunksToXml(Stream writer)
        {
            var settings = new XmlWriterSettings()
            {
                Indent = true,
                IndentChars = "\t",
                NewLineOnAttributes = true
            };
            using (XmlWriter xw = XmlWriter.Create(writer, settings))
            {
                XmlSerializer.SerializeStartObject<CR2WFile>(xw, this);
                XmlSerializer.SerializeObjectContent<CR2WFile>(xw, this);
                xw.WriteStartElement("chunks");
                foreach(var ew in chunks)
                {
                    ew.SerializeToXml(xw);
                }
                xw.WriteEndElement();
                XmlSerializer.SerializeEndObject<CR2WFile>(xw);
                

                xw.Flush();
                xw.Close();
            }
        }

        //private T ReadStruct<T>(Crc32Algorithm crc32 = null) where T : struct
        //{
        //    var size = Marshal.SizeOf<T>();

        //    var m_temp = new byte[size];
        //    m_stream.Read(m_temp, 0, size);

        //    var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);
        //    var item = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());

        //    if (crc32 != null)
        //        crc32.Append(m_temp);

        //    handle.Free();

        //    return item;
        //}
        //private T[] ReadStructs<T>(uint count, Crc32Algorithm crc32 = null) where T : struct
        //{
        //    var size = Marshal.SizeOf<T>();
        //    var items = new T[count];

        //    var m_temp = new byte[size];
        //    for (uint i = 0; i < count; i++)
        //    {
        //        m_stream.Read(m_temp, 0, size);

        //        var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);
        //        items[i] = Marshal.PtrToStructure<T>(handle.AddrOfPinnedObject());

        //        if (crc32 != null)
        //            crc32.Append(m_temp);

        //        handle.Free();
        //    }

        //    return items;
        //}
        //private void WriteStruct<T>(T value, Crc32Algorithm crc32 = null) where T : struct
        //{
        //    var m_temp = new byte[Marshal.SizeOf<T>()];
        //    var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);

        //    Marshal.StructureToPtr(value, handle.AddrOfPinnedObject(), true);
        //    m_stream.Write(m_temp, 0, m_temp.Length);

        //    if (crc32 != null)
        //        crc32.Append(m_temp);

        //    handle.Free();
        //}
        //private void WriteStructs<T>(T[] array, Crc32Algorithm crc32 = null) where T : struct
        //{
        //    var size = Marshal.SizeOf<T>();
        //    var m_temp = new byte[size];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        var handle = GCHandle.Alloc(m_temp, GCHandleType.Pinned);

        //        Marshal.StructureToPtr(array[i], handle.AddrOfPinnedObject(), true);
        //        m_stream.Write(m_temp, 0, m_temp.Length);

        //        if (crc32 != null)
        //            crc32.Append(m_temp);

        //        handle.Free();
        //    }
        //}
        #endregion

        #region Create
        public CR2WExportWrapper CreateChunk(string type, CR2WExportWrapper parent = null)
        {
            
            var chunk = new CR2WExportWrapper(this)
            {
                REDType = type
            };

            chunk.CreateDefaultData();
            if (parent != null)
            {
                chunk.SetParentChunkId((uint)chunks.IndexOf(parent) + 1);
            }

            chunks.Add(chunk);
            return chunk;
        }

        public int GetStringIndex(string name, bool addnew = false)
        {
            for (var i = 0; i < names.Count; i++)
            {
                if (names[i].Str == name || (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(names[i].Str)))
                    return i;
            }

            throw new NotImplementedException();
            return -1;
        }

        public CR2WExportWrapper GetChunkByType(string type)
        {
            for (var i = 0; i < chunks.Count; i++)
            {
                if (chunks[i].REDType == type)
                    return chunks[i];
            }

            return null;
        }

        public bool RemoveChunk(CR2WExportWrapper chunk)
        {
            return chunks.Remove(chunk);
        }
        #endregion
    }
}