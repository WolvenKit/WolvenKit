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
using WolvenKit.Common.Conversion;
using WolvenKit.Core.Exceptions;
using WolvenKit.Common.Tools;

namespace WolvenKit.Modkit.RED4.Compiled
{
    public class CompiledPackage : ObservableObject, IRed4EngineFile
    {
        private readonly IHashService _hashService;
        private const UInt32 RefTableSizeBitShift = 23;
        private const UInt32 RefTableOffsetMask = (1U << (int)RefTableSizeBitShift) - 1U;
        private const UInt32 NamesTableSizeBitShift = 24;
        private const UInt32 NamesTableOffsetMask = (1U << (int)NamesTableSizeBitShift) - 1U;
        private const UInt32 SizeBitMask = (1U << 8) - 1;

        [StructLayout(LayoutKind.Explicit, Size = 36)]
        struct Header
        {
            [FieldOffset(0)]
            public UInt16 Uk1;

            [FieldOffset(2)]
            public UInt16 NumSections;

            [FieldOffset(4)]
            public UInt32 NumCruids0;

            [FieldOffset(8)]
            public UInt32 RefPoolDescOffset;

            [FieldOffset(12)]
            public UInt32 RefPoolDataOffset;

            [FieldOffset(16)]
            public UInt32 NamesPoolDescoffset;

            [FieldOffset(20)]
            public UInt32 NamesPoolDataoffset;

            [FieldOffset(24)]
            public UInt32 ChunkDescOffset;

            [FieldOffset(28)]
            public UInt32 ChunkDataOffset;

            [FieldOffset(32)]
            public UInt16 Uk2;

            [FieldOffset(34)]
            public UInt16 NumCruids1;
        }
        private Header _header;
        public List<UInt64> EmbeddedCruids { get; private set; }
        private List<UInt32> RefPoolDescTable { get; set; }
        public Dictionary<uint, string> RefTableasStr { get; private set; }
        public Dictionary<uint, UInt64> RefTableasHash { get; private set; }
        private List<UInt32> NamesPoolDescTable { get; set; }
        public Dictionary<uint, string> NamesTableasStr { get; private set; }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        struct ChunkDesc
        {
            [FieldOffset(0)]
            public UInt32 ChunkRedTypeIdx;

            [FieldOffset(4)]
            public UInt32 ChunkDataOffset;
        }
        private List<ChunkDesc> ChunkDescs { get; set; }
        public List<ICR2WExport> Chunks { get; private set; }
        public List<ICR2WBuffer> Buffers { get; private set; }
        [JsonIgnore] public bool CreatePropertyOnAccess { get; set; } = true;
        [JsonIgnore] public bool IsDirty { get; set; }
        [JsonIgnore] public string FileName { get; set; }
        [JsonIgnore] public List<string> UnknownTypes { get; } = new();
        [JsonIgnore] public List<string> UnknownVars { get; set; } = new();
        [JsonIgnore] public Dictionary<uint, string> StringDictionary { get; private set; }
        [JsonIgnore] public List<ICR2WName> Names { get; private set; }
        [JsonIgnore] public List<ICR2WImport> Imports { get; private set; }
        public CompiledPackage(IHashService hashservice)
        {
            _hashService = hashservice;

            EmbeddedCruids = new List<UInt64>();
            RefPoolDescTable = new List<UInt32>();
            RefTableasStr = new Dictionary<uint, string>();
            RefTableasHash = new Dictionary<uint, UInt64>();
            NamesPoolDescTable = new List<UInt32>();
            NamesTableasStr = new Dictionary<uint, string>();
            ChunkDescs = new List<ChunkDesc>();

            Names = new List<ICR2WName>();
            Imports = new List<ICR2WImport>();
            Chunks = new List<ICR2WExport>();
            Buffers = new List<ICR2WBuffer>();
        }
        public EFileReadErrorCodes Read(BinaryReader br)
        {
            _header = br.BaseStream.ReadStruct<Header>();
            if (_header.RefPoolDescOffset != 0)
                throw new Exception("RefPoolDescOffset != 0");

            if (_header.NumCruids0 != _header.NumCruids1)
                throw new Exception("NumCruids0 != NumCruids1");

            for (int i = 0; i < _header.NumCruids0; i++)
                EmbeddedCruids.Add(br.ReadUInt64());

            long baseOff = br.BaseStream.Position;
            UInt32 NumRefPoolDesc = (_header.RefPoolDataOffset - _header.RefPoolDescOffset) / 4;

            for (uint i = 0; i < NumRefPoolDesc; i++)
            {
                br.BaseStream.Seek(baseOff + _header.RefPoolDescOffset + i * 4, SeekOrigin.Begin);
                UInt32 bitmaskData = br.ReadUInt32();
                RefPoolDescTable.Add(bitmaskData);
                UInt32 off = bitmaskData & RefTableOffsetMask;
                UInt32 len = (bitmaskData >> (int)RefTableSizeBitShift) & SizeBitMask;

                br.BaseStream.Seek(baseOff + off, SeekOrigin.Begin);
                if (_header.Uk2 == 0)
                {
                    string name = new string(br.ReadChars((int)len));
                    RefTableasStr.Add(i, name);
                    RefTableasHash.Add(i, FNV1A64HashAlgorithm.HashString(name));
                }
                else
                {
                    RefTableasHash.Add(i, br.ReadUInt64());
                    RefTableasStr.Add(i, _hashService.Get(RefTableasHash[i]));
                }
                Imports.Add(new Import(this, i));
            }

            UInt32 NumNamesPoolDesc = (_header.NamesPoolDataoffset - _header.NamesPoolDescoffset) / 4;

            for (uint i = 0; i < NumNamesPoolDesc; i++)
            {
                br.BaseStream.Seek(baseOff + _header.NamesPoolDescoffset + i * 4, SeekOrigin.Begin);
                UInt32 bitmaskData = br.ReadUInt32();
                NamesPoolDescTable.Add(bitmaskData);
                UInt32 off = bitmaskData & NamesTableOffsetMask;
                UInt32 len = (bitmaskData >> (int)NamesTableSizeBitShift) & SizeBitMask;

                br.BaseStream.Seek(baseOff + off, SeekOrigin.Begin);
                string name = new string(br.ReadChars((int)len-1));
                NamesTableasStr.Add(i, name);
                Names.Add(new Name(this, i));
            }

            UInt32 NumChunksDesc = (_header.ChunkDataOffset - _header.ChunkDescOffset) / 8;

            for (int i = 0; i < NumChunksDesc; i++)
            {
                br.BaseStream.Seek(baseOff + _header.ChunkDescOffset + i * 8, SeekOrigin.Begin);
                var chunkDesc = br.BaseStream.ReadStruct<ChunkDesc>();
                ChunkDescs.Add(chunkDesc);

                br.BaseStream.Seek(baseOff + chunkDesc.ChunkDataOffset, SeekOrigin.Begin);
                CreateChunk(Names[(int)chunkDesc.ChunkRedTypeIdx].Str, i).ReadData(br);
            }
            return EFileReadErrorCodes.NoError;
        }
        public string ToJson()
        {
            return JsonConvert.SerializeObject(new RedFileDto(this),Formatting.Indented);
        }
        public IEditableVariable ReadVariable(BinaryReader br, IEditableVariable parent)
        {
            if(parent is DataBuffer buff)
            {
                buff.Buffer.Value = (ushort)Buffers.Count;
                uint size = br.ReadUInt32();
                CR2WBufferWrapper buffWrapper = new CR2WBufferWrapper();
                buffWrapper.DiskSize = size;
                buffWrapper.ReadData(br);
                Buffers.Add(buffWrapper);
            }
            else if(parent is IREDRef rref)
            {
                rref.DepotPath = Imports[br.ReadUInt16()].DepotPathStr;
            }
            else if (parent is IREDArray arr)
            {
                uint len = br.ReadUInt32();
                for (uint e = 0; e < len; e++)
                {
                    var element = CR2WTypeManager.Create(arr.Elementtype, Convert.ToString(e), this, null);
                    arr.Add(ReadVariable(br, element));
                    element.ParentVar = arr;
                }
            }
            else if (parent is IREDEnum enu)
            {
                List<string> strings = new List<string>();
                if (enu.IsFlag)
                {
                    byte len = br.ReadByte();
                    for (byte e = 0; e < len; e++)
                    {
                        strings.Add(Names[br.ReadUInt16()].Str);
                    }
                }
                else
                {
                    strings.Add(Names[br.ReadUInt16()].Str);
                }
                enu.SetValue(strings);
            }
            else if(parent is LocalizationString lstr)
            {
                lstr.Unk1.Read(br, 8);
                var lslen = br.ReadUInt16();
                var lsVal = System.Text.Encoding.GetEncoding("ISO-8859-1").GetString(br.ReadBytes(lslen));
                lstr.Value.SetValue(lsVal);
            }
            else if (parent.ChildrEditableVariables.Count > 0)
            {
                long basePos = br.BaseStream.Position;
                ushort numChilds = br.ReadUInt16();
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
                    parsedvar = ReadVariable(br, parsedvar);
                }
            }
            else
            {
                parent.Read(br, (uint)(br.BaseStream.Length - br.BaseStream.Position));
            }
            parent.IsSerialized = true;
            return parent;
        }
        public int GetStringIndex(string name, bool addnew = false)
        {
            return 0;
        }
        public void Write(BinaryWriter writer)
        {

        }
        public ICR2WExport CreateChunk(string type, int chunkindex = 0, ICR2WExport parent = null, ICR2WExport virtualparent = null, IEditableVariable cvar = null)
        {
            var chunk = new Export(this, type, parent as Export);
            chunk.ChunkIndex = chunkindex;
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
    public class Import : ICR2WImport
    {
        private readonly CompiledPackage _package;
        public uint DepotPath { get; private set; }
        public string DepotPathStr => _package.RefTableasStr[DepotPath];
        public string ClassNameStr { get; private set; } = "NAME NOT FOUND";
        public ushort ClassName { get; private set; } = 0;
        public ushort Flags { get; private set; } = 4;
        public Import(CompiledPackage package, uint idx)
        {
            _package = package;
            DepotPath = idx;
        }
    }
    public class Name : ICR2WName
    {
        private readonly CompiledPackage _package;
        public uint idx { get; private set; }
        public string Str => _package.NamesTableasStr[idx];
        public uint hash { get; private set; } = 0;
        public Name(CompiledPackage package, uint idx)
        {
            _package = package;
            this.idx = idx;
        }
    }
    public class Export : ICR2WExport
    {
        public bool ShouldSerializeData() => (Data.IsSerialized == true);
        public string REDType { get; }
        [JsonIgnore] public CompiledPackage Package { get; private set; }
        public int ParentChunkIndex { get; }

        public IEditableVariable Data { get; set; }

        [JsonIgnore] public string REDName { get; }
        [JsonIgnore] public int ChunkIndex { get; set; }

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

        public void ReadData(BinaryReader br)
        {
            long basePos = br.BaseStream.Position;
            ushort numChilds = br.ReadUInt16();
            long pos = basePos + 2;
            for (ushort i = 0; i < numChilds; i++)
            {
                br.BaseStream.Position = pos;
                ushort name = br.ReadUInt16();
                string varname = Package.Names[name].Str;
                ushort type = br.ReadUInt16();
                string typename = Package.Names[type].Str;
                uint off = br.ReadUInt32();
                pos = br.BaseStream.Position;
                var parsedvar = Data.GetPropertyByREDName(varname);
                if (parsedvar == null || parsedvar.REDType != typename)
                {
                    throw new MissingRTTIException(varname, typename, Data.REDType);
                }
                br.BaseStream.Position = off + basePos;
                Package.ReadVariable(br, parsedvar);
            }
        }
        public void WriteData(BinaryWriter file)
        { }

        public uint GetOffset() => throw new NotImplementedException();

        public Export(CompiledPackage file, string redtype, Export parentchunk, bool cooked = false)
        {
            AdReferences = new List<IREDChunkPtr>();
            AbReferences = new List<IREDChunkPtr>();

            this.Package = file;
            this.REDType = redtype;
            ParentChunk = parentchunk;
        }
    }
}
