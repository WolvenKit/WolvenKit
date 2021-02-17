using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorVelocityOverLife : IParticleModificator
	{
		[Ordinal(4)] [RED("velocity")] public CHandle<IEvaluatorVector> Velocity { get; set; }
		[Ordinal(5)] [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(6)] [RED("modulate")] public CBool Modulate { get; set; }
		[Ordinal(7)] [RED("absolute")] public CBool Absolute { get; set; }

		public CParticleModificatorVelocityOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
