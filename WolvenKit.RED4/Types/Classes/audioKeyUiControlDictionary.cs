using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioKeyUiControlDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioKeyUiControlPairDictionaryItem> Entries
		{
			get => GetPropertyValue<CArray<audioKeyUiControlPairDictionaryItem>>();
			set => SetPropertyValue<CArray<audioKeyUiControlPairDictionaryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioKeyUiControlPairDictionaryItem> EntryType
		{
			get => GetPropertyValue<CHandle<audioKeyUiControlPairDictionaryItem>>();
			set => SetPropertyValue<CHandle<audioKeyUiControlPairDictionaryItem>>(value);
		}

		public audioKeyUiControlDictionary()
		{
			Entries = new();
			EntryType = new audioKeyUiControlPairDictionaryItem { Value = new audioUiControl { UiEventsByAction = new audioKeyUiSoundDictionary { EntryType = new audioKeyUiSoundPairDictionaryItem() } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
