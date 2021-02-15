using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemDataMosh : effectTrackItem
	{
		[Ordinal(3)] [RED("override")] public CBool Override { get; set; }
		[Ordinal(4)] [RED("intensity")] public effectEffectParameterEvaluatorFloat Intensity { get; set; }
		[Ordinal(5)] [RED("useGlitch")] public CBool UseGlitch { get; set; }
		[Ordinal(6)] [RED("glitchColor")] public effectEffectParameterEvaluatorVector GlitchColor { get; set; }

		public effectTrackItemDataMosh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
