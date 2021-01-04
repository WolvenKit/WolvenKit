using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestDetailsObjectiveController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("hovered")] public CBool Hovered { get; set; }
		[Ordinal(1)]  [RED("objective")] public wCHandle<gameJournalQuestObjective> Objective { get; set; }
		[Ordinal(2)]  [RED("objectiveName")] public inkTextWidgetReference ObjectiveName { get; set; }
		[Ordinal(3)]  [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(4)]  [RED("trackingMarker")] public inkWidgetReference TrackingMarker { get; set; }

		public QuestDetailsObjectiveController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
