using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemColorGrade : effectTrackItem
	{
		[Ordinal(3)] [RED("contrast")] public effectEffectParameterEvaluatorFloat Contrast { get; set; }
		[Ordinal(4)] [RED("saturate")] public effectEffectParameterEvaluatorFloat Saturate { get; set; }
		[Ordinal(5)] [RED("brightness")] public effectEffectParameterEvaluatorFloat Brightness { get; set; }
		[Ordinal(6)] [RED("lutWeight")] public effectEffectParameterEvaluatorFloat LutWeight { get; set; }
		[Ordinal(7)] [RED("lutParams")] public ColorGradingLutParams LutParams { get; set; }
		[Ordinal(8)] [RED("lutParamsHdr")] public ColorGradingLutParams LutParamsHdr { get; set; }

		public effectTrackItemColorGrade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
