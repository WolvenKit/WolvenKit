using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.Common.RED4.Compiled
{
    public class CompiledPackage : Red4File
    {
        private readonly IHashService _hashService;
        private const uint RefTableSizeBitShift = 23;
        private const uint RefTableOffsetMask = (1U << (int)RefTableSizeBitShift) - 1U;
        private const uint NamesTableSizeBitShift = 24;
        private const uint NamesTableOffsetMask = (1U << (int)NamesTableSizeBitShift) - 1U;
        private const uint SizeBitMask = (1U << 8) - 1;

        [StructLayout(LayoutKind.Explicit, Size = 36)]
        private struct Header
        {
            [FieldOffset(0)]
            public ushort Uk1;

            [FieldOffset(2)]
            public ushort NumSections;

            [FieldOffset(4)]
            public uint NumCruids0;

            [FieldOffset(8)]
            public uint RefPoolDescOffset;

            [FieldOffset(12)]
            public uint RefPoolDataOffset;

            [FieldOffset(16)]
            public uint NamesPoolDescoffset;

            [FieldOffset(20)]
            public uint NamesPoolDataoffset;

            [FieldOffset(24)]
            public uint ChunkDescOffset;

            [FieldOffset(28)]
            public uint ChunkDataOffset;

            [FieldOffset(32)]
            public ushort Uk2;

            [FieldOffset(34)]
            public ushort NumCruids1;
        }
        private Header _header;
        public List<ulong> EmbeddedCruids { get; private set; }
        private List<uint> RefPoolDescTable { get; set; }
        public Dictionary<uint, string> RefTableasStr { get; private set; }
        public Dictionary<uint, ulong> RefTableasHash { get; private set; }
        private List<uint> NamesPoolDescTable { get; set; }
        public Dictionary<uint, string> NamesTableasStr { get; private set; }

        [StructLayout(LayoutKind.Explicit, Size = 8)]
        private struct ChunkDesc
        {
            [FieldOffset(0)]
            public uint ChunkRedTypeIdx;

            [FieldOffset(4)]
            public uint ChunkDataOffset;
        }
        private List<ChunkDesc> ChunkDescs { get; set; }
        public List<ICR2WBuffer> Buffers { get; private set; }
        [JsonIgnore] public bool CreatePropertyOnAccess { get; set; } = true;
        [JsonIgnore] public bool IsDirty { get; set; }
        [JsonIgnore] public string? FileName { get; set; }
        [JsonIgnore] public List<string> UnknownTypes { get; } = new();
        [JsonIgnore] public List<string> UnknownVars { get; set; } = new();
        [JsonIgnore] public Dictionary<uint, string>? StringDictionary { get; private set; }
        [JsonIgnore] public List<Name> Names { get; private set; }
        [JsonIgnore] public List<Import> Imports { get; private set; }
        public CompiledPackage(IHashService hashservice)
        {
            _hashService = hashservice;

            EmbeddedCruids = new List<ulong>();
            RefPoolDescTable = new List<uint>();
            RefTableasStr = new Dictionary<uint, string>();
            RefTableasHash = new Dictionary<uint, ulong>();
            NamesPoolDescTable = new List<uint>();
            NamesTableasStr = new Dictionary<uint, string>();
            ChunkDescs = new List<ChunkDesc>();

            Names = new List<Name>();
            Imports = new List<Import>();
            Buffers = new List<ICR2WBuffer>();
        }

        public EFileReadErrorCodes Read(BinaryReader br)
        {
            _header = br.BaseStream.ReadStruct<Header>();
            if (_header.RefPoolDescOffset != 0)
            {
                return EFileReadErrorCodes.NoCr2w;
            }

            if (_header.NumCruids0 != _header.NumCruids1)
            {
                return EFileReadErrorCodes.NoCr2w;
            }

            for (var i = 0; i < _header.NumCruids0; i++)
            {
                EmbeddedCruids.Add(br.ReadUInt64());
            }

            var baseOff = br.BaseStream.Position;
            var NumRefPoolDesc = (_header.RefPoolDataOffset - _header.RefPoolDescOffset) / 4;

            for (uint i = 0; i < NumRefPoolDesc; i++)
            {
                br.BaseStream.Seek(baseOff + _header.RefPoolDescOffset + (i * 4), SeekOrigin.Begin);
                var bitmaskData = br.ReadUInt32();
                RefPoolDescTable.Add(bitmaskData);
                var off = bitmaskData & RefTableOffsetMask;
                var len = (bitmaskData >> (int)RefTableSizeBitShift) & SizeBitMask;

                br.BaseStream.Seek(baseOff + off, SeekOrigin.Begin);
                if (_header.Uk2 == 0)
                {
                    var name = new string(br.ReadChars((int)len));
                    RefTableasStr.Add(i, name);
                    RefTableasHash.Add(i, FNV1A64HashAlgorithm.HashString(name));
                }
                else
                {
                    RefTableasHash.Add(i, br.ReadUInt64());
                    RefTableasStr.Add(i, _hashService.Get(RefTableasHash[i]).NotNull());
                }
                Imports.Add(new Import(this, i));
            }

            var NumNamesPoolDesc = (_header.NamesPoolDataoffset - _header.NamesPoolDescoffset) / 4;

            for (uint i = 0; i < NumNamesPoolDesc; i++)
            {
                br.BaseStream.Seek(baseOff + _header.NamesPoolDescoffset + (i * 4), SeekOrigin.Begin);
                var bitmaskData = br.ReadUInt32();
                NamesPoolDescTable.Add(bitmaskData);
                var off = bitmaskData & NamesTableOffsetMask;
                var len = (bitmaskData >> (int)NamesTableSizeBitShift) & SizeBitMask;

                br.BaseStream.Seek(baseOff + off, SeekOrigin.Begin);
                var name = new string(br.ReadChars((int)len - 1));
                NamesTableasStr.Add(i, name);
                Names.Add(new Name(this, i));
            }

            var NumChunksDesc = (_header.ChunkDataOffset - _header.ChunkDescOffset) / 8;

            //throw new WolvenKit.RED4.Types.Exceptions.TodoException();
            for (var i = 0; i < NumChunksDesc; i++)
            {
                br.BaseStream.Seek(baseOff + _header.ChunkDescOffset + (i * 8), SeekOrigin.Begin);
                var chunkDesc = br.BaseStream.ReadStruct<ChunkDesc>();
                ChunkDescs.Add(chunkDesc);

                br.BaseStream.Seek(baseOff + chunkDesc.ChunkDataOffset, SeekOrigin.Begin);
                CreateChunk(Names[(int)chunkDesc.ChunkRedTypeIdx].Str, i).ReadData(br);
            }
            return EFileReadErrorCodes.NoError;
        }
        public string ToJson() => throw new NotImplementedException();//return JsonConvert.SerializeObject(new RedFileDto(this), Formatting.Indented);
        public IRedType ReadVariable(BinaryReader br, IRedType parent) => throw new WolvenKit.RED4.Types.Exceptions.TodoException();//if (parent is DataBuffer buff)//{//    buff.Buffer.Value = (ushort)Buffers.Count;//    var size = br.ReadUInt32();//    var buffWrapper = new CR2WBufferWrapper();//    buffWrapper.DiskSize = size;//    buffWrapper.ReadData(br);//    Buffers.Add(buffWrapper);//}//else if (parent is IRedRef rref)//{//    rref.DepotPath = Imports[br.ReadUInt16()].DepotPathStr;//}//else if (parent is IRedArray arr)//{//    var len = br.ReadUInt32();//    for (uint e = 0; e < len; e++)//    {//        var element = CR2WTypeManager.Create(arr.Elementtype, Convert.ToString(e), this, null);//        arr.Add(ReadVariable(br, element));//        element.ParentVar = arr;//    }//}//else if (parent is IRedEnum enu)//{//    var strings = new List<string>();//    if (enu.IsFlag)//    {//        var len = br.ReadByte();//        for (byte e = 0; e < len; e++)//        {//            strings.Add(Names[br.ReadUInt16()].Str);//        }//    }//    else//    {//        strings.Add(Names[br.ReadUInt16()].Str);//    }//    enu.SetValue(strings);//}//else if (parent is LocalizationString lstr)//{//    lstr.Unk1.Read(br, 8);//    var lslen = br.ReadUInt16();//    var lsVal = System.Text.Encoding.GetEncoding("ISO-8859-1").GetString(br.ReadBytes(lslen));//    lstr.Value.SetValue(lsVal);//}//else if (parent is CColor)//{//    var basePos = br.BaseStream.Position;//    var numChilds = br.ReadUInt16();//    var pos = basePos + 2;//    for (ushort i = 0; i < numChilds; i++)//    {//        br.BaseStream.Position = pos;//        var name = br.ReadUInt16();//        var varname = Names[name].Str;//        var type = br.ReadUInt16();//        var typename = Names[type].Str;//        var off = br.ReadUInt32();//        pos = br.BaseStream.Position;//        var parsedvar = parent.GetPropertyByREDName(varname);//        if (parsedvar == null || parsedvar.REDType != typename)//        {//            throw new MissingRTTIException(varname, typename, parent.REDType);//        }//        br.BaseStream.Position = off + basePos;//        parsedvar = ReadVariable(br, parsedvar);//    }//}//else if (parent.ChildrEditableVariables.Count > 0)//{//    var basePos = br.BaseStream.Position;//    var numChilds = br.ReadUInt16();//    var pos = basePos + 2;//    for (ushort i = 0; i < numChilds; i++)//    {//        br.BaseStream.Position = pos;//        var name = br.ReadUInt16();//        var varname = Names[name].Str;//        var type = br.ReadUInt16();//        var typename = Names[type].Str;//        var off = br.ReadUInt32();//        pos = br.BaseStream.Position;//        var parsedvar = parent.GetPropertyByREDName(varname);//        if (parsedvar == null || parsedvar.REDType != typename)//        {//            throw new MissingRTTIException(varname, typename, parent.REDType);//        }//        br.BaseStream.Position = off + basePos;//        parsedvar = ReadVariable(br, parsedvar);//    }//}//else//{//    parent.Read(br, (uint)(br.BaseStream.Length - br.BaseStream.Position));//}//parent.IsSerialized = true;//return parent;
        public int GetStringIndex(string name, bool addnew = false) => 0;
        public void Write(BinaryWriter writer) => throw new NotImplementedException();
        public Export CreateChunk(string type, int chunkindex = 0, ICR2WExport? parent = null, ICR2WExport? virtualparent = null, IRedType? cvar = null)
        {
            if (parent is not Export e)
            {
                throw new ArgumentException();
            }
            var chunk = new Export(this, type, e)
            {
                ChunkIndex = chunkindex
            };
            if (cvar != null)
            {
                chunk.CreateDefaultData();
            }
            else
            {
                chunk.CreateDefaultData(cvar);
            }
            //chunk.Data.VarChunkIndex = chunkindex;

            if (parent != null)
            {
                chunk.ParentChunk = parent;
            }
            if (virtualparent != null)
            {
                chunk.MountChunkVirtually(virtualparent);
            }

            throw new TodoException("fix everything");
            //Chunks.Insert(chunkindex, chunk);
            //return chunk;
        }
    }
    public class Import : ICR2WImport
    {
        private readonly CompiledPackage _package;
        public uint DepotPathIdx { get; private set; }
        public CName DepotPath => _package.RefTableasStr[DepotPathIdx];
        public string ClassNameStr { get; private set; } = "NAME NOT FOUND";
        public ushort ClassName { get; private set; } = 0;
        public ushort Flags { get; private set; } = 4;

        InternalEnums.EImportFlags IRedImport.Flags => throw new NotImplementedException();

        public Import(CompiledPackage package, uint idx)
        {
            _package = package;
            DepotPathIdx = idx;
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
        // public bool ShouldSerializeData() => Data.IsSerialized == true;
        public string REDType { get; }
        [JsonIgnore] public CompiledPackage Package { get; private set; }
        public int ParentChunkIndex { get; }

        public IRedType? Data { get; set; }

        [JsonIgnore] public string REDName => REDType + " #" + ChunkIndex;
        [JsonIgnore] public int ChunkIndex { get; set; }

        [JsonIgnore] public IRedType? UnknownBytes { get; }

        [JsonIgnore] public ICR2WExport ParentChunk { get; set; }
        [JsonIgnore] public ICR2WExport? VirtualParentChunk { get; set; }
        [JsonIgnore] public List<ICR2WExport>? ChildrenChunks { get; }
        [JsonIgnore] public List<ICR2WExport>? VirtualChildrenChunks { get; }
        //[JsonIgnore] public List<IREDChunkPtr> AdReferences { get; }
        //[JsonIgnore] public List<IREDChunkPtr> AbReferences { get; }
        [JsonIgnore] public List<string>? UnknownTypes { get; }

        public void CreateDefaultData(IRedType? cvar = null) => throw new WolvenKit.RED4.Types.Exceptions.TodoException();//Data = cvar ?? CR2WTypeManager.Create(REDType, REDType, Package, ParentChunk?.Data as CVariable);//if (Data is not CVariable cdata)//{//    throw new InvalidParsingException($"{nameof(CreateDefaultData)} failed: {REDName}");//}//Data.IsSerialized = true;
        public string GetFullChunkTypeDependencyString() => "";
        public void MountChunkVirtually(int virtualparentchunkindex, bool force = false) { }
        public void MountChunkVirtually(ICR2WExport virtualparentchunk, bool force = false) { }

        public void ReadData(BinaryReader br)
        {
            var basePos = br.BaseStream.Position;
            var numChilds = br.ReadUInt16();
            var pos = basePos + 2;
            throw new WolvenKit.RED4.Types.Exceptions.TodoException();
            //for (ushort i = 0; i < numChilds; i++)
            //{
            //    br.BaseStream.Position = pos;
            //    var name = br.ReadUInt16();
            //    var varname = Package.Names[name].Str;
            //    var type = br.ReadUInt16();
            //    var typename = Package.Names[type].Str;
            //    var off = br.ReadUInt32();
            //    pos = br.BaseStream.Position;
            //    var parsedvar = Data.GetPropertyByREDName(varname);
            //    if (parsedvar == null || parsedvar.REDType != typename)
            //    {
            //        throw new MissingRTTIException(varname, typename, Data.REDType);
            //    }
            //    br.BaseStream.Position = off + basePos;
            //    Package.ReadVariable(br, parsedvar);
            //}
        }
        public void WriteData(BinaryWriter file) => throw new NotImplementedException();

        public uint GetOffset() => throw new NotImplementedException();

        public Export(CompiledPackage file, string redtype, Export parentchunk, bool cooked = false)
        {
            //AdReferences = new List<IREDChunkPtr>();
            //AbReferences = new List<IREDChunkPtr>();

            Package = file;
            REDType = redtype;
            ParentChunk = parentchunk;
        }
    }
}
