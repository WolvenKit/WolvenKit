using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.CR2W.Types;
using Newtonsoft.Json;
using RED.CRC32;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;

namespace CP77.CR2W
{
    public class CR2WFile : Catel.Data.ObservableObject, IWolvenkitFile
    {
        #region Enums

        public enum EChunkDisplayMode
        {
            Linear,
            Parent,
            VirtualParent
        }

        #endregion Enums

        #region Constants

        public const uint MAGIC = 0x57325243; // "W2RC"
        private const long FILEHEADER_SIZE = 36;
        private const long MAGIC_SIZE = 4;
        private const long TABLEHEADER_SIZE = 12 * 10;
        private readonly int[] TABLES_SIZES = new int[6] { 8, 8, 16, 24, 24, 24 };

        #endregion Constants

        #region Constructors

        public CR2WFile()
        {
            Names = new List<CR2WNameWrapper>();            //block 2
            Imports = new List<ICR2WImport>();              //block 3
            Properties = new List<CR2WPropertyWrapper>();   //block 4
            Chunks = new List<ICR2WExport>();               //block 5
            Buffers = new List<ICR2WBuffer>();              //block 6
            Embedded = new List<CR2WEmbeddedWrapper>();     //block 7

            m_fileheader = new CR2WFileHeader()
            {
                version = 162,
            };

            Logger = ServiceLocator.Default.ResolveType<ILoggerService>();

            StringDictionary = new Dictionary<uint, string>();
            m_tableheaders = new CR2WTable[10];
        }

        #endregion Constructors

        #region Fields

        // constants

        public byte[] AdditionalCr2WFileBytes;
        private const uint DEADBEEF = 0xDEADBEEF;

        private CR2WFile additionalCr2WFile;

        // misc
        private uint headerOffset = 0;

        // IO
        private CR2WFileHeader m_fileheader;

        private byte[] m_strings;
        private CR2WTable[] m_tableheaders;
        //private bool m_hasInternalBuffer;

        #endregion Fields

        #region Properties

        public readonly List<string> UnknownTypes = new();

        [JsonIgnore]
        public List<LocalizedString> LocalizedStrings = new List<LocalizedString>();

        public List<ICR2WBuffer> Buffers { get; private set; }
        public List<ICR2WExport> Chunks { get; private set; }

        [JsonIgnore]
        public Dictionary<int, ICR2WExport> Chunksdict { get; private set; }

        [JsonIgnore]
        public IVariableEditor EditorController { get; set; }

        public List<CR2WEmbeddedWrapper> Embedded { get; private set; }
        public string FileName { get; set; }
        public CR2WFileHeader Header => m_fileheader;

        public List<ICR2WImport> Imports { get; private set; }

        [JsonIgnore]
        public ILocalizedStringSource LocalizedStringSource { get; set; }

        [JsonIgnore]
        public ILoggerService Logger { get; }

        [JsonIgnore]
        public List<CR2WNameWrapper> Names { get; private set; }

        public List<CR2WPropertyWrapper> Properties { get; private set; }
        public Dictionary<uint, string> StringDictionary { get; private set; }

        #endregion Properties

        #region Supporting Functions

        public static void FixBufferCRC32(Stream stream, ICR2WBuffer buffer)
        {
            //This might throw errors, the way it should be checked for is by reading
            //the object tree to find the deferred data buffers that will point to a buffer.
            //The flag of the parent object indicates where to read the data from.
            //For now this is a crude workaround.
            // var m_hasInternalBuffer = m_fileheader.bufferSize > m_fileheader.fileSize;
            // if (m_hasInternalBuffer)
            {
                stream.Seek(buffer.Offset, SeekOrigin.Begin);
                var m_temp = new byte[buffer.DiskSize];
                stream.Read(m_temp, 0, m_temp.Length);
                buffer.Crc32 = Crc32Algorithm.Compute(m_temp);
            }
            //else
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

        public static void FixExportCRC32(Stream stream, CR2WExport export)
        {
            stream.Seek(export.dataOffset, SeekOrigin.Begin);
            var m_temp = new byte[export.dataSize];
            stream.Read(m_temp, 0, m_temp.Length);
            export.crc32 = Crc32Algorithm.Compute(m_temp);
        }

        public static int GetLastChildrenIndexRecursive(ICR2WExport chunk)
        {
            return !chunk.VirtualChildrenChunks.Any()
                ? chunk.ChunkIndex
                : GetLastChildrenIndexRecursive(chunk.VirtualChildrenChunks
                    .FirstOrDefault(_ => _.ChunkIndex == chunk.VirtualChildrenChunks.Max(p => p.ChunkIndex)));
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

        public uint CalculateHeaderCRC32()
        {
            var hash = new Crc32Algorithm(false);
            hash.Append(BitConverter.GetBytes(MAGIC));
            hash.Append(BitConverter.GetBytes(m_fileheader.version));
            hash.Append(BitConverter.GetBytes(m_fileheader.flags));
            hash.Append(BitConverter.GetBytes(m_fileheader.timeStamp));
            hash.Append(BitConverter.GetBytes(m_fileheader.buildVersion));
            hash.Append(BitConverter.GetBytes(m_fileheader.objectsEnd));
            hash.Append(BitConverter.GetBytes(m_fileheader.buffersEnd));
            hash.Append(BitConverter.GetBytes(DEADBEEF));
            hash.Append(BitConverter.GetBytes(m_fileheader.numChunks));
            foreach (var h in m_tableheaders)
            {
                hash.Append(BitConverter.GetBytes(h.offset));
                hash.Append(BitConverter.GetBytes(h.itemCount));
                hash.Append(BitConverter.GetBytes(h.crc32));
            }
            return hash.HashUInt32;
        }

        // Does not reindex /TODO
        public CR2WExportWrapper CreateChunk(string type, int chunkindex = 0, CR2WExportWrapper parent = null, CR2WExportWrapper virtualparent = null, CVariable cvar = null)
        {
            var chunk = new CR2WExportWrapper(this, type, parent);
            if (cvar != null)
            {
                chunk.CreateDefaultData();
            }
            else
            {
                chunk.CreateDefaultData(cvar);
            }

            if (parent != null)
            {
                chunk.ParentChunk = parent;
            }
            if (virtualparent != null)
            {
                chunk.MountChunkVirtually(virtualparent);
            }

            Chunks.Insert(chunkindex, chunk);
            return chunk;
        }

        // Does not reindex /TODO
        public CR2WExportWrapper CreateChunk(CVariable cvar, int chunkindex = 0, CR2WExportWrapper parent = null, CR2WExportWrapper virtualparent = null)
        {
            // checks to see if the variable from which the chunk is built is properly constructed
            if (cvar == null || cvar.REDName != cvar.REDType || cvar.ParentVar != null)
                throw new InvalidChunkTypeException($"{nameof(CreateChunk)}");

            var chunk = new CR2WExportWrapper(this, cvar.REDType, parent);
            chunk.CreateDefaultData(cvar);

            if (parent != null)
            {
                chunk.ParentChunk = parent;
            }
            if (virtualparent != null)
            {
                chunk.MountChunkVirtually(virtualparent);
            }

            Chunks.Insert(chunkindex, chunk);
            return chunk;
        }

        public void GenerateChunksDict() => Chunksdict = Chunks.ToDictionary(_ => _.ChunkIndex, _ => _);

        public CR2WFileHeader GetFileHeader() => m_fileheader;

        public string GetLocalizedString(uint val)
        {
            return LocalizedStringSource?.GetLocalizedString(val);
        }

        public int GetStringIndex(string name, bool addnew = false)
        {
            for (var i = 0; i < Names.Count; i++)
            {
                if (Names[i].Str == name || (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(Names[i].Str)))
                    return i;
            }

            throw new InvalidParsingException($"{nameof(GetStringIndex)}: {name}");
        }

        public CR2WTable[] GetTableHeaders() => m_tableheaders;

        public (List<string>, int) GetUnknownBytes()
        {
            List<string> types = new();
            foreach (var x in Chunks.Select(chunk => chunk.UnknownTypes)
                .SelectMany(s => s.Where(x => !types.Contains(x))))
            {
                types.Add(x);
            }

            return (types,
                Chunks.Sum(chunk => (chunk.unknownBytes as CBytes).Bytes.Length));
        }

        public CVariable ReadVariable(BinaryReader file, CVariable parent)
        {
            // Read Name
            var nameId = file.ReadUInt16();
            if (nameId == 0)
            {
                return null;
            }
            var varname = Names[nameId].Str;

            // Read Type
            var typeId = file.ReadUInt16();
            var typename = Names[typeId].Str;

            // Read Size
            var sizepos = file.BaseStream.Position;
            var size = file.ReadUInt32();

            // Read Value
            var parsedvar = CR2WTypeManager.Create(typename, varname, this, parent);
            // The "size" variable read is something a bit strange : it takes itself into account.
            parsedvar.Read(file, size - 4);

            var afterVarPos = file.BaseStream.Position;

            var bytesleft = size - (afterVarPos - sizepos);
            if (bytesleft > 0)
            {
                var unreadBytes = file.ReadBytes((int)bytesleft);
                throw new InvalidParsingException($"Parsing Variable read too short. Difference: {bytesleft}");
            }
            else if (bytesleft < 0)
            {
                throw new InvalidParsingException($"Parsing Variable read too far. Difference: {bytesleft}");
            }

            return parsedvar;
        }

        /// <summary>
        /// Deletes the chunk and/or its children chunks.
        /// Reindexes the hierarchy.
        /// </summary>
        /// <param name="toberemovedchunks">The chunks dealt with.</param>
        /// <param name="onlychildren">The method can remove the chunk and descendance, or only the descendance.</param>
        /// <param name="recursionmode">The method can remove only the chunk (Linear), the real children (Parent), the virtual children (VirtualParent).</param>
        /// <param name="purgereferrers">Try to not leave null pointers</param>
        /// <param name="reentrant">Called for children chunks</param>
        /// <param name="passedoldparentinghierarchy">Passed for children chunks</param>
        /// <returns>Number of chunks removed</returns>
        public int RemoveChunks(
            List<ICR2WExport> toberemovedchunks,
            bool onlychildren = false,
            EChunkDisplayMode recursionmode = EChunkDisplayMode.VirtualParent,
            bool purgereferrers = false,
            bool reentrant = false,
            Dictionary<ICR2WExport, (ICR2WExport oldchunkparent, ICR2WExport oldchunkvparent)> passedoldparentinghierarchy = null)
        {
            int removed = onlychildren ? 0 : 1;

            // To reindex later, we need a middle-ground copy, between deep and shallow, of the parenting hierarchy.
            var oldparentinghierarchy = new Dictionary<ICR2WExport, (ICR2WExport oldchunkparent, ICR2WExport oldchunkvparent)>();
            if (!reentrant)
            {
                foreach (var achunk in Chunks)
                {
                    oldparentinghierarchy.Add(achunk, (achunk.ParentChunk, achunk.VirtualParentChunk));
                }
            }

            foreach (var chunk in toberemovedchunks)
            {
                // Nullify references toward this chunk
                if ((!onlychildren && !reentrant) || reentrant)
                {
                    foreach (var referrer in chunk.AdReferences)
                    {
                        if (purgereferrers && referrer.ParentVar is IArrayAccessor)
                        {
                            referrer.ParentVar.RemoveVariable(referrer as IEditableVariable);
                        }
                        else
                        {
                            // This leaves a dangling cptr/chandle in AdReferences,
                            // which needs to be adressed later.
                            referrer.Reference = null;
                        }
                    }
                }

                //Recurse
                int i = 0;
                while (recursionmode != EChunkDisplayMode.Linear)
                {
                    if (i >= Chunks.Count())
                        break;
                    var achunk = Chunks[i++];

                    // Remove children chunks
                    if (recursionmode == EChunkDisplayMode.Parent)
                    {
                        if (!reentrant)
                        {
                            if (oldparentinghierarchy[achunk].oldchunkparent == chunk)
                            {
                                removed += RemoveChunks(
                                    new List<ICR2WExport>() { achunk },
                                    false,
                                    recursionmode,
                                    true,
                                    purgereferrers,
                                    oldparentinghierarchy);
                                i = 0;
                            }
                        }
                        else
                        {
                            if (passedoldparentinghierarchy[achunk].oldchunkparent == chunk)
                            {
                                removed += RemoveChunks(
                                    new List<ICR2WExport>() { achunk },
                                    false,
                                    recursionmode,
                                    true,
                                    purgereferrers,
                                    passedoldparentinghierarchy);
                                i = 0;
                            }
                        }
                    }
                    else if (recursionmode == EChunkDisplayMode.VirtualParent)
                    {
                        if (!reentrant)
                        {
                            if (oldparentinghierarchy[achunk].oldchunkvparent == chunk)
                            {
                                removed += RemoveChunks(
                                    new List<ICR2WExport>() { achunk },
                                    false,
                                    recursionmode,
                                    true,
                                    purgereferrers,
                                    oldparentinghierarchy);
                                i = 0;
                            }
                        }
                        else
                        {
                            if (passedoldparentinghierarchy[achunk].oldchunkvparent == chunk)
                            {
                                removed += RemoveChunks(
                                    new List<ICR2WExport>() { achunk },
                                    false,
                                    recursionmode,
                                    true,
                                    purgereferrers,
                                    passedoldparentinghierarchy);
                                i = 0;
                            }
                        }
                    }
                }

                // Actually remove the chunk
                if ((!reentrant && !onlychildren) || reentrant)
                {
                    Chunks.Remove(chunk);
                }
            }

            // Reindex the tree from the root function call
            if (!reentrant && removed > 0)
            {
                foreach (var achunk in Chunks)
                {
                    achunk.ParentChunk = oldparentinghierarchy[achunk].oldchunkparent;
                }

                //Update UI
                RaisePropertyChanged(nameof(Chunks));
            }

            return removed;
        }

        #endregion Supporting Functions

        #region Read

        public CR2WFile GetAdditionalCr2wFile()
        {
            if (AdditionalCr2WFileBytes == null)
                return null;
            using (var ms2 = new MemoryStream(AdditionalCr2WFileBytes))
            using (var br2 = new BinaryReader(ms2))
            {
                additionalCr2WFile = new CR2WFile();
                additionalCr2WFile.Read(br2);
                return additionalCr2WFile;
            }
        }

        public EFileReadErrorCodes Read(byte[] data)
        {
            using var ms = new MemoryStream(data);
            using var br = new BinaryReader(ms);
            return Read(br);
        }

        /// <summary>
        /// Reads a Cr2wFile from a stream
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        public EFileReadErrorCodes Read(Stream stream)
        {
            using var br = new BinaryReader(stream);
            return Read(br);
        }

        /// <summary>
        /// Reads a Cr2wFile from a BinaryReader stream
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public EFileReadErrorCodes Read(BinaryReader file)
        {
            //m_stream = file.BaseStream;
            StringDictionary.Clear();

            var stopwatch1 = new Stopwatch();
            stopwatch1.Start();

            #region Read Headers

            var startpos = file.BaseStream.Position;

            // read file header
            var id = file.BaseStream.ReadStruct<uint>();
            if (id != MAGIC)
                return EFileReadErrorCodes.NoCr2w;

            m_fileheader = file.BaseStream.ReadStruct<CR2WFileHeader>();
            if (m_fileheader.version > 195 || m_fileheader.version < 163)
                return EFileReadErrorCodes.UnsupportedVersion;

            var dt = new CDateTime(m_fileheader.timeStamp, null, "");

            // Tables [7-9] are not used in cr2w so far.
            m_tableheaders = file.BaseStream.ReadStructs<CR2WTable>(10);
            var m_hasInternalBuffer = m_fileheader.buffersEnd > m_fileheader.objectsEnd;

            // read strings - block 1 (index 0)
            m_strings = ReadStringsBuffer(file.BaseStream);

            // read the other tables
            Names = ReadTable<CR2WName>(file.BaseStream, 1).Select(_ => new CR2WNameWrapper(_, this)).ToList(); // block 2
            Imports = ReadTable<CR2WImport>(file.BaseStream, 2).Select(_ => new CR2WImportWrapper(_, this) as ICR2WImport).ToList(); // block 3
            Properties = ReadTable<CR2WProperty>(file.BaseStream, 3).Select(_ => new CR2WPropertyWrapper(_)).ToList(); // block 4
            Chunks = ReadTable<CR2WExport>(file.BaseStream, 4).Select(_ => new CR2WExportWrapper(_, this) as ICR2WExport).ToList(); // block 5
            Buffers = ReadTable<CR2WBuffer>(file.BaseStream, 5).Select(_ => new CR2WBufferWrapper(_) as ICR2WBuffer).ToList(); // block 6
            Embedded = ReadTable<CR2WEmbedded>(file.BaseStream, 6).Select(_ => new CR2WEmbeddedWrapper(_)
            {
                ParentFile = this,
            }).ToList(); // block 7

            //if (Embedded.Count > 1)
            //    throw new NotImplementedException("Embedded files present?");

            #endregion Read Headers

            #region Read Data

            // Read object data //block 5
            for (int i = 0; i < Chunks.Count; i++)
            {
                ICR2WExport chunk = Chunks[i];

                chunk.ReadData(file);

                //int percentprogress = (int)((float)i / (float)Chunks.Count * 100.0);
                //Logger?.LogProgress(percentprogress, $"Reading chunk {chunk.REDName}...");
            }
            // Read buffer data //block 6
            if (m_hasInternalBuffer)
            {
                for (int i = 0; i < Buffers.Count; i++)
                {
                    var buffer = Buffers[i];
                    buffer.ReadData(file);

                    //int percentprogress = (int)((float)i / (float)Buffers.Count * 100.0);
                    //Logger?.LogProgress(percentprogress);
                }
            }
            // Read embedded files //block 7
            for (int i = 0; i < Embedded.Count; i++)
            {
                //throw new NotImplementedException("embedded files for cp77 are not implemented");

                CR2WEmbeddedWrapper emb = Embedded[i];
                emb.ReadData(file);

                //int percentprogress = (int)((float)i / (float)Embedded.Count * 100.0);
                //Logger?.LogProgress(percentprogress, $"Reading embedded file {emb.ClassName}...");
            }

            #endregion Read Data

            // some w2ls have additional CLayerInfo packed behind the file
            var endpos = file.BaseStream.Position;
            var readbytes = endpos - startpos;
            if (readbytes != file.BaseStream.Length)
            {
                throw new NotImplementedException("additional files for cp77 are not implemented");

                //var bytesleft = file.BaseStream.Length - readbytes;
                //AdditionalCr2WFileBytes = file.ReadBytes((int)bytesleft);
            }

            //Logger?.LogString($"File {FileName} loaded in: {stopwatch1.Elapsed}\n", Logtype.Normal);
            stopwatch1.Stop();
            //m_stream = null;
            return 0;
        }

        public async Task<EFileReadErrorCodes> ReadAsync(byte[] data)
        {
            await using var ms = new MemoryStream(data);
            using var br = new BinaryReader(ms);
            return await Task.Run(() => Read(br));
        }

        public (List<ICR2WImport>, bool, List<ICR2WBuffer>) ReadImportsAndBuffers(BinaryReader file)
        {
            #region Read Headers

            // read file header
            var id = file.BaseStream.ReadStruct<uint>();
            if (id != MAGIC)
                throw new FormatException($"Not a CR2W file, Magic read as 0x{id:X8}");

            m_fileheader = file.BaseStream.ReadStruct<CR2WFileHeader>();

            //TODO: CP77

            if (m_fileheader.version > 195 || m_fileheader.version < 163)
                throw new FormatException($"Unknown Version {m_fileheader.version}. Supported versions: 159 - 163.");

            var dt = new CDateTime(m_fileheader.timeStamp, null, "");

            m_tableheaders = file.BaseStream.ReadStructs<CR2WTable>(10);
            //m_hasInternalBuffer = m_fileheader.bufferSize > m_fileheader.fileSize;

            // read strings
            m_strings = ReadStringsBuffer(file.BaseStream);

            // read tables
            Names = ReadTable<CR2WName>(file.BaseStream, 1).Select(_ => new CR2WNameWrapper(_, this)).ToList();
            Imports = ReadTable<CR2WImport>(file.BaseStream, 2).Select(_ => new CR2WImportWrapper(_, this) as ICR2WImport).ToList();
            Properties = ReadTable<CR2WProperty>(file.BaseStream, 3).Select(_ => new CR2WPropertyWrapper(_)).ToList();
            Chunks = ReadTable<CR2WExport>(file.BaseStream, 4).Select(_ => new CR2WExportWrapper(_, this) as ICR2WExport).ToList();
            Buffers = ReadTable<CR2WBuffer>(file.BaseStream, 5).Select(_ => new CR2WBufferWrapper(_) as ICR2WBuffer).ToList();
            //Embedded = ReadTable<CR2WEmbedded>(file.BaseStream, 6).Select(_ => new CR2WEmbeddedWrapper(_)
            //{
            //    ParentFile = this,
            //    ParentImports = Imports,
            //    Handle = StringDictionary[_.path],
            //}).ToList();

            #endregion Read Headers

            return (Imports, false, Buffers);
        }

        private byte[] ReadStringsBuffer(Stream stream)
        {
            var start = m_tableheaders[0].offset;
            var m_strings_size = m_tableheaders[0].itemCount;
            var crc = m_tableheaders[0].crc32;

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

        #endregion Read

        #region Write

        /// <summary>
        /// How a REDEngine entity is to be serialized
        /// </summary>
        private enum EStringTableMod
        {
            None,
            SkipType,
            SkipName,
            SkipNameAndType,
            TypeFirst
        }

        public (Dictionary<uint, string>, List<byte>, List<string>, List<SImportEntry>) GenerateStringtable()
        {
            Dictionary<uint, string> newstringtable = new Dictionary<uint, string>();

            // Get lists
            (var nameslist, List<SImportEntry> importslist) = GenerateStringtableInner();
            var stringlist = new List<string>(nameslist);
            foreach (var import in importslist)
            {
                if (!nameslist.Contains(import.ClassName))
                    nameslist.Add(import.ClassName);
                if (!stringlist.Contains(import.ClassName))
                    stringlist.Add(import.ClassName);
                if (!stringlist.Contains(import.Path))
                    stringlist.Add(import.Path);
            }
            foreach (var emb in Embedded)
            {
            }

            // create new stringslist
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

            // build new stringsDictionary
            var strings = newstrings.ToArray();
            var stringscount = strings.Length;

            StringBuilder sb = new StringBuilder();
            var tempstring = new List<byte>();
            uint offset = 0;
            for (uint i = 0; i < stringscount; i++)
            {
                byte b = strings[i];
                if (b == 0)
                {
                    var text = Encoding.GetEncoding("iso-8859-1").GetString(tempstring.ToArray());
                    newstringtable.Add(offset, text);

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

            return (newstringtable, newstrings, nameslist, importslist);
        }

        public void Write(BinaryWriter file)
        {
            // update data
            //m_fileheader.timeStamp = CDateTime.Now.ToUInt64();    //this will change any vanilla assets simply by opening and saving in wkit
            var nn = new List<CR2WNameWrapper>(Names);

            #region Update Tables

            #region Stringtable

            StringDictionary.Clear();

            List<byte> newstrings;
            List<string> nameslist;
            List<SImportEntry> importslist;
            (StringDictionary, newstrings, nameslist, importslist) = GenerateStringtable();

            uint stringbuffer_offset = 160; // always 160
            m_tableheaders[0].offset = stringbuffer_offset;
            m_strings = newstrings.ToArray();

            m_tableheaders[0].itemCount = (uint)m_strings.Length;
            m_tableheaders[0].crc32 = Crc32Algorithm.Compute(m_strings);

            #endregion Stringtable

            var inverseDictionary = StringDictionary.ToDictionary(x => x.Value, x => x.Key);

            #region Names

            Names.Clear();
            foreach (var name in nameslist)
            {
                var newoffset = inverseDictionary[name];

                var hash64 = string.IsNullOrEmpty(name)
                    ? 0
                    : FNV1A64HashAlgorithm.HashString(name, Encoding.GetEncoding("iso-8859-1"));
                uint hash = (uint)(hash64 & 0xffffffff);

                Names.Add(new CR2WNameWrapper(new CR2WName()
                {
                    //me: Why hash and not name??
                    hash = hash,
                    value = newoffset
                }, this));
            }

            #endregion Names

            #region Imports

            Imports.Clear();
            foreach (var import in importslist)
            {
                var nw = Names.First(_ => _.Str == import.ClassName);
                ushort flag = (ushort)import.Flags;

                Imports.Add(new CR2WImportWrapper(
                    new CR2WImport()
                    {
                        className = (ushort)Names.IndexOf(nw),
                        depotPath = inverseDictionary[import.Path],
                        flags = (ushort)import.Flags    //TODO finish all flags
                    }, this));
            }

            #endregion Imports

            #region Embedded

            foreach (var emb in Embedded)
            {
                // update import index
                int realidx = (int)emb.Embedded.importIndex - 1;
                int chunkidx = (int)emb.Embedded.chunkIndex;
                if (emb.ImportPath != Imports[realidx].DepotPathStr)
                {
                    var emb1 = emb;
                    var importindex = Imports.FindIndex(_ => _.DepotPathStr == emb1.ImportPath);
                    if (importindex != -1)
                        emb.SetImportIndex((uint)importindex);
                }
                // update export index
                if (emb.Export != Chunks[chunkidx])
                {
                    var chunkindex = Chunks.FindIndex(_ => _ == emb.Export);
                    if (chunkindex != -1)
                        emb.SetChunkIndex((uint)chunkindex);
                }
            }

            #endregion Embedded

            #endregion Update Tables

            // Write headers once to allocate the space for it
            WriteHeader(file);
            headerOffset = (uint)file.BaseStream.Position;

            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                // first write the file to memory
                // this also sets m_fileheader.fileSize and m_fileheader.bufferSize, offsets
                WriteData(bw);

                // Write buffers
                ms.Seek(0, SeekOrigin.Begin);
                ms.WriteTo(file.BaseStream);
            }

            #region Update Offsets

            foreach (var ichunk in Chunks)
            {
                var chunk = ichunk as CR2WExportWrapper;
                var newoffset = chunk.Export.dataOffset + headerOffset;
                chunk.SetOffset(newoffset);
                chunk.SetType((ushort)GetStringIndex(chunk.REDType));
            }
            foreach (var buffer in Buffers)
            {
                var newoffset = buffer.Offset + headerOffset;
                buffer.SetOffset(newoffset);
            }
            m_fileheader.objectsEnd += headerOffset;

            #endregion Update Offsets

            foreach (var chunk in Chunks)
                FixExportCRC32(file.BaseStream, (chunk as CR2WExportWrapper).Export);
            foreach (var buffer in Buffers)
                FixBufferCRC32(file.BaseStream, buffer);

            // Write headers again with fixed offsets
            WriteHeader(file);

            if (AdditionalCr2WFileBytes != null)
            {
                file.BaseStream.Seek(0, SeekOrigin.End);
                file.Write(AdditionalCr2WFileBytes);
            }
        }

        public void WriteHeader(BinaryWriter file)
        {
            WriteFileHeader(file);

            #region Write Tables

            m_tableheaders[1].itemCount = (uint)Names.Count;
            m_tableheaders[1].offset = (uint)file.BaseStream.Position;
            WriteTable<CR2WName>(file.BaseStream, Names.Select(_ => _.Name).ToArray(), 1);

            m_tableheaders[2].itemCount = (uint)Imports.Count;
            m_tableheaders[2].offset = Imports.Count > 0 ? (uint)file.BaseStream.Position : 0;
            WriteTable<CR2WImport>(file.BaseStream, Imports.Select(_ => (_ as CR2WImportWrapper).Import).ToArray(), 2);

            m_tableheaders[3].itemCount = (uint)Properties.Count;
            m_tableheaders[3].offset = (uint)file.BaseStream.Position;
            WriteTable<CR2WProperty>(file.BaseStream, Properties.Select(_ => _.Property).ToArray(), 3);

            m_tableheaders[4].itemCount = (uint)Chunks.Count;
            m_tableheaders[4].offset = (uint)file.BaseStream.Position;
            WriteTable<CR2WExport>(file.BaseStream, Chunks.Select(_ => (_ as CR2WExportWrapper).Export).ToArray(), 4);

            if (Buffers.Count > 0)
            {
                m_tableheaders[5].itemCount = (uint)Buffers.Count;
                m_tableheaders[5].offset = (uint)file.BaseStream.Position;
                WriteTable<CR2WBuffer>(file.BaseStream, Buffers.Select(_ => (_ as CR2WBufferWrapper).Buffer).ToArray(), 5);
            }

            if (Embedded.Count > 0)
            {
                m_tableheaders[6].itemCount = (uint)Embedded.Count;
                m_tableheaders[6].offset = (uint)file.BaseStream.Position;
                WriteTable<CR2WEmbedded>(file.BaseStream, Embedded.Select(_ => _.Embedded).ToArray(), 6);
            }

            #endregion Write Tables

            // calculate crc and write file header again
            var headerEndPosition = (int)file.BaseStream.Position;
            m_fileheader.crc32 = CalculateHeaderCRC32();
            WriteFileHeader(file);

            // move to end of fileheader
            file.Seek(headerEndPosition, SeekOrigin.Begin);
        }

        private (List<string>, List<SImportEntry>) GenerateStringtableInner()
        {
            var dbg_trace = new List<string>();
            var newnameslist = new Dictionary<string, string> { { "", "" } };
            var newimportslist = new List<SImportEntry>();
            var newsoftlist = new List<SImportEntry>();
            var idlist = new HashSet<string>();

            foreach (var c in Chunks)
            {
                LoopWrapper(new SNameArg(EStringTableMod.SkipName, c.data));
            }

            newimportslist.AddRange(newsoftlist);

            return (newnameslist.Values.ToList(), newimportslist);

            void LoopWrapper(SNameArg var)
            {
                if (idlist.Contains(var.Var.UniqueIdentifier))
                    return;

                //collection.Add(var);
                dbg_trace.Add($"{var.Var.UniqueIdentifier} - {var.Mod}");
                AddStrings(var);

                List<SNameArg> nextl = GetVariables(var.Var);
                if (nextl == null)
                    return;
                foreach (var l in nextl.Where(l => l.Var != null))
                {
                    LoopWrapper(l);
                }
            }

            List<SNameArg> GetVariables(IEditableVariable ivar)
            {
                //check for looping references
                if (idlist.Contains(ivar.UniqueIdentifier))
                    return null;
                else
                    idlist.Add(ivar.UniqueIdentifier);

                var returnedVariables = new List<SNameArg>();

                // if variable is generic type or some special case
                switch (ivar)
                {
                    case IArrayAccessor a:
                        switch (a)
                        {
                            case CArray<CName> cacn:
                                returnedVariables.Add(new SNameArg(EStringTableMod.None, a)); //???
                                break;

                            case CArray<CBool> cacb:
                            case CArray<CUInt16> cacu16:
                            case CArray<CInt16> caci16:
                            case CArray<CUInt32> cacu32:
                            case CArray<CInt32> caci32:
                            case CArray<CUInt64> cacu64:
                            case CArray<CInt64> caci64:
                                break;

                            default:
                                var elements = a.GetEditableVariables();
                                foreach (var item in elements)
                                    returnedVariables.Add(new SNameArg(EStringTableMod.SkipNameAndType, item));
                                break;
                        }
                        break;

                    case IHandleAccessor h:
                        if (h.ChunkHandle)
                            if (h.Reference != null)
                                returnedVariables.Add(new SNameArg(EStringTableMod.None, h.Reference.data));
                        break;

                    case ISoftAccessor s:
                        break;

                    case IBufferVariantAccessor ivariant:
                        var mod = EStringTableMod.None;
                        returnedVariables.Add(new SNameArg(mod, ivariant.Variant));
                        break;

                    case CVariant cVariant:
                        returnedVariables.Add(new SNameArg(EStringTableMod.SkipName, cVariant.Variant));
                        break;
                    // check all other CVariables
                    case CVariable cvar:
                    {
                        // skip some custom buffers
                        if (cvar is gameCookedDeviceDataCompressed)
                        {
                            return null;
                        }

                        // add parent if not already in guidlist
                        // don't add array type parents, don't add IBufferVariantAccessor type parents
                        if (cvar.ParentVar != null
                            && !cvar.ParentVar.GetType().IsGenericType
                            && !(cvar.ParentVar is IBufferVariantAccessor)
                            && !idlist.Contains(cvar.ParentVar.UniqueIdentifier))
                        {
                            returnedVariables.Add(new SNameArg(EStringTableMod.None, cvar.ParentVar));
                        }

                        // add all normal REDProperties
                        var props = cvar.GetExistingVariables(false);
                        returnedVariables.AddRange(props
                            .Select(_ => new SNameArg(EStringTableMod.None, _)));

                        // get buffers
                        var buffers = cvar.GetExistingVariables(true).Except(props).ToList();

                        // custom serialization
                        if (cvar is CMaterialInstance mi)
                        {
                            returnedVariables.AddRange(buffers
                                .Select(_ => new SNameArg(EStringTableMod.SkipNameAndType, _)));
                        }

                        if (cvar is physicsMaterialLibraryResource pmlr)
                        {
                            returnedVariables.AddRange(buffers
                                .Select(_ => new SNameArg(EStringTableMod.SkipNameAndType, _)));
                        }

                        if (cvar is gameDeviceResourceData gdrd)
                        {
                            returnedVariables.AddRange(gdrd.CookedDeviceData
                                .Select(_ => _.ClassName)
                                .Select(_ => new SNameArg(EStringTableMod.SkipNameAndType, _)));
                        }

                        break;
                    }
                    default:
                        break;
                }

                return returnedVariables;
            }

            void AddStrings(SNameArg tvar)
            {
                var var = tvar.Var;

                // skip some custom buffers
                if (var is gameCookedDeviceDataCompressed)
                {
                    return;
                }

                CheckVarNameAndTypes();

                switch (var)
                {
                    case IHandleAccessor handle:
                    {
                        if (!handle.ChunkHandle)
                        {
                            AddUniqueToTable(handle.ClassName);
                            var flags = EImportFlags.Default;

                            if ((var.Cr2wFile as CR2WFile).Embedded.Any(_ => _.ImportPath == handle.DepotPath))
                                flags = EImportFlags.Inplace;

                            var importtuple = new SImportEntry(handle.ClassName, handle.DepotPath, flags);
                            if (!newimportslist.Contains(importtuple))
                            {
                                newimportslist.Add(importtuple);
                            }
                        }

                        break;
                    }
                    case ISoftAccessor soft:
                    {
                        if (/*!(string.IsNullOrEmpty(s.ClassName) &&*/ !string.IsNullOrEmpty(soft.DepotPath))
                        {
                            //FIXME: calculate this properly
                            //var flags = EImportFlags.Default;
                            //if (s.REDType.StartsWith("raRef:"))
                            //    flags = EImportFlags.Soft;

                            var flags = soft.Flags;

                            var stuple = new SImportEntry("", soft.DepotPath, flags);
                            if (newsoftlist.All(_ => _.Path != soft.DepotPath))
                            {
                                newsoftlist.Add(stuple);
                            }
                        }

                        break;
                    }
                    case CName n:
                        AddUniqueToTable(n.Value);
                        break;

                    case IArrayAccessor when var is IBufferAccessor buffer:
                    {
                        foreach (var ivar in buffer.GetEditableVariables())
                        {
                            if (ivar is not IHandleAccessor ha)
                                continue;
                            if (ha.ChunkHandle)
                                continue;

                            AddUniqueToTable(ha.ClassName);
                            var flags = EImportFlags.Default;
                            if (ha.REDName == "template")
                                flags = EImportFlags.Template;
                            var importtuple = new SImportEntry(ha.ClassName, ha.DepotPath, flags);
                            if (!newimportslist.Contains(importtuple))
                            {
                                newimportslist.Add(importtuple);
                            }
                        }

                        break;
                    }
                    case IArrayAccessor:
                    {
                        CheckVarNameAndTypes();

                        if (var is CArray<CName> aa)
                        {
                            foreach (var element in aa)
                            {
                                AddUniqueToTable(element.Value);
                            }
                        }

                        break;
                    }
                    case IEnumAccessor { IsFlag: true } enumAccessor:
                    {
                        foreach (var enumstring in enumAccessor.Value)
                            AddUniqueToTable(enumstring);
                        break;
                    }
                    case IEnumAccessor enumAccessor:
                        AddUniqueToTable(enumAccessor.GetAttributeVal());
                        break;
                }

                void CheckVarNameAndTypes()
                {
                    switch (tvar.Mod)
                    {
                        case EStringTableMod.SkipType:
                            AddUniqueToTable(var.REDName);
                            break;

                        case EStringTableMod.SkipName:
                            AddUniqueToTable(var.REDType);
                            break;

                        case EStringTableMod.SkipNameAndType:
                            break;

                        case EStringTableMod.TypeFirst:
                            AddUniqueToTable(var.REDType);
                            AddUniqueToTable(var.REDName);
                            break;

                        case EStringTableMod.None:
                        default:
                            AddUniqueToTable(var.REDName);
                            AddUniqueToTable(var.REDType);
                            break;
                    }
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
                    if (!newnameslist.ContainsKey(str))
                    {
                        // hack for CApexClothResource *sigh*
                        if (str == "apexMaterialNames")
                        {
                            if (!newnameslist.ContainsKey("apexBinaryAsset"))
                                newnameslist.Add("apexBinaryAsset", "apexBinaryAsset");
                            if (!newnameslist.ContainsKey("array: 95, 0, Uint8"))
                                newnameslist.Add("array:95,0,Uint8", "array:95,0,Uint8");
                        }

                        newnameslist.Add(str, str);
                    }
                }
            }
        }

        private void WriteData(BinaryWriter bw)
        {
            // Write chunk data
            foreach (var chunk in Chunks)
            {
                chunk.WriteData(bw);
            }

            m_fileheader.objectsEnd = (uint)bw.BaseStream.Position;

            //Write Buffer data
            foreach (var buffer in Buffers)
            {
                buffer.WriteData(bw);
            }
            m_fileheader.buffersEnd = (uint)bw.BaseStream.Position;
        }

        private void WriteFileHeader(BinaryWriter file)
        {
            file.BaseStream.Seek(0, SeekOrigin.Begin);

            // calculate filesize again
            m_fileheader.objectsEnd = (Chunks.Last() as CR2WExportWrapper).Export.dataOffset + (Chunks.Last() as CR2WExportWrapper).Export.dataSize;

            // calculate buffersize again
            m_fileheader.buffersEnd = (uint)Buffers.Sum(_ => _.DiskSize) + m_fileheader.objectsEnd;

            file.BaseStream.WriteStruct<uint>(MAGIC);
            file.BaseStream.WriteStruct<CR2WFileHeader>(m_fileheader);
            file.BaseStream.WriteStructs<CR2WTable>(m_tableheaders); // offsets change if stringtable changes
            WriteStringBuffer(file.BaseStream);
        }

        private void WriteStringBuffer(Stream stream)
        {
            m_tableheaders[0].crc32 = Crc32Algorithm.Compute(m_strings);
            stream.Write(m_strings, 0, m_strings.Length);
        }

        private void WriteTable<T>(Stream stream, T[] array, int index) where T : struct
        {
            if (array.Length == 0)
                return;

            var crc = new Crc32Algorithm(false);
            stream.WriteStructs<T>(array, crc);
            m_tableheaders[index].crc32 = crc.HashUInt32;
        }

        // Those where before tuples, passed between functions. Got sick of them and made structs.
        // Got lazy and did not rewrite elements in code, hence ItemN attributes. //FIXME unimportant
        public readonly struct SImportEntry
        {
            #region Fields

            public readonly string ClassName;
            public readonly EImportFlags Flags;
            public readonly string Path;

            #endregion Fields

            #region Constructors

            public SImportEntry(string classname, string path, EImportFlags flags)
            {
                ClassName = classname;
                Path = path;
                Flags = flags;
            }

            #endregion Constructors
        };

        // Those where before tuples, passed between functions. Got sick of them and made structs.
        // Got lazy and did not rewrite elements in code, hence ItemN attributes. //FIXME unimportant
        private readonly struct SNameArg
        {
            #region Fields

            public readonly EStringTableMod Mod;
            public readonly IEditableVariable Var;

            #endregion Fields

            #region Constructors

            public SNameArg(EStringTableMod mod, IEditableVariable var)
            {
                Mod = mod;
                Var = var;
            }

            #endregion Constructors
        };

        #endregion Write

        #region Methods

        public void GetChunks()
        {
            throw new NotImplementedException();
        }

        Task<EFileReadErrorCodes> IWolvenkitFile.Read(BinaryReader file)
        {
            throw new NotImplementedException();
        }

        #endregion Methods
    }
}
