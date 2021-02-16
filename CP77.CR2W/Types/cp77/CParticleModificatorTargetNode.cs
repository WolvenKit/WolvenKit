using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorTargetNode : IParticleModificator
	{
		[Ordinal(4)] [RED("forceScale")] public CHandle<IEvaluatorFloat> ForceScale { get; set; }
		[Ordinal(5)] [RED("killRadius")] public CHandle<IEvaluatorFloat> KillRadius { get; set; }
		[Ordinal(6)] [RED("maxForce")] public CFloat MaxForce { get; set; }

		public CParticleModificatorTargetNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
