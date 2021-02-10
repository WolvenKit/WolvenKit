using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AIShootingDataDef : AIBlackboardDef
	{
		[Ordinal(0)]  [RED("shootingPatternPackage")] public gamebbScriptID_Variant ShootingPatternPackage { get; set; }
		[Ordinal(1)]  [RED("shootingPattern")] public gamebbScriptID_Variant ShootingPattern { get; set; }
		[Ordinal(2)]  [RED("patternList")] public gamebbScriptID_Variant PatternList { get; set; }
		[Ordinal(3)]  [RED("rightArmLookAtLimitReached")] public gamebbScriptID_Int32 RightArmLookAtLimitReached { get; set; }
		[Ordinal(4)]  [RED("totalShotsFired")] public gamebbScriptID_Int32 TotalShotsFired { get; set; }
		[Ordinal(5)]  [RED("shotsInBurstFired")] public gamebbScriptID_Int32 ShotsInBurstFired { get; set; }
		[Ordinal(6)]  [RED("desiredNumberOfShots")] public gamebbScriptID_Int32 DesiredNumberOfShots { get; set; }
		[Ordinal(7)]  [RED("nextShotTimeStamp")] public gamebbScriptID_Float NextShotTimeStamp { get; set; }
		[Ordinal(8)]  [RED("shotTimeStamp")] public gamebbScriptID_Float ShotTimeStamp { get; set; }
		[Ordinal(9)]  [RED("maxChargedTimeStamp")] public gamebbScriptID_Float MaxChargedTimeStamp { get; set; }
		[Ordinal(10)]  [RED("chargeStartTimeStamp")] public gamebbScriptID_Float ChargeStartTimeStamp { get; set; }
		[Ordinal(11)]  [RED("fullyCharged")] public gamebbScriptID_Bool FullyCharged { get; set; }
		[Ordinal(12)]  [RED("weaponOverheated")] public gamebbScriptID_Bool WeaponOverheated { get; set; }
		[Ordinal(13)]  [RED("requestedTriggerMode")] public gamebbScriptID_Int32 RequestedTriggerMode { get; set; }

		public AIShootingDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
