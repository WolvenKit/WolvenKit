using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CyberwareMainGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("CyberwareColumnLeft")] public inkCompoundWidgetReference CyberwareColumnLeft { get; set; }
		[Ordinal(1)]  [RED("CyberwareColumnRight")] public inkCompoundWidgetReference CyberwareColumnRight { get; set; }
		[Ordinal(2)]  [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(3)]  [RED("MainViewRoot")] public inkWidgetReference MainViewRoot { get; set; }
		[Ordinal(4)]  [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(5)]  [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(6)]  [RED("attributesList")] public inkCompoundWidgetReference AttributesList { get; set; }
		[Ordinal(7)]  [RED("personalStatsList")] public inkCompoundWidgetReference PersonalStatsList { get; set; }
		[Ordinal(8)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(9)]  [RED("rawStatsData")] public CArray<gameStatViewData> RawStatsData { get; set; }
		[Ordinal(10)]  [RED("resistanceView")] public CName ResistanceView { get; set; }
		[Ordinal(11)]  [RED("resistancesList")] public inkCompoundWidgetReference ResistancesList { get; set; }
		[Ordinal(12)]  [RED("statView")] public CName StatView { get; set; }
		[Ordinal(13)]  [RED("toolTipOffset")] public inkMargin ToolTipOffset { get; set; }

		public CyberwareMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
