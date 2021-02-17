using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class weaponIndicatorController : gameuiHUDGameController
	{
		[Ordinal(9)] [RED("triggerModeControllers")] public CArray<CName> TriggerModeControllers { get; set; }
		[Ordinal(10)] [RED("ammoLogicControllers")] public CArray<CName> AmmoLogicControllers { get; set; }
		[Ordinal(11)] [RED("chargeLogicControllers")] public CArray<CName> ChargeLogicControllers { get; set; }
		[Ordinal(12)] [RED("triggerModeInstances")] public CArray<wCHandle<TriggerModeLogicController>> TriggerModeInstances { get; set; }
		[Ordinal(13)] [RED("ammoLogicInstances")] public CArray<wCHandle<AmmoLogicController>> AmmoLogicInstances { get; set; }
		[Ordinal(14)] [RED("chargeLogicInstances")] public CArray<wCHandle<ChargeLogicController>> ChargeLogicInstances { get; set; }
		[Ordinal(15)] [RED("bb")] public wCHandle<gameIBlackboard> Bb { get; set; }
		[Ordinal(16)] [RED("blackboard")] public wCHandle<gameIBlackboard> Blackboard { get; set; }
		[Ordinal(17)] [RED("onCharge")] public CUInt32 OnCharge { get; set; }
		[Ordinal(18)] [RED("onTriggerMode")] public CUInt32 OnTriggerMode { get; set; }
		[Ordinal(19)] [RED("onMagazineAmmoCount")] public CUInt32 OnMagazineAmmoCount { get; set; }
		[Ordinal(20)] [RED("onMagazineAmmoCapacity")] public CUInt32 OnMagazineAmmoCapacity { get; set; }
		[Ordinal(21)] [RED("BufferedRosterData")] public CHandle<gameSlotDataHolder> BufferedRosterData { get; set; }
		[Ordinal(22)] [RED("ActiveWeapon")] public gameSlotWeaponData ActiveWeapon { get; set; }
		[Ordinal(23)] [RED("InventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }

		public weaponIndicatorController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
