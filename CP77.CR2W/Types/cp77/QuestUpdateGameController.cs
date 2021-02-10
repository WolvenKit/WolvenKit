using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuestUpdateGameController : gameuiHUDGameController
	{
		[Ordinal(7)]  [RED("header")] public inkTextWidgetReference Header { get; set; }
		[Ordinal(8)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(9)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(10)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(11)]  [RED("data")] public CHandle<QuestUpdateUserData> Data { get; set; }
		[Ordinal(12)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(13)]  [RED("journalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }

		public QuestUpdateGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
