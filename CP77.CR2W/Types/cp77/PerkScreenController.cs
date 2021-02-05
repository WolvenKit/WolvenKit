using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerkScreenController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("hubSelector")] public inkWidgetReference HubSelector { get; set; }
		[Ordinal(1)]  [RED("connectionLinesContainer")] public inkCompoundWidgetReference ConnectionLinesContainer { get; set; }
		[Ordinal(2)]  [RED("boughtConnectionLinesContainer")] public inkCompoundWidgetReference BoughtConnectionLinesContainer { get; set; }
		[Ordinal(3)]  [RED("maxedConnectionLinesContainer")] public inkCompoundWidgetReference MaxedConnectionLinesContainer { get; set; }
		[Ordinal(4)]  [RED("boughtMaskContainer")] public inkCanvasWidgetReference BoughtMaskContainer { get; set; }
		[Ordinal(5)]  [RED("maxedMaskContainer")] public inkCanvasWidgetReference MaxedMaskContainer { get; set; }
		[Ordinal(6)]  [RED("attributeNameText")] public inkTextWidgetReference AttributeNameText { get; set; }
		[Ordinal(7)]  [RED("attributeLevelText")] public inkTextWidgetReference AttributeLevelText { get; set; }
		[Ordinal(8)]  [RED("levelControllerRef")] public inkWidgetReference LevelControllerRef { get; set; }
		[Ordinal(9)]  [RED("rewardsControllerRef")] public inkWidgetReference RewardsControllerRef { get; set; }
		[Ordinal(10)]  [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(11)]  [RED("proficiencyRootRef")] public inkWidgetReference ProficiencyRootRef { get; set; }
		[Ordinal(12)]  [RED("dataManager")] public CHandle<PlayerDevelopmentDataManager> DataManager { get; set; }
		[Ordinal(13)]  [RED("displayData")] public CHandle<AttributeDisplayData> DisplayData { get; set; }
		[Ordinal(14)]  [RED("proficiencyRoot")] public CHandle<TabRadioGroup> ProficiencyRoot { get; set; }
		[Ordinal(15)]  [RED("widgetMap")] public CArray<wCHandle<PerkDisplayContainerController>> WidgetMap { get; set; }
		[Ordinal(16)]  [RED("traitController")] public CHandle<PerkDisplayContainerController> TraitController { get; set; }
		[Ordinal(17)]  [RED("currentIndex")] public CInt32 CurrentIndex { get; set; }
		[Ordinal(18)]  [RED("connectionLines", 45)] public CArrayFixedSize<CInt32> ConnectionLines { get; set; }
		[Ordinal(19)]  [RED("levelController")] public CHandle<StatsProgressController> LevelController { get; set; }
		[Ordinal(20)]  [RED("rewardsController")] public CHandle<StatsStreetCredReward> RewardsController { get; set; }
		[Ordinal(21)]  [RED("tooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }

		public PerkScreenController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
