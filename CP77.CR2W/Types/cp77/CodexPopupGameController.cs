using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CodexPopupGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("title")] public inkTextWidgetReference Title { get; set; }
		[Ordinal(3)] [RED("text")] public inkTextWidgetReference Text { get; set; }
		[Ordinal(4)] [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(5)] [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(6)] [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(7)] [RED("journalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }
		[Ordinal(8)] [RED("data")] public CHandle<CodexPopupData> Data { get; set; }

		public CodexPopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
