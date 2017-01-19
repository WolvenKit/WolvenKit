using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using W3Edit.CR2W.Editors;
using W3Edit.CR2W.Types;

namespace W3Edit.CR2W
{
    [Serializable]
    public class CR2WChunk : IEditableVariable
    {
        public CName typeName;

        public UInt16 typeId
        {
            get
            {
                return typeName.val;
            }
            set
            {
                typeName.val = value;
            }
        }

        public string Type { 
            get { return typeName.Value; }
            set { typeName.Value = value; }
        }

        public string Name
        {
            get
            {
                return Type + " #" + (ChunkIndex+1);
            }
            set
            {
            }
        }

        private CUInt16 flags;

        public UInt16 Flags
        {
            get { return flags.val; }
            set { flags.val = value; }
        }

        

        public UInt32 ParentChunkId
        {
            get { return (UInt32)parentPtr.val; }
            set { parentPtr.val = (int)value; }
        }

        private CPtr parentPtr;

        public UInt32 size;
        public UInt32 offset;
        public UInt32 unk4;
        public UInt32 crc;

        public CVariable data;
        public CBytes unknownBytes;

        public CR2WFile cr2w;
        public CR2WFile CR2WOwner
        {
            get { return cr2w; }
        }

        public CR2WChunk Parent {
            get {
                if (ParentChunkId <= 0)
                    return null;
                return cr2w.chunks[(int)ParentChunkId-1]; 
            }
        }



        public int ChunkIndex
        {
            get
            {
                return cr2w.chunks.IndexOf(this);
            }
        }

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

        public CR2WChunk(CR2WFile cr2w)
        {
            this.cr2w = cr2w;


            parentPtr = new CPtr(cr2w);
            parentPtr.Name = "Parent";

            flags = new CUInt16(cr2w);
            flags.Name = "Flags";

            typeName = new CName(cr2w);
            typeName.Name = "Type";

            this.Flags = 8192;
        }

        public void Read(BinaryReader file)
        {
            Flags = file.ReadUInt16();
            ParentChunkId = file.ReadUInt32();
            size = file.ReadUInt32();
            offset = file.ReadUInt32();
            unk4 = file.ReadUInt32();
            crc = file.ReadUInt32();
        }

        public void ReadData(BinaryReader file)
        {
            file.BaseStream.Seek(offset, SeekOrigin.Begin);

            CreateDefaultData();
            data.Read(file, size);

            var bytesLeft = (long)size - (file.BaseStream.Position - (long)offset);


            unknownBytes = new CBytes(cr2w);
            unknownBytes.Name = "unknownBytes";
            unknownBytes.Type = "byte[]";

            if (bytesLeft != 0)
            {
                unknownBytes.Read(file, (UInt32)bytesLeft);
            }
            else
            {
                unknownBytes.Bytes = new byte[0];
            }
        }

        public void WriteData(BinaryWriter file)
        {
            offset = (UInt32)file.BaseStream.Position;

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

            var newsize = (UInt32)(file.BaseStream.Position - posstart);
            if (size != newsize)
            {
                size = newsize;
            }
        }

        public void Write(BinaryWriter file)
        {
            file.Write(typeId);
            file.Write(Flags);
            file.Write(ParentChunkId);
            file.Write(size);
            file.Write(offset);
            file.Write(unk4);
            file.Write(crc);
        }

        public void CreateDefaultData()
        {
            data = CR2WTypeManager.Get().GetByName(Type, "", cr2w, false);
            if (data == null)
            {
                // default chunks to vector type
                data = new CVector(cr2w);
            }
            data.Name = Name;
        }

        public CR2WChunk Copy(CR2WCopyAction context)
        {
            // this one was already copied
            if (context.chunkTranslation.ContainsKey(ChunkIndex))
                return null;
            

            var chunk = context.DestinationFile.CreateChunk(Type);

            context.chunks.Add(chunk);
            context.chunkTranslation.Add(ChunkIndex, chunk.ChunkIndex);

            chunk.Type = Type;
            chunk.Flags = Flags;
            chunk.unk4 = unk4;
            chunk.crc = crc;

            // requires updating from context.chunkTranslation once all chunks are copied.
            chunk.ParentChunkId = ParentChunkId;

            if (data != null)
            {
                chunk.data = (CVector)data.Copy(context);
            }
            if (unknownBytes != null)
            {
                chunk.unknownBytes = (CBytes)unknownBytes.Copy(context);
            }

            return chunk;
        }



        public virtual System.Windows.Forms.Control GetEditor()
        {
            return null;
        }

        public virtual List<IEditableVariable> GetEditableVariables()
        {
            data.Name = Name;

            var vars = new List<IEditableVariable>();
            vars.Add(flags);
            vars.Add(parentPtr);
            vars.Add(typeName);
            vars.Add(data);
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
    }
}
