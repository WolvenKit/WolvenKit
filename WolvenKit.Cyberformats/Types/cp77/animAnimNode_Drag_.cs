using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Drag_ : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("sourceBone")] public animTransformIndex SourceBone { get; set; }
		[Ordinal(13)] [RED("outTargetBone")] public animTransformIndex OutTargetBone { get; set; }
		[Ordinal(14)] [RED("simulationFps")] public CFloat SimulationFps { get; set; }
		[Ordinal(15)] [RED("sourceSpeedMultiplier")] public CFloat SourceSpeedMultiplier { get; set; }
		[Ordinal(17)] [RED("hasOvershoot")] public CBool HasOvershoot { get; set; }
		[Ordinal(18)] [RED("overshootDuration")] public CFloat OvershootDuration { get; set; }
		[Ordinal(19)] [RED("overshootDetectionMinSpeed")] public CFloat OvershootDetectionMinSpeed { get; set; }
		[Ordinal(20)] [RED("overshootDetectionMaxSpeed")] public CFloat OvershootDetectionMaxSpeed { get; set; }
		[Ordinal(21)] [RED("useSteps")] public CBool UseSteps { get; set; }
		[Ordinal(22)] [RED("stepsTargetSpeedMultiplier")] public CFloat StepsTargetSpeedMultiplier { get; set; }
		[Ordinal(23)] [RED("timeBetweenSteps")] public CFloat TimeBetweenSteps { get; set; }
		[Ordinal(24)] [RED("timeInStep")] public CFloat TimeInStep { get; set; }

		public animAnimNode_Drag_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
