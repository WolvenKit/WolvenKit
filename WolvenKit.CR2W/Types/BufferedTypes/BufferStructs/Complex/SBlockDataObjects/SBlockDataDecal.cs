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
    class SBlockDataDecal : CVariable
    {
        [Ordinal(0)] [RED] public CUInt16 diffuseTexture { get; set; }
        [Ordinal(1)] [RED] public CUInt16 padding { get; set; }
        [Ordinal(2)] [RED] public CUInt32 specularColor { get; set; }
        [Ordinal(3)] [RED] public CFloat normalTreshold { get; set; }
        [Ordinal(4)] [RED] public CFloat specularity { get; set; }
        [Ordinal(5)] [RED] public CFloat fadeTime { get; set; }

        public SBlockDataDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
