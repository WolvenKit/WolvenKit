using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetGameplayObjectiveStateRequest : gameScriptableSystemRequest
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

		public SetGameplayObjectiveStateRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
