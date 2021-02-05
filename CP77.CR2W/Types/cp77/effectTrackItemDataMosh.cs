using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemDataMosh : effectTrackItem
	{
		[Ordinal(0)]  [RED("override")] public CBool Override { get; set; }
		[Ordinal(1)]  [RED("intensity")] public effectEffectParameterEvaluatorFloat Intensity { get; set; }
		[Ordinal(2)]  [RED("useGlitch")] public CBool UseGlitch { get; set; }
		[Ordinal(3)]  [RED("glitchColor")] public effectEffectParameterEvaluatorVector GlitchColor { get; set; }

		public effectTrackItemDataMosh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
