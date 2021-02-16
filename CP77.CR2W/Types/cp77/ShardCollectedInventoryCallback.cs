using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ShardCollectedInventoryCallback : gameInventoryScriptCallback
	{
		[Ordinal(1)] [RED("notificationQueue")] public CHandle<JournalNotificationQueue> NotificationQueue { get; set; }
		[Ordinal(2)] [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }

		public ShardCollectedInventoryCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
