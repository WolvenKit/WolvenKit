using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioPlayerWeaponSettings : audioWeaponSettings
	{
		[Ordinal(0)]  [RED("aimEnterSound")] public CName AimEnterSound { get; set; }
		[Ordinal(1)]  [RED("aimExitSound")] public CName AimExitSound { get; set; }
		[Ordinal(2)]  [RED("autoFireSound")] public CName AutoFireSound { get; set; }
		[Ordinal(3)]  [RED("autoFireStop")] public CName AutoFireStop { get; set; }
		[Ordinal(4)]  [RED("burstFireSound")] public CName BurstFireSound { get; set; }
		[Ordinal(5)]  [RED("dryFireSound")] public CName DryFireSound { get; set; }
		[Ordinal(6)]  [RED("fireSound")] public CName FireSound { get; set; }
		[Ordinal(7)]  [RED("initEvent")] public CName InitEvent { get; set; }
		[Ordinal(8)]  [RED("preFireSound")] public CName PreFireSound { get; set; }
		[Ordinal(9)]  [RED("quickMeleeHitEvent")] public CName QuickMeleeHitEvent { get; set; }
		[Ordinal(10)]  [RED("shellCasingsSettings")] public CName ShellCasingsSettings { get; set; }
		[Ordinal(11)]  [RED("shutdownEvent")] public CName ShutdownEvent { get; set; }
		[Ordinal(12)]  [RED("tails")] public CName Tails { get; set; }
		[Ordinal(13)]  [RED("timeLimitForAutoFireSingleShot")] public CFloat TimeLimitForAutoFireSingleShot { get; set; }
		[Ordinal(14)]  [RED("weaponTailOverrides")] public CHandle<audioWeaponTailOverrides> WeaponTailOverrides { get; set; }

		public audioPlayerWeaponSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
