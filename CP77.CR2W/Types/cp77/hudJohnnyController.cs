using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class hudJohnnyController : gameuiHUDGameController
	{
		[Ordinal(7)]  [RED("tourHeader")] public inkTextWidgetReference TourHeader { get; set; }
		[Ordinal(8)]  [RED("leftDates")] public inkTextWidgetReference LeftDates { get; set; }
		[Ordinal(9)]  [RED("rightDates")] public inkTextWidgetReference RightDates { get; set; }
		[Ordinal(10)]  [RED("cancelled")] public inkWidgetReference Cancelled { get; set; }
		[Ordinal(11)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }

		public hudJohnnyController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
