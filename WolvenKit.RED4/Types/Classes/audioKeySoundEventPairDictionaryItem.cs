using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioKeySoundEventPairDictionaryItem : audioInlinedAudioMetadata
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
		public CName Value
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioKeySoundEventPairDictionaryItem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
