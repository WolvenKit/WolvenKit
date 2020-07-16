using RED.CRC32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.CR2W.Types;
using WolvenKit.CR2W.Types.Utils;
using WolvenKit.Utils;

namespace WolvenKit.CR2W
{
    [ DataContract(Namespace = "") ]
    public class CR2WFile
    {
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
        }

        public CR2WFile(BinaryReader file)
        {
            Logger = new LoggerService(); //dummy
            Read(file);
            //m_filePath = 
        }
        public CR2WFile(BinaryReader file, LoggerService logger)
        {
            Logger = logger;
            Read(file);
            //m_filePath = 
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
        private Stream m_stream; //handle this better?
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


        public List<CLocalizedString> LocalizedStrings = new List<CLocalizedString>();
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
        public (List<CR2WImportWrapper>, bool, List<CR2WBufferWrapper>) ReadImportsAndBuffers(BinaryReader file)
        {
            m_stream = file.BaseStream;

            // read file header
            var id = ReadStruct<uint>();
            if (id != MAGIC)
                throw new FormatException($"Not a CR2W file, Magic read as 0x{id:X8}");

            m_fileheader = ReadStruct<CR2WFileHeader>();
            if (m_fileheader.version > 163 || m_fileheader.version < 159)
                throw new FormatException($"Unknown Version {m_fileheader.version}. Supported versions: 159 - 163.");

            var dt = new CDateTime(m_fileheader.timeStamp);

            m_tableheaders = ReadStructs<CR2WTable>(10);
            m_hasInternalBuffer = m_fileheader.bufferSize > m_fileheader.fileSize;

            // read strings
            m_strings = ReadStringsBuffer();

            // read tables
            names = ReadTable<CR2WName>(1).Select(_ => new CR2WNameWrapper(_, this)).ToList();
            imports = ReadTable<CR2WImport>(2).Select(_ => new CR2WImportWrapper(_, this)).ToList();
            properties = ReadTable<CR2WProperty>(3).Select(_ => new CR2WPropertyWrapper(_)).ToList();
            chunks = ReadTable<CR2WExport>(4).Select(_ => new CR2WExportWrapper(_, this)).ToList();
            buffers = ReadTable<CR2WBuffer>(5).Select(_ => new CR2WBufferWrapper(_)).ToList();

            return (imports, m_hasInternalBuffer, buffers);
        }

        public void Read(BinaryReader file)
        {
            m_stream = file.BaseStream;

            #region Read Headers
            Logger.LogProgress(1, "Reading headers...");
            // read file header
            var id = ReadStruct<uint>();
            if (id != MAGIC)
                throw new FormatException($"Not a CR2W file, Magic read as 0x{id:X8}");

            m_fileheader = ReadStruct<CR2WFileHeader>();
            if (m_fileheader.version > 163 || m_fileheader.version < 159)
                throw new FormatException($"Unknown Version {m_fileheader.version}. Supported versions: 159 - 163.");

            var dt = new CDateTime(m_fileheader.timeStamp);

            m_tableheaders = ReadStructs<CR2WTable>(10);
            m_hasInternalBuffer = m_fileheader.bufferSize > m_fileheader.fileSize;

            // read strings
            m_strings = ReadStringsBuffer();
            
            // read tables
            names = ReadTable<CR2WName>(1).Select(_ => new CR2WNameWrapper(_, this)).ToList();
            imports = ReadTable<CR2WImport>(2).Select(_ => new CR2WImportWrapper(_, this)).ToList();
            properties = ReadTable<CR2WProperty>(3).Select(_ => new CR2WPropertyWrapper(_)).ToList();
            chunks = ReadTable<CR2WExport>(4).Select(_ => new CR2WExportWrapper(_, this)).ToList();
            buffers = ReadTable<CR2WBuffer>(5).Select(_ => new CR2WBufferWrapper(_)).ToList();
            embedded = ReadTable<CR2WEmbedded>(6).Select(_ => new CR2WEmbeddedWrapper(_)
            {
                ParentFile = this,
                ParentImports = imports,
                Handle = StringDictionary[_.path],
            }).ToList();

            Logger.LogProgress(100);
            #endregion

            #region Read Data
            Logger.LogProgress(1, "Reading chunks...");
            // Read object data //block 5
            for (int i = 0; i < chunks.Count; i++)
            {
                CR2WExportWrapper chunk = chunks[i];
                chunk.ReadData(file);

                int percentprogress = (int)((float)i / (float)chunks.Count * 100.0);
                Logger.LogProgress(percentprogress, $"Reading chunk {chunk.Name}...");
            }
            // Read buffer data //block 6
            if (m_hasInternalBuffer)
            {
                for (int i = 0; i < buffers.Count; i++)
                {
                    CR2WBufferWrapper buffer = buffers[i];
                    buffer.ReadData(file);

                    int percentprogress = (int)((float)i / (float)buffers.Count * 100.0);
                    Logger.LogProgress(percentprogress);
                }
            }
            // Read embedded files //block 7
            for (int i = 0; i < embedded.Count; i++)
            {
                CR2WEmbeddedWrapper emb = embedded[i];
                emb.ReadData(file);

                int percentprogress = (int)((float)i / (float)embedded.Count * 100.0);
                Logger.LogProgress(percentprogress, $"Reading embedded file {emb.ClassName}...");
            }
            #endregion

            m_stream = null;
        }




        #endregion

        public CVariable ReadVariable(BinaryReader file)
        {
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
            var parsedvar = CR2WTypeManager.Get().GetByName(typename, varname, this);
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
                chunks[i].SetType( (ushort)GetStringIndex(chunks[i].Type));
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

            m_stream = null;

            void FixExportCRC32(CR2WExport export) //FIXME do I wanna keep the ref?
            {
                m_stream.Seek(export.dataOffset, SeekOrigin.Begin);
                var m_temp = new byte[export.dataSize];
                m_stream.Read(m_temp, 0, m_temp.Length);
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
            var collection = new List<Tuple<string, CVariable>>();
            foreach (var c in chunks)
            {
                chunkguidlist.Add(c.data.InternalGuid);
                LoopWrapper(new Tuple<string, CVariable>("skipName", c.data));
            }
            foreach (var storedvar in collection)
            {
                AddStrings(storedvar);
            }
            
            newimportslist.AddRange(newsoftlist);

            return (newnameslist, newimportslist);

            void LoopWrapper(Tuple<string, CVariable> var)
            {
                collection.Add(var);
                List<Tuple<string, CVariable>> nextl = GetVariables(var.Item2);
                if (nextl == null)
                    return;
                foreach (var l in nextl)
                {
                    if (l.Item2 != null)
                        LoopWrapper(l);
                }
            }

            List<Tuple<string,CVariable>> GetVariables(CVariable var)
            {
                //check for looping references
                if (guidlist.Contains(var.InternalGuid))
                    return null;
                else
                    guidlist.Add(var.InternalGuid);

                var returnedVariables = new List<Tuple<string, CVariable>>();

                if (var is CVector)
                {
                    #region Buffer Hacks Before Variables
                    if (var is CEntity)
                    {
                        var t = (var as CVector).variables.FirstOrDefault(_ => _.Name == "template");
                        if (t != null)
                            returnedVariables.Add(new Tuple<string, CVariable>("skipName,skipType", t as CHandle));
                    }
                    // always checks for the variable parent first
                    //else if (var is CBehaviorGraphStateMachineNode)
                    //    returnedVariables.Add(new Tuple<string, CVariable>("", (var.cr2w.chunks.First().data as CBehaviorGraph).Toplevelnode.Reference.data));
                    //else if (var.Type != null && (
                    //    var.Type.Contains("CBehaviorGraphMimicSlotNode") ||
                    //    var.Type.Contains("CBehaviorGraphPoseSlotNode") ||
                    //    var.Type.Contains("CBehaviorGraphAnimationSlotNode") ||
                    //    var.Type.Contains("CBehaviorGraphAnimationBaseSlotNode")
                    //    ))
                    //    returnedVariables.Add(new Tuple<string, CVariable>("", (var.cr2w.chunks.First().data as CBehaviorGraph).Toplevelnode.Reference.data));

                    //else if (var.Type != null && 
                    //    (var.Type.Contains("CMeshSkinningAttachment") ||
                    //    var.Type.Contains("CHardAttachment") ||
                    //    var.Type.Contains("CAnimatedAttachment")
                    //    ))
                    //{
                    //    if ((var as CVector).variables != null && (var as CVector).variables.Count > 0)
                    //    {
                    //        if ((var as CVector).variables.First().Name == "parent")
                    //            returnedVariables.Add(new Tuple<string, CVariable>("skipName,skipType", (var as CVector).variables.First()));
                    //    }
                    //}
                    else if (var.ParentVariable != null)
                    {
                        returnedVariables.Add(new Tuple<string, CVariable>("", var.ParentVariable));
                    }
                    #endregion

                    // for all other variables 
                    foreach (var item in (var as CVector).variables)
                    {
                        returnedVariables.Add(new Tuple<string, CVariable>("", (item)));
                    }

                    #region Buffer Hacks After Variables
                    // hack for CUmbraScene *sigh*
                    if (var is CFoliageResource)
                    {
                        foreach (CVariable item in (var as CFoliageResource).Trees)
                            returnedVariables.Add(new Tuple<string, CVariable>("", (item)));
                        foreach (CVariable item in (var as CFoliageResource).Grasses)
                            returnedVariables.Add(new Tuple<string, CVariable>("", item));
                    }
                    // hack for CClipMap *sigh*
                    else if (var is CClipMap)
                        returnedVariables.Add(new Tuple<string, CVariable>("", (var as CClipMap).tiles));
                    // hack for CUmbraScene *sigh*
                    else if (var is CUmbraScene)
                        foreach (SUmbraSceneData item in (var as CUmbraScene).tiles.elements) //handled in GetStrings
                            returnedVariables.Add(new Tuple<string, CVariable>("", item));

                    // hack for CSkeletalAnimationSetEntry *sigh*
                    else if (var is CSkeletalAnimationSetEntry)
                        foreach (CVariable item in (var as CSkeletalAnimationSetEntry).entries)
                            returnedVariables.Add(new Tuple<string, CVariable>("", item));
                    // hack for CLayerInfo *sigh*
                    else if (var is CLayerInfo)
                        returnedVariables.Add(new Tuple<string, CVariable>("", (var as CLayerInfo).ParentGroup.Reference?.data));
                    // hack for CMaterialInstance *sigh*
                    else if (var is CMaterialInstance)
                        foreach (CVariable iparam in (var as CMaterialInstance).instanceParameters)
                            returnedVariables.Add(new Tuple<string, CVariable>("", iparam));
                    // hack for CMesh *sigh*
                    else if (var is CMesh)
                        returnedVariables.Add(new Tuple<string, CVariable>("", (var as CMesh).boneNames));
                    // hack for CBehaviorGraphContainerNode *sigh*
                    else if (var is CBehaviorGraphContainerNode)
                    {
                        foreach (CHandle item in (var as CBehaviorGraphContainerNode).inputnodes.elements)
                            returnedVariables.Add(new Tuple<string, CVariable>("", (item.Reference?.data)));
                        returnedVariables.Add(new Tuple<string, CVariable>("", (var as CBehaviorGraphContainerNode).unk1));
                        returnedVariables.Add(new Tuple<string, CVariable>("", (var as CBehaviorGraphContainerNode).unk2));
                        returnedVariables.Add(new Tuple<string, CVariable>("", (var as CBehaviorGraphContainerNode).outputnode.Reference?.data));
                    }
                    // hack for CBehaviorGraphStateMachineNode *sigh*
                    else if (var is CBehaviorGraphStateMachineNode)
                    {
                        foreach (CHandle item in (var as CBehaviorGraphStateMachineNode).inputnodes.elements)
                            returnedVariables.Add(new Tuple<string, CVariable>("", item.Reference?.data));
                        returnedVariables.Add(new Tuple<string, CVariable>("", (var as CBehaviorGraphStateMachineNode).unk1));
                        returnedVariables.Add(new Tuple<string, CVariable>("", (var as CBehaviorGraphStateMachineNode).unk2));
                    }
                    // hack for CBehaviorGraphStateMachineNode *sigh*
                    else if (var is CBehaviorGraph)
                    {
                        var b = var as CBehaviorGraph;
                        returnedVariables.Add(new Tuple<string, CVariable>("", b.Toplevelnode.Reference?.data));
                        foreach (IdHandle item in b.variables1.elements)
                            returnedVariables.Add(new Tuple<string, CVariable>("", item));
                        foreach (CHandle item in b.descriptions.elements)
                            returnedVariables.Add(new Tuple<string, CVariable>("", item.Reference?.data));
                        foreach (IdHandle item in b.vectorvariables1.elements)
                            returnedVariables.Add(new Tuple<string, CVariable>("", item));
                        foreach (IdHandle item in b.variables2.elements)
                            returnedVariables.Add(new Tuple<string, CVariable>("", item));
                        foreach (IdHandle item in b.vectorvariables2.elements)
                            returnedVariables.Add(new Tuple<string, CVariable>("", item));
                    }
                    // hack for CComponent *sigh*
                    if (var is CNode)
                    {
                        foreach (CVariable att in (var as CNode).attachmentsChild)
                            returnedVariables.Add(new Tuple<string, CVariable>("", att));
                        foreach (CVariable att in (var as CNode).attachmentsReference)
                            returnedVariables.Add(new Tuple<string, CVariable>("", att));
                    }
                    // hack for CEntity *sigh*
                    if (var is CEntity)
                    {
                        var e = var as CEntity;
                        foreach (CVariable component in e.components)
                            returnedVariables.Add(new Tuple<string, CVariable>("", component));
                        foreach (CEntityBufferType1 buffer in (e.buffer_v1 as CVector).variables)
                            returnedVariables.Add(new Tuple<string, CVariable>("", buffer));
                        foreach (CEntityBufferType2 item in e.buffer_v2.elements)
                        {
                            returnedVariables.Add(new Tuple<string, CVariable>("skipName,skipType", item.componentName));
                            foreach (CVariableWrapper el in item.variables.elements)
                            {
                                returnedVariables.Add(new Tuple<string, CVariable>("Typefirst", el.variable));
                            }
                        }
                    }
                    // hack for SAppearanceAttachment *sigh*
                    else if (var is SAppearanceAttachment)
                        foreach (CVariable item in (var as SAppearanceAttachment).Data.elements)
                            returnedVariables.Add(new Tuple<string, CVariable>("", item));
                    // hack for CSkeletalAnimationSetEntry *sigh*
                    else if (var is CSkeletalAnimationSetEntry)
                        foreach (CVariable item in (var as CSkeletalAnimationSetEntry).entries)
                            returnedVariables.Add(new Tuple<string, CVariable>("", item));
                    // hack for SAppearanceAttachment *sigh*
                    else if (var is CCutsceneTemplate)
                        foreach (CVectorWrapper item in (var as CCutsceneTemplate).animevents.elements)
                            returnedVariables.Add(new Tuple<string, CVariable>("", item.variable));
                    // hack for CStorySceneSection *sigh*
                    else if (var is CStorySceneSection)
                        foreach (CVariable item in (var as CStorySceneSection).sceneEventElements)
                            returnedVariables.Add(new Tuple<string, CVariable>("", item));
                    // hack for CStorySceneScript *sigh*
                    else if (var is CStorySceneScript)
                        foreach (CVariable item in (var as CStorySceneScript).parameters)
                            returnedVariables.Add(new Tuple<string, CVariable>("", item));
                    // hack for CFXTrackItem *sigh*
                    else if (var is CFXTrackItem)
                        returnedVariables.Add(new Tuple<string, CVariable>("skipName,skipType", (var as CFXTrackItem).buffername));
                    #endregion
                }
                // hack for CPhysicalCollision *sigh*
                else if (var is CPhysicalCollision)
                {
                    returnedVariables.Add(new Tuple<string, CVariable>("", (var as CPhysicalCollision).Collisiontypes));
                }
                else if (var is CArray)
                {
                    if ((var as CArray).array.Count > 0 )
                    {
                        foreach (var element in (var as CArray).array)
                        {
                            if (
                                element is CBool || element is CName ||
                                element is CUInt16 || element is CInt16 ||
                                element is CUInt32 || element is CInt32 ||
                                element is CUInt64 || element is CInt64
                                )
                            {

                            }
                            else
                                returnedVariables.Add(new Tuple<string, CVariable>("", element));
                        }
                        if ((var as CArray).array.First() is CName)
                            returnedVariables.Add(new Tuple<string, CVariable>("", var));
                    }
                }
                else if (var is CPtr)
                {
                    var p = var as CPtr;
                    if (p.Reference != null)
                        returnedVariables.Add(new Tuple<string, CVariable>("", (var as CPtr).Reference.data));
                }
                else if (var is CHandle)
                {
                    var h = var as CHandle;
                    if (h.ChunkHandle)
                    {
                        if (h.Reference != null)
                            returnedVariables.Add(new Tuple<string, CVariable>("", h.Reference.data));
                    }
                }
                else if (var is CSoft)
                {
                    //var s = var as CSoft;
                    //if (!(string.IsNullOrEmpty(s.ClassName) && string.IsNullOrEmpty(s.DepotPath)))
                    //{
                    //    var stuple = new Tuple<string, string, EImportFlags>(s.ClassName, s.DepotPath, EImportFlags.Soft);
                    //    if (!newimportslist.Contains(stuple))
                    //    {
                    //        newimportslist.Add(stuple);
                    //    }
                    //}
                }
                else if (var is IdHandle)
                {
                    var i = var as IdHandle;
                    returnedVariables.Add(new Tuple<string, CVariable>("", i));
                    returnedVariables.Add(new Tuple<string, CVariable>("", i.handle.Reference?.data));
                }
                else if (var is CVariant)
                {
                    returnedVariables.Add(new Tuple<string, CVariable>("", (var as CVariant).Variant));
                }

                return returnedVariables;
            }

            void AddStrings(Tuple<string, CVariable> tvar)
            {
                var var = tvar.Item2;
                if (var is SFoliageInstance)
                    return;
                if (!(var is CBufferVLQ<CName> ||
                    var is CBufferUInt32<CHandle> ||
                    var is IdHandle ||
                    var is CEntityBufferType1 ||
                    var is SUmbraSceneData
                    ))
                {
                    if (tvar.Item1.Contains("Typefirst"))
                    {
                        AddUniqueToTable(var.Type);
                        AddUniqueToTable(var.Name);
                    }
                    // I'm sorry
                    else if (tvar.Item1 == "skipName" || chunkguidlist.Contains(tvar.Item2.InternalGuid))
                    {
                        AddUniqueToTable(var.Type);
                    }
                    else if (!tvar.Item1.Contains("skipName,skipType"))
                    {
                        AddUniqueToTable(var.Name);
                        AddUniqueToTable(var.Type);
                    }
                }

                if (var is CVector)
                {
                    //AddUniqueToTable(var.Name);
                    //AddUniqueToTable(var.Type);
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
                else if (var is CTagList)
                {
                    foreach (var tag in (var as CTagList).tags)
                    {
                        AddUniqueToTable(tag.Value);
                    }
                }
                else if (var is CHandle)
                {
                    var h = var as CHandle;
                    if (!h.ChunkHandle)
                    {
                        AddUniqueToTable(h.ClassName);
                        var flags = EImportFlags.Default;
                        if (h.Name == "template" && h.ClassName == "CEntityTemplate")
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
                else if (var is CSoft)
                {
                    var s = var as CSoft;
                    if (!(string.IsNullOrEmpty(s.ClassName) && string.IsNullOrEmpty(s.DepotPath)))
                    {
                        AddUniqueToTable(s.Type);
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
                else if (var is CArray)
                {
                    AddUniqueToTable(var.Name);
                    AddUniqueToTable((var as CArray).Type);
                    foreach (var element in (var as CArray).array)
                    {
                        if (element is CName )
                        {
                            AddUniqueToTable((element as CName).Value);
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
                else if (var is CBufferUInt32<CHandle>)
                {
                    foreach (CHandle h in (var as CBufferUInt32<CHandle>).elements)
                    {
                        if (!h.ChunkHandle)
                        {
                            AddUniqueToTable(h.ClassName);
                            var flags = EImportFlags.Default;
                            if (h.Name == "template")
                                flags = EImportFlags.Template;
                            var importtuple = new Tuple<string, string, EImportFlags>(h.ClassName, h.DepotPath, flags);
                            if (!newimportslist.Contains(importtuple))
                            {
                                newimportslist.Add(importtuple);
                            }
                        }
                    }
                }
                else if (var is CPtr)
                {
                }
                else if (var is IdHandle)
                {
                    AddUniqueToTable((var as IdHandle).handlename.Value);
                }
                else if (var is CString)
                {
                    AddUniqueToTable(var.Name);
                    AddUniqueToTable(var.Type);
                }
                else if (var is CEntityBufferType1)
                {
                    AddUniqueToTable((var as CEntityBufferType1).ComponentName.Value);
                }
                else
                {
                    AddUniqueToTable(var.Type);
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
            WriteTable<CR2WName>(names.Select(_ => _.Name).ToArray(), 1);
            
            m_tableheaders[2].size = (uint)imports.Count;
            m_tableheaders[2].offset = imports.Count > 0 ? (uint) file.BaseStream.Position : 0;
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
        private byte[] ReadStringsBuffer()
        {
            var start = m_tableheaders[0].offset;
            var size = m_tableheaders[0].size;
            var crc = m_tableheaders[0].crc32;

            var m_temp = new byte[size];
            m_stream.Read(m_temp, 0, m_temp.Length);

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
            
            var chunk = new CR2WExportWrapper(this)
            {
                Type = type
            };

            chunk.CreateDefaultData();
            if (parent != null)
            {
                chunk.SetParentChunkId((uint)chunks.IndexOf(parent) + 1);
            }

            chunks.Add(chunk);
            return chunk;
        }

        public CR2WExportWrapper CreateChunk(string type, CVariable data, CR2WExportWrapper parent = null)
        {
            var chunk = new CR2WExportWrapper(this)
            {
                Type = type,
                data = data
            };
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

            //if (addnew)
            //{
            //    var newstring = new CR2WNameWrapper
            //    {
            //        Str = name
            //    };
            //    names.Add(newstring);

            //    return names.Count - 1;
            //}

            throw new NotImplementedException();
            return -1;
        }

        //public int GetHandleIndex(string name, ushort filetype, ushort flags, bool addnew = false)
        //{
        //    for (var i = 0; i < imports.Count; i++)
        //    {
        //        if (imports[i].Import.className == filetype 
        //            && imports[i].Import.flags == flags 
        //            && (imports[i].DepotPathStr == name || (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(imports[i].DepotPathStr))))
        //            return i;
        //    }

        //    if (addnew)
        //    {
        //        // we can leave the depotpath 0 here, it will get updated on file write
        //        // value is the offset in the stringtable, which gets re-written on file write
        //        // a better solution might be to dynamically update the import table 
        //        var import = new CR2WImport()
        //        {
        //            flags = flags,
        //            depotPath = 0, 
        //            className = filetype
        //        };
        //        imports.Add(new CR2WImportWrapper(import)
        //        {
        //            DepotPathStr = name,
        //        });

        //        return imports.Count - 1;
        //    }

        //    return -1;
        //}

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

            ptr.DepotPath = handle;
            ptr.ClassName = targetType;

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

            ptr.ClassName = targetType;
            ptr.Flags = 4;
            ptr.DepotPath = handle;
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
                //ptr.val = chunks.IndexOf(tochunk) + 1;
                ptr.Reference = tochunk;
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