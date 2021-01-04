using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemRandomizedStatsController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("statName")] public inkTextWidgetReference StatName { get; set; }

		public ItemRandomizedStatsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
