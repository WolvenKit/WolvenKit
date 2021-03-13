using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudJohnnyController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("tourHeader")] public inkTextWidgetReference TourHeader { get; set; }
		[Ordinal(10)] [RED("leftDates")] public inkTextWidgetReference LeftDates { get; set; }
		[Ordinal(11)] [RED("rightDates")] public inkTextWidgetReference RightDates { get; set; }
		[Ordinal(12)] [RED("cancelled")] public inkWidgetReference Cancelled { get; set; }
		[Ordinal(13)] [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }

		public hudJohnnyController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
