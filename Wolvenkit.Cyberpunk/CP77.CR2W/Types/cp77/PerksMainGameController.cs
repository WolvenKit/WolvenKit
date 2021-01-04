using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerksMainGameController : gameuiMenuGameController
	{
		[Ordinal(0)]  [RED("activeScreen")] public CEnum<CharacterScreenType> ActiveScreen { get; set; }
		[Ordinal(1)]  [RED("attributeSelectorsContainer")] public inkWidgetReference AttributeSelectorsContainer { get; set; }
		[Ordinal(2)]  [RED("attributeTooltipHolderLeft")] public inkWidgetReference AttributeTooltipHolderLeft { get; set; }
		[Ordinal(3)]  [RED("attributeTooltipHolderRight")] public inkWidgetReference AttributeTooltipHolderRight { get; set; }
		[Ordinal(4)]  [RED("attributesControllersList")] public CArray<wCHandle<PerksMenuAttributeItemController>> AttributesControllersList { get; set; }
		[Ordinal(5)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }
		[Ordinal(6)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(7)]  [RED("centerHiglightParts")] public CArray<inkWidgetReference> CenterHiglightParts { get; set; }
		[Ordinal(8)]  [RED("characterLevelListener")] public CUInt32 CharacterLevelListener { get; set; }
		[Ordinal(9)]  [RED("dataManager")] public CHandle<PlayerDevelopmentDataManager> DataManager { get; set; }
		[Ordinal(10)]  [RED("johnnyConnectorRef")] public inkWidgetReference JohnnyConnectorRef { get; set; }
		[Ordinal(11)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(12)]  [RED("perksMenuItemCreatedQueue")] public CArray<CHandle<PerksMenuAttributeItemCreated>> PerksMenuItemCreatedQueue { get; set; }
		[Ordinal(13)]  [RED("perksScreen")] public inkWidgetReference PerksScreen { get; set; }
		[Ordinal(14)]  [RED("perksScreenController")] public wCHandle<PerkScreenController> PerksScreenController { get; set; }
		[Ordinal(15)]  [RED("playerLevel")] public inkTextWidgetReference PlayerLevel { get; set; }
		[Ordinal(16)]  [RED("playerStatsBlackboard")] public CHandle<gameIBlackboard> PlayerStatsBlackboard { get; set; }
		[Ordinal(17)]  [RED("pointsDisplay")] public inkWidgetReference PointsDisplay { get; set; }
		[Ordinal(18)]  [RED("pointsDisplayController")] public wCHandle<PerksPointsDisplayController> PointsDisplayController { get; set; }
		[Ordinal(19)]  [RED("questSystem")] public wCHandle<questQuestsSystem> QuestSystem { get; set; }
		[Ordinal(20)]  [RED("tooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(21)]  [RED("tooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }

		public PerksMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
