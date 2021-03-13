using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Pose360 : animAnimNode_Base
	{
		[Ordinal(11)] [RED("angle")] public animFloatLink Angle { get; set; }
		[Ordinal(12)] [RED("animation")] public CName Animation { get; set; }

		public animAnimNode_Pose360(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
