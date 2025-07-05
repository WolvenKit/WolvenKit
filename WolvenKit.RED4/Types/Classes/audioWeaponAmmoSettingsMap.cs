using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioWeaponAmmoSettingsMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("standardFlyby")] 
		public audioFlybySettings StandardFlyby
		{
			get => GetPropertyValue<audioFlybySettings>();
			set => SetPropertyValue<audioFlybySettings>(value);
		}

		[Ordinal(2)] 
		[RED("sniperFlyby")] 
		public audioFlybySettings SniperFlyby
		{
			get => GetPropertyValue<audioFlybySettings>();
			set => SetPropertyValue<audioFlybySettings>(value);
		}

		[Ordinal(3)] 
		[RED("shotFlyby")] 
		public audioFlybySettings ShotFlyby
		{
			get => GetPropertyValue<audioFlybySettings>();
			set => SetPropertyValue<audioFlybySettings>(value);
		}

		[Ordinal(4)] 
		[RED("railFlyby")] 
		public audioFlybySettings RailFlyby
		{
			get => GetPropertyValue<audioFlybySettings>();
			set => SetPropertyValue<audioFlybySettings>(value);
		}

		[Ordinal(5)] 
		[RED("automaticFlyby")] 
		public audioFlybySettings AutomaticFlyby
		{
			get => GetPropertyValue<audioFlybySettings>();
			set => SetPropertyValue<audioFlybySettings>(value);
		}

		[Ordinal(6)] 
		[RED("smartFlyby")] 
		public audioFlybySettings SmartFlyby
		{
			get => GetPropertyValue<audioFlybySettings>();
			set => SetPropertyValue<audioFlybySettings>(value);
		}

		[Ordinal(7)] 
		[RED("smartSniperFlyby")] 
		public audioFlybySettings SmartSniperFlyby
		{
			get => GetPropertyValue<audioFlybySettings>();
			set => SetPropertyValue<audioFlybySettings>(value);
		}

		[Ordinal(8)] 
		[RED("hmgFlyby")] 
		public audioFlybySettings HmgFlyby
		{
			get => GetPropertyValue<audioFlybySettings>();
			set => SetPropertyValue<audioFlybySettings>(value);
		}

		[Ordinal(9)] 
		[RED("flybyMinDistance")] 
		public CFloat FlybyMinDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public audioWeaponAmmoSettingsMap()
		{
			StandardFlyby = new audioFlybySettings { MovementSpeed = 15.000000F };
			SniperFlyby = new audioFlybySettings { MovementSpeed = 15.000000F };
			ShotFlyby = new audioFlybySettings { MovementSpeed = 15.000000F };
			RailFlyby = new audioFlybySettings { MovementSpeed = 15.000000F };
			AutomaticFlyby = new audioFlybySettings { MovementSpeed = 15.000000F };
			SmartFlyby = new audioFlybySettings { MovementSpeed = 15.000000F };
			SmartSniperFlyby = new audioFlybySettings { MovementSpeed = 15.000000F };
			HmgFlyby = new audioFlybySettings { MovementSpeed = 15.000000F };
			FlybyMinDistance = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
