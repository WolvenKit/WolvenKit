using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CEnvProbeComponent : CComponent
    {
        public CBufferUInt32<CQuaternion> unk1;
            
        public CEnvProbeComponent(CR2WFile cr2w) :
            base(cr2w)
        {
            unk1 = new CBufferUInt32<CQuaternion>(cr2w, _ => new CQuaternion(_))
            {
                Name = "unk1"
            };
            
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            unk1.Read(file, 0);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            unk1.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CEnvProbeComponent(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CEnvProbeComponent) base.Copy(context);

            var.unk1 = (CBufferUInt32<CQuaternion>) unk1.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(base.GetEditableVariables())
            {
                unk1
            };
        }
    }
}