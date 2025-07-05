using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioRadioStationMetadataMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("radioStations")] 
		public CArray<CName> RadioStations
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("switchStationEvent")] 
		public CName SwitchStationEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("turnOnRadioEvent")] 
		public CName TurnOnRadioEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("turnOffRadioEvent")] 
		public CName TurnOffRadioEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("defaultBackgroundJingle")] 
		public audioRadioStationJingleMetadata DefaultBackgroundJingle
		{
			get => GetPropertyValue<audioRadioStationJingleMetadata>();
			set => SetPropertyValue<audioRadioStationJingleMetadata>(value);
		}

		public audioRadioStationMetadataMap()
		{
			RadioStations = new();
			DefaultBackgroundJingle = new audioRadioStationJingleMetadata();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
