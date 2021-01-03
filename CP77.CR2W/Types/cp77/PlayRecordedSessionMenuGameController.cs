using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayRecordedSessionMenuGameController : PreGameSubMenuGameController
	{
		[Ordinal(0)]  [RED("records")] public CArray<CString> Records { get; set; }
		[Ordinal(1)]  [RED("recordsSelector")] public wCHandle<inkSelectorController> RecordsSelector { get; set; }

		public PlayRecordedSessionMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
