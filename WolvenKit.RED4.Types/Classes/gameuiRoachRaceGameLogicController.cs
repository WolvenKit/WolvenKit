using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiRoachRaceGameLogicController : gameuiSideScrollerMiniGameLogicController
	{
		[Ordinal(10)] 
		[RED("jumpAcceleration")] 
		public CFloat JumpAcceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("jumpCancelAcceleration")] 
		public CFloat JumpCancelAcceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("gravity")] 
		public CFloat Gravity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("playerSpawnPoint")] 
		public Vector2 PlayerSpawnPoint
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(14)] 
		[RED("pixelsPerScore")] 
		public CFloat PixelsPerScore
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("invincibilityTime")] 
		public CFloat InvincibilityTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("maxSpeedMultiplier")] 
		public CFloat MaxSpeedMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("multiplierPerScore")] 
		public CFloat MultiplierPerScore
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("house")] 
		public inkWidgetReference House
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("ground")] 
		public inkWidgetReference Ground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("startAnimation")] 
		public CName StartAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("deathAnimation")] 
		public CName DeathAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("layers")] 
		public CArray<gameuiRoachRaceChunkLayer> Layers
		{
			get => GetPropertyValue<CArray<gameuiRoachRaceChunkLayer>>();
			set => SetPropertyValue<CArray<gameuiRoachRaceChunkLayer>>(value);
		}

		[Ordinal(23)] 
		[RED("damageAnimation")] 
		public CName DamageAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("healAnimation")] 
		public CName HealAnimation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("healthText")] 
		public inkTextWidgetReference HealthText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("scoreText")] 
		public inkTextWidgetReference ScoreText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(27)] 
		[RED("scoreMultiplierText")] 
		public inkTextWidgetReference ScoreMultiplierText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("previousHealth")] 
		public CInt32 PreviousHealth
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameuiRoachRaceGameLogicController()
		{
			PlayerSpawnPoint = new();
			MaxSpeedMultiplier = 2.000000F;
			MultiplierPerScore = 0.020000F;
			House = new();
			Ground = new();
			Layers = new();
			HealthText = new();
			ScoreText = new();
			ScoreMultiplierText = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
