using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShardCollectedInventoryCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] 
		[RED("notificationQueue")] 
		public CWeakHandle<JournalNotificationQueue> NotificationQueue
		{
			get => GetPropertyValue<CWeakHandle<JournalNotificationQueue>>();
			set => SetPropertyValue<CWeakHandle<JournalNotificationQueue>>(value);
		}

		[Ordinal(2)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetPropertyValue<CWeakHandle<gameJournalManager>>();
			set => SetPropertyValue<CWeakHandle<gameJournalManager>>(value);
		}

		public ShardCollectedInventoryCallback()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
