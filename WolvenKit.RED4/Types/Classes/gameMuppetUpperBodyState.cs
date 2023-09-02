using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetUpperBodyState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("currentWeapon")] 
		public gameItemID CurrentWeapon
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(1)] 
		[RED("wantedWeapon")] 
		public gameItemID WantedWeapon
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("inProgressWeapon")] 
		public gameItemID InProgressWeapon
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(3)] 
		[RED("logicWantedWeapon")] 
		public gameItemID LogicWantedWeapon
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(4)] 
		[RED("equippingTransitionTime")] 
		public CFloat EquippingTransitionTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("remainingShotTime")] 
		public CFloat RemainingShotTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("timeTillNextShootSeconds")] 
		public CFloat TimeTillNextShootSeconds
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("isAimingDownSight")] 
		public CBool IsAimingDownSight
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("currentWeaponAmmo")] 
		public CInt32 CurrentWeaponAmmo
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("currentWeaponAmmoCapacity")] 
		public CInt32 CurrentWeaponAmmoCapacity
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("isShooting")] 
		public CBool IsShooting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("weaponZoomLevel")] 
		public CFloat WeaponZoomLevel
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(12)] 
		[RED("weaponAimFOV")] 
		public CFloat WeaponAimFOV
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("remainingReloadTime")] 
		public CFloat RemainingReloadTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(14)] 
		[RED("remainingReloadCooldownTime")] 
		public CFloat RemainingReloadCooldownTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(15)] 
		[RED("shotsMade")] 
		public CUInt32 ShotsMade
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(16)] 
		[RED("isMeleeAttackInProgress")] 
		public CBool IsMeleeAttackInProgress
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("meleeAttacksMade")] 
		public CUInt32 MeleeAttacksMade
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(18)] 
		[RED("meleeAttackIndex")] 
		public CInt32 MeleeAttackIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("remainingMeleeAttackDuration")] 
		public CFloat RemainingMeleeAttackDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("selectedConsumable")] 
		public gameItemID SelectedConsumable
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(21)] 
		[RED("consumableInUse")] 
		public CBool ConsumableInUse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(22)] 
		[RED("consumableEffectApplied")] 
		public CBool ConsumableEffectApplied
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(23)] 
		[RED("consumableUseTimeStartup")] 
		public CFloat ConsumableUseTimeStartup
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("consumableUseTimeRecovery")] 
		public CFloat ConsumableUseTimeRecovery
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("remainingQuickMeleeTime")] 
		public CFloat RemainingQuickMeleeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("remainingQuickMeleeCooldownTime")] 
		public CFloat RemainingQuickMeleeCooldownTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameMuppetUpperBodyState()
		{
			CurrentWeapon = new gameItemID();
			WantedWeapon = new gameItemID();
			InProgressWeapon = new gameItemID();
			LogicWantedWeapon = new gameItemID();
			CurrentWeaponAmmo = 10;
			CurrentWeaponAmmoCapacity = 10;
			SelectedConsumable = new gameItemID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
