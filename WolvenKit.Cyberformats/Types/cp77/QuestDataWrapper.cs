using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestDataWrapper : AJournalEntryWrapper
	{
		[Ordinal(1)] [RED("isNew")] public CBool IsNew { get; set; }
		[Ordinal(2)] [RED("quest")] public wCHandle<gameJournalQuest> Quest { get; set; }
		[Ordinal(3)] [RED("title")] public CString Title { get; set; }
		[Ordinal(4)] [RED("description")] public CString Description { get; set; }
		[Ordinal(5)] [RED("questObjectives")] public CArray<CHandle<QuestObjectiveWrapper>> QuestObjectives { get; set; }
		[Ordinal(6)] [RED("links")] public CArray<wCHandle<gameJournalEntry>> Links { get; set; }
		[Ordinal(7)] [RED("questStatus")] public CEnum<gameJournalEntryState> QuestStatus { get; set; }
		[Ordinal(8)] [RED("isTracked")] public CBool IsTracked { get; set; }
		[Ordinal(9)] [RED("isChildTracked")] public CBool IsChildTracked { get; set; }
		[Ordinal(10)] [RED("recommendedLevel")] public CInt32 RecommendedLevel { get; set; }
		[Ordinal(11)] [RED("district")] public CHandle<gamedataDistrict_Record> District { get; set; }

		public QuestDataWrapper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
