using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioKeyUiSoundPairDictionaryItem : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("key")] 
		public CName Key
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public audioUiSound Value
		{
			get => GetPropertyValue<audioUiSound>();
			set => SetPropertyValue<audioUiSound>(value);
		}

		public audioKeyUiSoundPairDictionaryItem()
		{
			Value = new audioUiSound { Events = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
