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
    public class SUmbraSceneData : CVariable
    {
        [Ordinal(1000)] [REDBuffer] public SVector4D Position { get; set; }
        [Ordinal(1001)] [REDBuffer] public CHandle<CUmbraTile> Umbratile { get; set; }

        public SUmbraSceneData(CR2WFile cr2w, CVariable parent, string name) :
            base(cr2w, parent, name)
        {

        }



        public static CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new SUmbraSceneData(cr2w, parent, name);
        }
    }
}