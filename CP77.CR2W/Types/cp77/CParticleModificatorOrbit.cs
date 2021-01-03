using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CParticleModificatorOrbit : IParticleModificator
	{
		[Ordinal(0)]  [RED("frequency")] public CHandle<IEvaluatorVector> Frequency { get; set; }
		[Ordinal(1)]  [RED("offset")] public CHandle<IEvaluatorVector> Offset { get; set; }
		[Ordinal(2)]  [RED("overridePosition")] public CBool OverridePosition { get; set; }
		[Ordinal(3)]  [RED("phase")] public CHandle<IEvaluatorVector> Phase { get; set; }

		public CParticleModificatorOrbit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
