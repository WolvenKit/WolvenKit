using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetGameplayObjectiveStateRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("objectiveData")] public CHandle<GemplayObjectiveData> ObjectiveData { get; set; }
		[Ordinal(1)] [RED("objectiveState")] public CEnum<gameJournalEntryState> ObjectiveState { get; set; }

		public SetGameplayObjectiveStateRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
