using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DebugTextDrawer : gameObject
	{
		[Ordinal(31)]  [RED("text")] public CString Text { get; set; }
		[Ordinal(32)]  [RED("color")] public CColor Color { get; set; }

		public DebugTextDrawer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
