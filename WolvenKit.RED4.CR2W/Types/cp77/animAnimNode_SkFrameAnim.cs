using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SkFrameAnim : animAnimNode_SkAnim
	{
		[Ordinal(30)] [RED("progressLink")] public animFloatLink ProgressLink { get; set; }
		[Ordinal(31)] [RED("timeLink")] public animFloatLink TimeLink { get; set; }
		[Ordinal(32)] [RED("frameLink")] public animFloatLink FrameLink { get; set; }
		[Ordinal(33)] [RED("fireAnimEndOnceOnAnimEnd")] public CBool FireAnimEndOnceOnAnimEnd { get; set; }

		public animAnimNode_SkFrameAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
