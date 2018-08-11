
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    class SParticleEmitterLODLevel : CVector
    {
        public CFloat distance;
		

        public SParticleEmitterLODLevel(CR2WFile cr2w) : base(cr2w)
        {
            distance = new CFloat(cr2w)
            {
                Name = "distance"
            };
        }

        public override void Read(BinaryReader file, uint size)
        {
            distance.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            distance.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SParticleEmitterLODLevel(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = (SParticleEmitterLODLevel)base.Copy(context);
            var.distance = (CFloat) distance.Copy(context);
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var list = new List<IEditableVariable>(variables)
            {
                distance
            };
            return list;
        }
    }
}
