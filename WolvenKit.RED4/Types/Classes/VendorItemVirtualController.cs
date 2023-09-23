using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorItemVirtualController : inkVirtualCompoundItemController
	{
		[Ordinal(18)] 
		[RED("data")] 
		public CHandle<VendorInventoryItemData> Data
		{
			get => GetPropertyValue<CHandle<VendorInventoryItemData>>();
			set => SetPropertyValue<CHandle<VendorInventoryItemData>>(value);
		}

		[Ordinal(19)] 
		[RED("newData")] 
		public CHandle<VendorUIInventoryItemData> NewData
		{
			get => GetPropertyValue<CHandle<VendorUIInventoryItemData>>();
			set => SetPropertyValue<CHandle<VendorUIInventoryItemData>>(value);
		}

		[Ordinal(20)] 
		[RED("itemViewController")] 
		public CWeakHandle<InventoryItemDisplayController> ItemViewController
		{
			get => GetPropertyValue<CWeakHandle<InventoryItemDisplayController>>();
			set => SetPropertyValue<CWeakHandle<InventoryItemDisplayController>>(value);
		}

		[Ordinal(21)] 
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
