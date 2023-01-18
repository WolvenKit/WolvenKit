using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CurrencyChangeInventoryCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("notificationQueue")] 
		public CWeakHandle<ItemsNotificationQueue> NotificationQueue
		{
			get => GetPropertyValue<CWeakHandle<ItemsNotificationQueue>>();
			set => SetPropertyValue<CWeakHandle<ItemsNotificationQueue>>(value);
		}

		public CurrencyChangeInventoryCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
