using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorVectorFieldAttractor : IParticleModificator
	{
		[Ordinal(0)]  [RED("attract")] public CBool Attract { get; set; }
		[Ordinal(1)]  [RED("drag")] public CBool Drag { get; set; }
		[Ordinal(2)]  [RED("inheritVelocity")] public CBool InheritVelocity { get; set; }
		[Ordinal(3)]  [RED("restitution")] public CHandle<IEvaluatorFloat> Restitution { get; set; }

		public CParticleModificatorVectorFieldAttractor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
