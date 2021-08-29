using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShardCollectedNotificationViewData : gameuiGenericNotificationViewData
	{
		private CHandle<gameJournalOnscreen> _entry;
		private CBool _isCrypted;
		private gameItemID _itemID;
		private CString _shardTitle;

		[Ordinal(5)] 
		[RED("entry")] 
		public CHandle<gameJournalOnscreen> Entry
		{
			get => GetProperty(ref _entry);
			set => SetProperty(ref _entry, value);
		}

		[Ordinal(6)] 
		[RED("isCrypted")] 
		public CBool IsCrypted
		{
			get => GetProperty(ref _isCrypted);
			set => SetProperty(ref _isCrypted, value);
		}

		[Ordinal(7)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(8)] 
		[RED("shardTitle")] 
		public CString ShardTitle
		{
			get => GetProperty(ref _shardTitle);
			set => SetProperty(ref _shardTitle, value);
		}
	}
}
