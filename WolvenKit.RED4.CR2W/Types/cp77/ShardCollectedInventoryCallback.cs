using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardCollectedInventoryCallback : gameInventoryScriptCallback
	{
		private wCHandle<JournalNotificationQueue> _notificationQueue;
		private wCHandle<gameJournalManager> _journalManager;

		[Ordinal(1)] 
		[RED("notificationQueue")] 
		public wCHandle<JournalNotificationQueue> NotificationQueue
		{
			get => GetProperty(ref _notificationQueue);
			set => SetProperty(ref _notificationQueue, value);
		}

		[Ordinal(2)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		public ShardCollectedInventoryCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
