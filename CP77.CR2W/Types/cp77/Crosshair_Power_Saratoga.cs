using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Power_Saratoga : gameuiCrosshairBaseGameController
	{
		[Ordinal(16)]  [RED("leftPart")] public inkWidgetReference LeftPart { get; set; }
		[Ordinal(17)]  [RED("rightPart")] public inkWidgetReference RightPart { get; set; }
		[Ordinal(18)]  [RED("topPart")] public inkWidgetReference TopPart { get; set; }
		[Ordinal(19)]  [RED("botPart")] public inkWidgetReference BotPart { get; set; }

		public Crosshair_Power_Saratoga(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
