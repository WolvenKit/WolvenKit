using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIDriveCommandsDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)]  [RED("useKinematic")] public CBool UseKinematic { get; set; }
		[Ordinal(1)]  [RED("needDriver")] public CBool NeedDriver { get; set; }
		[Ordinal(2)]  [RED("splineRef")] public NodeRef SplineRef { get; set; }
		[Ordinal(3)]  [RED("secureTimeOut")] public CFloat SecureTimeOut { get; set; }
		[Ordinal(4)]  [RED("forcedStartSpeed")] public CFloat ForcedStartSpeed { get; set; }
		[Ordinal(5)]  [RED("stopAtPathEnd")] public CBool StopAtPathEnd { get; set; }
		[Ordinal(6)]  [RED("driveBackwards")] public CBool DriveBackwards { get; set; }
		[Ordinal(7)]  [RED("reverseSpline")] public CBool ReverseSpline { get; set; }
		[Ordinal(8)]  [RED("startFromClosest")] public CBool StartFromClosest { get; set; }
		[Ordinal(9)]  [RED("keepDistanceBool")] public CBool KeepDistanceBool { get; set; }
		[Ordinal(10)]  [RED("keepDistanceCompanion")] public wCHandle<gameObject> KeepDistanceCompanion { get; set; }
		[Ordinal(11)]  [RED("keepDistanceDistance")] public CFloat KeepDistanceDistance { get; set; }
		[Ordinal(12)]  [RED("rubberBandingBool")] public CBool RubberBandingBool { get; set; }
		[Ordinal(13)]  [RED("rubberBandingTargetRef")] public wCHandle<gameObject> RubberBandingTargetRef { get; set; }
		[Ordinal(14)]  [RED("rubberBandingMinDistance")] public CFloat RubberBandingMinDistance { get; set; }
		[Ordinal(15)]  [RED("rubberBandingMaxDistance")] public CFloat RubberBandingMaxDistance { get; set; }
		[Ordinal(16)]  [RED("rubberBandingStopAndWait")] public CBool RubberBandingStopAndWait { get; set; }
		[Ordinal(17)]  [RED("rubberBandingTeleportToCatchUp")] public CBool RubberBandingTeleportToCatchUp { get; set; }
		[Ordinal(18)]  [RED("rubberBandingStayInFront")] public CBool RubberBandingStayInFront { get; set; }
		[Ordinal(19)]  [RED("allowStubMovement")] public CBool AllowStubMovement { get; set; }
		[Ordinal(20)]  [RED("driveOnSplineCommand")] public CHandle<AIVehicleOnSplineCommand> DriveOnSplineCommand { get; set; }
		[Ordinal(21)]  [RED("useTraffic")] public CBool UseTraffic { get; set; }
		[Ordinal(22)]  [RED("speedInTraffic")] public CFloat SpeedInTraffic { get; set; }
		[Ordinal(23)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(24)]  [RED("distanceMin")] public CFloat DistanceMin { get; set; }
		[Ordinal(25)]  [RED("distanceMax")] public CFloat DistanceMax { get; set; }
		[Ordinal(26)]  [RED("stopWhenTargetReached")] public CBool StopWhenTargetReached { get; set; }
		[Ordinal(27)]  [RED("trafficTryNeighborsForStart")] public CBool TrafficTryNeighborsForStart { get; set; }
		[Ordinal(28)]  [RED("trafficTryNeighborsForEnd")] public CBool TrafficTryNeighborsForEnd { get; set; }
		[Ordinal(29)]  [RED("driveFollowCommand")] public CHandle<AIVehicleFollowCommand> DriveFollowCommand { get; set; }
		[Ordinal(30)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(31)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(32)]  [RED("forceGreenLights")] public CBool ForceGreenLights { get; set; }
		[Ordinal(33)]  [RED("portals")] public CHandle<vehiclePortalsList> Portals { get; set; }
		[Ordinal(34)]  [RED("driveToNodeCommand")] public CHandle<AIVehicleToNodeCommand> DriveToNodeCommand { get; set; }
		[Ordinal(35)]  [RED("driveRacingCommand")] public CHandle<AIVehicleRacingCommand> DriveRacingCommand { get; set; }
		[Ordinal(36)]  [RED("driveJoinTrafficCommand")] public CHandle<AIVehicleJoinTrafficCommand> DriveJoinTrafficCommand { get; set; }

		public AIDriveCommandsDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
