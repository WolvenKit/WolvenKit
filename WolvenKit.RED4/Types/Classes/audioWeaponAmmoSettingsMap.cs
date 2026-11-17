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
			StandardFlyby = new audioFlybySettings();
			SniperFlyby = new audioFlybySettings();
			ShotFlyby = new audioFlybySettings();
			RailFlyby = new audioFlybySettings();
			AutomaticFlyby = new audioFlybySettings();
			SmartFlyby = new audioFlybySettings();
			SmartSniperFlyby = new audioFlybySettings();
			HmgFlyby = new audioFlybySettings();
			FlybyMinDistance = 5.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
