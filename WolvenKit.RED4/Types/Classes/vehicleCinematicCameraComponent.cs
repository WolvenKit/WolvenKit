using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleCinematicCameraComponent : gameCameraComponent
	{
		[Ordinal(35)] 
		[RED("teleportThisFrame")] 
		public CBool TeleportThisFrame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("targetTransform")] 
		public WorldTransform TargetTransform
		{
			get => GetPropertyValue<WorldTransform>();
			set => SetPropertyValue<WorldTransform>(value);
		}

		[Ordinal(37)] 
		[RED("groups")] 
		public CArray<vehicleCinematicCameraShotGroup> Groups
		{
			get => GetPropertyValue<CArray<vehicleCinematicCameraShotGroup>>();
			set => SetPropertyValue<CArray<vehicleCinematicCameraShotGroup>>(value);
		}

		[Ordinal(38)] 
		[RED("middleZoneSizeForShotSelection")] 
		public CFloat MiddleZoneSizeForShotSelection
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(39)] 
		[RED("consecutiveStaticShotsProbabilityBonus")] 
		public CInt32 ConsecutiveStaticShotsProbabilityBonus
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(40)] 
		[RED("consecutiveDynamicShotsProbabilityBonus")] 
		public CInt32 ConsecutiveDynamicShotsProbabilityBonus
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(41)] 
		[RED("maxProbabilityBonusFromCameraProximityToShot")] 
		public CFloat MaxProbabilityBonusFromCameraProximityToShot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(42)] 
		[RED("maxDistanceFromCameraToHaveProbabilityBonusForShot")] 
		public CFloat MaxDistanceFromCameraToHaveProbabilityBonusForShot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(43)] 
		[RED("lastChangeTime")] 
		public CFloat LastChangeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(44)] 
		[RED("shotChangeRequested")] 
		public CBool ShotChangeRequested
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("currentShot")] 
		public CHandle<vehicleCinematicCameraShot> CurrentShot
		{
			get => GetPropertyValue<CHandle<vehicleCinematicCameraShot>>();
			set => SetPropertyValue<CHandle<vehicleCinematicCameraShot>>(value);
		}

		[Ordinal(46)] 
		[RED("lastShot")] 
		public CHandle<vehicleCinematicCameraShot> LastShot
		{
			get => GetPropertyValue<CHandle<vehicleCinematicCameraShot>>();
			set => SetPropertyValue<CHandle<vehicleCinematicCameraShot>>(value);
		}

		public vehicleCinematicCameraComponent()
		{
			TargetTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };
			Groups = new();
			MiddleZoneSizeForShotSelection = 0.500000F;
			ConsecutiveStaticShotsProbabilityBonus = 2;
			ConsecutiveDynamicShotsProbabilityBonus = 1;
			MaxProbabilityBonusFromCameraProximityToShot = 3.000000F;
			MaxDistanceFromCameraToHaveProbabilityBonusForShot = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
