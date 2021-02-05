using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LookAtPose360 : animAnimNode_Base
	{
		[Ordinal(0)]  [RED("speedInDegreesPerSecond")] public CFloat SpeedInDegreesPerSecond { get; set; }
		[Ordinal(1)]  [RED("angleOffsetNode")] public animFloatLink AngleOffsetNode { get; set; }
		[Ordinal(2)]  [RED("targetAngleOffsetNode")] public animFloatLink TargetAngleOffsetNode { get; set; }
		[Ordinal(3)]  [RED("animation")] public CName Animation { get; set; }
		[Ordinal(4)]  [RED("durationCut")] public CFloat DurationCut { get; set; }

		public animAnimNode_LookAtPose360(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
