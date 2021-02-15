using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemVignette : effectTrackItem
	{
		[Ordinal(3)] [RED("overrideRadiusAndExp")] public CBool OverrideRadiusAndExp { get; set; }
		[Ordinal(4)] [RED("overrideColor")] public CBool OverrideColor { get; set; }
		[Ordinal(5)] [RED("vignetteRadius")] public effectEffectParameterEvaluatorFloat VignetteRadius { get; set; }
		[Ordinal(6)] [RED("vignetteExp")] public effectEffectParameterEvaluatorFloat VignetteExp { get; set; }
		[Ordinal(7)] [RED("color")] public effectEffectParameterEvaluatorColor Color { get; set; }

		public effectTrackItemVignette(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
