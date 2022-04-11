using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class UpdateTrackedObjectiveEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("trackedObjective")] 
		public CWeakHandle<gameJournalQuestObjective> TrackedObjective
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuestObjective>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuestObjective>>(value);
		}

		[Ordinal(1)] 
		[RED("trackedQuest")] 
		public CWeakHandle<gameJournalQuest> TrackedQuest
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}
	}
}
