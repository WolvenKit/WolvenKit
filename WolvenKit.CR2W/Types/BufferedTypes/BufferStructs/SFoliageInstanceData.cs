using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
   
   


    

    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SFoliageInstanceData : CVariable
    {
        [RED] public CFloat PositionX { get; set; }
        [RED] public CFloat PositionY { get; set; }
        [RED] public CFloat PositionZ { get; set; }
        [RED] public CFloat Yaw { get; set; }
        [RED] public CFloat Pitch { get; set; }
        [RED] public CFloat Roll { get; set; }

        public SFoliageInstanceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }

        public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SFoliageInstanceData(cr2w, parent, name);
    }
}