using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioPlayerWeaponSettings : audioWeaponSettings
	{
		[Ordinal(10)] [RED("fireSound")] public CName FireSound { get; set; }
		[Ordinal(11)] [RED("preFireSound")] public CName PreFireSound { get; set; }
		[Ordinal(12)] [RED("burstFireSound")] public CName BurstFireSound { get; set; }
		[Ordinal(13)] [RED("autoFireSound")] public CName AutoFireSound { get; set; }
		[Ordinal(14)] [RED("autoFireStop")] public CName AutoFireStop { get; set; }
		[Ordinal(15)] [RED("timeLimitForAutoFireSingleShot")] public CFloat TimeLimitForAutoFireSingleShot { get; set; }
		[Ordinal(16)] [RED("tails")] public CName Tails { get; set; }
		[Ordinal(17)] [RED("shellCasingsSettings")] public CName ShellCasingsSettings { get; set; }
		[Ordinal(18)] [RED("weaponTailOverrides")] public CHandle<audioWeaponTailOverrides> WeaponTailOverrides { get; set; }
		[Ordinal(19)] [RED("quickMeleeHitEvent")] public CName QuickMeleeHitEvent { get; set; }
		[Ordinal(20)] [RED("initEvent")] public CName InitEvent { get; set; }
		[Ordinal(21)] [RED("shutdownEvent")] public CName ShutdownEvent { get; set; }
		[Ordinal(22)] [RED("aimEnterSound")] public CName AimEnterSound { get; set; }
		[Ordinal(23)] [RED("aimExitSound")] public CName AimExitSound { get; set; }
		[Ordinal(24)] [RED("dryFireSound")] public CName DryFireSound { get; set; }

		public audioPlayerWeaponSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
