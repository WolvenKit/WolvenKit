using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemTonemapping : effectTrackItem
	{
		[Ordinal(3)] [RED("override")] public CBool Override { get; set; }
		[Ordinal(4)] [RED("maxStopsSDR")] public effectEffectParameterEvaluatorFloat MaxStopsSDR { get; set; }
		[Ordinal(5)] [RED("midGrayScaleSDR")] public effectEffectParameterEvaluatorFloat MidGrayScaleSDR { get; set; }
		[Ordinal(6)] [RED("maxStopsHDR")] public effectEffectParameterEvaluatorFloat MaxStopsHDR { get; set; }
		[Ordinal(7)] [RED("midGrayScaleHDR")] public effectEffectParameterEvaluatorFloat MidGrayScaleHDR { get; set; }

		public effectTrackItemTonemapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
