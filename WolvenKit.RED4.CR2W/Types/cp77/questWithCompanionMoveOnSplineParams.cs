using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questWithCompanionMoveOnSplineParams : CVariable
	{
		private AIMovementTypeSpec _movementType;
		private CHandle<questUniversalRef> _facingTargetRef;
		private CBool _rotateEntityTowardsFacingTarget;
		private CBool _snapToTerrain;
		private CHandle<questUniversalRef> _shootingTargetRef;
		private CHandle<questUniversalRef> _companionRef;
		private CEnum<gamedataCompanionDistancePreset> _companionDistancePreset;
		private CEnum<questCompanionPositions> _companionPosition;
		private CBool _catchUpWithCompanion;
		private CBool _teleportToCompanion;
		private CBool _useMatchForSpeedForPlayer;
		private CBool _ignoreNavigation;
		private CBool _ignoreLineOfSightCheck;
		private CBool _useOffMeshLinkReservation;
		private CHandle<questUniversalRef> _lookAtTargetRef;
		private CFloat _minSearchAngle;
		private CFloat _maxSearchAngle;
		private CEnum<scnInterruptCapability> _interruptCapability;
		private CFloat _maxCompanionDistanceOnSpline;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("facingTargetRef")] 
		public CHandle<questUniversalRef> FacingTargetRef
		{
			get
			{
				if (_facingTargetRef == null)
				{
					_facingTargetRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "facingTargetRef", cr2w, this);
				}
				return _facingTargetRef;
			}
			set
			{
				if (_facingTargetRef == value)
				{
					return;
				}
				_facingTargetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("shootingTargetRef")] 
		public CHandle<questUniversalRef> ShootingTargetRef
		{
			get
			{
				if (_shootingTargetRef == null)
				{
					_shootingTargetRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "shootingTargetRef", cr2w, this);
				}
				return _shootingTargetRef;
			}
			set
			{
				if (_shootingTargetRef == value)
				{
					return;
				}
				_shootingTargetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("companionRef")] 
		public CHandle<questUniversalRef> CompanionRef
		{
			get
			{
				if (_companionRef == null)
				{
					_companionRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "companionRef", cr2w, this);
				}
				return _companionRef;
			}
			set
			{
				if (_companionRef == value)
				{
					return;
				}
				_companionRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("companionDistancePreset")] 
		public CEnum<gamedataCompanionDistancePreset> CompanionDistancePreset
		{
			get
			{
				if (_companionDistancePreset == null)
				{
					_companionDistancePreset = (CEnum<gamedataCompanionDistancePreset>) CR2WTypeManager.Create("gamedataCompanionDistancePreset", "companionDistancePreset", cr2w, this);
				}
				return _companionDistancePreset;
			}
			set
			{
				if (_companionDistancePreset == value)
				{
					return;
				}
				_companionDistancePreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("companionPosition")] 
		public CEnum<questCompanionPositions> CompanionPosition
		{
			get
			{
				if (_companionPosition == null)
				{
					_companionPosition = (CEnum<questCompanionPositions>) CR2WTypeManager.Create("questCompanionPositions", "companionPosition", cr2w, this);
				}
				return _companionPosition;
			}
			set
			{
				if (_companionPosition == value)
				{
					return;
				}
				_companionPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("lookAtTargetRef")] 
		public CHandle<questUniversalRef> LookAtTargetRef
		{
			get
			{
				if (_lookAtTargetRef == null)
				{
					_lookAtTargetRef = (CHandle<questUniversalRef>) CR2WTypeManager.Create("handle:questUniversalRef", "lookAtTargetRef", cr2w, this);
				}
				return _lookAtTargetRef;
			}
			set
			{
				if (_lookAtTargetRef == value)
				{
					return;
				}
				_lookAtTargetRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
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

		[Ordinal(16)] 
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

		[Ordinal(17)] 
		[RED("interruptCapability")] 
		public CEnum<scnInterruptCapability> InterruptCapability
		{
			get
			{
				if (_interruptCapability == null)
				{
					_interruptCapability = (CEnum<scnInterruptCapability>) CR2WTypeManager.Create("scnInterruptCapability", "interruptCapability", cr2w, this);
				}
				return _interruptCapability;
			}
			set
			{
				if (_interruptCapability == value)
				{
					return;
				}
				_interruptCapability = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
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

		public questWithCompanionMoveOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
