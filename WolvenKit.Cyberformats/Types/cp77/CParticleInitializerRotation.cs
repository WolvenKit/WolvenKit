using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleInitializerRotation : IParticleInitializer
	{
		[Ordinal(4)] [RED("rotation")] public CHandle<IEvaluatorFloat> Rotation { get; set; }

		public CParticleInitializerRotation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
