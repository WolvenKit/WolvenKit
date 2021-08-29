using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudioFoliageMaterialDictionary : audioInlinedAudioMetadata
	{
		private CArray<audioAudioFoliageMaterialDictionaryItem> _entries;
		private CHandle<audioAudioFoliageMaterialDictionaryItem> _entryType;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioAudioFoliageMaterialDictionaryItem> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioAudioFoliageMaterialDictionaryItem> EntryType
		{
			get => GetProperty(ref _entryType);
			set => SetProperty(ref _entryType, value);
		}
	}
}
