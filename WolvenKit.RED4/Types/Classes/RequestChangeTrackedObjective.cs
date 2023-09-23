using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RequestChangeTrackedObjective : redEvent
	{
		[Ordinal(0)] 
		[RED("objective")] 
		public CWeakHandle<gameJournalQuestObjective> Objective
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuestObjective>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuestObjective>>(value);
		}

		[Ordinal(1)] 
		[RED("quest")] 
		public CWeakHandle<gameJournalQuest> Quest
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuest>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuest>>(value);
		}

		[Ordinal(2)] 
		[RED("forceSelectEntry")] 
		public CInt32 ForceSelectEntry
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public RequestChangeTrackedObjective()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
