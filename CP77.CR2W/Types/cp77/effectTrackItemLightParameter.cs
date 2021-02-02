using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemLightParameter : effectTrackItem
	{
		[Ordinal(0)]  [RED("scale")] public CFloat Scale { get; set; }
		[Ordinal(1)]  [RED("intensityMultiplier")] public effectEffectParameterEvaluatorFloat IntensityMultiplier { get; set; }
		[Ordinal(2)]  [RED("intensity")] public effectEffectParameterEvaluatorFloat Intensity { get; set; }
		[Ordinal(3)]  [RED("radius")] public effectEffectParameterEvaluatorFloat Radius { get; set; }

		public effectTrackItemLightParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
