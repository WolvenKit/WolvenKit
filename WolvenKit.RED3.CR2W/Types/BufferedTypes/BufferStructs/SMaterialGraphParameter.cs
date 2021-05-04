using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

using WolvenKit.RED3.CR2W.Reflection;
using static WolvenKit.RED3.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SMaterialGraphParameter : CVariable
    {
        [Ordinal(0)] [RED] public CUInt8 Type { get; set; }
        [Ordinal(1)] [RED] public CUInt8 Offset { get; set; }
        [Ordinal(2)] [RED] public CName Name { get; set; }


        public SMaterialGraphParameter(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }


        public override string ToString()
        {
            return "";
        }
    }
}
