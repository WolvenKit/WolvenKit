using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemColorGradeV2 : effectTrackItem
	{
		[Ordinal(0)]  [RED("contrast")] public effectEffectParameterEvaluatorFloat Contrast { get; set; }
		[Ordinal(1)]  [RED("contrastPivot")] public effectEffectParameterEvaluatorFloat ContrastPivot { get; set; }
		[Ordinal(2)]  [RED("saturation")] public effectEffectParameterEvaluatorFloat Saturation { get; set; }
		[Ordinal(3)]  [RED("hue")] public effectEffectParameterEvaluatorFloat Hue { get; set; }
		[Ordinal(4)]  [RED("brightness")] public effectEffectParameterEvaluatorFloat Brightness { get; set; }
		[Ordinal(5)]  [RED("lowRange")] public effectEffectParameterEvaluatorFloat LowRange { get; set; }
		[Ordinal(6)]  [RED("highRange")] public effectEffectParameterEvaluatorFloat HighRange { get; set; }
		[Ordinal(7)]  [RED("lift")] public effectEffectParameterEvaluatorVector Lift { get; set; }
		[Ordinal(8)]  [RED("gamma")] public effectEffectParameterEvaluatorVector Gamma { get; set; }
		[Ordinal(9)]  [RED("gain")] public effectEffectParameterEvaluatorVector Gain { get; set; }
		[Ordinal(10)]  [RED("offset")] public effectEffectParameterEvaluatorVector Offset { get; set; }
		[Ordinal(11)]  [RED("shadow")] public effectEffectParameterEvaluatorVector Shadow { get; set; }
		[Ordinal(12)]  [RED("midtone")] public effectEffectParameterEvaluatorVector Midtone { get; set; }
		[Ordinal(13)]  [RED("highlight")] public effectEffectParameterEvaluatorVector Highlight { get; set; }

		public effectTrackItemColorGradeV2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
