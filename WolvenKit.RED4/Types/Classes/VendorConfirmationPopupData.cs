using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VendorConfirmationPopupData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("itemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(8)] 
		[RED("inventoryItem")] 
		public CWeakHandle<UIInventoryItem> InventoryItem
		{
			get => GetPropertyValue<CWeakHandle<UIInventoryItem>>();
			set => SetPropertyValue<CWeakHandle<UIInventoryItem>>(value);
		}

		[Ordinal(9)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("type")] 
		public CEnum<VendorConfirmationPopupType> Type
		{
			get => GetPropertyValue<CEnum<VendorConfirmationPopupType>>();
			set => SetPropertyValue<CEnum<VendorConfirmationPopupType>>(value);
		}

		[Ordinal(11)] 
		[RED("price")] 
		public CInt32 Price
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public VendorConfirmationPopupData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
