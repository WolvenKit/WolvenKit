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
		[RED("uiInventorySystem")] 
		public CWeakHandle<UIInventoryScriptableSystem> UiInventorySystem
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryScriptableSystem>>(value);
		}

		[Ordinal(15)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(16)] 
		[RED("player")] 
		public CWeakHandle<gameObject> Player
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(17)] 
		[RED("maxItemsNum")] 
		public CInt32 MaxItemsNum
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("boundOwnerID")] 
		public entEntityID BoundOwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(19)] 
		[RED("lootingItems")] 
		public CArray<CWeakHandle<gameItemData>> LootingItems
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameItemData>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameItemData>>>(value);
		}

		[Ordinal(20)] 
		[RED("uiInventoryItems")] 
		public CArray<CHandle<UIInventoryItem>> UiInventoryItems
		{
			get => GetPropertyValue<CArray<CHandle<UIInventoryItem>>>();
			set => SetPropertyValue<CArray<CHandle<UIInventoryItem>>>(value);
		}

		[Ordinal(21)] 
		[RED("tooltipProvider")] 
		public CWeakHandle<TooltipProvider> TooltipProvider
		{
			get => GetPropertyValue<CWeakHandle<TooltipProvider>>();
			set => SetPropertyValue<CWeakHandle<TooltipProvider>>(value);
		}

		[Ordinal(22)] 
		[RED("cachedTooltipData")] 
		public CHandle<ATooltipData> CachedTooltipData
		{
			get => GetPropertyValue<CHandle<ATooltipData>>();
			set => SetPropertyValue<CHandle<ATooltipData>>(value);
		}

		[Ordinal(23)] 
		[RED("cachedTooltipUIInventoryItem")] 
		public CHandle<UIInventoryItem> CachedTooltipUIInventoryItem
		{
			get => GetPropertyValue<CHandle<UIInventoryItem>>();
			set => SetPropertyValue<CHandle<UIInventoryItem>>(value);
		}

		[Ordinal(24)] 
		[RED("displayContext")] 
		public CHandle<ItemDisplayContextData> DisplayContext
		{
			get => GetPropertyValue<CHandle<ItemDisplayContextData>>();
			set => SetPropertyValue<CHandle<ItemDisplayContextData>>(value);
		}

		[Ordinal(25)] 
		[RED("startIndex")] 
		public CInt32 StartIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(26)] 
		[RED("selectedItemIndex")] 
		public CInt32 SelectedItemIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(27)] 
		[RED("itemsToCompare")] 
		public CInt32 ItemsToCompare
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(28)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(29)] 
		[RED("currentComparisonItemId")] 
		public gameItemID CurrentComparisonItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(30)] 
		[RED("lastTooltipItemId")] 
		public gameItemID LastTooltipItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(31)] 
		[RED("currentTooltipItemId")] 
		public gameItemID CurrentTooltipItemId
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(32)] 
		[RED("currentTooltipLootingData")] 
		public CHandle<TooltipLootingCachedData> CurrentTooltipLootingData
		{
			get => GetPropertyValue<CHandle<TooltipLootingCachedData>>();
			set => SetPropertyValue<CHandle<TooltipLootingCachedData>>(value);
		}

		[Ordinal(33)] 
		[RED("lastItemOwnerId")] 
		public entEntityID LastItemOwnerId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(34)] 
		[RED("currentItemOwnerId")] 
		public entEntityID CurrentItemOwnerId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(35)] 
		[RED("currentComparisonEquipmentArea")] 
		public CEnum<gamedataEquipmentArea> CurrentComparisonEquipmentArea
		{
			get => GetPropertyValue<CEnum<gamedataEquipmentArea>>();
			set => SetPropertyValue<CEnum<gamedataEquipmentArea>>(value);
		}

		[Ordinal(36)] 
		[RED("lastListOpenedState")] 
		public CBool LastListOpenedState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(37)] 
		[RED("isComaprisonDirty")] 
		public CBool IsComaprisonDirty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(38)] 
		[RED("bufferedOwnerId")] 
		public entEntityID BufferedOwnerId
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(39)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(40)] 
		[RED("currendData")] 
		public gameinteractionsvisLootData CurrendData
		{
			get => GetPropertyValue<gameinteractionsvisLootData>();
			set => SetPropertyValue<gameinteractionsvisLootData>(value);
		}

		[Ordinal(41)] 
		[RED("activeWeaponID")] 
		public gameItemID ActiveWeaponID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(42)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("currentWidgetRequestVersion")] 
		public CInt32 CurrentWidgetRequestVersion
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(44)] 
		[RED("currentItemRequestVersion")] 
		public CInt32 CurrentItemRequestVersion
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(45)] 
		[RED("brokenLocPrefix")] 
		public CString BrokenLocPrefix
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(46)] 
		[RED("requestsCounter")] 
		public CInt32 RequestsCounter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public LootingController()
		{
			ItemsListContainer = new inkCompoundWidgetReference();
			TitleContainer = new inkCompoundWidgetReference();
			UpArrow = new inkWidgetReference();
			DownArrow = new inkWidgetReference();
			ListWrapper = new inkWidgetReference();
			ActionsListV = new inkCompoundWidgetReference();
			LockedStatusContainer = new inkWidgetReference();
			WidgetsPoolList = new();
			LootList = new();
			GameInstance = new ScriptGameInstance();
			MaxItemsNum = 3;
			BoundOwnerID = new entEntityID();
			LootingItems = new();
			UiInventoryItems = new();
			CurrentComparisonItemId = new gameItemID();
			LastTooltipItemId = new gameItemID();
			CurrentTooltipItemId = new gameItemID();
			LastItemOwnerId = new entEntityID();
			CurrentItemOwnerId = new entEntityID();
			BufferedOwnerId = new entEntityID();
			CurrendData = new gameinteractionsvisLootData { IsListOpen = true, Choices = new(), ItemIDs = new(), OwnerId = new entEntityID() };
			ActiveWeaponID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
