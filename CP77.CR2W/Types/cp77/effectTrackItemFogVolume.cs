using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemFogVolume : effectTrackItem
	{
		[Ordinal(0)]  [RED("blendFalloff")] public CFloat BlendFalloff { get; set; }
		[Ordinal(1)]  [RED("color")] public CHandle<IEvaluatorColor> Color { get; set; }
		[Ordinal(2)]  [RED("density")] public CHandle<IEvaluatorFloat> Density { get; set; }
		[Ordinal(3)]  [RED("densityFalloff")] public CFloat DensityFalloff { get; set; }
		[Ordinal(4)]  [RED("priority")] public CUInt8 Priority { get; set; }
		[Ordinal(5)]  [RED("size")] public CHandle<IEvaluatorVector> Size { get; set; }

		public effectTrackItemFogVolume(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
