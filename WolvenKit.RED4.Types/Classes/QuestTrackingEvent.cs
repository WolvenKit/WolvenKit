using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestTrackingEvent : redEvent
	{
		private CWeakHandle<gameJournalQuestObjectiveBase> _journalEntry;
		private CWeakHandle<QuestItemController> _objective;

		[Ordinal(0)] 
		[RED("journalEntry")] 
		public CWeakHandle<gameJournalQuestObjectiveBase> JournalEntry
		{
			get => GetProperty(ref _journalEntry);
			set => SetProperty(ref _journalEntry, value);
		}

		[Ordinal(1)] 
		[RED("objective")] 
		public CWeakHandle<QuestItemController> Objective
		{
			get => GetProperty(ref _objective);
			set => SetProperty(ref _objective, value);
		}
	}
}
