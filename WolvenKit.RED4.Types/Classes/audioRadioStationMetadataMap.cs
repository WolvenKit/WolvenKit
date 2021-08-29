using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioRadioStationMetadataMap : audioAudioMetadata
	{
		private CArray<CName> _radioStations;
		private CName _switchStationEvent;
		private CName _turnOnRadioEvent;
		private CName _turnOffRadioEvent;
		private audioRadioStationJingleMetadata _defaultBackgroundJingle;

		[Ordinal(1)] 
		[RED("radioStations")] 
		public CArray<CName> RadioStations
		{
			get => GetProperty(ref _radioStations);
			set => SetProperty(ref _radioStations, value);
		}

		[Ordinal(2)] 
		[RED("switchStationEvent")] 
		public CName SwitchStationEvent
		{
			get => GetProperty(ref _switchStationEvent);
			set => SetProperty(ref _switchStationEvent, value);
		}

		[Ordinal(3)] 
		[RED("turnOnRadioEvent")] 
		public CName TurnOnRadioEvent
		{
			get => GetProperty(ref _turnOnRadioEvent);
			set => SetProperty(ref _turnOnRadioEvent, value);
		}

		[Ordinal(4)] 
		[RED("turnOffRadioEvent")] 
		public CName TurnOffRadioEvent
		{
			get => GetProperty(ref _turnOffRadioEvent);
			set => SetProperty(ref _turnOffRadioEvent, value);
		}

		[Ordinal(5)] 
		[RED("defaultBackgroundJingle")] 
		public audioRadioStationJingleMetadata DefaultBackgroundJingle
		{
			get => GetProperty(ref _defaultBackgroundJingle);
			set => SetProperty(ref _defaultBackgroundJingle, value);
		}
	}
}
