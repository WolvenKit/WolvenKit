using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LootingController : inkWidgetLogicController
	{
		private wCHandle<inkWidget> _root;
		private inkCompoundWidgetReference _itemsListContainer;
		private inkCompoundWidgetReference _titleContainer;
		private inkWidgetReference _upArrow;
		private inkWidgetReference _downArrow;
		private inkWidgetReference _listWrapper;
		private inkCompoundWidgetReference _actionsListV;
		private inkWidgetReference _lockedStatusContainer;
		private CArray<wCHandle<inkWidget>> _widgetsPoolList;
		private CInt32 _requestedWidgetsPoolItems;
		private CArray<wCHandle<inkWidget>> _lootList;
		private CInt32 _requestedItemsPoolItems;
		private wCHandle<InventoryDataManagerV2> _dataManager;
		private ScriptGameInstance _gameInstance;
		private CInt32 _maxItemsNum;
		private wCHandle<TooltipProvider> _tooltipProvider;
		private CHandle<ATooltipData> _cachedTooltipData;
		private CInt32 _startIndex;
		private CInt32 _selectedItemIndex;
		private CInt32 _itemsToCompare;
		private CBool _isShown;
		private gameItemID _lastTooltipItemId;
		private gameItemID _currentTooltipItemId;
		private CHandle<TooltipLootingCachedData> _currentTooltipLootingData;
		private entEntityID _lastItemOwnerId;
		private entEntityID _currentItemOwnerId;
		private CBool _lastListOpenedState;
		private entEntityID _bufferedOwnerId;
		private CHandle<inkanimProxy> _introAnimProxy;
		private gameinteractionsvisLootData _currendData;
		private InventoryItemData _activeWeapon;
		private CBool _isLocked;
		private CInt32 _currentWidgetRequestVersion;
		private CInt32 _currentItemRequestVersion;

		[Ordinal(1)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(2)] 
		[RED("itemsListContainer")] 
		public inkCompoundWidgetReference ItemsListContainer
		{
			get => GetProperty(ref _itemsListContainer);
			set => SetProperty(ref _itemsListContainer, value);
		}

		[Ordinal(3)] 
		[RED("titleContainer")] 
		public inkCompoundWidgetReference TitleContainer
		{
			get => GetProperty(ref _titleContainer);
			set => SetProperty(ref _titleContainer, value);
		}

		[Ordinal(4)] 
		[RED("upArrow")] 
		public inkWidgetReference UpArrow
		{
			get => GetProperty(ref _upArrow);
			set => SetProperty(ref _upArrow, value);
		}

		[Ordinal(5)] 
		[RED("downArrow")] 
		public inkWidgetReference DownArrow
		{
			get => GetProperty(ref _downArrow);
			set => SetProperty(ref _downArrow, value);
		}

		[Ordinal(6)] 
		[RED("listWrapper")] 
		public inkWidgetReference ListWrapper
		{
			get => GetProperty(ref _listWrapper);
			set => SetProperty(ref _listWrapper, value);
		}

		[Ordinal(7)] 
		[RED("actionsListV")] 
		public inkCompoundWidgetReference ActionsListV
		{
			get => GetProperty(ref _actionsListV);
			set => SetProperty(ref _actionsListV, value);
		}

		[Ordinal(8)] 
		[RED("lockedStatusContainer")] 
		public inkWidgetReference LockedStatusContainer
		{
			get => GetProperty(ref _lockedStatusContainer);
			set => SetProperty(ref _lockedStatusContainer, value);
		}

		[Ordinal(9)] 
		[RED("widgetsPoolList")] 
		public CArray<wCHandle<inkWidget>> WidgetsPoolList
		{
			get => GetProperty(ref _widgetsPoolList);
			set => SetProperty(ref _widgetsPoolList, value);
		}

		[Ordinal(10)] 
		[RED("requestedWidgetsPoolItems")] 
		public CInt32 RequestedWidgetsPoolItems
		{
			get => GetProperty(ref _requestedWidgetsPoolItems);
			set => SetProperty(ref _requestedWidgetsPoolItems, value);
		}

		[Ordinal(11)] 
		[RED("lootList")] 
		public CArray<wCHandle<inkWidget>> LootList
		{
			get => GetProperty(ref _lootList);
			set => SetProperty(ref _lootList, value);
		}

		[Ordinal(12)] 
		[RED("requestedItemsPoolItems")] 
		public CInt32 RequestedItemsPoolItems
		{
			get => GetProperty(ref _requestedItemsPoolItems);
			set => SetProperty(ref _requestedItemsPoolItems, value);
		}

		[Ordinal(13)] 
		[RED("dataManager")] 
		public wCHandle<InventoryDataManagerV2> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(14)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(15)] 
		[RED("maxItemsNum")] 
		public CInt32 MaxItemsNum
		{
			get => GetProperty(ref _maxItemsNum);
			set => SetProperty(ref _maxItemsNum, value);
		}

		[Ordinal(16)] 
		[RED("tooltipProvider")] 
		public wCHandle<TooltipProvider> TooltipProvider
		{
			get => GetProperty(ref _tooltipProvider);
			set => SetProperty(ref _tooltipProvider, value);
		}

		[Ordinal(17)] 
		[RED("cachedTooltipData")] 
		public CHandle<ATooltipData> CachedTooltipData
		{
			get => GetProperty(ref _cachedTooltipData);
			set => SetProperty(ref _cachedTooltipData, value);
		}

		[Ordinal(18)] 
		[RED("startIndex")] 
		public CInt32 StartIndex
		{
			get => GetProperty(ref _startIndex);
			set => SetProperty(ref _startIndex, value);
		}

		[Ordinal(19)] 
		[RED("selectedItemIndex")] 
		public CInt32 SelectedItemIndex
		{
			get => GetProperty(ref _selectedItemIndex);
			set => SetProperty(ref _selectedItemIndex, value);
		}

		[Ordinal(20)] 
		[RED("itemsToCompare")] 
		public CInt32 ItemsToCompare
		{
			get => GetProperty(ref _itemsToCompare);
			set => SetProperty(ref _itemsToCompare, value);
		}

		[Ordinal(21)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get => GetProperty(ref _isShown);
			set => SetProperty(ref _isShown, value);
		}

		[Ordinal(22)] 
		[RED("lastTooltipItemId")] 
		public gameItemID LastTooltipItemId
		{
			get => GetProperty(ref _lastTooltipItemId);
			set => SetProperty(ref _lastTooltipItemId, value);
		}

		[Ordinal(23)] 
		[RED("currentTooltipItemId")] 
		public gameItemID CurrentTooltipItemId
		{
			get => GetProperty(ref _currentTooltipItemId);
			set => SetProperty(ref _currentTooltipItemId, value);
		}

		[Ordinal(24)] 
		[RED("currentTooltipLootingData")] 
		public CHandle<TooltipLootingCachedData> CurrentTooltipLootingData
		{
			get => GetProperty(ref _currentTooltipLootingData);
			set => SetProperty(ref _currentTooltipLootingData, value);
		}

		[Ordinal(25)] 
		[RED("lastItemOwnerId")] 
		public entEntityID LastItemOwnerId
		{
			get => GetProperty(ref _lastItemOwnerId);
			set => SetProperty(ref _lastItemOwnerId, value);
		}

		[Ordinal(26)] 
		[RED("currentItemOwnerId")] 
		public entEntityID CurrentItemOwnerId
		{
			get => GetProperty(ref _currentItemOwnerId);
			set => SetProperty(ref _currentItemOwnerId, value);
		}

		[Ordinal(27)] 
		[RED("lastListOpenedState")] 
		public CBool LastListOpenedState
		{
			get => GetProperty(ref _lastListOpenedState);
			set => SetProperty(ref _lastListOpenedState, value);
		}

		[Ordinal(28)] 
		[RED("bufferedOwnerId")] 
		public entEntityID BufferedOwnerId
		{
			get => GetProperty(ref _bufferedOwnerId);
			set => SetProperty(ref _bufferedOwnerId, value);
		}

		[Ordinal(29)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetProperty(ref _introAnimProxy);
			set => SetProperty(ref _introAnimProxy, value);
		}

		[Ordinal(30)] 
		[RED("currendData")] 
		public gameinteractionsvisLootData CurrendData
		{
			get => GetProperty(ref _currendData);
			set => SetProperty(ref _currendData, value);
		}

		[Ordinal(31)] 
		[RED("activeWeapon")] 
		public InventoryItemData ActiveWeapon
		{
			get => GetProperty(ref _activeWeapon);
			set => SetProperty(ref _activeWeapon, value);
		}

		[Ordinal(32)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(33)] 
		[RED("currentWidgetRequestVersion")] 
		public CInt32 CurrentWidgetRequestVersion
		{
			get => GetProperty(ref _currentWidgetRequestVersion);
			set => SetProperty(ref _currentWidgetRequestVersion, value);
		}

		[Ordinal(34)] 
		[RED("currentItemRequestVersion")] 
		public CInt32 CurrentItemRequestVersion
		{
			get => GetProperty(ref _currentItemRequestVersion);
			set => SetProperty(ref _currentItemRequestVersion, value);
		}

		public LootingController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
