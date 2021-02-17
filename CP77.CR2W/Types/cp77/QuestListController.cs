using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestListController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("CategoryName")] public inkTextWidgetReference CategoryName { get; set; }
		[Ordinal(2)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(3)] [RED("QuestListRef")] public inkCompoundWidgetReference QuestListRef { get; set; }
		[Ordinal(4)] [RED("QuestType")] public CEnum<gameJournalQuestType> QuestType { get; set; }
		[Ordinal(5)] [RED("QuestItems")] public CArray<wCHandle<QuestItemController>> QuestItems { get; set; }
		[Ordinal(6)] [RED("LastQuestData")] public wCHandle<QuestDataWrapper> LastQuestData { get; set; }

		public QuestListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
