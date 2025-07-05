using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAcousticZoneMetadata : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("bleadingDistance")] 
		public CFloat BleadingDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("eventsOnEnter")] 
		public CArray<CName> EventsOnEnter
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(4)] 
		[RED("eventsOnExit")] 
		public CArray<CName> EventsOnExit
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(5)] 
		[RED("eventsOnActive")] 
		public CArray<CName> EventsOnActive
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(6)] 
		[RED("soundBanks")] 
		public CArray<CName> SoundBanks
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(7)] 
		[RED("parameters")] 
		public CArray<audioAcousticZoneParameterMapItem> Parameters
		{
			get => GetPropertyValue<CArray<audioAcousticZoneParameterMapItem>>();
			set => SetPropertyValue<CArray<audioAcousticZoneParameterMapItem>>(value);
		}

		[Ordinal(8)] 
		[RED("reverbSettings")] 
		public CName ReverbSettings
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("voReverbSettings")] 
		public CName VoReverbSettings
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("footstepMaterialOverride")] 
		public CName FootstepMaterialOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioAcousticZoneMetadata()
		{
			BleadingDistance = 10.000000F;
			EventsOnEnter = new();
			EventsOnExit = new();
			EventsOnActive = new();
			SoundBanks = new();
			Parameters = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
