using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GemplayObjectiveData : IScriptable
	{
		[Ordinal(0)]  [RED("objectiveDescription")] public CString ObjectiveDescription { get; set; }
		[Ordinal(1)]  [RED("objectiveEntryID")] public CString ObjectiveEntryID { get; set; }
		[Ordinal(2)]  [RED("objectiveState")] public CEnum<gameJournalEntryState> ObjectiveState { get; set; }
		[Ordinal(3)]  [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(4)]  [RED("questTitle")] public CString QuestTitle { get; set; }
		[Ordinal(5)]  [RED("questUniqueId")] public CString QuestUniqueId { get; set; }
		[Ordinal(6)]  [RED("uniqueId")] public CString UniqueId { get; set; }
		[Ordinal(7)]  [RED("uniqueIdPrefix")] public CString UniqueIdPrefix { get; set; }

		public GemplayObjectiveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
