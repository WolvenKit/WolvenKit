using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetGameplayObjectiveStateRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("objectiveData")] 
		public CHandle<GemplayObjectiveData> ObjectiveData
		{
			get => GetPropertyValue<CHandle<GemplayObjectiveData>>();
			set => SetPropertyValue<CHandle<GemplayObjectiveData>>(value);
		}

		[Ordinal(1)] 
		[RED("objectiveState")] 
		public CEnum<gameJournalEntryState> ObjectiveState
		{
			get => GetPropertyValue<CEnum<gameJournalEntryState>>();
			set => SetPropertyValue<CEnum<gameJournalEntryState>>(value);
		}

		public SetGameplayObjectiveStateRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
