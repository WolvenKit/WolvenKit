using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemDataMosh : effectTrackItem
	{
		[Ordinal(0)]  [RED("glitchColor")] public effectEffectParameterEvaluatorVector GlitchColor { get; set; }
		[Ordinal(1)]  [RED("intensity")] public effectEffectParameterEvaluatorFloat Intensity { get; set; }
		[Ordinal(2)]  [RED("override")] public CBool Override { get; set; }
		[Ordinal(3)]  [RED("useGlitch")] public CBool UseGlitch { get; set; }

		public effectTrackItemDataMosh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
