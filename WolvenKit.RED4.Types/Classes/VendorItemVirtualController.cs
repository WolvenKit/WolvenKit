using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorItemVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(15)] 
		[RED("data")] 
		public CHandle<VendorInventoryItemData> Data
		{
			get => GetPropertyValue<CHandle<VendorInventoryItemData>>();
			set => SetPropertyValue<CHandle<VendorInventoryItemData>>(value);
		}

		[Ordinal(16)] 
		[RED("itemViewController")] 
		public CWeakHandle<InventoryItemDisplayController> ItemViewController
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(17)] 
		[RED("isSpawnInProgress")] 
		public CBool IsSpawnInProgress
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VendorItemVirtualController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
