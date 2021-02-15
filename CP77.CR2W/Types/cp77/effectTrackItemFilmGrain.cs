using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemFilmGrain : effectTrackItem
	{
		[Ordinal(3)] [RED("override")] public CBool Override { get; set; }
		[Ordinal(4)] [RED("luminanceBias")] public effectEffectParameterEvaluatorFloat LuminanceBias { get; set; }
		[Ordinal(5)] [RED("strength")] public effectEffectParameterEvaluatorVector Strength { get; set; }

		public effectTrackItemFilmGrain(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
