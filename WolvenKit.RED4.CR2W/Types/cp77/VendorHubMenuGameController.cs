using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorHubMenuGameController : gameuiMenuGameController
	{
		private inkWidgetReference _selectorWidget;
		private inkTextWidgetReference _playerCurrency;
		private inkTextWidgetReference _vendorShopLabel;
		private inkWidgetReference _notificationRoot;
		private inkTextWidgetReference _playerWeight;
		private inkTextWidgetReference _levelValue;
		private inkTextWidgetReference _streetCredLabel;
		private inkWidgetReference _levelBarProgress;
		private inkWidgetReference _levelBarSpacer;
		private inkWidgetReference _streetCredBarProgress;
		private inkWidgetReference _streetCredBarSpacer;
		private wCHandle<hubSelectorSingleSmallCarouselController> _selectorCtrl;
		private CHandle<VendorDataManager> _vendorDataManager;
		private CHandle<VendorUserData> _vendorUserData;
		private CHandle<questVendorPanelData> _vendorPanelData;
		private CHandle<StorageUserData> _storageUserData;
		private CHandle<PlayerDevelopmentSystem> _pDS;
		private wCHandle<inkWidget> _root;
		private CHandle<gameIBlackboard> _vendorBlackboard;
		private CHandle<gameIBlackboard> _playerStatsBlackboard;
		private CHandle<UI_VendorDef> _vendorBlackboardDef;
		private CUInt32 _vendorUpdatedCallbackID;
		private CUInt32 _weightListener;
		private CUInt32 _characterLevelListener;
		private CUInt32 _characterCurrentXPListener;
		private CUInt32 _characterCredListener;
		private CUInt32 _characterCredPointsListener;
		private CUInt32 _characterCurrentHealthListener;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<PlayerPuppet> _player;
		private CArray<MenuData> _menuData;
		private CHandle<StorageBlackboardDef> _storageDef;
		private CHandle<gameIBlackboard> _storageBlackboard;

		[Ordinal(3)] 
		[RED("selectorWidget")] 
		public inkWidgetReference SelectorWidget
		{
			get
			{
				if (_selectorWidget == null)
				{
					_selectorWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "selectorWidget", cr2w, this);
				}
				return _selectorWidget;
			}
			set
			{
				if (_selectorWidget == value)
				{
					return;
				}
				_selectorWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("playerCurrency")] 
		public inkTextWidgetReference PlayerCurrency
		{
			get
			{
				if (_playerCurrency == null)
				{
					_playerCurrency = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "playerCurrency", cr2w, this);
				}
				return _playerCurrency;
			}
			set
			{
				if (_playerCurrency == value)
				{
					return;
				}
				_playerCurrency = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("vendorShopLabel")] 
		public inkTextWidgetReference VendorShopLabel
		{
			get
			{
				if (_vendorShopLabel == null)
				{
					_vendorShopLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "vendorShopLabel", cr2w, this);
				}
				return _vendorShopLabel;
			}
			set
			{
				if (_vendorShopLabel == value)
				{
					return;
				}
				_vendorShopLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("notificationRoot")] 
		public inkWidgetReference NotificationRoot
		{
			get
			{
				if (_notificationRoot == null)
				{
					_notificationRoot = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "notificationRoot", cr2w, this);
				}
				return _notificationRoot;
			}
			set
			{
				if (_notificationRoot == value)
				{
					return;
				}
				_notificationRoot = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("playerWeight")] 
		public inkTextWidgetReference PlayerWeight
		{
			get
			{
				if (_playerWeight == null)
				{
					_playerWeight = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "playerWeight", cr2w, this);
				}
				return _playerWeight;
			}
			set
			{
				if (_playerWeight == value)
				{
					return;
				}
				_playerWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("levelValue")] 
		public inkTextWidgetReference LevelValue
		{
			get
			{
				if (_levelValue == null)
				{
					_levelValue = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "levelValue", cr2w, this);
				}
				return _levelValue;
			}
			set
			{
				if (_levelValue == value)
				{
					return;
				}
				_levelValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("streetCredLabel")] 
		public inkTextWidgetReference StreetCredLabel
		{
			get
			{
				if (_streetCredLabel == null)
				{
					_streetCredLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "streetCredLabel", cr2w, this);
				}
				return _streetCredLabel;
			}
			set
			{
				if (_streetCredLabel == value)
				{
					return;
				}
				_streetCredLabel = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("levelBarProgress")] 
		public inkWidgetReference LevelBarProgress
		{
			get
			{
				if (_levelBarProgress == null)
				{
					_levelBarProgress = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "levelBarProgress", cr2w, this);
				}
				return _levelBarProgress;
			}
			set
			{
				if (_levelBarProgress == value)
				{
					return;
				}
				_levelBarProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("levelBarSpacer")] 
		public inkWidgetReference LevelBarSpacer
		{
			get
			{
				if (_levelBarSpacer == null)
				{
					_levelBarSpacer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "levelBarSpacer", cr2w, this);
				}
				return _levelBarSpacer;
			}
			set
			{
				if (_levelBarSpacer == value)
				{
					return;
				}
				_levelBarSpacer = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("streetCredBarProgress")] 
		public inkWidgetReference StreetCredBarProgress
		{
			get
			{
				if (_streetCredBarProgress == null)
				{
					_streetCredBarProgress = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "streetCredBarProgress", cr2w, this);
				}
				return _streetCredBarProgress;
			}
			set
			{
				if (_streetCredBarProgress == value)
				{
					return;
				}
				_streetCredBarProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("streetCredBarSpacer")] 
		public inkWidgetReference StreetCredBarSpacer
		{
			get
			{
				if (_streetCredBarSpacer == null)
				{
					_streetCredBarSpacer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "streetCredBarSpacer", cr2w, this);
				}
				return _streetCredBarSpacer;
			}
			set
			{
				if (_streetCredBarSpacer == value)
				{
					return;
				}
				_streetCredBarSpacer = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("selectorCtrl")] 
		public wCHandle<hubSelectorSingleSmallCarouselController> SelectorCtrl
		{
			get
			{
				if (_selectorCtrl == null)
				{
					_selectorCtrl = (wCHandle<hubSelectorSingleSmallCarouselController>) CR2WTypeManager.Create("whandle:hubSelectorSingleSmallCarouselController", "selectorCtrl", cr2w, this);
				}
				return _selectorCtrl;
			}
			set
			{
				if (_selectorCtrl == value)
				{
					return;
				}
				_selectorCtrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get
			{
				if (_vendorDataManager == null)
				{
					_vendorDataManager = (CHandle<VendorDataManager>) CR2WTypeManager.Create("handle:VendorDataManager", "VendorDataManager", cr2w, this);
				}
				return _vendorDataManager;
			}
			set
			{
				if (_vendorDataManager == value)
				{
					return;
				}
				_vendorDataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("vendorUserData")] 
		public CHandle<VendorUserData> VendorUserData
		{
			get
			{
				if (_vendorUserData == null)
				{
					_vendorUserData = (CHandle<VendorUserData>) CR2WTypeManager.Create("handle:VendorUserData", "vendorUserData", cr2w, this);
				}
				return _vendorUserData;
			}
			set
			{
				if (_vendorUserData == value)
				{
					return;
				}
				_vendorUserData = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("vendorPanelData")] 
		public CHandle<questVendorPanelData> VendorPanelData
		{
			get
			{
				if (_vendorPanelData == null)
				{
					_vendorPanelData = (CHandle<questVendorPanelData>) CR2WTypeManager.Create("handle:questVendorPanelData", "vendorPanelData", cr2w, this);
				}
				return _vendorPanelData;
			}
			set
			{
				if (_vendorPanelData == value)
				{
					return;
				}
				_vendorPanelData = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("storageUserData")] 
		public CHandle<StorageUserData> StorageUserData
		{
			get
			{
				if (_storageUserData == null)
				{
					_storageUserData = (CHandle<StorageUserData>) CR2WTypeManager.Create("handle:StorageUserData", "storageUserData", cr2w, this);
				}
				return _storageUserData;
			}
			set
			{
				if (_storageUserData == value)
				{
					return;
				}
				_storageUserData = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
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

		[Ordinal(20)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("VendorBlackboard")] 
		public CHandle<gameIBlackboard> VendorBlackboard
		{
			get
			{
				if (_vendorBlackboard == null)
				{
					_vendorBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "VendorBlackboard", cr2w, this);
				}
				return _vendorBlackboard;
			}
			set
			{
				if (_vendorBlackboard == value)
				{
					return;
				}
				_vendorBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
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

		[Ordinal(23)] 
		[RED("VendorBlackboardDef")] 
		public CHandle<UI_VendorDef> VendorBlackboardDef
		{
			get
			{
				if (_vendorBlackboardDef == null)
				{
					_vendorBlackboardDef = (CHandle<UI_VendorDef>) CR2WTypeManager.Create("handle:UI_VendorDef", "VendorBlackboardDef", cr2w, this);
				}
				return _vendorBlackboardDef;
			}
			set
			{
				if (_vendorBlackboardDef == value)
				{
					return;
				}
				_vendorBlackboardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("VendorUpdatedCallbackID")] 
		public CUInt32 VendorUpdatedCallbackID
		{
			get
			{
				if (_vendorUpdatedCallbackID == null)
				{
					_vendorUpdatedCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "VendorUpdatedCallbackID", cr2w, this);
				}
				return _vendorUpdatedCallbackID;
			}
			set
			{
				if (_vendorUpdatedCallbackID == value)
				{
					return;
				}
				_vendorUpdatedCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("weightListener")] 
		public CUInt32 WeightListener
		{
			get
			{
				if (_weightListener == null)
				{
					_weightListener = (CUInt32) CR2WTypeManager.Create("Uint32", "weightListener", cr2w, this);
				}
				return _weightListener;
			}
			set
			{
				if (_weightListener == value)
				{
					return;
				}
				_weightListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
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

		[Ordinal(27)] 
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

		[Ordinal(28)] 
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

		[Ordinal(29)] 
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

		[Ordinal(30)] 
		[RED("characterCurrentHealthListener")] 
		public CUInt32 CharacterCurrentHealthListener
		{
			get
			{
				if (_characterCurrentHealthListener == null)
				{
					_characterCurrentHealthListener = (CUInt32) CR2WTypeManager.Create("Uint32", "characterCurrentHealthListener", cr2w, this);
				}
				return _characterCurrentHealthListener;
			}
			set
			{
				if (_characterCurrentHealthListener == value)
				{
					return;
				}
				_characterCurrentHealthListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get
			{
				if (_menuEventDispatcher == null)
				{
					_menuEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "menuEventDispatcher", cr2w, this);
				}
				return _menuEventDispatcher;
			}
			set
			{
				if (_menuEventDispatcher == value)
				{
					return;
				}
				_menuEventDispatcher = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
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

		[Ordinal(33)] 
		[RED("menuData")] 
		public CArray<MenuData> MenuData
		{
			get
			{
				if (_menuData == null)
				{
					_menuData = (CArray<MenuData>) CR2WTypeManager.Create("array:MenuData", "menuData", cr2w, this);
				}
				return _menuData;
			}
			set
			{
				if (_menuData == value)
				{
					return;
				}
				_menuData = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("storageDef")] 
		public CHandle<StorageBlackboardDef> StorageDef
		{
			get
			{
				if (_storageDef == null)
				{
					_storageDef = (CHandle<StorageBlackboardDef>) CR2WTypeManager.Create("handle:StorageBlackboardDef", "storageDef", cr2w, this);
				}
				return _storageDef;
			}
			set
			{
				if (_storageDef == value)
				{
					return;
				}
				_storageDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("storageBlackboard")] 
		public CHandle<gameIBlackboard> StorageBlackboard
		{
			get
			{
				if (_storageBlackboard == null)
				{
					_storageBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "storageBlackboard", cr2w, this);
				}
				return _storageBlackboard;
			}
			set
			{
				if (_storageBlackboard == value)
				{
					return;
				}
				_storageBlackboard = value;
				PropertySet(this);
			}
		}

		public VendorHubMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
