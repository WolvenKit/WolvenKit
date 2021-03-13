using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FastTravelGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("fastTravelPointsList")] public inkCompoundWidgetReference FastTravelPointsList { get; set; }
		[Ordinal(3)] [RED("menuEventDispatcher")] public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher { get; set; }

		public FastTravelGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
