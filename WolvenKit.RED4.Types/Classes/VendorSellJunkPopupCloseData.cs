using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorSellJunkPopupCloseData : inkGameNotificationData
	{
		private CBool _confirm;
		private CArray<CWeakHandle<gameItemData>> _items;
		private CArray<CHandle<VendorJunkSellItem>> _limitedItems;

		[Ordinal(6)] 
		[RED("confirm")] 
		public CBool Confirm
		{
			get => GetProperty(ref _confirm);
			set => SetProperty(ref _confirm, value);
		}

		[Ordinal(7)] 
		[RED("items")] 
		public CArray<CWeakHandle<gameItemData>> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		[Ordinal(8)] 
		[RED("limitedItems")] 
		public CArray<CHandle<VendorJunkSellItem>> LimitedItems
		{
			get => GetProperty(ref _limitedItems);
			set => SetProperty(ref _limitedItems, value);
		}
	}
}
