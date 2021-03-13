using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorForce : IParticleModificator
	{
		[Ordinal(4)] [RED("pivot")] public Vector3 Pivot { get; set; }
		[Ordinal(5)] [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(6)] [RED("scale")] public CHandle<IEvaluatorFloat> Scale { get; set; }
		[Ordinal(7)] [RED("damp")] public CHandle<IEvaluatorVector> Damp { get; set; }

		public CParticleModificatorForce(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
