using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scannerBorderLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("braindanceSetHidden")] public CArray<inkWidgetReference> BraindanceSetHidden { get; set; }
		[Ordinal(1)]  [RED("braindanceSetVisible")] public CArray<inkWidgetReference> BraindanceSetVisible { get; set; }

		public scannerBorderLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
