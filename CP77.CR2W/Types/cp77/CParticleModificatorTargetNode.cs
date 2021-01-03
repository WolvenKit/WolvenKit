using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorTargetNode : IParticleModificator
	{
		[Ordinal(0)]  [RED("forceScale")] public CHandle<IEvaluatorFloat> ForceScale { get; set; }
		[Ordinal(1)]  [RED("killRadius")] public CHandle<IEvaluatorFloat> KillRadius { get; set; }
		[Ordinal(2)]  [RED("maxForce")] public CFloat MaxForce { get; set; }

		public CParticleModificatorTargetNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
