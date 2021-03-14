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

		[Ordinal(2)] 
		[RED("itemsListContainer")] 
		public inkCompoundWidgetReference ItemsListContainer
		{
			get
			{
				if (_itemsListContainer == null)
				{
					_itemsListContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "itemsListContainer", cr2w, this);
				}
				return _itemsListContainer;
			}
			set
			{
				if (_itemsListContainer == value)
				{
					return;
				}
				_itemsListContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("titleContainer")] 
		public inkCompoundWidgetReference TitleContainer
		{
			get
			{
				if (_titleContainer == null)
				{
					_titleContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "titleContainer", cr2w, this);
				}
				return _titleContainer;
			}
			set
			{
				if (_titleContainer == value)
				{
					return;
				}
				_titleContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("upArrow")] 
		public inkWidgetReference UpArrow
		{
			get
			{
				if (_upArrow == null)
				{
					_upArrow = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "upArrow", cr2w, this);
				}
				return _upArrow;
			}
			set
			{
				if (_upArrow == value)
				{
					return;
				}
				_upArrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("downArrow")] 
		public inkWidgetReference DownArrow
		{
			get
			{
				if (_downArrow == null)
				{
					_downArrow = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "downArrow", cr2w, this);
				}
				return _downArrow;
			}
			set
			{
				if (_downArrow == value)
				{
					return;
				}
				_downArrow = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("listWrapper")] 
		public inkWidgetReference ListWrapper
		{
			get
			{
				if (_listWrapper == null)
				{
					_listWrapper = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "listWrapper", cr2w, this);
				}
				return _listWrapper;
			}
			set
			{
				if (_listWrapper == value)
				{
					return;
				}
				_listWrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("actionsListV")] 
		public inkCompoundWidgetReference ActionsListV
		{
			get
			{
				if (_actionsListV == null)
				{
					_actionsListV = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "actionsListV", cr2w, this);
				}
				return _actionsListV;
			}
			set
			{
				if (_actionsListV == value)
				{
					return;
				}
				_actionsListV = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("lockedStatusContainer")] 
		public inkWidgetReference LockedStatusContainer
		{
			get
			{
				if (_lockedStatusContainer == null)
				{
					_lockedStatusContainer = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "lockedStatusContainer", cr2w, this);
				}
				return _lockedStatusContainer;
			}
			set
			{
				if (_lockedStatusContainer == value)
				{
					return;
				}
				_lockedStatusContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("widgetsPoolList")] 
		public CArray<wCHandle<inkWidget>> WidgetsPoolList
		{
			get
			{
				if (_widgetsPoolList == null)
				{
					_widgetsPoolList = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "widgetsPoolList", cr2w, this);
				}
				return _widgetsPoolList;
			}
			set
			{
				if (_widgetsPoolList == value)
				{
					return;
				}
				_widgetsPoolList = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("requestedWidgetsPoolItems")] 
		public CInt32 RequestedWidgetsPoolItems
		{
			get
			{
				if (_requestedWidgetsPoolItems == null)
				{
					_requestedWidgetsPoolItems = (CInt32) CR2WTypeManager.Create("Int32", "requestedWidgetsPoolItems", cr2w, this);
				}
				return _requestedWidgetsPoolItems;
			}
			set
			{
				if (_requestedWidgetsPoolItems == value)
				{
					return;
				}
				_requestedWidgetsPoolItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("lootList")] 
		public CArray<wCHandle<inkWidget>> LootList
		{
			get
			{
				if (_lootList == null)
				{
					_lootList = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "lootList", cr2w, this);
				}
				return _lootList;
			}
			set
			{
				if (_lootList == value)
				{
					return;
				}
				_lootList = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("requestedItemsPoolItems")] 
		public CInt32 RequestedItemsPoolItems
		{
			get
			{
				if (_requestedItemsPoolItems == null)
				{
					_requestedItemsPoolItems = (CInt32) CR2WTypeManager.Create("Int32", "requestedItemsPoolItems", cr2w, this);
				}
				return _requestedItemsPoolItems;
			}
			set
			{
				if (_requestedItemsPoolItems == value)
				{
					return;
				}
				_requestedItemsPoolItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("dataManager")] 
		public wCHandle<InventoryDataManagerV2> DataManager
		{
			get
			{
				if (_dataManager == null)
				{
					_dataManager = (wCHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("whandle:InventoryDataManagerV2", "dataManager", cr2w, this);
				}
				return _dataManager;
			}
			set
			{
				if (_dataManager == value)
				{
					return;
				}
				_dataManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get
			{
				if (_gameInstance == null)
				{
					_gameInstance = (ScriptGameInstance) CR2WTypeManager.Create("ScriptGameInstance", "gameInstance", cr2w, this);
				}
				return _gameInstance;
			}
			set
			{
				if (_gameInstance == value)
				{
					return;
				}
				_gameInstance = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("maxItemsNum")] 
		public CInt32 MaxItemsNum
		{
			get
			{
				if (_maxItemsNum == null)
				{
					_maxItemsNum = (CInt32) CR2WTypeManager.Create("Int32", "maxItemsNum", cr2w, this);
				}
				return _maxItemsNum;
			}
			set
			{
				if (_maxItemsNum == value)
				{
					return;
				}
				_maxItemsNum = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("tooltipProvider")] 
		public wCHandle<TooltipProvider> TooltipProvider
		{
			get
			{
				if (_tooltipProvider == null)
				{
					_tooltipProvider = (wCHandle<TooltipProvider>) CR2WTypeManager.Create("whandle:TooltipProvider", "tooltipProvider", cr2w, this);
				}
				return _tooltipProvider;
			}
			set
			{
				if (_tooltipProvider == value)
				{
					return;
				}
				_tooltipProvider = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("cachedTooltipData")] 
		public CHandle<ATooltipData> CachedTooltipData
		{
			get
			{
				if (_cachedTooltipData == null)
				{
					_cachedTooltipData = (CHandle<ATooltipData>) CR2WTypeManager.Create("handle:ATooltipData", "cachedTooltipData", cr2w, this);
				}
				return _cachedTooltipData;
			}
			set
			{
				if (_cachedTooltipData == value)
				{
					return;
				}
				_cachedTooltipData = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("startIndex")] 
		public CInt32 StartIndex
		{
			get
			{
				if (_startIndex == null)
				{
					_startIndex = (CInt32) CR2WTypeManager.Create("Int32", "startIndex", cr2w, this);
				}
				return _startIndex;
			}
			set
			{
				if (_startIndex == value)
				{
					return;
				}
				_startIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("selectedItemIndex")] 
		public CInt32 SelectedItemIndex
		{
			get
			{
				if (_selectedItemIndex == null)
				{
					_selectedItemIndex = (CInt32) CR2WTypeManager.Create("Int32", "selectedItemIndex", cr2w, this);
				}
				return _selectedItemIndex;
			}
			set
			{
				if (_selectedItemIndex == value)
				{
					return;
				}
				_selectedItemIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("itemsToCompare")] 
		public CInt32 ItemsToCompare
		{
			get
			{
				if (_itemsToCompare == null)
				{
					_itemsToCompare = (CInt32) CR2WTypeManager.Create("Int32", "itemsToCompare", cr2w, this);
				}
				return _itemsToCompare;
			}
			set
			{
				if (_itemsToCompare == value)
				{
					return;
				}
				_itemsToCompare = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get
			{
				if (_isShown == null)
				{
					_isShown = (CBool) CR2WTypeManager.Create("Bool", "isShown", cr2w, this);
				}
				return _isShown;
			}
			set
			{
				if (_isShown == value)
				{
					return;
				}
				_isShown = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("lastTooltipItemId")] 
		public gameItemID LastTooltipItemId
		{
			get
			{
				if (_lastTooltipItemId == null)
				{
					_lastTooltipItemId = (gameItemID) CR2WTypeManager.Create("gameItemID", "lastTooltipItemId", cr2w, this);
				}
				return _lastTooltipItemId;
			}
			set
			{
				if (_lastTooltipItemId == value)
				{
					return;
				}
				_lastTooltipItemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("currentTooltipItemId")] 
		public gameItemID CurrentTooltipItemId
		{
			get
			{
				if (_currentTooltipItemId == null)
				{
					_currentTooltipItemId = (gameItemID) CR2WTypeManager.Create("gameItemID", "currentTooltipItemId", cr2w, this);
				}
				return _currentTooltipItemId;
			}
			set
			{
				if (_currentTooltipItemId == value)
				{
					return;
				}
				_currentTooltipItemId = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("currentTooltipLootingData")] 
		public CHandle<TooltipLootingCachedData> CurrentTooltipLootingData
		{
			get
			{
				if (_currentTooltipLootingData == null)
				{
					_currentTooltipLootingData = (CHandle<TooltipLootingCachedData>) CR2WTypeManager.Create("handle:TooltipLootingCachedData", "currentTooltipLootingData", cr2w, this);
				}
				return _currentTooltipLootingData;
			}
			set
			{
				if (_currentTooltipLootingData == value)
				{
					return;
				}
				_currentTooltipLootingData = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("lastItemOwnerId")] 
		public entEntityID LastItemOwnerId
		{
			get
			{
				if (_lastItemOwnerId == null)
				{
					_lastItemOwnerId = (entEntityID) CR2WTypeManager.Create("entEntityID", "lastItemOwnerId", cr2w, this);
				}
				return _lastItemOwnerId;
			}
			set
			{
				if (_lastItemOwnerId == value)
				{
					return;
				}
				_lastItemOwnerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("currentItemOwnerId")] 
		public entEntityID CurrentItemOwnerId
		{
			get
			{
				if (_currentItemOwnerId == null)
				{
					_currentItemOwnerId = (entEntityID) CR2WTypeManager.Create("entEntityID", "currentItemOwnerId", cr2w, this);
				}
				return _currentItemOwnerId;
			}
			set
			{
				if (_currentItemOwnerId == value)
				{
					return;
				}
				_currentItemOwnerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("lastListOpenedState")] 
		public CBool LastListOpenedState
		{
			get
			{
				if (_lastListOpenedState == null)
				{
					_lastListOpenedState = (CBool) CR2WTypeManager.Create("Bool", "lastListOpenedState", cr2w, this);
				}
				return _lastListOpenedState;
			}
			set
			{
				if (_lastListOpenedState == value)
				{
					return;
				}
				_lastListOpenedState = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("bufferedOwnerId")] 
		public entEntityID BufferedOwnerId
		{
			get
			{
				if (_bufferedOwnerId == null)
				{
					_bufferedOwnerId = (entEntityID) CR2WTypeManager.Create("entEntityID", "bufferedOwnerId", cr2w, this);
				}
				return _bufferedOwnerId;
			}
			set
			{
				if (_bufferedOwnerId == value)
				{
					return;
				}
				_bufferedOwnerId = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get
			{
				if (_introAnimProxy == null)
				{
					_introAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "introAnimProxy", cr2w, this);
				}
				return _introAnimProxy;
			}
			set
			{
				if (_introAnimProxy == value)
				{
					return;
				}
				_introAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("currendData")] 
		public gameinteractionsvisLootData CurrendData
		{
			get
			{
				if (_currendData == null)
				{
					_currendData = (gameinteractionsvisLootData) CR2WTypeManager.Create("gameinteractionsvisLootData", "currendData", cr2w, this);
				}
				return _currendData;
			}
			set
			{
				if (_currendData == value)
				{
					return;
				}
				_currendData = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("activeWeapon")] 
		public InventoryItemData ActiveWeapon
		{
			get
			{
				if (_activeWeapon == null)
				{
					_activeWeapon = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "activeWeapon", cr2w, this);
				}
				return _activeWeapon;
			}
			set
			{
				if (_activeWeapon == value)
				{
					return;
				}
				_activeWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get
			{
				if (_isLocked == null)
				{
					_isLocked = (CBool) CR2WTypeManager.Create("Bool", "isLocked", cr2w, this);
				}
				return _isLocked;
			}
			set
			{
				if (_isLocked == value)
				{
					return;
				}
				_isLocked = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("currentWidgetRequestVersion")] 
		public CInt32 CurrentWidgetRequestVersion
		{
			get
			{
				if (_currentWidgetRequestVersion == null)
				{
					_currentWidgetRequestVersion = (CInt32) CR2WTypeManager.Create("Int32", "currentWidgetRequestVersion", cr2w, this);
				}
				return _currentWidgetRequestVersion;
			}
			set
			{
				if (_currentWidgetRequestVersion == value)
				{
					return;
				}
				_currentWidgetRequestVersion = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("currentItemRequestVersion")] 
		public CInt32 CurrentItemRequestVersion
		{
			get
			{
				if (_currentItemRequestVersion == null)
				{
					_currentItemRequestVersion = (CInt32) CR2WTypeManager.Create("Int32", "currentItemRequestVersion", cr2w, this);
				}
				return _currentItemRequestVersion;
			}
			set
			{
				if (_currentItemRequestVersion == value)
				{
					return;
				}
				_currentItemRequestVersion = value;
				PropertySet(this);
			}
		}

		public LootingController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
