using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;
using static WolvenKit.CR2W.Types.Enums;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SUmbraSceneData : CVariable
    {
        [RED] public CFloat positionX { get; set; }
        [RED] public CFloat positionY { get; set; }
        [RED] public CFloat positionZ { get; set; }
        [RED] public CFloat positionW { get; set; }
        [RED] public CHandle<CUmbraTile> umbratile { get; set; }

        public SUmbraSceneData(CR2WFile cr2w) :
            base(cr2w)
        {

        }



        public override CVariable Create(CR2WFile cr2w)
        {
            return new SUmbraSceneData(cr2w);
        }
    }
}