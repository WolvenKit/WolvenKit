using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LootingController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("root")] 
		public CWeakHandle<inkWidget> Root
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(2)] 
		[RED("itemsListContainer")] 
		public inkCompoundWidgetReference ItemsListContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("titleContainer")] 
		public inkCompoundWidgetReference TitleContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("upArrow")] 
		public inkWidgetReference UpArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("downArrow")] 
		public inkWidgetReference DownArrow
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("listWrapper")] 
		public inkWidgetReference ListWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("actionsListV")] 
		public inkCompoundWidgetReference ActionsListV
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("lockedStatusContainer")] 
		public inkWidgetReference LockedStatusContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("widgetsPoolList")] 
		public CArray<CWeakHandle<inkWidget>> WidgetsPoolList
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(10)] 
		[RED("requestedWidgetsPoolItems")] 
		public CInt32 RequestedWidgetsPoolItems
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("lootList")] 
		public CArray<CWeakHandle<inkWidget>> LootList
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(12)] 
		[RED("requestedItemsPoolItems")] 
		public CInt32 RequestedItemsPoolItems
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("dataManager")] 
		public CWeakHandle<InventoryDataManagerV2> DataManager
		{
			get => GetPropertyValue<CWeakHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CWeakHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(14)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(15)] 
		[RED("maxItemsNum")] 
		public CInt32 MaxItemsNum
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(16)] 
		[RED("tooltipProvider")] 
		public CWeakHandle<TooltipProvider> TooltipProvider
		{
			get => GetPropertyValue<CWeakHandle<TooltipProvider>>();
			set => SetPropertyValue<CWeakHandle<TooltipProvider>>(value);
		}

		[Ordinal(17)] 
		[RED("cachedTooltipData")] 
		public CHandle<ATooltipData> CachedTooltipData
		{
			get => GetPropertyValue<CHandle<ATooltipData>>();
			set => SetPropertyValue<CHandle<ATooltipData>>(value);
		}

		[Ordinal(18)] 
		[RED("startIndex")] 
		public CInt32 StartIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("selectedItemIndex")] 
		public CInt32 SelectedItemIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("itemsToCompare")] 
		public CInt32 ItemsToCompare
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(21)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("currentComparisonItemId")] 
		public gameItemID CurrentComparisonItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(23)] 
		[RED("lastTooltipItemId")] 
		public gameItemID LastTooltipItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(24)] 
		[RED("currentTooltipItemId")] 
		public gameItemID CurrentTooltipItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(25)] 
		[RED("currentTooltipLootingData")] 
		public CHandle<TooltipLootingCachedData> CurrentTooltipLootingData
		{
			get => GetPropertyValue<CHandle<TooltipLootingCachedData>>();
			set => SetPropertyValue<CHandle<TooltipLootingCachedData>>(value);
		}

		[Ordinal(26)] 
		[RED("lastItemOwnerId")] 
		public entEntityID LastItemOwnerId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(27)] 
		[RED("currentItemOwnerId")] 
		public entEntityID CurrentItemOwnerId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(28)] 
		[RED("currentComparisonEquipmentArea")] 
		public CEnum<gamedataEquipmentArea> CurrentComparisonEquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(29)] 
		[RED("lastListOpenedState")] 
		public CBool LastListOpenedState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("isComaprisonDirty")] 
		public CBool IsComaprisonDirty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("bufferedOwnerId")] 
		public entEntityID BufferedOwnerId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(32)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(33)] 
		[RED("currendData")] 
		public gameinteractionsvisLootData CurrendData
		{
			get => GetPropertyValue<gameinteractionsvisLootData>();
			set => SetPropertyValue<gameinteractionsvisLootData>(value);
		}

		[Ordinal(34)] 
		[RED("activeWeapon")] 
		public gameInventoryItemData ActiveWeapon
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(35)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(36)] 
		[RED("currentWidgetRequestVersion")] 
		public CInt32 CurrentWidgetRequestVersion
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(37)] 
		[RED("currentItemRequestVersion")] 
		public CInt32 CurrentItemRequestVersion
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(38)] 
		[RED("requestsCounter")] 
		public CInt32 RequestsCounter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public LootingController()
		{
			ItemsListContainer = new();
			TitleContainer = new();
			UpArrow = new();
			DownArrow = new();
			ListWrapper = new();
			ActionsListV = new();
			LockedStatusContainer = new();
			WidgetsPoolList = new();
			LootList = new();
			GameInstance = new();
			MaxItemsNum = 3;
			CurrentComparisonItemId = new();
			LastTooltipItemId = new();
			CurrentTooltipItemId = new();
			LastItemOwnerId = new();
			CurrentItemOwnerId = new();
			BufferedOwnerId = new();
			CurrendData = new() { IsListOpen = true, Choices = new(), ItemIDs = new(), OwnerId = new() };
			ActiveWeapon = new() { ID = new(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = 4294967295, IsRequirementMet = true, IsEquippable = true, Requirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new() { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
