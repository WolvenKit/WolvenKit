using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayRecordedSessionMenuGameController : PreGameSubMenuGameController
	{
		[Ordinal(0)]  [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }
		[Ordinal(1)]  [RED("recordsSelector")] public wCHandle<inkSelectorController> RecordsSelector { get; set; }
		[Ordinal(2)]  [RED("records")] public CArray<CString> Records { get; set; }

		public PlayRecordedSessionMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
