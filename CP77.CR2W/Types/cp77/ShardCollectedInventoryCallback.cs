using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ShardCollectedInventoryCallback : gameInventoryScriptCallback
	{
		[Ordinal(0)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(1)]  [RED("notificationQueue")] public CHandle<JournalNotificationQueue> NotificationQueue { get; set; }

		public ShardCollectedInventoryCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
