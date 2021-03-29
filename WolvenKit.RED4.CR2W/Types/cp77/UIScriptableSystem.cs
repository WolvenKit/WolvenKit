using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIScriptableSystem : gameScriptableSystem
	{
		private CInt32 _backpackActiveSorting;
		private CInt32 _backpackActiveFilter;
		private CBool _isBackpackActiveFilterSaved;
		private CInt32 _vendorPanelPlayerActiveSorting;
		private CInt32 _vendorPanelVendorActiveSorting;
		private CArray<gameItemID> _newItems;
		private CBool _comparisionTooltipDisabled;
		private wCHandle<PlayerPuppet> _attachedPlayer;
		private CHandle<UIScriptableInventoryListenerCallback> _inventoryListenerCallback;
		private CHandle<gameInventoryScriptListener> _inventoryListener;

		[Ordinal(0)] 
		[RED("backpackActiveSorting")] 
		public CInt32 BackpackActiveSorting
		{
			get => GetProperty(ref _backpackActiveSorting);
			set => SetProperty(ref _backpackActiveSorting, value);
		}

		[Ordinal(1)] 
		[RED("backpackActiveFilter")] 
		public CInt32 BackpackActiveFilter
		{
			get => GetProperty(ref _backpackActiveFilter);
			set => SetProperty(ref _backpackActiveFilter, value);
		}

		[Ordinal(2)] 
		[RED("isBackpackActiveFilterSaved")] 
		public CBool IsBackpackActiveFilterSaved
		{
			get => GetProperty(ref _isBackpackActiveFilterSaved);
			set => SetProperty(ref _isBackpackActiveFilterSaved, value);
		}

		[Ordinal(3)] 
		[RED("vendorPanelPlayerActiveSorting")] 
		public CInt32 VendorPanelPlayerActiveSorting
		{
			get => GetProperty(ref _vendorPanelPlayerActiveSorting);
			set => SetProperty(ref _vendorPanelPlayerActiveSorting, value);
		}

		[Ordinal(4)] 
		[RED("vendorPanelVendorActiveSorting")] 
		public CInt32 VendorPanelVendorActiveSorting
		{
			get => GetProperty(ref _vendorPanelVendorActiveSorting);
			set => SetProperty(ref _vendorPanelVendorActiveSorting, value);
		}

		[Ordinal(5)] 
		[RED("newItems")] 
		public CArray<gameItemID> NewItems
		{
			get => GetProperty(ref _newItems);
			set => SetProperty(ref _newItems, value);
		}

		[Ordinal(6)] 
		[RED("comparisionTooltipDisabled")] 
		public CBool ComparisionTooltipDisabled
		{
			get => GetProperty(ref _comparisionTooltipDisabled);
			set => SetProperty(ref _comparisionTooltipDisabled, value);
		}

		[Ordinal(7)] 
		[RED("attachedPlayer")] 
		public wCHandle<PlayerPuppet> AttachedPlayer
		{
			get => GetProperty(ref _attachedPlayer);
			set => SetProperty(ref _attachedPlayer, value);
		}

		[Ordinal(8)] 
		[RED("inventoryListenerCallback")] 
		public CHandle<UIScriptableInventoryListenerCallback> InventoryListenerCallback
		{
			get => GetProperty(ref _inventoryListenerCallback);
			set => SetProperty(ref _inventoryListenerCallback, value);
		}

		[Ordinal(9)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetProperty(ref _inventoryListener);
			set => SetProperty(ref _inventoryListener, value);
		}

		public UIScriptableSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
