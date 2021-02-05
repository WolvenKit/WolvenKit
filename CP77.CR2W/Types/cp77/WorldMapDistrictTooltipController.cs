using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WorldMapDistrictTooltipController : WorldMapTooltipBaseController
	{
		[Ordinal(0)]  [RED("root")] public inkWidgetReference Root { get; set; }
		[Ordinal(1)]  [RED("showHideAnim")] public CHandle<inkanimProxy> ShowHideAnim { get; set; }
		[Ordinal(2)]  [RED("visible")] public CBool Visible { get; set; }
		[Ordinal(3)]  [RED("active")] public CBool Active { get; set; }
		[Ordinal(4)]  [RED("titleText")] public inkTextWidgetReference TitleText { get; set; }
		[Ordinal(5)]  [RED("levelRangeText")] public inkTextWidgetReference LevelRangeText { get; set; }
		[Ordinal(6)]  [RED("threatText")] public inkTextWidgetReference ThreatText { get; set; }
		[Ordinal(7)]  [RED("completionText")] public inkTextWidgetReference CompletionText { get; set; }
		[Ordinal(8)]  [RED("gangsContainer")] public inkWidgetReference GangsContainer { get; set; }
		[Ordinal(9)]  [RED("gangsList")] public inkCompoundWidgetReference GangsList { get; set; }
		[Ordinal(10)]  [RED("gangControllers")] public CArray<wCHandle<WorldMapGangItemController>> GangControllers { get; set; }

		public WorldMapDistrictTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
