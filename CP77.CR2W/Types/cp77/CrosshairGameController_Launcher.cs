using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Launcher : gameuiCrosshairBaseGameController
	{
		[Ordinal(16)]  [RED("weaponLocalBB")] public CHandle<gameIBlackboard> WeaponLocalBB { get; set; }
		[Ordinal(17)]  [RED("weaponBBID")] public CUInt32 WeaponBBID { get; set; }
		[Ordinal(18)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(19)]  [RED("Cori_S")] public inkCanvasWidgetReference Cori_S { get; set; }
		[Ordinal(20)]  [RED("Cori_M")] public inkCanvasWidgetReference Cori_M { get; set; }
		[Ordinal(21)]  [RED("rightStickX")] public CFloat RightStickX { get; set; }
		[Ordinal(22)]  [RED("rightStickY")] public CFloat RightStickY { get; set; }

		public CrosshairGameController_Launcher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
