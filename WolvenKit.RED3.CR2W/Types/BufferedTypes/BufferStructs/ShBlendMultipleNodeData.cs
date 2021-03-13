using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using static WolvenKit.RED3.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class ShBlendMultipleNodeData : CVariable
    {
        [Ordinal(0)] [RED] public CUInt32 Index { get; set; }
        [Ordinal(1)] [RED] public CFloat Blendvalue { get; set; }

        public ShBlendMultipleNodeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new ShBlendMultipleNodeData(cr2w, parent, name);
    }





}