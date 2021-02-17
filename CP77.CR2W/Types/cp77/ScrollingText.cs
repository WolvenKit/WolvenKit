using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ScrollingText : CVariable
	{
		[Ordinal(0)] [RED("textArray")] public CArray<CString> TextArray { get; set; }

		public ScrollingText(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
