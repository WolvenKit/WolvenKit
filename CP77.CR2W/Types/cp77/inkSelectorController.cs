using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkSelectorController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("SelectionChanged")] public inkSelectionChangeCallback SelectionChanged { get; set; }
		[Ordinal(1)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(2)]  [RED("cycledNavigation")] public CBool CycledNavigation { get; set; }
		[Ordinal(3)]  [RED("values")] public CArray<CString> Values { get; set; }

		public inkSelectorController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
