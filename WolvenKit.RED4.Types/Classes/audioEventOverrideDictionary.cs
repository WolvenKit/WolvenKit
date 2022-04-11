using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioEventOverrideDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioEventOverrideDictionaryItem> Entries
		{
			get => GetPropertyValue<CArray<audioEventOverrideDictionaryItem>>();
			set => SetPropertyValue<CArray<audioEventOverrideDictionaryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioEventOverrideDictionaryItem> EntryType
		{
			get => GetPropertyValue<CHandle<audioEventOverrideDictionaryItem>>();
			set => SetPropertyValue<CHandle<audioEventOverrideDictionaryItem>>(value);
		}

		public audioEventOverrideDictionary()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
