using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetGameplayObjectiveStateRequest : gameScriptableSystemRequest
	{
		private CHandle<GemplayObjectiveData> _objectiveData;
		private CEnum<gameJournalEntryState> _objectiveState;

		[Ordinal(0)] 
		[RED("objectiveData")] 
		public CHandle<GemplayObjectiveData> ObjectiveData
		{
			get => GetProperty(ref _objectiveData);
			set => SetProperty(ref _objectiveData, value);
		}

		[Ordinal(1)] 
		[RED("objectiveState")] 
		public CEnum<gameJournalEntryState> ObjectiveState
		{
			get => GetProperty(ref _objectiveState);
			set => SetProperty(ref _objectiveState, value);
		}
	}
}
