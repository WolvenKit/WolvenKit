using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorDrag : IParticleModificator
	{
		[Ordinal(0)]  [RED("dragCoefficient")] public CHandle<IEvaluatorFloat> DragCoefficient { get; set; }
		[Ordinal(1)]  [RED("scale")] public CFloat Scale { get; set; }

		public CParticleModificatorDrag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
