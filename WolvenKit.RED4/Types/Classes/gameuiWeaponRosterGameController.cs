using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiWeaponRosterGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("rightWeaponName")] 
		public inkTextWidgetReference RightWeaponName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("rightWeaponIcon")] 
		public inkImageWidgetReference RightWeaponIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("rightWeaponCurrentAmmo")] 
		public inkTextWidgetReference RightWeaponCurrentAmmo
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("rightWeaponTotalAmmo")] 
		public inkTextWidgetReference RightWeaponTotalAmmo
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("rightWeaponAmmoWrapper")] 
		public inkWidgetReference RightWeaponAmmoWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("leftWeaponName")] 
		public inkTextWidgetReference LeftWeaponName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("leftWeaponIcon")] 
		public inkImageWidgetReference LeftWeaponIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("leftWeaponCurrentAmmo")] 
		public inkTextWidgetReference LeftWeaponCurrentAmmo
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("leftWeaponTotalAmmo")] 
		public inkTextWidgetReference LeftWeaponTotalAmmo
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("widgetsToActivateWithLeftWeapon")] 
		public CArray<inkWidgetReference> WidgetsToActivateWithLeftWeapon
		{
			get => GetPropertyValue<CArray<inkWidgetReference>>();
			set => SetPropertyValue<CArray<inkWidgetReference>>(value);
		}

		[Ordinal(19)] 
		[RED("rightWeaponHolder")] 
		public inkWidgetReference RightWeaponHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("leftWeaponHolder")] 
		public inkWidgetReference LeftWeaponHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("weaponIconsScaleWhenDualWielding")] 
		public Vector2 WeaponIconsScaleWhenDualWielding
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(22)] 
		[RED("weaponIconsTopMarginWhenSingleWielding")] 
		public CFloat WeaponIconsTopMarginWhenSingleWielding
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("weaponIconsTopMarginWhenDualWielding")] 
		public CFloat WeaponIconsTopMarginWhenDualWielding
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("rightWeaponWrapper")] 
		public inkHorizontalPanelWidgetReference RightWeaponWrapper
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		[Ordinal(25)] 
		[RED("childMarginWhenSingleWielding")] 
		public CFloat ChildMarginWhenSingleWielding
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("childMarginWhenDualWielding")] 
		public CFloat ChildMarginWhenDualWielding
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("onFootContainer")] 
		public inkWidgetReference OnFootContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(28)] 
		[RED("weaponizedVehicleContainer")] 
		public inkWidgetReference WeaponizedVehicleContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(29)] 
		[RED("weaponizedVehicleMissileLauncherContainer")] 
		public inkWidgetReference WeaponizedVehicleMissileLauncherContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("weaponizedVehicleMachinegunContainer")] 
		public inkWidgetReference WeaponizedVehicleMachinegunContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("machinegunAmmo")] 
		public inkTextWidgetReference MachinegunAmmo
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("machinegunReloadingProgressBar")] 
		public inkWidgetReference MachinegunReloadingProgressBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("machinegunReloadingProgressBarFill")] 
		public inkWidgetReference MachinegunReloadingProgressBarFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("missileLauncherAmmo")] 
		public inkTextWidgetReference MissileLauncherAmmo
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(35)] 
		[RED("missileLauncherReloadingProgressBar")] 
		public inkWidgetReference MissileLauncherReloadingProgressBar
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(36)] 
		[RED("missileLauncherReloadingProgressBarFill")] 
		public inkWidgetReference MissileLauncherReloadingProgressBarFill
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(37)] 
		[RED("smartLinkFirmwareOnline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOnline
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(38)] 
		[RED("smartLinkFirmwareOffline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOffline
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(39)] 
		[RED("uiEquipmentDataBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiEquipmentDataBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(40)] 
		[RED("uiBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(41)] 
		[RED("ammoHackedListenerId")] 
		public CHandle<redCallbackObject> AmmoHackedListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(42)] 
		[RED("BBWeaponList")] 
		public CHandle<redCallbackObject> BBWeaponList
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(43)] 
		[RED("BBAmmoLooted")] 
		public CHandle<redCallbackObject> BBAmmoLooted
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(44)] 
		[RED("dataListenerId")] 
		public CHandle<redCallbackObject> DataListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(45)] 
		[RED("onMagazineAmmoCount")] 
		public CHandle<redCallbackObject> OnMagazineAmmoCount
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(46)] 
		[RED("remoteControlledVehicleDataCallback")] 
		public CHandle<redCallbackObject> RemoteControlledVehicleDataCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(47)] 
		[RED("psmWeaponStateChangedCallback")] 
		public CHandle<redCallbackObject> PsmWeaponStateChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(48)] 
		[RED("VisionStateBlackboardId")] 
		public CHandle<redCallbackObject> VisionStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(49)] 
		[RED("weaponParamsListenerId")] 
		public CHandle<redCallbackObject> WeaponParamsListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(50)] 
		[RED("weaponizedVehicleMachineGunAmmoChangedCallback")] 
		public CHandle<redCallbackObject> WeaponizedVehicleMachineGunAmmoChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(51)] 
		[RED("weaponizedVehicleMissileLauncherChargesChangedCallback")] 
		public CHandle<redCallbackObject> WeaponizedVehicleMissileLauncherChargesChangedCallback
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(52)] 
		[RED("rightWeaponRecord")] 
		public CHandle<gamedataWeaponItem_Record> RightWeaponRecord
		{
			get => GetPropertyValue<CHandle<gamedataWeaponItem_Record>>();
			set => SetPropertyValue<CHandle<gamedataWeaponItem_Record>>(value);
		}

		[Ordinal(53)] 
		[RED("activeRightWeapon")] 
		public gameSlotWeaponData ActiveRightWeapon
		{
			get => GetPropertyValue<gameSlotWeaponData>();
			set => SetPropertyValue<gameSlotWeaponData>(value);
		}

		[Ordinal(54)] 
		[RED("leftWeaponRecord")] 
		public CHandle<gamedataWeaponItem_Record> LeftWeaponRecord
		{
			get => GetPropertyValue<CHandle<gamedataWeaponItem_Record>>();
			set => SetPropertyValue<CHandle<gamedataWeaponItem_Record>>(value);
		}

		[Ordinal(55)] 
		[RED("activeLeftWeapon")] 
		public gameSlotWeaponData ActiveLeftWeapon
		{
			get => GetPropertyValue<gameSlotWeaponData>();
			set => SetPropertyValue<gameSlotWeaponData>(value);
		}

		[Ordinal(56)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(57)] 
		[RED("PlayerMuppet")] 
		public CWeakHandle<gameMuppet> PlayerMuppet
		{
			get => GetPropertyValue<CWeakHandle<gameMuppet>>();
			set => SetPropertyValue<CWeakHandle<gameMuppet>>(value);
		}

		[Ordinal(58)] 
		[RED("transitionAnimProxy")] 
		public CHandle<inkanimProxy> TransitionAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(59)] 
		[RED("outOfAmmoAnim")] 
		public CHandle<inkanimProxy> OutOfAmmoAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(60)] 
		[RED("folded")] 
		public CBool Folded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("isLeftWeaponVisible")] 
		public CBool IsLeftWeaponVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(62)] 
		[RED("isUnholstered")] 
		public CBool IsUnholstered
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(63)] 
		[RED("inVehicle")] 
		public CBool InVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(64)] 
		[RED("inWeaponizedVehicle")] 
		public CBool InWeaponizedVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(65)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(66)] 
		[RED("rightWeaponItemData")] 
		public gameInventoryItemData RightWeaponItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(67)] 
		[RED("leftWeaponItemData")] 
		public gameInventoryItemData LeftWeaponItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(68)] 
		[RED("weaponizedVehiclePowerWeaponReloadTime")] 
		public CFloat WeaponizedVehiclePowerWeaponReloadTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(69)] 
		[RED("weaponizedVehiclePowerWeaponReloadElapsedTime")] 
		public CFloat WeaponizedVehiclePowerWeaponReloadElapsedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(70)] 
		[RED("weaponizedVehicleMissileLauncherMaxCharges")] 
		public CUInt32 WeaponizedVehicleMissileLauncherMaxCharges
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(71)] 
		[RED("weaponizedVehicleMissileLauncherRechargeTime")] 
		public CFloat WeaponizedVehicleMissileLauncherRechargeTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(72)] 
		[RED("weaponizedVehicleMissileLauncherRechargeElapsedTime")] 
		public CFloat WeaponizedVehicleMissileLauncherRechargeElapsedTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameuiWeaponRosterGameController()
		{
			RightWeaponName = new inkTextWidgetReference();
			RightWeaponIcon = new inkImageWidgetReference();
			RightWeaponCurrentAmmo = new inkTextWidgetReference();
			RightWeaponTotalAmmo = new inkTextWidgetReference();
			RightWeaponAmmoWrapper = new inkWidgetReference();
			LeftWeaponName = new inkTextWidgetReference();
			LeftWeaponIcon = new inkImageWidgetReference();
			LeftWeaponCurrentAmmo = new inkTextWidgetReference();
			LeftWeaponTotalAmmo = new inkTextWidgetReference();
			WidgetsToActivateWithLeftWeapon = new();
			RightWeaponHolder = new inkWidgetReference();
			LeftWeaponHolder = new inkWidgetReference();
			WeaponIconsScaleWhenDualWielding = new Vector2();
			RightWeaponWrapper = new inkHorizontalPanelWidgetReference();
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
			ActiveRightWeapon = new gameSlotWeaponData();
			ActiveLeftWeapon = new gameSlotWeaponData();
			Folded = true;
			RightWeaponItemData = new gameInventoryItemData();
			LeftWeaponItemData = new gameInventoryItemData();
			WeaponizedVehiclePowerWeaponReloadTime = -1.000000F;
			WeaponizedVehiclePowerWeaponReloadElapsedTime = -1.000000F;
			WeaponizedVehicleMissileLauncherRechargeTime = -1.000000F;
			WeaponizedVehicleMissileLauncherRechargeElapsedTime = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
