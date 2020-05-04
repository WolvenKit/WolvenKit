
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    class EmitterDelaySettings : CVector
    {
        public CFloat emitterDelay;
		public CFloat emitterDelayLow;
		public CBool useEmitterDelayRange;
		public CBool useEmitterDelayOnce;
		

        public EmitterDelaySettings(CR2WFile cr2w) : base(cr2w)
        {
                emitterDelay = new CFloat(cr2w){ Name = "emitterDelay", Type = "Float"};
				emitterDelayLow = new CFloat(cr2w){ Name = "emitterDelayLow", Type = "Float"};
				useEmitterDelayRange = new CBool(cr2w){ Name = "useEmitterDelayRange", Type = "Bool"};
				useEmitterDelayOnce = new CBool(cr2w){ Name = "useEmitterDelayOnce", Type = "Bool"};
				
        }

        public override void Read(BinaryReader file, uint size)
        {
                emitterDelay.Read(file,size);
				emitterDelayLow.Read(file,size);
				useEmitterDelayRange.Read(file,size);
				useEmitterDelayOnce.Read(file,size);
				
        }

        public override void Write(BinaryWriter file)
        {
                emitterDelay.Write(file);
				emitterDelayLow.Write(file);
				useEmitterDelayRange.Write(file);
				useEmitterDelayOnce.Write(file);
				
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new EmitterDelaySettings(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
                var var = (EmitterDelaySettings)base.Copy(context);
            
                var.emitterDelay = (CFloat)emitterDelay.Copy(context);
				var.emitterDelayLow = (CFloat)emitterDelayLow.Copy(context);
				var.useEmitterDelayRange = (CBool)useEmitterDelayRange.Copy(context);
				var.useEmitterDelayOnce = (CBool)useEmitterDelayOnce.Copy(context);
				
            
                return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                emitterDelay,
				emitterDelayLow,
				useEmitterDelayRange,
				useEmitterDelayOnce, 
            };
            return list;
        }
    }
}
