using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SBlockData : CVariable
    {

        [Ordinal(0)] [RED] public CMatrix3x3 rotationMatrix { get; set; }
        [Ordinal(1)] [RED] public SVector3D position { get; set; }
        [Ordinal(2)] [RED] public CUInt16 streamingRadius { get; set; }
        [Ordinal(3)] [RED] public CUInt16 flags { get; set; }
        [Ordinal(4)] [RED] public CUInt32 occlusionSystemID { get; set; }
        [Ordinal(5)] [RED] public CUInt32 resourceIndex { get; set; }

        [Ordinal(1000)] [REDBuffer(true)] public CBytes tail { get; set; }

        public SBlockData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            tail = new CBytes(cr2w, this, nameof(tail));
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

        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new SBlockData(cr2w, parent, name);
        }

        public override string ToString()
        {
            return "";
        }
    }
}