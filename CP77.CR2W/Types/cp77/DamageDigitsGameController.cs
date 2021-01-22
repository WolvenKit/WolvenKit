using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DamageDigitsGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(0)]  [RED("ActiveWeapon")] public gameSlotWeaponData ActiveWeapon { get; set; }
		[Ordinal(1)]  [RED("BBWeaponListBlackboardId")] public CUInt32 BBWeaponListBlackboardId { get; set; }
		[Ordinal(2)]  [RED("BufferedRosterData")] public CHandle<gameSlotDataHolder> BufferedRosterData { get; set; }
		[Ordinal(3)]  [RED("UIBlackboard")] public CHandle<gameIBlackboard> UIBlackboard { get; set; }
		[Ordinal(4)]  [RED("accumulatedControllerArray")] public CArray<AccumulatedDamageDigitsNode> AccumulatedControllerArray { get; set; }
		[Ordinal(5)]  [RED("damageDigitsMode")] public CEnum<gameuiDamageDigitsMode> DamageDigitsMode { get; set; }
		[Ordinal(6)]  [RED("damageDigitsModeBlackboardId")] public CUInt32 DamageDigitsModeBlackboardId { get; set; }
		[Ordinal(7)]  [RED("damageDigitsStickingMode")] public CEnum<gameuiDamageDigitsStickingMode> DamageDigitsStickingMode { get; set; }
		[Ordinal(8)]  [RED("damageDigitsStickingModeBlackboardId")] public CUInt32 DamageDigitsStickingModeBlackboardId { get; set; }
		[Ordinal(9)]  [RED("damageInfoBB")] public CHandle<gameIBlackboard> DamageInfoBB { get; set; }
		[Ordinal(10)]  [RED("damageListBlackboardId")] public CUInt32 DamageListBlackboardId { get; set; }
		[Ordinal(11)]  [RED("digitsQueue")] public CHandle<inkScriptFIFOQueue> DigitsQueue { get; set; }
		[Ordinal(12)]  [RED("individualControllerArray")] public CArray<wCHandle<DamageDigitLogicController>> IndividualControllerArray { get; set; }
		[Ordinal(13)]  [RED("isBeingUsed")] public CBool IsBeingUsed { get; set; }
		[Ordinal(14)]  [RED("maxAccumulatedVisible")] public CInt32 MaxAccumulatedVisible { get; set; }
		[Ordinal(15)]  [RED("maxVisible")] public CInt32 MaxVisible { get; set; }
		[Ordinal(16)]  [RED("realOwner")] public wCHandle<gameObject> RealOwner { get; set; }
		[Ordinal(17)]  [RED("showDigitsAccumulated")] public CBool ShowDigitsAccumulated { get; set; }
		[Ordinal(18)]  [RED("showDigitsIndividual")] public CBool ShowDigitsIndividual { get; set; }

		public DamageDigitsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
