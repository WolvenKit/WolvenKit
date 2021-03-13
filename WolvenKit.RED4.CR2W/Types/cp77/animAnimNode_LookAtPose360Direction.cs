using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LookAtPose360Direction : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("angleOffset")] public CFloat AngleOffset { get; set; }
		[Ordinal(12)] [RED("defaultValue")] public CFloat DefaultValue { get; set; }
		[Ordinal(13)] [RED("negateOutput")] public CBool NegateOutput { get; set; }

		public animAnimNode_LookAtPose360Direction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
