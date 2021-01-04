using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnPlaySkAnimRootMotionData : CVariable
	{
		[Ordinal(0)]  [RED("customBlendInCurve")] public CEnum<scnEasingType> CustomBlendInCurve { get; set; }
		[Ordinal(1)]  [RED("customBlendInTime")] public CFloat CustomBlendInTime { get; set; }
		[Ordinal(2)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(3)]  [RED("meshDissolvingEnabled")] public CBool MeshDissolvingEnabled { get; set; }
		[Ordinal(4)]  [RED("originMarker")] public scnMarker OriginMarker { get; set; }
		[Ordinal(5)]  [RED("originOffset")] public Transform OriginOffset { get; set; }
		[Ordinal(6)]  [RED("placementMode")] public CEnum<scnRootMotionAnimPlacementMode> PlacementMode { get; set; }
		[Ordinal(7)]  [RED("removePitchRollRotation")] public CBool RemovePitchRollRotation { get; set; }
		[Ordinal(8)]  [RED("trajectoryLOD")] public CArray<scnAnimationMotionSample> TrajectoryLOD { get; set; }
		[Ordinal(9)]  [RED("vehicleChangePhysicsState")] public CBool VehicleChangePhysicsState { get; set; }
		[Ordinal(10)]  [RED("vehicleEnabledPhysicsOnEnd")] public CBool VehicleEnabledPhysicsOnEnd { get; set; }

		public scnPlaySkAnimRootMotionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
