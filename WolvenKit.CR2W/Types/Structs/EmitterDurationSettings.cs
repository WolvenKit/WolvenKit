
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class EmitterDurationSettings : CVariable
    {
        [RED] public CFloat emitterDuration { get; set; }
        [RED] public CFloat emitterDurationLow { get; set; }
        [RED] public CBool useEmitterDurationRange { get; set; }


        public EmitterDurationSettings(CR2WFile cr2w) : base(cr2w)
        {


        }

        public override CVariable Create(CR2WFile cr2w) => new EmitterDurationSettings(cr2w);
    }
}
