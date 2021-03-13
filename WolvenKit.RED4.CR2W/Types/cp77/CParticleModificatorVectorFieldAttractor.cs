using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorVectorFieldAttractor : IParticleModificator
	{
		[Ordinal(4)] [RED("inheritVelocity")] public CBool InheritVelocity { get; set; }
		[Ordinal(5)] [RED("attract")] public CBool Attract { get; set; }
		[Ordinal(6)] [RED("drag")] public CBool Drag { get; set; }
		[Ordinal(7)] [RED("restitution")] public CHandle<IEvaluatorFloat> Restitution { get; set; }

		public CParticleModificatorVectorFieldAttractor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
