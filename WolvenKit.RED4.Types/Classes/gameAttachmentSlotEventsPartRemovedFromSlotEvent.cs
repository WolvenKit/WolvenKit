using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
			ItemID = new();
			RemovedPartID = new();
		}
	}
}
