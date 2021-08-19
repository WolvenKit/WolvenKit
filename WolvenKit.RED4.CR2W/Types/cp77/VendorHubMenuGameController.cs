using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorHubMenuGameController : gameuiMenuGameController
	{
		private inkWidgetReference _tabRootContainer;
		private inkWidgetReference _tabRootRef;
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
		private CHandle<VendorDataManager> _vendorDataManager;
		private CHandle<VendorUserData> _vendorUserData;
		private CHandle<questVendorPanelData> _vendorPanelData;
		private CHandle<StorageUserData> _storageUserData;
		private CHandle<PlayerDevelopmentSystem> _pDS;
		private wCHandle<inkWidget> _root;
		private wCHandle<TabRadioGroup> _tabRoot;
		private wCHandle<gameIBlackboard> _vendorBlackboard;
		private wCHandle<gameIBlackboard> _playerStatsBlackboard;
		private CHandle<UI_VendorDef> _vendorBlackboardDef;
		private CHandle<redCallbackObject> _vendorUpdatedCallbackID;
		private CHandle<redCallbackObject> _weightListener;
		private CHandle<redCallbackObject> _characterLevelListener;
		private CHandle<redCallbackObject> _characterCurrentXPListener;
		private CHandle<redCallbackObject> _characterCredListener;
		private CHandle<redCallbackObject> _characterCredPointsListener;
		private CHandle<redCallbackObject> _characterCurrentHealthListener;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<PlayerPuppet> _player;
		private CArray<MenuData> _menuData;
		private CHandle<StorageBlackboardDef> _storageDef;
		private wCHandle<gameIBlackboard> _storageBlackboard;

		[Ordinal(3)] 
		[RED("tabRootContainer")] 
		public inkWidgetReference TabRootContainer
		{
			get => GetProperty(ref _tabRootContainer);
			set => SetProperty(ref _tabRootContainer, value);
		}

		[Ordinal(4)] 
		[RED("tabRootRef")] 
		public inkWidgetReference TabRootRef
		{
			get => GetProperty(ref _tabRootRef);
			set => SetProperty(ref _tabRootRef, value);
		}

		[Ordinal(5)] 
		[RED("playerCurrency")] 
		public inkTextWidgetReference PlayerCurrency
		{
			get => GetProperty(ref _playerCurrency);
			set => SetProperty(ref _playerCurrency, value);
		}

		[Ordinal(6)] 
		[RED("vendorShopLabel")] 
		public inkTextWidgetReference VendorShopLabel
		{
			get => GetProperty(ref _vendorShopLabel);
			set => SetProperty(ref _vendorShopLabel, value);
		}

		[Ordinal(7)] 
		[RED("notificationRoot")] 
		public inkWidgetReference NotificationRoot
		{
			get => GetProperty(ref _notificationRoot);
			set => SetProperty(ref _notificationRoot, value);
		}

		[Ordinal(8)] 
		[RED("playerWeight")] 
		public inkTextWidgetReference PlayerWeight
		{
			get => GetProperty(ref _playerWeight);
			set => SetProperty(ref _playerWeight, value);
		}

		[Ordinal(9)] 
		[RED("levelValue")] 
		public inkTextWidgetReference LevelValue
		{
			get => GetProperty(ref _levelValue);
			set => SetProperty(ref _levelValue, value);
		}

		[Ordinal(10)] 
		[RED("streetCredLabel")] 
		public inkTextWidgetReference StreetCredLabel
		{
			get => GetProperty(ref _streetCredLabel);
			set => SetProperty(ref _streetCredLabel, value);
		}

		[Ordinal(11)] 
		[RED("levelBarProgress")] 
		public inkWidgetReference LevelBarProgress
		{
			get => GetProperty(ref _levelBarProgress);
			set => SetProperty(ref _levelBarProgress, value);
		}

		[Ordinal(12)] 
		[RED("levelBarSpacer")] 
		public inkWidgetReference LevelBarSpacer
		{
			get => GetProperty(ref _levelBarSpacer);
			set => SetProperty(ref _levelBarSpacer, value);
		}

		[Ordinal(13)] 
		[RED("streetCredBarProgress")] 
		public inkWidgetReference StreetCredBarProgress
		{
			get => GetProperty(ref _streetCredBarProgress);
			set => SetProperty(ref _streetCredBarProgress, value);
		}

		[Ordinal(14)] 
		[RED("streetCredBarSpacer")] 
		public inkWidgetReference StreetCredBarSpacer
		{
			get => GetProperty(ref _streetCredBarSpacer);
			set => SetProperty(ref _streetCredBarSpacer, value);
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
		[RED("tabRoot")] 
		public wCHandle<TabRadioGroup> TabRoot
		{
			get => GetProperty(ref _tabRoot);
			set => SetProperty(ref _tabRoot, value);
		}

		[Ordinal(22)] 
		[RED("VendorBlackboard")] 
		public wCHandle<gameIBlackboard> VendorBlackboard
		{
			get => GetProperty(ref _vendorBlackboard);
			set => SetProperty(ref _vendorBlackboard, value);
		}

		[Ordinal(23)] 
		[RED("playerStatsBlackboard")] 
		public wCHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetProperty(ref _playerStatsBlackboard);
			set => SetProperty(ref _playerStatsBlackboard, value);
		}

		[Ordinal(24)] 
		[RED("VendorBlackboardDef")] 
		public CHandle<UI_VendorDef> VendorBlackboardDef
		{
			get => GetProperty(ref _vendorBlackboardDef);
			set => SetProperty(ref _vendorBlackboardDef, value);
		}

		[Ordinal(25)] 
		[RED("VendorUpdatedCallbackID")] 
		public CHandle<redCallbackObject> VendorUpdatedCallbackID
		{
			get => GetProperty(ref _vendorUpdatedCallbackID);
			set => SetProperty(ref _vendorUpdatedCallbackID, value);
		}

		[Ordinal(26)] 
		[RED("weightListener")] 
		public CHandle<redCallbackObject> WeightListener
		{
			get => GetProperty(ref _weightListener);
			set => SetProperty(ref _weightListener, value);
		}

		[Ordinal(27)] 
		[RED("characterLevelListener")] 
		public CHandle<redCallbackObject> CharacterLevelListener
		{
			get => GetProperty(ref _characterLevelListener);
			set => SetProperty(ref _characterLevelListener, value);
		}

		[Ordinal(28)] 
		[RED("characterCurrentXPListener")] 
		public CHandle<redCallbackObject> CharacterCurrentXPListener
		{
			get => GetProperty(ref _characterCurrentXPListener);
			set => SetProperty(ref _characterCurrentXPListener, value);
		}

		[Ordinal(29)] 
		[RED("characterCredListener")] 
		public CHandle<redCallbackObject> CharacterCredListener
		{
			get => GetProperty(ref _characterCredListener);
			set => SetProperty(ref _characterCredListener, value);
		}

		[Ordinal(30)] 
		[RED("characterCredPointsListener")] 
		public CHandle<redCallbackObject> CharacterCredPointsListener
		{
			get => GetProperty(ref _characterCredPointsListener);
			set => SetProperty(ref _characterCredPointsListener, value);
		}

		[Ordinal(31)] 
		[RED("characterCurrentHealthListener")] 
		public CHandle<redCallbackObject> CharacterCurrentHealthListener
		{
			get => GetProperty(ref _characterCurrentHealthListener);
			set => SetProperty(ref _characterCurrentHealthListener, value);
		}

		[Ordinal(32)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(33)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(34)] 
		[RED("menuData")] 
		public CArray<MenuData> MenuData
		{
			get => GetProperty(ref _menuData);
			set => SetProperty(ref _menuData, value);
		}

		[Ordinal(35)] 
		[RED("storageDef")] 
		public CHandle<StorageBlackboardDef> StorageDef
		{
			get => GetProperty(ref _storageDef);
			set => SetProperty(ref _storageDef, value);
		}

		[Ordinal(36)] 
		[RED("storageBlackboard")] 
		public wCHandle<gameIBlackboard> StorageBlackboard
		{
			get => GetProperty(ref _storageBlackboard);
			set => SetProperty(ref _storageBlackboard, value);
		}

		public VendorHubMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
