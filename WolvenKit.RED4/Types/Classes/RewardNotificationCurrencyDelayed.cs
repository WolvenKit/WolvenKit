using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RewardNotificationCurrencyDelayed : gameDelaySystemScriptedDelayCallbackWrapper
	{
		[Ordinal(0)] 
		[RED("notificationQueue")] 
		public CWeakHandle<ItemsNotificationQueue> NotificationQueue
		{
			get => GetPropertyValue<CWeakHandle<ItemsNotificationQueue>>();
			set => SetPropertyValue<CWeakHandle<ItemsNotificationQueue>>(value);
		}

		[Ordinal(1)] 
		[RED("notificationData")] 
		public gameuiGenericNotificationData NotificationData
		{
			get => GetPropertyValue<gameuiGenericNotificationData>();
			set => SetPropertyValue<gameuiGenericNotificationData>(value);
		}

		public RewardNotificationCurrencyDelayed()
		{
			NotificationData = new gameuiGenericNotificationData { WidgetLibraryResource = new redResourceReferenceScriptToken() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
