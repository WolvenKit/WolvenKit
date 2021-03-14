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
			get
			{
				if (_inventoryCanvas == null)
				{
					_inventoryCanvas = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "inventoryCanvas", cr2w, this);
				}
				return _inventoryCanvas;
			}
			set
			{
				if (_inventoryCanvas == value)
				{
					return;
				}
				_inventoryCanvas = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("inventoryList")] 
		public wCHandle<inkVerticalPanelWidget> InventoryList
		{
			get
			{
				if (_inventoryList == null)
				{
					_inventoryList = (wCHandle<inkVerticalPanelWidget>) CR2WTypeManager.Create("whandle:inkVerticalPanelWidget", "inventoryList", cr2w, this);
				}
				return _inventoryList;
			}
			set
			{
				if (_inventoryList == value)
				{
					return;
				}
				_inventoryList = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("inventory")] 
		public CArray<wCHandle<gameItemData>> Inventory
		{
			get
			{
				if (_inventory == null)
				{
					_inventory = (CArray<wCHandle<gameItemData>>) CR2WTypeManager.Create("array:whandle:gameItemData", "inventory", cr2w, this);
				}
				return _inventory;
			}
			set
			{
				if (_inventory == value)
				{
					return;
				}
				_inventory = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("equipmentSystem")] 
		public CHandle<EquipmentSystem> EquipmentSystem
		{
			get
			{
				if (_equipmentSystem == null)
				{
					_equipmentSystem = (CHandle<EquipmentSystem>) CR2WTypeManager.Create("handle:EquipmentSystem", "equipmentSystem", cr2w, this);
				}
				return _equipmentSystem;
			}
			set
			{
				if (_equipmentSystem == value)
				{
					return;
				}
				_equipmentSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("subCharacterSystem")] 
		public CHandle<SubCharacterSystem> SubCharacterSystem
		{
			get
			{
				if (_subCharacterSystem == null)
				{
					_subCharacterSystem = (CHandle<SubCharacterSystem>) CR2WTypeManager.Create("handle:SubCharacterSystem", "subCharacterSystem", cr2w, this);
				}
				return _subCharacterSystem;
			}
			set
			{
				if (_subCharacterSystem == value)
				{
					return;
				}
				_subCharacterSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get
			{
				if (_transactionSystem == null)
				{
					_transactionSystem = (CHandle<gameTransactionSystem>) CR2WTypeManager.Create("handle:gameTransactionSystem", "transactionSystem", cr2w, this);
				}
				return _transactionSystem;
			}
			set
			{
				if (_transactionSystem == value)
				{
					return;
				}
				_transactionSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("craftingSystem")] 
		public CHandle<CraftingSystem> CraftingSystem
		{
			get
			{
				if (_craftingSystem == null)
				{
					_craftingSystem = (CHandle<CraftingSystem>) CR2WTypeManager.Create("handle:CraftingSystem", "craftingSystem", cr2w, this);
				}
				return _craftingSystem;
			}
			set
			{
				if (_craftingSystem == value)
				{
					return;
				}
				_craftingSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("buttonScrollUp")] 
		public wCHandle<inkCanvasWidget> ButtonScrollUp
		{
			get
			{
				if (_buttonScrollUp == null)
				{
					_buttonScrollUp = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "buttonScrollUp", cr2w, this);
				}
				return _buttonScrollUp;
			}
			set
			{
				if (_buttonScrollUp == value)
				{
					return;
				}
				_buttonScrollUp = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("buttonScrollDn")] 
		public wCHandle<inkCanvasWidget> ButtonScrollDn
		{
			get
			{
				if (_buttonScrollDn == null)
				{
					_buttonScrollDn = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "buttonScrollDn", cr2w, this);
				}
				return _buttonScrollDn;
			}
			set
			{
				if (_buttonScrollDn == value)
				{
					return;
				}
				_buttonScrollDn = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("buttonPlayer")] 
		public wCHandle<inkCanvasWidget> ButtonPlayer
		{
			get
			{
				if (_buttonPlayer == null)
				{
					_buttonPlayer = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "buttonPlayer", cr2w, this);
				}
				return _buttonPlayer;
			}
			set
			{
				if (_buttonPlayer == value)
				{
					return;
				}
				_buttonPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("buttonFlathead")] 
		public wCHandle<inkCanvasWidget> ButtonFlathead
		{
			get
			{
				if (_buttonFlathead == null)
				{
					_buttonFlathead = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "buttonFlathead", cr2w, this);
				}
				return _buttonFlathead;
			}
			set
			{
				if (_buttonFlathead == value)
				{
					return;
				}
				_buttonFlathead = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("buttonToolbox")] 
		public wCHandle<inkCanvasWidget> ButtonToolbox
		{
			get
			{
				if (_buttonToolbox == null)
				{
					_buttonToolbox = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "buttonToolbox", cr2w, this);
				}
				return _buttonToolbox;
			}
			set
			{
				if (_buttonToolbox == value)
				{
					return;
				}
				_buttonToolbox = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("panelPlayer")] 
		public wCHandle<inkCanvasWidget> PanelPlayer
		{
			get
			{
				if (_panelPlayer == null)
				{
					_panelPlayer = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "panelPlayer", cr2w, this);
				}
				return _panelPlayer;
			}
			set
			{
				if (_panelPlayer == value)
				{
					return;
				}
				_panelPlayer = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("panelFlathead")] 
		public wCHandle<inkCanvasWidget> PanelFlathead
		{
			get
			{
				if (_panelFlathead == null)
				{
					_panelFlathead = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "panelFlathead", cr2w, this);
				}
				return _panelFlathead;
			}
			set
			{
				if (_panelFlathead == value)
				{
					return;
				}
				_panelFlathead = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("panelToolbox")] 
		public wCHandle<inkCanvasWidget> PanelToolbox
		{
			get
			{
				if (_panelToolbox == null)
				{
					_panelToolbox = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "panelToolbox", cr2w, this);
				}
				return _panelToolbox;
			}
			set
			{
				if (_panelToolbox == value)
				{
					return;
				}
				_panelToolbox = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("uiBB_Equipment")] 
		public CHandle<UI_EquipmentDef> UiBB_Equipment
		{
			get
			{
				if (_uiBB_Equipment == null)
				{
					_uiBB_Equipment = (CHandle<UI_EquipmentDef>) CR2WTypeManager.Create("handle:UI_EquipmentDef", "uiBB_Equipment", cr2w, this);
				}
				return _uiBB_Equipment;
			}
			set
			{
				if (_uiBB_Equipment == value)
				{
					return;
				}
				_uiBB_Equipment = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("uiBB_EquipmentBlackboard")] 
		public CHandle<gameIBlackboard> UiBB_EquipmentBlackboard
		{
			get
			{
				if (_uiBB_EquipmentBlackboard == null)
				{
					_uiBB_EquipmentBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "uiBB_EquipmentBlackboard", cr2w, this);
				}
				return _uiBB_EquipmentBlackboard;
			}
			set
			{
				if (_uiBB_EquipmentBlackboard == value)
				{
					return;
				}
				_uiBB_EquipmentBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("backgroundVideo")] 
		public wCHandle<inkVideoWidget> BackgroundVideo
		{
			get
			{
				if (_backgroundVideo == null)
				{
					_backgroundVideo = (wCHandle<inkVideoWidget>) CR2WTypeManager.Create("whandle:inkVideoWidget", "backgroundVideo", cr2w, this);
				}
				return _backgroundVideo;
			}
			set
			{
				if (_backgroundVideo == value)
				{
					return;
				}
				_backgroundVideo = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("paperdollVideo")] 
		public wCHandle<inkVideoWidget> PaperdollVideo
		{
			get
			{
				if (_paperdollVideo == null)
				{
					_paperdollVideo = (wCHandle<inkVideoWidget>) CR2WTypeManager.Create("whandle:inkVideoWidget", "paperdollVideo", cr2w, this);
				}
				return _paperdollVideo;
			}
			set
			{
				if (_paperdollVideo == value)
				{
					return;
				}
				_paperdollVideo = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("areaTags")] 
		public CArray<CName> AreaTags
		{
			get
			{
				if (_areaTags == null)
				{
					_areaTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "areaTags", cr2w, this);
				}
				return _areaTags;
			}
			set
			{
				if (_areaTags == value)
				{
					return;
				}
				_areaTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManager> InventoryManager
		{
			get
			{
				if (_inventoryManager == null)
				{
					_inventoryManager = (CHandle<InventoryDataManager>) CR2WTypeManager.Create("handle:InventoryDataManager", "inventoryManager", cr2w, this);
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

		[Ordinal(25)] 
		[RED("vendorBlackboard")] 
		public CHandle<gameIBlackboard> VendorBlackboard
		{
			get
			{
				if (_vendorBlackboard == null)
				{
					_vendorBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "vendorBlackboard", cr2w, this);
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

		[Ordinal(26)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get
			{
				if (_equipArea == null)
				{
					_equipArea = (CEnum<gamedataEquipmentArea>) CR2WTypeManager.Create("gamedataEquipmentArea", "equipArea", cr2w, this);
				}
				return _equipArea;
			}
			set
			{
				if (_equipArea == value)
				{
					return;
				}
				_equipArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get
			{
				if (_slotIndex == null)
				{
					_slotIndex = (CInt32) CR2WTypeManager.Create("Int32", "slotIndex", cr2w, this);
				}
				return _slotIndex;
			}
			set
			{
				if (_slotIndex == value)
				{
					return;
				}
				_slotIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("recipeItemList")] 
		public CArray<TweakDBID> RecipeItemList
		{
			get
			{
				if (_recipeItemList == null)
				{
					_recipeItemList = (CArray<TweakDBID>) CR2WTypeManager.Create("array:TweakDBID", "recipeItemList", cr2w, this);
				}
				return _recipeItemList;
			}
			set
			{
				if (_recipeItemList == value)
				{
					return;
				}
				_recipeItemList = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("playerCraftBook")] 
		public CHandle<CraftBook> PlayerCraftBook
		{
			get
			{
				if (_playerCraftBook == null)
				{
					_playerCraftBook = (CHandle<CraftBook>) CR2WTypeManager.Create("handle:CraftBook", "playerCraftBook", cr2w, this);
				}
				return _playerCraftBook;
			}
			set
			{
				if (_playerCraftBook == value)
				{
					return;
				}
				_playerCraftBook = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("tooltipsLibrary")] 
		public redResourceReferenceScriptToken TooltipsLibrary
		{
			get
			{
				if (_tooltipsLibrary == null)
				{
					_tooltipsLibrary = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "tooltipsLibrary", cr2w, this);
				}
				return _tooltipsLibrary;
			}
			set
			{
				if (_tooltipsLibrary == value)
				{
					return;
				}
				_tooltipsLibrary = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("itemTooltipName")] 
		public CName ItemTooltipName
		{
			get
			{
				if (_itemTooltipName == null)
				{
					_itemTooltipName = (CName) CR2WTypeManager.Create("CName", "itemTooltipName", cr2w, this);
				}
				return _itemTooltipName;
			}
			set
			{
				if (_itemTooltipName == value)
				{
					return;
				}
				_itemTooltipName = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("tooltipStylePath")] 
		public redResourceReferenceScriptToken TooltipStylePath
		{
			get
			{
				if (_tooltipStylePath == null)
				{
					_tooltipStylePath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "tooltipStylePath", cr2w, this);
				}
				return _tooltipStylePath;
			}
			set
			{
				if (_tooltipStylePath == value)
				{
					return;
				}
				_tooltipStylePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("tooltipLeft")] 
		public wCHandle<InventorySlotTooltip> TooltipLeft
		{
			get
			{
				if (_tooltipLeft == null)
				{
					_tooltipLeft = (wCHandle<InventorySlotTooltip>) CR2WTypeManager.Create("whandle:InventorySlotTooltip", "tooltipLeft", cr2w, this);
				}
				return _tooltipLeft;
			}
			set
			{
				if (_tooltipLeft == value)
				{
					return;
				}
				_tooltipLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("tooltipRight")] 
		public wCHandle<InventorySlotTooltip> TooltipRight
		{
			get
			{
				if (_tooltipRight == null)
				{
					_tooltipRight = (wCHandle<InventorySlotTooltip>) CR2WTypeManager.Create("whandle:InventorySlotTooltip", "tooltipRight", cr2w, this);
				}
				return _tooltipRight;
			}
			set
			{
				if (_tooltipRight == value)
				{
					return;
				}
				_tooltipRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("tooltipContainer")] 
		public wCHandle<inkCompoundWidget> TooltipContainer
		{
			get
			{
				if (_tooltipContainer == null)
				{
					_tooltipContainer = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "tooltipContainer", cr2w, this);
				}
				return _tooltipContainer;
			}
			set
			{
				if (_tooltipContainer == value)
				{
					return;
				}
				_tooltipContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("paperDollList")] 
		public CArray<CName> PaperDollList
		{
			get
			{
				if (_paperDollList == null)
				{
					_paperDollList = (CArray<CName>) CR2WTypeManager.Create("array:CName", "paperDollList", cr2w, this);
				}
				return _paperDollList;
			}
			set
			{
				if (_paperDollList == value)
				{
					return;
				}
				_paperDollList = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("scrollOffset")] 
		public CInt32 ScrollOffset
		{
			get
			{
				if (_scrollOffset == null)
				{
					_scrollOffset = (CInt32) CR2WTypeManager.Create("Int32", "scrollOffset", cr2w, this);
				}
				return _scrollOffset;
			}
			set
			{
				if (_scrollOffset == value)
				{
					return;
				}
				_scrollOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("faceTags")] 
		public CArray<CName> FaceTags
		{
			get
			{
				if (_faceTags == null)
				{
					_faceTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "faceTags", cr2w, this);
				}
				return _faceTags;
			}
			set
			{
				if (_faceTags == value)
				{
					return;
				}
				_faceTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("headTags")] 
		public CArray<CName> HeadTags
		{
			get
			{
				if (_headTags == null)
				{
					_headTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "headTags", cr2w, this);
				}
				return _headTags;
			}
			set
			{
				if (_headTags == value)
				{
					return;
				}
				_headTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("chestTags")] 
		public CArray<CName> ChestTags
		{
			get
			{
				if (_chestTags == null)
				{
					_chestTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "chestTags", cr2w, this);
				}
				return _chestTags;
			}
			set
			{
				if (_chestTags == value)
				{
					return;
				}
				_chestTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("legTags")] 
		public CArray<CName> LegTags
		{
			get
			{
				if (_legTags == null)
				{
					_legTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "legTags", cr2w, this);
				}
				return _legTags;
			}
			set
			{
				if (_legTags == value)
				{
					return;
				}
				_legTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("weaponTags")] 
		public CArray<CName> WeaponTags
		{
			get
			{
				if (_weaponTags == null)
				{
					_weaponTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "weaponTags", cr2w, this);
				}
				return _weaponTags;
			}
			set
			{
				if (_weaponTags == value)
				{
					return;
				}
				_weaponTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("consumableTags")] 
		public CArray<CName> ConsumableTags
		{
			get
			{
				if (_consumableTags == null)
				{
					_consumableTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "consumableTags", cr2w, this);
				}
				return _consumableTags;
			}
			set
			{
				if (_consumableTags == value)
				{
					return;
				}
				_consumableTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("modulesTags")] 
		public CArray<CName> ModulesTags
		{
			get
			{
				if (_modulesTags == null)
				{
					_modulesTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "modulesTags", cr2w, this);
				}
				return _modulesTags;
			}
			set
			{
				if (_modulesTags == value)
				{
					return;
				}
				_modulesTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("framesTags")] 
		public CArray<CName> FramesTags
		{
			get
			{
				if (_framesTags == null)
				{
					_framesTags = (CArray<CName>) CR2WTypeManager.Create("array:CName", "framesTags", cr2w, this);
				}
				return _framesTags;
			}
			set
			{
				if (_framesTags == value)
				{
					return;
				}
				_framesTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("operationsMode")] 
		public CEnum<operationsMode> OperationsMode
		{
			get
			{
				if (_operationsMode == null)
				{
					_operationsMode = (CEnum<operationsMode>) CR2WTypeManager.Create("operationsMode", "operationsMode", cr2w, this);
				}
				return _operationsMode;
			}
			set
			{
				if (_operationsMode == value)
				{
					return;
				}
				_operationsMode = value;
				PropertySet(this);
			}
		}

		public ArmorEquipGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
