using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerVelocitySpread : IParticleInitializer
	{
		[Ordinal(0)]  [RED("conserveMomentum")] public CBool ConserveMomentum { get; set; }
		[Ordinal(1)]  [RED("scale")] public CHandle<IEvaluatorFloat> Scale { get; set; }

		public CParticleInitializerVelocitySpread(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
