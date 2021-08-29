using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioUiControlEventsSettingsMapItem : audioAudioMetadata
	{
		private CName _baseEvent;
		private CHandle<audioKeySoundEventDictionary> _customActionsDictionary;

		[Ordinal(1)] 
		[RED("baseEvent")] 
		public CName BaseEvent
		{
			get => GetProperty(ref _baseEvent);
			set => SetProperty(ref _baseEvent, value);
		}

		[Ordinal(2)] 
		[RED("customActionsDictionary")] 
		public CHandle<audioKeySoundEventDictionary> CustomActionsDictionary
		{
			get => GetProperty(ref _customActionsDictionary);
			set => SetProperty(ref _customActionsDictionary, value);
		}
	}
}
