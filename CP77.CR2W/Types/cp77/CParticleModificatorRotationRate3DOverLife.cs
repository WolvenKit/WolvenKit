using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorRotationRate3DOverLife : IParticleModificator
	{
		[Ordinal(4)] [RED("rotationRate")] public CHandle<IEvaluatorVector> RotationRate { get; set; }

		public CParticleModificatorRotationRate3DOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
