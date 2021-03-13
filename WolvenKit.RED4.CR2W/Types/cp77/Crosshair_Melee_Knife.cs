using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Melee_Knife : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] [RED("targetColorChange")] public inkWidgetReference TargetColorChange { get; set; }
		[Ordinal(19)] [RED("leftPart")] public inkWidgetReference LeftPart { get; set; }
		[Ordinal(20)] [RED("rightPart")] public inkWidgetReference RightPart { get; set; }
		[Ordinal(21)] [RED("topPart")] public inkWidgetReference TopPart { get; set; }
		[Ordinal(22)] [RED("botPart")] public inkWidgetReference BotPart { get; set; }

		public Crosshair_Melee_Knife(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
