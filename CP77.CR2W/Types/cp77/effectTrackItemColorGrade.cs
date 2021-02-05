using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemColorGrade : effectTrackItem
	{
		[Ordinal(0)]  [RED("contrast")] public effectEffectParameterEvaluatorFloat Contrast { get; set; }
		[Ordinal(1)]  [RED("saturate")] public effectEffectParameterEvaluatorFloat Saturate { get; set; }
		[Ordinal(2)]  [RED("brightness")] public effectEffectParameterEvaluatorFloat Brightness { get; set; }
		[Ordinal(3)]  [RED("lutWeight")] public effectEffectParameterEvaluatorFloat LutWeight { get; set; }
		[Ordinal(4)]  [RED("lutParams")] public ColorGradingLutParams LutParams { get; set; }
		[Ordinal(5)]  [RED("lutParamsHdr")] public ColorGradingLutParams LutParamsHdr { get; set; }

		public effectTrackItemColorGrade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
