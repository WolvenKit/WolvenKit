using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioGenericNameEventDictionary : audioInlinedAudioMetadata
	{
		private CArray<audioGenericNameEventItem> _entries;
		private CHandle<audioGenericNameEventItem> _entryType;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<audioGenericNameEventItem> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		[Ordinal(2)] 
		[RED("entryType")] 
		public CHandle<audioGenericNameEventItem> EntryType
		{
			get => GetProperty(ref _entryType);
			set => SetProperty(ref _entryType, value);
		}
	}
}
