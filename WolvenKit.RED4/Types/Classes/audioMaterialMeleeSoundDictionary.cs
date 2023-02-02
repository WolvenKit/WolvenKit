using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioMaterialMeleeSoundDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioMaterialMeleeSoundDictionaryItem> Entries
		{
			get => GetPropertyValue<CArray<audioMaterialMeleeSoundDictionaryItem>>();
			set => SetPropertyValue<CArray<audioMaterialMeleeSoundDictionaryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioMaterialMeleeSoundDictionaryItem> EntryType
		{
			get => GetPropertyValue<CHandle<audioMaterialMeleeSoundDictionaryItem>>();
			set => SetPropertyValue<CHandle<audioMaterialMeleeSoundDictionaryItem>>(value);
		}

		public audioMaterialMeleeSoundDictionary()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
