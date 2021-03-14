using System.Collections.Generic;
using System.IO;

using System.Diagnostics;
using System.Runtime.Serialization;
using static WolvenKit.RED3.CR2W.Types.Enums;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SUmbraTileData : CVariable
    {
        [Ordinal(1000)] [REDBuffer] public CUInt64 Hash { get; set; }
        [Ordinal(1001)] [REDBuffer] public CUInt16 Index { get; set; }
        [Ordinal(1001)] [REDBuffer] public CUInt8 Flag1 { get; set; }
        [Ordinal(1001)] [REDBuffer] public CUInt8 Flag2 { get; set; }

        public SUmbraTileData(CR2WFile cr2w, CVariable parent, string name) :
            base(cr2w, parent, name)
        {

        }


    }
}