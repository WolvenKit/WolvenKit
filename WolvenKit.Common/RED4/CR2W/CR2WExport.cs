using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using WolvenKit.RED4.CR2W.Reflection;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Common.Extensions;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Interfaces.Core;
using WolvenKit.Interfaces.Extensions;
using ISerializable = System.Runtime.Serialization.ISerializable;

[assembly: ContractNamespaceAttribute("", ClrNamespace = "WolvenKit.RED4.CR2W")]

namespace WolvenKit.RED4.CR2W
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CR2WExport
    {
        [DataMember]
        [FieldOffset(0)]
        public ushort className;        //needs to be registered upon new creation and updated on file write!   //done

        [DataMember]
        [FieldOffset(2)]
        public ushort objectFlags;      // 0 means uncooked, 8192 is cooked //TODO

        [DataMember]
        [FieldOffset(4)]
        public uint parentID;

        [DataMember]
        [FieldOffset(8)]
        public uint dataSize;           // created upon data write  //done

        [DataMember]
        [FieldOffset(12)]
        public uint dataOffset;         // created upon data write  //done

        [DataMember]
        [FieldOffset(16)]
        public uint template;           // can be 0 //TODO?

        [DataMember]
        [FieldOffset(20)]
        public uint crc32;              // created upon write   //done
    }

    public class CR2WExportWrapper : ICR2WExport
    {
        #region Constructors

        public CR2WExportWrapper()
        {
            _export = new CR2WExport();

            AdReferences = new List<IChunkPtrAccessor>();
            AbReferences = new List<IChunkPtrAccessor>();
        }

        /// <summary>
        /// This constructor should be used when manually creating chunks
        /// </summary>
        /// <param name="file"></param>
        /// <param name="redtype"></param>
        /// <param name="parentchunk"></param>
        /// <param name="cooked"></param>
        public CR2WExportWrapper(CR2WFile file, string redtype, CR2WExportWrapper parentchunk, bool cooked = false)
        {
            _export = new CR2WExport
            {
                objectFlags = (ushort)(cooked ? 8192 : 0),
            };
            AdReferences = new List<IChunkPtrAccessor>();
            AbReferences = new List<IChunkPtrAccessor>();

            this.cr2w = file;
            this.REDType = redtype;
            ParentChunk = parentchunk;
        }

        /// <summary>
        /// This constructor is only used in cr2w parsing = deserialization
        /// </summary>
        /// <param name="export"></param>
        /// <param name="file"></param>
        public CR2WExportWrapper(CR2WExport export, CR2WFile file)
        {
            this.cr2w = file;
            _export = export;

            REDType = cr2w.Names[export.className].Str;
            AdReferences = new List<IChunkPtrAccessor>();
            AbReferences = new List<IChunkPtrAccessor>();
        }

        #endregion Constructors

        #region Fields

        private CR2WExport _export;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Main CR2WExport.parentId wrapper
        /// </summary>
        public int ParentChunkIndex
        {
            get => (int)_export.parentID - 1;
            private set => _export.parentID = (uint)(value + 1);
        }

        public string REDType { get; private set; }

        public IEditableVariable Data { get; private set; }

        [JsonIgnore] public CBytes unknownBytes;

        [JsonIgnore] public List<string> UnknownTypes = new();

        /// <summary>
        /// Playing with latin here, ab means toward, ab away from.
        /// This is the directed-graph out-edge list :
        /// CVariables, being CPtr or CHandle, which are referenced by this chunk.
        /// </summary>
        [JsonIgnore] public List<IChunkPtrAccessor> AbReferences { get; }

        /// <summary>
        /// Playing with latin here, ab means toward, ab away from.
        /// This is the directed-graph in-edge list :
        /// CVariables, being CPtr or CHandle, which reference this chunk.
        /// </summary>
        [JsonIgnore] public List<IChunkPtrAccessor> AdReferences { get; }

        [JsonIgnore] public List<ICR2WExport> ChildrenChunks => cr2w.Chunks.Where(_ => _.ParentChunk == this).ToList();

        [JsonIgnore] public int ChunkIndex => cr2w.Chunks.IndexOf(this);

        [JsonIgnore] public CR2WFile cr2w { get; }

        [JsonIgnore] public CR2WExport Export => _export;

        [JsonIgnore] public bool IsSerialized => true;

        [JsonIgnore]
        public ICR2WExport ParentChunk
        {
            get => ParentChunkIndex == -1 ? null : cr2w.Chunks[ParentChunkIndex];
            set => ParentChunkIndex = value == null ? -1 : cr2w.Chunks.IndexOf(value);
        }

        /// <summary>
        /// This property is used as BindingProperty in frmChunkProperties
        /// Do not delete!
        /// </summary>
        [JsonIgnore] public string Preview
        {
            get
            {
                var vars = Data.GetEditableVariables();
                var firstString = vars
                        .OfType<IREDString>()
                        .FirstOrDefault(_ => _.Value != null)
                    ;
                return firstString is {Value: { }} ? firstString.Value : "";
            }
        }

        [JsonIgnore] public string REDName => REDType + " #" + (ChunkIndex);

        /// <summary>
        /// This property is used as BindingProperty in frmChunkProperties
        /// Do not delete!
        /// </summary>

        [JsonIgnore] public string REDValue => this.ToString();

        [JsonIgnore] IEditableVariable ICR2WExport.UnknownBytes => unknownBytes;

        [JsonIgnore] List<string> ICR2WExport.UnknownTypes => UnknownTypes;

        [JsonIgnore] public List<ICR2WExport> VirtualChildrenChunks => cr2w.Chunks.Where(_ => _.VirtualParentChunk == this).ToList();

        [JsonIgnore] public ICR2WExport VirtualParentChunk { get; set; }

        [JsonIgnore] public int VirtualParentChunkIndex => cr2w.Chunks.IndexOf(VirtualParentChunk);

        #endregion Properties

        #region Methods

        public virtual void AddVariable(CVariable var)
        {
        }

        public virtual bool CanAddVariable(IEditableVariable newvar)
        {
            return false;
        }

        public virtual bool CanRemoveVariable(IEditableVariable child)
        {
            return false;
        }

        public CVariable Copy(CR2WCopyAction context)
        {
            throw new NotImplementedException(nameof(Copy));
        }

        /// <summary>
        /// Needs the parentChunk idx to be set!
        /// </summary>
        public void CreateDefaultData(IEditableVariable cvar = null)
        {
            //if (Export.className != 1 && GetParentChunk() == null)
            //    throw new InvalidChunkTypeException("No parent chunk set!");

            Data = cvar ?? CR2WTypeManager.Create(REDType, REDType, cr2w, ParentChunk?.Data as CVariable);

            if (Data == null || Data is not CVariable cdata)
            {
                throw new InvalidParsingException($"{nameof(CreateDefaultData)} failed: {this.REDName}");
            }

            Data.IsSerialized = true;
            cdata.SetREDFlags(Export.objectFlags);
        }

        public Cr2wVariableDumpObject GetDumpObject(Stream stream)
        {
            stream.Seek(Export.dataOffset, SeekOrigin.Begin);
            using var br = new BinaryReader(stream);
            var o = new Cr2wVariableDumpObject()
            {
                Name = this.REDName,
                Type = this.REDType,
                Size = (int)this.Export.dataSize,
                Offset = br.BaseStream.Position
            };

            var zero = br.ReadByte();
            if (zero != 0)
                return null;

            while (true)
            {
                try
                {
                    var nameId = br.ReadUInt16();
                    if (nameId == 0)
                        break;

                    var variable = new Cr2wVariableDumpObject();
                    variable.Offset = br.BaseStream.Position - 3;

                    var typeId = (int)br.ReadUInt16();
                    variable.Size = br.ReadInt32();

                    var endoffset = br.BaseStream.Position + variable.Size - 4;

                    try
                    {
                        variable.Name = cr2w.StringDictionary.Values.ToList()[(int)nameId];
                        variable.Type = cr2w.StringDictionary.Values.ToList()[typeId];

                        if (variable.Type.Contains("array:"))
                        {
                            var count = br.ReadUInt32();
                            for (int i = 0; i < count; i++)
                            {
                                // dbg for now
                                var elementsize = (variable.Size - 8) / count;
                                if (elementsize > 9)
                                    variable.Variables = TryGetClassVariables((int)elementsize);
                            }
                        }
                        // may be another class:
                        else if (variable.Size > 9)
                        {
                            variable.Variables = TryGetClassVariables(variable.Size);
                        }
                    }
                    catch (Exception)
                    {
                        // TODO: Are we intentionally swallowing this?
                    }

                    // go to variable end
                    br.BaseStream.Seek(endoffset, SeekOrigin.Begin);
                    o.Variables.Add(variable);
                }
                catch (Exception)
                {
                    return o;
                }
            }

            return o;

            List<Cr2wVariableDumpObject> TryGetClassVariables(int innersize)
            {
                var ret = new List<Cr2wVariableDumpObject>();
                var startpos = br.BaseStream.Position;

                var zero = br.ReadByte();
                if (zero != 0)
                    return ret;

                while (true)
                {
                    try
                    {
                        var nameId = br.ReadUInt16();
                        if (nameId == 0)
                            return ret;

                        var variable = new Cr2wVariableDumpObject
                        {
                            Offset = br.BaseStream.Position - 3,
                            Name = cr2w.StringDictionary.Values.ToList()[(int)nameId],
                            Type = cr2w.StringDictionary.Values.ToList()[(int)br.ReadUInt16()],
                            Size = br.ReadInt32()
                        };

                        var endoffset = br.BaseStream.Position + variable.Size - 4;

                        //var buffer = br.ReadBytes(variable.Size - 4);
                        // try read variable
                        //array
                        if (variable.Type.Contains("array:"))
                        {
                            var count = br.ReadUInt32();
                            for (int i = 0; i < count; i++)
                            {
                                variable.Variables = TryGetClassVariables(variable.Size);
                            }
                        }
                        // may be another class:
                        else if (variable.Size > 9)
                        {
                            variable.Variables = TryGetClassVariables(variable.Size);
                        }

                        // go to variable end
                        br.BaseStream.Seek(endoffset, SeekOrigin.Begin);
                        ret.Add(variable);
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
        }

        public virtual List<IEditableVariable> GetEditableVariables()
        {
            var vars = new List<IEditableVariable>
            {
                //ParentPtr,
                Data
            };
            if (unknownBytes != null && unknownBytes.Bytes != null && unknownBytes.Bytes.Length != 0)
            {
                vars.Add(unknownBytes);
            }
            return vars;
        }

        /// <summary>
        /// We can use something like this for hashing
        /// </summary>
        /// <returns></returns>
        public string GetFullChunkTypeDependencyString()
        {
            var depstr = this.REDName;
            var par = this.VirtualParentChunk;
            while (par != null)
            {
                depstr = $"{par.REDName}.{depstr}";
                par = par.VirtualParentChunk;
            }

            return depstr;
        }

        public void MountChunkVirtually(int virtualparentchunkindex, bool force = false)
        {
            if (VirtualParentChunk == null || force)
            {
                VirtualParentChunk = cr2w.Chunks[virtualparentchunkindex];
                //cr2w.Logger.LogString($"Mounted {this.REDName} to {VirtualParentChunk.REDName}.");
            }
        }

        public void MountChunkVirtually(ICR2WExport virtualparentchunk, bool force = false)
        {
            if (VirtualParentChunk == null || force)
            {
                VirtualParentChunk = virtualparentchunk;
            }
        }

        public void Read(BinaryReader file, uint size)
        {
            throw new NotImplementedException(nameof(Read));
        }

        public void ReadData(BinaryReader file)
        {
            file.BaseStream.Seek(_export.dataOffset, SeekOrigin.Begin);

            CreateDefaultData();

            Data.VarChunkIndex = ChunkIndex;

            Data.Read(file, _export.dataSize);

            // Unknown bytes after the normal serialized class
            var bytesLeft = _export.dataSize - (file.BaseStream.Position - _export.dataOffset);
            unknownBytes = new CBytes(cr2w, Data as CVariable, "unknownBytes");
            if (bytesLeft > 0)
            {
                unknownBytes.Read(file, (uint)bytesLeft);
                if (!UnknownTypes.Contains(Data.REDType))
                    UnknownTypes.Add(Data.REDType);
                //UnknownTypes.Add($"Type: {data.REDType}, File: {cr2w.FileName}, Offset: {file.BaseStream.Position}, UnknownBytes: {bytesLeft}");
            }
            else if (bytesLeft < 0)
            {
                //throw new InvalidParsingException("File read too far.");
            }
            else
            {
                unknownBytes.Bytes = new byte[0];
            }
        }

        public virtual bool RemoveVariable(IEditableVariable child)
        {
            return false;
        }

        public void SetOffset(uint offset) => _export.dataOffset = offset;

        public void SetREDName(string val) => throw new NotImplementedException(nameof(SetREDName));

        public void SetType(ushort val) => _export.className = val;

        public override string ToString() => REDName;

        public void Write(BinaryWriter file) => throw new NotImplementedException(nameof(Write));

        public void WriteData(BinaryWriter file)
        {
            _export.dataOffset = (uint)file.BaseStream.Position;
            //_export.className = (ushort)cr2w.GetStringIndex(_type);

            var posstart = file.BaseStream.Position;

            if (Data != null)
            {
                Data.Write(file);
            }

            // Unknown bytes not as variable because I always want it at the end.
            if (unknownBytes != null)
            {
                unknownBytes.Write(file);
            }

            var newsize = (uint)(file.BaseStream.Position - posstart);
            _export.dataSize = newsize;
        }

        public class Cr2wVariableDumpObject
        {
            #region Properties

            public string Name { get; set; }
            public long Offset { get; set; }
            public int Size { get; set; }
            public string Type { get; set; }
            public List<Cr2wVariableDumpObject> Variables { get; set; } = new List<Cr2wVariableDumpObject>();

            #endregion Properties

            #region Methods

            public string ToSimpleString() => $"{Type} {Name}";

            public string ToVarString()
            {
                var wktype = REDReflection.GetWKitBaseTypeFromREDBaseType(Type);
                return $"[RED(\"{Name}\")] public {wktype} {Name.FirstCharToUpper()} {{ get; set; }}";
            }

            #endregion Methods
        }

        #endregion Methods
    }
}
