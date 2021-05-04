using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FillAnimWrapperInfoBasedOnEquippedItem : redEvent
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

		public FillAnimWrapperInfoBasedOnEquippedItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
