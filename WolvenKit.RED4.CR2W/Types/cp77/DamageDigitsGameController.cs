using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageDigitsGameController : gameuiProjectedHUDGameController
	{
		[Ordinal(9)] [RED("maxVisible")] public CInt32 MaxVisible { get; set; }
		[Ordinal(10)] [RED("maxAccumulatedVisible")] public CInt32 MaxAccumulatedVisible { get; set; }
		[Ordinal(11)] [RED("realOwner")] public wCHandle<gameObject> RealOwner { get; set; }
		[Ordinal(12)] [RED("digitsQueue")] public CHandle<inkScriptFIFOQueue> DigitsQueue { get; set; }
		[Ordinal(13)] [RED("isBeingUsed")] public CBool IsBeingUsed { get; set; }
		[Ordinal(14)] [RED("ActiveWeapon")] public gameSlotWeaponData ActiveWeapon { get; set; }
		[Ordinal(15)] [RED("BufferedRosterData")] public CHandle<gameSlotDataHolder> BufferedRosterData { get; set; }
		[Ordinal(16)] [RED("individualControllerArray")] public CArray<wCHandle<DamageDigitLogicController>> IndividualControllerArray { get; set; }
		[Ordinal(17)] [RED("accumulatedControllerArray")] public CArray<AccumulatedDamageDigitsNode> AccumulatedControllerArray { get; set; }
		[Ordinal(18)] [RED("damageDigitsMode")] public CEnum<gameuiDamageDigitsMode> DamageDigitsMode { get; set; }
		[Ordinal(19)] [RED("showDigitsIndividual")] public CBool ShowDigitsIndividual { get; set; }
		[Ordinal(20)] [RED("showDigitsAccumulated")] public CBool ShowDigitsAccumulated { get; set; }
		[Ordinal(21)] [RED("damageDigitsStickingMode")] public CEnum<gameuiDamageDigitsStickingMode> DamageDigitsStickingMode { get; set; }
		[Ordinal(22)] [RED("damageInfoBB")] public wCHandle<gameIBlackboard> DamageInfoBB { get; set; }
		[Ordinal(23)] [RED("UIBlackboard")] public wCHandle<gameIBlackboard> UIBlackboard { get; set; }
		[Ordinal(24)] [RED("damageListBlackboardId")] public CUInt32 DamageListBlackboardId { get; set; }
		[Ordinal(25)] [RED("BBWeaponListBlackboardId")] public CUInt32 BBWeaponListBlackboardId { get; set; }
		[Ordinal(26)] [RED("damageDigitsModeBlackboardId")] public CUInt32 DamageDigitsModeBlackboardId { get; set; }
		[Ordinal(27)] [RED("damageDigitsStickingModeBlackboardId")] public CUInt32 DamageDigitsStickingModeBlackboardId { get; set; }

		public DamageDigitsGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
