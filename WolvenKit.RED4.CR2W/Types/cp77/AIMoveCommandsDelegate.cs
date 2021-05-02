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
			get => GetProperty(ref _animMoveOnSplineCommand);
			set => SetProperty(ref _animMoveOnSplineCommand, value);
		}

		[Ordinal(1)] 
		[RED("spline")] 
		public NodeRef Spline
		{
			get => GetProperty(ref _spline);
			set => SetProperty(ref _spline, value);
		}

		[Ordinal(2)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetProperty(ref _useStart);
			set => SetProperty(ref _useStart, value);
		}

		[Ordinal(3)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetProperty(ref _useStop);
			set => SetProperty(ref _useStop, value);
		}

		[Ordinal(4)] 
		[RED("reverse")] 
		public CBool Reverse
		{
			get => GetProperty(ref _reverse);
			set => SetProperty(ref _reverse, value);
		}

		[Ordinal(5)] 
		[RED("controllerSetupName")] 
		public CName ControllerSetupName
		{
			get => GetProperty(ref _controllerSetupName);
			set => SetProperty(ref _controllerSetupName, value);
		}

		[Ordinal(6)] 
		[RED("blendTime")] 
		public CFloat BlendTime
		{
			get => GetProperty(ref _blendTime);
			set => SetProperty(ref _blendTime, value);
		}

		[Ordinal(7)] 
		[RED("globalInBlendTime")] 
		public CFloat GlobalInBlendTime
		{
			get => GetProperty(ref _globalInBlendTime);
			set => SetProperty(ref _globalInBlendTime, value);
		}

		[Ordinal(8)] 
		[RED("globalOutBlendTime")] 
		public CFloat GlobalOutBlendTime
		{
			get => GetProperty(ref _globalOutBlendTime);
			set => SetProperty(ref _globalOutBlendTime, value);
		}

		[Ordinal(9)] 
		[RED("turnCharacterToMatchVelocity")] 
		public CBool TurnCharacterToMatchVelocity
		{
			get => GetProperty(ref _turnCharacterToMatchVelocity);
			set => SetProperty(ref _turnCharacterToMatchVelocity, value);
		}

		[Ordinal(10)] 
		[RED("customStartAnimationName")] 
		public CName CustomStartAnimationName
		{
			get => GetProperty(ref _customStartAnimationName);
			set => SetProperty(ref _customStartAnimationName, value);
		}

		[Ordinal(11)] 
		[RED("customMainAnimationName")] 
		public CName CustomMainAnimationName
		{
			get => GetProperty(ref _customMainAnimationName);
			set => SetProperty(ref _customMainAnimationName, value);
		}

		[Ordinal(12)] 
		[RED("customStopAnimationName")] 
		public CName CustomStopAnimationName
		{
			get => GetProperty(ref _customStopAnimationName);
			set => SetProperty(ref _customStopAnimationName, value);
		}

		[Ordinal(13)] 
		[RED("startSnapToTerrain")] 
		public CBool StartSnapToTerrain
		{
			get => GetProperty(ref _startSnapToTerrain);
			set => SetProperty(ref _startSnapToTerrain, value);
		}

		[Ordinal(14)] 
		[RED("mainSnapToTerrain")] 
		public CBool MainSnapToTerrain
		{
			get => GetProperty(ref _mainSnapToTerrain);
			set => SetProperty(ref _mainSnapToTerrain, value);
		}

		[Ordinal(15)] 
		[RED("stopSnapToTerrain")] 
		public CBool StopSnapToTerrain
		{
			get => GetProperty(ref _stopSnapToTerrain);
			set => SetProperty(ref _stopSnapToTerrain, value);
		}

		[Ordinal(16)] 
		[RED("startSnapToTerrainBlendTime")] 
		public CFloat StartSnapToTerrainBlendTime
		{
			get => GetProperty(ref _startSnapToTerrainBlendTime);
			set => SetProperty(ref _startSnapToTerrainBlendTime, value);
		}

		[Ordinal(17)] 
		[RED("stopSnapToTerrainBlendTime")] 
		public CFloat StopSnapToTerrainBlendTime
		{
			get => GetProperty(ref _stopSnapToTerrainBlendTime);
			set => SetProperty(ref _stopSnapToTerrainBlendTime, value);
		}

		[Ordinal(18)] 
		[RED("moveOnSplineCommand")] 
		public CHandle<AIMoveOnSplineCommand> MoveOnSplineCommand
		{
			get => GetProperty(ref _moveOnSplineCommand);
			set => SetProperty(ref _moveOnSplineCommand, value);
		}

		[Ordinal(19)] 
		[RED("strafingTarget")] 
		public wCHandle<gameObject> StrafingTarget
		{
			get => GetProperty(ref _strafingTarget);
			set => SetProperty(ref _strafingTarget, value);
		}

		[Ordinal(20)] 
		[RED("movementType")] 
		public CEnum<moveMovementType> MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(21)] 
		[RED("ignoreNavigation")] 
		public CBool IgnoreNavigation
		{
			get => GetProperty(ref _ignoreNavigation);
			set => SetProperty(ref _ignoreNavigation, value);
		}

		[Ordinal(22)] 
		[RED("startFromClosestPoint")] 
		public CBool StartFromClosestPoint
		{
			get => GetProperty(ref _startFromClosestPoint);
			set => SetProperty(ref _startFromClosestPoint, value);
		}

		[Ordinal(23)] 
		[RED("useCombatState")] 
		public CBool UseCombatState
		{
			get => GetProperty(ref _useCombatState);
			set => SetProperty(ref _useCombatState, value);
		}

		[Ordinal(24)] 
		[RED("useAlertedState")] 
		public CBool UseAlertedState
		{
			get => GetProperty(ref _useAlertedState);
			set => SetProperty(ref _useAlertedState, value);
		}

		[Ordinal(25)] 
		[RED("noWaitToEndDistance")] 
		public CFloat NoWaitToEndDistance
		{
			get => GetProperty(ref _noWaitToEndDistance);
			set => SetProperty(ref _noWaitToEndDistance, value);
		}

		[Ordinal(26)] 
		[RED("noWaitToEndCompanionDistance")] 
		public CFloat NoWaitToEndCompanionDistance
		{
			get => GetProperty(ref _noWaitToEndCompanionDistance);
			set => SetProperty(ref _noWaitToEndCompanionDistance, value);
		}

		[Ordinal(27)] 
		[RED("lowestCompanionDistanceToEnd")] 
		public CFloat LowestCompanionDistanceToEnd
		{
			get => GetProperty(ref _lowestCompanionDistanceToEnd);
			set => SetProperty(ref _lowestCompanionDistanceToEnd, value);
		}

		[Ordinal(28)] 
		[RED("previousCompanionDistanceToEnd")] 
		public CFloat PreviousCompanionDistanceToEnd
		{
			get => GetProperty(ref _previousCompanionDistanceToEnd);
			set => SetProperty(ref _previousCompanionDistanceToEnd, value);
		}

		[Ordinal(29)] 
		[RED("maxCompanionDistanceOnSpline")] 
		public CFloat MaxCompanionDistanceOnSpline
		{
			get => GetProperty(ref _maxCompanionDistanceOnSpline);
			set => SetProperty(ref _maxCompanionDistanceOnSpline, value);
		}

		[Ordinal(30)] 
		[RED("companion")] 
		public wCHandle<gameObject> Companion
		{
			get => GetProperty(ref _companion);
			set => SetProperty(ref _companion, value);
		}

		[Ordinal(31)] 
		[RED("ignoreLineOfSightCheck")] 
		public CBool IgnoreLineOfSightCheck
		{
			get => GetProperty(ref _ignoreLineOfSightCheck);
			set => SetProperty(ref _ignoreLineOfSightCheck, value);
		}

		[Ordinal(32)] 
		[RED("shootingTarget")] 
		public wCHandle<gameObject> ShootingTarget
		{
			get => GetProperty(ref _shootingTarget);
			set => SetProperty(ref _shootingTarget, value);
		}

		[Ordinal(33)] 
		[RED("minSearchAngle")] 
		public CFloat MinSearchAngle
		{
			get => GetProperty(ref _minSearchAngle);
			set => SetProperty(ref _minSearchAngle, value);
		}

		[Ordinal(34)] 
		[RED("maxSearchAngle")] 
		public CFloat MaxSearchAngle
		{
			get => GetProperty(ref _maxSearchAngle);
			set => SetProperty(ref _maxSearchAngle, value);
		}

		[Ordinal(35)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get => GetProperty(ref _desiredDistance);
			set => SetProperty(ref _desiredDistance, value);
		}

		[Ordinal(36)] 
		[RED("deadZoneRadius")] 
		public CFloat DeadZoneRadius
		{
			get => GetProperty(ref _deadZoneRadius);
			set => SetProperty(ref _deadZoneRadius, value);
		}

		[Ordinal(37)] 
		[RED("shouldBeInFrontOfCompanion")] 
		public CBool ShouldBeInFrontOfCompanion
		{
			get => GetProperty(ref _shouldBeInFrontOfCompanion);
			set => SetProperty(ref _shouldBeInFrontOfCompanion, value);
		}

		[Ordinal(38)] 
		[RED("useMatchForSpeedForPlayer")] 
		public CBool UseMatchForSpeedForPlayer
		{
			get => GetProperty(ref _useMatchForSpeedForPlayer);
			set => SetProperty(ref _useMatchForSpeedForPlayer, value);
		}

		[Ordinal(39)] 
		[RED("lookAtTarget")] 
		public wCHandle<gameObject> LookAtTarget
		{
			get => GetProperty(ref _lookAtTarget);
			set => SetProperty(ref _lookAtTarget, value);
		}

		[Ordinal(40)] 
		[RED("distanceToCompanion")] 
		public CFloat DistanceToCompanion
		{
			get => GetProperty(ref _distanceToCompanion);
			set => SetProperty(ref _distanceToCompanion, value);
		}

		[Ordinal(41)] 
		[RED("splineEndPoint")] 
		public Vector4 SplineEndPoint
		{
			get => GetProperty(ref _splineEndPoint);
			set => SetProperty(ref _splineEndPoint, value);
		}

		[Ordinal(42)] 
		[RED("hasSplineEndPoint")] 
		public CBool HasSplineEndPoint
		{
			get => GetProperty(ref _hasSplineEndPoint);
			set => SetProperty(ref _hasSplineEndPoint, value);
		}

		[Ordinal(43)] 
		[RED("playerCompanion")] 
		public wCHandle<PlayerPuppet> PlayerCompanion
		{
			get => GetProperty(ref _playerCompanion);
			set => SetProperty(ref _playerCompanion, value);
		}

		[Ordinal(44)] 
		[RED("firstWaitingDemandTimestamp")] 
		public CFloat FirstWaitingDemandTimestamp
		{
			get => GetProperty(ref _firstWaitingDemandTimestamp);
			set => SetProperty(ref _firstWaitingDemandTimestamp, value);
		}

		[Ordinal(45)] 
		[RED("useOffMeshLinkReservation")] 
		public CBool UseOffMeshLinkReservation
		{
			get => GetProperty(ref _useOffMeshLinkReservation);
			set => SetProperty(ref _useOffMeshLinkReservation, value);
		}

		[Ordinal(46)] 
		[RED("sprint")] 
		public CBool Sprint
		{
			get => GetProperty(ref _sprint);
			set => SetProperty(ref _sprint, value);
		}

		[Ordinal(47)] 
		[RED("run")] 
		public CBool Run
		{
			get => GetProperty(ref _run);
			set => SetProperty(ref _run, value);
		}

		[Ordinal(48)] 
		[RED("waitForCompanion")] 
		public CBool WaitForCompanion
		{
			get => GetProperty(ref _waitForCompanion);
			set => SetProperty(ref _waitForCompanion, value);
		}

		[Ordinal(49)] 
		[RED("followTargetCommand")] 
		public CHandle<AIFollowTargetCommand> FollowTargetCommand
		{
			get => GetProperty(ref _followTargetCommand);
			set => SetProperty(ref _followTargetCommand, value);
		}

		[Ordinal(50)] 
		[RED("stopWhenDestinationReached")] 
		public CBool StopWhenDestinationReached
		{
			get => GetProperty(ref _stopWhenDestinationReached);
			set => SetProperty(ref _stopWhenDestinationReached, value);
		}

		[Ordinal(51)] 
		[RED("teleportToTarget")] 
		public CBool TeleportToTarget
		{
			get => GetProperty(ref _teleportToTarget);
			set => SetProperty(ref _teleportToTarget, value);
		}

		[Ordinal(52)] 
		[RED("shouldTeleportNow")] 
		public CBool ShouldTeleportNow
		{
			get => GetProperty(ref _shouldTeleportNow);
			set => SetProperty(ref _shouldTeleportNow, value);
		}

		[Ordinal(53)] 
		[RED("teleportDestination")] 
		public Vector4 TeleportDestination
		{
			get => GetProperty(ref _teleportDestination);
			set => SetProperty(ref _teleportDestination, value);
		}

		[Ordinal(54)] 
		[RED("matchTargetSpeed")] 
		public CBool MatchTargetSpeed
		{
			get => GetProperty(ref _matchTargetSpeed);
			set => SetProperty(ref _matchTargetSpeed, value);
		}

		public AIMoveCommandsDelegate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
