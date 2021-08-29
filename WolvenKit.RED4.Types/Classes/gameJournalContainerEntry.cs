using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalContainerEntry : gameJournalEntry
	{
		private CArray<CHandle<gameJournalEntry>> _entries;

		[Ordinal(1)] 
		[RED("entries")] 
		public CArray<CHandle<gameJournalEntry>> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
