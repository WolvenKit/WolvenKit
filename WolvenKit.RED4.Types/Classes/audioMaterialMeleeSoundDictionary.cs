using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMaterialMeleeSoundDictionary : audioInlinedAudioMetadata
	{
		private CArray<audioMaterialMeleeSoundDictionaryItem> _entries;
		private CHandle<audioMaterialMeleeSoundDictionaryItem> _entryType;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioMaterialMeleeSoundDictionaryItem> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioMaterialMeleeSoundDictionaryItem> EntryType
		{
			get => GetProperty(ref _entryType);
			set => SetProperty(ref _entryType, value);
		}
	}
}
