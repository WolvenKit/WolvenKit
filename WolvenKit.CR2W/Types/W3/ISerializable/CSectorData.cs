using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    class CSectorData : CVariable
    {
        public CUInt32 Unknown1;
        public CUInt32 Unknown2;

        public CBufferVLQ<CSectorDataResource> Resources;
        public CBufferVLQ<CSectorDataObject> Objects;

        public CVLQInt32 blocksize;
        public CCompressedBuffer<CBytes> BlockData;

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

            BlockData = new CCompressedBuffer<CBytes>(cr2w, _ => new CBytes(_))
            {
                Name = "blockData",
            };
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
                var b = new CBytes(cr2w);
                CSectorDataObject curobj = (CSectorDataObject)Objects.GetEditableVariables()[i];

                ulong curoffset = curobj.offset.val;
                byte type = curobj.type.val;
                if (!(type == 0x1 || type == 0x2))
                {
                    System.Diagnostics.Debugger.Break();
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
                b.Read(file, (uint)len);
                BlockData.AddVariable(b);
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
            return null;
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }
    }

    public class CSectorDataResource : CVariable
    {
        public CFloat box0;
        public CFloat box1;
        public CFloat box2;
        public CFloat box3;
        public CFloat box4;
        public CFloat box5;
        public CUInt64 patchHash;

        public CSectorDataResource(CR2WFile cr2w)
            : base(cr2w)
        {
            box0 = new CFloat(cr2w) { Name = "box0", Type = "Float" };
            box1 = new CFloat(cr2w) { Name = "box1", Type = "Float" };
            box2 = new CFloat(cr2w) { Name = "box2", Type = "Float" };
            box3 = new CFloat(cr2w) { Name = "box3", Type = "Float" };
            box4 = new CFloat(cr2w) { Name = "box4", Type = "Float" };
            box5 = new CFloat(cr2w) { Name = "box5", Type = "Float" };
            patchHash = new CUInt64(cr2w) { Name = "patchHash", Type = "UInt64" };
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CSectorDataResource(cr2w);
        }

        public override void Read(BinaryReader file, uint size)
        {
            box0.Read(file, 4);
            box1.Read(file, 4);
            box2.Read(file, 4);
            box3.Read(file, 4);
            box4.Read(file, 4);
            box5.Read(file, 4);
            patchHash.Read(file, 8);
        }

        public override void Write(BinaryWriter file)
        {
            box0.Write(file);
            box1.Write(file);
            box2.Write(file);
            box3.Write(file);
            box4.Write(file);
            box5.Write(file);
            patchHash.Write(file);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                box0,
                box1,
                box2,
                box3,
                box4,
                box5,
                patchHash,
            };
        }

        public override string ToString()
        {
            return null;
        }
    }

    public class CSectorDataObject : CVariable
    {
        public CUInt8 type;
        public CUInt8 flags;
        public CUInt16 radius;
        public CUInt64 offset;
        public CFloat positionX;
        public CFloat positionY;
        public CFloat positionZ;

        public CSectorDataObject(CR2WFile cr2w)
            : base(cr2w)
        {
            type = new CUInt8(cr2w) { Name = "type", Type = "UInt8" };
            flags = new CUInt8(cr2w) { Name = "flags", Type = "UInt8" };
            radius = new CUInt16(cr2w) { Name = "radius", Type = "UInt16" };
            offset = new CUInt64(cr2w) { Name = "offset", Type = "UInt64" };
            positionX = new CFloat(cr2w) { Name = "positionX", Type = "Float" };
            positionY = new CFloat(cr2w) { Name = "positionY", Type = "Float" };
            positionZ = new CFloat(cr2w) { Name = "positionZ", Type = "Float" };
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CSectorDataObject(cr2w);
        }

        public override void Read(BinaryReader file, uint size)
        {
            type.Read(file, 1);
            flags.Read(file, 1);
            radius.Read(file, 2);
            offset.Read(file, 8);
            positionX.Read(file, 4);
            positionY.Read(file, 4);
            positionZ.Read(file, 4);
        }

        public override void Write(BinaryWriter file)
        {
            type.Write(file);
            flags.Write(file);
            radius.Write(file);
            offset.Write(file);
            positionX.Write(file);
            positionY.Write(file);
            positionZ.Write(file);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>()
            {
                type,
                flags,
                radius,
                offset,
                positionX,
                positionY,
                positionZ,
            };
        }

        public override string ToString()
        {
            return null;
        }
    }
}