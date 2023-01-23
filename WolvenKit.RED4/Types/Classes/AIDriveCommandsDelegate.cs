using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIDriveCommandsDelegate : AIbehaviorScriptBehaviorDelegate
	{
		[Ordinal(0)] 
		[RED("useKinematic")] 
		public CBool UseKinematic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("needDriver")] 
		public CBool NeedDriver
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(3)] 
		[RED("secureTimeOut")] 
		public CFloat SecureTimeOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("forcedStartSpeed")] 
		public CFloat ForcedStartSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("stopAtPathEnd")] 
		public CBool StopAtPathEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("driveBackwards")] 
		public CBool DriveBackwards
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("reverseSpline")] 
		public CBool ReverseSpline
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("startFromClosest")] 
		public CBool StartFromClosest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("keepDistanceBool")] 
		public CBool KeepDistanceBool
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("keepDistanceCompanion")] 
		public CWeakHandle<gameObject> KeepDistanceCompanion
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(11)] 
		[RED("keepDistanceDistance")] 
		public CFloat KeepDistanceDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("rubberBandingBool")] 
		public CBool RubberBandingBool
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("rubberBandingTargetRef")] 
		public CWeakHandle<gameObject> RubberBandingTargetRef
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(14)] 
		[RED("rubberBandingMinDistance")] 
		public CFloat RubberBandingMinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("rubberBandingMaxDistance")] 
		public CFloat RubberBandingMaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("rubberBandingStopAndWait")] 
		public CBool RubberBandingStopAndWait
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("rubberBandingTeleportToCatchUp")] 
		public CBool RubberBandingTeleportToCatchUp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(18)] 
		[RED("rubberBandingStayInFront")] 
		public CBool RubberBandingStayInFront
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("driveOnSplineCommand")] 
		public CHandle<AIVehicleOnSplineCommand> DriveOnSplineCommand
		{
			get => GetPropertyValue<CHandle<AIVehicleOnSplineCommand>>();
			set => SetPropertyValue<CHandle<AIVehicleOnSplineCommand>>(value);
		}

		[Ordinal(20)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(21)] 
		[RED("speedInTraffic")] 
		public CFloat SpeedInTraffic
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(23)] 
		[RED("distanceMin")] 
		public CFloat DistanceMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("distanceMax")] 
		public CFloat DistanceMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("stopWhenTargetReached")] 
		public CBool StopWhenTargetReached
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("trafficTryNeighborsForStart")] 
		public CBool TrafficTryNeighborsForStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(27)] 
		[RED("trafficTryNeighborsForEnd")] 
		public CBool TrafficTryNeighborsForEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(28)] 
		[RED("driveFollowCommand")] 
		public CHandle<AIVehicleFollowCommand> DriveFollowCommand
		{
			get => GetPropertyValue<CHandle<AIVehicleFollowCommand>>();
			set => SetPropertyValue<CHandle<AIVehicleFollowCommand>>(value);
		}

		[Ordinal(29)] 
		[RED("driveChaseCommand")] 
		public CHandle<AIVehicleChaseCommand> DriveChaseCommand
		{
			get => GetPropertyValue<CHandle<AIVehicleChaseCommand>>();
			set => SetPropertyValue<CHandle<AIVehicleChaseCommand>>(value);
		}

		[Ordinal(30)] 
		[RED("drivePanicCommand")] 
		public CHandle<AIVehiclePanicCommand> DrivePanicCommand
		{
			get => GetPropertyValue<CHandle<AIVehiclePanicCommand>>();
			set => SetPropertyValue<CHandle<AIVehiclePanicCommand>>(value);
		}

		[Ordinal(31)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(32)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("forceGreenLights")] 
		public CBool ForceGreenLights
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(34)] 
		[RED("portals")] 
		public CHandle<vehiclePortalsList> Portals
		{
			get => GetPropertyValue<CHandle<vehiclePortalsList>>();
			set => SetPropertyValue<CHandle<vehiclePortalsList>>(value);
		}

		[Ordinal(35)] 
		[RED("driveToNodeCommand")] 
		public CHandle<AIVehicleToNodeCommand> DriveToNodeCommand
		{
			get => GetPropertyValue<CHandle<AIVehicleToNodeCommand>>();
			set => SetPropertyValue<CHandle<AIVehicleToNodeCommand>>(value);
		}

		[Ordinal(36)] 
		[RED("driveRacingCommand")] 
		public CHandle<AIVehicleRacingCommand> DriveRacingCommand
		{
			get => GetPropertyValue<CHandle<AIVehicleRacingCommand>>();
			set => SetPropertyValue<CHandle<AIVehicleRacingCommand>>(value);
		}

		[Ordinal(37)] 
		[RED("driveJoinTrafficCommand")] 
		public CHandle<AIVehicleJoinTrafficCommand> DriveJoinTrafficCommand
		{
			get => GetPropertyValue<CHandle<AIVehicleJoinTrafficCommand>>();
			set => SetPropertyValue<CHandle<AIVehicleJoinTrafficCommand>>(value);
		}

		public AIDriveCommandsDelegate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
