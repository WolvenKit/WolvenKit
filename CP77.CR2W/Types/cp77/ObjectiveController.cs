using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ObjectiveController : inkButtonController
	{
		[Ordinal(10)] [RED("ObjectiveLabel")] public inkTextWidgetReference ObjectiveLabel { get; set; }
		[Ordinal(11)] [RED("ObjectiveStatus")] public inkTextWidgetReference ObjectiveStatus { get; set; }
		[Ordinal(12)] [RED("QuestIcon")] public inkImageWidgetReference QuestIcon { get; set; }
		[Ordinal(13)] [RED("TrackedIcon")] public inkImageWidgetReference TrackedIcon { get; set; }
		[Ordinal(14)] [RED("FrameBackground_On")] public inkImageWidgetReference FrameBackground_On { get; set; }
		[Ordinal(15)] [RED("FrameBackground_Off")] public inkImageWidgetReference FrameBackground_Off { get; set; }
		[Ordinal(16)] [RED("FrameFluff_On")] public inkImageWidgetReference FrameFluff_On { get; set; }
		[Ordinal(17)] [RED("FrameFluff_Off")] public inkImageWidgetReference FrameFluff_Off { get; set; }
		[Ordinal(18)] [RED("Folder_On")] public inkImageWidgetReference Folder_On { get; set; }
		[Ordinal(19)] [RED("Folder_Off")] public inkImageWidgetReference Folder_Off { get; set; }
		[Ordinal(20)] [RED("QuestObjectiveData")] public CHandle<ABaseQuestObjectiveWrapper> QuestObjectiveData { get; set; }
		[Ordinal(21)] [RED("ToTrack")] public wCHandle<ABaseQuestObjectiveWrapper> ToTrack { get; set; }

		public ObjectiveController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
