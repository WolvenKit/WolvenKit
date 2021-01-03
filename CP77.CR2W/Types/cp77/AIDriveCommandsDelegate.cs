using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIDriveCommandsDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)]  [RED("allowStubMovement")] public CBool AllowStubMovement { get; set; }
		[Ordinal(1)]  [RED("distanceMax")] public CFloat DistanceMax { get; set; }
		[Ordinal(2)]  [RED("distanceMin")] public CFloat DistanceMin { get; set; }
		[Ordinal(3)]  [RED("driveBackwards")] public CBool DriveBackwards { get; set; }
		[Ordinal(4)]  [RED("driveFollowCommand")] public CHandle<AIVehicleFollowCommand> DriveFollowCommand { get; set; }
		[Ordinal(5)]  [RED("driveJoinTrafficCommand")] public CHandle<AIVehicleJoinTrafficCommand> DriveJoinTrafficCommand { get; set; }
		[Ordinal(6)]  [RED("driveOnSplineCommand")] public CHandle<AIVehicleOnSplineCommand> DriveOnSplineCommand { get; set; }
		[Ordinal(7)]  [RED("driveRacingCommand")] public CHandle<AIVehicleRacingCommand> DriveRacingCommand { get; set; }
		[Ordinal(8)]  [RED("driveToNodeCommand")] public CHandle<AIVehicleToNodeCommand> DriveToNodeCommand { get; set; }
		[Ordinal(9)]  [RED("forceGreenLights")] public CBool ForceGreenLights { get; set; }
		[Ordinal(10)]  [RED("forcedStartSpeed")] public CFloat ForcedStartSpeed { get; set; }
		[Ordinal(11)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(12)]  [RED("keepDistanceBool")] public CBool KeepDistanceBool { get; set; }
		[Ordinal(13)]  [RED("keepDistanceCompanion")] public wCHandle<gameObject> KeepDistanceCompanion { get; set; }
		[Ordinal(14)]  [RED("keepDistanceDistance")] public CFloat KeepDistanceDistance { get; set; }
		[Ordinal(15)]  [RED("needDriver")] public CBool NeedDriver { get; set; }
		[Ordinal(16)]  [RED("nodeRef")] public NodeRef NodeRef { get; set; }
		[Ordinal(17)]  [RED("portals")] public CHandle<vehiclePortalsList> Portals { get; set; }
		[Ordinal(18)]  [RED("reverseSpline")] public CBool ReverseSpline { get; set; }
		[Ordinal(19)]  [RED("rubberBandingBool")] public CBool RubberBandingBool { get; set; }
		[Ordinal(20)]  [RED("rubberBandingMaxDistance")] public CFloat RubberBandingMaxDistance { get; set; }
		[Ordinal(21)]  [RED("rubberBandingMinDistance")] public CFloat RubberBandingMinDistance { get; set; }
		[Ordinal(22)]  [RED("rubberBandingStayInFront")] public CBool RubberBandingStayInFront { get; set; }
		[Ordinal(23)]  [RED("rubberBandingStopAndWait")] public CBool RubberBandingStopAndWait { get; set; }
		[Ordinal(24)]  [RED("rubberBandingTargetRef")] public wCHandle<gameObject> RubberBandingTargetRef { get; set; }
		[Ordinal(25)]  [RED("rubberBandingTeleportToCatchUp")] public CBool RubberBandingTeleportToCatchUp { get; set; }
		[Ordinal(26)]  [RED("secureTimeOut")] public CFloat SecureTimeOut { get; set; }
		[Ordinal(27)]  [RED("speedInTraffic")] public CFloat SpeedInTraffic { get; set; }
		[Ordinal(28)]  [RED("splineRef")] public NodeRef SplineRef { get; set; }
		[Ordinal(29)]  [RED("startFromClosest")] public CBool StartFromClosest { get; set; }
		[Ordinal(30)]  [RED("stopAtPathEnd")] public CBool StopAtPathEnd { get; set; }
		[Ordinal(31)]  [RED("stopWhenTargetReached")] public CBool StopWhenTargetReached { get; set; }
		[Ordinal(32)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(33)]  [RED("trafficTryNeighborsForEnd")] public CBool TrafficTryNeighborsForEnd { get; set; }
		[Ordinal(34)]  [RED("trafficTryNeighborsForStart")] public CBool TrafficTryNeighborsForStart { get; set; }
		[Ordinal(35)]  [RED("useKinematic")] public CBool UseKinematic { get; set; }
		[Ordinal(36)]  [RED("useTraffic")] public CBool UseTraffic { get; set; }

		public AIDriveCommandsDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
