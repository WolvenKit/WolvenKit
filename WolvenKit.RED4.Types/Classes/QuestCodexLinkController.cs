using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestCodexLinkController : BaseCodexLinkController
	{
		[Ordinal(5)] 
		[RED("linkLabelContainer")] 
		public inkWidgetReference LinkLabelContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("journalEntry")] 
		public CHandle<gameJournalEntry> JournalEntry
		{
			get => GetPropertyValue<CHandle<gameJournalEntry>>();
			set => SetPropertyValue<CHandle<gameJournalEntry>>(value);
		}

		public QuestCodexLinkController()
		{
			LinkLabelContainer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
