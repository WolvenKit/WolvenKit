using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class SFoliageInstance : CVariable
    {
        [RED] public SVector3D position { get; set; }
        [RED] public CFloat Yaw { get; set; }
        [RED] public CFloat Pitch { get; set; }
        [RED] public CFloat Roll { get; set; }

        public SFoliageInstance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {

        }


        public override CVariable Create(CR2WFile cr2w, CVariable parent, string name)
        {
            return new SFoliageInstance(cr2w, parent, name);
        }
    }
}
