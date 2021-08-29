using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CurrencyChangeInventoryCallback : gameInventoryScriptCallback
	{
		private CWeakHandle<ItemsNotificationQueue> _notificationQueue;

		[Ordinal(1)] 
		[RED("notificationQueue")] 
		public CWeakHandle<ItemsNotificationQueue> NotificationQueue
		{
			get => GetProperty(ref _notificationQueue);
			set => SetProperty(ref _notificationQueue, value);
		}
	}
}
