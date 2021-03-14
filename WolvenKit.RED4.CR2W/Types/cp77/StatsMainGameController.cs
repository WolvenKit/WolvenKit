using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatsMainGameController : gameuiMenuGameController
	{
		private inkWidgetReference _mainViewRoot;
		private inkCompoundWidgetReference _statsList;
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _levelControllerRef;
		private inkWidgetReference _streetCredControllerRef;
		private inkWidgetReference _detailListControllerRef;
		private inkWidgetReference _statsStreetCredRewardRef;
		private inkWidgetReference _statsPlayTimeControllerdRef;
		private inkWidgetReference _btnInventory;
		private inkWidgetReference _buttonHintsManagerRef;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<PlayerPuppet> _player;
		private CArray<gameStatViewData> _healthStatsData;
		private CArray<gameStatViewData> _dPSStatsData;
		private CArray<gameStatViewData> _armorStatsData;
		private CArray<gameStatViewData> _otherStatsData;
		private CHandle<gameIBlackboard> _playerStatsBlackboard;
		private CUInt32 _currencyListener;
		private CUInt32 _characterCredListener;
		private CUInt32 _characterLevelListener;
		private CUInt32 _characterCurrentXPListener;
		private CUInt32 _characterCredPointsListener;
		private CHandle<PlayerDevelopmentSystem> _pDS;
		private CHandle<StatsProgressController> _levelController;
		private CHandle<StatsProgressController> _streetCredController;
		private CHandle<StatsDetailListController> _detailListController;
		private CHandle<StatsStreetCredReward> _statsStreetCredReward;
		private CHandle<StatsPlayTimeController> _statsPlayTimeController;
		private CHandle<PreviousMenuData> _previousMenuData;
		private wCHandle<ButtonHints> _buttonHintsController;

		[Ordinal(3)] 
		[RED("MainViewRoot")] 
		public inkWidgetReference MainViewRoot
		{
			get
			{
				if (_mainViewRoot == null)
				{
					_mainViewRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "MainViewRoot", cr2w, this);
				}
				return _mainViewRoot;
			}
			set
			{
				if (_mainViewRoot == value)
				{
					return;
				}
				_mainViewRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("statsList")] 
		public inkCompoundWidgetReference StatsList
		{
			get
			{
				if (_statsList == null)
				{
					_statsList = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "statsList", cr2w, this);
				}
				return _statsList;
			}
			set
			{
				if (_statsList == value)
				{
					return;
				}
				_statsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get
			{
				if (_tooltipsManagerRef == null)
				{
					_tooltipsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "TooltipsManagerRef", cr2w, this);
				}
				return _tooltipsManagerRef;
			}
			set
			{
				if (_tooltipsManagerRef == value)
				{
					return;
				}
				_tooltipsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("levelControllerRef")] 
		public inkWidgetReference LevelControllerRef
		{
			get
			{
				if (_levelControllerRef == null)
				{
					_levelControllerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "levelControllerRef", cr2w, this);
				}
				return _levelControllerRef;
			}
			set
			{
				if (_levelControllerRef == value)
				{
					return;
				}
				_levelControllerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("streetCredControllerRef")] 
		public inkWidgetReference StreetCredControllerRef
		{
			get
			{
				if (_streetCredControllerRef == null)
				{
					_streetCredControllerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "streetCredControllerRef", cr2w, this);
				}
				return _streetCredControllerRef;
			}
			set
			{
				if (_streetCredControllerRef == value)
				{
					return;
				}
				_streetCredControllerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("detailListControllerRef")] 
		public inkWidgetReference DetailListControllerRef
		{
			get
			{
				if (_detailListControllerRef == null)
				{
					_detailListControllerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "detailListControllerRef", cr2w, this);
				}
				return _detailListControllerRef;
			}
			set
			{
				if (_detailListControllerRef == value)
				{
					return;
				}
				_detailListControllerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("statsStreetCredRewardRef")] 
		public inkWidgetReference StatsStreetCredRewardRef
		{
			get
			{
				if (_statsStreetCredRewardRef == null)
				{
					_statsStreetCredRewardRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "statsStreetCredRewardRef", cr2w, this);
				}
				return _statsStreetCredRewardRef;
			}
			set
			{
				if (_statsStreetCredRewardRef == value)
				{
					return;
				}
				_statsStreetCredRewardRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("statsPlayTimeControllerdRef")] 
		public inkWidgetReference StatsPlayTimeControllerdRef
		{
			get
			{
				if (_statsPlayTimeControllerdRef == null)
				{
					_statsPlayTimeControllerdRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "statsPlayTimeControllerdRef", cr2w, this);
				}
				return _statsPlayTimeControllerdRef;
			}
			set
			{
				if (_statsPlayTimeControllerdRef == value)
				{
					return;
				}
				_statsPlayTimeControllerdRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("btnInventory")] 
		public inkWidgetReference BtnInventory
		{
			get
			{
				if (_btnInventory == null)
				{
					_btnInventory = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "btnInventory", cr2w, this);
				}
				return _btnInventory;
			}
			set
			{
				if (_btnInventory == value)
				{
					return;
				}
				_btnInventory = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get
			{
				if (_buttonHintsManagerRef == null)
				{
					_buttonHintsManagerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "buttonHintsManagerRef", cr2w, this);
				}
				return _buttonHintsManagerRef;
			}
			set
			{
				if (_buttonHintsManagerRef == value)
				{
					return;
				}
				_buttonHintsManagerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get
			{
				if (_tooltipsManager == null)
				{
					_tooltipsManager = (wCHandle<gameuiTooltipsManager>) CR2WTypeManager.Create("whandle:gameuiTooltipsManager", "TooltipsManager", cr2w, this);
				}
				return _tooltipsManager;
			}
			set
			{
				if (_tooltipsManager == value)
				{
					return;
				}
				_tooltipsManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get
			{
				if (_inventoryManager == null)
				{
					_inventoryManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "InventoryManager", cr2w, this);
				}
				return _inventoryManager;
			}
			set
			{
				if (_inventoryManager == value)
				{
					return;
				}
				_inventoryManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get
			{
				if (_player == null)
				{
					_player = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "player", cr2w, this);
				}
				return _player;
			}
			set
			{
				if (_player == value)
				{
					return;
				}
				_player = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("healthStatsData")] 
		public CArray<gameStatViewData> HealthStatsData
		{
			get
			{
				if (_healthStatsData == null)
				{
					_healthStatsData = (CArray<gameStatViewData>) CR2WTypeManager.Create("array:gameStatViewData", "healthStatsData", cr2w, this);
				}
				return _healthStatsData;
			}
			set
			{
				if (_healthStatsData == value)
				{
					return;
				}
				_healthStatsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("DPSStatsData")] 
		public CArray<gameStatViewData> DPSStatsData
		{
			get
			{
				if (_dPSStatsData == null)
				{
					_dPSStatsData = (CArray<gameStatViewData>) CR2WTypeManager.Create("array:gameStatViewData", "DPSStatsData", cr2w, this);
				}
				return _dPSStatsData;
			}
			set
			{
				if (_dPSStatsData == value)
				{
					return;
				}
				_dPSStatsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("armorStatsData")] 
		public CArray<gameStatViewData> ArmorStatsData
		{
			get
			{
				if (_armorStatsData == null)
				{
					_armorStatsData = (CArray<gameStatViewData>) CR2WTypeManager.Create("array:gameStatViewData", "armorStatsData", cr2w, this);
				}
				return _armorStatsData;
			}
			set
			{
				if (_armorStatsData == value)
				{
					return;
				}
				_armorStatsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("otherStatsData")] 
		public CArray<gameStatViewData> OtherStatsData
		{
			get
			{
				if (_otherStatsData == null)
				{
					_otherStatsData = (CArray<gameStatViewData>) CR2WTypeManager.Create("array:gameStatViewData", "otherStatsData", cr2w, this);
				}
				return _otherStatsData;
			}
			set
			{
				if (_otherStatsData == value)
				{
					return;
				}
				_otherStatsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("playerStatsBlackboard")] 
		public CHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get
			{
				if (_playerStatsBlackboard == null)
				{
					_playerStatsBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "playerStatsBlackboard", cr2w, this);
				}
				return _playerStatsBlackboard;
			}
			set
			{
				if (_playerStatsBlackboard == value)
				{
					return;
				}
				_playerStatsBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("currencyListener")] 
		public CUInt32 CurrencyListener
		{
			get
			{
				if (_currencyListener == null)
				{
					_currencyListener = (CUInt32) CR2WTypeManager.Create("Uint32", "currencyListener", cr2w, this);
				}
				return _currencyListener;
			}
			set
			{
				if (_currencyListener == value)
				{
					return;
				}
				_currencyListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("characterCredListener")] 
		public CUInt32 CharacterCredListener
		{
			get
			{
				if (_characterCredListener == null)
				{
					_characterCredListener = (CUInt32) CR2WTypeManager.Create("Uint32", "characterCredListener", cr2w, this);
				}
				return _characterCredListener;
			}
			set
			{
				if (_characterCredListener == value)
				{
					return;
				}
				_characterCredListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("characterLevelListener")] 
		public CUInt32 CharacterLevelListener
		{
			get
			{
				if (_characterLevelListener == null)
				{
					_characterLevelListener = (CUInt32) CR2WTypeManager.Create("Uint32", "characterLevelListener", cr2w, this);
				}
				return _characterLevelListener;
			}
			set
			{
				if (_characterLevelListener == value)
				{
					return;
				}
				_characterLevelListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("characterCurrentXPListener")] 
		public CUInt32 CharacterCurrentXPListener
		{
			get
			{
				if (_characterCurrentXPListener == null)
				{
					_characterCurrentXPListener = (CUInt32) CR2WTypeManager.Create("Uint32", "characterCurrentXPListener", cr2w, this);
				}
				return _characterCurrentXPListener;
			}
			set
			{
				if (_characterCurrentXPListener == value)
				{
					return;
				}
				_characterCurrentXPListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("characterCredPointsListener")] 
		public CUInt32 CharacterCredPointsListener
		{
			get
			{
				if (_characterCredPointsListener == null)
				{
					_characterCredPointsListener = (CUInt32) CR2WTypeManager.Create("Uint32", "characterCredPointsListener", cr2w, this);
				}
				return _characterCredPointsListener;
			}
			set
			{
				if (_characterCredPointsListener == value)
				{
					return;
				}
				_characterCredPointsListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("PDS")] 
		public CHandle<PlayerDevelopmentSystem> PDS
		{
			get
			{
				if (_pDS == null)
				{
					_pDS = (CHandle<PlayerDevelopmentSystem>) CR2WTypeManager.Create("handle:PlayerDevelopmentSystem", "PDS", cr2w, this);
				}
				return _pDS;
			}
			set
			{
				if (_pDS == value)
				{
					return;
				}
				_pDS = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("levelController")] 
		public CHandle<StatsProgressController> LevelController
		{
			get
			{
				if (_levelController == null)
				{
					_levelController = (CHandle<StatsProgressController>) CR2WTypeManager.Create("handle:StatsProgressController", "levelController", cr2w, this);
				}
				return _levelController;
			}
			set
			{
				if (_levelController == value)
				{
					return;
				}
				_levelController = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("streetCredController")] 
		public CHandle<StatsProgressController> StreetCredController
		{
			get
			{
				if (_streetCredController == null)
				{
					_streetCredController = (CHandle<StatsProgressController>) CR2WTypeManager.Create("handle:StatsProgressController", "streetCredController", cr2w, this);
				}
				return _streetCredController;
			}
			set
			{
				if (_streetCredController == value)
				{
					return;
				}
				_streetCredController = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("detailListController")] 
		public CHandle<StatsDetailListController> DetailListController
		{
			get
			{
				if (_detailListController == null)
				{
					_detailListController = (CHandle<StatsDetailListController>) CR2WTypeManager.Create("handle:StatsDetailListController", "detailListController", cr2w, this);
				}
				return _detailListController;
			}
			set
			{
				if (_detailListController == value)
				{
					return;
				}
				_detailListController = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("statsStreetCredReward")] 
		public CHandle<StatsStreetCredReward> StatsStreetCredReward
		{
			get
			{
				if (_statsStreetCredReward == null)
				{
					_statsStreetCredReward = (CHandle<StatsStreetCredReward>) CR2WTypeManager.Create("handle:StatsStreetCredReward", "statsStreetCredReward", cr2w, this);
				}
				return _statsStreetCredReward;
			}
			set
			{
				if (_statsStreetCredReward == value)
				{
					return;
				}
				_statsStreetCredReward = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("statsPlayTimeController")] 
		public CHandle<StatsPlayTimeController> StatsPlayTimeController
		{
			get
			{
				if (_statsPlayTimeController == null)
				{
					_statsPlayTimeController = (CHandle<StatsPlayTimeController>) CR2WTypeManager.Create("handle:StatsPlayTimeController", "statsPlayTimeController", cr2w, this);
				}
				return _statsPlayTimeController;
			}
			set
			{
				if (_statsPlayTimeController == value)
				{
					return;
				}
				_statsPlayTimeController = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("previousMenuData")] 
		public CHandle<PreviousMenuData> PreviousMenuData
		{
			get
			{
				if (_previousMenuData == null)
				{
					_previousMenuData = (CHandle<PreviousMenuData>) CR2WTypeManager.Create("handle:PreviousMenuData", "previousMenuData", cr2w, this);
				}
				return _previousMenuData;
			}
			set
			{
				if (_previousMenuData == value)
				{
					return;
				}
				_previousMenuData = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get
			{
				if (_buttonHintsController == null)
				{
					_buttonHintsController = (wCHandle<ButtonHints>) CR2WTypeManager.Create("whandle:ButtonHints", "buttonHintsController", cr2w, this);
				}
				return _buttonHintsController;
			}
			set
			{
				if (_buttonHintsController == value)
				{
					return;
				}
				_buttonHintsController = value;
				PropertySet(this);
			}
		}

		public StatsMainGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
