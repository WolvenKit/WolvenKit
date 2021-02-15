using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CyberwareMainGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("MainViewRoot")] public inkWidgetReference MainViewRoot { get; set; }
		[Ordinal(3)] [RED("CyberwareColumnLeft")] public inkCompoundWidgetReference CyberwareColumnLeft { get; set; }
		[Ordinal(4)] [RED("CyberwareColumnRight")] public inkCompoundWidgetReference CyberwareColumnRight { get; set; }
		[Ordinal(5)] [RED("personalStatsList")] public inkCompoundWidgetReference PersonalStatsList { get; set; }
		[Ordinal(6)] [RED("attributesList")] public inkCompoundWidgetReference AttributesList { get; set; }
		[Ordinal(7)] [RED("resistancesList")] public inkCompoundWidgetReference ResistancesList { get; set; }
		[Ordinal(8)] [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(9)] [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(10)] [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(11)] [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(12)] [RED("resistanceView")] public CName ResistanceView { get; set; }
		[Ordinal(13)] [RED("statView")] public CName StatView { get; set; }
		[Ordinal(14)] [RED("toolTipOffset")] public inkMargin ToolTipOffset { get; set; }
		[Ordinal(15)] [RED("rawStatsData")] public CArray<gameStatViewData> RawStatsData { get; set; }

		public CyberwareMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
