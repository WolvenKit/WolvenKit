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
			get => GetProperty(ref _movementType);
			set => SetProperty(ref _movementType, value);
		}

		[Ordinal(1)] 
		[RED("facingTargetRef")] 
		public CHandle<questUniversalRef> FacingTargetRef
		{
			get => GetProperty(ref _facingTargetRef);
			set => SetProperty(ref _facingTargetRef, value);
		}

		[Ordinal(2)] 
		[RED("rotateEntityTowardsFacingTarget")] 
		public CBool RotateEntityTowardsFacingTarget
		{
			get => GetProperty(ref _rotateEntityTowardsFacingTarget);
			set => SetProperty(ref _rotateEntityTowardsFacingTarget, value);
		}

		[Ordinal(3)] 
		[RED("snapToTerrain")] 
		public CBool SnapToTerrain
		{
			get => GetProperty(ref _snapToTerrain);
			set => SetProperty(ref _snapToTerrain, value);
		}

		[Ordinal(4)] 
		[RED("shootingTargetRef")] 
		public CHandle<questUniversalRef> ShootingTargetRef
		{
			get => GetProperty(ref _shootingTargetRef);
			set => SetProperty(ref _shootingTargetRef, value);
		}

		[Ordinal(5)] 
		[RED("companionRef")] 
		public CHandle<questUniversalRef> CompanionRef
		{
			get => GetProperty(ref _companionRef);
			set => SetProperty(ref _companionRef, value);
		}

		[Ordinal(6)] 
		[RED("companionDistancePreset")] 
		public CEnum<gamedataCompanionDistancePreset> CompanionDistancePreset
		{
			get => GetProperty(ref _companionDistancePreset);
			set => SetProperty(ref _companionDistancePreset, value);
		}

		[Ordinal(7)] 
		[RED("companionPosition")] 
		public CEnum<questCompanionPositions> CompanionPosition
		{
			get => GetProperty(ref _companionPosition);
			set => SetProperty(ref _companionPosition, value);
		}

		[Ordinal(8)] 
		[RED("catchUpWithCompanion")] 
		public CBool CatchUpWithCompanion
		{
			get => GetProperty(ref _catchUpWithCompanion);
			set => SetProperty(ref _catchUpWithCompanion, value);
		}

		[Ordinal(9)] 
		[RED("teleportToCompanion")] 
		public CBool TeleportToCompanion
		{
			get => GetProperty(ref _teleportToCompanion);
			set => SetProperty(ref _teleportToCompanion, value);
		}

		[Ordinal(10)] 
		[RED("useMatchForSpeedForPlayer")] 
		public CBool UseMatchForSpeedForPlayer
		{
			get => GetProperty(ref _useMatchForSpeedForPlayer);
			set => SetProperty(ref _useMatchForSpeedForPlayer, value);
		}

		[Ordinal(11)] 
		[RED("ignoreNavigation")] 
		public CBool IgnoreNavigation
		{
			get => GetProperty(ref _ignoreNavigation);
			set => SetProperty(ref _ignoreNavigation, value);
		}

		[Ordinal(12)] 
		[RED("ignoreLineOfSightCheck")] 
		public CBool IgnoreLineOfSightCheck
		{
			get => GetProperty(ref _ignoreLineOfSightCheck);
			set => SetProperty(ref _ignoreLineOfSightCheck, value);
		}

		[Ordinal(13)] 
		[RED("useOffMeshLinkReservation")] 
		public CBool UseOffMeshLinkReservation
		{
			get => GetProperty(ref _useOffMeshLinkReservation);
			set => SetProperty(ref _useOffMeshLinkReservation, value);
		}

		[Ordinal(14)] 
		[RED("lookAtTargetRef")] 
		public CHandle<questUniversalRef> LookAtTargetRef
		{
			get => GetProperty(ref _lookAtTargetRef);
			set => SetProperty(ref _lookAtTargetRef, value);
		}

		[Ordinal(15)] 
		[RED("minSearchAngle")] 
		public CFloat MinSearchAngle
		{
			get => GetProperty(ref _minSearchAngle);
			set => SetProperty(ref _minSearchAngle, value);
		}

		[Ordinal(16)] 
		[RED("maxSearchAngle")] 
		public CFloat MaxSearchAngle
		{
			get => GetProperty(ref _maxSearchAngle);
			set => SetProperty(ref _maxSearchAngle, value);
		}

		[Ordinal(17)] 
		[RED("interruptCapability")] 
		public CEnum<scnInterruptCapability> InterruptCapability
		{
			get => GetProperty(ref _interruptCapability);
			set => SetProperty(ref _interruptCapability, value);
		}

		[Ordinal(18)] 
		[RED("maxCompanionDistanceOnSpline")] 
		public CFloat MaxCompanionDistanceOnSpline
		{
			get => GetProperty(ref _maxCompanionDistanceOnSpline);
			set => SetProperty(ref _maxCompanionDistanceOnSpline, value);
		}

		public questWithCompanionMoveOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
