using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    class CSectorData : CVariable
    {
        public CUInt32 Unknown1;
        public CUInt32 Unknown2;

        public CBufferVLQ<CSectorDataResource> Resources;
        public CBufferVLQ<CSectorDataObject> Objects;

        public CVLQInt32 blocksize;
        public CCompressedBuffer<SBlockData> BlockData;

        public CSectorData(CR2WFile cr2w)
            : base(cr2w)
        {
            Unknown1 = new CUInt32(cr2w)
            {
                Name = "unknown1",
            };
            Unknown2 = new CUInt32(cr2w)
            {
                Name = "unknown2",
            };
            blocksize = new CVLQInt32(cr2w)
            {
                Name = "blocksize",
            };

            Resources = new CBufferVLQ<CSectorDataResource>(cr2w, _ => new CSectorDataResource(_)) { Name = "resources", };
            Objects = new CBufferVLQ<CSectorDataObject>(cr2w, _ => new CSectorDataObject(_)) { Name = "objects", };

            BlockData = new CCompressedBuffer<SBlockData>(cr2w, _ => new SBlockData(_)) { Name = "blockData", };
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CSectorData(cr2w);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                Unknown1,
                Unknown2,
                Resources,
                Objects,
                BlockData
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            //Read the 8 unknown bytes.
            Unknown1.Read(file, 4);
            Unknown2.Read(file, 4);

            Resources.Read(file, 0);
            Objects.Read(file, 0);

            // Read the data block.
            blocksize.Read(file, 0);

            for (int i = 0; i < Objects.elements.Count; i++)
            {
                
                CSectorDataObject curobj = (CSectorDataObject)Objects.GetEditableVariables()[i];

                ulong curoffset = curobj.offset.val;
                byte type = curobj.type.val;
                if (!(type == 0x1 || type == 0x2))
                {
                    //System.Diagnostics.Debugger.Break();
                    //throw new NotImplementedException();
                }

                ulong len;
                if (i < Objects.elements.Count - 1)
                {
                    CSectorDataObject nextobj = (CSectorDataObject)Objects.GetEditableVariables()[i + 1];
                    ulong nextoffset = nextobj.offset.val;
                    len = nextoffset - curoffset;
                }
                else
                {
                    len = (ulong)blocksize.val - curoffset;
                }
                var blockdata = new SBlockData(cr2w);
                blockdata.Read(file, (uint)len);
                BlockData.AddVariable(blockdata);
            }
        }

        public override void Write(BinaryWriter file)
        {
            //Write the 8 unknown bytes.
            Unknown1.Write(file);
            Unknown2.Write(file);

            Resources.Write(file);
            Objects.Write(file);

            byte[] buffer;
            using (var ms = new MemoryStream())
            using (var bw = new BinaryWriter(ms))
            {
                BlockData.Write(bw);
                blocksize.val = (int)ms.Length;
                buffer = ms.ToArray();
            }

            blocksize.Write(file);
            file.Write(buffer);
        }

        public override string ToString()
        {
            return "";
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }
    }
    
}