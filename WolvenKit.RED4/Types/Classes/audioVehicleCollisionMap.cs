using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVehicleCollisionMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("minImpactVelocityThreshold")] 
		public CFloat MinImpactVelocityThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("minRumbleVelocityThreshold")] 
		public CFloat MinRumbleVelocityThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("rumbleCooldown")] 
		public CFloat RumbleCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("scrapingMinTangentialVelocityThreshold")] 
		public CFloat ScrapingMinTangentialVelocityThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("scrapingMaxCollisionCooldown")] 
		public CFloat ScrapingMaxCollisionCooldown
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("scrapingMinVehicleUpCollisionContactAngle")] 
		public CFloat ScrapingMinVehicleUpCollisionContactAngle
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("useScrapingMinVehicleUpCollisionContactAngle")] 
		public CBool UseScrapingMinVehicleUpCollisionContactAngle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("explosionEvent")] 
		public CName ExplosionEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("bigFireEvent")] 
		public CName BigFireEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("engineFireEvent")] 
		public CName EngineFireEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("coolerDamageEvent")] 
		public CName CoolerDamageEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("interiorCollisionEvent")] 
		public CName InteriorCollisionEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("collisionSettings")] 
		public CArray<audioVehicleCollisionMapItem> CollisionSettings
		{
			get => GetPropertyValue<CArray<audioVehicleCollisionMapItem>>();
			set => SetPropertyValue<CArray<audioVehicleCollisionMapItem>>(value);
		}

		public audioVehicleCollisionMap()
		{
			MinImpactVelocityThreshold = 0.800000F;
			MinRumbleVelocityThreshold = 0.800000F;
			RumbleCooldown = 0.600000F;
			ScrapingMinTangentialVelocityThreshold = 5.000000F;
			ScrapingMaxCollisionCooldown = 0.200000F;
			ScrapingMinVehicleUpCollisionContactAngle = 30.000000F;
			UseScrapingMinVehicleUpCollisionContactAngle = true;
			CollisionSettings = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
