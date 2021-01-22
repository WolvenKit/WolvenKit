using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestItemController : inkButtonController
	{
		[Ordinal(0)]  [RED("DefaultStateName")] public CName DefaultStateName { get; set; }
		[Ordinal(1)]  [RED("Folder_Off")] public inkImageWidgetReference Folder_Off { get; set; }
		[Ordinal(2)]  [RED("Folder_On")] public inkImageWidgetReference Folder_On { get; set; }
		[Ordinal(3)]  [RED("FrameBackground_Off")] public inkImageWidgetReference FrameBackground_Off { get; set; }
		[Ordinal(4)]  [RED("FrameBackground_On")] public inkImageWidgetReference FrameBackground_On { get; set; }
		[Ordinal(5)]  [RED("FrameFluff_Off")] public inkImageWidgetReference FrameFluff_Off { get; set; }
		[Ordinal(6)]  [RED("FrameFluff_On")] public inkImageWidgetReference FrameFluff_On { get; set; }
		[Ordinal(7)]  [RED("MarkedStateName")] public CName MarkedStateName { get; set; }
		[Ordinal(8)]  [RED("NewIcon")] public inkImageWidgetReference NewIcon { get; set; }
		[Ordinal(9)]  [RED("QuestData")] public CHandle<QuestDataWrapper> QuestData { get; set; }
		[Ordinal(10)]  [RED("QuestIcon")] public inkImageWidgetReference QuestIcon { get; set; }
		[Ordinal(11)]  [RED("QuestObjectiveData")] public CHandle<ABaseQuestObjectiveWrapper> QuestObjectiveData { get; set; }
		[Ordinal(12)]  [RED("QuestStatus")] public inkTextWidgetReference QuestStatus { get; set; }
		[Ordinal(13)]  [RED("QuestTitle")] public inkTextWidgetReference QuestTitle { get; set; }
		[Ordinal(14)]  [RED("StyleRoot")] public inkWidgetReference StyleRoot { get; set; }
		[Ordinal(15)]  [RED("ToTrack")] public wCHandle<ABaseQuestObjectiveWrapper> ToTrack { get; set; }
		[Ordinal(16)]  [RED("TrackedIcon")] public inkImageWidgetReference TrackedIcon { get; set; }

		public QuestItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
