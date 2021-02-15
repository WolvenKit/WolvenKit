using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioWeaponSettings : audioAudioMetadata
	{
		[Ordinal(1)] [RED("bulletType")] public CEnum<audioWeaponBulletType> BulletType { get; set; }
		[Ordinal(2)] [RED("shellCasingType")] public CEnum<audioWeaponShellCasingType> ShellCasingType { get; set; }
		[Ordinal(3)] [RED("weaponHandlingSettings")] public audioWeaponHandlingSettings WeaponHandlingSettings { get; set; }
		[Ordinal(4)] [RED("singleShotInSandevistan")] public CBool SingleShotInSandevistan { get; set; }
		[Ordinal(5)] [RED("chargeStartSound")] public CName ChargeStartSound { get; set; }
		[Ordinal(6)] [RED("chargeReadySound")] public CName ChargeReadySound { get; set; }
		[Ordinal(7)] [RED("chargeOverchargeSound")] public CName ChargeOverchargeSound { get; set; }
		[Ordinal(8)] [RED("chargeDischargeSound")] public CName ChargeDischargeSound { get; set; }
		[Ordinal(9)] [RED("fireModeSounds")] public audioWeaponFireModeSounds FireModeSounds { get; set; }

		public audioWeaponSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
