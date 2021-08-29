using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorItemVirtualController : inkVirtualCompoundItemController
	{
		private CHandle<VendorInventoryItemData> _data;
		private CWeakHandle<InventoryItemDisplayController> _itemViewController;
		private CBool _isSpawnInProgress;

		[Ordinal(15)] 
		[RED("data")] 
		public CHandle<VendorInventoryItemData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(16)] 
		[RED("itemViewController")] 
		public CWeakHandle<InventoryItemDisplayController> ItemViewController
		{
			get => GetProperty(ref _itemViewController);
			set => SetProperty(ref _itemViewController, value);
		}

		[Ordinal(17)] 
		[RED("isSpawnInProgress")] 
		public CBool IsSpawnInProgress
		{
			get => GetProperty(ref _isSpawnInProgress);
			set => SetProperty(ref _isSpawnInProgress, value);
		}
	}
}
