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
    class SBlockDataMeshObject : CVariable
    {
        [Ordinal(0)] [RED] public CUInt16 forceAutoHide { get; set; }
        [Ordinal(1)] [RED] public CUInt8 lightChanels { get; set; }
        [Ordinal(2)] [RED] public CUInt8 forcedLodLevel { get; set; }
        [Ordinal(3)] [RED] public CUInt8 shadowBias { get; set; }
        [Ordinal(4)] [RED] public CUInt8 renderingPlane { get; set; }

        public SBlockDataMeshObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
