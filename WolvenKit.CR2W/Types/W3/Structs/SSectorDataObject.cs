using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
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
            return "";
        }
    }
}