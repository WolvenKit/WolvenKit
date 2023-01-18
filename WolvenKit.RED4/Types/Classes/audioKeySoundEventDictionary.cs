using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioKeySoundEventDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioKeySoundEventPairDictionaryItem> Entries
		{
			get => GetPropertyValue<CArray<audioKeySoundEventPairDictionaryItem>>();
			set => SetPropertyValue<CArray<audioKeySoundEventPairDictionaryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioKeySoundEventPairDictionaryItem> EntryType
		{
			get => GetPropertyValue<CHandle<audioKeySoundEventPairDictionaryItem>>();
			set => SetPropertyValue<CHandle<audioKeySoundEventPairDictionaryItem>>(value);
		}

		public audioKeySoundEventDictionary()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
