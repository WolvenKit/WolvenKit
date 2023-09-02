using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrouchIndicatorGameController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("CurrentAmmoRef")] 
		public inkTextWidgetReference CurrentAmmoRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("AllAmmoRef")] 
		public inkTextWidgetReference AllAmmoRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("ammoWrapper")] 
		public inkWidgetReference AmmoWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("warningMessageWraper")] 
		public inkWidgetReference WarningMessageWraper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("smartLinkFirmwareOnline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOnline
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("smartLinkFirmwareOffline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOffline
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("weaponIcon")] 
		public inkImageWidgetReference WeaponIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("FireModes")] 
		public CArray<inkImageWidgetReference> FireModes
		{
			get => GetPropertyValue<CArray<inkImageWidgetReference>>();
			set => SetPropertyValue<CArray<inkImageWidgetReference>>(value);
		}

		[Ordinal(18)] 
		[RED("WeaponMods")] 
		public CArray<inkImageWidgetReference> WeaponMods
		{
			get => GetPropertyValue<CArray<inkImageWidgetReference>>();
			set => SetPropertyValue<CArray<inkImageWidgetReference>>(value);
		}

		[Ordinal(19)] 
		[RED("modHolder")] 
		public inkWidgetReference ModHolder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("weaponName")] 
		public inkTextWidgetReference WeaponName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("damageTypeRef")] 
		public inkWidgetReference DamageTypeRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("crouchIcon")] 
		public inkImageWidgetReference CrouchIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("folded")] 
		public CBool Folded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(24)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(25)] 
		[RED("weaponItemData")] 
		public gameInventoryItemData WeaponItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(26)] 
		[RED("damageTypeIndicator")] 
		public CWeakHandle<DamageTypeIndicator> DamageTypeIndicator
		{
			get => GetPropertyValue<CWeakHandle<DamageTypeIndicator>>();
			set => SetPropertyValue<CWeakHandle<DamageTypeIndicator>>(value);
		}

		[Ordinal(27)] 
		[RED("WeaponAreas")] 
		public CArray<CEnum<gamedataItemType>> WeaponAreas
		{
			get => GetPropertyValue<CArray<CEnum<gamedataItemType>>>();
			set => SetPropertyValue<CArray<CEnum<gamedataItemType>>>(value);
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
		[RED("BBCurrentWeapon")] 
		public CHandle<redCallbackObject> BBCurrentWeapon
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(31)] 
		[RED("LocomotionStateBlackboardId")] 
		public CHandle<redCallbackObject> LocomotionStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(32)] 
		[RED("VisionStateBlackboardId")] 
		public CHandle<redCallbackObject> VisionStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(33)] 
		[RED("UIStateBlackboardId")] 
		public CHandle<redCallbackObject> UIStateBlackboardId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(34)] 
		[RED("PlayerSpawnedCallbackID")] 
		public CHandle<redCallbackObject> PlayerSpawnedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(35)] 
		[RED("ammoHackedListenerId")] 
		public CHandle<redCallbackObject> AmmoHackedListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(36)] 
		[RED("BufferedRosterData")] 
		public CHandle<gameSlotDataHolder> BufferedRosterData
		{
			get => GetPropertyValue<CHandle<gameSlotDataHolder>>();
			set => SetPropertyValue<CHandle<gameSlotDataHolder>>(value);
		}

		[Ordinal(37)] 
		[RED("UIBlackboard")] 
		public CWeakHandle<gameIBlackboard> UIBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(38)] 
		[RED("ActiveWeapon")] 
		public gameSlotWeaponData ActiveWeapon
		{
			get => GetPropertyValue<gameSlotWeaponData>();
			set => SetPropertyValue<gameSlotWeaponData>(value);
		}

		[Ordinal(39)] 
		[RED("hackingBlackboard")] 
		public CWeakHandle<gameIBlackboard> HackingBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(40)] 
		[RED("Player")] 
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
		[RED("outOfAmmoAnim")] 
		public CHandle<inkanimProxy> OutOfAmmoAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(43)] 
		[RED("transitionAnimProxy")] 
		public CHandle<inkanimProxy> TransitionAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(44)] 
		[RED("blackboard")] 
		public CWeakHandle<gameIBlackboard> Blackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(45)] 
		[RED("bbDefinition")] 
		public CHandle<UIInteractionsDef> BbDefinition
		{
			get => GetPropertyValue<CHandle<UIInteractionsDef>>();
			set => SetPropertyValue<CHandle<UIInteractionsDef>>(value);
		}

		[Ordinal(46)] 
		[RED("onMagazineAmmoCount")] 
		public CHandle<redCallbackObject> OnMagazineAmmoCount
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(47)] 
		[RED("dataListenerId")] 
		public CHandle<redCallbackObject> DataListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(48)] 
		[RED("weaponBlackboard")] 
		public CWeakHandle<gameIBlackboard> WeaponBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(49)] 
		[RED("weaponParamsListenerId")] 
		public CHandle<redCallbackObject> WeaponParamsListenerId
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(50)] 
		[RED("bufferedMaxAmmo")] 
		public CInt32 BufferedMaxAmmo
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(51)] 
		[RED("bufferedAmmoId")] 
		public CInt32 BufferedAmmoId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(52)] 
		[RED("genderName")] 
		public CName GenderName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public CrouchIndicatorGameController()
		{
			CurrentAmmoRef = new inkTextWidgetReference();
			AllAmmoRef = new inkTextWidgetReference();
			AmmoWrapper = new inkWidgetReference();
			Container = new inkWidgetReference();
			WarningMessageWraper = new inkWidgetReference();
			SmartLinkFirmwareOnline = new inkCompoundWidgetReference();
			SmartLinkFirmwareOffline = new inkCompoundWidgetReference();
			WeaponIcon = new inkImageWidgetReference();
			FireModes = new();
			WeaponMods = new();
			ModHolder = new inkWidgetReference();
			WeaponName = new inkTextWidgetReference();
			DamageTypeRef = new inkWidgetReference();
			CrouchIcon = new inkImageWidgetReference();
			WeaponItemData = new gameInventoryItemData { ID = new gameItemID(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = uint.MaxValue, IsRequirementMet = true, IsEquippable = true, Requirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new gameInventoryItemSortData() };
			WeaponAreas = new();
			ActiveWeapon = new gameSlotWeaponData { WeaponID = new gameItemID(), AmmoCurrent = -1, MagazineCap = -1, AmmoId = new gameItemID(), TriggerModeCurrent = Enums.gamedataTriggerMode.Invalid, TriggerModeList = new(), Evolution = Enums.gamedataWeaponEvolution.Invalid, IsFirstEquip = true };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
