using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestShardLinkController : BaseCodexLinkController
	{
		[Ordinal(6)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		[Ordinal(7)] 
		[RED("journalEntry")] 
		public CWeakHandle<gameJournalOnscreen> JournalEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalOnscreen>>();
			set => SetPropertyValue<CWeakHandle<gameJournalOnscreen>>(value);
		}

		public QuestShardLinkController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
