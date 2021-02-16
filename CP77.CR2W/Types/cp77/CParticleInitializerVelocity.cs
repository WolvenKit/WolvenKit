using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerVelocity : IParticleInitializer
	{
		[Ordinal(4)] [RED("velocity")] public CHandle<IEvaluatorVector> Velocity { get; set; }
		[Ordinal(5)] [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(6)] [RED("worldSpace")] public CBool WorldSpace { get; set; }

		public CParticleInitializerVelocity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
