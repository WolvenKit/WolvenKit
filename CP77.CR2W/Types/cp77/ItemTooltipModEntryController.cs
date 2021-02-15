using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipModEntryController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("modName")] public inkTextWidgetReference ModName { get; set; }

		public ItemTooltipModEntryController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
