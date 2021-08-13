using System;
using System.Collections.Generic;
using WolvenKit.Interfaces.Core;
using System.IO;
using System.Runtime.InteropServices;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.FNV1A;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Common.Services;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.Common;
using Newtonsoft.Json;
using WolvenKit.Core.Exceptions;

namespace WolvenKit.Modkit.RED4.Compiled
{
    public class CompiledPackage : ObservableObject, IRed4EngineFile
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        struct header
        {
            [FieldOffset(0)]
            public UInt16 uk1;

            [FieldOffset(2)]
            public UInt16 uk2;  // sections count apparently mostly its 7

            [FieldOffset(4)]
            public UInt32 ids_cnt;

            [FieldOffset(8)]
            public UInt32 rarefpool_descs_offset;

            [FieldOffset(12)]
            public UInt32 rarefpool_data_offset;

            [FieldOffset(16)]
            public UInt32 strpool_descs_offset;

            [FieldOffset(20)]
            public UInt32 strpool_data_offset;

            [FieldOffset(24)]
            public UInt32 obj_descs_offset;

            [FieldOffset(28)]
            public UInt32 objdata_offset;
        }

        header _header;
        UInt16 _uk1;
        List<UInt64> _ids { get; set; }
        public Dictionary<uint, string> StrTable1asStr { get; set; } // Imports TBH, if string exists directly in the file both StrTable1asStr and StrTable1asHash is filled
        public Dictionary<uint, UInt64> StrTable1asHash { get; set; } // Imports as hashes TBH, if string exists as Hashes then Obvs only StrTable1asHash can be filled
        public Dictionary<uint, string> StrTable2asStr { get; set; } // Names TBH
        List<ObjDesc> ObjectDescs; // Names Idx and Offset of Object Data in file from Origin

        const UInt32 strTable1SizeBitShift = 23;
        const UInt32 strTable1OffsetMask = (1U << (int)strTable1SizeBitShift) - 1U;
        const UInt32 strTable2SizeBitShift = 24;
        const UInt32 strTable2OffsetMask = (1U << (int)strTable2SizeBitShift) - 1U;
        const UInt32 sizeBitMask = (1U << 8) - 1;

        private readonly IHashService _hashService;
        public CompiledPackage(IHashService hashservice)
        {
            _hashService = hashservice;
            Names = new List<ICR2WName>();
            Imports = new List<ICR2WImport>();
            Chunks = new List<ICR2WExport>();
            Buffers = new List<ICR2WBuffer>();

            _ids = new List<ulong>();
            StrTable1asStr = new Dictionary<uint, string>();
            StrTable1asHash = new Dictionary<uint, ulong>();
            StrTable2asStr = new Dictionary<uint, string>();
            ObjectDescs = new List<ObjDesc>();
        }
        public EFileReadErrorCodes Read(BinaryReader br)
        {
            _header = br.BaseStream.ReadStruct<header>();
            if (_header.rarefpool_descs_offset != 0)
                throw new Exception("m_header.u32arr_offset != 0");

            _uk1 = br.ReadUInt16();
            UInt16 ids_cnt;
            ids_cnt = br.ReadUInt16();
            if (ids_cnt != _header.ids_cnt)
                throw new Exception("ids_cnt != m_header.ids_cnt");

            _ids = new List<ulong>();
            for (int i = 0; i < ids_cnt; i++)
                _ids.Add(br.ReadUInt64());

            long baseOff = br.BaseStream.Position;
            UInt32 rarefpool_descs_size = _header.rarefpool_data_offset - _header.rarefpool_descs_offset;

            for (uint i = 0; i < rarefpool_descs_size/4; i++)
            {
                br.BaseStream.Seek(baseOff + _header.rarefpool_descs_offset + i * 4, SeekOrigin.Begin);
                UInt32 maskData = br.ReadUInt32();
                UInt32 off = maskData & strTable1OffsetMask;
                UInt32 len = (maskData >> (int)strTable1SizeBitShift) & sizeBitMask;

                if(_uk1 == 0)
                {
                    br.BaseStream.Seek(baseOff + off, SeekOrigin.Begin);
                    string name = new string(br.ReadChars((int)len));
                    StrTable1asStr.Add(i, name);
                    StrTable1asHash.Add(i, FNV1A64HashAlgorithm.HashString(name));
                }
                else
                {
                    br.BaseStream.Seek(baseOff + off, SeekOrigin.Begin);
                    StrTable1asHash.Add(i, br.ReadUInt64());
                    StrTable1asStr.Add(i, _hashService.Get(StrTable1asHash[i]));
                }
                Imports.Add(new Import(this, i));
            }

            UInt32 strpool_descs_size = _header.strpool_data_offset - _header.strpool_descs_offset;

            for (uint i = 0; i < strpool_descs_size / 4; i++)
            {
                br.BaseStream.Seek(baseOff + _header.strpool_descs_offset + i * 4, SeekOrigin.Begin);
                UInt32 maskData = br.ReadUInt32();
                UInt32 off = maskData & strTable2OffsetMask;
                UInt32 len = (maskData >> (int)strTable2SizeBitShift) & sizeBitMask;

                br.BaseStream.Seek(baseOff + off, SeekOrigin.Begin);
                string name = new string(br.ReadChars((int)len-1));
                StrTable2asStr.Add(i, name);
                Names.Add(new Name(this, i));
            }
            UInt32 obj_descs_size = _header.objdata_offset - _header.obj_descs_offset;;

            for (int i = 0; i < obj_descs_size / 8; i++)
            {
                br.BaseStream.Seek(baseOff + _header.obj_descs_offset + i * 8, SeekOrigin.Begin);
                UInt32 varNameIdx = br.ReadUInt32();
                UInt32 off = br.ReadUInt32();

                ObjDesc obj_desc = new ObjDesc(varNameIdx, off + baseOff);
                ObjectDescs.Add(obj_desc);
            }
            List<uint> sizes = new List<uint>();
            for (int i = 0; i < ObjectDescs.Count; i++)
            {
                uint size = 0;
                if(i < ObjectDescs.Count - 1)
                {
                    size = (uint)(ObjectDescs[i + 1].objDataOffset - ObjectDescs[i].objDataOffset);
                }
                else
                {
                    size = (uint)(br.BaseStream.Length - ObjectDescs[i].objDataOffset);
                }
                sizes.Add(size);
            }
            for (int i = 0; i < ObjectDescs.Count; i++)
            {
                var cvar = CreateChunk(Names[(int)ObjectDescs[i].NameIdx].Str, i).Data;
                try
                {
                    if (cvar.ChildrEditableVariables.Count > 0)
                    {
                        br.BaseStream.Position = ObjectDescs[i].objDataOffset;
                        var bytes = br.ReadBytes((int)sizes[i]);
                        ReadVariable(new BinaryReader(new MemoryStream(bytes)), cvar);
                    }
                }
                catch { }
            }
            return EFileReadErrorCodes.NoError;
        }
        [JsonIgnore] public bool CreatePropertyOnAccess { get; set; } = true;
        [JsonIgnore] public bool IsDirty { get; set; }
        [JsonIgnore] public string FileName { get; set; }
        [JsonIgnore] public List<string> UnknownTypes { get; } = new();
        [JsonIgnore] public List<string> UnknownVars { get; set; } = new();
        [JsonIgnore] public Dictionary<uint, string> StringDictionary { get; private set; }
        [JsonIgnore] public List<ICR2WName> Names { get; private set; }
        [JsonIgnore] public List<ICR2WImport> Imports { get; private set; }
        public List<ICR2WExport> Chunks { get; set; }
        public List<ICR2WBuffer> Buffers { get; set; }
        public IEditableVariable ReadVariable(BinaryReader br, IEditableVariable parent)
        {
            long basePos = br.BaseStream.Position;
            ushort numChilds = br.ReadUInt16();
            List<uint> offs = new List<uint>();
            for (ushort i = 0; i < numChilds; i++)
            {
                br.BaseStream.Position += 4;
                offs.Add(br.ReadUInt32());
            }
            List<uint> sizes = new List<uint>();
            for (ushort i = 0; i < numChilds; i++)
            {
                uint size = 0;
                if(i < numChilds - 1)
                {
                    size = offs[i + 1] - offs[i];
                }
                else
                {
                    size = (uint)br.BaseStream.Length - offs[i];
                }
                sizes.Add(size);
            }
            long pos = basePos + 2;
            for (ushort i = 0; i < numChilds; i++)
            {
                br.BaseStream.Position = pos;
                ushort name = br.ReadUInt16();
                string varname = Names[name].Str;
                ushort type = br.ReadUInt16();
                string typename = Names[type].Str;
                uint off = br.ReadUInt32();
                pos = br.BaseStream.Position;
                var parsedvar = parent.GetPropertyByREDName(varname);
                if (parsedvar == null || parsedvar.REDType != typename)
                {
                    throw new MissingRTTIException(varname, typename, parent.REDType);
                }
                br.BaseStream.Position = off + basePos;
                if ((parsedvar.ChildrEditableVariables.Count > 0) && (parsedvar is not DataBuffer))
                {
                    var bytes = br.ReadBytes((int)sizes[i]);
                    ReadVariable(new BinaryReader(new MemoryStream(bytes)),parsedvar);
                }
                else if(parsedvar is DataBuffer)
                {
                    ((DataBuffer)parsedvar).Buffer.Value = (ushort)Buffers.Count;
                    uint size = br.ReadUInt32();
                    CR2WBufferWrapper buff = new CR2WBufferWrapper();
                    buff.DiskSize = size;
                    buff.ReadData(br);
                    Buffers.Add(buff);
                }
                else
                {
                    if (parsedvar is IREDRef)
                    {
                        var reMs = new MemoryStream();
                        var reBw = new BinaryWriter(reMs);
                        reBw.Write(br.ReadUInt16() + 1);
                        reMs.Position = 0;
                        parsedvar.Read(new BinaryReader(reMs), 2);
                    }
                    else if(parsedvar is IREDArray arr)
                    {
                        uint len = br.ReadUInt32();
                        for (uint e = 0; e < len; e++)
                        {
                            var element = CR2WTypeManager.Create(arr.Elementtype,Convert.ToString(e), this, null);
                            if (element.ChildrEditableVariables.Count > 0)
                            {
                                arr.Add(ReadVariable(br, element));
                            }
                            else
                            {
                                element.Read(br,sizes[i]);
                                arr.Add(element);
                            }
                        }
                        parsedvar = arr;
                    }
                    else if(parsedvar is IREDEnum)
                    {
                        if(((IREDEnum)parsedvar).IsFlag)
                        {
                            var reMs = new MemoryStream();
                            var reBw = new BinaryWriter(reMs);
                            byte len = br.ReadByte();
                            for (byte e = 0; e < len; e++)
                            {
                                reBw.Write(br.ReadUInt16());
                            }
                            reBw.Write(Convert.ToUInt16(0));
                            reMs.Position = 0;
                            parsedvar.Read(new BinaryReader(reMs), ((uint)len + 1) * 2);
                        }
                        else
                        {
                            parsedvar.Read(br, 2);
                        }
                    }
                    else
                    {
                        parsedvar.Read(br, sizes[i]);
                    }
                }
            }
            return parent;
        }
        public int GetStringIndex(string name, bool addnew = false)
        {
            return 0;
        }
        public void Write(BinaryWriter writer)
        {

        }
        struct ObjDesc
        {
            public uint NameIdx;
            public long objDataOffset;
            public ObjDesc(uint varnameIdx, long dataOffset)
            {
                NameIdx = varnameIdx;
                objDataOffset = dataOffset;
            }
        }
        public class Import : ICR2WImport
        {
            private readonly CompiledPackage _package;
            public uint DepotPath { get; private set; }
            public string DepotPathStr => _package.StrTable1asStr[DepotPath];
            public string ClassNameStr { get; private set; } = "NAME NOT FOUND";
            public ushort ClassName { get; private set; } = 0;
            public ushort Flags { get; private set; } = 4;
            public Import(CompiledPackage package,uint idx)
            {
                _package = package;
                DepotPath = idx;
            }
        }
        public class Name : ICR2WName
        {
            private readonly CompiledPackage _package;
            public uint idx { get; private set; }
            public string Str => _package.StrTable2asStr[idx];
            public uint hash { get; private set; } = 0;
            public Name(CompiledPackage package, uint idx)
            {
                _package = package;
                this.idx = idx;
            }
        }
        public class Export : ICR2WExport
        {
            public string REDType { get; }
            public CompiledPackage Package { get; private set; }
            public int ParentChunkIndex { get; }

            public IEditableVariable Data { get; set; }

            [JsonIgnore] public string REDName { get; }
            [JsonIgnore] public int ChunkIndex { get; }

            [JsonIgnore] public IEditableVariable UnknownBytes { get; }

            [JsonIgnore] public ICR2WExport ParentChunk { get; set; }
            [JsonIgnore] public ICR2WExport VirtualParentChunk { get; set; }
            [JsonIgnore] public List<ICR2WExport> ChildrenChunks { get; }
            [JsonIgnore] public List<ICR2WExport> VirtualChildrenChunks { get; }
            [JsonIgnore] public List<IREDChunkPtr> AdReferences { get; }
            [JsonIgnore] public List<IREDChunkPtr> AbReferences { get; }
            [JsonIgnore] public List<string> UnknownTypes { get; }

            public void CreateDefaultData(IEditableVariable cvar = null)
            {
                Data = cvar ?? CR2WTypeManager.Create(REDType, REDType, Package, ParentChunk?.Data as CVariable);

                if (Data is not CVariable cdata)
                {
                    throw new InvalidParsingException($"{nameof(CreateDefaultData)} failed: {this.REDName}");
                }

                Data.IsSerialized = true;
            }
            public string GetFullChunkTypeDependencyString() { return ""; }
            public void MountChunkVirtually(int virtualparentchunkindex, bool force = false) { }
            public void MountChunkVirtually(ICR2WExport virtualparentchunk, bool force = false) { }

            public void ReadData(BinaryReader file)
            { }
            public void WriteData(BinaryWriter file)
            { }
            public Export(CompiledPackage file, string redtype, Export parentchunk, bool cooked = false)
            {
                AdReferences = new List<IREDChunkPtr>();
                AbReferences = new List<IREDChunkPtr>();

                this.Package = file;
                this.REDType = redtype;
                ParentChunk = parentchunk;
            }
        }
        public ICR2WExport CreateChunk(string type, int chunkindex = 0, ICR2WExport parent = null, ICR2WExport virtualparent = null, IEditableVariable cvar = null)
        {
            var chunk = new Export(this, type, parent as Export);
            if (cvar != null)
            {
                chunk.CreateDefaultData();
            }
            else
            {
                chunk.CreateDefaultData(cvar);
            }
            chunk.Data.VarChunkIndex = chunkindex;

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
    }
}
