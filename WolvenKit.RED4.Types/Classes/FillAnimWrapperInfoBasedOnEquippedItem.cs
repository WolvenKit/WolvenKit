using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FillAnimWrapperInfoBasedOnEquippedItem : redEvent
	{
		private gameItemID _itemID;
		private CName _itemType;
		private CName _itemName;
		private CBool _clearWrapperInfo;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("itemType")] 
		public CName ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(2)] 
		[RED("itemName")] 
		public CName ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(3)] 
		[RED("clearWrapperInfo")] 
		public CBool ClearWrapperInfo
		{
			get => GetProperty(ref _clearWrapperInfo);
			set => SetProperty(ref _clearWrapperInfo, value);
		}
	}
}
