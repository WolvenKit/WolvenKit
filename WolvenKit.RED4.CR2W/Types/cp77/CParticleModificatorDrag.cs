using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorDrag : IParticleModificator
	{
		[Ordinal(4)] [RED("dragCoefficient")] public CHandle<IEvaluatorFloat> DragCoefficient { get; set; }
		[Ordinal(5)] [RED("scale")] public CFloat Scale { get; set; }

		public CParticleModificatorDrag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
