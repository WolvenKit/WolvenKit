using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BrowserGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(1)]  [RED("locationTags")] public CArray<CName> LocationTags { get; set; }
		[Ordinal(2)]  [RED("logicControllerRef")] public inkWidgetReference LogicControllerRef { get; set; }

		public BrowserGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
