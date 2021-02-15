using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TabButtonController : inkToggleController
	{
		[Ordinal(13)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(14)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(15)] [RED("data")] public CInt32 Data { get; set; }
		[Ordinal(16)] [RED("labelSet")] public CString LabelSet { get; set; }
		[Ordinal(17)] [RED("iconSet")] public CString IconSet { get; set; }

		public TabButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
