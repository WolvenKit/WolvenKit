using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuestListItemController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("animProxy")] public CHandle<inkanimProxy> AnimProxy { get; set; }
		[Ordinal(1)]  [RED("closestObjective")] public CHandle<QuestListDistanceData> ClosestObjective { get; set; }
		[Ordinal(2)]  [RED("data")] public CHandle<QuestListItemData> Data { get; set; }
		[Ordinal(3)]  [RED("distance")] public inkTextWidgetReference Distance { get; set; }
		[Ordinal(4)]  [RED("districtIcon")] public inkImageWidgetReference DistrictIcon { get; set; }
		[Ordinal(5)]  [RED("hovered")] public CBool Hovered { get; set; }
		[Ordinal(6)]  [RED("level")] public inkTextWidgetReference Level { get; set; }
		[Ordinal(7)]  [RED("newIcon")] public inkWidgetReference NewIcon { get; set; }
		[Ordinal(8)]  [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(9)]  [RED("stateIcon")] public inkImageWidgetReference StateIcon { get; set; }
		[Ordinal(10)]  [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(11)]  [RED("trackedMarker")] public inkWidgetReference TrackedMarker { get; set; }

		public QuestListItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
