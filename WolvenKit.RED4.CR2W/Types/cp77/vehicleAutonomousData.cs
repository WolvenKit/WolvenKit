using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleAutonomousData : ISerializable
	{
		private wCHandle<vehicleBaseObject> _owner;
		private CBool _useKinematic;
		private CBool _needDriver;
		private wCHandle<gameObject> _targetObjToReach;
		private wCHandle<gameObject> _targetObjToFollow;
		private NodeRef _targetRef;
		private NodeRef _splineRef;
		private NodeRef _splineRefBackwards;
		private gameEntityReference _vehicleRef;
		private Vector3 _targetPosition;
		private TweakDBID _drivingID;
		private CFloat _distanceMin;
		private CFloat _distanceMax;
		private CBool _wantToStop;
		private CBool _stopHasReachedTarget;
		private CBool _driveBackwards;
		private CBool _reverseSpline;
		private CBool _startFromClosest;
		private CBool _canClearActions;
		private CBool _keepDistanceParamBool;
		private wCHandle<gameObject> _keepDistanceParamCompanion;
		private CFloat _keepDistanceParamDistance;
		private CBool _rubberBandingBool;
		private wCHandle<gameObject> _rubberBandingTargetRef;
		private CFloat _rubberBandingMinDistance;
		private CFloat _rubberBandingMaxDistance;
		private CBool _rubberBandingStopAndWait;
		private CBool _rubberBandingTeleportToCatchUp;
		private CBool _rubberBandingStayInFront;
		private CFloat _secureTimeOut;
		private CHandle<vehiclePortalsList> _portalsList;
		private CBool _trafficTryNeighborsForStart;
		private CBool _trafficTryNeighborsForEnd;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<vehicleBaseObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("useKinematic")] 
		public CBool UseKinematic
		{
			get => GetProperty(ref _useKinematic);
			set => SetProperty(ref _useKinematic, value);
		}

		[Ordinal(2)] 
		[RED("needDriver")] 
		public CBool NeedDriver
		{
			get => GetProperty(ref _needDriver);
			set => SetProperty(ref _needDriver, value);
		}

		[Ordinal(3)] 
		[RED("targetObjToReach")] 
		public wCHandle<gameObject> TargetObjToReach
		{
			get => GetProperty(ref _targetObjToReach);
			set => SetProperty(ref _targetObjToReach, value);
		}

		[Ordinal(4)] 
		[RED("targetObjToFollow")] 
		public wCHandle<gameObject> TargetObjToFollow
		{
			get => GetProperty(ref _targetObjToFollow);
			set => SetProperty(ref _targetObjToFollow, value);
		}

		[Ordinal(5)] 
		[RED("targetRef")] 
		public NodeRef TargetRef
		{
			get => GetProperty(ref _targetRef);
			set => SetProperty(ref _targetRef, value);
		}

		[Ordinal(6)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetProperty(ref _splineRef);
			set => SetProperty(ref _splineRef, value);
		}

		[Ordinal(7)] 
		[RED("splineRefBackwards")] 
		public NodeRef SplineRefBackwards
		{
			get => GetProperty(ref _splineRefBackwards);
			set => SetProperty(ref _splineRefBackwards, value);
		}

		[Ordinal(8)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(9)] 
		[RED("targetPosition")] 
		public Vector3 TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(10)] 
		[RED("drivingID")] 
		public TweakDBID DrivingID
		{
			get => GetProperty(ref _drivingID);
			set => SetProperty(ref _drivingID, value);
		}

		[Ordinal(11)] 
		[RED("distanceMin")] 
		public CFloat DistanceMin
		{
			get => GetProperty(ref _distanceMin);
			set => SetProperty(ref _distanceMin, value);
		}

		[Ordinal(12)] 
		[RED("distanceMax")] 
		public CFloat DistanceMax
		{
			get => GetProperty(ref _distanceMax);
			set => SetProperty(ref _distanceMax, value);
		}

		[Ordinal(13)] 
		[RED("wantToStop")] 
		public CBool WantToStop
		{
			get => GetProperty(ref _wantToStop);
			set => SetProperty(ref _wantToStop, value);
		}

		[Ordinal(14)] 
		[RED("stopHasReachedTarget")] 
		public CBool StopHasReachedTarget
		{
			get => GetProperty(ref _stopHasReachedTarget);
			set => SetProperty(ref _stopHasReachedTarget, value);
		}

		[Ordinal(15)] 
		[RED("driveBackwards")] 
		public CBool DriveBackwards
		{
			get => GetProperty(ref _driveBackwards);
			set => SetProperty(ref _driveBackwards, value);
		}

		[Ordinal(16)] 
		[RED("reverseSpline")] 
		public CBool ReverseSpline
		{
			get => GetProperty(ref _reverseSpline);
			set => SetProperty(ref _reverseSpline, value);
		}

		[Ordinal(17)] 
		[RED("startFromClosest")] 
		public CBool StartFromClosest
		{
			get => GetProperty(ref _startFromClosest);
			set => SetProperty(ref _startFromClosest, value);
		}

		[Ordinal(18)] 
		[RED("canClearActions")] 
		public CBool CanClearActions
		{
			get => GetProperty(ref _canClearActions);
			set => SetProperty(ref _canClearActions, value);
		}

		[Ordinal(19)] 
		[RED("keepDistanceParamBool")] 
		public CBool KeepDistanceParamBool
		{
			get => GetProperty(ref _keepDistanceParamBool);
			set => SetProperty(ref _keepDistanceParamBool, value);
		}

		[Ordinal(20)] 
		[RED("keepDistanceParamCompanion")] 
		public wCHandle<gameObject> KeepDistanceParamCompanion
		{
			get => GetProperty(ref _keepDistanceParamCompanion);
			set => SetProperty(ref _keepDistanceParamCompanion, value);
		}

		[Ordinal(21)] 
		[RED("keepDistanceParamDistance")] 
		public CFloat KeepDistanceParamDistance
		{
			get => GetProperty(ref _keepDistanceParamDistance);
			set => SetProperty(ref _keepDistanceParamDistance, value);
		}

		[Ordinal(22)] 
		[RED("rubberBandingBool")] 
		public CBool RubberBandingBool
		{
			get => GetProperty(ref _rubberBandingBool);
			set => SetProperty(ref _rubberBandingBool, value);
		}

		[Ordinal(23)] 
		[RED("rubberBandingTargetRef")] 
		public wCHandle<gameObject> RubberBandingTargetRef
		{
			get => GetProperty(ref _rubberBandingTargetRef);
			set => SetProperty(ref _rubberBandingTargetRef, value);
		}

		[Ordinal(24)] 
		[RED("rubberBandingMinDistance")] 
		public CFloat RubberBandingMinDistance
		{
			get => GetProperty(ref _rubberBandingMinDistance);
			set => SetProperty(ref _rubberBandingMinDistance, value);
		}

		[Ordinal(25)] 
		[RED("rubberBandingMaxDistance")] 
		public CFloat RubberBandingMaxDistance
		{
			get => GetProperty(ref _rubberBandingMaxDistance);
			set => SetProperty(ref _rubberBandingMaxDistance, value);
		}

		[Ordinal(26)] 
		[RED("rubberBandingStopAndWait")] 
		public CBool RubberBandingStopAndWait
		{
			get => GetProperty(ref _rubberBandingStopAndWait);
			set => SetProperty(ref _rubberBandingStopAndWait, value);
		}

		[Ordinal(27)] 
		[RED("rubberBandingTeleportToCatchUp")] 
		public CBool RubberBandingTeleportToCatchUp
		{
			get => GetProperty(ref _rubberBandingTeleportToCatchUp);
			set => SetProperty(ref _rubberBandingTeleportToCatchUp, value);
		}

		[Ordinal(28)] 
		[RED("rubberBandingStayInFront")] 
		public CBool RubberBandingStayInFront
		{
			get => GetProperty(ref _rubberBandingStayInFront);
			set => SetProperty(ref _rubberBandingStayInFront, value);
		}

		[Ordinal(29)] 
		[RED("secureTimeOut")] 
		public CFloat SecureTimeOut
		{
			get => GetProperty(ref _secureTimeOut);
			set => SetProperty(ref _secureTimeOut, value);
		}

		[Ordinal(30)] 
		[RED("portalsList")] 
		public CHandle<vehiclePortalsList> PortalsList
		{
			get => GetProperty(ref _portalsList);
			set => SetProperty(ref _portalsList, value);
		}

		[Ordinal(31)] 
		[RED("trafficTryNeighborsForStart")] 
		public CBool TrafficTryNeighborsForStart
		{
			get => GetProperty(ref _trafficTryNeighborsForStart);
			set => SetProperty(ref _trafficTryNeighborsForStart, value);
		}

		[Ordinal(32)] 
		[RED("trafficTryNeighborsForEnd")] 
		public CBool TrafficTryNeighborsForEnd
		{
			get => GetProperty(ref _trafficTryNeighborsForEnd);
			set => SetProperty(ref _trafficTryNeighborsForEnd, value);
		}

		public vehicleAutonomousData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
