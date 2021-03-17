using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ArmorEquipGameController : gameuiMenuGameController
	{
		private wCHandle<inkWidget> _inventoryCanvas;
		private wCHandle<inkVerticalPanelWidget> _inventoryList;
		private CArray<wCHandle<gameItemData>> _inventory;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<EquipmentSystem> _equipmentSystem;
		private CHandle<SubCharacterSystem> _subCharacterSystem;
		private CHandle<gameTransactionSystem> _transactionSystem;
		private CHandle<CraftingSystem> _craftingSystem;
		private wCHandle<inkCanvasWidget> _buttonScrollUp;
		private wCHandle<inkCanvasWidget> _buttonScrollDn;
		private wCHandle<inkCanvasWidget> _buttonPlayer;
		private wCHandle<inkCanvasWidget> _buttonFlathead;
		private wCHandle<inkCanvasWidget> _buttonToolbox;
		private wCHandle<inkCanvasWidget> _panelPlayer;
		private wCHandle<inkCanvasWidget> _panelFlathead;
		private wCHandle<inkCanvasWidget> _panelToolbox;
		private CHandle<UI_EquipmentDef> _uiBB_Equipment;
		private CHandle<gameIBlackboard> _uiBB_EquipmentBlackboard;
		private wCHandle<inkVideoWidget> _backgroundVideo;
		private wCHandle<inkVideoWidget> _paperdollVideo;
		private CArray<CName> _areaTags;
		private CHandle<InventoryDataManager> _inventoryManager;
		private CHandle<gameIBlackboard> _vendorBlackboard;
		private CEnum<gamedataEquipmentArea> _equipArea;
		private CInt32 _slotIndex;
		private CArray<TweakDBID> _recipeItemList;
		private CHandle<CraftBook> _playerCraftBook;
		private redResourceReferenceScriptToken _tooltipsLibrary;
		private CName _itemTooltipName;
		private redResourceReferenceScriptToken _tooltipStylePath;
		private wCHandle<InventorySlotTooltip> _tooltipLeft;
		private wCHandle<InventorySlotTooltip> _tooltipRight;
		private wCHandle<inkCompoundWidget> _tooltipContainer;
		private CArray<CName> _paperDollList;
		private CInt32 _scrollOffset;
		private CArray<CName> _faceTags;
		private CArray<CName> _headTags;
		private CArray<CName> _chestTags;
		private CArray<CName> _legTags;
		private CArray<CName> _weaponTags;
		private CArray<CName> _consumableTags;
		private CArray<CName> _modulesTags;
		private CArray<CName> _framesTags;
		private CEnum<operationsMode> _operationsMode;

		[Ordinal(3)] 
		[RED("inventoryCanvas")] 
		public wCHandle<inkWidget> InventoryCanvas
		{
			get => GetProperty(ref _inventoryCanvas);
			set => SetProperty(ref _inventoryCanvas, value);
		}

		[Ordinal(4)] 
		[RED("inventoryList")] 
		public wCHandle<inkVerticalPanelWidget> InventoryList
		{
			get => GetProperty(ref _inventoryList);
			set => SetProperty(ref _inventoryList, value);
		}

		[Ordinal(5)] 
		[RED("inventory")] 
		public CArray<wCHandle<gameItemData>> Inventory
		{
			get => GetProperty(ref _inventory);
			set => SetProperty(ref _inventory, value);
		}

		[Ordinal(6)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(7)] 
		[RED("equipmentSystem")] 
		public CHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetProperty(ref _equipmentSystem);
			set => SetProperty(ref _equipmentSystem, value);
		}

		[Ordinal(8)] 
		[RED("subCharacterSystem")] 
		public CHandle<SubCharacterSystem> SubCharacterSystem
		{
			get => GetProperty(ref _subCharacterSystem);
			set => SetProperty(ref _subCharacterSystem, value);
		}

		[Ordinal(9)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(10)] 
		[RED("craftingSystem")] 
		public CHandle<CraftingSystem> CraftingSystem
		{
			get => GetProperty(ref _craftingSystem);
			set => SetProperty(ref _craftingSystem, value);
		}

		[Ordinal(11)] 
		[RED("buttonScrollUp")] 
		public wCHandle<inkCanvasWidget> ButtonScrollUp
		{
			get => GetProperty(ref _buttonScrollUp);
			set => SetProperty(ref _buttonScrollUp, value);
		}

		[Ordinal(12)] 
		[RED("buttonScrollDn")] 
		public wCHandle<inkCanvasWidget> ButtonScrollDn
		{
			get => GetProperty(ref _buttonScrollDn);
			set => SetProperty(ref _buttonScrollDn, value);
		}

		[Ordinal(13)] 
		[RED("buttonPlayer")] 
		public wCHandle<inkCanvasWidget> ButtonPlayer
		{
			get => GetProperty(ref _buttonPlayer);
			set => SetProperty(ref _buttonPlayer, value);
		}

		[Ordinal(14)] 
		[RED("buttonFlathead")] 
		public wCHandle<inkCanvasWidget> ButtonFlathead
		{
			get => GetProperty(ref _buttonFlathead);
			set => SetProperty(ref _buttonFlathead, value);
		}

		[Ordinal(15)] 
		[RED("buttonToolbox")] 
		public wCHandle<inkCanvasWidget> ButtonToolbox
		{
			get => GetProperty(ref _buttonToolbox);
			set => SetProperty(ref _buttonToolbox, value);
		}

		[Ordinal(16)] 
		[RED("panelPlayer")] 
		public wCHandle<inkCanvasWidget> PanelPlayer
		{
			get => GetProperty(ref _panelPlayer);
			set => SetProperty(ref _panelPlayer, value);
		}

		[Ordinal(17)] 
		[RED("panelFlathead")] 
		public wCHandle<inkCanvasWidget> PanelFlathead
		{
			get => GetProperty(ref _panelFlathead);
			set => SetProperty(ref _panelFlathead, value);
		}

		[Ordinal(18)] 
		[RED("panelToolbox")] 
		public wCHandle<inkCanvasWidget> PanelToolbox
		{
			get => GetProperty(ref _panelToolbox);
			set => SetProperty(ref _panelToolbox, value);
		}

		[Ordinal(19)] 
		[RED("uiBB_Equipment")] 
		public CHandle<UI_EquipmentDef> UiBB_Equipment
		{
			get => GetProperty(ref _uiBB_Equipment);
			set => SetProperty(ref _uiBB_Equipment, value);
		}

		[Ordinal(20)] 
		[RED("uiBB_EquipmentBlackboard")] 
		public CHandle<gameIBlackboard> UiBB_EquipmentBlackboard
		{
			get => GetProperty(ref _uiBB_EquipmentBlackboard);
			set => SetProperty(ref _uiBB_EquipmentBlackboard, value);
		}

		[Ordinal(21)] 
		[RED("backgroundVideo")] 
		public wCHandle<inkVideoWidget> BackgroundVideo
		{
			get => GetProperty(ref _backgroundVideo);
			set => SetProperty(ref _backgroundVideo, value);
		}

		[Ordinal(22)] 
		[RED("paperdollVideo")] 
		public wCHandle<inkVideoWidget> PaperdollVideo
		{
			get => GetProperty(ref _paperdollVideo);
			set => SetProperty(ref _paperdollVideo, value);
		}

		[Ordinal(23)] 
		[RED("areaTags")] 
		public CArray<CName> AreaTags
		{
			get => GetProperty(ref _areaTags);
			set => SetProperty(ref _areaTags, value);
		}

		[Ordinal(24)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManager> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(25)] 
		[RED("vendorBlackboard")] 
		public CHandle<gameIBlackboard> VendorBlackboard
		{
			get => GetProperty(ref _vendorBlackboard);
			set => SetProperty(ref _vendorBlackboard, value);
		}

		[Ordinal(26)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get => GetProperty(ref _equipArea);
			set => SetProperty(ref _equipArea, value);
		}

		[Ordinal(27)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetProperty(ref _slotIndex);
			set => SetProperty(ref _slotIndex, value);
		}

		[Ordinal(28)] 
		[RED("recipeItemList")] 
		public CArray<TweakDBID> RecipeItemList
		{
			get => GetProperty(ref _recipeItemList);
			set => SetProperty(ref _recipeItemList, value);
		}

		[Ordinal(29)] 
		[RED("playerCraftBook")] 
		public CHandle<CraftBook> PlayerCraftBook
		{
			get => GetProperty(ref _playerCraftBook);
			set => SetProperty(ref _playerCraftBook, value);
		}

		[Ordinal(30)] 
		[RED("tooltipsLibrary")] 
		public redResourceReferenceScriptToken TooltipsLibrary
		{
			get => GetProperty(ref _tooltipsLibrary);
			set => SetProperty(ref _tooltipsLibrary, value);
		}

		[Ordinal(31)] 
		[RED("itemTooltipName")] 
		public CName ItemTooltipName
		{
			get => GetProperty(ref _itemTooltipName);
			set => SetProperty(ref _itemTooltipName, value);
		}

		[Ordinal(32)] 
		[RED("tooltipStylePath")] 
		public redResourceReferenceScriptToken TooltipStylePath
		{
			get => GetProperty(ref _tooltipStylePath);
			set => SetProperty(ref _tooltipStylePath, value);
		}

		[Ordinal(33)] 
		[RED("tooltipLeft")] 
		public wCHandle<InventorySlotTooltip> TooltipLeft
		{
			get => GetProperty(ref _tooltipLeft);
			set => SetProperty(ref _tooltipLeft, value);
		}

		[Ordinal(34)] 
		[RED("tooltipRight")] 
		public wCHandle<InventorySlotTooltip> TooltipRight
		{
			get => GetProperty(ref _tooltipRight);
			set => SetProperty(ref _tooltipRight, value);
		}

		[Ordinal(35)] 
		[RED("tooltipContainer")] 
		public wCHandle<inkCompoundWidget> TooltipContainer
		{
			get => GetProperty(ref _tooltipContainer);
			set => SetProperty(ref _tooltipContainer, value);
		}

		[Ordinal(36)] 
		[RED("paperDollList")] 
		public CArray<CName> PaperDollList
		{
			get => GetProperty(ref _paperDollList);
			set => SetProperty(ref _paperDollList, value);
		}

		[Ordinal(37)] 
		[RED("scrollOffset")] 
		public CInt32 ScrollOffset
		{
			get => GetProperty(ref _scrollOffset);
			set => SetProperty(ref _scrollOffset, value);
		}

		[Ordinal(38)] 
		[RED("faceTags")] 
		public CArray<CName> FaceTags
		{
			get => GetProperty(ref _faceTags);
			set => SetProperty(ref _faceTags, value);
		}

		[Ordinal(39)] 
		[RED("headTags")] 
		public CArray<CName> HeadTags
		{
			get => GetProperty(ref _headTags);
			set => SetProperty(ref _headTags, value);
		}

		[Ordinal(40)] 
		[RED("chestTags")] 
		public CArray<CName> ChestTags
		{
			get => GetProperty(ref _chestTags);
			set => SetProperty(ref _chestTags, value);
		}

		[Ordinal(41)] 
		[RED("legTags")] 
		public CArray<CName> LegTags
		{
			get => GetProperty(ref _legTags);
			set => SetProperty(ref _legTags, value);
		}

		[Ordinal(42)] 
		[RED("weaponTags")] 
		public CArray<CName> WeaponTags
		{
			get => GetProperty(ref _weaponTags);
			set => SetProperty(ref _weaponTags, value);
		}

		[Ordinal(43)] 
		[RED("consumableTags")] 
		public CArray<CName> ConsumableTags
		{
			get => GetProperty(ref _consumableTags);
			set => SetProperty(ref _consumableTags, value);
		}

		[Ordinal(44)] 
		[RED("modulesTags")] 
		public CArray<CName> ModulesTags
		{
			get => GetProperty(ref _modulesTags);
			set => SetProperty(ref _modulesTags, value);
		}

		[Ordinal(45)] 
		[RED("framesTags")] 
		public CArray<CName> FramesTags
		{
			get => GetProperty(ref _framesTags);
			set => SetProperty(ref _framesTags, value);
		}

		[Ordinal(46)] 
		[RED("operationsMode")] 
		public CEnum<operationsMode> OperationsMode
		{
			get => GetProperty(ref _operationsMode);
			set => SetProperty(ref _operationsMode, value);
		}

		public ArmorEquipGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
