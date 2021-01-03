using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ProgramTooltipStatController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("arrow")] public inkImageWidgetReference Arrow { get; set; }
		[Ordinal(1)]  [RED("diffValue")] public inkTextWidgetReference DiffValue { get; set; }
		[Ordinal(2)]  [RED("value")] public inkTextWidgetReference Value { get; set; }

		public ProgramTooltipStatController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
