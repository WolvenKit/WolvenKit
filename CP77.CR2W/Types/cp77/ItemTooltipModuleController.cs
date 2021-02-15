using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipModuleController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("lineWidget")] public inkWidgetReference LineWidget { get; set; }

		public ItemTooltipModuleController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
