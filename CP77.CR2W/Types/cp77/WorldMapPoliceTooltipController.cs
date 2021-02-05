using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorldMapPoliceTooltipController : WorldMapTooltipController
	{
		[Ordinal(0)]  [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(1)]  [RED("showHideAnim")] public CHandle<inkanimProxy> ShowHideAnim { get; set; }
		[Ordinal(2)]  [RED("visible")] public CBool Visible { get; set; }
		[Ordinal(3)]  [RED("active")] public CBool Active { get; set; }
		[Ordinal(4)]  [RED("titleText")] public inkTextWidgetReference TitleText { get; set; }
		[Ordinal(5)]  [RED("descText")] public inkTextWidgetReference DescText { get; set; }
		[Ordinal(6)]  [RED("trackedQuestContainer")] public inkWidgetReference TrackedQuestContainer { get; set; }
		[Ordinal(7)]  [RED("requiredLevelCanvas")] public inkWidgetReference RequiredLevelCanvas { get; set; }
		[Ordinal(8)]  [RED("requiredLevelText")] public inkTextWidgetReference RequiredLevelText { get; set; }
		[Ordinal(9)]  [RED("requiredLevelValue")] public inkTextWidgetReference RequiredLevelValue { get; set; }
		[Ordinal(10)]  [RED("inputSetWaypointContainer")] public inkCompoundWidgetReference InputSetWaypointContainer { get; set; }
		[Ordinal(11)]  [RED("inputSetWaypointText")] public inkTextWidgetReference InputSetWaypointText { get; set; }
		[Ordinal(12)]  [RED("inputTrackQuestContainer")] public inkCompoundWidgetReference InputTrackQuestContainer { get; set; }
		[Ordinal(13)]  [RED("inputTrackQuestText")] public inkTextWidgetReference InputTrackQuestText { get; set; }
		[Ordinal(14)]  [RED("inputInteractContainer")] public inkCompoundWidgetReference InputInteractContainer { get; set; }
		[Ordinal(15)]  [RED("inputInteractText")] public inkTextWidgetReference InputInteractText { get; set; }
		[Ordinal(16)]  [RED("inputOpenJournalContainer")] public inkCompoundWidgetReference InputOpenJournalContainer { get; set; }
		[Ordinal(17)]  [RED("inputOpenJournalText")] public inkTextWidgetReference InputOpenJournalText { get; set; }
		[Ordinal(18)]  [RED("inputZoomToContainer")] public inkCompoundWidgetReference InputZoomToContainer { get; set; }
		[Ordinal(19)]  [RED("inputZoomToText")] public inkTextWidgetReference InputZoomToText { get; set; }
		[Ordinal(20)]  [RED("threatLevelCaption")] public inkTextWidgetReference ThreatLevelCaption { get; set; }
		[Ordinal(21)]  [RED("threatLevelValue")] public inkTextWidgetReference ThreatLevelValue { get; set; }
		[Ordinal(22)]  [RED("collectionCountContainer")] public inkCompoundWidgetReference CollectionCountContainer { get; set; }
		[Ordinal(23)]  [RED("collectionCountText")] public inkTextWidgetReference CollectionCountText { get; set; }

		public WorldMapPoliceTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
