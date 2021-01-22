using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorVelocityTurbulize : IParticleModificator
	{
		[Ordinal(0)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(1)]  [RED("noiseInterval")] public CFloat NoiseInterval { get; set; }
		[Ordinal(2)]  [RED("scale")] public CHandle<IEvaluatorVector> Scale { get; set; }
		[Ordinal(3)]  [RED("timelifeLimit")] public CHandle<IEvaluatorFloat> TimelifeLimit { get; set; }
		[Ordinal(4)]  [RED("worldSpace")] public CBool WorldSpace { get; set; }

		public CParticleModificatorVelocityTurbulize(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
