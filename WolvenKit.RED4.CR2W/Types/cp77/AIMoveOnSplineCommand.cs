using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIMoveOnSplineCommand : AIMoveCommand
	{
		private NodeRef _spline;
		private AIMovementTypeSpec _movementType;
		private CBool _rotateEntityTowardsFacingTarget;
		private wCHandle<gameObject> _facingTarget;
		private wCHandle<gameObject> _shootingTarget;
		private wCHandle<gameObject> _companion;
		private CFloat _desiredDistance;
		private CFloat _deadZoneRadius;
		private CBool _catchUpWithCompanion;
		private CBool _teleportToCompanion;
		private CBool _useMatchForSpeedForPlayer;
		private CBool _startFromClosestPoint;
		private CBool _ignoreNavigation;
		private CBool _snapToTerrain;
		private CBool _ignoreLineOfSightCheck;
		private CBool _useAlertedState;
		private CBool _useStart;
		private CBool _useStop;
		private CBool _useCombatState;
		private CBool _reverse;
		private CBool _useOMLReservation;
		private wCHandle<gameObject> _lookAtTarget;
		private CFloat _minSearchAngle;
		private CFloat _maxSearchAngle;
		private CFloat _noWaitToEndDistance;
		private CFloat _noWaitToEndCompanionDistance;
		private CFloat _maxCompanionDistanceOnSpline;

		[Ordinal(7)] 
		[RED("spline")] 
		public NodeRef Spline
		{
			get => GetProperty(ref _spline);
			set => SetProperty(ref _spline, value);
		}

		[Ordinal(8)] 
		[RED("movementType")] 
		public AIMovementTypeSpec MovementType
		{
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(9)] 
		[RED("rotateEntityTowardsFacingTarget")] 
		public CBool RotateEntityTowardsFacingTarget
		{
			get => GetProperty(ref _rotateEntityTowardsFacingTarget);
			set => SetProperty(ref _rotateEntityTowardsFacingTarget, value);
		}

		[Ordinal(10)] 
		[RED("facingTarget")] 
		public wCHandle<gameObject> FacingTarget
		{
			get => GetProperty(ref _facingTarget);
			set => SetProperty(ref _facingTarget, value);
		}

		[Ordinal(11)] 
		[RED("shootingTarget")] 
		public wCHandle<gameObject> ShootingTarget
		{
			get => GetProperty(ref _shootingTarget);
			set => SetProperty(ref _shootingTarget, value);
		}

		[Ordinal(12)] 
		[RED("companion")] 
		public wCHandle<gameObject> Companion
		{
			get => GetProperty(ref _companion);
			set => SetProperty(ref _companion, value);
		}

		[Ordinal(13)] 
		[RED("desiredDistance")] 
		public CFloat DesiredDistance
		{
			get => GetProperty(ref _desiredDistance);
			set => SetProperty(ref _desiredDistance, value);
		}

		[Ordinal(14)] 
		[RED("deadZoneRadius")] 
		public CFloat DeadZoneRadius
		{
			get => GetProperty(ref _deadZoneRadius);
			set => SetProperty(ref _deadZoneRadius, value);
		}

		[Ordinal(15)] 
		[RED("catchUpWithCompanion")] 
		public CBool CatchUpWithCompanion
		{
			get => GetProperty(ref _catchUpWithCompanion);
			set => SetProperty(ref _catchUpWithCompanion, value);
		}

		[Ordinal(16)] 
		[RED("teleportToCompanion")] 
		public CBool TeleportToCompanion
		{
			get => GetProperty(ref _teleportToCompanion);
			set => SetProperty(ref _teleportToCompanion, value);
		}

		[Ordinal(17)] 
		[RED("useMatchForSpeedForPlayer")] 
		public CBool UseMatchForSpeedForPlayer
		{
			get => GetProperty(ref _useMatchForSpeedForPlayer);
			set => SetProperty(ref _useMatchForSpeedForPlayer, value);
		}

		[Ordinal(18)] 
		[RED("startFromClosestPoint")] 
		public CBool StartFromClosestPoint
		{
			get => GetProperty(ref _startFromClosestPoint);
			set => SetProperty(ref _startFromClosestPoint, value);
		}

		[Ordinal(19)] 
		[RED("ignoreNavigation")] 
		public CBool IgnoreNavigation
		{
			get => GetProperty(ref _ignoreNavigation);
			set => SetProperty(ref _ignoreNavigation, value);
		}

		[Ordinal(20)] 
		[RED("snapToTerrain")] 
		public CBool SnapToTerrain
		{
			get => GetProperty(ref _snapToTerrain);
			set => SetProperty(ref _snapToTerrain, value);
		}

		[Ordinal(21)] 
		[RED("ignoreLineOfSightCheck")] 
		public CBool IgnoreLineOfSightCheck
		{
			get => GetProperty(ref _ignoreLineOfSightCheck);
			set => SetProperty(ref _ignoreLineOfSightCheck, value);
		}

		[Ordinal(22)] 
		[RED("useAlertedState")] 
		public CBool UseAlertedState
		{
			get => GetProperty(ref _useAlertedState);
			set => SetProperty(ref _useAlertedState, value);
		}

		[Ordinal(23)] 
		[RED("useStart")] 
		public CBool UseStart
		{
			get => GetProperty(ref _useStart);
			set => SetProperty(ref _useStart, value);
		}

		[Ordinal(24)] 
		[RED("useStop")] 
		public CBool UseStop
		{
			get => GetProperty(ref _useStop);
			set => SetProperty(ref _useStop, value);
		}

		[Ordinal(25)] 
		[RED("useCombatState")] 
		public CBool UseCombatState
		{
			get => GetProperty(ref _useCombatState);
			set => SetProperty(ref _useCombatState, value);
		}

		[Ordinal(26)] 
		[RED("reverse")] 
		public CBool Reverse
		{
			get => GetProperty(ref _reverse);
			set => SetProperty(ref _reverse, value);
		}

		[Ordinal(27)] 
		[RED("useOMLReservation")] 
		public CBool UseOMLReservation
		{
			get => GetProperty(ref _useOMLReservation);
			set => SetProperty(ref _useOMLReservation, value);
		}

		[Ordinal(28)] 
		[RED("lookAtTarget")] 
		public wCHandle<gameObject> LookAtTarget
		{
			get => GetProperty(ref _lookAtTarget);
			set => SetProperty(ref _lookAtTarget, value);
		}

		[Ordinal(29)] 
		[RED("minSearchAngle")] 
		public CFloat MinSearchAngle
		{
			get => GetProperty(ref _minSearchAngle);
			set => SetProperty(ref _minSearchAngle, value);
		}

		[Ordinal(30)] 
		[RED("maxSearchAngle")] 
		public CFloat MaxSearchAngle
		{
			get => GetProperty(ref _maxSearchAngle);
			set => SetProperty(ref _maxSearchAngle, value);
		}

		[Ordinal(31)] 
		[RED("noWaitToEndDistance")] 
		public CFloat NoWaitToEndDistance
		{
			get => GetProperty(ref _noWaitToEndDistance);
			set => SetProperty(ref _noWaitToEndDistance, value);
		}

		[Ordinal(32)] 
		[RED("noWaitToEndCompanionDistance")] 
		public CFloat NoWaitToEndCompanionDistance
		{
			get => GetProperty(ref _noWaitToEndCompanionDistance);
			set => SetProperty(ref _noWaitToEndCompanionDistance, value);
		}

		[Ordinal(33)] 
		[RED("maxCompanionDistanceOnSpline")] 
		public CFloat MaxCompanionDistanceOnSpline
		{
			get => GetProperty(ref _maxCompanionDistanceOnSpline);
			set => SetProperty(ref _maxCompanionDistanceOnSpline, value);
		}

		public AIMoveOnSplineCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
