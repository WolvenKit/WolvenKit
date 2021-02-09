using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StatsMainGameController : gameuiMenuGameController
	{
		[Ordinal(1)]  [RED("MainViewRoot")] public inkWidgetReference MainViewRoot { get; set; }
		[Ordinal(2)]  [RED("statsList")] public inkCompoundWidgetReference StatsList { get; set; }
		[Ordinal(3)]  [RED("TooltipsManagerRef")] public inkWidgetReference TooltipsManagerRef { get; set; }
		[Ordinal(4)]  [RED("levelControllerRef")] public inkWidgetReference LevelControllerRef { get; set; }
		[Ordinal(5)]  [RED("streetCredControllerRef")] public inkWidgetReference StreetCredControllerRef { get; set; }
		[Ordinal(6)]  [RED("detailListControllerRef")] public inkWidgetReference DetailListControllerRef { get; set; }
		[Ordinal(7)]  [RED("statsStreetCredRewardRef")] public inkWidgetReference StatsStreetCredRewardRef { get; set; }
		[Ordinal(8)]  [RED("statsPlayTimeControllerdRef")] public inkWidgetReference StatsPlayTimeControllerdRef { get; set; }
		[Ordinal(9)]  [RED("btnInventory")] public inkWidgetReference BtnInventory { get; set; }
		[Ordinal(10)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(11)]  [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }
		[Ordinal(12)]  [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(13)]  [RED("player")] public wCHandle<PlayerPuppet> Player { get; set; }
		[Ordinal(14)]  [RED("healthStatsData")] public CArray<gameStatViewData> HealthStatsData { get; set; }
		[Ordinal(15)]  [RED("DPSStatsData")] public CArray<gameStatViewData> DPSStatsData { get; set; }
		[Ordinal(16)]  [RED("armorStatsData")] public CArray<gameStatViewData> ArmorStatsData { get; set; }
		[Ordinal(17)]  [RED("otherStatsData")] public CArray<gameStatViewData> OtherStatsData { get; set; }
		[Ordinal(18)]  [RED("playerStatsBlackboard")] public CHandle<gameIBlackboard> PlayerStatsBlackboard { get; set; }
		[Ordinal(19)]  [RED("currencyListener")] public CUInt32 CurrencyListener { get; set; }
		[Ordinal(20)]  [RED("characterCredListener")] public CUInt32 CharacterCredListener { get; set; }
		[Ordinal(21)]  [RED("characterLevelListener")] public CUInt32 CharacterLevelListener { get; set; }
		[Ordinal(22)]  [RED("characterCurrentXPListener")] public CUInt32 CharacterCurrentXPListener { get; set; }
		[Ordinal(23)]  [RED("characterCredPointsListener")] public CUInt32 CharacterCredPointsListener { get; set; }
		[Ordinal(24)]  [RED("PDS")] public CHandle<PlayerDevelopmentSystem> PDS { get; set; }
		[Ordinal(25)]  [RED("levelController")] public CHandle<StatsProgressController> LevelController { get; set; }
		[Ordinal(26)]  [RED("streetCredController")] public CHandle<StatsProgressController> StreetCredController { get; set; }
		[Ordinal(27)]  [RED("detailListController")] public CHandle<StatsDetailListController> DetailListController { get; set; }
		[Ordinal(28)]  [RED("statsStreetCredReward")] public CHandle<StatsStreetCredReward> StatsStreetCredReward { get; set; }
		[Ordinal(29)]  [RED("statsPlayTimeController")] public CHandle<StatsPlayTimeController> StatsPlayTimeController { get; set; }
		[Ordinal(30)]  [RED("previousMenuData")] public CHandle<PreviousMenuData> PreviousMenuData { get; set; }
		[Ordinal(31)]  [RED("buttonHintsController")] public wCHandle<ButtonHints> ButtonHintsController { get; set; }

		public StatsMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
