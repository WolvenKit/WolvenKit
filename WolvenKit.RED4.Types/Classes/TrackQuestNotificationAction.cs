using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TrackQuestNotificationAction : GenericNotificationBaseAction
	{
		private CWeakHandle<gameJournalQuest> _questEntry;
		private CWeakHandle<gameJournalManager> _journalMgr;

		[Ordinal(0)] 
		[RED("questEntry")] 
		public CWeakHandle<gameJournalQuest> QuestEntry
		{
			get => GetProperty(ref _questEntry);
			set => SetProperty(ref _questEntry, value);
		}

		[Ordinal(1)] 
		[RED("journalMgr")] 
		public CWeakHandle<gameJournalManager> JournalMgr
		{
			get => GetProperty(ref _journalMgr);
			set => SetProperty(ref _journalMgr, value);
		}
	}
}
