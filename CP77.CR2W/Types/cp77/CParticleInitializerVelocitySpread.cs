using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerVelocitySpread : IParticleInitializer
	{
		[Ordinal(0)]  [RED("conserveMomentum")] public CBool ConserveMomentum { get; set; }
		[Ordinal(1)]  [RED("scale")] public CHandle<IEvaluatorFloat> Scale { get; set; }

		public CParticleInitializerVelocitySpread(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
