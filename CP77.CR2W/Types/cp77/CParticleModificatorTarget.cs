using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorTarget : IParticleModificator
	{
		[Ordinal(4)] [RED("position")] public CHandle<IEvaluatorVector> Position { get; set; }
		[Ordinal(5)] [RED("forceScale")] public CHandle<IEvaluatorFloat> ForceScale { get; set; }
		[Ordinal(6)] [RED("killRadius")] public CHandle<IEvaluatorFloat> KillRadius { get; set; }
		[Ordinal(7)] [RED("maxForce")] public CFloat MaxForce { get; set; }

		public CParticleModificatorTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
