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
        public CVector Resources;
        public CVector Objects;
        public CByteArray BlockData;

        public CSectorData(CR2WFile cr2w)
            : base(cr2w)
        {
            Unknown1 = new CUInt32(cr2w)
            {
                Name = "unknown1",
                Type = "UInt32"
            };
            Unknown2 = new CUInt32(cr2w)
            {
                Name = "unknown2",
                Type = "UInt32"
            };
            Resources = new CVector(cr2w)
            {
                Name = "resources",
                Type = "CSectorDataResource[]"
            };
            Objects = new CVector(cr2w)
            {
                Name = "objects",
                Type = "CSectorDataObject[]"
            };
            BlockData = new CByteArray(cr2w)
            {
                Name = "blockData",
                Type = "byte[]"
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
                //BlockData
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            //Read the 8 unknown bytes.
            Unknown1.Read(file, 4);
            Unknown2.Read(file, 4);

            //Read the resources list.
            var numresources = file.ReadVLQInt32();
            for (int i = 0; i < numresources; i++)
            {
                var temp = new CSectorDataResource(cr2w);
                temp.Read(file, 24);
                Resources.AddVariable(temp);
            }

            //Read the Objects list.
            var numobjects = file.ReadVLQInt32();
            for (int i = 0; i < numobjects; i++)
            {
                var temp = new CSectorDataObject(cr2w);
                temp.Read(file, 32);
                Objects.AddVariable(temp);
            }

            // Read the data block.
            var datasize = file.ReadVLQInt32();
            BlockData.Bytes = file.ReadBytes(datasize);

            // add blockdata per object instead of in the end of the file
            // we do it after we read the array for easier writing
            for (int i = 0; i < numobjects; i++)
            {
                CSectorDataObject curobj = (CSectorDataObject)Objects.GetEditableVariables()[i];
                int curoffset = int.Parse(curobj.offset.ToString());
                int nextoffset = datasize;
                if (i != numobjects - 1)
                {
                    CSectorDataObject nextobj = (CSectorDataObject)Objects.GetEditableVariables()[i + 1];
                    nextoffset = int.Parse(nextobj.offset.ToString());
                }
                int length = nextoffset - curoffset;

                byte[] cutoutdata = new byte[length];
                Array.Copy(BlockData.Bytes, curoffset, cutoutdata, 0, length);

                curobj.blockdata.Bytes = cutoutdata;
            }




        }

        public override void Write(BinaryWriter file)
        {
            //Write the 8 unknown bytes.
            Unknown1.Write(file);
            Unknown2.Write(file);

            //Write the resources
            file.WriteVLQInt32(Resources.variables.Count);
            foreach (var cvar in Resources.variables)
            {
                cvar.Write(file);
            }

            //Write the objects
            file.WriteVLQInt32(Objects.variables.Count);
            foreach (var cvar in Objects.variables)
            {
                cvar.Write(file);
            }

            //Write the block data.
            //first assemble from bytearrays from the individual objects
            List<byte> newbyte = new List<byte>();
            foreach (CSectorDataObject obj in Objects.GetEditableVariables())
            {
                newbyte.AddRange(obj.blockdata.Bytes);
            }
            BlockData.Bytes = newbyte.ToArray();

            //write the data back into one block
            file.WriteVLQInt32(BlockData.Bytes.Length);
            file.Write(BlockData.Bytes);
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

        //blockdata
        public CByteArray blockdata { get; set; }

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
            blockdata = new CByteArray(cr2w) { Name = "blockdata", Type = "byte[]" };
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
                blockdata
            };
        }

        public override string ToString()
        {
            return null;
        }
    }
}