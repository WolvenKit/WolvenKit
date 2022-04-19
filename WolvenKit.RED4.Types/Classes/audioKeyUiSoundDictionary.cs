using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioKeyUiSoundDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioKeyUiSoundPairDictionaryItem> Entries
		{
			get => GetPropertyValue<CArray<audioKeyUiSoundPairDictionaryItem>>();
			set => SetPropertyValue<CArray<audioKeyUiSoundPairDictionaryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioKeyUiSoundPairDictionaryItem> EntryType
		{
			get => GetPropertyValue<CHandle<audioKeyUiSoundPairDictionaryItem>>();
			set => SetPropertyValue<CHandle<audioKeyUiSoundPairDictionaryItem>>(value);
		}

		public audioKeyUiSoundDictionary()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
