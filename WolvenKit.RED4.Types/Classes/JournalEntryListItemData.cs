using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class JournalEntryListItemData : IScriptable
	{
		private CWeakHandle<gameJournalEntry> _entry;
		private CHandle<IScriptable> _extraData;

		[Ordinal(0)] 
		[RED("entry")] 
		public CWeakHandle<gameJournalEntry> Entry
		{
			get => GetProperty(ref _entry);
			set => SetProperty(ref _entry, value);
		}

		[Ordinal(1)] 
		[RED("extraData")] 
		public CHandle<IScriptable> ExtraData
		{
			get => GetProperty(ref _extraData);
			set => SetProperty(ref _extraData, value);
		}
	}
}
