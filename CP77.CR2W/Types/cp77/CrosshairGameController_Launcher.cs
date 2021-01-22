using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Launcher : gameuiCrosshairBaseGameController
	{
		[Ordinal(0)]  [RED("Cori_M")] public inkCanvasWidgetReference Cori_M { get; set; }
		[Ordinal(1)]  [RED("Cori_S")] public inkCanvasWidgetReference Cori_S { get; set; }
		[Ordinal(2)]  [RED("animationProxy")] public CHandle<inkanimProxy> AnimationProxy { get; set; }
		[Ordinal(3)]  [RED("rightStickX")] public CFloat RightStickX { get; set; }
		[Ordinal(4)]  [RED("rightStickY")] public CFloat RightStickY { get; set; }
		[Ordinal(5)]  [RED("weaponBBID")] public CUInt32 WeaponBBID { get; set; }
		[Ordinal(6)]  [RED("weaponLocalBB")] public CHandle<gameIBlackboard> WeaponLocalBB { get; set; }

		public CrosshairGameController_Launcher(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
