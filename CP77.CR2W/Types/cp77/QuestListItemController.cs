using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestListItemController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(1)]  [RED("level")] public inkTextWidgetReference Level { get; set; }
		[Ordinal(2)]  [RED("trackedMarker")] public inkWidgetReference TrackedMarker { get; set; }
		[Ordinal(3)]  [RED("districtIcon")] public inkImageWidgetReference DistrictIcon { get; set; }
		[Ordinal(4)]  [RED("stateIcon")] public inkImageWidgetReference StateIcon { get; set; }
		[Ordinal(5)]  [RED("distance")] public inkTextWidgetReference Distance { get; set; }
		[Ordinal(6)]  [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(7)]  [RED("newIcon")] public inkWidgetReference NewIcon { get; set; }
		[Ordinal(8)]  [RED("data")] public CHandle<QuestListItemData> Data { get; set; }
		[Ordinal(9)]  [RED("closestObjective")] public CHandle<QuestListDistanceData> ClosestObjective { get; set; }
		[Ordinal(10)]  [RED("hovered")] public CBool Hovered { get; set; }
		[Ordinal(11)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }

		public QuestListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
