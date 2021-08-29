using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemPreviewData : inkGameNotificationData
	{
		private gameItemID _itemID;
		private CString _itemName;
		private CInt32 _requiredLevel;
		private CName _itemQualityState;

		[Ordinal(6)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(7)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(8)] 
		[RED("requiredLevel")] 
		public CInt32 RequiredLevel
		{
			get => GetProperty(ref _requiredLevel);
			set => SetProperty(ref _requiredLevel, value);
		}

		[Ordinal(9)] 
		[RED("itemQualityState")] 
		public CName ItemQualityState
		{
			get => GetProperty(ref _itemQualityState);
			set => SetProperty(ref _itemQualityState, value);
		}
	}
}
