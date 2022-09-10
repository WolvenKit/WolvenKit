using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIScriptableSystem : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("backpackActiveSorting")] 
		public CInt32 BackpackActiveSorting
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("backpackActiveFilter")] 
		public CInt32 BackpackActiveFilter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("isBackpackActiveFilterSaved")] 
		public CBool IsBackpackActiveFilterSaved
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("vendorPanelPlayerActiveSorting")] 
		public CInt32 VendorPanelPlayerActiveSorting
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("vendorPanelVendorActiveSorting")] 
		public CInt32 VendorPanelVendorActiveSorting
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("newItems")] 
		public CArray<gameItemID> NewItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(6)] 
		[RED("DLCAddedItems")] 
		public CArray<TweakDBID> DLCAddedItems
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(7)] 
		[RED("newWardrobeSets")] 
		public CArray<CEnum<gameWardrobeClothingSetIndex>> NewWardrobeSets
		{
			get => GetPropertyValue<CArray<CEnum<gameWardrobeClothingSetIndex>>>();
			set => SetPropertyValue<CArray<CEnum<gameWardrobeClothingSetIndex>>>(value);
		}

		[Ordinal(8)] 
		[RED("newWardrobeItems")] 
		public CArray<gameItemID> NewWardrobeItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(9)] 
		[RED("comparisionTooltipDisabled")] 
		public CBool ComparisionTooltipDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("attachedPlayer")] 
		public CWeakHandle<PlayerPuppet> AttachedPlayer
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(11)] 
		[RED("inventoryListenerCallback")] 
		public CHandle<UIScriptableInventoryListenerCallback> InventoryListenerCallback
		{
			get => GetPropertyValue<CHandle<UIScriptableInventoryListenerCallback>>();
			set => SetPropertyValue<CHandle<UIScriptableInventoryListenerCallback>>(value);
		}

		[Ordinal(12)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetPropertyValue<CHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CHandle<gameInventoryScriptListener>>(value);
		}

		public UIScriptableSystem()
		{
			NewItems = new();
			DLCAddedItems = new();
			NewWardrobeSets = new();
			NewWardrobeItems = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
