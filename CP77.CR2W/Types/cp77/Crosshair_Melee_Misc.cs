using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Melee_Misc : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] [RED("targetColorChange")] public inkWidgetReference TargetColorChange { get; set; }

		public Crosshair_Melee_Misc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
