using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemLogUserData : inkGameNotificationData
	{
		[Ordinal(6)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(7)] 
		[RED("itemLogQueueEmpty")] 
		public CBool ItemLogQueueEmpty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ItemLogUserData()
		{
			ItemID = new();
		}
	}
}
