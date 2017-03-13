using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3Edit.CR2W.Editors;

namespace W3Edit.CR2W.Types
{
    class CParticleEmitter : CVector
    {
        public CArray Emitters;

        public CParticleEmitter(CR2WFile cr2w) : base(cr2w)
        {
            Emitters = new CArray("array:2,0,ptr:CParticleEmitter", "CParticleEmitter", true, cr2w) {Name = "Emitters"};
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
            Emitters.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            Emitters.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CParticleEmitter(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (CParticleEmitter)base.Copy(context);

            var.Emitters = (CArray)Emitters.Copy(context);

            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables);
            list.Add(Emitters);
            return list;
        }
    }
}
