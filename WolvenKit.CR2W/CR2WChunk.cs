using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Types;

namespace WolvenKit.CR2W
{
    [Serializable]
    public class CR2WChunk : IEditableVariable
    {
        private readonly CUInt16 flags;
        private readonly CPtr parentPtr;
        public CR2WFile cr2w;
        public uint crc;
        public CVariable data;
        public uint offset;
        public uint size;
        public CName typeName;
        public uint unk4;
        public CBytes unknownBytes;

        public CR2WChunk(CR2WFile cr2w)
        {
            this.cr2w = cr2w;


            parentPtr = new CPtr(cr2w);
            parentPtr.Name = "Parent";

            flags = new CUInt16(cr2w);
            flags.Name = "Flags";

            typeName = new CName(cr2w);
            typeName.Name = "Type";

            Flags = 8192;
        }

        public ushort typeId
        {
            get { return typeName.val; }
            set { typeName.val = value; }
        }

        public ushort Flags
        {
            get { return flags.val; }
            set { flags.val = value; }
        }

        public uint ParentChunkId
        {
            get { return (uint) parentPtr.val; }
            set { parentPtr.val = (int) value; }
        }

        public CR2WChunk Parent
        {
            get
            {
                if (ParentChunkId <= 0)
                    return null;
                return cr2w.chunks[(int) ParentChunkId - 1];
            }
        }

        public int ChunkIndex => cr2w.chunks.IndexOf(this);

        public string Preview
        {
            get
            {
                if (data is CVector)
                {
                    var firstString = ((CVector) data).GetVariableByType("String");
                    if (firstString != null)
                    {
                        return ((CString) firstString).val;
                    }

                    var firstName = ((CVector) data).GetVariableByType("CName");
                    if (firstName != null)
                    {
                        return ((CName) firstName).Value;
                    }
                }

                return "";
            }
        }

        public string Type
        {
            get { return typeName.Value; }
            set { typeName.Value = value; }
        }

        public string Name
        {
            get { return Type + " #" + (ChunkIndex + 1); }
            set { }
        }

        public CR2WFile CR2WOwner => cr2w;

        public virtual Control GetEditor()
        {
            return null;
        }

        public virtual List<IEditableVariable> GetEditableVariables()
        {
            data.Name = Name;

            var vars = new List<IEditableVariable> {flags, parentPtr, typeName, data};
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

            var bytesLeft = size - (file.BaseStream.Position - offset);


            unknownBytes = new CBytes(cr2w)
            {
                Name = "unknownBytes",
                Type = "byte[]"
            };

            if (bytesLeft != 0)
            {
                unknownBytes.Read(file, (uint) bytesLeft);
            }
            else
            {
                unknownBytes.Bytes = new byte[0];
            }
        }

        public void WriteData(BinaryWriter file)
        {
            offset = (uint) file.BaseStream.Position;

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
                chunk.data = (CVector) data.Copy(context);
            }
            if (unknownBytes != null)
            {
                chunk.unknownBytes = (CBytes) unknownBytes.Copy(context);
            }

            return chunk;
        }
    }
}