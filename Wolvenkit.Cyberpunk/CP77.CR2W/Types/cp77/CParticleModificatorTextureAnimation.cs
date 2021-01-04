using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorTextureAnimation : IParticleModificator
	{
		[Ordinal(0)]  [RED("animationMode")] public CEnum<ETextureAnimationMode> AnimationMode { get; set; }
		[Ordinal(1)]  [RED("animationSpeed")] public CHandle<IEvaluatorFloat> AnimationSpeed { get; set; }
		[Ordinal(2)]  [RED("initialFrame")] public CHandle<IEvaluatorFloat> InitialFrame { get; set; }

		public CParticleModificatorTextureAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
