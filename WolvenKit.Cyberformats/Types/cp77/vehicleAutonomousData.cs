using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class vehicleAutonomousData : ISerializable
	{
		[Ordinal(0)] [RED("owner")] public wCHandle<vehicleBaseObject> Owner { get; set; }
		[Ordinal(1)] [RED("useKinematic")] public CBool UseKinematic { get; set; }
		[Ordinal(2)] [RED("needDriver")] public CBool NeedDriver { get; set; }
		[Ordinal(3)] [RED("targetObjToReach")] public wCHandle<gameObject> TargetObjToReach { get; set; }
		[Ordinal(4)] [RED("targetObjToFollow")] public wCHandle<gameObject> TargetObjToFollow { get; set; }
		[Ordinal(5)] [RED("targetRef")] public NodeRef TargetRef { get; set; }
		[Ordinal(6)] [RED("splineRef")] public NodeRef SplineRef { get; set; }
		[Ordinal(7)] [RED("splineRefBackwards")] public NodeRef SplineRefBackwards { get; set; }
		[Ordinal(8)] [RED("vehicleRef")] public gameEntityReference VehicleRef { get; set; }
		[Ordinal(9)] [RED("targetPosition")] public Vector3 TargetPosition { get; set; }
		[Ordinal(10)] [RED("drivingID")] public TweakDBID DrivingID { get; set; }
		[Ordinal(11)] [RED("distanceMin")] public CFloat DistanceMin { get; set; }
		[Ordinal(12)] [RED("distanceMax")] public CFloat DistanceMax { get; set; }
		[Ordinal(13)] [RED("wantToStop")] public CBool WantToStop { get; set; }
		[Ordinal(14)] [RED("stopHasReachedTarget")] public CBool StopHasReachedTarget { get; set; }
		[Ordinal(15)] [RED("driveBackwards")] public CBool DriveBackwards { get; set; }
		[Ordinal(16)] [RED("reverseSpline")] public CBool ReverseSpline { get; set; }
		[Ordinal(17)] [RED("startFromClosest")] public CBool StartFromClosest { get; set; }
		[Ordinal(18)] [RED("canClearActions")] public CBool CanClearActions { get; set; }
		[Ordinal(19)] [RED("keepDistanceParamBool")] public CBool KeepDistanceParamBool { get; set; }
		[Ordinal(20)] [RED("keepDistanceParamCompanion")] public wCHandle<gameObject> KeepDistanceParamCompanion { get; set; }
		[Ordinal(21)] [RED("keepDistanceParamDistance")] public CFloat KeepDistanceParamDistance { get; set; }
		[Ordinal(22)] [RED("rubberBandingBool")] public CBool RubberBandingBool { get; set; }
		[Ordinal(23)] [RED("rubberBandingTargetRef")] public wCHandle<gameObject> RubberBandingTargetRef { get; set; }
		[Ordinal(24)] [RED("rubberBandingMinDistance")] public CFloat RubberBandingMinDistance { get; set; }
		[Ordinal(25)] [RED("rubberBandingMaxDistance")] public CFloat RubberBandingMaxDistance { get; set; }
		[Ordinal(26)] [RED("rubberBandingStopAndWait")] public CBool RubberBandingStopAndWait { get; set; }
		[Ordinal(27)] [RED("rubberBandingTeleportToCatchUp")] public CBool RubberBandingTeleportToCatchUp { get; set; }
		[Ordinal(28)] [RED("rubberBandingStayInFront")] public CBool RubberBandingStayInFront { get; set; }
		[Ordinal(29)] [RED("secureTimeOut")] public CFloat SecureTimeOut { get; set; }
		[Ordinal(30)] [RED("portalsList")] public CHandle<vehiclePortalsList> PortalsList { get; set; }
		[Ordinal(31)] [RED("trafficTryNeighborsForStart")] public CBool TrafficTryNeighborsForStart { get; set; }
		[Ordinal(32)] [RED("trafficTryNeighborsForEnd")] public CBool TrafficTryNeighborsForEnd { get; set; }

		public vehicleAutonomousData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
