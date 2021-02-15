using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ExplorationAdjuster : animAnimNode_MotionAdjuster
	{
		[Ordinal(6)] [RED("targetPosition2")] public animVectorLink TargetPosition2 { get; set; }
		[Ordinal(7)] [RED("targetDirection2")] public animVectorLink TargetDirection2 { get; set; }
		[Ordinal(8)] [RED("totalTimeToAdjust2")] public animFloatLink TotalTimeToAdjust2 { get; set; }
		[Ordinal(9)] [RED("targetPosition3")] public animVectorLink TargetPosition3 { get; set; }
		[Ordinal(10)] [RED("targetDirection3")] public animVectorLink TargetDirection3 { get; set; }
		[Ordinal(11)] [RED("totalTimeToAdjust3")] public animFloatLink TotalTimeToAdjust3 { get; set; }

		public animAnimNode_ExplorationAdjuster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
