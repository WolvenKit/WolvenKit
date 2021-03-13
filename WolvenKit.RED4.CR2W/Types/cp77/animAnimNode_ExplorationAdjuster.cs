using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ExplorationAdjuster : animAnimNode_MotionAdjuster
	{
		[Ordinal(16)] [RED("targetPosition2")] public animVectorLink TargetPosition2 { get; set; }
		[Ordinal(17)] [RED("targetDirection2")] public animVectorLink TargetDirection2 { get; set; }
		[Ordinal(18)] [RED("totalTimeToAdjust2")] public animFloatLink TotalTimeToAdjust2 { get; set; }
		[Ordinal(19)] [RED("targetPosition3")] public animVectorLink TargetPosition3 { get; set; }
		[Ordinal(20)] [RED("targetDirection3")] public animVectorLink TargetDirection3 { get; set; }
		[Ordinal(21)] [RED("totalTimeToAdjust3")] public animFloatLink TotalTimeToAdjust3 { get; set; }

		public animAnimNode_ExplorationAdjuster(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
