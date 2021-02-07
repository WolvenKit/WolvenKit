using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Drag : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("sourceBone")] public animTransformIndex SourceBone { get; set; }
		[Ordinal(1)]  [RED("outTargetBone")] public animTransformIndex OutTargetBone { get; set; }
		[Ordinal(2)]  [RED("simulationFps")] public CFloat SimulationFps { get; set; }
		[Ordinal(3)]  [RED("sourceSpeedMultiplier")] public CFloat SourceSpeedMultiplier { get; set; }
		[Ordinal(4)]  [RED("hasOvershoot")] public CBool HasOvershoot { get; set; }
		[Ordinal(5)]  [RED("overshootDuration")] public CFloat OvershootDuration { get; set; }
		[Ordinal(6)]  [RED("overshootDetectionMinSpeed")] public CFloat OvershootDetectionMinSpeed { get; set; }
		[Ordinal(7)]  [RED("overshootDetectionMaxSpeed")] public CFloat OvershootDetectionMaxSpeed { get; set; }
		[Ordinal(8)]  [RED("useSteps")] public CBool UseSteps { get; set; }
		[Ordinal(9)]  [RED("stepsTargetSpeedMultiplier")] public CFloat StepsTargetSpeedMultiplier { get; set; }
		[Ordinal(10)]  [RED("timeBetweenSteps")] public CFloat TimeBetweenSteps { get; set; }
		[Ordinal(11)]  [RED("timeInStep")] public CFloat TimeInStep { get; set; }

		public animAnimNode_Drag(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
