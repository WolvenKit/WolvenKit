using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDriveCommandsDelegate : AIbehaviorScriptBehaviorDelegate
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
		private wCHandle<gameObject> _keepDistanceCompanion;
		private CFloat _keepDistanceDistance;
		private CBool _rubberBandingBool;
		private wCHandle<gameObject> _rubberBandingTargetRef;
		private CFloat _rubberBandingMinDistance;
		private CFloat _rubberBandingMaxDistance;
		private CBool _rubberBandingStopAndWait;
		private CBool _rubberBandingTeleportToCatchUp;
		private CBool _rubberBandingStayInFront;
		private CBool _allowStubMovement;
		private CHandle<AIVehicleOnSplineCommand> _driveOnSplineCommand;
		private CBool _useTraffic;
		private CFloat _speedInTraffic;
		private wCHandle<gameObject> _target;
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

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("forcedStartSpeed")] 
		public CFloat ForcedStartSpeed
		{
			get
			{
				if (_forcedStartSpeed == null)
				{
					_forcedStartSpeed = (CFloat) CR2WTypeManager.Create("Float", "forcedStartSpeed", cr2w, this);
				}
				return _forcedStartSpeed;
			}
			set
			{
				if (_forcedStartSpeed == value)
				{
					return;
				}
				_forcedStartSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("stopAtPathEnd")] 
		public CBool StopAtPathEnd
		{
			get
			{
				if (_stopAtPathEnd == null)
				{
					_stopAtPathEnd = (CBool) CR2WTypeManager.Create("Bool", "stopAtPathEnd", cr2w, this);
				}
				return _stopAtPathEnd;
			}
			set
			{
				if (_stopAtPathEnd == value)
				{
					return;
				}
				_stopAtPathEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("keepDistanceBool")] 
		public CBool KeepDistanceBool
		{
			get
			{
				if (_keepDistanceBool == null)
				{
					_keepDistanceBool = (CBool) CR2WTypeManager.Create("Bool", "keepDistanceBool", cr2w, this);
				}
				return _keepDistanceBool;
			}
			set
			{
				if (_keepDistanceBool == value)
				{
					return;
				}
				_keepDistanceBool = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("keepDistanceCompanion")] 
		public wCHandle<gameObject> KeepDistanceCompanion
		{
			get
			{
				if (_keepDistanceCompanion == null)
				{
					_keepDistanceCompanion = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "keepDistanceCompanion", cr2w, this);
				}
				return _keepDistanceCompanion;
			}
			set
			{
				if (_keepDistanceCompanion == value)
				{
					return;
				}
				_keepDistanceCompanion = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("keepDistanceDistance")] 
		public CFloat KeepDistanceDistance
		{
			get
			{
				if (_keepDistanceDistance == null)
				{
					_keepDistanceDistance = (CFloat) CR2WTypeManager.Create("Float", "keepDistanceDistance", cr2w, this);
				}
				return _keepDistanceDistance;
			}
			set
			{
				if (_keepDistanceDistance == value)
				{
					return;
				}
				_keepDistanceDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		[Ordinal(14)] 
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

		[Ordinal(15)] 
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

		[Ordinal(16)] 
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

		[Ordinal(17)] 
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
		[RED("allowStubMovement")] 
		public CBool AllowStubMovement
		{
			get
			{
				if (_allowStubMovement == null)
				{
					_allowStubMovement = (CBool) CR2WTypeManager.Create("Bool", "allowStubMovement", cr2w, this);
				}
				return _allowStubMovement;
			}
			set
			{
				if (_allowStubMovement == value)
				{
					return;
				}
				_allowStubMovement = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("driveOnSplineCommand")] 
		public CHandle<AIVehicleOnSplineCommand> DriveOnSplineCommand
		{
			get
			{
				if (_driveOnSplineCommand == null)
				{
					_driveOnSplineCommand = (CHandle<AIVehicleOnSplineCommand>) CR2WTypeManager.Create("handle:AIVehicleOnSplineCommand", "driveOnSplineCommand", cr2w, this);
				}
				return _driveOnSplineCommand;
			}
			set
			{
				if (_driveOnSplineCommand == value)
				{
					return;
				}
				_driveOnSplineCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get
			{
				if (_useTraffic == null)
				{
					_useTraffic = (CBool) CR2WTypeManager.Create("Bool", "useTraffic", cr2w, this);
				}
				return _useTraffic;
			}
			set
			{
				if (_useTraffic == value)
				{
					return;
				}
				_useTraffic = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("speedInTraffic")] 
		public CFloat SpeedInTraffic
		{
			get
			{
				if (_speedInTraffic == null)
				{
					_speedInTraffic = (CFloat) CR2WTypeManager.Create("Float", "speedInTraffic", cr2w, this);
				}
				return _speedInTraffic;
			}
			set
			{
				if (_speedInTraffic == value)
				{
					return;
				}
				_speedInTraffic = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get
			{
				if (_target == null)
				{
					_target = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "target", cr2w, this);
				}
				return _target;
			}
			set
			{
				if (_target == value)
				{
					return;
				}
				_target = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
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

		[Ordinal(25)] 
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

		[Ordinal(26)] 
		[RED("stopWhenTargetReached")] 
		public CBool StopWhenTargetReached
		{
			get
			{
				if (_stopWhenTargetReached == null)
				{
					_stopWhenTargetReached = (CBool) CR2WTypeManager.Create("Bool", "stopWhenTargetReached", cr2w, this);
				}
				return _stopWhenTargetReached;
			}
			set
			{
				if (_stopWhenTargetReached == value)
				{
					return;
				}
				_stopWhenTargetReached = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
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

		[Ordinal(28)] 
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

		[Ordinal(29)] 
		[RED("driveFollowCommand")] 
		public CHandle<AIVehicleFollowCommand> DriveFollowCommand
		{
			get
			{
				if (_driveFollowCommand == null)
				{
					_driveFollowCommand = (CHandle<AIVehicleFollowCommand>) CR2WTypeManager.Create("handle:AIVehicleFollowCommand", "driveFollowCommand", cr2w, this);
				}
				return _driveFollowCommand;
			}
			set
			{
				if (_driveFollowCommand == value)
				{
					return;
				}
				_driveFollowCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "nodeRef", cr2w, this);
				}
				return _nodeRef;
			}
			set
			{
				if (_nodeRef == value)
				{
					return;
				}
				_nodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("forceGreenLights")] 
		public CBool ForceGreenLights
		{
			get
			{
				if (_forceGreenLights == null)
				{
					_forceGreenLights = (CBool) CR2WTypeManager.Create("Bool", "forceGreenLights", cr2w, this);
				}
				return _forceGreenLights;
			}
			set
			{
				if (_forceGreenLights == value)
				{
					return;
				}
				_forceGreenLights = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("portals")] 
		public CHandle<vehiclePortalsList> Portals
		{
			get
			{
				if (_portals == null)
				{
					_portals = (CHandle<vehiclePortalsList>) CR2WTypeManager.Create("handle:vehiclePortalsList", "portals", cr2w, this);
				}
				return _portals;
			}
			set
			{
				if (_portals == value)
				{
					return;
				}
				_portals = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("driveToNodeCommand")] 
		public CHandle<AIVehicleToNodeCommand> DriveToNodeCommand
		{
			get
			{
				if (_driveToNodeCommand == null)
				{
					_driveToNodeCommand = (CHandle<AIVehicleToNodeCommand>) CR2WTypeManager.Create("handle:AIVehicleToNodeCommand", "driveToNodeCommand", cr2w, this);
				}
				return _driveToNodeCommand;
			}
			set
			{
				if (_driveToNodeCommand == value)
				{
					return;
				}
				_driveToNodeCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("driveRacingCommand")] 
		public CHandle<AIVehicleRacingCommand> DriveRacingCommand
		{
			get
			{
				if (_driveRacingCommand == null)
				{
					_driveRacingCommand = (CHandle<AIVehicleRacingCommand>) CR2WTypeManager.Create("handle:AIVehicleRacingCommand", "driveRacingCommand", cr2w, this);
				}
				return _driveRacingCommand;
			}
			set
			{
				if (_driveRacingCommand == value)
				{
					return;
				}
				_driveRacingCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("driveJoinTrafficCommand")] 
		public CHandle<AIVehicleJoinTrafficCommand> DriveJoinTrafficCommand
		{
			get
			{
				if (_driveJoinTrafficCommand == null)
				{
					_driveJoinTrafficCommand = (CHandle<AIVehicleJoinTrafficCommand>) CR2WTypeManager.Create("handle:AIVehicleJoinTrafficCommand", "driveJoinTrafficCommand", cr2w, this);
				}
				return _driveJoinTrafficCommand;
			}
			set
			{
				if (_driveJoinTrafficCommand == value)
				{
					return;
				}
				_driveJoinTrafficCommand = value;
				PropertySet(this);
			}
		}

		public AIDriveCommandsDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
