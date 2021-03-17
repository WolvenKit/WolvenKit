using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameItemAddedEvent : redEvent
	{
		private gameItemID _itemID;
		private CHandle<gameItemData> _itemData;
		private CInt32 _currentQuantity;
		private CBool _flaggedAsSilent;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("itemData")] 
		public CHandle<gameItemData> ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(2)] 
		[RED("currentQuantity")] 
		public CInt32 CurrentQuantity
		{
			get => GetProperty(ref _currentQuantity);
			set => SetProperty(ref _currentQuantity, value);
		}

		[Ordinal(3)] 
		[RED("flaggedAsSilent")] 
		public CBool FlaggedAsSilent
		{
			get => GetProperty(ref _flaggedAsSilent);
			set => SetProperty(ref _flaggedAsSilent, value);
		}

		public gameItemAddedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
