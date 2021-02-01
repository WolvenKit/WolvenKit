using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorForce : IParticleModificator
	{
		[Ordinal(0)]  [RED("damp")] public CHandle<IEvaluatorVector> Damp { get; set; }
		[Ordinal(1)]  [RED("pivot")] public Vector3 Pivot { get; set; }
		[Ordinal(2)]  [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(3)]  [RED("scale")] public CHandle<IEvaluatorFloat> Scale { get; set; }

		public CParticleModificatorForce(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
