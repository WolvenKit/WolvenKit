using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuestListController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("CategoryName")] public inkTextWidgetReference CategoryName { get; set; }
		[Ordinal(1)]  [RED("LastQuestData")] public wCHandle<QuestDataWrapper> LastQuestData { get; set; }
		[Ordinal(2)]  [RED("QuestItems")] public CArray<wCHandle<QuestItemController>> QuestItems { get; set; }
		[Ordinal(3)]  [RED("QuestListRef")] public inkCompoundWidgetReference QuestListRef { get; set; }
		[Ordinal(4)]  [RED("QuestType")] public CEnum<gameJournalQuestType> QuestType { get; set; }
		[Ordinal(5)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }

		public QuestListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
