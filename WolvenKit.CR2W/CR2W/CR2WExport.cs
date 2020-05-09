//using RED.CRC32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Types;
using System.Runtime.InteropServices;
//using System.Linq;
using System.Runtime.Serialization;
using System.Xml;
using WolvenKit.Utils;

[assembly: ContractNamespaceAttribute("",    ClrNamespace = "WolvenKit.CR2W")]

namespace WolvenKit.CR2W
{

    [DataContract(Namespace ="")]
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public struct CR2WExport
    {
        [DataMember]
        [FieldOffset(0)]
        public ushort className;    //needs to be registered upon new creation!

        [DataMember]
        [FieldOffset(2)]
        public ushort objectFlags;  // can be 0

        [DataMember]
        [FieldOffset(4)]
        public uint parentID;   //0 means no parent, 1 is chunkID 0

        [DataMember]
        [FieldOffset(8)]
        public uint dataSize;   // created upon data write

        [DataMember]
        [FieldOffset(12)]
        public uint dataOffset; //created upon data write

        [DataMember]
        [FieldOffset(16)]
        public uint template;   // can be 0

        [DataMember]
        [FieldOffset(20)]
        public uint crc32;  // created upon write
    }

    [DataContract(Namespace = "")]
    public class CR2WExportWrapper : IEditableVariable
    {

        #region  Constructors
        public CR2WExportWrapper(CR2WFile file)
        {
            this.cr2w = file;
            _export = new CR2WExport
            {
                objectFlags = 8192,
            };
        }
        public CR2WExportWrapper(CR2WExport export, CR2WFile file)
        {
            this.cr2w = file;
            _export = export;

            Type = cr2w.names[export.className].Str;
        }
        #endregion

        private CR2WExport _export;
        [DataMember()]
        public CR2WExport Export
        {
            get => _export;
        }

        #region Fields
        [NonSerialized]
        public CR2WFile cr2w;

        [NonSerialized]
        public CBytes unknownBytes;
        #endregion

        #region Properties
        public CVariable data { get; set; }

        // editable variables
        private CPtr _parentPtr;
        public CPtr ParentPtr
        {
            get
            {
                return _parentPtr;
            }
            set
            {
                _parentPtr = value;

                // this is unneccessary, handled in frmChunkProperties:treeView_CellEditFinished
                if (_parentPtr.Reference == null)
                {
                    _export.parentID = (uint)0;
                }
                else
                    _export.parentID = (uint)_parentPtr.Reference.ChunkIndex + 1;
            }
        }
        public uint ParentChunkId => this.Export.parentID;

        private string _type;
        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;

                _export.className = (ushort)cr2w.GetStringIndex(_type);
            }
        }


        [DataMember]
        public string Name
        {
            get { return Type + " #" + (ChunkIndex); }
            set { }
        }

        /// <summary>
        /// Deprecated
        /// </summary>
        public CR2WFile CR2WOwner => cr2w;
        public int ChunkIndex => cr2w.chunks.IndexOf(this);
        public string Preview
        {
            get
            {
                if (data is CVector)
                {
                    var firstString = ((CVector)data).GetVariableByType("String");
                    if (firstString != null)
                    {
                        return ((CString)firstString).val;
                    }

                    var firstName = ((CVector)data).GetVariableByType("CName");
                    if (firstName != null)
                    {
                        return ((CName)firstName).Value;
                    }
                }

                return "";
            }
        }
        #endregion

        #region Methods
        public void SetType(ushort val) => _export.className = val;
        public void SetParentChunkId(uint val) => _export.parentID = val;
        public void SetParent(CR2WExportWrapper parent)
        {
            ParentPtr.Reference = parent;
            SetParentChunkId((uint)ParentPtr.Reference.ChunkIndex + 1);
        }
        public void SetOffset(uint offset) => _export.dataOffset = offset;


        public CVariable CreateDefaultVariable()
        {
            throw new NotImplementedException();
        }

        public CR2WExportWrapper GetParent()
        {
            try
            {
                return cr2w.chunks[(int)ParentChunkId - 1];
            }
            catch (Exception)
            {
                return null;
            }

        }
        
        public virtual Control GetEditor()
        {
            return null;
        }

        public virtual List<IEditableVariable> GetEditableVariables()
        {
            data.Name = Name;

            var vars = new List<IEditableVariable>
            {
                ParentPtr,
                data
            };
            if (unknownBytes != null)
            {
                vars.Add(unknownBytes);
            }
            return vars;
        }

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

        public virtual void RemoveVariable(IEditableVariable child)
        {
        }

        public void ReadData(BinaryReader file)
        {
            file.BaseStream.Seek(_export.dataOffset, SeekOrigin.Begin);

            CreateDefaultData();

            data.Read(file, _export.dataSize);
            var bytesLeft = _export.dataSize - (file.BaseStream.Position - _export.dataOffset);

            unknownBytes = new CBytes(cr2w)
            {
                Name = "unknownBytes",
                Type = "byte[]"
            };

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
            _export.className = (ushort)cr2w.GetStringIndex(_type);

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
            if (_export.dataSize != newsize)
            {
                _export.dataSize = newsize;
            }
        }

        public void CreateDefaultData()
        {
            data = CR2WTypeManager.Get().GetByName(Type, "", cr2w, false);
            if (data == null)
            {
                // default chunks to vector type
                data = new CVector(cr2w);
            }
            //data.Name = Name;
            data.Type = Type;
            if (ParentChunkId != 0)
                data.ParentVariable = GetParent().data;

            ParentPtr = new CPtr(cr2w)
            {
                Name = "Parent",
                Reference = GetParent()
            };
        }

        public CR2WExportWrapper Copy(CR2WCopyAction context)
        {
            // this one was already copied
            if (context.chunkTranslation.ContainsKey(ChunkIndex))
                return null;


            var copy = context.DestinationFile.CreateChunk(Type);

            context.chunks.Add(copy);
            context.chunkTranslation.Add(ChunkIndex, copy.ChunkIndex);

            copy.Type = Type;
            copy._export.template = _export.template;
            copy._export.crc32 = _export.crc32;

            // requires updating from context.chunkTranslation once all chunks are copied.
            //copy.ParentChunkId = ParentChunkId;
            copy._export.parentID = _export.parentID;

            if (data != null)
            {
                copy.data = (CVector) data.Copy(context);
            }
            if (unknownBytes != null)
            {
                copy.unknownBytes = (CBytes) unknownBytes.Copy(context);
            }

            return copy;
        }

        public void SerializeToXml(XmlWriter xw)
        {
            XmlSerializer.SerializeStartObject<CR2WExportWrapper>(xw, this);
            XmlSerializer.SerializeObjectContent<CR2WExportWrapper>(xw, this);
            data.SerializeToXml(xw);
            unknownBytes.SerializeToXml(xw);
            XmlSerializer.SerializeEndObject<CR2WExportWrapper>(xw);
        }

        public override string ToString()
        {
            return Name;
        }
        #endregion
    }
}