using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestContactLinkController : BaseCodexLinkController
	{
		[Ordinal(4)] [RED("msgLabel")] public inkTextWidgetReference MsgLabel { get; set; }
		[Ordinal(5)] [RED("msgContainer")] public inkWidgetReference MsgContainer { get; set; }
		[Ordinal(6)] [RED("msgCounter")] public CInt32 MsgCounter { get; set; }
		[Ordinal(7)] [RED("contactEntry")] public CHandle<gameJournalContact> ContactEntry { get; set; }
		[Ordinal(8)] [RED("journalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }
		[Ordinal(9)] [RED("phoneSystem")] public wCHandle<PhoneSystem> PhoneSystem { get; set; }

		public QuestContactLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
