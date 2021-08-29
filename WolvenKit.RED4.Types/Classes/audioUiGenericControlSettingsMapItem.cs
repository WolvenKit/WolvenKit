using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioUiGenericControlSettingsMapItem : audioAudioMetadata
	{
		private CHandle<audioKeySoundEventDictionary> _uiEventToAudioEventDictionary;

		[Ordinal(1)] 
		[RED("uiEventToAudioEventDictionary")] 
		public CHandle<audioKeySoundEventDictionary> UiEventToAudioEventDictionary
		{
			get => GetProperty(ref _uiEventToAudioEventDictionary);
			set => SetProperty(ref _uiEventToAudioEventDictionary, value);
		}
	}
}
