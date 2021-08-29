using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RequestChangeTrackedObjective : redEvent
	{
		private CWeakHandle<gameJournalQuestObjective> _objective;
		private CWeakHandle<gameJournalQuest> _quest;

		[Ordinal(0)] 
		[RED("objective")] 
		public CWeakHandle<gameJournalQuestObjective> Objective
		{
			get => GetProperty(ref _objective);
			set => SetProperty(ref _objective, value);
		}

		[Ordinal(1)] 
		[RED("quest")] 
		public CWeakHandle<gameJournalQuest> Quest
		{
			get => GetProperty(ref _quest);
			set => SetProperty(ref _quest, value);
		}
	}
}
