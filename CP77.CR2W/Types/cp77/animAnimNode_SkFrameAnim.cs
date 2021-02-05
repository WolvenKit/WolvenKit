using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkFrameAnim : animAnimNode_SkAnim
	{
		[Ordinal(0)]  [RED("progressLink")] public animFloatLink ProgressLink { get; set; }
		[Ordinal(1)]  [RED("timeLink")] public animFloatLink TimeLink { get; set; }
		[Ordinal(2)]  [RED("frameLink")] public animFloatLink FrameLink { get; set; }
		[Ordinal(3)]  [RED("fireAnimEndOnceOnAnimEnd")] public CBool FireAnimEndOnceOnAnimEnd { get; set; }

		public animAnimNode_SkFrameAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
