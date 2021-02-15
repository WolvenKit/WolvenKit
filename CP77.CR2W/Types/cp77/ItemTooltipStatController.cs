using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipStatController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("statName")] public inkTextWidgetReference StatName { get; set; }
		[Ordinal(2)] [RED("statValue")] public inkTextWidgetReference StatValue { get; set; }
		[Ordinal(3)] [RED("statComparedContainer")] public inkWidgetReference StatComparedContainer { get; set; }
		[Ordinal(4)] [RED("statComparedValue")] public inkTextWidgetReference StatComparedValue { get; set; }
		[Ordinal(5)] [RED("arrow")] public inkImageWidgetReference Arrow { get; set; }

		public ItemTooltipStatController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
