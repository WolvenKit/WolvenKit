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
		[RED("playerFavouriteItems")] 
		public CArray<gameItemID> PlayerFavouriteItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(6)] 
		[RED("newItems")] 
		public CArray<gameItemID> NewItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(7)] 
		[RED("DLCAddedItems")] 
		public CArray<TweakDBID> DLCAddedItems
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}

		[Ordinal(8)] 
		[RED("newWardrobeSets")] 
		public CArray<CEnum<gameWardrobeClothingSetIndex>> NewWardrobeSets
		{
			get => GetPropertyValue<CArray<CEnum<gameWardrobeClothingSetIndex>>>();
			set => SetPropertyValue<CArray<CEnum<gameWardrobeClothingSetIndex>>>(value);
		}

		[Ordinal(9)] 
		[RED("newWardrobeItems")] 
		public CArray<gameItemID> NewWardrobeItems
		{
			get => GetPropertyValue<CArray<gameItemID>>();
			set => SetPropertyValue<CArray<gameItemID>>(value);
		}

		[Ordinal(10)] 
		[RED("availableCars")] 
		public CArray<CName> AvailableCars
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(11)] 
		[RED("previousAttributeLevels")] 
		public CArray<UIScriptableSystemAttributeLevel> PreviousAttributeLevels
		{
			get => GetPropertyValue<CArray<UIScriptableSystemAttributeLevel>>();
			set => SetPropertyValue<CArray<UIScriptableSystemAttributeLevel>>(value);
		}

		[Ordinal(12)] 
		[RED("comparisionTooltipDisabled")] 
		public CBool ComparisionTooltipDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("attachedPlayer")] 
		public CWeakHandle<PlayerPuppet> AttachedPlayer
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(14)] 
		[RED("inventoryListenerCallback")] 
		public CHandle<UIScriptableInventoryListenerCallback> InventoryListenerCallback
		{
			get => GetPropertyValue<CHandle<UIScriptableInventoryListenerCallback>>();
			set => SetPropertyValue<CHandle<UIScriptableInventoryListenerCallback>>(value);
		}

		[Ordinal(15)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetPropertyValue<CHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CHandle<gameInventoryScriptListener>>(value);
		}

		[Ordinal(16)] 
		[RED("DEV_useNewTooltips")] 
		public CBool DEV_useNewTooltips
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("DEV_useLongScanTooltips")] 
		public CBool DEV_useLongScanTooltips
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UIScriptableSystem()
		{
			PlayerFavouriteItems = new();
			NewItems = new();
			DLCAddedItems = new();
			NewWardrobeSets = new();
			NewWardrobeItems = new();
			AvailableCars = new();
			PreviousAttributeLevels = new();
			DEV_useLongScanTooltips = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
