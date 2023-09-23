using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ArmorEquipGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("inventoryCanvas")] 
		public CWeakHandle<inkWidget> InventoryCanvas
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(4)] 
		[RED("inventoryList")] 
		public CWeakHandle<inkVerticalPanelWidget> InventoryList
		{
			get => GetPropertyValue<CWeakHandle<inkVerticalPanelWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVerticalPanelWidget>>(value);
		}

		[Ordinal(5)] 
		[RED("inventory")] 
		public CArray<CWeakHandle<gameItemData>> Inventory
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameItemData>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameItemData>>>(value);
		}

		[Ordinal(6)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(7)] 
		[RED("equipmentSystem")] 
		public CWeakHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetPropertyValue<CWeakHandle<EquipmentSystem>>();
			set => SetPropertyValue<CWeakHandle<EquipmentSystem>>(value);
		}

		[Ordinal(8)] 
		[RED("subCharacterSystem")] 
		public CWeakHandle<SubCharacterSystem> SubCharacterSystem
		{
			get => GetPropertyValue<CWeakHandle<SubCharacterSystem>>();
			set => SetPropertyValue<CWeakHandle<SubCharacterSystem>>(value);
		}

		[Ordinal(9)] 
		[RED("transactionSystem")] 
		public CWeakHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CWeakHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CWeakHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(10)] 
		[RED("craftingSystem")] 
		public CWeakHandle<CraftingSystem> CraftingSystem
		{
			get => GetPropertyValue<CWeakHandle<CraftingSystem>>();
			set => SetPropertyValue<CWeakHandle<CraftingSystem>>(value);
		}

		[Ordinal(11)] 
		[RED("buttonScrollUp")] 
		public CWeakHandle<inkCanvasWidget> ButtonScrollUp
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(12)] 
		[RED("buttonScrollDn")] 
		public CWeakHandle<inkCanvasWidget> ButtonScrollDn
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(13)] 
		[RED("buttonPlayer")] 
		public CWeakHandle<inkCanvasWidget> ButtonPlayer
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(14)] 
		[RED("buttonFlathead")] 
		public CWeakHandle<inkCanvasWidget> ButtonFlathead
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(15)] 
		[RED("buttonToolbox")] 
		public CWeakHandle<inkCanvasWidget> ButtonToolbox
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(16)] 
		[RED("panelPlayer")] 
		public CWeakHandle<inkCanvasWidget> PanelPlayer
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(17)] 
		[RED("panelFlathead")] 
		public CWeakHandle<inkCanvasWidget> PanelFlathead
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(18)] 
		[RED("panelToolbox")] 
		public CWeakHandle<inkCanvasWidget> PanelToolbox
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("uiBB_Equipment")] 
		public CHandle<UI_EquipmentDef> UiBB_Equipment
		{
			get => GetPropertyValue<CHandle<UI_EquipmentDef>>();
			set => SetPropertyValue<CHandle<UI_EquipmentDef>>(value);
		}

		[Ordinal(20)] 
		[RED("uiBB_EquipmentBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiBB_EquipmentBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(21)] 
		[RED("backgroundVideo")] 
		public CWeakHandle<inkVideoWidget> BackgroundVideo
		{
			get => GetPropertyValue<CWeakHandle<inkVideoWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVideoWidget>>(value);
		}

		[Ordinal(22)] 
		[RED("paperdollVideo")] 
		public CWeakHandle<inkVideoWidget> PaperdollVideo
		{
			get => GetPropertyValue<CWeakHandle<inkVideoWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVideoWidget>>(value);
		}

		[Ordinal(23)] 
		[RED("areaTags")] 
		public CArray<CName> AreaTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(24)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManager> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManager>>();
			set => SetPropertyValue<CHandle<InventoryDataManager>>(value);
		}

		[Ordinal(25)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(26)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(27)] 
		[RED("recipeItemList")] 
		public CArray<TweakDBID> RecipeItemList
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(28)] 
		[RED("playerCraftBook")] 
		public CHandle<CraftBook> PlayerCraftBook
		{
			get => GetPropertyValue<CHandle<CraftBook>>();
			set => SetPropertyValue<CHandle<CraftBook>>(value);
		}

		[Ordinal(29)] 
		[RED("tooltipsLibrary")] 
		public redResourceReferenceScriptToken TooltipsLibrary
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(30)] 
		[RED("itemTooltipName")] 
		public CName ItemTooltipName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(31)] 
		[RED("tooltipStylePath")] 
		public redResourceReferenceScriptToken TooltipStylePath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(32)] 
		[RED("tooltipLeft")] 
		public CWeakHandle<InventorySlotTooltip> TooltipLeft
		{
			get => GetPropertyValue<CWeakHandle<InventorySlotTooltip>>();
			set => SetPropertyValue<CWeakHandle<InventorySlotTooltip>>(value);
		}

		[Ordinal(33)] 
		[RED("tooltipRight")] 
		public CWeakHandle<InventorySlotTooltip> TooltipRight
		{
			get => GetPropertyValue<CWeakHandle<InventorySlotTooltip>>();
			set => SetPropertyValue<CWeakHandle<InventorySlotTooltip>>(value);
		}

		[Ordinal(34)] 
		[RED("tooltipContainer")] 
		public CWeakHandle<inkCompoundWidget> TooltipContainer
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(35)] 
		[RED("paperDollList")] 
		public CArray<CName> PaperDollList
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(36)] 
		[RED("scrollOffset")] 
		public CInt32 ScrollOffset
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(37)] 
		[RED("faceTags")] 
		public CArray<CName> FaceTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(38)] 
		[RED("headTags")] 
		public CArray<CName> HeadTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(39)] 
		[RED("chestTags")] 
		public CArray<CName> ChestTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(40)] 
		[RED("legTags")] 
		public CArray<CName> LegTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(41)] 
		[RED("weaponTags")] 
		public CArray<CName> WeaponTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(42)] 
		[RED("consumableTags")] 
		public CArray<CName> ConsumableTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(43)] 
		[RED("modulesTags")] 
		public CArray<CName> ModulesTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(44)] 
		[RED("framesTags")] 
		public CArray<CName> FramesTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(45)] 
		[RED("operationsMode")] 
		public CEnum<operationsMode> OperationsMode
		{
			get => GetPropertyValue<CEnum<operationsMode>>();
			set => SetPropertyValue<CEnum<operationsMode>>(value);
		}

		public ArmorEquipGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
