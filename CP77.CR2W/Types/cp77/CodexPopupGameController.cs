using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CodexPopupGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("buttonHintsManagerRef")] public inkWidgetReference ButtonHintsManagerRef { get; set; }
		[Ordinal(1)]  [RED("data")] public CHandle<CodexPopupData> Data { get; set; }
		[Ordinal(2)]  [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(3)]  [RED("journalMgr")] public wCHandle<gameJournalManager> JournalMgr { get; set; }
		[Ordinal(4)]  [RED("player")] public wCHandle<gameObject> Player { get; set; }
		[Ordinal(5)]  [RED("text")] public inkTextWidgetReference Text { get; set; }
		[Ordinal(6)]  [RED("title")] public inkTextWidgetReference Title { get; set; }

		public CodexPopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
