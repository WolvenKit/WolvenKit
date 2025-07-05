using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAttachmentSlotEventsPartRemovedFromSlotEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("removedPartID")] 
		public gameItemID RemovedPartID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public gameAttachmentSlotEventsPartRemovedFromSlotEvent()
		{
			ItemID = new gameItemID();
			RemovedPartID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
