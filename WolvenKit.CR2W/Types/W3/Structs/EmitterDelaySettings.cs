
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;
using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    [REDMeta(EREDMetaInfo.REDStruct)]
    public class EmitterDelaySettings : CVariable
    {
        [RED] public CFloat emitterDelay { get; set; }
        [RED] public CFloat emitterDelayLow { get; set; }
        [RED] public CBool useEmitterDelayRange { get; set; }
        [RED] public CBool useEmitterDelayOnce { get; set; }


        public EmitterDelaySettings(CR2WFile cr2w) : base(cr2w)
        {
            emitterDelay = new CFloat(cr2w);
            emitterDelayLow = new CFloat(cr2w);
            useEmitterDelayRange = new CBool(cr2w);
            useEmitterDelayOnce = new CBool(cr2w);
        }

        public override CVariable Create(CR2WFile cr2w) => new EmitterDelaySettings(cr2w);
    }
}
