using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestItemController : inkButtonController
	{
		[Ordinal(10)] [RED("QuestTitle")] public inkTextWidgetReference QuestTitle { get; set; }
		[Ordinal(11)] [RED("QuestStatus")] public inkTextWidgetReference QuestStatus { get; set; }
		[Ordinal(12)] [RED("QuestIcon")] public inkImageWidgetReference QuestIcon { get; set; }
		[Ordinal(13)] [RED("TrackedIcon")] public inkImageWidgetReference TrackedIcon { get; set; }
		[Ordinal(14)] [RED("NewIcon")] public inkImageWidgetReference NewIcon { get; set; }
		[Ordinal(15)] [RED("FrameBackground_On")] public inkImageWidgetReference FrameBackground_On { get; set; }
		[Ordinal(16)] [RED("FrameBackground_Off")] public inkImageWidgetReference FrameBackground_Off { get; set; }
		[Ordinal(17)] [RED("FrameFluff_On")] public inkImageWidgetReference FrameFluff_On { get; set; }
		[Ordinal(18)] [RED("FrameFluff_Off")] public inkImageWidgetReference FrameFluff_Off { get; set; }
		[Ordinal(19)] [RED("Folder_On")] public inkImageWidgetReference Folder_On { get; set; }
		[Ordinal(20)] [RED("Folder_Off")] public inkImageWidgetReference Folder_Off { get; set; }
		[Ordinal(21)] [RED("StyleRoot")] public inkWidgetReference StyleRoot { get; set; }
		[Ordinal(22)] [RED("ToTrack")] public wCHandle<ABaseQuestObjectiveWrapper> ToTrack { get; set; }
		[Ordinal(23)] [RED("DefaultStateName")] public CName DefaultStateName { get; set; }
		[Ordinal(24)] [RED("MarkedStateName")] public CName MarkedStateName { get; set; }
		[Ordinal(25)] [RED("QuestObjectiveData")] public CHandle<ABaseQuestObjectiveWrapper> QuestObjectiveData { get; set; }
		[Ordinal(26)] [RED("QuestData")] public CHandle<QuestDataWrapper> QuestData { get; set; }

		public QuestItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
