using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalResource : gameJournalBaseResource
	{
		private CHandle<gameJournalEntry> _entry;

		[Ordinal(1)] 
		[RED("entry")] 
		public CHandle<gameJournalEntry> Entry
		{
			get => GetProperty(ref _entry);
			set => SetProperty(ref _entry, value);
		}
	}
}
