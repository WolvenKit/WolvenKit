using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameActionAnimationSlideParams : CVariable
	{
		[Ordinal(0)]  [RED("distance")] public CFloat Distance { get; set; }
		[Ordinal(1)]  [RED("directionAngle")] public CFloat DirectionAngle { get; set; }
		[Ordinal(2)]  [RED("finalRotationAngle")] public CFloat FinalRotationAngle { get; set; }
		[Ordinal(3)]  [RED("offsetToTarget")] public CFloat OffsetToTarget { get; set; }
		[Ordinal(4)]  [RED("offsetAroundTarget")] public CFloat OffsetAroundTarget { get; set; }
		[Ordinal(5)]  [RED("slideToTarget")] public CBool SlideToTarget { get; set; }
		[Ordinal(6)]  [RED("duration")] public CFloat Duration { get; set; }
		[Ordinal(7)]  [RED("positionSpeed")] public CFloat PositionSpeed { get; set; }
		[Ordinal(8)]  [RED("rotationSpeed")] public CFloat RotationSpeed { get; set; }
		[Ordinal(9)]  [RED("maxSlidePositionDistance")] public CFloat MaxSlidePositionDistance { get; set; }
		[Ordinal(10)]  [RED("maxSlideRotationAngle")] public CFloat MaxSlideRotationAngle { get; set; }
		[Ordinal(11)]  [RED("slideStartDelay")] public CFloat SlideStartDelay { get; set; }
		[Ordinal(12)]  [RED("usePositionSlide")] public CBool UsePositionSlide { get; set; }
		[Ordinal(13)]  [RED("useRotationSlide")] public CBool UseRotationSlide { get; set; }
		[Ordinal(14)]  [RED("maxTargetVelocity")] public CFloat MaxTargetVelocity { get; set; }
		[Ordinal(15)]  [RED("zAlignmentThreshold")] public CFloat ZAlignmentThreshold { get; set; }

		public gameActionAnimationSlideParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
