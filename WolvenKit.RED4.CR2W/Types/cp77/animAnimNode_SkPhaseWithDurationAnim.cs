using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseWithDurationAnim : animAnimNode_SkPhaseAnim
	{
		[Ordinal(31)] [RED("durationLink")] public animFloatLink DurationLink { get; set; }

		public animAnimNode_SkPhaseWithDurationAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
