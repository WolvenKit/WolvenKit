using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System;
using System.Linq;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    class SBlockDataParticles : CVariable
    {
        [Ordinal(0)] [RED] public CUInt16 particleSystem { get; set; }
        [Ordinal(1)] [RED] public CUInt16 padding { get; set; }
        [Ordinal(2)] [RED] public CUInt8 lightChanels { get; set; }
        [Ordinal(3)] [RED] public CUInt8 renderingPlane { get; set; }
        [Ordinal(4)] [RED] public CUInt8 envAutoHideGroup { get; set; }
        [Ordinal(5)] [RED] public CUInt8 transparencySortGroup { get; set; }
        [Ordinal(6)] [RED] public CFloat globalEmissionScale { get; set; }

        public SBlockDataParticles(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}