using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StatsDetailListController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("StatLabelRef")] public inkTextWidgetReference StatLabelRef { get; set; }
		[Ordinal(1)]  [RED("statsList")] public inkCompoundWidgetReference StatsList { get; set; }

		public StatsDetailListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
