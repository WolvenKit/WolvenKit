using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioFoliageMaterialDictionary : audioInlinedAudioMetadata
	{
		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioAudioFoliageMaterialDictionaryItem> Entries
		{
			get => GetPropertyValue<CArray<audioAudioFoliageMaterialDictionaryItem>>();
			set => SetPropertyValue<CArray<audioAudioFoliageMaterialDictionaryItem>>(value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioAudioFoliageMaterialDictionaryItem> EntryType
		{
			get => GetPropertyValue<CHandle<audioAudioFoliageMaterialDictionaryItem>>();
			set => SetPropertyValue<CHandle<audioAudioFoliageMaterialDictionaryItem>>(value);
		}

		public audioAudioFoliageMaterialDictionary()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
