using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OpenMessengerNotificationAction : GenericNotificationBaseAction
	{
		[Ordinal(0)] [RED("eventDispatcher")] public wCHandle<worlduiIWidgetGameController> EventDispatcher { get; set; }
		[Ordinal(1)] [RED("journalEntry")] public wCHandle<gameJournalEntry> JournalEntry { get; set; }

		public OpenMessengerNotificationAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
