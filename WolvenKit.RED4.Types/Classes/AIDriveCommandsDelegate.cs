using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIDriveCommandsDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CBool _useKinematic;
		private CBool _needDriver;
		private NodeRef _splineRef;
		private CFloat _secureTimeOut;
		private CFloat _forcedStartSpeed;
		private CBool _stopAtPathEnd;
		private CBool _driveBackwards;
		private CBool _reverseSpline;
		private CBool _startFromClosest;
		private CBool _keepDistanceBool;
		private CWeakHandle<gameObject> _keepDistanceCompanion;
		private CFloat _keepDistanceDistance;
		private CBool _rubberBandingBool;
		private CWeakHandle<gameObject> _rubberBandingTargetRef;
		private CFloat _rubberBandingMinDistance;
		private CFloat _rubberBandingMaxDistance;
		private CBool _rubberBandingStopAndWait;
		private CBool _rubberBandingTeleportToCatchUp;
		private CBool _rubberBandingStayInFront;
		private CBool _allowStubMovement;
		private CHandle<AIVehicleOnSplineCommand> _driveOnSplineCommand;
		private CBool _useTraffic;
		private CFloat _speedInTraffic;
		private CWeakHandle<gameObject> _target;
		private CFloat _distanceMin;
		private CFloat _distanceMax;
		private CBool _stopWhenTargetReached;
		private CBool _trafficTryNeighborsForStart;
		private CBool _trafficTryNeighborsForEnd;
		private CHandle<AIVehicleFollowCommand> _driveFollowCommand;
		private NodeRef _nodeRef;
		private CBool _isPlayer;
		private CBool _forceGreenLights;
		private CHandle<vehiclePortalsList> _portals;
		private CHandle<AIVehicleToNodeCommand> _driveToNodeCommand;
		private CHandle<AIVehicleRacingCommand> _driveRacingCommand;
		private CHandle<AIVehicleJoinTrafficCommand> _driveJoinTrafficCommand;

		[Ordinal(0)] 
		[RED("useKinematic")] 
		public CBool UseKinematic
		{
			get => GetProperty(ref _useKinematic);
			set => SetProperty(ref _useKinematic, value);
		}

		[Ordinal(1)] 
		[RED("needDriver")] 
		public CBool NeedDriver
		{
			get => GetProperty(ref _needDriver);
			set => SetProperty(ref _needDriver, value);
		}

		[Ordinal(2)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetProperty(ref _splineRef);
			set => SetProperty(ref _splineRef, value);
		}

		[Ordinal(3)] 
		[RED("secureTimeOut")] 
		public CFloat SecureTimeOut
		{
			get => GetProperty(ref _secureTimeOut);
			set => SetProperty(ref _secureTimeOut, value);
		}

		[Ordinal(4)] 
		[RED("forcedStartSpeed")] 
		public CFloat ForcedStartSpeed
		{
			get => GetProperty(ref _forcedStartSpeed);
			set => SetProperty(ref _forcedStartSpeed, value);
		}

		[Ordinal(5)] 
		[RED("stopAtPathEnd")] 
		public CBool StopAtPathEnd
		{
			get => GetProperty(ref _stopAtPathEnd);
			set => SetProperty(ref _stopAtPathEnd, value);
		}

		[Ordinal(6)] 
		[RED("driveBackwards")] 
		public CBool DriveBackwards
		{
			get => GetProperty(ref _driveBackwards);
			set => SetProperty(ref _driveBackwards, value);
		}

		[Ordinal(7)] 
		[RED("reverseSpline")] 
		public CBool ReverseSpline
		{
			get => GetProperty(ref _reverseSpline);
			set => SetProperty(ref _reverseSpline, value);
		}

		[Ordinal(8)] 
		[RED("startFromClosest")] 
		public CBool StartFromClosest
		{
			get => GetProperty(ref _startFromClosest);
			set => SetProperty(ref _startFromClosest, value);
		}

		[Ordinal(9)] 
		[RED("keepDistanceBool")] 
		public CBool KeepDistanceBool
		{
			get => GetProperty(ref _keepDistanceBool);
			set => SetProperty(ref _keepDistanceBool, value);
		}

		[Ordinal(10)] 
		[RED("keepDistanceCompanion")] 
		public CWeakHandle<gameObject> KeepDistanceCompanion
		{
			get => GetProperty(ref _keepDistanceCompanion);
			set => SetProperty(ref _keepDistanceCompanion, value);
		}

		[Ordinal(11)] 
		[RED("keepDistanceDistance")] 
		public CFloat KeepDistanceDistance
		{
			get => GetProperty(ref _keepDistanceDistance);
			set => SetProperty(ref _keepDistanceDistance, value);
		}

		[Ordinal(12)] 
		[RED("rubberBandingBool")] 
		public CBool RubberBandingBool
		{
			get => GetProperty(ref _rubberBandingBool);
			set => SetProperty(ref _rubberBandingBool, value);
		}

		[Ordinal(13)] 
		[RED("rubberBandingTargetRef")] 
		public CWeakHandle<gameObject> RubberBandingTargetRef
		{
			get => GetProperty(ref _rubberBandingTargetRef);
			set => SetProperty(ref _rubberBandingTargetRef, value);
		}

		[Ordinal(14)] 
		[RED("rubberBandingMinDistance")] 
		public CFloat RubberBandingMinDistance
		{
			get => GetProperty(ref _rubberBandingMinDistance);
			set => SetProperty(ref _rubberBandingMinDistance, value);
		}

		[Ordinal(15)] 
		[RED("rubberBandingMaxDistance")] 
		public CFloat RubberBandingMaxDistance
		{
			get => GetProperty(ref _rubberBandingMaxDistance);
			set => SetProperty(ref _rubberBandingMaxDistance, value);
		}

		[Ordinal(16)] 
		[RED("rubberBandingStopAndWait")] 
		public CBool RubberBandingStopAndWait
		{
			get => GetProperty(ref _rubberBandingStopAndWait);
			set => SetProperty(ref _rubberBandingStopAndWait, value);
		}

		[Ordinal(17)] 
		[RED("rubberBandingTeleportToCatchUp")] 
		public CBool RubberBandingTeleportToCatchUp
		{
			get => GetProperty(ref _rubberBandingTeleportToCatchUp);
			set => SetProperty(ref _rubberBandingTeleportToCatchUp, value);
		}

		[Ordinal(18)] 
		[RED("rubberBandingStayInFront")] 
		public CBool RubberBandingStayInFront
		{
			get => GetProperty(ref _rubberBandingStayInFront);
			set => SetProperty(ref _rubberBandingStayInFront, value);
		}

		[Ordinal(19)] 
		[RED("allowStubMovement")] 
		public CBool AllowStubMovement
		{
			get => GetProperty(ref _allowStubMovement);
			set => SetProperty(ref _allowStubMovement, value);
		}

		[Ordinal(20)] 
		[RED("driveOnSplineCommand")] 
		public CHandle<AIVehicleOnSplineCommand> DriveOnSplineCommand
		{
			get => GetProperty(ref _driveOnSplineCommand);
			set => SetProperty(ref _driveOnSplineCommand, value);
		}

		[Ordinal(21)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get => GetProperty(ref _useTraffic);
			set => SetProperty(ref _useTraffic, value);
		}

		[Ordinal(22)] 
		[RED("speedInTraffic")] 
		public CFloat SpeedInTraffic
		{
			get => GetProperty(ref _speedInTraffic);
			set => SetProperty(ref _speedInTraffic, value);
		}

		[Ordinal(23)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(24)] 
		[RED("distanceMin")] 
		public CFloat DistanceMin
		{
			get => GetProperty(ref _distanceMin);
			set => SetProperty(ref _distanceMin, value);
		}

		[Ordinal(25)] 
		[RED("distanceMax")] 
		public CFloat DistanceMax
		{
			get => GetProperty(ref _distanceMax);
			set => SetProperty(ref _distanceMax, value);
		}

		[Ordinal(26)] 
		[RED("stopWhenTargetReached")] 
		public CBool StopWhenTargetReached
		{
			get => GetProperty(ref _stopWhenTargetReached);
			set => SetProperty(ref _stopWhenTargetReached, value);
		}

		[Ordinal(27)] 
		[RED("trafficTryNeighborsForStart")] 
		public CBool TrafficTryNeighborsForStart
		{
			get => GetProperty(ref _trafficTryNeighborsForStart);
			set => SetProperty(ref _trafficTryNeighborsForStart, value);
		}

		[Ordinal(28)] 
		[RED("trafficTryNeighborsForEnd")] 
		public CBool TrafficTryNeighborsForEnd
		{
			get => GetProperty(ref _trafficTryNeighborsForEnd);
			set => SetProperty(ref _trafficTryNeighborsForEnd, value);
		}

		[Ordinal(29)] 
		[RED("driveFollowCommand")] 
		public CHandle<AIVehicleFollowCommand> DriveFollowCommand
		{
			get => GetProperty(ref _driveFollowCommand);
			set => SetProperty(ref _driveFollowCommand, value);
		}

		[Ordinal(30)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(31)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(32)] 
		[RED("forceGreenLights")] 
		public CBool ForceGreenLights
		{
			get => GetProperty(ref _forceGreenLights);
			set => SetProperty(ref _forceGreenLights, value);
		}

		[Ordinal(33)] 
		[RED("portals")] 
		public CHandle<vehiclePortalsList> Portals
		{
			get => GetProperty(ref _portals);
			set => SetProperty(ref _portals, value);
		}

		[Ordinal(34)] 
		[RED("driveToNodeCommand")] 
		public CHandle<AIVehicleToNodeCommand> DriveToNodeCommand
		{
			get => GetProperty(ref _driveToNodeCommand);
			set => SetProperty(ref _driveToNodeCommand, value);
		}

		[Ordinal(35)] 
		[RED("driveRacingCommand")] 
		public CHandle<AIVehicleRacingCommand> DriveRacingCommand
		{
			get => GetProperty(ref _driveRacingCommand);
			set => SetProperty(ref _driveRacingCommand, value);
		}

		[Ordinal(36)] 
		[RED("driveJoinTrafficCommand")] 
		public CHandle<AIVehicleJoinTrafficCommand> DriveJoinTrafficCommand
		{
			get => GetProperty(ref _driveJoinTrafficCommand);
			set => SetProperty(ref _driveJoinTrafficCommand, value);
		}
	}
}
