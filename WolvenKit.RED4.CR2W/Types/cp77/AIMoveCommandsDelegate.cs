using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMoveCommandsDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private wCHandle<AIAnimMoveOnSplineCommand> _animMoveOnSplineCommand;
		private NodeRef _spline;
		private CBool _useStart;
		private CBool _useStop;
		private CBool _reverse;
		private CName _controllerSetupName;
		private CFloat _blendTime;
		private CFloat _globalInBlendTime;
		private CFloat _globalOutBlendTime;
		private CBool _turnCharacterToMatchVelocity;
		private CName _customStartAnimationName;
		private CName _customMainAnimationName;
		private CName _customStopAnimationName;
		private CBool _startSnapToTerrain;
		private CBool _mainSnapToTerrain;
		private CBool _stopSnapToTerrain;
		private CFloat _startSnapToTerrainBlendTime;
		private CFloat _stopSnapToTerrainBlendTime;
		private CHandle<AIMoveOnSplineCommand> _moveOnSplineCommand;
		private wCHandle<gameObject> _strafingTarget;
		private CEnum<moveMovementType> _movementType;
		private CBool _ignoreNavigation;
		private CBool _startFromClosestPoint;
		private CBool _useCombatState;
		private CBool _useAlertedState;
		private CFloat _noWaitToEndDistance;
		private CFloat _noWaitToEndCompanionDistance;
		private CFloat _lowestCompanionDistanceToEnd;
		private CFloat _previousCompanionDistanceToEnd;
		private CFloat _maxCompanionDistanceOnSpline;
		private wCHandle<gameObject> _companion;
		private CBool _ignoreLineOfSightCheck;
		private wCHandle<gameObject> _shootingTarget;
		private CFloat _minSearchAngle;
		private CFloat _maxSearchAngle;
		private CFloat _desiredDistance;
		private CFloat _deadZoneRadius;
		private CBool _shouldBeInFrontOfCompanion;
		private CBool _useMatchForSpeedForPlayer;
		private wCHandle<gameObject> _lookAtTarget;
		private CFloat _distanceToCompanion;
		private Vector4 _splineEndPoint;
		private CBool _hasSplineEndPoint;
		private wCHandle<PlayerPuppet> _playerCompanion;
		private CFloat _firstWaitingDemandTimestamp;
		private CBool _useOffMeshLinkReservation;
		private CBool _sprint;
		private CBool _run;
		private CBool _waitForCompanion;
		private CHandle<AIFollowTargetCommand> _followTargetCommand;
		private CBool _stopWhenDestinationReached;
		private CBool _teleportToTarget;
		private CBool _shouldTeleportNow;
		private Vector4 _teleportDestination;
		private CBool _matchTargetSpeed;

		[Ordinal(0)] 
		[RED("animMoveOnSplineCommand")] 
		public wCHandle<AIAnimMoveOnSplineCommand> AnimMoveOnSplineCommand
		{
			get
			{
				if (_animMoveOnSplineCommand == null)
				{
					_animMoveOnSplineCommand = (wCHandle<AIAnimMoveOnSplineCommand>) CR2WTypeManager.Create("whandle:AIAnimMoveOnSplineCommand", "animMoveOnSplineCommand", cr2w, this);
				}
				return _animMoveOnSplineCommand;
			}
			set
			{
				if (_animMoveOnSplineCommand == value)
				{
					return;
				}
				_animMoveOnSplineCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("spline")] 
		public NodeRef Spline
		{
			get
			{
				if (_spline == null)
				{
					_spline = (NodeRef) CR2WTypeManager.Create("NodeRef", "spline", cr2w, this);
				}
				return _spline;
			}
			set
			{
				if (_spline == value)
				{
					return;
				}
				_spline = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get
			{
				if (_useStart == null)
				{
					_useStart = (CBool) CR2WTypeManager.Create("Bool", "useStart", cr2w, this);
				}
				return _useStart;
			}
			set
			{
				if (_useStart == value)
				{
					return;
				}
				_useStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get
			{
				if (_useStop == null)
				{
					_useStop = (CBool) CR2WTypeManager.Create("Bool", "useStop", cr2w, this);
				}
				return _useStop;
			}
			set
			{
				if (_useStop == value)
				{
					return;
				}
				_useStop = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("reverse")] 
		public CBool Reverse
		{
			get
			{
				if (_reverse == null)
				{
					_reverse = (CBool) CR2WTypeManager.Create("Bool", "reverse", cr2w, this);
				}
				return _reverse;
			}
			set
			{
				if (_reverse == value)
				{
					return;
				}
				_reverse = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("controllerSetupName")] 
		public CName ControllerSetupName
		{
			get
			{
				if (_controllerSetupName == null)
				{
					_controllerSetupName = (CName) CR2WTypeManager.Create("CName", "controllerSetupName", cr2w, this);
				}
				return _controllerSetupName;
			}
			set
			{
				if (_controllerSetupName == value)
				{
					return;
				}
				_controllerSetupName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get
			{
				if (_blendTime == null)
				{
					_blendTime = (CFloat) CR2WTypeManager.Create("Float", "blendTime", cr2w, this);
				}
				return _blendTime;
			}
			set
			{
				if (_blendTime == value)
				{
					return;
				}
				_blendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("globalInBlendTime")] 
		public CFloat GlobalInBlendTime
		{
			get
			{
				if (_globalInBlendTime == null)
				{
					_globalInBlendTime = (CFloat) CR2WTypeManager.Create("Float", "globalInBlendTime", cr2w, this);
				}
				return _globalInBlendTime;
			}
			set
			{
				if (_globalInBlendTime == value)
				{
					return;
				}
				_globalInBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("globalOutBlendTime")] 
		public CFloat GlobalOutBlendTime
		{
			get
			{
				if (_globalOutBlendTime == null)
				{
					_globalOutBlendTime = (CFloat) CR2WTypeManager.Create("Float", "globalOutBlendTime", cr2w, this);
				}
				return _globalOutBlendTime;
			}
			set
			{
				if (_globalOutBlendTime == value)
				{
					return;
				}
				_globalOutBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("turnCharacterToMatchVelocity")] 
		public CBool TurnCharacterToMatchVelocity
		{
			get
			{
				if (_turnCharacterToMatchVelocity == null)
				{
					_turnCharacterToMatchVelocity = (CBool) CR2WTypeManager.Create("Bool", "turnCharacterToMatchVelocity", cr2w, this);
				}
				return _turnCharacterToMatchVelocity;
			}
			set
			{
				if (_turnCharacterToMatchVelocity == value)
				{
					return;
				}
				_turnCharacterToMatchVelocity = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("customStartAnimationName")] 
		public CName CustomStartAnimationName
		{
			get
			{
				if (_customStartAnimationName == null)
				{
					_customStartAnimationName = (CName) CR2WTypeManager.Create("CName", "customStartAnimationName", cr2w, this);
				}
				return _customStartAnimationName;
			}
			set
			{
				if (_customStartAnimationName == value)
				{
					return;
				}
				_customStartAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("customMainAnimationName")] 
		public CName CustomMainAnimationName
		{
			get
			{
				if (_customMainAnimationName == null)
				{
					_customMainAnimationName = (CName) CR2WTypeManager.Create("CName", "customMainAnimationName", cr2w, this);
				}
				return _customMainAnimationName;
			}
			set
			{
				if (_customMainAnimationName == value)
				{
					return;
				}
				_customMainAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("customStopAnimationName")] 
		public CName CustomStopAnimationName
		{
			get
			{
				if (_customStopAnimationName == null)
				{
					_customStopAnimationName = (CName) CR2WTypeManager.Create("CName", "customStopAnimationName", cr2w, this);
				}
				return _customStopAnimationName;
			}
			set
			{
				if (_customStopAnimationName == value)
				{
					return;
				}
				_customStopAnimationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("startSnapToTerrain")] 
		public CBool StartSnapToTerrain
		{
			get
			{
				if (_startSnapToTerrain == null)
				{
					_startSnapToTerrain = (CBool) CR2WTypeManager.Create("Bool", "startSnapToTerrain", cr2w, this);
				}
				return _startSnapToTerrain;
			}
			set
			{
				if (_startSnapToTerrain == value)
				{
					return;
				}
				_startSnapToTerrain = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("mainSnapToTerrain")] 
		public CBool MainSnapToTerrain
		{
			get
			{
				if (_mainSnapToTerrain == null)
				{
					_mainSnapToTerrain = (CBool) CR2WTypeManager.Create("Bool", "mainSnapToTerrain", cr2w, this);
				}
				return _mainSnapToTerrain;
			}
			set
			{
				if (_mainSnapToTerrain == value)
				{
					return;
				}
				_mainSnapToTerrain = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("stopSnapToTerrain")] 
		public CBool StopSnapToTerrain
		{
			get
			{
				if (_stopSnapToTerrain == null)
				{
					_stopSnapToTerrain = (CBool) CR2WTypeManager.Create("Bool", "stopSnapToTerrain", cr2w, this);
				}
				return _stopSnapToTerrain;
			}
			set
			{
				if (_stopSnapToTerrain == value)
				{
					return;
				}
				_stopSnapToTerrain = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("startSnapToTerrainBlendTime")] 
		public CFloat StartSnapToTerrainBlendTime
		{
			get
			{
				if (_startSnapToTerrainBlendTime == null)
				{
					_startSnapToTerrainBlendTime = (CFloat) CR2WTypeManager.Create("Float", "startSnapToTerrainBlendTime", cr2w, this);
				}
				return _startSnapToTerrainBlendTime;
			}
			set
			{
				if (_startSnapToTerrainBlendTime == value)
				{
					return;
				}
				_startSnapToTerrainBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("stopSnapToTerrainBlendTime")] 
		public CFloat StopSnapToTerrainBlendTime
		{
			get
			{
				if (_stopSnapToTerrainBlendTime == null)
				{
					_stopSnapToTerrainBlendTime = (CFloat) CR2WTypeManager.Create("Float", "stopSnapToTerrainBlendTime", cr2w, this);
				}
				return _stopSnapToTerrainBlendTime;
			}
			set
			{
				if (_stopSnapToTerrainBlendTime == value)
				{
					return;
				}
				_stopSnapToTerrainBlendTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("moveOnSplineCommand")] 
		public CHandle<AIMoveOnSplineCommand> MoveOnSplineCommand
		{
			get
			{
				if (_moveOnSplineCommand == null)
				{
					_moveOnSplineCommand = (CHandle<AIMoveOnSplineCommand>) CR2WTypeManager.Create("handle:AIMoveOnSplineCommand", "moveOnSplineCommand", cr2w, this);
				}
				return _moveOnSplineCommand;
			}
			set
			{
				if (_moveOnSplineCommand == value)
				{
					return;
				}
				_moveOnSplineCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("strafingTarget")] 
		public wCHandle<gameObject> StrafingTarget
		{
			get
			{
				if (_strafingTarget == null)
				{
					_strafingTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "strafingTarget", cr2w, this);
				}
				return _strafingTarget;
			}
			set
			{
				if (_strafingTarget == value)
				{
					return;
				}
				_strafingTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get
			{
				if (_movementType == null)
				{
					_movementType = (CEnum<moveMovementType>) CR2WTypeManager.Create("moveMovementType", "movementType", cr2w, this);
				}
				return _movementType;
			}
			set
			{
				if (_movementType == value)
				{
					return;
				}
				_movementType = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("ignoreNavigation")] 
		public CBool IgnoreNavigation
		{
			get
			{
				if (_ignoreNavigation == null)
				{
					_ignoreNavigation = (CBool) CR2WTypeManager.Create("Bool", "ignoreNavigation", cr2w, this);
				}
				return _ignoreNavigation;
			}
			set
			{
				if (_ignoreNavigation == value)
				{
					return;
				}
				_ignoreNavigation = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("startFromClosestPoint")] 
		public CBool StartFromClosestPoint
		{
			get
			{
				if (_startFromClosestPoint == null)
				{
					_startFromClosestPoint = (CBool) CR2WTypeManager.Create("Bool", "startFromClosestPoint", cr2w, this);
				}
				return _startFromClosestPoint;
			}
			set
			{
				if (_startFromClosestPoint == value)
				{
					return;
				}
				_startFromClosestPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("useCombatState")] 
		public CBool UseCombatState
		{
			get
			{
				if (_useCombatState == null)
				{
					_useCombatState = (CBool) CR2WTypeManager.Create("Bool", "useCombatState", cr2w, this);
				}
				return _useCombatState;
			}
			set
			{
				if (_useCombatState == value)
				{
					return;
				}
				_useCombatState = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("useAlertedState")] 
		public CBool UseAlertedState
		{
			get
			{
				if (_useAlertedState == null)
				{
					_useAlertedState = (CBool) CR2WTypeManager.Create("Bool", "useAlertedState", cr2w, this);
				}
				return _useAlertedState;
			}
			set
			{
				if (_useAlertedState == value)
				{
					return;
				}
				_useAlertedState = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("noWaitToEndDistance")] 
		public CFloat NoWaitToEndDistance
		{
			get
			{
				if (_noWaitToEndDistance == null)
				{
					_noWaitToEndDistance = (CFloat) CR2WTypeManager.Create("Float", "noWaitToEndDistance", cr2w, this);
				}
				return _noWaitToEndDistance;
			}
			set
			{
				if (_noWaitToEndDistance == value)
				{
					return;
				}
				_noWaitToEndDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("noWaitToEndCompanionDistance")] 
		public CFloat NoWaitToEndCompanionDistance
		{
			get
			{
				if (_noWaitToEndCompanionDistance == null)
				{
					_noWaitToEndCompanionDistance = (CFloat) CR2WTypeManager.Create("Float", "noWaitToEndCompanionDistance", cr2w, this);
				}
				return _noWaitToEndCompanionDistance;
			}
			set
			{
				if (_noWaitToEndCompanionDistance == value)
				{
					return;
				}
				_noWaitToEndCompanionDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("lowestCompanionDistanceToEnd")] 
		public CFloat LowestCompanionDistanceToEnd
		{
			get
			{
				if (_lowestCompanionDistanceToEnd == null)
				{
					_lowestCompanionDistanceToEnd = (CFloat) CR2WTypeManager.Create("Float", "lowestCompanionDistanceToEnd", cr2w, this);
				}
				return _lowestCompanionDistanceToEnd;
			}
			set
			{
				if (_lowestCompanionDistanceToEnd == value)
				{
					return;
				}
				_lowestCompanionDistanceToEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("previousCompanionDistanceToEnd")] 
		public CFloat PreviousCompanionDistanceToEnd
		{
			get
			{
				if (_previousCompanionDistanceToEnd == null)
				{
					_previousCompanionDistanceToEnd = (CFloat) CR2WTypeManager.Create("Float", "previousCompanionDistanceToEnd", cr2w, this);
				}
				return _previousCompanionDistanceToEnd;
			}
			set
			{
				if (_previousCompanionDistanceToEnd == value)
				{
					return;
				}
				_previousCompanionDistanceToEnd = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("maxCompanionDistanceOnSpline")] 
		public CFloat MaxCompanionDistanceOnSpline
		{
			get
			{
				if (_maxCompanionDistanceOnSpline == null)
				{
					_maxCompanionDistanceOnSpline = (CFloat) CR2WTypeManager.Create("Float", "maxCompanionDistanceOnSpline", cr2w, this);
				}
				return _maxCompanionDistanceOnSpline;
			}
			set
			{
				if (_maxCompanionDistanceOnSpline == value)
				{
					return;
				}
				_maxCompanionDistanceOnSpline = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("companion")] 
		public wCHandle<gameObject> Companion
		{
			get
			{
				if (_companion == null)
				{
					_companion = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "companion", cr2w, this);
				}
				return _companion;
			}
			set
			{
				if (_companion == value)
				{
					return;
				}
				_companion = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("ignoreLineOfSightCheck")] 
		public CBool IgnoreLineOfSightCheck
		{
			get
			{
				if (_ignoreLineOfSightCheck == null)
				{
					_ignoreLineOfSightCheck = (CBool) CR2WTypeManager.Create("Bool", "ignoreLineOfSightCheck", cr2w, this);
				}
				return _ignoreLineOfSightCheck;
			}
			set
			{
				if (_ignoreLineOfSightCheck == value)
				{
					return;
				}
				_ignoreLineOfSightCheck = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("shootingTarget")] 
		public wCHandle<gameObject> ShootingTarget
		{
			get
			{
				if (_shootingTarget == null)
				{
					_shootingTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "shootingTarget", cr2w, this);
				}
				return _shootingTarget;
			}
			set
			{
				if (_shootingTarget == value)
				{
					return;
				}
				_shootingTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("minSearchAngle")] 
		public CFloat MinSearchAngle
		{
			get
			{
				if (_minSearchAngle == null)
				{
					_minSearchAngle = (CFloat) CR2WTypeManager.Create("Float", "minSearchAngle", cr2w, this);
				}
				return _minSearchAngle;
			}
			set
			{
				if (_minSearchAngle == value)
				{
					return;
				}
				_minSearchAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("maxSearchAngle")] 
		public CFloat MaxSearchAngle
		{
			get
			{
				if (_maxSearchAngle == null)
				{
					_maxSearchAngle = (CFloat) CR2WTypeManager.Create("Float", "maxSearchAngle", cr2w, this);
				}
				return _maxSearchAngle;
			}
			set
			{
				if (_maxSearchAngle == value)
				{
					return;
				}
				_maxSearchAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get
			{
				if (_desiredDistance == null)
				{
					_desiredDistance = (CFloat) CR2WTypeManager.Create("Float", "desiredDistance", cr2w, this);
				}
				return _desiredDistance;
			}
			set
			{
				if (_desiredDistance == value)
				{
					return;
				}
				_desiredDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("deadZoneRadius")] 
		public CFloat DeadZoneRadius
		{
			get
			{
				if (_deadZoneRadius == null)
				{
					_deadZoneRadius = (CFloat) CR2WTypeManager.Create("Float", "deadZoneRadius", cr2w, this);
				}
				return _deadZoneRadius;
			}
			set
			{
				if (_deadZoneRadius == value)
				{
					return;
				}
				_deadZoneRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("shouldBeInFrontOfCompanion")] 
		public CBool ShouldBeInFrontOfCompanion
		{
			get
			{
				if (_shouldBeInFrontOfCompanion == null)
				{
					_shouldBeInFrontOfCompanion = (CBool) CR2WTypeManager.Create("Bool", "shouldBeInFrontOfCompanion", cr2w, this);
				}
				return _shouldBeInFrontOfCompanion;
			}
			set
			{
				if (_shouldBeInFrontOfCompanion == value)
				{
					return;
				}
				_shouldBeInFrontOfCompanion = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("useMatchForSpeedForPlayer")] 
		public CBool UseMatchForSpeedForPlayer
		{
			get
			{
				if (_useMatchForSpeedForPlayer == null)
				{
					_useMatchForSpeedForPlayer = (CBool) CR2WTypeManager.Create("Bool", "useMatchForSpeedForPlayer", cr2w, this);
				}
				return _useMatchForSpeedForPlayer;
			}
			set
			{
				if (_useMatchForSpeedForPlayer == value)
				{
					return;
				}
				_useMatchForSpeedForPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("lookAtTarget")] 
		public wCHandle<gameObject> LookAtTarget
		{
			get
			{
				if (_lookAtTarget == null)
				{
					_lookAtTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "lookAtTarget", cr2w, this);
				}
				return _lookAtTarget;
			}
			set
			{
				if (_lookAtTarget == value)
				{
					return;
				}
				_lookAtTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("distanceToCompanion")] 
		public CFloat DistanceToCompanion
		{
			get
			{
				if (_distanceToCompanion == null)
				{
					_distanceToCompanion = (CFloat) CR2WTypeManager.Create("Float", "distanceToCompanion", cr2w, this);
				}
				return _distanceToCompanion;
			}
			set
			{
				if (_distanceToCompanion == value)
				{
					return;
				}
				_distanceToCompanion = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("splineEndPoint")] 
		public Vector4 SplineEndPoint
		{
			get
			{
				if (_splineEndPoint == null)
				{
					_splineEndPoint = (Vector4) CR2WTypeManager.Create("Vector4", "splineEndPoint", cr2w, this);
				}
				return _splineEndPoint;
			}
			set
			{
				if (_splineEndPoint == value)
				{
					return;
				}
				_splineEndPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("hasSplineEndPoint")] 
		public CBool HasSplineEndPoint
		{
			get
			{
				if (_hasSplineEndPoint == null)
				{
					_hasSplineEndPoint = (CBool) CR2WTypeManager.Create("Bool", "hasSplineEndPoint", cr2w, this);
				}
				return _hasSplineEndPoint;
			}
			set
			{
				if (_hasSplineEndPoint == value)
				{
					return;
				}
				_hasSplineEndPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("playerCompanion")] 
		public wCHandle<PlayerPuppet> PlayerCompanion
		{
			get
			{
				if (_playerCompanion == null)
				{
					_playerCompanion = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "playerCompanion", cr2w, this);
				}
				return _playerCompanion;
			}
			set
			{
				if (_playerCompanion == value)
				{
					return;
				}
				_playerCompanion = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("firstWaitingDemandTimestamp")] 
		public CFloat FirstWaitingDemandTimestamp
		{
			get
			{
				if (_firstWaitingDemandTimestamp == null)
				{
					_firstWaitingDemandTimestamp = (CFloat) CR2WTypeManager.Create("Float", "firstWaitingDemandTimestamp", cr2w, this);
				}
				return _firstWaitingDemandTimestamp;
			}
			set
			{
				if (_firstWaitingDemandTimestamp == value)
				{
					return;
				}
				_firstWaitingDemandTimestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("useOffMeshLinkReservation")] 
		public CBool UseOffMeshLinkReservation
		{
			get
			{
				if (_useOffMeshLinkReservation == null)
				{
					_useOffMeshLinkReservation = (CBool) CR2WTypeManager.Create("Bool", "useOffMeshLinkReservation", cr2w, this);
				}
				return _useOffMeshLinkReservation;
			}
			set
			{
				if (_useOffMeshLinkReservation == value)
				{
					return;
				}
				_useOffMeshLinkReservation = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("sprint")] 
		public CBool Sprint
		{
			get
			{
				if (_sprint == null)
				{
					_sprint = (CBool) CR2WTypeManager.Create("Bool", "sprint", cr2w, this);
				}
				return _sprint;
			}
			set
			{
				if (_sprint == value)
				{
					return;
				}
				_sprint = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("run")] 
		public CBool Run
		{
			get
			{
				if (_run == null)
				{
					_run = (CBool) CR2WTypeManager.Create("Bool", "run", cr2w, this);
				}
				return _run;
			}
			set
			{
				if (_run == value)
				{
					return;
				}
				_run = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("waitForCompanion")] 
		public CBool WaitForCompanion
		{
			get
			{
				if (_waitForCompanion == null)
				{
					_waitForCompanion = (CBool) CR2WTypeManager.Create("Bool", "waitForCompanion", cr2w, this);
				}
				return _waitForCompanion;
			}
			set
			{
				if (_waitForCompanion == value)
				{
					return;
				}
				_waitForCompanion = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("followTargetCommand")] 
		public CHandle<AIFollowTargetCommand> FollowTargetCommand
		{
			get
			{
				if (_followTargetCommand == null)
				{
					_followTargetCommand = (CHandle<AIFollowTargetCommand>) CR2WTypeManager.Create("handle:AIFollowTargetCommand", "followTargetCommand", cr2w, this);
				}
				return _followTargetCommand;
			}
			set
			{
				if (_followTargetCommand == value)
				{
					return;
				}
				_followTargetCommand = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("stopWhenDestinationReached")] 
		public CBool StopWhenDestinationReached
		{
			get
			{
				if (_stopWhenDestinationReached == null)
				{
					_stopWhenDestinationReached = (CBool) CR2WTypeManager.Create("Bool", "stopWhenDestinationReached", cr2w, this);
				}
				return _stopWhenDestinationReached;
			}
			set
			{
				if (_stopWhenDestinationReached == value)
				{
					return;
				}
				_stopWhenDestinationReached = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("teleportToTarget")] 
		public CBool TeleportToTarget
		{
			get
			{
				if (_teleportToTarget == null)
				{
					_teleportToTarget = (CBool) CR2WTypeManager.Create("Bool", "teleportToTarget", cr2w, this);
				}
				return _teleportToTarget;
			}
			set
			{
				if (_teleportToTarget == value)
				{
					return;
				}
				_teleportToTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("shouldTeleportNow")] 
		public CBool ShouldTeleportNow
		{
			get
			{
				if (_shouldTeleportNow == null)
				{
					_shouldTeleportNow = (CBool) CR2WTypeManager.Create("Bool", "shouldTeleportNow", cr2w, this);
				}
				return _shouldTeleportNow;
			}
			set
			{
				if (_shouldTeleportNow == value)
				{
					return;
				}
				_shouldTeleportNow = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("teleportDestination")] 
		public Vector4 TeleportDestination
		{
			get
			{
				if (_teleportDestination == null)
				{
					_teleportDestination = (Vector4) CR2WTypeManager.Create("Vector4", "teleportDestination", cr2w, this);
				}
				return _teleportDestination;
			}
			set
			{
				if (_teleportDestination == value)
				{
					return;
				}
				_teleportDestination = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("matchTargetSpeed")] 
		public CBool MatchTargetSpeed
		{
			get
			{
				if (_matchTargetSpeed == null)
				{
					_matchTargetSpeed = (CBool) CR2WTypeManager.Create("Bool", "matchTargetSpeed", cr2w, this);
				}
				return _matchTargetSpeed;
			}
			set
			{
				if (_matchTargetSpeed == value)
				{
					return;
				}
				_matchTargetSpeed = value;
				PropertySet(this);
			}
		}

		public AIMoveCommandsDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
