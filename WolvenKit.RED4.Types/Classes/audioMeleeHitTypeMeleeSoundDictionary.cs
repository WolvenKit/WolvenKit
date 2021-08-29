using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMeleeHitTypeMeleeSoundDictionary : audioInlinedAudioMetadata
	{
		private CArray<audioMeleeHitTypeMeleeSoundDictionaryItem> _entries;
		private CHandle<audioMeleeHitTypeMeleeSoundDictionaryItem> _entryType;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioMeleeHitTypeMeleeSoundDictionaryItem> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioMeleeHitTypeMeleeSoundDictionaryItem> EntryType
		{
			get => GetProperty(ref _entryType);
			set => SetProperty(ref _entryType, value);
		}
	}
}
