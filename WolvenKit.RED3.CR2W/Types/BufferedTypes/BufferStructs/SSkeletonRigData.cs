using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System;
using System.Linq;
using System.Globalization;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SSkeletonRigData : CVariable
    {
        [Ordinal(0)] [RED] public SVector4D Position { get; set; }
        [Ordinal(1)] [RED] public SVector4D Rotation { get; set; }
        [Ordinal(2)] [RED] public SVector4D Scale { get; set; }

        public SSkeletonRigData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }


        public override string ToString()
        {
            return $"[{Position.ToString()}, {Rotation.ToString()}, {Scale.ToString()}]";
        }
    }
}
