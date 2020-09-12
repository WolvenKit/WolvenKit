using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.CR2W.Types
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