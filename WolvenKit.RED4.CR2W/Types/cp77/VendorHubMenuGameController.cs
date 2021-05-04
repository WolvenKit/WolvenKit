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
			get => GetProperty(ref _selectorWidget);
			set => SetProperty(ref _selectorWidget, value);
		}

		[Ordinal(4)] 
		[RED("playerCurrency")] 
		public inkTextWidgetReference PlayerCurrency
		{
			get => GetProperty(ref _playerCurrency);
			set => SetProperty(ref _playerCurrency, value);
		}

		[Ordinal(5)] 
		[RED("vendorShopLabel")] 
		public inkTextWidgetReference VendorShopLabel
		{
			get => GetProperty(ref _vendorShopLabel);
			set => SetProperty(ref _vendorShopLabel, value);
		}

		[Ordinal(6)] 
		[RED("notificationRoot")] 
		public inkWidgetReference NotificationRoot
		{
			get => GetProperty(ref _notificationRoot);
			set => SetProperty(ref _notificationRoot, value);
		}

		[Ordinal(7)] 
		[RED("playerWeight")] 
		public inkTextWidgetReference PlayerWeight
		{
			get => GetProperty(ref _playerWeight);
			set => SetProperty(ref _playerWeight, value);
		}

		[Ordinal(8)] 
		[RED("levelValue")] 
		public inkTextWidgetReference LevelValue
		{
			get => GetProperty(ref _levelValue);
			set => SetProperty(ref _levelValue, value);
		}

		[Ordinal(9)] 
		[RED("streetCredLabel")] 
		public inkTextWidgetReference StreetCredLabel
		{
			get => GetProperty(ref _streetCredLabel);
			set => SetProperty(ref _streetCredLabel, value);
		}

		[Ordinal(10)] 
		[RED("levelBarProgress")] 
		public inkWidgetReference LevelBarProgress
		{
			get => GetProperty(ref _levelBarProgress);
			set => SetProperty(ref _levelBarProgress, value);
		}

		[Ordinal(11)] 
		[RED("levelBarSpacer")] 
		public inkWidgetReference LevelBarSpacer
		{
			get => GetProperty(ref _levelBarSpacer);
			set => SetProperty(ref _levelBarSpacer, value);
		}

		[Ordinal(12)] 
		[RED("streetCredBarProgress")] 
		public inkWidgetReference StreetCredBarProgress
		{
			get => GetProperty(ref _streetCredBarProgress);
			set => SetProperty(ref _streetCredBarProgress, value);
		}

		[Ordinal(13)] 
		[RED("streetCredBarSpacer")] 
		public inkWidgetReference StreetCredBarSpacer
		{
			get => GetProperty(ref _streetCredBarSpacer);
			set => SetProperty(ref _streetCredBarSpacer, value);
		}

		[Ordinal(14)] 
		[RED("selectorCtrl")] 
		public wCHandle<hubSelectorSingleSmallCarouselController> SelectorCtrl
		{
			get => GetProperty(ref _selectorCtrl);
			set => SetProperty(ref _selectorCtrl, value);
		}

		[Ordinal(15)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get => GetProperty(ref _vendorDataManager);
			set => SetProperty(ref _vendorDataManager, value);
		}

		[Ordinal(16)] 
		[RED("vendorUserData")] 
		public CHandle<VendorUserData> VendorUserData
		{
			get => GetProperty(ref _vendorUserData);
			set => SetProperty(ref _vendorUserData, value);
		}

		[Ordinal(17)] 
		[RED("vendorPanelData")] 
		public CHandle<questVendorPanelData> VendorPanelData
		{
			get => GetProperty(ref _vendorPanelData);
			set => SetProperty(ref _vendorPanelData, value);
		}

		[Ordinal(18)] 
		[RED("storageUserData")] 
		public CHandle<StorageUserData> StorageUserData
		{
			get => GetProperty(ref _storageUserData);
			set => SetProperty(ref _storageUserData, value);
		}

		[Ordinal(19)] 
		[RED("PDS")] 
		public CHandle<PlayerDevelopmentSystem> PDS
		{
			get => GetProperty(ref _pDS);
			set => SetProperty(ref _pDS, value);
		}

		[Ordinal(20)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(21)] 
		[RED("VendorBlackboard")] 
		public CHandle<gameIBlackboard> VendorBlackboard
		{
			get => GetProperty(ref _vendorBlackboard);
			set => SetProperty(ref _vendorBlackboard, value);
		}

		[Ordinal(22)] 
		[RED("playerStatsBlackboard")] 
		public CHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetProperty(ref _playerStatsBlackboard);
			set => SetProperty(ref _playerStatsBlackboard, value);
		}

		[Ordinal(23)] 
		[RED("VendorBlackboardDef")] 
		public CHandle<UI_VendorDef> VendorBlackboardDef
		{
			get => GetProperty(ref _vendorBlackboardDef);
			set => SetProperty(ref _vendorBlackboardDef, value);
		}

		[Ordinal(24)] 
		[RED("VendorUpdatedCallbackID")] 
		public CUInt32 VendorUpdatedCallbackID
		{
			get => GetProperty(ref _vendorUpdatedCallbackID);
			set => SetProperty(ref _vendorUpdatedCallbackID, value);
		}

		[Ordinal(25)] 
		[RED("weightListener")] 
		public CUInt32 WeightListener
		{
			get => GetProperty(ref _weightListener);
			set => SetProperty(ref _weightListener, value);
		}

		[Ordinal(26)] 
		[RED("characterLevelListener")] 
		public CUInt32 CharacterLevelListener
		{
			get => GetProperty(ref _characterLevelListener);
			set => SetProperty(ref _characterLevelListener, value);
		}

		[Ordinal(27)] 
		[RED("characterCurrentXPListener")] 
		public CUInt32 CharacterCurrentXPListener
		{
			get => GetProperty(ref _characterCurrentXPListener);
			set => SetProperty(ref _characterCurrentXPListener, value);
		}

		[Ordinal(28)] 
		[RED("characterCredListener")] 
		public CUInt32 CharacterCredListener
		{
			get => GetProperty(ref _characterCredListener);
			set => SetProperty(ref _characterCredListener, value);
		}

		[Ordinal(29)] 
		[RED("characterCredPointsListener")] 
		public CUInt32 CharacterCredPointsListener
		{
			get => GetProperty(ref _characterCredPointsListener);
			set => SetProperty(ref _characterCredPointsListener, value);
		}

		[Ordinal(30)] 
		[RED("characterCurrentHealthListener")] 
		public CUInt32 CharacterCurrentHealthListener
		{
			get => GetProperty(ref _characterCurrentHealthListener);
			set => SetProperty(ref _characterCurrentHealthListener, value);
		}

		[Ordinal(31)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(32)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(33)] 
		[RED("menuData")] 
		public CArray<MenuData> MenuData
		{
			get => GetProperty(ref _menuData);
			set => SetProperty(ref _menuData, value);
		}

		[Ordinal(34)] 
		[RED("storageDef")] 
		public CHandle<StorageBlackboardDef> StorageDef
		{
			get => GetProperty(ref _storageDef);
			set => SetProperty(ref _storageDef, value);
		}

		[Ordinal(35)] 
		[RED("storageBlackboard")] 
		public CHandle<gameIBlackboard> StorageBlackboard
		{
			get => GetProperty(ref _storageBlackboard);
			set => SetProperty(ref _storageBlackboard, value);
		}

		public VendorHubMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
