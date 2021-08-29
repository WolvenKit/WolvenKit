using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioElevatorSettings : audioEntitySettings
	{
		private audioMusicController _musicEvents;
		private audioLoopingSoundController _movementEvents;
		private CName _callingEvent;
		private CName _destinationReachedEvent;
		private CName _panelSelectionEvent;

		[Ordinal(6)] 
		[RED("musicEvents")] 
		public audioMusicController MusicEvents
		{
			get => GetProperty(ref _musicEvents);
			set => SetProperty(ref _musicEvents, value);
		}

		[Ordinal(7)] 
		[RED("movementEvents")] 
		public audioLoopingSoundController MovementEvents
		{
			get => GetProperty(ref _movementEvents);
			set => SetProperty(ref _movementEvents, value);
		}

		[Ordinal(8)] 
		[RED("callingEvent")] 
		public CName CallingEvent
		{
			get => GetProperty(ref _callingEvent);
			set => SetProperty(ref _callingEvent, value);
		}

		[Ordinal(9)] 
		[RED("destinationReachedEvent")] 
		public CName DestinationReachedEvent
		{
			get => GetProperty(ref _destinationReachedEvent);
			set => SetProperty(ref _destinationReachedEvent, value);
		}

		[Ordinal(10)] 
		[RED("panelSelectionEvent")] 
		public CName PanelSelectionEvent
		{
			get => GetProperty(ref _panelSelectionEvent);
			set => SetProperty(ref _panelSelectionEvent, value);
		}
	}
}
