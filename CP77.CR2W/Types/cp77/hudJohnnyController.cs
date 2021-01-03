using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class hudJohnnyController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("cancelled")] public inkWidgetReference Cancelled { get; set; }
		[Ordinal(1)]  [RED("gameInstance")] public ScriptGameInstance GameInstance { get; set; }
		[Ordinal(2)]  [RED("leftDates")] public inkTextWidgetReference LeftDates { get; set; }
		[Ordinal(3)]  [RED("rightDates")] public inkTextWidgetReference RightDates { get; set; }
		[Ordinal(4)]  [RED("tourHeader")] public inkTextWidgetReference TourHeader { get; set; }

		public hudJohnnyController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
