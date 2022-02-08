using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		[RED("comparisionTooltipDisabled")] 
		public CBool ComparisionTooltipDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("attachedPlayer")] 
		public CWeakHandle<PlayerPuppet> AttachedPlayer
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(8)] 
		[RED("inventoryListenerCallback")] 
		public CHandle<UIScriptableInventoryListenerCallback> InventoryListenerCallback
		{
			get => GetPropertyValue<CHandle<UIScriptableInventoryListenerCallback>>();
			set => SetPropertyValue<CHandle<UIScriptableInventoryListenerCallback>>(value);
		}

		[Ordinal(9)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetPropertyValue<CHandle<gameInventoryScriptListener>>();
			set => SetPropertyValue<CHandle<gameInventoryScriptListener>>(value);
		}

		public UIScriptableSystem()
		{
			NewItems = new();
		}
	}
}
