using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ABaseQuestObjectiveWrapper : AJournalEntryWrapper
	{
		[Ordinal(1)] 
		[RED("questObjective")] 
		public CWeakHandle<gameJournalQuestObjectiveBase> QuestObjective
		{
			get => GetPropertyValue<CWeakHandle<gameJournalQuestObjectiveBase>>();
			set => SetPropertyValue<CWeakHandle<gameJournalQuestObjectiveBase>>(value);
		}

		[Ordinal(2)] 
		[RED("objectiveStatus")] 
		public CEnum<gameJournalEntryState> ObjectiveStatus
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		[Ordinal(3)] 
		[RED("isTracked")] 
		public CBool IsTracked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("currentCounter")] 
		public CInt32 CurrentCounter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("totalCounter")] 
		public CInt32 TotalCounter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ABaseQuestObjectiveWrapper()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
