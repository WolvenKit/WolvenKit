using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemChromaticAberration : effectTrackItem
	{
		[Ordinal(3)] [RED("override")] public CBool Override { get; set; }
		[Ordinal(4)] [RED("chromaticAberrationOffset")] public effectEffectParameterEvaluatorFloat ChromaticAberrationOffset { get; set; }
		[Ordinal(5)] [RED("chromaticAberrationExp")] public effectEffectParameterEvaluatorFloat ChromaticAberrationExp { get; set; }

		public effectTrackItemChromaticAberration(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
