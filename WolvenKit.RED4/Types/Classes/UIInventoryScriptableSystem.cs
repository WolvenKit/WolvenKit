using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryScriptableSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("attachedPlayer")] 
		public CWeakHandle<PlayerPuppet> AttachedPlayer
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("inventoryListenerCallback")] 
		public CHandle<UIInventoryScriptableInventoryListenerCallback> InventoryListenerCallback
		{
			get => GetPropertyValue<CHandle<UIInventoryScriptableInventoryListenerCallback>>();
			set => SetPropertyValue<CHandle<UIInventoryScriptableInventoryListenerCallback>>(value);
		}

		[Ordinal(2)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetPropertyValue<CHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(3)] 
		[RED("equipmentListener")] 
		public CHandle<UIInventoryScriptableEquipmentListener> EquipmentListener
		{
			get => GetPropertyValue<CHandle<UIInventoryScriptableEquipmentListener>>();
			set => SetPropertyValue<CHandle<UIInventoryScriptableEquipmentListener>>(value);
		}

		[Ordinal(4)] 
		[RED("playerStatsListener")] 
		public CHandle<UIInventoryScriptableStatsListener> PlayerStatsListener
		{
			get => GetPropertyValue<CHandle<UIInventoryScriptableStatsListener>>();
			set => SetPropertyValue<CHandle<UIInventoryScriptableStatsListener>>(value);
		}

		[Ordinal(5)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetPropertyValue<CHandle<gameuiGameSystemUI>>();
			set => SetPropertyValue<CHandle<gameuiGameSystemUI>>(value);
		}

		[Ordinal(6)] 
		[RED("playerItems")] 
		public CHandle<inkScriptHashMap> PlayerItems
		{
			get => GetPropertyValue<CHandle<inkScriptHashMap>>();
			set => SetPropertyValue<CHandle<inkScriptHashMap>>(value);
		}

		[Ordinal(7)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(8)] 
		[RED("uiScriptableSystem")] 
		public CHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetPropertyValue<CHandle<UIScriptableSystem>>();
			set => SetPropertyValue<CHandle<UIScriptableSystem>>(value);
		}

		[Ordinal(9)] 
		[RED("inventoryItemsManager")] 
		public CHandle<UIInventoryItemsManager> InventoryItemsManager
		{
			get => GetPropertyValue<CHandle<UIInventoryItemsManager>>();
			set => SetPropertyValue<CHandle<UIInventoryItemsManager>>(value);
		}

		[Ordinal(10)] 
		[RED("blacklistedTags")] 
		public CArray<CName> BlacklistedTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(11)] 
		[RED("cachedNonInventoryItems")] 
		public CHandle<inkScriptHashMap> CachedNonInventoryItems
		{
			get => GetPropertyValue<CHandle<inkScriptHashMap>>();
			set => SetPropertyValue<CHandle<inkScriptHashMap>>(value);
		}

		[Ordinal(12)] 
		[RED("statsDependantItems")] 
		public CHandle<inkScriptWeakHashMap> StatsDependantItems
		{
			get => GetPropertyValue<CHandle<inkScriptWeakHashMap>>();
			set => SetPropertyValue<CHandle<inkScriptWeakHashMap>>(value);
		}

		[Ordinal(13)] 
		[RED("InventoryBlackboard")] 
		public CWeakHandle<gameIBlackboard> InventoryBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(14)] 
		[RED("CraftingBlackboardDefinition")] 
		public CHandle<UI_CraftingDef> CraftingBlackboardDefinition
		{
			get => GetPropertyValue<CHandle<UI_CraftingDef>>();
			set => SetPropertyValue<CHandle<UI_CraftingDef>>(value);
		}

		[Ordinal(15)] 
		[RED("Blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(16)] 
		[RED("UpgradeBlackboardCallback")] 
		public CHandle<redCallbackObject> UpgradeBlackboardCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(17)] 
		[RED("TEMP_questSystem")] 
		public CHandle<questQuestsSystem> TEMP_questSystem
		{
			get => GetPropertyValue<CHandle<questQuestsSystem>>();
			set => SetPropertyValue<CHandle<questQuestsSystem>>(value);
		}

		[Ordinal(18)] 
		[RED("TEMP_cuverBarsListener")] 
		public CUInt32 TEMP_cuverBarsListener
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(19)] 
		[RED("TEMP_separatorBarsListener")] 
		public CUInt32 TEMP_separatorBarsListener
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(20)] 
		[RED("itemsRestored")] 
		public CBool ItemsRestored
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UIInventoryScriptableSystem()
		{
			BlacklistedTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
