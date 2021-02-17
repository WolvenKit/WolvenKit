using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorVelocityTurbulize : IParticleModificator
	{
		[Ordinal(4)] [RED("scale")] public CHandle<IEvaluatorVector> Scale { get; set; }
		[Ordinal(5)] [RED("timelifeLimit")] public CHandle<IEvaluatorFloat> TimelifeLimit { get; set; }
		[Ordinal(6)] [RED("noiseInterval")] public CFloat NoiseInterval { get; set; }
		[Ordinal(7)] [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(8)] [RED("worldSpace")] public CBool WorldSpace { get; set; }

		public CParticleModificatorVelocityTurbulize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
