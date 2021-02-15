using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorTextureAnimation : IParticleModificator
	{
		[Ordinal(4)] [RED("initialFrame")] public CHandle<IEvaluatorFloat> InitialFrame { get; set; }
		[Ordinal(5)] [RED("animationSpeed")] public CHandle<IEvaluatorFloat> AnimationSpeed { get; set; }
		[Ordinal(6)] [RED("animationMode")] public CEnum<ETextureAnimationMode> AnimationMode { get; set; }

		public CParticleModificatorTextureAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
