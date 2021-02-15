using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Mantis_Blade : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] [RED("weaponLocalBB")] public CHandle<gameIBlackboard> WeaponLocalBB { get; set; }
		[Ordinal(19)] [RED("weaponBBID")] public CUInt32 WeaponBBID { get; set; }
		[Ordinal(20)] [RED("meleeWeaponState")] public CEnum<gamePSMMeleeWeapon> MeleeWeaponState { get; set; }
		[Ordinal(21)] [RED("targetColorChange")] public inkWidgetReference TargetColorChange { get; set; }
		[Ordinal(22)] [RED("holdAnim")] public CHandle<inkanimProxy> HoldAnim { get; set; }
		[Ordinal(23)] [RED("aimAnim")] public CHandle<inkanimProxy> AimAnim { get; set; }

		public CrosshairGameController_Mantis_Blade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
