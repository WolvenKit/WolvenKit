using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class scannerBorderLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("braindanceSetHidden")] public CArray<inkWidgetReference> BraindanceSetHidden { get; set; }
		[Ordinal(1)]  [RED("braindanceSetVisible")] public CArray<inkWidgetReference> BraindanceSetVisible { get; set; }

		public scannerBorderLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
