using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeRoachRaceGameplayController : gameuiarcadeArcadeGameplayController
	{
		[Ordinal(3)] 
		[RED("defaultWorldVelocity")] 
		public CFloat DefaultWorldVelocity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("cycleWorldVelocityMultiplier")] 
		public CFloat CycleWorldVelocityMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("carrotPowerupPointsPerSecond")] 
		public CFloat CarrotPowerupPointsPerSecond
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("carrotPowerupTime")] 
		public CFloat CarrotPowerupTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("carrotPowerupWorldVelocityMultiplier")] 
		public CFloat CarrotPowerupWorldVelocityMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("collisionSFX")] 
		public CName CollisionSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("powerupPickupSFX")] 
		public CName PowerupPickupSFX
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("player")] 
		public inkWidgetReference Player
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("obstacleSpawner")] 
		public inkWidgetReference ObstacleSpawner
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("currentLevelAndCycleText")] 
		public inkTextWidgetReference CurrentLevelAndCycleText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("pointsBoostPickupText")] 
		public inkTextWidgetReference PointsBoostPickupText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("dummy")] 
		public inkWidgetReference Dummy
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("invincibilityCooldownIndicator")] 
		public inkWidgetReference InvincibilityCooldownIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public gameuiarcadeRoachRaceGameplayController()
		{
			Score = new();
			PauseText = new();
			DefaultWorldVelocity = 1.000000F;
			CycleWorldVelocityMultiplier = 1.100000F;
			CarrotPowerupPointsPerSecond = 2.000000F;
			CarrotPowerupTime = 6.000000F;
			CarrotPowerupWorldVelocityMultiplier = 1.500000F;
			Player = new();
			ObstacleSpawner = new();
			Background = new();
			CurrentLevelAndCycleText = new();
			PointsBoostPickupText = new();
			Dummy = new();
			InvincibilityCooldownIndicator = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
