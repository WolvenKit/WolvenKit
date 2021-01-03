using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Melee_Misc : gameuiCrosshairBaseGameController
	{
		[Ordinal(0)]  [RED("targetColorChange")] public inkWidgetReference TargetColorChange { get; set; }

		public Crosshair_Melee_Misc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
