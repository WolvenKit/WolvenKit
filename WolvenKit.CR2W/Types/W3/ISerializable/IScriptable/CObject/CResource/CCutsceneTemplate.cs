using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;
using System.Diagnostics;
using WolvenKit.CR2W.Types.Utils;
using System.Runtime.Serialization;

namespace WolvenKit.CR2W.Types
{
    [DataContract(Namespace = "")]
    public class CCutsceneTemplate : CVector
    {
        public CUInt32 unk1;
        public CBufferUInt32<CVectorWrapper> animevents;
            
        public CCutsceneTemplate(CR2WFile cr2w) :
            base(cr2w)
        {
            unk1 = new CUInt32(cr2w)
            {
                Name = "unk1"
            };
            animevents = new CBufferUInt32<CVectorWrapper>(cr2w, _ => new CVectorWrapper(_))
            {
                Name = "buffer"
            };

        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            unk1.Read(file, 0);
            animevents.Read(file, 0);

        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            unk1.Write(file);
            animevents.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CCutsceneTemplate(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CCutsceneTemplate) base.Copy(context);

            var.unk1 = (CUInt32) unk1.Copy(context);
            var.animevents = (CBufferUInt32<CVectorWrapper>)animevents.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                unk1,
                animevents
            };
        }
    }
}