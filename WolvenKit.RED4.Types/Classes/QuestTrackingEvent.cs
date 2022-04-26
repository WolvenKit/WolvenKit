using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestTrackingEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("journalEntry")] 
		public CWeakHandle<gameJournalQuestObjectiveBase> JournalEntry
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuestObjectiveBase>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuestObjectiveBase>>(value);
		}

		[Ordinal(1)] 
		[RED("objective")] 
		public CWeakHandle<QuestItemController> Objective
		{
			get => GetPropertyValue<CWeakHandle<QuestItemController>>();
			set => SetPropertyValue<CWeakHandle<QuestItemController>>(value);
		}

		public QuestTrackingEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
