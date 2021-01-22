using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorVelocityOverLife : IParticleModificator
	{
		[Ordinal(0)]  [RED("absolute")] public CBool Absolute { get; set; }
		[Ordinal(1)]  [RED("modulate")] public CBool Modulate { get; set; }
		[Ordinal(2)]  [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(3)]  [RED("velocity")] public CHandle<IEvaluatorVector> Velocity { get; set; }

		public CParticleModificatorVelocityOverLife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
