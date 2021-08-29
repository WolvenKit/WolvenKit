using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnOpenCodexAtEntryEvent : redEvent
	{
		private CWeakHandle<gameJournalCodexEntry> _entry;

		[Ordinal(0)] 
		[RED("entry")] 
		public CWeakHandle<gameJournalCodexEntry> Entry
		{
			get => GetProperty(ref _entry);
			set => SetProperty(ref _entry, value);
		}
	}
}
