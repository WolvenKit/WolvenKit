using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuestUpdateGameController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(1)]  [RED("data")] public CHandle<QuestUpdateUserData> Data { get; set; }
		[Ordinal(2)]  [RED("header")] public inkTextWidgetReference Header { get; set; }
		[Ordinal(3)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(4)]  [RED("journalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }
		[Ordinal(5)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(6)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }

		public QuestUpdateGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
