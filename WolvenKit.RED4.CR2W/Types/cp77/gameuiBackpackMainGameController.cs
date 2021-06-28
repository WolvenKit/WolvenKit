using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBackpackMainGameController : gameuiMenuGameController
	{
		private inkCompoundWidgetReference _commonCraftingMaterialsGrid;
		private inkCompoundWidgetReference _hackingCraftingMaterialsGrid;
		private inkCompoundWidgetReference _filterButtonsGrid;
		private inkVirtualCompoundWidgetReference _virtualItemsGrid;
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _sortingButton;
		private inkWidgetReference _sortingDropdown;
		private inkWidgetReference _itemsListScrollAreaContainer;
		private inkWidgetReference _itemNotificationRoot;
		private wCHandle<inkGridController> _virtualBackpackItemsListController;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CArray<CEnum<gamedataItemType>> _itemTypeSorting;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<PlayerPuppet> _player;
		private CArray<gameItemModParams> _itemDropQueue;
		private CArray<CHandle<CrafringMaterialItemController>> _craftingMaterialsListItems;
		private CHandle<UI_CraftingDef> _disassembleCallback;
		private CHandle<gameIBlackboard> _disassembleBlackboard;
		private CUInt32 _disassembleBBID;
		private CHandle<UI_EquipmentDef> _equippedCallback;
		private CHandle<gameIBlackboard> _equippedBlackboard;
		private CUInt32 _equippedBBID;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<BackpackFilterButtonController> _activeFilter;
		private CHandle<inkScriptableDataSourceWrapper> _backpackItemsDataSource;
		private CHandle<BackpackDataView> _backpackItemsDataView;
		private CHandle<ItemPreferredComparisonResolver> _comparisonResolver;
		private CHandle<BackpackInventoryListenerCallback> _backpackInventoryListenerCallback;
		private CHandle<gameInventoryScriptListener> _backpackInventoryListener;
		private CHandle<ItemDisplayTemplateClassifier> _backpackItemsClassifier;
		private CHandle<ItemPositionProvider> _backpackItemsPositionProvider;
		private CHandle<inkGameNotificationToken> _equipSlotChooserPopupToken;
		private CHandle<inkGameNotificationToken> _quantityPickerPopupToken;
		private CBool _isE3Demo;
		private CBool _equipRequested;
		private wCHandle<gameIBlackboard> _psmBlackboard;
		private CEnum<gamePSMVehicle> _playerState;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private CHandle<inkGameNotificationToken> _confirmationPopupToken;
		private CHandle<ItemDisplayHoverOverEvent> _lastItemHoverOverEvent;
		private CBool _isComparisionDisabled;
		private CHandle<inkGameNotificationToken> _itemPreviewPopupToken;
		private CBool _afterCloseRequest;

		[Ordinal(3)] 
		[RED("commonCraftingMaterialsGrid")] 
		public inkCompoundWidgetReference CommonCraftingMaterialsGrid
		{
			get => GetProperty(ref _commonCraftingMaterialsGrid);
			set => SetProperty(ref _commonCraftingMaterialsGrid, value);
		}

		[Ordinal(4)] 
		[RED("hackingCraftingMaterialsGrid")] 
		public inkCompoundWidgetReference HackingCraftingMaterialsGrid
		{
			get => GetProperty(ref _hackingCraftingMaterialsGrid);
			set => SetProperty(ref _hackingCraftingMaterialsGrid, value);
		}

		[Ordinal(5)] 
		[RED("filterButtonsGrid")] 
		public inkCompoundWidgetReference FilterButtonsGrid
		{
			get => GetProperty(ref _filterButtonsGrid);
			set => SetProperty(ref _filterButtonsGrid, value);
		}

		[Ordinal(6)] 
		[RED("virtualItemsGrid")] 
		public inkVirtualCompoundWidgetReference VirtualItemsGrid
		{
			get => GetProperty(ref _virtualItemsGrid);
			set => SetProperty(ref _virtualItemsGrid, value);
		}

		[Ordinal(7)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(8)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(9)] 
		[RED("sortingButton")] 
		public inkWidgetReference SortingButton
		{
			get => GetProperty(ref _sortingButton);
			set => SetProperty(ref _sortingButton, value);
		}

		[Ordinal(10)] 
		[RED("sortingDropdown")] 
		public inkWidgetReference SortingDropdown
		{
			get => GetProperty(ref _sortingDropdown);
			set => SetProperty(ref _sortingDropdown, value);
		}

		[Ordinal(11)] 
		[RED("itemsListScrollAreaContainer")] 
		public inkWidgetReference ItemsListScrollAreaContainer
		{
			get => GetProperty(ref _itemsListScrollAreaContainer);
			set => SetProperty(ref _itemsListScrollAreaContainer, value);
		}

		[Ordinal(12)] 
		[RED("itemNotificationRoot")] 
		public inkWidgetReference ItemNotificationRoot
		{
			get => GetProperty(ref _itemNotificationRoot);
			set => SetProperty(ref _itemNotificationRoot, value);
		}

		[Ordinal(13)] 
		[RED("virtualBackpackItemsListController")] 
		public wCHandle<inkGridController> VirtualBackpackItemsListController
		{
			get => GetProperty(ref _virtualBackpackItemsListController);
			set => SetProperty(ref _virtualBackpackItemsListController, value);
		}

		[Ordinal(14)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(15)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(16)] 
		[RED("itemTypeSorting")] 
		public CArray<CEnum<gamedataItemType>> ItemTypeSorting
		{
			get => GetProperty(ref _itemTypeSorting);
			set => SetProperty(ref _itemTypeSorting, value);
		}

		[Ordinal(17)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(18)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(19)] 
		[RED("itemDropQueue")] 
		public CArray<gameItemModParams> ItemDropQueue
		{
			get => GetProperty(ref _itemDropQueue);
			set => SetProperty(ref _itemDropQueue, value);
		}

		[Ordinal(20)] 
		[RED("craftingMaterialsListItems")] 
		public CArray<CHandle<CrafringMaterialItemController>> CraftingMaterialsListItems
		{
			get => GetProperty(ref _craftingMaterialsListItems);
			set => SetProperty(ref _craftingMaterialsListItems, value);
		}

		[Ordinal(21)] 
		[RED("DisassembleCallback")] 
		public CHandle<UI_CraftingDef> DisassembleCallback
		{
			get => GetProperty(ref _disassembleCallback);
			set => SetProperty(ref _disassembleCallback, value);
		}

		[Ordinal(22)] 
		[RED("DisassembleBlackboard")] 
		public CHandle<gameIBlackboard> DisassembleBlackboard
		{
			get => GetProperty(ref _disassembleBlackboard);
			set => SetProperty(ref _disassembleBlackboard, value);
		}

		[Ordinal(23)] 
		[RED("DisassembleBBID")] 
		public CUInt32 DisassembleBBID
		{
			get => GetProperty(ref _disassembleBBID);
			set => SetProperty(ref _disassembleBBID, value);
		}

		[Ordinal(24)] 
		[RED("EquippedCallback")] 
		public CHandle<UI_EquipmentDef> EquippedCallback
		{
			get => GetProperty(ref _equippedCallback);
			set => SetProperty(ref _equippedCallback, value);
		}

		[Ordinal(25)] 
		[RED("EquippedBlackboard")] 
		public CHandle<gameIBlackboard> EquippedBlackboard
		{
			get => GetProperty(ref _equippedBlackboard);
			set => SetProperty(ref _equippedBlackboard, value);
		}

		[Ordinal(26)] 
		[RED("EquippedBBID")] 
		public CUInt32 EquippedBBID
		{
			get => GetProperty(ref _equippedBBID);
			set => SetProperty(ref _equippedBBID, value);
		}

		[Ordinal(27)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(28)] 
		[RED("activeFilter")] 
		public CHandle<BackpackFilterButtonController> ActiveFilter
		{
			get => GetProperty(ref _activeFilter);
			set => SetProperty(ref _activeFilter, value);
		}

		[Ordinal(29)] 
		[RED("backpackItemsDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> BackpackItemsDataSource
		{
			get => GetProperty(ref _backpackItemsDataSource);
			set => SetProperty(ref _backpackItemsDataSource, value);
		}

		[Ordinal(30)] 
		[RED("backpackItemsDataView")] 
		public CHandle<BackpackDataView> BackpackItemsDataView
		{
			get => GetProperty(ref _backpackItemsDataView);
			set => SetProperty(ref _backpackItemsDataView, value);
		}

		[Ordinal(31)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetProperty(ref _comparisonResolver);
			set => SetProperty(ref _comparisonResolver, value);
		}

		[Ordinal(32)] 
		[RED("backpackInventoryListenerCallback")] 
		public CHandle<BackpackInventoryListenerCallback> BackpackInventoryListenerCallback
		{
			get => GetProperty(ref _backpackInventoryListenerCallback);
			set => SetProperty(ref _backpackInventoryListenerCallback, value);
		}

		[Ordinal(33)] 
		[RED("backpackInventoryListener")] 
		public CHandle<gameInventoryScriptListener> BackpackInventoryListener
		{
			get => GetProperty(ref _backpackInventoryListener);
			set => SetProperty(ref _backpackInventoryListener, value);
		}

		[Ordinal(34)] 
		[RED("backpackItemsClassifier")] 
		public CHandle<ItemDisplayTemplateClassifier> BackpackItemsClassifier
		{
			get => GetProperty(ref _backpackItemsClassifier);
			set => SetProperty(ref _backpackItemsClassifier, value);
		}

		[Ordinal(35)] 
		[RED("backpackItemsPositionProvider")] 
		public CHandle<ItemPositionProvider> BackpackItemsPositionProvider
		{
			get => GetProperty(ref _backpackItemsPositionProvider);
			set => SetProperty(ref _backpackItemsPositionProvider, value);
		}

		[Ordinal(36)] 
		[RED("equipSlotChooserPopupToken")] 
		public CHandle<inkGameNotificationToken> EquipSlotChooserPopupToken
		{
			get => GetProperty(ref _equipSlotChooserPopupToken);
			set => SetProperty(ref _equipSlotChooserPopupToken, value);
		}

		[Ordinal(37)] 
		[RED("quantityPickerPopupToken")] 
		public CHandle<inkGameNotificationToken> QuantityPickerPopupToken
		{
			get => GetProperty(ref _quantityPickerPopupToken);
			set => SetProperty(ref _quantityPickerPopupToken, value);
		}

		[Ordinal(38)] 
		[RED("isE3Demo")] 
		public CBool IsE3Demo
		{
			get => GetProperty(ref _isE3Demo);
			set => SetProperty(ref _isE3Demo, value);
		}

		[Ordinal(39)] 
		[RED("equipRequested")] 
		public CBool EquipRequested
		{
			get => GetProperty(ref _equipRequested);
			set => SetProperty(ref _equipRequested, value);
		}

		[Ordinal(40)] 
		[RED("psmBlackboard")] 
		public wCHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(41)] 
		[RED("playerState")] 
		public CEnum<gamePSMVehicle> PlayerState
		{
			get => GetProperty(ref _playerState);
			set => SetProperty(ref _playerState, value);
		}

		[Ordinal(42)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(43)] 
		[RED("confirmationPopupToken")] 
		public CHandle<inkGameNotificationToken> ConfirmationPopupToken
		{
			get => GetProperty(ref _confirmationPopupToken);
			set => SetProperty(ref _confirmationPopupToken, value);
		}

		[Ordinal(44)] 
		[RED("lastItemHoverOverEvent")] 
		public CHandle<ItemDisplayHoverOverEvent> LastItemHoverOverEvent
		{
			get => GetProperty(ref _lastItemHoverOverEvent);
			set => SetProperty(ref _lastItemHoverOverEvent, value);
		}

		[Ordinal(45)] 
		[RED("isComparisionDisabled")] 
		public CBool IsComparisionDisabled
		{
			get => GetProperty(ref _isComparisionDisabled);
			set => SetProperty(ref _isComparisionDisabled, value);
		}

		[Ordinal(46)] 
		[RED("itemPreviewPopupToken")] 
		public CHandle<inkGameNotificationToken> ItemPreviewPopupToken
		{
			get => GetProperty(ref _itemPreviewPopupToken);
			set => SetProperty(ref _itemPreviewPopupToken, value);
		}

		[Ordinal(47)] 
		[RED("afterCloseRequest")] 
		public CBool AfterCloseRequest
		{
			get => GetProperty(ref _afterCloseRequest);
			set => SetProperty(ref _afterCloseRequest, value);
		}

		public gameuiBackpackMainGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
