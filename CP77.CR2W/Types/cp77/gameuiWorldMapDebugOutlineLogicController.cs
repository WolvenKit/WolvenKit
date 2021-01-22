using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiWorldMapDebugOutlineLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("outlineWidget")] public inkShapeWidgetReference OutlineWidget { get; set; }

		public gameuiWorldMapDebugOutlineLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
