using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ProgramTooltipStatController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("arrow")] public inkImageWidgetReference Arrow { get; set; }
		[Ordinal(2)] [RED("value")] public inkTextWidgetReference Value { get; set; }
		[Ordinal(3)] [RED("diffValue")] public inkTextWidgetReference DiffValue { get; set; }

		public ProgramTooltipStatController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
