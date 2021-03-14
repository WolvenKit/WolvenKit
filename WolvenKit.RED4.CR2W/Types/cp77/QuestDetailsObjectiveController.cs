using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestDetailsObjectiveController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("objectiveName")] public inkTextWidgetReference ObjectiveName { get; set; }
		[Ordinal(2)] [RED("trackingMarker")] public inkWidgetReference TrackingMarker { get; set; }
		[Ordinal(3)] [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(4)] [RED("objective")] public wCHandle<gameJournalQuestObjective> Objective { get; set; }
		[Ordinal(5)] [RED("hovered")] public CBool Hovered { get; set; }

		public QuestDetailsObjectiveController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
