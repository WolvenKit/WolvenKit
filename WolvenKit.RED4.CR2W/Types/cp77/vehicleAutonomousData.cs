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
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<vehicleBaseObject>) CR2WTypeManager.Create("whandle:vehicleBaseObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("useKinematic")] 
		public CBool UseKinematic
		{
			get
			{
				if (_useKinematic == null)
				{
					_useKinematic = (CBool) CR2WTypeManager.Create("Bool", "useKinematic", cr2w, this);
				}
				return _useKinematic;
			}
			set
			{
				if (_useKinematic == value)
				{
					return;
				}
				_useKinematic = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("needDriver")] 
		public CBool NeedDriver
		{
			get
			{
				if (_needDriver == null)
				{
					_needDriver = (CBool) CR2WTypeManager.Create("Bool", "needDriver", cr2w, this);
				}
				return _needDriver;
			}
			set
			{
				if (_needDriver == value)
				{
					return;
				}
				_needDriver = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("targetObjToReach")] 
		public wCHandle<gameObject> TargetObjToReach
		{
			get
			{
				if (_targetObjToReach == null)
				{
					_targetObjToReach = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "targetObjToReach", cr2w, this);
				}
				return _targetObjToReach;
			}
			set
			{
				if (_targetObjToReach == value)
				{
					return;
				}
				_targetObjToReach = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("targetObjToFollow")] 
		public wCHandle<gameObject> TargetObjToFollow
		{
			get
			{
				if (_targetObjToFollow == null)
				{
					_targetObjToFollow = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "targetObjToFollow", cr2w, this);
				}
				return _targetObjToFollow;
			}
			set
			{
				if (_targetObjToFollow == value)
				{
					return;
				}
				_targetObjToFollow = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("targetRef")] 
		public NodeRef TargetRef
		{
			get
			{
				if (_targetRef == null)
				{
					_targetRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "targetRef", cr2w, this);
				}
				return _targetRef;
			}
			set
			{
				if (_targetRef == value)
				{
					return;
				}
				_targetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get
			{
				if (_splineRef == null)
				{
					_splineRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "splineRef", cr2w, this);
				}
				return _splineRef;
			}
			set
			{
				if (_splineRef == value)
				{
					return;
				}
				_splineRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("splineRefBackwards")] 
		public NodeRef SplineRefBackwards
		{
			get
			{
				if (_splineRefBackwards == null)
				{
					_splineRefBackwards = (NodeRef) CR2WTypeManager.Create("NodeRef", "splineRefBackwards", cr2w, this);
				}
				return _splineRefBackwards;
			}
			set
			{
				if (_splineRefBackwards == value)
				{
					return;
				}
				_splineRefBackwards = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get
			{
				if (_vehicleRef == null)
				{
					_vehicleRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "vehicleRef", cr2w, this);
				}
				return _vehicleRef;
			}
			set
			{
				if (_vehicleRef == value)
				{
					return;
				}
				_vehicleRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("targetPosition")] 
		public Vector3 TargetPosition
		{
			get
			{
				if (_targetPosition == null)
				{
					_targetPosition = (Vector3) CR2WTypeManager.Create("Vector3", "targetPosition", cr2w, this);
				}
				return _targetPosition;
			}
			set
			{
				if (_targetPosition == value)
				{
					return;
				}
				_targetPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("drivingID")] 
		public TweakDBID DrivingID
		{
			get
			{
				if (_drivingID == null)
				{
					_drivingID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "drivingID", cr2w, this);
				}
				return _drivingID;
			}
			set
			{
				if (_drivingID == value)
				{
					return;
				}
				_drivingID = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("distanceMin")] 
		public CFloat DistanceMin
		{
			get
			{
				if (_distanceMin == null)
				{
					_distanceMin = (CFloat) CR2WTypeManager.Create("Float", "distanceMin", cr2w, this);
				}
				return _distanceMin;
			}
			set
			{
				if (_distanceMin == value)
				{
					return;
				}
				_distanceMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("distanceMax")] 
		public CFloat DistanceMax
		{
			get
			{
				if (_distanceMax == null)
				{
					_distanceMax = (CFloat) CR2WTypeManager.Create("Float", "distanceMax", cr2w, this);
				}
				return _distanceMax;
			}
			set
			{
				if (_distanceMax == value)
				{
					return;
				}
				_distanceMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("wantToStop")] 
		public CBool WantToStop
		{
			get
			{
				if (_wantToStop == null)
				{
					_wantToStop = (CBool) CR2WTypeManager.Create("Bool", "wantToStop", cr2w, this);
				}
				return _wantToStop;
			}
			set
			{
				if (_wantToStop == value)
				{
					return;
				}
				_wantToStop = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("stopHasReachedTarget")] 
		public CBool StopHasReachedTarget
		{
			get
			{
				if (_stopHasReachedTarget == null)
				{
					_stopHasReachedTarget = (CBool) CR2WTypeManager.Create("Bool", "stopHasReachedTarget", cr2w, this);
				}
				return _stopHasReachedTarget;
			}
			set
			{
				if (_stopHasReachedTarget == value)
				{
					return;
				}
				_stopHasReachedTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("driveBackwards")] 
		public CBool DriveBackwards
		{
			get
			{
				if (_driveBackwards == null)
				{
					_driveBackwards = (CBool) CR2WTypeManager.Create("Bool", "driveBackwards", cr2w, this);
				}
				return _driveBackwards;
			}
			set
			{
				if (_driveBackwards == value)
				{
					return;
				}
				_driveBackwards = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("reverseSpline")] 
		public CBool ReverseSpline
		{
			get
			{
				if (_reverseSpline == null)
				{
					_reverseSpline = (CBool) CR2WTypeManager.Create("Bool", "reverseSpline", cr2w, this);
				}
				return _reverseSpline;
			}
			set
			{
				if (_reverseSpline == value)
				{
					return;
				}
				_reverseSpline = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("startFromClosest")] 
		public CBool StartFromClosest
		{
			get
			{
				if (_startFromClosest == null)
				{
					_startFromClosest = (CBool) CR2WTypeManager.Create("Bool", "startFromClosest", cr2w, this);
				}
				return _startFromClosest;
			}
			set
			{
				if (_startFromClosest == value)
				{
					return;
				}
				_startFromClosest = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("canClearActions")] 
		public CBool CanClearActions
		{
			get
			{
				if (_canClearActions == null)
				{
					_canClearActions = (CBool) CR2WTypeManager.Create("Bool", "canClearActions", cr2w, this);
				}
				return _canClearActions;
			}
			set
			{
				if (_canClearActions == value)
				{
					return;
				}
				_canClearActions = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("keepDistanceParamBool")] 
		public CBool KeepDistanceParamBool
		{
			get
			{
				if (_keepDistanceParamBool == null)
				{
					_keepDistanceParamBool = (CBool) CR2WTypeManager.Create("Bool", "keepDistanceParamBool", cr2w, this);
				}
				return _keepDistanceParamBool;
			}
			set
			{
				if (_keepDistanceParamBool == value)
				{
					return;
				}
				_keepDistanceParamBool = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("keepDistanceParamCompanion")] 
		public wCHandle<gameObject> KeepDistanceParamCompanion
		{
			get
			{
				if (_keepDistanceParamCompanion == null)
				{
					_keepDistanceParamCompanion = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "keepDistanceParamCompanion", cr2w, this);
				}
				return _keepDistanceParamCompanion;
			}
			set
			{
				if (_keepDistanceParamCompanion == value)
				{
					return;
				}
				_keepDistanceParamCompanion = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("keepDistanceParamDistance")] 
		public CFloat KeepDistanceParamDistance
		{
			get
			{
				if (_keepDistanceParamDistance == null)
				{
					_keepDistanceParamDistance = (CFloat) CR2WTypeManager.Create("Float", "keepDistanceParamDistance", cr2w, this);
				}
				return _keepDistanceParamDistance;
			}
			set
			{
				if (_keepDistanceParamDistance == value)
				{
					return;
				}
				_keepDistanceParamDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("rubberBandingBool")] 
		public CBool RubberBandingBool
		{
			get
			{
				if (_rubberBandingBool == null)
				{
					_rubberBandingBool = (CBool) CR2WTypeManager.Create("Bool", "rubberBandingBool", cr2w, this);
				}
				return _rubberBandingBool;
			}
			set
			{
				if (_rubberBandingBool == value)
				{
					return;
				}
				_rubberBandingBool = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("rubberBandingTargetRef")] 
		public wCHandle<gameObject> RubberBandingTargetRef
		{
			get
			{
				if (_rubberBandingTargetRef == null)
				{
					_rubberBandingTargetRef = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "rubberBandingTargetRef", cr2w, this);
				}
				return _rubberBandingTargetRef;
			}
			set
			{
				if (_rubberBandingTargetRef == value)
				{
					return;
				}
				_rubberBandingTargetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("rubberBandingMinDistance")] 
		public CFloat RubberBandingMinDistance
		{
			get
			{
				if (_rubberBandingMinDistance == null)
				{
					_rubberBandingMinDistance = (CFloat) CR2WTypeManager.Create("Float", "rubberBandingMinDistance", cr2w, this);
				}
				return _rubberBandingMinDistance;
			}
			set
			{
				if (_rubberBandingMinDistance == value)
				{
					return;
				}
				_rubberBandingMinDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("rubberBandingMaxDistance")] 
		public CFloat RubberBandingMaxDistance
		{
			get
			{
				if (_rubberBandingMaxDistance == null)
				{
					_rubberBandingMaxDistance = (CFloat) CR2WTypeManager.Create("Float", "rubberBandingMaxDistance", cr2w, this);
				}
				return _rubberBandingMaxDistance;
			}
			set
			{
				if (_rubberBandingMaxDistance == value)
				{
					return;
				}
				_rubberBandingMaxDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("rubberBandingStopAndWait")] 
		public CBool RubberBandingStopAndWait
		{
			get
			{
				if (_rubberBandingStopAndWait == null)
				{
					_rubberBandingStopAndWait = (CBool) CR2WTypeManager.Create("Bool", "rubberBandingStopAndWait", cr2w, this);
				}
				return _rubberBandingStopAndWait;
			}
			set
			{
				if (_rubberBandingStopAndWait == value)
				{
					return;
				}
				_rubberBandingStopAndWait = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("rubberBandingTeleportToCatchUp")] 
		public CBool RubberBandingTeleportToCatchUp
		{
			get
			{
				if (_rubberBandingTeleportToCatchUp == null)
				{
					_rubberBandingTeleportToCatchUp = (CBool) CR2WTypeManager.Create("Bool", "rubberBandingTeleportToCatchUp", cr2w, this);
				}
				return _rubberBandingTeleportToCatchUp;
			}
			set
			{
				if (_rubberBandingTeleportToCatchUp == value)
				{
					return;
				}
				_rubberBandingTeleportToCatchUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("rubberBandingStayInFront")] 
		public CBool RubberBandingStayInFront
		{
			get
			{
				if (_rubberBandingStayInFront == null)
				{
					_rubberBandingStayInFront = (CBool) CR2WTypeManager.Create("Bool", "rubberBandingStayInFront", cr2w, this);
				}
				return _rubberBandingStayInFront;
			}
			set
			{
				if (_rubberBandingStayInFront == value)
				{
					return;
				}
				_rubberBandingStayInFront = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("secureTimeOut")] 
		public CFloat SecureTimeOut
		{
			get
			{
				if (_secureTimeOut == null)
				{
					_secureTimeOut = (CFloat) CR2WTypeManager.Create("Float", "secureTimeOut", cr2w, this);
				}
				return _secureTimeOut;
			}
			set
			{
				if (_secureTimeOut == value)
				{
					return;
				}
				_secureTimeOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("portalsList")] 
		public CHandle<vehiclePortalsList> PortalsList
		{
			get
			{
				if (_portalsList == null)
				{
					_portalsList = (CHandle<vehiclePortalsList>) CR2WTypeManager.Create("handle:vehiclePortalsList", "portalsList", cr2w, this);
				}
				return _portalsList;
			}
			set
			{
				if (_portalsList == value)
				{
					return;
				}
				_portalsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("trafficTryNeighborsForStart")] 
		public CBool TrafficTryNeighborsForStart
		{
			get
			{
				if (_trafficTryNeighborsForStart == null)
				{
					_trafficTryNeighborsForStart = (CBool) CR2WTypeManager.Create("Bool", "trafficTryNeighborsForStart", cr2w, this);
				}
				return _trafficTryNeighborsForStart;
			}
			set
			{
				if (_trafficTryNeighborsForStart == value)
				{
					return;
				}
				_trafficTryNeighborsForStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("trafficTryNeighborsForEnd")] 
		public CBool TrafficTryNeighborsForEnd
		{
			get
			{
				if (_trafficTryNeighborsForEnd == null)
				{
					_trafficTryNeighborsForEnd = (CBool) CR2WTypeManager.Create("Bool", "trafficTryNeighborsForEnd", cr2w, this);
				}
				return _trafficTryNeighborsForEnd;
			}
			set
			{
				if (_trafficTryNeighborsForEnd == value)
				{
					return;
				}
				_trafficTryNeighborsForEnd = value;
				PropertySet(this);
			}
		}

		public vehicleAutonomousData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
