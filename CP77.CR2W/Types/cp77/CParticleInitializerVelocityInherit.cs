using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerVelocityInherit : IParticleInitializer
	{
		[Ordinal(4)] [RED("scale")] public CHandle<IEvaluatorFloat> Scale { get; set; }

		public CParticleInitializerVelocityInherit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
