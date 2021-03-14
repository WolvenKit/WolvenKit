using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardCollectedInventoryCallback : gameInventoryScriptCallback
	{
		private CHandle<JournalNotificationQueue> _notificationQueue;
		private wCHandle<gameJournalManager> _journalManager;

		[Ordinal(1)] 
		[RED("notificationQueue")] 
		public CHandle<JournalNotificationQueue> NotificationQueue
		{
			get
			{
				if (_notificationQueue == null)
				{
					_notificationQueue = (CHandle<JournalNotificationQueue>) CR2WTypeManager.Create("handle:JournalNotificationQueue", "notificationQueue", cr2w, this);
				}
				return _notificationQueue;
			}
			set
			{
				if (_notificationQueue == value)
				{
					return;
				}
				_notificationQueue = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get
			{
				if (_journalManager == null)
				{
					_journalManager = (wCHandle<gameJournalManager>) CR2WTypeManager.Create("whandle:gameJournalManager", "journalManager", cr2w, this);
				}
				return _journalManager;
			}
			set
			{
				if (_journalManager == value)
				{
					return;
				}
				_journalManager = value;
				PropertySet(this);
			}
		}

		public ShardCollectedInventoryCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
