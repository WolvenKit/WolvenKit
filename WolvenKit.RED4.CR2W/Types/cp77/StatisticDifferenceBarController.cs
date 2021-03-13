using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatisticDifferenceBarController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("filled")] public inkWidgetReference Filled { get; set; }
		[Ordinal(2)] [RED("difference")] public inkWidgetReference Difference { get; set; }
		[Ordinal(3)] [RED("empty")] public inkWidgetReference Empty { get; set; }

		public StatisticDifferenceBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
