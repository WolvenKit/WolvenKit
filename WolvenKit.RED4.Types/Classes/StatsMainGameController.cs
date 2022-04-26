using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatsMainGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("MainViewRoot")] 
		public inkWidgetReference MainViewRoot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("statsList")] 
		public inkCompoundWidgetReference StatsList
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("levelControllerRef")] 
		public inkWidgetReference LevelControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("streetCredControllerRef")] 
		public inkWidgetReference StreetCredControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("detailListControllerRef")] 
		public inkWidgetReference DetailListControllerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("statsStreetCredRewardRef")] 
		public inkWidgetReference StatsStreetCredRewardRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("statsPlayTimeControllerdRef")] 
		public inkWidgetReference StatsPlayTimeControllerdRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("btnInventory")] 
		public inkWidgetReference BtnInventory
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("TooltipsManager")] 
		public CWeakHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetPropertyValue<CWeakHandle<gameuiTooltipsManager>>();
			set => SetPropertyValue<CWeakHandle<gameuiTooltipsManager>>(value);
		}

		[Ordinal(14)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(15)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(16)] 
		[RED("healthStatsData")] 
		public CArray<gameStatViewData> HealthStatsData
		{
			get => GetPropertyValue<CArray<gameStatViewData>>();
			set => SetPropertyValue<CArray<gameStatViewData>>(value);
		}

		[Ordinal(17)] 
		[RED("DPSStatsData")] 
		public CArray<gameStatViewData> DPSStatsData
		{
			get => GetPropertyValue<CArray<gameStatViewData>>();
			set => SetPropertyValue<CArray<gameStatViewData>>(value);
		}

		[Ordinal(18)] 
		[RED("armorStatsData")] 
		public CArray<gameStatViewData> ArmorStatsData
		{
			get => GetPropertyValue<CArray<gameStatViewData>>();
			set => SetPropertyValue<CArray<gameStatViewData>>(value);
		}

		[Ordinal(19)] 
		[RED("otherStatsData")] 
		public CArray<gameStatViewData> OtherStatsData
		{
			get => GetPropertyValue<CArray<gameStatViewData>>();
			set => SetPropertyValue<CArray<gameStatViewData>>(value);
		}

		[Ordinal(20)] 
		[RED("playerStatsBlackboard")] 
		public CWeakHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(21)] 
		[RED("currencyListener")] 
		public CHandle<redCallbackObject> CurrencyListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(22)] 
		[RED("characterCredListener")] 
		public CHandle<redCallbackObject> CharacterCredListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(23)] 
		[RED("characterLevelListener")] 
		public CHandle<redCallbackObject> CharacterLevelListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(24)] 
		[RED("characterCurrentXPListener")] 
		public CHandle<redCallbackObject> CharacterCurrentXPListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(25)] 
		[RED("characterCredPointsListener")] 
		public CHandle<redCallbackObject> CharacterCredPointsListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(26)] 
		[RED("PDS")] 
		public CHandle<PlayerDevelopmentSystem> PDS
		{
			get => GetPropertyValue<CHandle<PlayerDevelopmentSystem>>();
			set => SetPropertyValue<CHandle<PlayerDevelopmentSystem>>(value);
		}

		[Ordinal(27)] 
		[RED("levelController")] 
		public CWeakHandle<StatsProgressController> LevelController
		{
			get => GetPropertyValue<CWeakHandle<StatsProgressController>>();
			set => SetPropertyValue<CWeakHandle<StatsProgressController>>(value);
		}

		[Ordinal(28)] 
		[RED("streetCredController")] 
		public CWeakHandle<StatsProgressController> StreetCredController
		{
			get => GetPropertyValue<CWeakHandle<StatsProgressController>>();
			set => SetPropertyValue<CWeakHandle<StatsProgressController>>(value);
		}

		[Ordinal(29)] 
		[RED("detailListController")] 
		public CWeakHandle<StatsDetailListController> DetailListController
		{
			get => GetPropertyValue<CWeakHandle<StatsDetailListController>>();
			set => SetPropertyValue<CWeakHandle<StatsDetailListController>>(value);
		}

		[Ordinal(30)] 
		[RED("statsStreetCredReward")] 
		public CWeakHandle<StatsStreetCredReward> StatsStreetCredReward
		{
			get => GetPropertyValue<CWeakHandle<StatsStreetCredReward>>();
			set => SetPropertyValue<CWeakHandle<StatsStreetCredReward>>(value);
		}

		[Ordinal(31)] 
		[RED("statsPlayTimeController")] 
		public CWeakHandle<StatsPlayTimeController> StatsPlayTimeController
		{
			get => GetPropertyValue<CWeakHandle<StatsPlayTimeController>>();
			set => SetPropertyValue<CWeakHandle<StatsPlayTimeController>>(value);
		}

		[Ordinal(32)] 
		[RED("previousMenuData")] 
		public CHandle<PreviousMenuData> PreviousMenuData
		{
			get => GetPropertyValue<CHandle<PreviousMenuData>>();
			set => SetPropertyValue<CHandle<PreviousMenuData>>(value);
		}

		[Ordinal(33)] 
		[RED("buttonHintsController")] 
		public CWeakHandle<ButtonHints> ButtonHintsController
		{
			get => GetPropertyValue<CWeakHandle<ButtonHints>>();
			set => SetPropertyValue<CWeakHandle<ButtonHints>>(value);
		}

		public StatsMainGameController()
		{
			MainViewRoot = new();
			StatsList = new();
			TooltipsManagerRef = new();
			LevelControllerRef = new();
			StreetCredControllerRef = new();
			DetailListControllerRef = new();
			StatsStreetCredRewardRef = new();
			StatsPlayTimeControllerdRef = new();
			BtnInventory = new();
			ButtonHintsManagerRef = new();
			HealthStatsData = new();
			DPSStatsData = new();
			ArmorStatsData = new();
			OtherStatsData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
