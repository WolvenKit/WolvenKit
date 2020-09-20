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
    class SBlockDataCollisionObject : CVariable
    {
        [Ordinal(0)] [RED] public CUInt16 meshIndex { get; set; }
        [Ordinal(1)] [RED] public CUInt16 padding { get;set; }
        [Ordinal(2)] [RED] public CUInt64 collisionMask { get; set; }
        [Ordinal(3)] [RED] public CUInt64 collisionGroup { get; set; }

        public SBlockDataCollisionObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}