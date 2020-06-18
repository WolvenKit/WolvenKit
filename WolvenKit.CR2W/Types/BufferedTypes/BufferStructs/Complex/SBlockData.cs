using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SBlockData : CVariable
    {

        [RED] public CMatrix3x3 rotationMatrix { get; set; }
        [RED] public SVector3D position { get; set; }
        [RED] public CUInt16 streamingRadius { get; set; }
        [RED] public CUInt16 flags { get; set; }
        [RED] public CUInt32 occlusionSystemID { get; set; }
        [RED] public CUInt32 resourceIndex { get; set; }

        [REDBuffer(true)] public CBytes tail { get; set; }

        public SBlockData(CR2WFile cr2w) :
            base(cr2w)
        {
            tail = new CBytes(cr2w) { REDName = "tail", Parent = this };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            tail.Read(file, size - 60);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            tail.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SBlockData(cr2w);
        }

        public override string ToString()
        {
            return "";
        }
    }
}