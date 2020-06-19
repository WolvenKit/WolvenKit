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

        public override CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new SBlockData(cr2w, parent, name);
        }

        public override string ToString()
        {
            return "";
        }
    }
}