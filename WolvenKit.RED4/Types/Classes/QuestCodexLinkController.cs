using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestCodexLinkController : BaseCodexLinkController
	{
		[Ordinal(6)] 
		[RED("linkLabelContainer")] 
		public inkWidgetReference LinkLabelContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("journalEntry")] 
		public CWeakHandle<gameJournalEntry> JournalEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalEntry>>();
			set => SetPropertyValue<CWeakHandle<gameJournalEntry>>(value);
		}

		public QuestCodexLinkController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
