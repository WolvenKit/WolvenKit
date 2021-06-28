using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemPreviewData : inkGameNotificationData
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

		public InventoryItemPreviewData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
