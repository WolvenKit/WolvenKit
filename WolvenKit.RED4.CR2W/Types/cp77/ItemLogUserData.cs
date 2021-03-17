using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemLogUserData : inkGameNotificationData
	{
		private gameItemID _itemID;
		private CBool _itemLogQueueEmpty;

		[Ordinal(6)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(7)] 
		[RED("itemLogQueueEmpty")] 
		public CBool ItemLogQueueEmpty
		{
			get => GetProperty(ref _itemLogQueueEmpty);
			set => SetProperty(ref _itemLogQueueEmpty, value);
		}

		public ItemLogUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
