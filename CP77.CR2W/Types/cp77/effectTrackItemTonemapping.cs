using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemTonemapping : effectTrackItem
	{
		[Ordinal(0)]  [RED("maxStopsHDR")] public effectEffectParameterEvaluatorFloat MaxStopsHDR { get; set; }
		[Ordinal(1)]  [RED("maxStopsSDR")] public effectEffectParameterEvaluatorFloat MaxStopsSDR { get; set; }
		[Ordinal(2)]  [RED("midGrayScaleHDR")] public effectEffectParameterEvaluatorFloat MidGrayScaleHDR { get; set; }
		[Ordinal(3)]  [RED("midGrayScaleSDR")] public effectEffectParameterEvaluatorFloat MidGrayScaleSDR { get; set; }
		[Ordinal(4)]  [RED("override")] public CBool Override { get; set; }

		public effectTrackItemTonemapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
