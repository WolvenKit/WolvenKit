using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using WolvenKit.Common.Model.Cr2w;
using WolvenKit.Interfaces.Core;
using CR2WTypeManager = WolvenKit.RED3.CR2W.Types.CR2WTypeManager;
using CVariable = WolvenKit.RED3.CR2W.Types.CVariable;

[assembly: ContractNamespaceAttribute("", ClrNamespace = "WolvenKit.RED3.CR2W")]

namespace WolvenKit.RED3.CR2W
{
    [DataContract(Namespace = "")]
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

    [DataContract(Namespace = "")]
    public class CR2WExportWrapper : ICR2WExport
    {
        #region Constructors

        /// <summary>
        /// This constructor should be used when manually creating chunks
        /// </summary>
        /// <param name="file"></param>
        /// <param name="redtype"></param>
        /// <param name="parentchunk"></param>
        /// <param name="cooked"></param>
        public CR2WExportWrapper(CR2WFile file, string redtype, ICR2WExport parentchunk, bool cooked = false)
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

        public CR2WExport Export => _export;

        #endregion Properties



        #region Fields

        [NonSerialized] [JsonIgnore] public List<string> UnknownTypes = new();
        [NonSerialized] [JsonIgnore] public CBytes unknownBytes;
        IEditableVariable ICR2WExport.unknownBytes => unknownBytes;

        List<string> ICR2WExport.UnknownTypes => UnknownTypes;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Playing with latin here, ab means toward, ab away from.
        /// This is the directed-graph out-edge list :
        /// CVariables, being CPtr or CHandle, which are referenced by this chunk.
        /// </summary>
        public List<IChunkPtrAccessor> AbReferences { get; }

        /// <summary>
        /// Playing with latin here, ab means toward, ab away from.
        /// This is the directed-graph in-edge list :
        /// CVariables, being CPtr or CHandle, which reference this chunk.
        /// </summary>
        public List<IChunkPtrAccessor> AdReferences { get; }

        public List<ICR2WExport> ChildrenChunks => cr2w.Chunks.Where(_ => _.ParentChunk == this).ToList();
        public int ChunkIndex => cr2w.Chunks.IndexOf(this as ICR2WExport);
        public CR2WFile cr2w { get; }

        public IEditableVariable data { get; private set; }

        public bool IsSerialized => true;

        public ICR2WExport ParentChunk
        {
            get => ParentChunkIndex == -1 ? null : cr2w.Chunks[ParentChunkIndex];
            set => ParentChunkIndex = value == null ? -1 : cr2w.Chunks.IndexOf(value);
        }

        /// <summary>
        /// Main CR2WExport.parentId wrapper
        /// </summary>
        public int ParentChunkIndex
        {
            get => (int)_export.parentID - 1;
            private set => _export.parentID = (uint)(value + 1);
        }

        /// <summary>
        /// This property is used as BindingProperty in frmChunkProperties
        /// Do not delete!
        /// </summary>
        public string Preview
        {
            get
            {
                var vars = data.GetEditableVariables();
                var firstString = vars
                        .OfType<IREDString>()
                        .FirstOrDefault(_ => _.Value != null)
                    ;
                return firstString != null ? firstString.Value : "";
            }
        }

        [DataMember]
        public string REDName => REDType + " #" + (ChunkIndex);

        public string REDType { get; private set; }

        /// <summary>
        /// This property is used as BindingProperty in frmChunkProperties
        /// Do not delete!
        /// </summary>
        public string REDValue => this.ToString();

        public List<ICR2WExport> VirtualChildrenChunks => cr2w.Chunks.Where(_ => _.VirtualParentChunk == this).ToList();
        public ICR2WExport VirtualParentChunk { get; set; }

        public int VirtualParentChunkIndex => cr2w.Chunks.IndexOf(VirtualParentChunk);

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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Needs the parentChunk idx to be set!
        /// </summary>
        public void CreateDefaultData(IEditableVariable cvar = null)
        {
            //if (Export.className != 1 && GetParentChunk() == null)
            //    throw new InvalidChunkTypeException("No parent chunk set!");

            data = cvar ?? CR2WTypeManager.Create(REDType, REDType, cr2w, ParentChunk?.data as CVariable);

            if (data == null || data is not CVariable cdata)
            {
                throw new InvalidParsingException($"{nameof(CreateDefaultData)} failed: {this.REDName}");
            }

            data.IsSerialized = true;
            cdata.SetREDFlags(Export.objectFlags);
        }

        public virtual List<IEditableVariable> GetEditableVariables()
        {
            var vars = new List<IEditableVariable>
            {
                //ParentPtr,
                data
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
            throw new NotImplementedException();
        }

        public void ReadData(BinaryReader file)
        {
            file.BaseStream.Seek(_export.dataOffset, SeekOrigin.Begin);

            CreateDefaultData();

            data.VarChunkIndex = ChunkIndex;

            data.Read(file, _export.dataSize);

            // Unknown bytes
            var bytesLeft = _export.dataSize - (file.BaseStream.Position - _export.dataOffset);
            unknownBytes = new CBytes(cr2w, data as CVariable, "unknownBytes");
            if (bytesLeft > 0)
            {
                unknownBytes.Read(file, (uint)bytesLeft);
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

        public void SetREDName(string val)
        {
            throw new NotImplementedException();
        }

        public void SetType(ushort val) => _export.className = val;

        public override string ToString() => REDName;

        public void Write(BinaryWriter file)
        {
            throw new NotImplementedException();
        }

        public void WriteData(BinaryWriter file)
        {
            _export.dataOffset = (uint)file.BaseStream.Position;
            //_export.className = (ushort)cr2w.GetStringIndex(_type);

            var posstart = file.BaseStream.Position;

            if (data != null)
            {
                data.Write(file);
            }

            // Unknown bytes not as variable because I always want it at the end.
            if (unknownBytes != null)
            {
                unknownBytes.Write(file);
            }

            var newsize = (uint)(file.BaseStream.Position - posstart);
            _export.dataSize = newsize;
        }

        #endregion Methods
    }
}
