using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTimeDisplayLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("timerText")] public inkTextWidgetReference TimerText { get; set; }
		[Ordinal(2)] [RED("noConnectionText")] public inkTextWidgetReference NoConnectionText { get; set; }

		public gameuiTimeDisplayLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
