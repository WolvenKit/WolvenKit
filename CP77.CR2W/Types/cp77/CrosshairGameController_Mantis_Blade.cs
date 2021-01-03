using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Mantis_Blade : gameuiCrosshairBaseGameController
	{
		[Ordinal(0)]  [RED("aimAnim")] public CHandle<inkanimProxy> AimAnim { get; set; }
		[Ordinal(1)]  [RED("holdAnim")] public CHandle<inkanimProxy> HoldAnim { get; set; }
		[Ordinal(2)]  [RED("meleeWeaponState")] public CEnum<gamePSMMeleeWeapon> MeleeWeaponState { get; set; }
		[Ordinal(3)]  [RED("targetColorChange")] public inkWidgetReference TargetColorChange { get; set; }
		[Ordinal(4)]  [RED("weaponBBID")] public CUInt32 WeaponBBID { get; set; }
		[Ordinal(5)]  [RED("weaponLocalBB")] public CHandle<gameIBlackboard> WeaponLocalBB { get; set; }

		public CrosshairGameController_Mantis_Blade(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
