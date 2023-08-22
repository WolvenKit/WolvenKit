
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameAttachmentSlotEventsAttachmentSlotEvent : redEvent
	{
		public gameAttachmentSlotEventsAttachmentSlotEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
