using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ObjectiveController : inkButtonController
	{
		[Ordinal(0)]  [RED("Folder_Off")] public inkImageWidgetReference Folder_Off { get; set; }
		[Ordinal(1)]  [RED("Folder_On")] public inkImageWidgetReference Folder_On { get; set; }
		[Ordinal(2)]  [RED("FrameBackground_Off")] public inkImageWidgetReference FrameBackground_Off { get; set; }
		[Ordinal(3)]  [RED("FrameBackground_On")] public inkImageWidgetReference FrameBackground_On { get; set; }
		[Ordinal(4)]  [RED("FrameFluff_Off")] public inkImageWidgetReference FrameFluff_Off { get; set; }
		[Ordinal(5)]  [RED("FrameFluff_On")] public inkImageWidgetReference FrameFluff_On { get; set; }
		[Ordinal(6)]  [RED("ObjectiveLabel")] public inkTextWidgetReference ObjectiveLabel { get; set; }
		[Ordinal(7)]  [RED("ObjectiveStatus")] public inkTextWidgetReference ObjectiveStatus { get; set; }
		[Ordinal(8)]  [RED("QuestIcon")] public inkImageWidgetReference QuestIcon { get; set; }
		[Ordinal(9)]  [RED("QuestObjectiveData")] public CHandle<ABaseQuestObjectiveWrapper> QuestObjectiveData { get; set; }
		[Ordinal(10)]  [RED("ToTrack")] public wCHandle<ABaseQuestObjectiveWrapper> ToTrack { get; set; }
		[Ordinal(11)]  [RED("TrackedIcon")] public inkImageWidgetReference TrackedIcon { get; set; }

		public ObjectiveController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
