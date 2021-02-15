using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkPhaseWithDurationAnim : animAnimNode_SkPhaseAnim
	{
		[Ordinal(19)] [RED("durationLink")] public animFloatLink DurationLink { get; set; }

		public animAnimNode_SkPhaseWithDurationAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
