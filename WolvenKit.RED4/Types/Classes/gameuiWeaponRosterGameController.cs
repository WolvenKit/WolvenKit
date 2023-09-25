using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiWeaponRosterGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("weaponName")] 
		public inkTextWidgetReference WeaponName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("weaponIcon")] 
		public inkImageWidgetReference WeaponIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("weaponCurrentAmmo")] 
		public inkTextWidgetReference WeaponCurrentAmmo
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("weaponTotalAmmo")] 
		public inkTextWidgetReference WeaponTotalAmmo
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("weaponAmmoWrapper")] 
		public inkWidgetReference WeaponAmmoWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("onFootContainer")] 
		public inkWidgetReference OnFootContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("weaponizedVehicleContainer")] 
		public inkWidgetReference WeaponizedVehicleContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("weaponizedVehicleMissileLauncherContainer")] 
		public inkWidgetReference WeaponizedVehicleMissileLauncherContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("weaponizedVehicleMachinegunContainer")] 
		public inkWidgetReference WeaponizedVehicleMachinegunContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("machinegunAmmo")] 
		public inkTextWidgetReference MachinegunAmmo
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("machinegunReloadingProgressBar")] 
		public inkWidgetReference MachinegunReloadingProgressBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("machinegunReloadingProgressBarFill")] 
		public inkWidgetReference MachinegunReloadingProgressBarFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("missileLauncherAmmo")] 
		public inkTextWidgetReference MissileLauncherAmmo
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("missileLauncherReloadingProgressBar")] 
		public inkWidgetReference MissileLauncherReloadingProgressBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("missileLauncherReloadingProgressBarFill")] 
		public inkWidgetReference MissileLauncherReloadingProgressBarFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(24)] 
		[RED("smartLinkFirmwareOnline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOnline
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("smartLinkFirmwareOffline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOffline
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(26)] 
		[RED("uiEquipmentDataBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiEquipmentDataBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(27)] 
		[RED("ammoHackedListenerId")] 
		public CHandle<redCallbackObject> AmmoHackedListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(28)] 
		[RED("BBWeaponList")] 
		public CHandle<redCallbackObject> BBWeaponList
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(29)] 
		[RED("BBAmmoLooted")] 
		public CHandle<redCallbackObject> BBAmmoLooted
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(30)] 
		[RED("dataListenerId")] 
		public CHandle<redCallbackObject> DataListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("onMagazineAmmoCount")] 
		public CHandle<redCallbackObject> OnMagazineAmmoCount
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(32)] 
		[RED("remoteControlledVehicleDataCallback")] 
		public CHandle<redCallbackObject> RemoteControlledVehicleDataCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(33)] 
		[RED("psmWeaponStateChangedCallback")] 
		public CHandle<redCallbackObject> PsmWeaponStateChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(34)] 
		[RED("VisionStateBlackboardId")] 
		public CHandle<redCallbackObject> VisionStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(35)] 
		[RED("weaponParamsListenerId")] 
		public CHandle<redCallbackObject> WeaponParamsListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(36)] 
		[RED("weaponizedVehicleMachineGunAmmoChangedCallback")] 
		public CHandle<redCallbackObject> WeaponizedVehicleMachineGunAmmoChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(37)] 
		[RED("weaponizedVehicleMissileLauncherChargesChangedCallback")] 
		public CHandle<redCallbackObject> WeaponizedVehicleMissileLauncherChargesChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(38)] 
		[RED("weaponRecord")] 
		public CHandle<gamedataWeaponItem_Record> WeaponRecord
		{
			get => GetPropertyValue<CHandle<gamedataWeaponItem_Record>>();
			set => SetPropertyValue<CHandle<gamedataWeaponItem_Record>>(value);
		}

		[Ordinal(39)] 
		[RED("activeWeapon")] 
		public gameSlotWeaponData ActiveWeapon
		{
			get => GetPropertyValue<gameSlotWeaponData>();
			set => SetPropertyValue<gameSlotWeaponData>(value);
		}

		[Ordinal(40)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(41)] 
		[RED("PlayerMuppet")] 
		public CWeakHandle<gameMuppet> PlayerMuppet
		{
			get => GetPropertyValue<CWeakHandle<gameMuppet>>();
			set => SetPropertyValue<CWeakHandle<gameMuppet>>(value);
		}

		[Ordinal(42)] 
		[RED("transitionAnimProxy")] 
		public CHandle<inkanimProxy> TransitionAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(43)] 
		[RED("outOfAmmoAnim")] 
		public CHandle<inkanimProxy> OutOfAmmoAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(44)] 
		[RED("folded")] 
		public CBool Folded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(45)] 
		[RED("isUnholstered")] 
		public CBool IsUnholstered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(46)] 
		[RED("inVehicle")] 
		public CBool InVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(47)] 
		[RED("inWeaponizedVehicle")] 
		public CBool InWeaponizedVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(48)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(49)] 
		[RED("weaponItemData")] 
		public gameInventoryItemData WeaponItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(50)] 
		[RED("weaponizedVehiclePowerWeaponReloadTime")] 
		public CFloat WeaponizedVehiclePowerWeaponReloadTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(51)] 
		[RED("weaponizedVehiclePowerWeaponReloadElapsedTime")] 
		public CFloat WeaponizedVehiclePowerWeaponReloadElapsedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(52)] 
		[RED("weaponizedVehicleMissileLauncherMaxCharges")] 
		public CUInt32 WeaponizedVehicleMissileLauncherMaxCharges
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(53)] 
		[RED("weaponizedVehicleMissileLauncherRechargeTime")] 
		public CFloat WeaponizedVehicleMissileLauncherRechargeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(54)] 
		[RED("weaponizedVehicleMissileLauncherRechargeElapsedTime")] 
		public CFloat WeaponizedVehicleMissileLauncherRechargeElapsedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiWeaponRosterGameController()
		{
			WeaponName = new inkTextWidgetReference();
			WeaponIcon = new inkImageWidgetReference();
			WeaponCurrentAmmo = new inkTextWidgetReference();
			WeaponTotalAmmo = new inkTextWidgetReference();
			WeaponAmmoWrapper = new inkWidgetReference();
			OnFootContainer = new inkWidgetReference();
			WeaponizedVehicleContainer = new inkWidgetReference();
			WeaponizedVehicleMissileLauncherContainer = new inkWidgetReference();
			WeaponizedVehicleMachinegunContainer = new inkWidgetReference();
			MachinegunAmmo = new inkTextWidgetReference();
			MachinegunReloadingProgressBar = new inkWidgetReference();
			MachinegunReloadingProgressBarFill = new inkWidgetReference();
			MissileLauncherAmmo = new inkTextWidgetReference();
			MissileLauncherReloadingProgressBar = new inkWidgetReference();
			MissileLauncherReloadingProgressBarFill = new inkWidgetReference();
			SmartLinkFirmwareOnline = new inkCompoundWidgetReference();
			SmartLinkFirmwareOffline = new inkCompoundWidgetReference();
			ActiveWeapon = new gameSlotWeaponData { WeaponID = new gameItemID(), AmmoCurrent = -1, MagazineCap = -1, AmmoId = new gameItemID(), TriggerModeCurrent = Enums.gamedataTriggerMode.Invalid, TriggerModeList = new(), Evolution = Enums.gamedataWeaponEvolution.Invalid, IsFirstEquip = true };
			Folded = true;
			WeaponItemData = new gameInventoryItemData { ID = new gameItemID(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = uint.MaxValue, IsRequirementMet = true, IsEquippable = true, Requirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new gameInventoryItemSortData() };
			WeaponizedVehiclePowerWeaponReloadTime = -1.000000F;
			WeaponizedVehiclePowerWeaponReloadElapsedTime = -1.000000F;
			WeaponizedVehicleMissileLauncherRechargeTime = -1.000000F;
			WeaponizedVehicleMissileLauncherRechargeElapsedTime = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
