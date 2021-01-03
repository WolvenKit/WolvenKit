using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIShootingDataDef : AIBlackboardDef
	{
		[Ordinal(0)]  [RED("chargeStartTimeStamp")] public gamebbScriptID_Float ChargeStartTimeStamp { get; set; }
		[Ordinal(1)]  [RED("desiredNumberOfShots")] public gamebbScriptID_Int32 DesiredNumberOfShots { get; set; }
		[Ordinal(2)]  [RED("fullyCharged")] public gamebbScriptID_Bool FullyCharged { get; set; }
		[Ordinal(3)]  [RED("maxChargedTimeStamp")] public gamebbScriptID_Float MaxChargedTimeStamp { get; set; }
		[Ordinal(4)]  [RED("nextShotTimeStamp")] public gamebbScriptID_Float NextShotTimeStamp { get; set; }
		[Ordinal(5)]  [RED("patternList")] public gamebbScriptID_Variant PatternList { get; set; }
		[Ordinal(6)]  [RED("requestedTriggerMode")] public gamebbScriptID_Int32 RequestedTriggerMode { get; set; }
		[Ordinal(7)]  [RED("rightArmLookAtLimitReached")] public gamebbScriptID_Int32 RightArmLookAtLimitReached { get; set; }
		[Ordinal(8)]  [RED("shootingPattern")] public gamebbScriptID_Variant ShootingPattern { get; set; }
		[Ordinal(9)]  [RED("shootingPatternPackage")] public gamebbScriptID_Variant ShootingPatternPackage { get; set; }
		[Ordinal(10)]  [RED("shotTimeStamp")] public gamebbScriptID_Float ShotTimeStamp { get; set; }
		[Ordinal(11)]  [RED("shotsInBurstFired")] public gamebbScriptID_Int32 ShotsInBurstFired { get; set; }
		[Ordinal(12)]  [RED("totalShotsFired")] public gamebbScriptID_Int32 TotalShotsFired { get; set; }
		[Ordinal(13)]  [RED("weaponOverheated")] public gamebbScriptID_Bool WeaponOverheated { get; set; }

		public AIShootingDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
