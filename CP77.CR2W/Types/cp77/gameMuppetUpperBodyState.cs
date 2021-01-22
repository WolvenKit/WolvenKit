using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetUpperBodyState : CVariable
	{
		[Ordinal(0)]  [RED("consumableEffectApplied")] public CBool ConsumableEffectApplied { get; set; }
		[Ordinal(1)]  [RED("consumableInUse")] public CBool ConsumableInUse { get; set; }
		[Ordinal(2)]  [RED("consumableUseTimeRecovery")] public CFloat ConsumableUseTimeRecovery { get; set; }
		[Ordinal(3)]  [RED("consumableUseTimeStartup")] public CFloat ConsumableUseTimeStartup { get; set; }
		[Ordinal(4)]  [RED("currentWeapon")] public gameItemID CurrentWeapon { get; set; }
		[Ordinal(5)]  [RED("currentWeaponAmmo")] public CInt32 CurrentWeaponAmmo { get; set; }
		[Ordinal(6)]  [RED("currentWeaponAmmoCapacity")] public CInt32 CurrentWeaponAmmoCapacity { get; set; }
		[Ordinal(7)]  [RED("equippingTransitionTime")] public CFloat EquippingTransitionTime { get; set; }
		[Ordinal(8)]  [RED("inProgressWeapon")] public gameItemID InProgressWeapon { get; set; }
		[Ordinal(9)]  [RED("isAimingDownSight")] public CBool IsAimingDownSight { get; set; }
		[Ordinal(10)]  [RED("isMeleeAttackInProgress")] public CBool IsMeleeAttackInProgress { get; set; }
		[Ordinal(11)]  [RED("isShooting")] public CBool IsShooting { get; set; }
		[Ordinal(12)]  [RED("logicWantedWeapon")] public gameItemID LogicWantedWeapon { get; set; }
		[Ordinal(13)]  [RED("meleeAttackIndex")] public CInt32 MeleeAttackIndex { get; set; }
		[Ordinal(14)]  [RED("meleeAttacksMade")] public CUInt32 MeleeAttacksMade { get; set; }
		[Ordinal(15)]  [RED("remainingMeleeAttackDuration")] public CFloat RemainingMeleeAttackDuration { get; set; }
		[Ordinal(16)]  [RED("remainingQuickMeleeCooldownTime")] public CFloat RemainingQuickMeleeCooldownTime { get; set; }
		[Ordinal(17)]  [RED("remainingQuickMeleeTime")] public CFloat RemainingQuickMeleeTime { get; set; }
		[Ordinal(18)]  [RED("remainingReloadCooldownTime")] public CFloat RemainingReloadCooldownTime { get; set; }
		[Ordinal(19)]  [RED("remainingReloadTime")] public CFloat RemainingReloadTime { get; set; }
		[Ordinal(20)]  [RED("remainingShotTime")] public CFloat RemainingShotTime { get; set; }
		[Ordinal(21)]  [RED("selectedConsumable")] public gameItemID SelectedConsumable { get; set; }
		[Ordinal(22)]  [RED("shotsMade")] public CUInt32 ShotsMade { get; set; }
		[Ordinal(23)]  [RED("timeTillNextShootSeconds")] public CFloat TimeTillNextShootSeconds { get; set; }
		[Ordinal(24)]  [RED("wantedWeapon")] public gameItemID WantedWeapon { get; set; }
		[Ordinal(25)]  [RED("weaponAimFOV")] public CFloat WeaponAimFOV { get; set; }
		[Ordinal(26)]  [RED("weaponZoomLevel")] public CFloat WeaponZoomLevel { get; set; }

		public gameMuppetUpperBodyState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
