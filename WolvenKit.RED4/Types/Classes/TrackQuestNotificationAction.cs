using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TrackQuestNotificationAction : GenericNotificationBaseAction
	{
		[Ordinal(0)] 
		[RED("questEntry")] 
		public CWeakHandle<gameJournalQuest> QuestEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(1)] 
		[RED("journalMgr")] 
		public CWeakHandle<gameJournalManager> JournalMgr
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		public TrackQuestNotificationAction()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
