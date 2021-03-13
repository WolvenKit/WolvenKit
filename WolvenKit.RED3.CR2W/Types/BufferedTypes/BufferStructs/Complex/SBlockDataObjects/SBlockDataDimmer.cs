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
    class SBlockDataDimmer : CVariable
    {
        [Ordinal(0)] [RED] public CFloat ambienLevel { get; set; }
        [Ordinal(1)] [RED] public CUInt16 marginFactor { get; set; }
        [Ordinal(2)] [RED] public CUInt8 dimmerType { get; set; }
        [Ordinal(3)] [RED] public CUInt8 paddin1 { get; set; }
        [Ordinal(4)] [RED] public CUInt16 paddin2 { get; set; }

        public SBlockDataDimmer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}