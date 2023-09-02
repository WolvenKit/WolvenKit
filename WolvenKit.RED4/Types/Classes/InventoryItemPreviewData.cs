using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemPreviewData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(8)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(9)] 
		[RED("requiredLevel")] 
		public CInt32 RequiredLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("itemQualityState")] 
		public CName ItemQualityState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public InventoryItemPreviewData()
		{
			ItemID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
