using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioUiControlEventsSettingsMapItem : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("baseEvent")] 
		public CName BaseEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("customActionsDictionary")] 
		public CHandle<audioKeySoundEventDictionary> CustomActionsDictionary
		{
			get => GetPropertyValue<CHandle<audioKeySoundEventDictionary>>();
			set => SetPropertyValue<CHandle<audioKeySoundEventDictionary>>(value);
		}

		public audioUiControlEventsSettingsMapItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
