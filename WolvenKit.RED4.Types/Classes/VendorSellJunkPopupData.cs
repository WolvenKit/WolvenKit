using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VendorSellJunkPopupData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("items")] 
		public CArray<CWeakHandle<gameItemData>> Items
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameItemData>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameItemData>>>(value);
		}

		[Ordinal(8)] 
		[RED("limitedItems")] 
		public CArray<CHandle<VendorJunkSellItem>> LimitedItems
		{
			get => GetPropertyValue<CArray<CHandle<VendorJunkSellItem>>>();
			set => SetPropertyValue<CArray<CHandle<VendorJunkSellItem>>>(value);
		}

		[Ordinal(9)] 
		[RED("itemsQuantity")] 
		public CInt32 ItemsQuantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("limitedItemsQuantity")] 
		public CInt32 LimitedItemsQuantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("totalPrice")] 
		public CFloat TotalPrice
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("limitedTotalPrice")] 
		public CInt32 LimitedTotalPrice
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public VendorSellJunkPopupData()
		{
			Items = new();
			LimitedItems = new();
		}
	}
}
