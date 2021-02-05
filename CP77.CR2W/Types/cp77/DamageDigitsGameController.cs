using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DamageDigitsGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(7)]  [RED("maxVisible")] public CInt32 MaxVisible { get; set; }
		[Ordinal(8)]  [RED("maxAccumulatedVisible")] public CInt32 MaxAccumulatedVisible { get; set; }
		[Ordinal(9)]  [RED("realOwner")] public wCHandle<gameObject> RealOwner { get; set; }
		[Ordinal(10)]  [RED("digitsQueue")] public CHandle<inkScriptFIFOQueue> DigitsQueue { get; set; }
		[Ordinal(11)]  [RED("isBeingUsed")] public CBool IsBeingUsed { get; set; }
		[Ordinal(12)]  [RED("ActiveWeapon")] public gameSlotWeaponData ActiveWeapon { get; set; }
		[Ordinal(13)]  [RED("BufferedRosterData")] public CHandle<gameSlotDataHolder> BufferedRosterData { get; set; }
		[Ordinal(14)]  [RED("individualControllerArray")] public CArray<wCHandle<DamageDigitLogicController>> IndividualControllerArray { get; set; }
		[Ordinal(15)]  [RED("accumulatedControllerArray")] public CArray<AccumulatedDamageDigitsNode> AccumulatedControllerArray { get; set; }
		[Ordinal(16)]  [RED("damageDigitsMode")] public CEnum<gameuiDamageDigitsMode> DamageDigitsMode { get; set; }
		[Ordinal(17)]  [RED("showDigitsIndividual")] public CBool ShowDigitsIndividual { get; set; }
		[Ordinal(18)]  [RED("showDigitsAccumulated")] public CBool ShowDigitsAccumulated { get; set; }
		[Ordinal(19)]  [RED("damageDigitsStickingMode")] public CEnum<gameuiDamageDigitsStickingMode> DamageDigitsStickingMode { get; set; }
		[Ordinal(20)]  [RED("damageInfoBB")] public wCHandle<gameIBlackboard> DamageInfoBB { get; set; }
		[Ordinal(21)]  [RED("UIBlackboard")] public wCHandle<gameIBlackboard> UIBlackboard { get; set; }
		[Ordinal(22)]  [RED("damageListBlackboardId")] public CUInt32 DamageListBlackboardId { get; set; }
		[Ordinal(23)]  [RED("BBWeaponListBlackboardId")] public CUInt32 BBWeaponListBlackboardId { get; set; }
		[Ordinal(24)]  [RED("damageDigitsModeBlackboardId")] public CUInt32 DamageDigitsModeBlackboardId { get; set; }
		[Ordinal(25)]  [RED("damageDigitsStickingModeBlackboardId")] public CUInt32 DamageDigitsStickingModeBlackboardId { get; set; }

		public DamageDigitsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
