using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkFrameAnim : animAnimNode_SkAnim
	{
		[Ordinal(18)] [RED("progressLink")] public animFloatLink ProgressLink { get; set; }
		[Ordinal(19)] [RED("timeLink")] public animFloatLink TimeLink { get; set; }
		[Ordinal(20)] [RED("frameLink")] public animFloatLink FrameLink { get; set; }
		[Ordinal(21)] [RED("fireAnimEndOnceOnAnimEnd")] public CBool FireAnimEndOnceOnAnimEnd { get; set; }

		public animAnimNode_SkFrameAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
