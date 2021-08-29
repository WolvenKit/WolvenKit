using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ShardCollectedInventoryCallback : gameInventoryScriptCallback
	{
		private CWeakHandle<JournalNotificationQueue> _notificationQueue;
		private CWeakHandle<gameJournalManager> _journalManager;

		[Ordinal(1)] 
		[RED("notificationQueue")] 
		public CWeakHandle<JournalNotificationQueue> NotificationQueue
		{
			get => GetProperty(ref _notificationQueue);
			set => SetProperty(ref _notificationQueue, value);
		}

		[Ordinal(2)] 
		[RED("journalManager")] 
		public CWeakHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}
	}
}
