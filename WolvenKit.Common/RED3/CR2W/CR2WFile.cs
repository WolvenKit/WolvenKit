using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using RED.CRC32;
using WolvenKit.Common;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Common.Services;
using WolvenKit.Interfaces.Core;
using WolvenKit.Interfaces.RED3;
using WolvenKit.RED3.CR2W.Reflection;
using WolvenKit.RED3.CR2W.Types;
using WolvenKit.RED3.CR2W.Types.Utils;

namespace WolvenKit.RED3.CR2W
{
    public class CR2WFile : ObservableObject, IRed3EngineFile
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

        private const long FILEHEADER_SIZE = 36;
        private const long MAGIC_SIZE = 4;
        private const long TABLEHEADER_SIZE = 12 * 10;
        private readonly int[] TABLES_SIZES = new int[6] { 8, 8, 16, 24, 24, 24 };

        #endregion Constants

        #region Constructors

        public CR2WFile()
        {
            Names = new List<ICR2WName>();            //block 2
            Imports = new List<ICR2WImport>();              //block 3
            Properties = new List<CR2WPropertyWrapper>();   //block 4
            Chunks = new List<ICR2WExport>();               //block 5
            Buffers = new List<ICR2WBuffer>();              //block 6
            Embedded = new List<CR2WEmbeddedWrapper>();     //block 7

            m_fileheader = new CR2WFileHeader()
            {
                version = 162,
            };

            StringDictionary = new Dictionary<uint, string>();
            m_tableheaders = new CR2WTable[10];
        }

        #endregion Constructors

        #region Fields

        private const uint DEADBEEF = 0xDEADBEEF;

        // constants
        private const uint MAGIC = 0x57325243; // "W2RC"

        private CR2WFile additionalCr2WFile;

        private byte[] additionalCr2WFileBytes;

        // misc
        private uint headerOffset = 0;

        // IO
        private CR2WFileHeader m_fileheader;

        private bool m_hasInternalBuffer;
        private byte[] m_strings;
        private CR2WTable[] m_tableheaders;
        public Dictionary<uint, string> StringDictionary { get; private set; }

        #endregion Fields

        #region Properties

        public List<string> UnknownTypes { get; } = new();
        public List<ILocalizedString> LocalizedStrings { get; } = new();
        public List<ICR2WBuffer> Buffers { get; private set; }
        public List<ICR2WExport> Chunks { get; private set; }
        public Dictionary<int, ICR2WExport> Chunksdict { get; private set; }

        /// <summary>
        ///     EditorController
        /// </summary>
        public IVariableEditor EditorController { get; set; }

        //[DataMember(Order = 2)]
        public List<CR2WEmbeddedWrapper> Embedded { get; private set; }

        public string FileName { get; set; }
        public List<ICR2WImport> Imports { get; private set; }
        public bool IsDirty { get; set; }

        /// <summary>
        ///     LocalizedStringSource
        /// </summary>
        public ILocalizedStringSource LocalizedStringSource { get; set; }

        public ILoggerService Logger { get; }

        // Tables
        public List<ICR2WName> Names { get; private set; }

        public List<CR2WPropertyWrapper> Properties { get; private set; }

        public void GenerateChunksDict() => Chunksdict = Chunks.ToDictionary(_ => _.ChunkIndex, _ => _);

        #endregion Properties

        #region Supporting Functions



        // Does not reindex /TODO
        public ICR2WExport CreateChunk(string type, int chunkindex = 0, ICR2WExport parent = null,
            ICR2WExport virtualparent = null, IEditableVariable cvar = null)
        {
            var chunk = new CR2WExportWrapper(this, type, parent) as ICR2WExport;
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
        public ICR2WExport CreateChunk(CVariable cvar, int chunkindex = 0, ICR2WExport parent = null, ICR2WExport virtualparent = null)
        {
            // checks to see if the variable from which the chunk is built is properly constructed
            if (cvar == null || cvar.REDName != cvar.REDType || cvar.ParentVar != null)
                throw new NotImplementedException();

            var chunk = new CR2WExportWrapper(this, cvar.REDType, parent) as ICR2WExport;
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

        public CR2WFileHeader GetFileHeader() => m_fileheader;

        public int GetLastChildrenIndexRecursive(ICR2WExport chunk)
        {
            if (chunk.VirtualChildrenChunks.Count() == 0)
            {
                return chunk.ChunkIndex;
            }
            else
            {
                return GetLastChildrenIndexRecursive(chunk.VirtualChildrenChunks.Where(
                    _ => _.ChunkIndex == chunk.VirtualChildrenChunks.Max(p => p.ChunkIndex)).FirstOrDefault());
            }
        }

        public string GetLocalizedString(uint val)
        {
            if (LocalizedStringSource != null)
                return LocalizedStringSource.GetLocalizedString(val);

            return null;
        }

        public int GetStringIndex(string name, bool addnew = false)
        {
            for (var i = 0; i < Names.Count; i++)
            {
                if (Names[i].Str == name || (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(Names[i].Str)))
                    return i;
            }

            throw new NotImplementedException();
            //return -1;
        }

        public CR2WTable[] GetTableHeaders() => m_tableheaders;

        public IEditableVariable ReadVariable(BinaryReader file, IEditableVariable parent)
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

            // CDPR changed the type of CPtr<IBehTreeNodeDefinition> RootNode
            // to CHandle<IBehTreeNodeDefinition> RootNode in CBehTree in patch1
            if (typename == "ptr:IBehTreeNodeDefinition" && varname == "rootNode" && parent.REDType == "CBehTree")
                typename = "handle:IBehTreeNodeDefinition";

            var parsedvar = CR2WTypeManager.Create(typename, varname, this, parent as CVariable);
            // The "size" variable read is something a bit strange : it takes itself into account.
            //try
            //{
            parsedvar.Read(file, size - 4);
            //}
            //catch
            //{
            //    System.Console.WriteLine("hohoho");
            //}

            var afterVarPos = file.BaseStream.Position;

            var bytesleft = size - (afterVarPos - sizepos);
            if (bytesleft > 0)
            {
                var unreadBytes = file.ReadBytes((int)bytesleft);
                //?? why not throw ?? throw new InvalidParsingException($"Parsing Variable read too short. Difference: {bytesleft}");
            }
            else if (bytesleft < 0)
            {
                throw new InvalidParsingException($"Parsing variable read too far. {bytesleft} bytes' diff.");
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
                OnPropertyChanged(nameof(Chunks));
            }

            return removed;
        }

        #endregion Supporting Functions

        #region Read

        public CR2WFile GetAdditionalCr2wFile()
        {
            if (additionalCr2WFileBytes == null)
                return null;
            using (var ms2 = new MemoryStream(additionalCr2WFileBytes))
            using (var br2 = new BinaryReader(ms2))
            {
                additionalCr2WFile = new CR2WFile();
                additionalCr2WFile.ReadAsync(br2).GetAwaiter().GetResult();
                return additionalCr2WFile;
            }
        }

        public async Task<EFileReadErrorCodes> ReadAsync(byte[] data)
        {
            await using (var ms = new MemoryStream(data))
            using (var br = new BinaryReader(ms))
            {
                return await ReadAsync(br);
            }
        }

        public async Task<EFileReadErrorCodes> ReadAsync(BinaryReader file)
        {
            //m_stream = file.BaseStream;

            var stopwatch1 = new Stopwatch();
            stopwatch1.Start();

            #region Read Headers

            var startpos = file.BaseStream.Position;

            // read file header
            var id = file.BaseStream.ReadStruct<uint>();
            if (id != MAGIC)
                return await Task.FromResult(EFileReadErrorCodes.NoCr2w);

            m_fileheader = file.BaseStream.ReadStruct<CR2WFileHeader>();
            if (m_fileheader.version > 195 || m_fileheader.version < 163)
                return await Task.FromResult(EFileReadErrorCodes.UnsupportedVersion);

            //var dt = new CDateTime(m_fileheader.timeStamp, null, "");

            // Tables [7-9] are not used in cr2w so far.
            m_tableheaders = file.BaseStream.ReadStructs<CR2WTable>(10);
            m_hasInternalBuffer = m_fileheader.bufferSize > m_fileheader.fileSize;

            // read strings - block 1 (index 0)
            m_strings = ReadStringsBuffer(file.BaseStream);

            // read the other tables
            Names = ReadTable<CR2WName>(file.BaseStream, 1).Select(_ => new CR2WNameWrapper(_, this) as ICR2WName).ToList(); // block 2
            Imports = ReadTable<CR2WImport>(file.BaseStream, 2).Select(_ => new CR2WImportWrapper(_, this) as ICR2WImport).ToList(); // block 3
            Properties = ReadTable<CR2WProperty>(file.BaseStream, 3).Select(_ => new CR2WPropertyWrapper(_)).ToList(); // block 4
            Chunks = ReadTable<CR2WExport>(file.BaseStream, 4).Select(_ => new CR2WExportWrapper(_, this) as ICR2WExport).ToList(); // block 5
            Buffers = ReadTable<CR2WBuffer>(file.BaseStream, 5).Select(_ => new CR2WBufferWrapper(_) as ICR2WBuffer).ToList(); // block 6
            Embedded = ReadTable<CR2WEmbedded>(file.BaseStream, 6).Select(_ => new CR2WEmbeddedWrapper(_)
            {
                ParentFile = this,
                ParentImports = Imports,
                Handle = StringDictionary[_.path],
            }).ToList(); // block 7


            #endregion Read Headers

            #region Read Data

            // Read object data //block 5
            for (int i = 0; i < Chunks.Count; i++)
            {
                ICR2WExport chunk = Chunks[i];

                chunk.ReadData(file);

                int percentprogress = (int)((float)i / (float)Chunks.Count * 100.0);
            }
            // Read buffer data //block 6
            if (m_hasInternalBuffer)
            {
                for (int i = 0; i < Buffers.Count; i++)
                {
                    var buffer = Buffers[i];
                    buffer.ReadData(file);

                    int percentprogress = (int)((float)i / (float)Buffers.Count * 100.0);
                }
            }
            // Read embedded files //block 7
            for (int i = 0; i < Embedded.Count; i++)
            {
                CR2WEmbeddedWrapper emb = Embedded[i];
                emb.ReadData(file);

                int percentprogress = (int)((float)i / (float)Embedded.Count * 100.0);
            }

            #endregion Read Data

            // some w2ls have additional CLayerInfo packed behind the file
            var endpos = file.BaseStream.Position;
            var readbytes = endpos - startpos;
            if (readbytes != file.BaseStream.Length)
            {
                var bytesleft = file.BaseStream.Length - readbytes;
                additionalCr2WFileBytes = file.ReadBytes((int)bytesleft);
            }

            Logger?.Info($"File {FileName} loaded in: {stopwatch1.Elapsed}\n");
            stopwatch1.Stop();
            //m_stream = null;
            return await Task.FromResult(EFileReadErrorCodes.NoError);
        }

        public (List<ICR2WImport>, bool, List<ICR2WBuffer>) ReadImportsAndBuffers(BinaryReader file)
        {
            #region Read Headers

            // read file header
            var id = file.BaseStream.ReadStruct<uint>();
            if (id != MAGIC)
                throw new FormatException($"Not a CR2W file, magic read as 0x{id:X8}.");

            m_fileheader = file.BaseStream.ReadStruct<CR2WFileHeader>();

            //TODO: CP77

            if (m_fileheader.version > 195 || m_fileheader.version < 163)
                throw new FormatException($"Unknown version {m_fileheader.version}. Supported versions: 159 - 163.");

            //var dt = new CDateTime(m_fileheader.timeStamp, null, "");

            m_tableheaders = file.BaseStream.ReadStructs<CR2WTable>(10);
            m_hasInternalBuffer = m_fileheader.bufferSize > m_fileheader.fileSize;

            // read strings
            m_strings = ReadStringsBuffer(file.BaseStream);

            // read tables
            Names = ReadTable<CR2WName>(file.BaseStream, 1).Select(_ => new CR2WNameWrapper(_, this) as ICR2WName).ToList();
            Imports = ReadTable<CR2WImport>(file.BaseStream, 2).Select(_ => new CR2WImportWrapper(_, this) as ICR2WImport).ToList();
            Properties = ReadTable<CR2WProperty>(file.BaseStream, 3).Select(_ => new CR2WPropertyWrapper(_)).ToList();
            Chunks = ReadTable<CR2WExport>(file.BaseStream, 4).Select(_ => new CR2WExportWrapper(_, this) as ICR2WExport).ToList();
            Buffers = ReadTable<CR2WBuffer>(file.BaseStream, 5).Select(_ => new CR2WBufferWrapper(_) as ICR2WBuffer).ToList();
            Embedded = ReadTable<CR2WEmbedded>(file.BaseStream, 6).Select(_ => new CR2WEmbeddedWrapper(_)
            {
                ParentFile = this,
                ParentImports = Imports,
                Handle = StringDictionary[_.path],
            }).ToList();

            #endregion Read Headers

            return (Imports, m_hasInternalBuffer, Buffers);
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
        public enum EStringTableMod
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
                if (!nameslist.Contains(import.Item1))
                    nameslist.Add(import.Item1);
                if (!stringlist.Contains(import.Item1))
                    stringlist.Add(import.Item1);
                if (!stringlist.Contains(import.Item2))
                    stringlist.Add(import.Item2);
            }
            foreach (var emb in Embedded)
            {
                if (!stringlist.Contains(emb.Handle))
                    stringlist.Add(emb.Handle);
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

            // build new stringsDixtionary
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

        public EFileReadErrorCodes Read(BinaryReader file) => throw new NotImplementedException();

        public void Write(BinaryWriter file)
        {
            //m_stream = file.BaseStream;

            // update data
            //m_fileheader.timeStamp = CDateTime.Now.ToUInt64();    //this will change any vanilla assets simply by opening and saving in wkit
            //m_fileheader.numChunks = (uint)chunks.Count;          //this is weird, I don't think it actually is the number of chunks
            //var nn = new List<ICR2WName>(Names);

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
                //var encodedstring = Encoding.GetEncoding("iso-8859-1")
                var newoffset = inverseDictionary[name];
                var hash = FNV1A32HashAlgorithm.HashString(name, Encoding.GetEncoding("iso-8859-1"), true);
                Names.Add(new CR2WNameWrapper(new CR2WName()
                {
                    //me: Why hash and not name??
                    hash = hash,
                    value = newoffset
                }, this) as ICR2WName);
            }

            #endregion Names

            #region Imports

            Imports.Clear();
            foreach (var import in importslist)
            {
                var nw = Names.First(_ => _.Str == import.Item1);
                ushort flag = (ushort)import.Item3;

                Imports.Add(new CR2WImportWrapper(
                    new CR2WImport()
                    {
                        className = (ushort)Names.IndexOf(nw),
                        depotPath = inverseDictionary[import.Item2],
                        flags = (ushort)import.Item3    //TODO finish all flags
                    }, this) as ICR2WImport);
            }

            #endregion Imports

            #region Embedded

            for (var i = 0; i < Embedded.Count; i++)
            {
                var emb = Embedded[i];
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
                if (Imports[realidx].ClassNameStr != emb.ImportClass || emb.ImportPath != Imports[realidx].DepotPathStr)
                {
                    var importindex = Imports.FindIndex(_ => _.ClassNameStr == emb.ImportClass && _.DepotPathStr == emb.ImportPath);
                    if (importindex != -1)
                        emb.SetImportIndex((uint)importindex);
                }
            }

            #endregion Embedded

            #endregion Update Tables

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

            for (var i = 0; i < Chunks.Count; i++)
            {
                var exportwrapper = Chunks[i] as CR2WExportWrapper;
                var newoffset = exportwrapper.Export.dataOffset + headerOffset;
                exportwrapper.SetOffset(newoffset);
                exportwrapper.SetType((ushort)GetStringIndex(Chunks[i].REDType));
            }
            if (m_hasInternalBuffer)
            {
                for (var i = 0; i < Buffers.Count; i++)
                {
                    var newoffset = Buffers[i].Offset + headerOffset;
                    Buffers[i].SetOffset(newoffset);
                }
            }
            for (var i = 0; i < Embedded.Count; i++)
            {
                var newoffset = Embedded[i].Embedded.dataOffset + headerOffset;
                Embedded[i].SetOffset(newoffset);
            }
            m_fileheader.fileSize += headerOffset;
            m_fileheader.bufferSize += headerOffset;

            #endregion Update Offsets

            foreach (var chunk in Chunks)
            {
                FixExportCRC32((chunk as CR2WExportWrapper).Export);
            }

            foreach (var buffer in Buffers)
            {
                FixBufferCRC32(buffer);
            }

            // Write headers again with fixed offsets
            //m_fileheader.crc32 = CalculateHeaderCRC32();
            WriteHeader(file);
            m_fileheader.crc32 = CalculateHeaderCRC32();
            WriteFileHeader(file);

            if (additionalCr2WFileBytes != null)
            {
                file.BaseStream.Seek(0, SeekOrigin.End);
                file.Write(additionalCr2WFileBytes);
            }

            //m_stream = null;

            void FixExportCRC32(CR2WExport export)
            {
                file.BaseStream.Seek(export.dataOffset, SeekOrigin.Begin);
                var m_temp = new byte[export.dataSize];
                file.BaseStream.Read(m_temp, 0, m_temp.Length);
                export.crc32 = Crc32Algorithm.Compute(m_temp);
            }

            void FixBufferCRC32(ICR2WBuffer buffer)
            {
                //This might throw errors, the way it should be checked for is by reading
                //the object tree to find the deferred data buffers that will point to a buffer.
                //The flag of the parent object indicates where to read the data from.
                //For now this is a crude workaround.
                if (m_hasInternalBuffer)
                {
                    file.BaseStream.Seek(buffer.Offset, SeekOrigin.Begin);
                    var m_temp = new byte[buffer.DiskSize];
                    file.BaseStream.Read(m_temp, 0, m_temp.Length);
                    buffer.Crc32 = Crc32Algorithm.Compute(m_temp);
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
                    hash.Append(BitConverter.GetBytes(h.itemCount));
                    hash.Append(BitConverter.GetBytes(h.crc32));
                }
                return hash.HashUInt32;
            }
        }

        private (List<string>, List<SImportEntry>) GenerateStringtableInner()
        {
            var dbg_trace = new List<string>();
            var newnameslist = new Dictionary<string, string>();
            newnameslist.Add("", "");
            var newimportslist = new List<SImportEntry>();
            var newsoftlist = new List<SImportEntry>();
            var idlist = new HashSet<string>();

            // CDPR changed the type of CPtr<IBehTreeNodeDefinition> RootNode
            // to CHandle<IBehTreeNodeDefinition> RootNode in CBehTree in patch1
            bool skipnamecheck = Chunks?.Count > 0 && Chunks.First().Data is CBehTree;

            foreach (var c in Chunks)
            {
                LoopWrapper(new SNameArg(EStringTableMod.SkipName, c.Data));
            }

            newimportslist.AddRange(newsoftlist);

            return (newnameslist.Values.ToList(), newimportslist);

            void LoopWrapper(SNameArg var)
            {
                if (idlist.Contains(var.Item2.UniqueIdentifier))
                {
                    return;
                }

                //collection.Add(var);
                dbg_trace.Add($"{var.Item2.REDName}[{var.Item2.REDType}] - {var.Item1}");
                AddStrings(var);

                if (!skipnamecheck)
                {
                    //if (newnameslist.Last().Value != StringDictionary.Values.ToList()[newnameslist.Count - 1])
                    //{
                    //}
                }

                List<SNameArg> nextl = GetVariables(var.Item2);
                if (nextl == null)
                    return;
                foreach (var l in nextl)
                {
                    if (l.Item2 != null)
                        LoopWrapper(l);
                }
            }

            //struct SNameArg zobi ;
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
                                returnedVariables.Add(new SNameArg(EStringTableMod.None, a)); ///???
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

                    case IPtrAccessor p:
                        if (p.Reference != null)
                            returnedVariables.Add(new SNameArg(EStringTableMod.None, p.Reference.Data));
                        break;

                    case IHandleAccessor h:
                        if (h.ChunkHandle)
                            if (h.Reference != null)
                                returnedVariables.Add(new SNameArg(EStringTableMod.None, h.Reference.Data));
                        break;

                    case ISoftAccessor s:
                        break;

                    case IBufferVariantAccessor ivariant:
                        EStringTableMod mod = EStringTableMod.None;
                        if (ivariant is CVariantSizeType)
                            mod = EStringTableMod.SkipName;
                        returnedVariables.Add(new SNameArg(mod, ivariant.Variant));
                        break;

                    case CVariant cVariant:
                        returnedVariables.Add(new SNameArg(EStringTableMod.SkipName, cVariant.Variant));
                        break;

                    case IdHandle i:
                        returnedVariables.Add(new SNameArg(EStringTableMod.None, i));
                        returnedVariables.Add(new SNameArg(EStringTableMod.None, i.handle.Reference?.Data));
                        break;
                    // check all other CVariables
                    case CVariable cvar:
                    {
                        // add parent if not already in guidlist
                        // don't add array type parents, don't add IBufferVariantAccessor type parents
                        if (cvar.ParentVar != null
                            && !cvar.ParentVar.GetType().IsGenericType
                            && !(cvar.ParentVar is IBufferVariantAccessor)
                            && !(cvar.ParentVar is SEntityBufferType2)
                            && !idlist.Contains(cvar.ParentVar.UniqueIdentifier))
                        {
                            returnedVariables.Add(new SNameArg(EStringTableMod.None, cvar.ParentVar));
                        }

                        // add all normal REDProperties
                        returnedVariables.AddRange(cvar.GetExistingVariables(false)
                            .Select(_ => new SNameArg(EStringTableMod.None, _)));

                        // for all buffers

                        #region Buffer Hacks After Variables

                        switch (cvar)
                        {
                            case CFoliageResource cfr:
                                if (cfr.Trees != null)
                                    returnedVariables.AddRange(cfr.Trees.Select(item =>
                                        new SNameArg(EStringTableMod.SkipNameAndType, item.Treetype)));
                                if (cfr.Grasses != null)
                                    returnedVariables.AddRange(cfr.Grasses.Select(item =>
                                        new SNameArg(EStringTableMod.SkipNameAndType, item.Treetype)));
                                break;

                            case CClipMap cm:
                                returnedVariables.Add(new SNameArg(EStringTableMod.SkipNameAndType, cm.TerrainTiles));
                                break;

                            case CUmbraScene cus:
                                if (cus.Tiles != null)
                                    returnedVariables.AddRange(cus.Tiles.Select(item =>
                                        new SNameArg(EStringTableMod.SkipNameAndType, item)));
                                break;

                            case CSkeletalAnimationSetEntry csase:
                                if (csase.Entries != null)
                                    returnedVariables.AddRange(csase.Entries.Select(item =>
                                        new SNameArg(EStringTableMod.SkipNameAndType, item)));
                                break;

                            case CLayerInfo cli:
                                returnedVariables.Add(new SNameArg(EStringTableMod.None, cli.ParentGroup.Reference?.Data));
                                break;

                            case CMaterialInstance cmi:
                                if (cmi.InstanceParameters != null)
                                    returnedVariables.AddRange(cmi.InstanceParameters.Select(iparam =>
                                        new SNameArg(EStringTableMod.SkipNameAndType, iparam)));
                                break;

                            case CMesh cm:
                                returnedVariables.Add(new SNameArg(EStringTableMod.None, cm.BoneNames));
                                break;

                            case CBehaviorGraphContainerNode bgcn:
                                if (bgcn.Inputnodes != null)
                                    returnedVariables.AddRange(bgcn.Inputnodes.Select(item =>
                                        new SNameArg(EStringTableMod.None, (item.Reference?.Data))));
                                returnedVariables.Add(new SNameArg(EStringTableMod.None, bgcn.Unk1));
                                returnedVariables.Add(new SNameArg(EStringTableMod.None, bgcn.Unk2));
                                switch (bgcn)
                                {
                                    case CBehaviorGraphStageNode bgsn:
                                        returnedVariables.Add(new SNameArg(EStringTableMod.None, bgsn.Outputnode.Reference?.Data));
                                        break;

                                    case CBehaviorGraphTopLevelNode bgtln:
                                        returnedVariables.Add(new SNameArg(EStringTableMod.None, bgtln.Outputnode.Reference?.Data));
                                        break;

                                    case CBehaviorGraphStateNode bgstn:
                                        returnedVariables.Add(new SNameArg(EStringTableMod.None, bgstn.Outputnode.Reference?.Data));
                                        break;

                                    case CBehaviorGraphStateMachineNode bgsmn:
                                        if (bgsmn.Unk3 != null)
                                            returnedVariables.AddRange(bgsmn.Unk3.Select(item =>
                                                new SNameArg(EStringTableMod.None, (item.Reference?.Data))));
                                        if (bgsmn.Unk4 != null)
                                            returnedVariables.AddRange(bgsmn.Unk4.Select(item =>
                                                new SNameArg(EStringTableMod.None, (item.Reference?.Data))));

                                        returnedVariables.Add(new SNameArg(EStringTableMod.None, bgsmn.Handle1.Reference?.Data));
                                        returnedVariables.Add(new SNameArg(EStringTableMod.None, bgsmn.Outputnode.Reference?.Data));
                                        if (bgsmn.Inputnodes != null)
                                            returnedVariables.AddRange(bgsmn.Inputnodes.Select(item =>
                                                new SNameArg(EStringTableMod.None, item.Reference?.Data)));
                                        returnedVariables.Add(new SNameArg(EStringTableMod.None, bgsmn.Unk1));
                                        returnedVariables.Add(new SNameArg(EStringTableMod.None, bgsmn.Unk2));
                                        break;

                                    default:
                                        break;
                                }
                                break;

                            case CBehaviorGraph cbg:
                                returnedVariables.Add(new SNameArg(EStringTableMod.None, cbg.Toplevelnode.Reference?.Data));
                                if (cbg.Variables1 != null)
                                    returnedVariables.AddRange(cbg.Variables1.Select(item =>
                                        new SNameArg(EStringTableMod.None, item)));
                                if (cbg.Descriptions != null)
                                    returnedVariables.AddRange(cbg.Descriptions.Select(item =>
                                        new SNameArg(EStringTableMod.None, item.Reference?.Data)));
                                if (cbg.Vectorvariables1 != null)
                                    returnedVariables.AddRange(cbg.Vectorvariables1.Select(item =>
                                        new SNameArg(EStringTableMod.None, item)));
                                if (cbg.Variables2 != null)
                                    returnedVariables.AddRange(cbg.Variables2.Select(item =>
                                        new SNameArg(EStringTableMod.None, item)));
                                if (cbg.Vectorvariables2 != null)
                                    returnedVariables.AddRange(cbg.Vectorvariables2.Select(item =>
                                        new SNameArg(EStringTableMod.None, item)));
                                break;

                            case CNode cn:
                                if (cn.AttachmentsChild != null)
                                    returnedVariables.AddRange(cn.AttachmentsChild.Select(att =>
                                        new SNameArg(EStringTableMod.SkipNameAndType, att)));
                                if (cn.AttachmentsReference != null)
                                    returnedVariables.AddRange(cn.AttachmentsReference.Select(att =>
                                        new SNameArg(EStringTableMod.SkipNameAndType, att)));
                                if (cn is CEntity e)
                                {
                                    if (e.Components != null)
                                        returnedVariables.AddRange(e.Components.Select(component =>
                                            new SNameArg(EStringTableMod.SkipNameAndType, component)));
                                    if (e.BufferV1 != null)
                                        returnedVariables.AddRange(e.BufferV1.Select(buffer =>
                                            new SNameArg(EStringTableMod.SkipNameAndType, buffer)));
                                    if (e.BufferV2 != null)
                                        foreach (SEntityBufferType2 item in e.BufferV2)
                                        {
                                            returnedVariables.Add(new SNameArg(EStringTableMod.SkipNameAndType, item.componentName));
                                            if (item.variables != null)
                                                returnedVariables.AddRange(item.variables.Select(el =>
                                                    new SNameArg(EStringTableMod.TypeFirst, el.Variant)));
                                        }
                                }
                                break;

                            case SAppearanceAttachment aa:
                                if (aa.Data != null)
                                    returnedVariables.AddRange(from CVariable item in aa.Data
                                                               select new SNameArg(EStringTableMod.SkipName, item));
                                break;

                            case CCutsceneTemplate cct:
                                if (cct.Animevents != null)
                                    returnedVariables.AddRange(cct.Animevents.Select(item =>
                                        new SNameArg(EStringTableMod.SkipName, item.Variant)));
                                break;

                            case CStorySceneSection csss:
                                if (csss.sceneEventElements != null)
                                    returnedVariables.AddRange(csss.sceneEventElements.Select(item =>
                                        new SNameArg(EStringTableMod.SkipNameAndType, item)));
                                break;

                            case CStorySceneScript cssscpt:
                                if (cssscpt.BufferParameters != null)
                                    returnedVariables.AddRange(cssscpt.BufferParameters.Select(item =>
                                        new SNameArg(EStringTableMod.SkipType, item)));
                                break;

                            case CQuestScriptBlock qsb:
                                if (qsb.BufferParameters != null)
                                    returnedVariables.AddRange(qsb.BufferParameters.Select(item =>
                                        new SNameArg(EStringTableMod.SkipType, item)));
                                break;

                            case CFXTrackItem cfxti:
                                returnedVariables.Add(new SNameArg(EStringTableMod.SkipNameAndType, cfxti.buffername));
                                break;

                            case CPhysicalCollision cpc:
                                returnedVariables.Add(new SNameArg(EStringTableMod.None, cpc.Collisiontypes));
                                break;

                            default:
                                break;
                        }

                        #endregion Buffer Hacks After Variables

                        break;
                    }
                    default:
                        break;
                }

                return returnedVariables;
            }

            void AddStrings(SNameArg tvar)
            {
                var var = tvar.Item2;

                if (var is SFoliageInstanceData)
                    return;

                // these CVariables have special requirements, for all others:  switch StringtableMod
                if (!(var is CBufferVLQInt32<CName> ||
                    var is IdHandle ||
                    var is SEntityBufferType1 ||
                    var is SUmbraSceneData)
                    )
                {
                    CheckVarNameAndTypes();
                }

                // array-type and ptr-type variables have special stringmods
                if (var is SUmbraSceneData)
                {
                    var h = (var as SUmbraSceneData).Umbratile;
                    if (!h.ChunkHandle)
                    {
                        AddUniqueToTable(h.ClassName);
                        var importtuple = new SImportEntry(h.ClassName, h.DepotPath, EImportFlags.Default);
                        if (!newimportslist.Contains(importtuple))
                        {
                            newimportslist.Add(importtuple);
                        }
                    }
                }
                //else if (var is CFlags)
                //{
                //    foreach (var flag in (var as CFlags).flags)
                //    {
                //        AddUniqueToTable(flag.Value);
                //    }
                //}
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
                        {
                            // this is needed because CDPR made one class (SWitcherSign)
                            // which also has a template handle:CEntityTemplate property lol
                            if (h.ParentVar is CEntity)
                                flags = EImportFlags.Template;
                        }

                        if ((var.Cr2wFile as CR2WFile).Embedded.Any(_ => _.ImportPath == h.DepotPath && _.ImportClass == h.ClassName))
                            flags = EImportFlags.Inplace;

                        var importtuple = new SImportEntry(h.ClassName, h.DepotPath, flags);
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
                        var stuple = new SImportEntry(s.ClassName, s.DepotPath, EImportFlags.Soft);
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
                    if (var is IBufferAccessor buffer)
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
                                    var importtuple = new SImportEntry(ha.ClassName, ha.DepotPath, flags);
                                    if (!newimportslist.Contains(importtuple))
                                    {
                                        newimportslist.Add(importtuple);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        CheckVarNameAndTypes();

                        if (var is CArray<CName> aa)
                        {
                            foreach (var element in aa)
                            {
                                AddUniqueToTable(element.Value);
                            }
                        }
                    }
                }
                else if (var is CBufferVLQInt32<CName>)
                {
                    foreach (var element in (var as CBufferVLQInt32<CName>).elements)
                    {
                        if (element is CName)
                        {
                            AddUniqueToTable((element as CName).Value);
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
                else if (var is SEntityBufferType1)
                {
                    AddUniqueToTable((var as SEntityBufferType1).ComponentName.Value);
                }
                else if (var is IEnumAccessor enumAccessor)
                {
                    foreach (var enumstring in enumAccessor.EnumValueList)
                    {
                        AddUniqueToTable(enumstring);
                    }
                }
                else
                {
                    CheckVarNameAndTypes();

                    #region Buffer Hacks Before Variables

                    if (var is CEntity ent)
                    {
                        CHandle<CEntityTemplate> t = ent.Template;
                        if (t != null && !t.ChunkHandle)
                            AddUniqueToTable(t.ClassName);
                    }

                    #endregion Buffer Hacks Before Variables
                }

                void CheckVarNameAndTypes()
                {
                    switch (tvar.Item1)
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
            for (var i = 0; i < Chunks.Count; i++)
            {
                Chunks[i].WriteData(bw);
            }

            m_fileheader.fileSize = (uint)bw.BaseStream.Position;

            //Write Buffer data
            if (m_hasInternalBuffer)
            {
                for (var i = 0; i < Buffers.Count; i++)
                {
                    Buffers[i].WriteData(bw);
                }
            }
            m_fileheader.bufferSize = (uint)bw.BaseStream.Position;

            // Write embedded data
            for (var i = 0; i < Embedded.Count; i++)
            {
                Embedded[i].WriteData(bw);
            }
        }

        private void WriteFileHeader(BinaryWriter file)
        {
            file.BaseStream.Seek(0, SeekOrigin.Begin);

            file.BaseStream.WriteStruct<uint>(MAGIC);
            file.BaseStream.WriteStruct<CR2WFileHeader>(m_fileheader);
            file.BaseStream.WriteStructs<CR2WTable>(m_tableheaders); // offsets change if stringtable changes
            WriteStringBuffer(file.BaseStream);
        }

        private void WriteHeader(BinaryWriter file)
        {
            WriteFileHeader(file);

            #region Write Tables

            m_tableheaders[1].itemCount = (uint)Names.Count;
            m_tableheaders[1].offset = (uint)file.BaseStream.Position;
            WriteTable<CR2WName>(file.BaseStream, Names.Select(_ => (_ as CR2WNameWrapper).Name).ToArray(), 1);

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
        public struct SImportEntry
        {
            #region Fields

            public readonly string Item1;
            public readonly string Item2;
            public readonly EImportFlags Item3;

            #endregion Fields

            #region Constructors

            public SImportEntry(string i1, string i2, EImportFlags i3)
            {
                Item1 = i1;
                Item2 = i2;
                Item3 = i3;
            }

            #endregion Constructors
        };

        // Those where before tuples, passed between functions. Got sick of them and made structs.
        // Got lazy and did not rewrite elements in code, hence ItemN attributes. //FIXME unimportant
        public struct SNameArg
        {
            #region Fields

            public EStringTableMod Item1;
            public IEditableVariable Item2;

            #endregion Fields

            #region Constructors

            public SNameArg(EStringTableMod i1, IEditableVariable i2)
            {
                Item1 = i1;
                Item2 = i2;
            }

            #endregion Constructors
        };

        #endregion Write
    }
}
