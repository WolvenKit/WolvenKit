using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestCodexLinkController : BaseCodexLinkController
	{
		private inkWidgetReference _linkLabelContainer;
		private CHandle<gameJournalEntry> _journalEntry;

		[Ordinal(5)] 
		[RED("linkLabelContainer")] 
		public inkWidgetReference LinkLabelContainer
		{
			get => GetProperty(ref _linkLabelContainer);
			set => SetProperty(ref _linkLabelContainer, value);
		}

		[Ordinal(6)] 
		[RED("journalEntry")] 
		public CHandle<gameJournalEntry> JournalEntry
		{
			get => GetProperty(ref _journalEntry);
			set => SetProperty(ref _journalEntry, value);
		}
	}
}
