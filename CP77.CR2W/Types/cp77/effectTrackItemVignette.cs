using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemVignette : effectTrackItem
	{
		[Ordinal(0)]  [RED("color")] public effectEffectParameterEvaluatorColor Color { get; set; }
		[Ordinal(1)]  [RED("overrideColor")] public CBool OverrideColor { get; set; }
		[Ordinal(2)]  [RED("overrideRadiusAndExp")] public CBool OverrideRadiusAndExp { get; set; }
		[Ordinal(3)]  [RED("vignetteExp")] public effectEffectParameterEvaluatorFloat VignetteExp { get; set; }
		[Ordinal(4)]  [RED("vignetteRadius")] public effectEffectParameterEvaluatorFloat VignetteRadius { get; set; }

		public effectTrackItemVignette(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
