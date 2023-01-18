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
		[RED("playerItems")] 
		public CHandle<inkScriptHashMap> PlayerItems
		{
			get => GetPropertyValue<CHandle<inkScriptHashMap>>();
			set => SetPropertyValue<CHandle<inkScriptHashMap>>(value);
		}

		[Ordinal(5)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(6)] 
		[RED("inventoryItemsManager")] 
		public CHandle<UIInventoryItemsManager> InventoryItemsManager
		{
			get => GetPropertyValue<CHandle<UIInventoryItemsManager>>();
			set => SetPropertyValue<CHandle<UIInventoryItemsManager>>(value);
		}

		[Ordinal(7)] 
		[RED("blacklistedTags")] 
		public CArray<CName> BlacklistedTags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(8)] 
		[RED("cachedNonInventoryItems")] 
		public CHandle<inkScriptHashMap> CachedNonInventoryItems
		{
			get => GetPropertyValue<CHandle<inkScriptHashMap>>();
			set => SetPropertyValue<CHandle<inkScriptHashMap>>(value);
		}

		[Ordinal(9)] 
		[RED("InventoryBlackboard")] 
		public CWeakHandle<gameIBlackboard> InventoryBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		public UIInventoryScriptableSystem()
		{
			BlacklistedTags = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
