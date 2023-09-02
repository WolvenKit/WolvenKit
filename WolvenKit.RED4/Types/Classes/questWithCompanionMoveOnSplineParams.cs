using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questWithCompanionMoveOnSplineParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("movementType")] 
		public AIMovementTypeSpec MovementType
		{
			get => GetPropertyValue<AIMovementTypeSpec>();
			set => SetPropertyValue<AIMovementTypeSpec>(value);
		}

		[Ordinal(1)] 
		[RED("facingTargetRef")] 
		public CHandle<questUniversalRef> FacingTargetRef
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(2)] 
		[RED("rotateEntityTowardsFacingTarget")] 
		public CBool RotateEntityTowardsFacingTarget
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("snapToTerrain")] 
		public CBool SnapToTerrain
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("shootingTargetRef")] 
		public CHandle<questUniversalRef> ShootingTargetRef
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(5)] 
		[RED("companionRef")] 
		public CHandle<questUniversalRef> CompanionRef
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(6)] 
		[RED("companionDistancePreset")] 
		public CEnum<gamedataCompanionDistancePreset> CompanionDistancePreset
		{
			get => GetPropertyValue<CEnum<gamedataCompanionDistancePreset>>();
			set => SetPropertyValue<CEnum<gamedataCompanionDistancePreset>>(value);
		}

		[Ordinal(7)] 
		[RED("companionPosition")] 
		public CEnum<questCompanionPositions> CompanionPosition
		{
			get => GetPropertyValue<CEnum<questCompanionPositions>>();
			set => SetPropertyValue<CEnum<questCompanionPositions>>(value);
		}

		[Ordinal(8)] 
		[RED("catchUpWithCompanion")] 
		public CBool CatchUpWithCompanion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("teleportToCompanion")] 
		public CBool TeleportToCompanion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("useMatchForSpeedForPlayer")] 
		public CBool UseMatchForSpeedForPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("ignoreNavigation")] 
		public CBool IgnoreNavigation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("ignoreLineOfSightCheck")] 
		public CBool IgnoreLineOfSightCheck
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("useOffMeshLinkReservation")] 
		public CBool UseOffMeshLinkReservation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(14)] 
		[RED("lookAtTargetRef")] 
		public CHandle<questUniversalRef> LookAtTargetRef
		{
			get => GetPropertyValue<CHandle<questUniversalRef>>();
			set => SetPropertyValue<CHandle<questUniversalRef>>(value);
		}

		[Ordinal(15)] 
		[RED("minSearchAngle")] 
		public CFloat MinSearchAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("maxSearchAngle")] 
		public CFloat MaxSearchAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("interruptCapability")] 
		public CEnum<scnInterruptCapability> InterruptCapability
		{
			get => GetPropertyValue<CEnum<scnInterruptCapability>>();
			set => SetPropertyValue<CEnum<scnInterruptCapability>>(value);
		}

		[Ordinal(18)] 
		[RED("maxCompanionDistanceOnSpline")] 
		public CFloat MaxCompanionDistanceOnSpline
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public questWithCompanionMoveOnSplineParams()
		{
			MovementType = new AIMovementTypeSpec { UseNPCMovementParams = true };
			CompanionDistancePreset = Enums.gamedataCompanionDistancePreset.Medium;
			CatchUpWithCompanion = true;
			TeleportToCompanion = true;
			MinSearchAngle = 22.500000F;
			MaxSearchAngle = 60.000000F;
			InterruptCapability = Enums.scnInterruptCapability.NotInterruptable;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
