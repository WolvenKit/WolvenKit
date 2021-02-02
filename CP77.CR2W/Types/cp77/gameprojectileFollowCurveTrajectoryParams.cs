using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameprojectileFollowCurveTrajectoryParams : gameprojectileTrajectoryParams
	{
		[Ordinal(0)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(1)]  [RED("componentName")] public CName ComponentName { get; set; }
		[Ordinal(2)]  [RED("targetComponent")] public wCHandle<entIPlacedComponent> TargetComponent { get; set; }
		[Ordinal(3)]  [RED("targetPosition")] public Vector4 TargetPosition { get; set; }
		[Ordinal(4)]  [RED("startVelocity")] public CFloat StartVelocity { get; set; }
		[Ordinal(5)]  [RED("linearTimeRatio")] public CFloat LinearTimeRatio { get; set; }
		[Ordinal(6)]  [RED("interpolationTimeRatio")] public CFloat InterpolationTimeRatio { get; set; }
		[Ordinal(7)]  [RED("returnTimeMargin")] public CFloat ReturnTimeMargin { get; set; }
		[Ordinal(8)]  [RED("bendTimeRatio")] public CFloat BendTimeRatio { get; set; }
		[Ordinal(9)]  [RED("bendFactor")] public CFloat BendFactor { get; set; }
		[Ordinal(10)]  [RED("angleInHitPlane")] public CFloat AngleInHitPlane { get; set; }
		[Ordinal(11)]  [RED("angleInVerticalPlane")] public CFloat AngleInVerticalPlane { get; set; }
		[Ordinal(12)]  [RED("shouldRotate")] public CBool ShouldRotate { get; set; }
		[Ordinal(13)]  [RED("halfLeanAngle")] public CFloat HalfLeanAngle { get; set; }
		[Ordinal(14)]  [RED("endLeanAngle")] public CFloat EndLeanAngle { get; set; }
		[Ordinal(15)]  [RED("angleInterpolationDuration")] public CFloat AngleInterpolationDuration { get; set; }
		[Ordinal(16)]  [RED("snapRadius")] public CFloat SnapRadius { get; set; }
		[Ordinal(17)]  [RED("accuracy")] public CFloat Accuracy { get; set; }
		[Ordinal(18)]  [RED("offset")] public Vector4 Offset { get; set; }
		[Ordinal(19)]  [RED("offsetInPlane")] public Vector3 OffsetInPlane { get; set; }
		[Ordinal(20)]  [RED("sendFollowEvent")] public CBool SendFollowEvent { get; set; }

		public gameprojectileFollowCurveTrajectoryParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
