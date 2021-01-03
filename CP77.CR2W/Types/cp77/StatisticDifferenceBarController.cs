using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StatisticDifferenceBarController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("difference")] public inkWidgetReference Difference { get; set; }
		[Ordinal(1)]  [RED("empty")] public inkWidgetReference Empty { get; set; }
		[Ordinal(2)]  [RED("filled")] public inkWidgetReference Filled { get; set; }

		public StatisticDifferenceBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
