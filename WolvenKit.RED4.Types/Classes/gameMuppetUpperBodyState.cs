using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetUpperBodyState : RedBaseClass
	{
		private gameItemID _currentWeapon;
		private gameItemID _wantedWeapon;
		private gameItemID _inProgressWeapon;
		private gameItemID _logicWantedWeapon;
		private CFloat _equippingTransitionTime;
		private CFloat _remainingShotTime;
		private CFloat _timeTillNextShootSeconds;
		private CBool _isAimingDownSight;
		private CInt32 _currentWeaponAmmo;
		private CInt32 _currentWeaponAmmoCapacity;
		private CBool _isShooting;
		private CFloat _weaponZoomLevel;
		private CFloat _weaponAimFOV;
		private CFloat _remainingReloadTime;
		private CFloat _remainingReloadCooldownTime;
		private CUInt32 _shotsMade;
		private CBool _isMeleeAttackInProgress;
		private CUInt32 _meleeAttacksMade;
		private CInt32 _meleeAttackIndex;
		private CFloat _remainingMeleeAttackDuration;
		private gameItemID _selectedConsumable;
		private CBool _consumableInUse;
		private CBool _consumableEffectApplied;
		private CFloat _consumableUseTimeStartup;
		private CFloat _consumableUseTimeRecovery;
		private CFloat _remainingQuickMeleeTime;
		private CFloat _remainingQuickMeleeCooldownTime;

		[Ordinal(0)] 
		[RED("currentWeapon")] 
		public gameItemID CurrentWeapon
		{
			get => GetProperty(ref _currentWeapon);
			set => SetProperty(ref _currentWeapon, value);
		}

		[Ordinal(1)] 
		[RED("wantedWeapon")] 
		public gameItemID WantedWeapon
		{
			get => GetProperty(ref _wantedWeapon);
			set => SetProperty(ref _wantedWeapon, value);
		}

		[Ordinal(2)] 
		[RED("inProgressWeapon")] 
		public gameItemID InProgressWeapon
		{
			get => GetProperty(ref _inProgressWeapon);
			set => SetProperty(ref _inProgressWeapon, value);
		}

		[Ordinal(3)] 
		[RED("logicWantedWeapon")] 
		public gameItemID LogicWantedWeapon
		{
			get => GetProperty(ref _logicWantedWeapon);
			set => SetProperty(ref _logicWantedWeapon, value);
		}

		[Ordinal(4)] 
		[RED("equippingTransitionTime")] 
		public CFloat EquippingTransitionTime
		{
			get => GetProperty(ref _equippingTransitionTime);
			set => SetProperty(ref _equippingTransitionTime, value);
		}

		[Ordinal(5)] 
		[RED("remainingShotTime")] 
		public CFloat RemainingShotTime
		{
			get => GetProperty(ref _remainingShotTime);
			set => SetProperty(ref _remainingShotTime, value);
		}

		[Ordinal(6)] 
		[RED("timeTillNextShootSeconds")] 
		public CFloat TimeTillNextShootSeconds
		{
			get => GetProperty(ref _timeTillNextShootSeconds);
			set => SetProperty(ref _timeTillNextShootSeconds, value);
		}

		[Ordinal(7)] 
		[RED("isAimingDownSight")] 
		public CBool IsAimingDownSight
		{
			get => GetProperty(ref _isAimingDownSight);
			set => SetProperty(ref _isAimingDownSight, value);
		}

		[Ordinal(8)] 
		[RED("currentWeaponAmmo")] 
		public CInt32 CurrentWeaponAmmo
		{
			get => GetProperty(ref _currentWeaponAmmo);
			set => SetProperty(ref _currentWeaponAmmo, value);
		}

		[Ordinal(9)] 
		[RED("currentWeaponAmmoCapacity")] 
		public CInt32 CurrentWeaponAmmoCapacity
		{
			get => GetProperty(ref _currentWeaponAmmoCapacity);
			set => SetProperty(ref _currentWeaponAmmoCapacity, value);
		}

		[Ordinal(10)] 
		[RED("isShooting")] 
		public CBool IsShooting
		{
			get => GetProperty(ref _isShooting);
			set => SetProperty(ref _isShooting, value);
		}

		[Ordinal(11)] 
		[RED("weaponZoomLevel")] 
		public CFloat WeaponZoomLevel
		{
			get => GetProperty(ref _weaponZoomLevel);
			set => SetProperty(ref _weaponZoomLevel, value);
		}

		[Ordinal(12)] 
		[RED("weaponAimFOV")] 
		public CFloat WeaponAimFOV
		{
			get => GetProperty(ref _weaponAimFOV);
			set => SetProperty(ref _weaponAimFOV, value);
		}

		[Ordinal(13)] 
		[RED("remainingReloadTime")] 
		public CFloat RemainingReloadTime
		{
			get => GetProperty(ref _remainingReloadTime);
			set => SetProperty(ref _remainingReloadTime, value);
		}

		[Ordinal(14)] 
		[RED("remainingReloadCooldownTime")] 
		public CFloat RemainingReloadCooldownTime
		{
			get => GetProperty(ref _remainingReloadCooldownTime);
			set => SetProperty(ref _remainingReloadCooldownTime, value);
		}

		[Ordinal(15)] 
		[RED("shotsMade")] 
		public CUInt32 ShotsMade
		{
			get => GetProperty(ref _shotsMade);
			set => SetProperty(ref _shotsMade, value);
		}

		[Ordinal(16)] 
		[RED("isMeleeAttackInProgress")] 
		public CBool IsMeleeAttackInProgress
		{
			get => GetProperty(ref _isMeleeAttackInProgress);
			set => SetProperty(ref _isMeleeAttackInProgress, value);
		}

		[Ordinal(17)] 
		[RED("meleeAttacksMade")] 
		public CUInt32 MeleeAttacksMade
		{
			get => GetProperty(ref _meleeAttacksMade);
			set => SetProperty(ref _meleeAttacksMade, value);
		}

		[Ordinal(18)] 
		[RED("meleeAttackIndex")] 
		public CInt32 MeleeAttackIndex
		{
			get => GetProperty(ref _meleeAttackIndex);
			set => SetProperty(ref _meleeAttackIndex, value);
		}

		[Ordinal(19)] 
		[RED("remainingMeleeAttackDuration")] 
		public CFloat RemainingMeleeAttackDuration
		{
			get => GetProperty(ref _remainingMeleeAttackDuration);
			set => SetProperty(ref _remainingMeleeAttackDuration, value);
		}

		[Ordinal(20)] 
		[RED("selectedConsumable")] 
		public gameItemID SelectedConsumable
		{
			get => GetProperty(ref _selectedConsumable);
			set => SetProperty(ref _selectedConsumable, value);
		}

		[Ordinal(21)] 
		[RED("consumableInUse")] 
		public CBool ConsumableInUse
		{
			get => GetProperty(ref _consumableInUse);
			set => SetProperty(ref _consumableInUse, value);
		}

		[Ordinal(22)] 
		[RED("consumableEffectApplied")] 
		public CBool ConsumableEffectApplied
		{
			get => GetProperty(ref _consumableEffectApplied);
			set => SetProperty(ref _consumableEffectApplied, value);
		}

		[Ordinal(23)] 
		[RED("consumableUseTimeStartup")] 
		public CFloat ConsumableUseTimeStartup
		{
			get => GetProperty(ref _consumableUseTimeStartup);
			set => SetProperty(ref _consumableUseTimeStartup, value);
		}

		[Ordinal(24)] 
		[RED("consumableUseTimeRecovery")] 
		public CFloat ConsumableUseTimeRecovery
		{
			get => GetProperty(ref _consumableUseTimeRecovery);
			set => SetProperty(ref _consumableUseTimeRecovery, value);
		}

		[Ordinal(25)] 
		[RED("remainingQuickMeleeTime")] 
		public CFloat RemainingQuickMeleeTime
		{
			get => GetProperty(ref _remainingQuickMeleeTime);
			set => SetProperty(ref _remainingQuickMeleeTime, value);
		}

		[Ordinal(26)] 
		[RED("remainingQuickMeleeCooldownTime")] 
		public CFloat RemainingQuickMeleeCooldownTime
		{
			get => GetProperty(ref _remainingQuickMeleeCooldownTime);
			set => SetProperty(ref _remainingQuickMeleeCooldownTime, value);
		}
	}
}
