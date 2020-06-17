
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    class EmitterDurationSettings : CVector
    {
        public CFloat emitterDuration;
		public CFloat emitterDurationLow;
		public CBool useEmitterDurationRange;
		

        public EmitterDurationSettings(CR2WFile cr2w) : base(cr2w)
        {
            emitterDuration = new CFloat(cr2w){ Name = "emitterDuration", Type = "Float"};
			emitterDurationLow = new CFloat(cr2w){ Name = "emitterDurationLow", Type = "Float"};
			useEmitterDurationRange = new CBool(cr2w){ Name = "useEmitterDurationRange", Type = "Bool"};
				
        }

        public override void Read(BinaryReader file, uint size)
        {
            //base.Read(file, size);

            emitterDuration.Read(file,size);
            emitterDurationLow.Read(file,size);
            useEmitterDurationRange.Read(file,size);

        }

        public override void Write(BinaryWriter file)
        {
            emitterDuration.Write(file);
			emitterDurationLow.Write(file);
			useEmitterDurationRange.Write(file);
				
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new EmitterDurationSettings(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
                var var = (EmitterDurationSettings)base.Copy(context);
            
                var.emitterDuration = (CFloat)emitterDuration.Copy(context);
				var.emitterDurationLow = (CFloat)emitterDurationLow.Copy(context);
				var.useEmitterDurationRange = (CBool)useEmitterDurationRange.Copy(context);
				
            
                return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                emitterDuration,
				emitterDurationLow,
				useEmitterDurationRange, 
            };
            return list;
        }
    }
}
