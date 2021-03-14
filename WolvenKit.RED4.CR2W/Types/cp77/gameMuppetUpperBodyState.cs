using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetUpperBodyState : CVariable
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
			get
			{
				if (_currentWeapon == null)
				{
					_currentWeapon = (gameItemID) CR2WTypeManager.Create("gameItemID", "currentWeapon", cr2w, this);
				}
				return _currentWeapon;
			}
			set
			{
				if (_currentWeapon == value)
				{
					return;
				}
				_currentWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("wantedWeapon")] 
		public gameItemID WantedWeapon
		{
			get
			{
				if (_wantedWeapon == null)
				{
					_wantedWeapon = (gameItemID) CR2WTypeManager.Create("gameItemID", "wantedWeapon", cr2w, this);
				}
				return _wantedWeapon;
			}
			set
			{
				if (_wantedWeapon == value)
				{
					return;
				}
				_wantedWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("inProgressWeapon")] 
		public gameItemID InProgressWeapon
		{
			get
			{
				if (_inProgressWeapon == null)
				{
					_inProgressWeapon = (gameItemID) CR2WTypeManager.Create("gameItemID", "inProgressWeapon", cr2w, this);
				}
				return _inProgressWeapon;
			}
			set
			{
				if (_inProgressWeapon == value)
				{
					return;
				}
				_inProgressWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("logicWantedWeapon")] 
		public gameItemID LogicWantedWeapon
		{
			get
			{
				if (_logicWantedWeapon == null)
				{
					_logicWantedWeapon = (gameItemID) CR2WTypeManager.Create("gameItemID", "logicWantedWeapon", cr2w, this);
				}
				return _logicWantedWeapon;
			}
			set
			{
				if (_logicWantedWeapon == value)
				{
					return;
				}
				_logicWantedWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("equippingTransitionTime")] 
		public CFloat EquippingTransitionTime
		{
			get
			{
				if (_equippingTransitionTime == null)
				{
					_equippingTransitionTime = (CFloat) CR2WTypeManager.Create("Float", "equippingTransitionTime", cr2w, this);
				}
				return _equippingTransitionTime;
			}
			set
			{
				if (_equippingTransitionTime == value)
				{
					return;
				}
				_equippingTransitionTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("remainingShotTime")] 
		public CFloat RemainingShotTime
		{
			get
			{
				if (_remainingShotTime == null)
				{
					_remainingShotTime = (CFloat) CR2WTypeManager.Create("Float", "remainingShotTime", cr2w, this);
				}
				return _remainingShotTime;
			}
			set
			{
				if (_remainingShotTime == value)
				{
					return;
				}
				_remainingShotTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("timeTillNextShootSeconds")] 
		public CFloat TimeTillNextShootSeconds
		{
			get
			{
				if (_timeTillNextShootSeconds == null)
				{
					_timeTillNextShootSeconds = (CFloat) CR2WTypeManager.Create("Float", "timeTillNextShootSeconds", cr2w, this);
				}
				return _timeTillNextShootSeconds;
			}
			set
			{
				if (_timeTillNextShootSeconds == value)
				{
					return;
				}
				_timeTillNextShootSeconds = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isAimingDownSight")] 
		public CBool IsAimingDownSight
		{
			get
			{
				if (_isAimingDownSight == null)
				{
					_isAimingDownSight = (CBool) CR2WTypeManager.Create("Bool", "isAimingDownSight", cr2w, this);
				}
				return _isAimingDownSight;
			}
			set
			{
				if (_isAimingDownSight == value)
				{
					return;
				}
				_isAimingDownSight = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("currentWeaponAmmo")] 
		public CInt32 CurrentWeaponAmmo
		{
			get
			{
				if (_currentWeaponAmmo == null)
				{
					_currentWeaponAmmo = (CInt32) CR2WTypeManager.Create("Int32", "currentWeaponAmmo", cr2w, this);
				}
				return _currentWeaponAmmo;
			}
			set
			{
				if (_currentWeaponAmmo == value)
				{
					return;
				}
				_currentWeaponAmmo = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("currentWeaponAmmoCapacity")] 
		public CInt32 CurrentWeaponAmmoCapacity
		{
			get
			{
				if (_currentWeaponAmmoCapacity == null)
				{
					_currentWeaponAmmoCapacity = (CInt32) CR2WTypeManager.Create("Int32", "currentWeaponAmmoCapacity", cr2w, this);
				}
				return _currentWeaponAmmoCapacity;
			}
			set
			{
				if (_currentWeaponAmmoCapacity == value)
				{
					return;
				}
				_currentWeaponAmmoCapacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isShooting")] 
		public CBool IsShooting
		{
			get
			{
				if (_isShooting == null)
				{
					_isShooting = (CBool) CR2WTypeManager.Create("Bool", "isShooting", cr2w, this);
				}
				return _isShooting;
			}
			set
			{
				if (_isShooting == value)
				{
					return;
				}
				_isShooting = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("weaponZoomLevel")] 
		public CFloat WeaponZoomLevel
		{
			get
			{
				if (_weaponZoomLevel == null)
				{
					_weaponZoomLevel = (CFloat) CR2WTypeManager.Create("Float", "weaponZoomLevel", cr2w, this);
				}
				return _weaponZoomLevel;
			}
			set
			{
				if (_weaponZoomLevel == value)
				{
					return;
				}
				_weaponZoomLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("weaponAimFOV")] 
		public CFloat WeaponAimFOV
		{
			get
			{
				if (_weaponAimFOV == null)
				{
					_weaponAimFOV = (CFloat) CR2WTypeManager.Create("Float", "weaponAimFOV", cr2w, this);
				}
				return _weaponAimFOV;
			}
			set
			{
				if (_weaponAimFOV == value)
				{
					return;
				}
				_weaponAimFOV = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("remainingReloadTime")] 
		public CFloat RemainingReloadTime
		{
			get
			{
				if (_remainingReloadTime == null)
				{
					_remainingReloadTime = (CFloat) CR2WTypeManager.Create("Float", "remainingReloadTime", cr2w, this);
				}
				return _remainingReloadTime;
			}
			set
			{
				if (_remainingReloadTime == value)
				{
					return;
				}
				_remainingReloadTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("remainingReloadCooldownTime")] 
		public CFloat RemainingReloadCooldownTime
		{
			get
			{
				if (_remainingReloadCooldownTime == null)
				{
					_remainingReloadCooldownTime = (CFloat) CR2WTypeManager.Create("Float", "remainingReloadCooldownTime", cr2w, this);
				}
				return _remainingReloadCooldownTime;
			}
			set
			{
				if (_remainingReloadCooldownTime == value)
				{
					return;
				}
				_remainingReloadCooldownTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("shotsMade")] 
		public CUInt32 ShotsMade
		{
			get
			{
				if (_shotsMade == null)
				{
					_shotsMade = (CUInt32) CR2WTypeManager.Create("Uint32", "shotsMade", cr2w, this);
				}
				return _shotsMade;
			}
			set
			{
				if (_shotsMade == value)
				{
					return;
				}
				_shotsMade = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("isMeleeAttackInProgress")] 
		public CBool IsMeleeAttackInProgress
		{
			get
			{
				if (_isMeleeAttackInProgress == null)
				{
					_isMeleeAttackInProgress = (CBool) CR2WTypeManager.Create("Bool", "isMeleeAttackInProgress", cr2w, this);
				}
				return _isMeleeAttackInProgress;
			}
			set
			{
				if (_isMeleeAttackInProgress == value)
				{
					return;
				}
				_isMeleeAttackInProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("meleeAttacksMade")] 
		public CUInt32 MeleeAttacksMade
		{
			get
			{
				if (_meleeAttacksMade == null)
				{
					_meleeAttacksMade = (CUInt32) CR2WTypeManager.Create("Uint32", "meleeAttacksMade", cr2w, this);
				}
				return _meleeAttacksMade;
			}
			set
			{
				if (_meleeAttacksMade == value)
				{
					return;
				}
				_meleeAttacksMade = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("meleeAttackIndex")] 
		public CInt32 MeleeAttackIndex
		{
			get
			{
				if (_meleeAttackIndex == null)
				{
					_meleeAttackIndex = (CInt32) CR2WTypeManager.Create("Int32", "meleeAttackIndex", cr2w, this);
				}
				return _meleeAttackIndex;
			}
			set
			{
				if (_meleeAttackIndex == value)
				{
					return;
				}
				_meleeAttackIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("remainingMeleeAttackDuration")] 
		public CFloat RemainingMeleeAttackDuration
		{
			get
			{
				if (_remainingMeleeAttackDuration == null)
				{
					_remainingMeleeAttackDuration = (CFloat) CR2WTypeManager.Create("Float", "remainingMeleeAttackDuration", cr2w, this);
				}
				return _remainingMeleeAttackDuration;
			}
			set
			{
				if (_remainingMeleeAttackDuration == value)
				{
					return;
				}
				_remainingMeleeAttackDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("selectedConsumable")] 
		public gameItemID SelectedConsumable
		{
			get
			{
				if (_selectedConsumable == null)
				{
					_selectedConsumable = (gameItemID) CR2WTypeManager.Create("gameItemID", "selectedConsumable", cr2w, this);
				}
				return _selectedConsumable;
			}
			set
			{
				if (_selectedConsumable == value)
				{
					return;
				}
				_selectedConsumable = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("consumableInUse")] 
		public CBool ConsumableInUse
		{
			get
			{
				if (_consumableInUse == null)
				{
					_consumableInUse = (CBool) CR2WTypeManager.Create("Bool", "consumableInUse", cr2w, this);
				}
				return _consumableInUse;
			}
			set
			{
				if (_consumableInUse == value)
				{
					return;
				}
				_consumableInUse = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("consumableEffectApplied")] 
		public CBool ConsumableEffectApplied
		{
			get
			{
				if (_consumableEffectApplied == null)
				{
					_consumableEffectApplied = (CBool) CR2WTypeManager.Create("Bool", "consumableEffectApplied", cr2w, this);
				}
				return _consumableEffectApplied;
			}
			set
			{
				if (_consumableEffectApplied == value)
				{
					return;
				}
				_consumableEffectApplied = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("consumableUseTimeStartup")] 
		public CFloat ConsumableUseTimeStartup
		{
			get
			{
				if (_consumableUseTimeStartup == null)
				{
					_consumableUseTimeStartup = (CFloat) CR2WTypeManager.Create("Float", "consumableUseTimeStartup", cr2w, this);
				}
				return _consumableUseTimeStartup;
			}
			set
			{
				if (_consumableUseTimeStartup == value)
				{
					return;
				}
				_consumableUseTimeStartup = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("consumableUseTimeRecovery")] 
		public CFloat ConsumableUseTimeRecovery
		{
			get
			{
				if (_consumableUseTimeRecovery == null)
				{
					_consumableUseTimeRecovery = (CFloat) CR2WTypeManager.Create("Float", "consumableUseTimeRecovery", cr2w, this);
				}
				return _consumableUseTimeRecovery;
			}
			set
			{
				if (_consumableUseTimeRecovery == value)
				{
					return;
				}
				_consumableUseTimeRecovery = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("remainingQuickMeleeTime")] 
		public CFloat RemainingQuickMeleeTime
		{
			get
			{
				if (_remainingQuickMeleeTime == null)
				{
					_remainingQuickMeleeTime = (CFloat) CR2WTypeManager.Create("Float", "remainingQuickMeleeTime", cr2w, this);
				}
				return _remainingQuickMeleeTime;
			}
			set
			{
				if (_remainingQuickMeleeTime == value)
				{
					return;
				}
				_remainingQuickMeleeTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("remainingQuickMeleeCooldownTime")] 
		public CFloat RemainingQuickMeleeCooldownTime
		{
			get
			{
				if (_remainingQuickMeleeCooldownTime == null)
				{
					_remainingQuickMeleeCooldownTime = (CFloat) CR2WTypeManager.Create("Float", "remainingQuickMeleeCooldownTime", cr2w, this);
				}
				return _remainingQuickMeleeCooldownTime;
			}
			set
			{
				if (_remainingQuickMeleeCooldownTime == value)
				{
					return;
				}
				_remainingQuickMeleeCooldownTime = value;
				PropertySet(this);
			}
		}

		public gameMuppetUpperBodyState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
