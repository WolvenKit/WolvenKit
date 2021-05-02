using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class CSectorDataObject : CVariable
    {
        [Ordinal(0)] [RED] public CUInt8 type { get; set; }
        [Ordinal(1)] [RED] public CUInt8 flags { get; set; }
        [Ordinal(2)] [RED] public CUInt16 radius { get; set; }
        [Ordinal(3)] [RED] public CUInt64 offset { get; set; }
        [Ordinal(4)] [RED] public CFloat positionX { get; set; }
        [Ordinal(5)] [RED] public CFloat positionY { get; set; }
        [Ordinal(6)] [RED] public CFloat positionZ { get; set; }

        public CSectorDataObject(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }

        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new CSectorDataObject(cr2w, parent, name);
        }

        public override void Read(BinaryReader file, uint size) => base.Read(file, size);

        public override void Write(BinaryWriter file) => base.Write(file);


    }
}