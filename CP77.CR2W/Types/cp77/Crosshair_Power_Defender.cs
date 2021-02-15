using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Power_Defender : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] [RED("leftPart")] public inkWidgetReference LeftPart { get; set; }
		[Ordinal(19)] [RED("rightPart")] public inkWidgetReference RightPart { get; set; }
		[Ordinal(20)] [RED("topPart")] public inkWidgetReference TopPart { get; set; }
		[Ordinal(21)] [RED("botPart")] public inkWidgetReference BotPart { get; set; }

		public Crosshair_Power_Defender(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
