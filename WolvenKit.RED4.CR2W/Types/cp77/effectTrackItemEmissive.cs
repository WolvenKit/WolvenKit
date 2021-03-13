using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemEmissive : effectTrackItem
	{
		[Ordinal(3)] [RED("override")] public CBool Override { get; set; }
		[Ordinal(4)] [RED("brigtness")] public effectEffectParameterEvaluatorFloat Brigtness { get; set; }

		public effectTrackItemEmissive(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
