using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class weaponIndicatorController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("showAnimDef")] public CHandle<inkanimDefinition> ShowAnimDef { get; set; }
		[Ordinal(1)]  [RED("hideAnimDef")] public CHandle<inkanimDefinition> HideAnimDef { get; set; }
		[Ordinal(2)]  [RED("showAnimationName")] public CName ShowAnimationName { get; set; }
		[Ordinal(3)]  [RED("hideAnimationName")] public CName HideAnimationName { get; set; }
		[Ordinal(4)]  [RED("moduleShown")] public CBool ModuleShown { get; set; }
		[Ordinal(5)]  [RED("showAnimProxy")] public CHandle<inkanimProxy> ShowAnimProxy { get; set; }
		[Ordinal(6)]  [RED("hideAnimProxy")] public CHandle<inkanimProxy> HideAnimProxy { get; set; }
		[Ordinal(7)]  [RED("triggerModeControllers")] public CArray<CName> TriggerModeControllers { get; set; }
		[Ordinal(8)]  [RED("ammoLogicControllers")] public CArray<CName> AmmoLogicControllers { get; set; }
		[Ordinal(9)]  [RED("chargeLogicControllers")] public CArray<CName> ChargeLogicControllers { get; set; }
		[Ordinal(10)]  [RED("triggerModeInstances")] public CArray<wCHandle<TriggerModeLogicController>> TriggerModeInstances { get; set; }
		[Ordinal(11)]  [RED("ammoLogicInstances")] public CArray<wCHandle<AmmoLogicController>> AmmoLogicInstances { get; set; }
		[Ordinal(12)]  [RED("chargeLogicInstances")] public CArray<wCHandle<ChargeLogicController>> ChargeLogicInstances { get; set; }
		[Ordinal(13)]  [RED("bb")] public wCHandle<gameIBlackboard> Bb { get; set; }
		[Ordinal(14)]  [RED("blackboard")] public wCHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(15)]  [RED("onCharge")] public CUInt32 OnCharge { get; set; }
		[Ordinal(16)]  [RED("onTriggerMode")] public CUInt32 OnTriggerMode { get; set; }
		[Ordinal(17)]  [RED("onMagazineAmmoCount")] public CUInt32 OnMagazineAmmoCount { get; set; }
		[Ordinal(18)]  [RED("onMagazineAmmoCapacity")] public CUInt32 OnMagazineAmmoCapacity { get; set; }
		[Ordinal(19)]  [RED("BufferedRosterData")] public CHandle<gameSlotDataHolder> BufferedRosterData { get; set; }
		[Ordinal(20)]  [RED("ActiveWeapon")] public gameSlotWeaponData ActiveWeapon { get; set; }
		[Ordinal(21)]  [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }

		public weaponIndicatorController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
