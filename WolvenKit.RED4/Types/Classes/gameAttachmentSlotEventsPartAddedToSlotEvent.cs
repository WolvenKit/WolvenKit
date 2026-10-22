using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAttachmentSlotEventsPartAddedToSlotEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("item")] 
		public CWeakHandle<gameItemObject> Item
		{
			get => GetPropertyValue<CWeakHandle<gameItemObject>>();
			set => SetPropertyValue<CWeakHandle<gameItemObject>>(value);
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
			PartID = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
