using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BrowserGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("logicControllerRef")] public inkWidgetReference LogicControllerRef { get; set; }
		[Ordinal(3)] [RED("journalManager")] public wCHandle<gameJournalManager> JournalManager { get; set; }
		[Ordinal(4)] [RED("locationTags")] public CArray<CName> LocationTags { get; set; }

		public BrowserGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
