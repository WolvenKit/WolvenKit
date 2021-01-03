using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemLightParameter : effectTrackItem
	{
		[Ordinal(0)]  [RED("intensity")] public effectEffectParameterEvaluatorFloat Intensity { get; set; }
		[Ordinal(1)]  [RED("intensityMultiplier")] public effectEffectParameterEvaluatorFloat IntensityMultiplier { get; set; }
		[Ordinal(2)]  [RED("radius")] public effectEffectParameterEvaluatorFloat Radius { get; set; }
		[Ordinal(3)]  [RED("scale")] public CFloat Scale { get; set; }

		public effectTrackItemLightParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
