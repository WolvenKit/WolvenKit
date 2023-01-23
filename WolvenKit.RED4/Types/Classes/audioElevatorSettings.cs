using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioElevatorSettings : audioEntitySettings
	{
		[Ordinal(6)] 
		[RED("musicEvents")] 
		public audioMusicController MusicEvents
		{
			get => GetPropertyValue<audioMusicController>();
			set => SetPropertyValue<audioMusicController>(value);
		}

		[Ordinal(7)] 
		[RED("movementEvents")] 
		public audioLoopingSoundController MovementEvents
		{
			get => GetPropertyValue<audioLoopingSoundController>();
			set => SetPropertyValue<audioLoopingSoundController>(value);
		}

		[Ordinal(8)] 
		[RED("callingEvent")] 
		public CName CallingEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("destinationReachedEvent")] 
		public CName DestinationReachedEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("panelSelectionEvent")] 
		public CName PanelSelectionEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioElevatorSettings()
		{
			CommonSettings = new() { StopAllSoundsOnDetach = true };
			ScanningSettings = new();
			AuxiliaryMetadata = new();
			MusicEvents = new();
			MovementEvents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
