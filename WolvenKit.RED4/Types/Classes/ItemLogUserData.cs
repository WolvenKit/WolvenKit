using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemLogUserData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(8)] 
		[RED("itemLogQueueEmpty")] 
		public CBool ItemLogQueueEmpty
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ItemLogUserData()
		{
			ItemID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
