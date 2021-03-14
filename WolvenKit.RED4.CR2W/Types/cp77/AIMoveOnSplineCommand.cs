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

		[Ordinal(8)] 
		[RED("movementType")] 
		public AIMovementTypeSpec MovementType
		{
			get
			{
				if (_movementType == null)
				{
					_movementType = (AIMovementTypeSpec) CR2WTypeManager.Create("AIMovementTypeSpec", "movementType", cr2w, this);
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

		[Ordinal(9)] 
		[RED("rotateEntityTowardsFacingTarget")] 
		public CBool RotateEntityTowardsFacingTarget
		{
			get
			{
				if (_rotateEntityTowardsFacingTarget == null)
				{
					_rotateEntityTowardsFacingTarget = (CBool) CR2WTypeManager.Create("Bool", "rotateEntityTowardsFacingTarget", cr2w, this);
				}
				return _rotateEntityTowardsFacingTarget;
			}
			set
			{
				if (_rotateEntityTowardsFacingTarget == value)
				{
					return;
				}
				_rotateEntityTowardsFacingTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("facingTarget")] 
		public wCHandle<gameObject> FacingTarget
		{
			get
			{
				if (_facingTarget == null)
				{
					_facingTarget = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "facingTarget", cr2w, this);
				}
				return _facingTarget;
			}
			set
			{
				if (_facingTarget == value)
				{
					return;
				}
				_facingTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("catchUpWithCompanion")] 
		public CBool CatchUpWithCompanion
		{
			get
			{
				if (_catchUpWithCompanion == null)
				{
					_catchUpWithCompanion = (CBool) CR2WTypeManager.Create("Bool", "catchUpWithCompanion", cr2w, this);
				}
				return _catchUpWithCompanion;
			}
			set
			{
				if (_catchUpWithCompanion == value)
				{
					return;
				}
				_catchUpWithCompanion = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("teleportToCompanion")] 
		public CBool TeleportToCompanion
		{
			get
			{
				if (_teleportToCompanion == null)
				{
					_teleportToCompanion = (CBool) CR2WTypeManager.Create("Bool", "teleportToCompanion", cr2w, this);
				}
				return _teleportToCompanion;
			}
			set
			{
				if (_teleportToCompanion == value)
				{
					return;
				}
				_teleportToCompanion = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
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

		[Ordinal(20)] 
		[RED("snapToTerrain")] 
		public CBool SnapToTerrain
		{
			get
			{
				if (_snapToTerrain == null)
				{
					_snapToTerrain = (CBool) CR2WTypeManager.Create("Bool", "snapToTerrain", cr2w, this);
				}
				return _snapToTerrain;
			}
			set
			{
				if (_snapToTerrain == value)
				{
					return;
				}
				_snapToTerrain = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
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

		[Ordinal(22)] 
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

		[Ordinal(23)] 
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

		[Ordinal(24)] 
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

		[Ordinal(25)] 
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

		[Ordinal(26)] 
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

		[Ordinal(27)] 
		[RED("useOMLReservation")] 
		public CBool UseOMLReservation
		{
			get
			{
				if (_useOMLReservation == null)
				{
					_useOMLReservation = (CBool) CR2WTypeManager.Create("Bool", "useOMLReservation", cr2w, this);
				}
				return _useOMLReservation;
			}
			set
			{
				if (_useOMLReservation == value)
				{
					return;
				}
				_useOMLReservation = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
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

		[Ordinal(29)] 
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

		[Ordinal(30)] 
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

		[Ordinal(31)] 
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

		[Ordinal(32)] 
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

		[Ordinal(33)] 
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

		public AIMoveOnSplineCommand(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
