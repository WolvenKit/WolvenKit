using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StatsDetailListController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("StatLabelRef")] public inkTextWidgetReference StatLabelRef { get; set; }
		[Ordinal(1)]  [RED("statsList")] public inkCompoundWidgetReference StatsList { get; set; }

		public StatsDetailListController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
