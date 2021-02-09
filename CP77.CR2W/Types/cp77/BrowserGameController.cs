using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BrowserGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("logicControllerRef")] public inkWidgetReference LogicControllerRef { get; set; }
		[Ordinal(1)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(2)]  [RED("locationTags")] public CArray<CName> LocationTags { get; set; }

		public BrowserGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
