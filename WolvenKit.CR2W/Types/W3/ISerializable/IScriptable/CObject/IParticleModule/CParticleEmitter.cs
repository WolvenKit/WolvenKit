using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    class CParticleEmitter : CVector
    {
        public SParticleEmitterModuleData moduleData;

        public CParticleEmitter(CR2WFile cr2w) : base(cr2w)
        {
            moduleData = new SParticleEmitterModuleData(cr2w) { Name = "moduleData", Type = "ParticleEmitterModuleData" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
            moduleData.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            moduleData.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CParticleEmitter(cr2w);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                moduleData
            };
        }
    }
}