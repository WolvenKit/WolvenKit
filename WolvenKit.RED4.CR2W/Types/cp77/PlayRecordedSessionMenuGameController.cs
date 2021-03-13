using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayRecordedSessionMenuGameController : PreGameSubMenuGameController
	{
		[Ordinal(3)] [RED("recordsSelector")] public wCHandle<inkSelectorController> RecordsSelector { get; set; }
		[Ordinal(4)] [RED("records")] public CArray<CString> Records { get; set; }

		public PlayRecordedSessionMenuGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
