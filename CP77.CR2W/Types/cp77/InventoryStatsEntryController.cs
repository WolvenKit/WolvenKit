using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryStatsEntryController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("iconWidget")] public inkImageWidgetReference IconWidget { get; set; }
		[Ordinal(2)] [RED("labelWidget")] public inkTextWidgetReference LabelWidget { get; set; }
		[Ordinal(3)] [RED("valueWidget")] public inkTextWidgetReference ValueWidget { get; set; }

		public InventoryStatsEntryController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
