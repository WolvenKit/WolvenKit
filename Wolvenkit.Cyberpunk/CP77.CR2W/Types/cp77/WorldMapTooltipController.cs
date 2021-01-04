using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorldMapTooltipController : WorldMapTooltipBaseController
	{
		[Ordinal(0)]  [RED("collectionCountContainer")] public inkCompoundWidgetReference CollectionCountContainer { get; set; }
		[Ordinal(1)]  [RED("collectionCountText")] public inkTextWidgetReference CollectionCountText { get; set; }
		[Ordinal(2)]  [RED("descText")] public inkTextWidgetReference DescText { get; set; }
		[Ordinal(3)]  [RED("inputInteractContainer")] public inkCompoundWidgetReference InputInteractContainer { get; set; }
		[Ordinal(4)]  [RED("inputInteractText")] public inkTextWidgetReference InputInteractText { get; set; }
		[Ordinal(5)]  [RED("inputOpenJournalContainer")] public inkCompoundWidgetReference InputOpenJournalContainer { get; set; }
		[Ordinal(6)]  [RED("inputOpenJournalText")] public inkTextWidgetReference InputOpenJournalText { get; set; }
		[Ordinal(7)]  [RED("inputSetWaypointContainer")] public inkCompoundWidgetReference InputSetWaypointContainer { get; set; }
		[Ordinal(8)]  [RED("inputSetWaypointText")] public inkTextWidgetReference InputSetWaypointText { get; set; }
		[Ordinal(9)]  [RED("inputTrackQuestContainer")] public inkCompoundWidgetReference InputTrackQuestContainer { get; set; }
		[Ordinal(10)]  [RED("inputTrackQuestText")] public inkTextWidgetReference InputTrackQuestText { get; set; }
		[Ordinal(11)]  [RED("inputZoomToContainer")] public inkCompoundWidgetReference InputZoomToContainer { get; set; }
		[Ordinal(12)]  [RED("inputZoomToText")] public inkTextWidgetReference InputZoomToText { get; set; }
		[Ordinal(13)]  [RED("requiredLevelCanvas")] public inkWidgetReference RequiredLevelCanvas { get; set; }
		[Ordinal(14)]  [RED("requiredLevelText")] public inkTextWidgetReference RequiredLevelText { get; set; }
		[Ordinal(15)]  [RED("requiredLevelValue")] public inkTextWidgetReference RequiredLevelValue { get; set; }
		[Ordinal(16)]  [RED("threatLevelCaption")] public inkTextWidgetReference ThreatLevelCaption { get; set; }
		[Ordinal(17)]  [RED("threatLevelValue")] public inkTextWidgetReference ThreatLevelValue { get; set; }
		[Ordinal(18)]  [RED("titleText")] public inkTextWidgetReference TitleText { get; set; }
		[Ordinal(19)]  [RED("trackedQuestContainer")] public inkWidgetReference TrackedQuestContainer { get; set; }

		public WorldMapTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
