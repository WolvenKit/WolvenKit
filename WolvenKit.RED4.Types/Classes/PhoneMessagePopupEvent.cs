using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PhoneMessagePopupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<JournalNotificationData> Data
		{
			get => GetPropertyValue<CHandle<JournalNotificationData>>();
			set => SetPropertyValue<CHandle<JournalNotificationData>>(value);
		}

		public PhoneMessagePopupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
