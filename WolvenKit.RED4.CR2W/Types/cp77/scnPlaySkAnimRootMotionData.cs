using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlaySkAnimRootMotionData : CVariable
	{
		[Ordinal(0)] [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(1)] [RED("placementMode")] public CEnum<scnRootMotionAnimPlacementMode> PlacementMode { get; set; }
		[Ordinal(2)] [RED("originMarker")] public scnMarker OriginMarker { get; set; }
		[Ordinal(3)] [RED("originOffset")] public Transform OriginOffset { get; set; }
		[Ordinal(4)] [RED("customBlendInTime")] public CFloat CustomBlendInTime { get; set; }
		[Ordinal(5)] [RED("customBlendInCurve")] public CEnum<scnEasingType> CustomBlendInCurve { get; set; }
		[Ordinal(6)] [RED("removePitchRollRotation")] public CBool RemovePitchRollRotation { get; set; }
		[Ordinal(7)] [RED("meshDissolvingEnabled")] public CBool MeshDissolvingEnabled { get; set; }
		[Ordinal(8)] [RED("vehicleChangePhysicsState")] public CBool VehicleChangePhysicsState { get; set; }
		[Ordinal(9)] [RED("vehicleEnabledPhysicsOnEnd")] public CBool VehicleEnabledPhysicsOnEnd { get; set; }
		[Ordinal(10)] [RED("trajectoryLOD")] public CArray<scnAnimationMotionSample> TrajectoryLOD { get; set; }

		public scnPlaySkAnimRootMotionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
