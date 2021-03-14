using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GemplayObjectiveData : IScriptable
	{
		[Ordinal(0)] [RED("questUniqueId")] public CString QuestUniqueId { get; set; }
		[Ordinal(1)] [RED("questTitle")] public CString QuestTitle { get; set; }
		[Ordinal(2)] [RED("objectiveDescription")] public CString ObjectiveDescription { get; set; }
		[Ordinal(3)] [RED("uniqueId")] public CString UniqueId { get; set; }
		[Ordinal(4)] [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(5)] [RED("objectiveEntryID")] public CString ObjectiveEntryID { get; set; }
		[Ordinal(6)] [RED("uniqueIdPrefix")] public CString UniqueIdPrefix { get; set; }
		[Ordinal(7)] [RED("objectiveState")] public CEnum<gameJournalEntryState> ObjectiveState { get; set; }

		public GemplayObjectiveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
