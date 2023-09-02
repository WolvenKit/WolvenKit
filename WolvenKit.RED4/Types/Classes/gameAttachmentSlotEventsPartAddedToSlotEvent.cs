using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAttachmentSlotEventsPartAddedToSlotEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("partID")] 
		public gameItemID PartID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		public gameAttachmentSlotEventsPartAddedToSlotEvent()
		{
			ItemID = new gameItemID();
			PartID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
