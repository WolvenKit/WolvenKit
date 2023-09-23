using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorSellJunkPopupCloseData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("confirm")] 
		public CBool Confirm
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("items")] 
		public CArray<CWeakHandle<gameItemData>> Items
		{
			get => GetPropertyValue<CArray<CWeakHandle<gameItemData>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gameItemData>>>(value);
		}

		[Ordinal(9)] 
		[RED("limitedItems")] 
		public CArray<CHandle<VendorJunkSellItem>> LimitedItems
		{
			get => GetPropertyValue<CArray<CHandle<VendorJunkSellItem>>>();
			set => SetPropertyValue<CArray<CHandle<VendorJunkSellItem>>>(value);
		}

		public VendorSellJunkPopupCloseData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
