using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Types;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml;
using WolvenKit.Utils;
using System.Linq;
using System.IO.MemoryMappedFiles;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;
using WolvenKit.Common.Model.Cr2w;

[assembly: ContractNamespaceAttribute("",    ClrNamespace = "WolvenKit.CR2W")]

namespace WolvenKit.CR2W
{

    [DataContract(Namespace ="")]
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
        // 0 means no parent, 1 is chunkID 0
        // CDPR had the horrendous idea to put an uint here.
        // So parentID really is [1;n], with 0 to denote a null parent...
        // ... when it could have been the usual int [0;n], with -1 for null parent.
        // We will thus touch this stupidity as little as possible, and rather interact with the wrapper
        // CR2WExportWrapper.ParentChunkIndex.
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

        #region  Constructors
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
        #endregion

        private CR2WExport _export;
        public CR2WExport Export => _export;

        #region Fields

        IEditableVariable ICR2WExport.unknownBytes => unknownBytes;

        List<string> ICR2WExport.UnknownTypes => UnknownTypes;

        [NonSerialized] [JsonIgnore] public CBytes unknownBytes;

        [NonSerialized] [JsonIgnore] public List<string> UnknownTypes = new();
        #endregion

        #region Properties
        public CR2WFile cr2w { get; }

        public IEditableVariable data { get; private set; }

        /// <summary>
        /// Main CR2WExport.parentId wrapper
        /// </summary>
        public int ParentChunkIndex
        {
            get => (int)_export.parentID - 1;
            private set => _export.parentID = (uint)(value + 1);
        }

        public ICR2WExport ParentChunk
        {
            get => ParentChunkIndex == -1 ? null : cr2w.Chunks[ParentChunkIndex];
            set => ParentChunkIndex = value == null ? -1 : cr2w.Chunks.IndexOf(value);
        }

        public ICR2WExport VirtualParentChunk { get; set; }

        public int VirtualParentChunkIndex => cr2w.Chunks.IndexOf(VirtualParentChunk);

        public List<ICR2WExport> ChildrenChunks => cr2w.Chunks.Where(_ => _.ParentChunk == this).ToList();

        public List<ICR2WExport> VirtualChildrenChunks => cr2w.Chunks.Where(_ => _.VirtualParentChunk == this).ToList();

        /// <summary>
        /// Playing with latin here, ab means toward, ab away from.
        /// This is the directed-graph in-edge list :
        /// CVariables, being CPtr or CHandle, which reference this chunk.
        /// </summary>
        public List<IChunkPtrAccessor> AdReferences { get; }

        /// <summary>
        /// Playing with latin here, ab means toward, ab away from.
        /// This is the directed-graph out-edge list :
        /// CVariables, being CPtr or CHandle, which are referenced by this chunk.
        /// </summary>
        public List<IChunkPtrAccessor> AbReferences { get; }

        public string REDType { get; private set; }


        [DataMember]
        public string REDName => REDType + " #" + (ChunkIndex);

        public int ChunkIndex => cr2w.Chunks.IndexOf(this as ICR2WExport);

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
                        .Where(_ => _ is CString)
                        .Cast<CString>()
                        .FirstOrDefault(_ => _.val != null)
                    ;
                if (firstString != null)
                {
                    return firstString.val;
                }

                var firstName = vars
                        .Where(_ => (_ is CName))
                        .Cast<CName>()
                        .FirstOrDefault(_ => _.Value != null)
                    ;
                return firstName != null ? firstName.Value : "";
            }
        }


        /// <summary>
        /// This property is used as BindingProperty in frmChunkProperties
        /// Do not delete!
        /// </summary>
        public string REDValue => this.ToString();


        public bool IsSerialized => true;

        #endregion

        #region Methods
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

        public void SetType(ushort val) => _export.className = val;

        public void SetOffset(uint offset) => _export.dataOffset = offset;

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
                unknownBytes.Read(file, (uint) bytesLeft);
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

        public void WriteData(BinaryWriter file)
        {
            _export.dataOffset = (uint) file.BaseStream.Position;
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

            var newsize = (uint) (file.BaseStream.Position - posstart);
            _export.dataSize = newsize;
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

        public override string ToString() => REDName;

        public virtual bool CanRemoveVariable(IEditableVariable child)
        {
            return false;
        }

        public virtual bool CanAddVariable(IEditableVariable newvar)
        {
            return false;
        }

        public virtual void AddVariable(CVariable var)
        {
        }

        public virtual bool RemoveVariable(IEditableVariable child)
        {
            return false;
        }

        public void SetREDName(string val)
        {
            throw new NotImplementedException();
        }

        public void Read(BinaryReader file, uint size)
        {
            throw new NotImplementedException();
        }

        public void Write(BinaryWriter file)
        {
            throw new NotImplementedException();
        }

        public CVariable Copy(CR2WCopyAction context)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
