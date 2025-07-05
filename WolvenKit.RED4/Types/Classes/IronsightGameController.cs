using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IronsightGameController : gameuiIronsightGameController
	{
		[Ordinal(2)] 
		[RED("playerPuppet")] 
		public CWeakHandle<gameObject> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(3)] 
		[RED("dot")] 
		public inkWidgetReference Dot
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("ammo")] 
		public inkTextWidgetReference Ammo
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("ammoSpareCount")] 
		public inkTextWidgetReference AmmoSpareCount
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("range")] 
		public inkTextWidgetReference Range
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("seeThroughWalls")] 
		public CBool SeeThroughWalls
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("targetAttitudeFriendly")] 
		public inkWidgetReference TargetAttitudeFriendly
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("targetAttitudeHostile")] 
		public inkWidgetReference TargetAttitudeHostile
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("targetAttitudeEnemyNonHostile")] 
		public inkWidgetReference TargetAttitudeEnemyNonHostile
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("weaponDataBB")] 
		public CWeakHandle<gameIBlackboard> WeaponDataBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(12)] 
		[RED("targetHitAnimationName")] 
		public CName TargetHitAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("targetHitAnimation")] 
		public CHandle<inkanimProxy> TargetHitAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(14)] 
		[RED("weaponDataTargetHitBBID")] 
		public CHandle<redCallbackObject> WeaponDataTargetHitBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(15)] 
		[RED("shootAnimationName")] 
		public CName ShootAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(16)] 
		[RED("firstEquipAnimationName")] 
		public CName FirstEquipAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("shootAnimation")] 
		public CHandle<inkanimProxy> ShootAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(18)] 
		[RED("weaponDataShootBBID")] 
		public CHandle<redCallbackObject> WeaponDataShootBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("currentAmmo")] 
		public CInt32 CurrentAmmo
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("animIntro")] 
		public CHandle<inkanimProxy> AnimIntro
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(21)] 
		[RED("animLoop")] 
		public CHandle<inkanimProxy> AnimLoop
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(22)] 
		[RED("animReload")] 
		public CHandle<inkanimProxy> AnimReload
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(23)] 
		[RED("animPerfectCharge")] 
		public CHandle<inkanimProxy> AnimPerfectCharge
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(24)] 
		[RED("ActiveWeapon")] 
		public gameSlotWeaponData ActiveWeapon
		{
			get => GetPropertyValue<gameSlotWeaponData>();
			set => SetPropertyValue<gameSlotWeaponData>(value);
		}

		[Ordinal(25)] 
		[RED("weaponItemData")] 
		public gameInventoryItemData WeaponItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(26)] 
		[RED("originalWeapon")] 
		public CWeakHandle<gameweaponObject> OriginalWeapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(27)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(28)] 
		[RED("bb")] 
		public CWeakHandle<gameIBlackboard> Bb
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(29)] 
		[RED("bbID")] 
		public CHandle<redCallbackObject> BbID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(30)] 
		[RED("target")] 
		public CWeakHandle<gameObject> Target
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(31)] 
		[RED("targetBB")] 
		public CWeakHandle<gameIBlackboard> TargetBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(32)] 
		[RED("targetRange")] 
		public CFloat TargetRange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("targetRangeBBID")] 
		public CHandle<redCallbackObject> TargetRangeBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(34)] 
		[RED("targetAttitudeBBID")] 
		public CHandle<redCallbackObject> TargetAttitudeBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(35)] 
		[RED("targetAcquiredBBID")] 
		public CHandle<redCallbackObject> TargetAcquiredBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(36)] 
		[RED("targetRangeObstructedBBID")] 
		public CHandle<redCallbackObject> TargetRangeObstructedBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(37)] 
		[RED("targetAcquiredObstructedBBID")] 
		public CHandle<redCallbackObject> TargetAcquiredObstructedBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(38)] 
		[RED("targetRangeDecimalPrecision")] 
		public CUInt32 TargetRangeDecimalPrecision
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(39)] 
		[RED("targetAttitudeAnimator")] 
		public CWeakHandle<TargetAttitudeAnimationController> TargetAttitudeAnimator
		{
			get => GetPropertyValue<CWeakHandle<TargetAttitudeAnimationController>>();
			set => SetPropertyValue<CWeakHandle<TargetAttitudeAnimationController>>(value);
		}

		[Ordinal(40)] 
		[RED("targetAttitudeContainer")] 
		public inkWidgetReference TargetAttitudeContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(41)] 
		[RED("targetHealthListener")] 
		public CHandle<IronsightTargetHealthChangeListener> TargetHealthListener
		{
			get => GetPropertyValue<CHandle<IronsightTargetHealthChangeListener>>();
			set => SetPropertyValue<CHandle<IronsightTargetHealthChangeListener>>(value);
		}

		[Ordinal(42)] 
		[RED("compass")] 
		public CWeakHandle<CompassController> Compass
		{
			get => GetPropertyValue<CWeakHandle<CompassController>>();
			set => SetPropertyValue<CWeakHandle<CompassController>>(value);
		}

		[Ordinal(43)] 
		[RED("compassContainer")] 
		public inkWidgetReference CompassContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(44)] 
		[RED("compass2")] 
		public CWeakHandle<CompassController> Compass2
		{
			get => GetPropertyValue<CWeakHandle<CompassController>>();
			set => SetPropertyValue<CWeakHandle<CompassController>>(value);
		}

		[Ordinal(45)] 
		[RED("compassContainer2")] 
		public inkWidgetReference CompassContainer2
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(46)] 
		[RED("altimeter")] 
		public CWeakHandle<AltimeterController> Altimeter
		{
			get => GetPropertyValue<CWeakHandle<AltimeterController>>();
			set => SetPropertyValue<CWeakHandle<AltimeterController>>(value);
		}

		[Ordinal(47)] 
		[RED("altimeterContainer")] 
		public inkWidgetReference AltimeterContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(48)] 
		[RED("weaponBB")] 
		public CWeakHandle<gameIBlackboard> WeaponBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(49)] 
		[RED("chargebar")] 
		public CWeakHandle<ChargebarController> Chargebar
		{
			get => GetPropertyValue<CWeakHandle<ChargebarController>>();
			set => SetPropertyValue<CWeakHandle<ChargebarController>>(value);
		}

		[Ordinal(50)] 
		[RED("chargebarContainer")] 
		public inkWidgetReference ChargebarContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(51)] 
		[RED("chargebarValueChanged")] 
		public CHandle<redCallbackObject> ChargebarValueChanged
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(52)] 
		[RED("chargebarTriggerModeChanged")] 
		public CHandle<redCallbackObject> ChargebarTriggerModeChanged
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(53)] 
		[RED("ADSContainer")] 
		public inkWidgetReference ADSContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(54)] 
		[RED("ADSAnimator")] 
		public CWeakHandle<AimDownSightController> ADSAnimator
		{
			get => GetPropertyValue<CWeakHandle<AimDownSightController>>();
			set => SetPropertyValue<CWeakHandle<AimDownSightController>>(value);
		}

		[Ordinal(55)] 
		[RED("playerStateMachineBB")] 
		public CWeakHandle<gameIBlackboard> PlayerStateMachineBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(56)] 
		[RED("playerStateMachineUpperBodyBBID")] 
		public CHandle<redCallbackObject> PlayerStateMachineUpperBodyBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(57)] 
		[RED("crosshairStateChanged")] 
		public CHandle<redCallbackObject> CrosshairStateChanged
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(58)] 
		[RED("perfectChargeIndicator")] 
		public inkWidgetReference PerfectChargeIndicator
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(59)] 
		[RED("crosshairState")] 
		public CEnum<gamePSMCrosshairStates> CrosshairState
		{
			get => GetPropertyValue<CEnum<gamePSMCrosshairStates>>();
			set => SetPropertyValue<CEnum<gamePSMCrosshairStates>>(value);
		}

		[Ordinal(60)] 
		[RED("isTargetEnemy")] 
		public CBool IsTargetEnemy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(61)] 
		[RED("attitude")] 
		public CEnum<EAIAttitude> Attitude
		{
			get => GetPropertyValue<CEnum<EAIAttitude>>();
			set => SetPropertyValue<CEnum<EAIAttitude>>(value);
		}

		[Ordinal(62)] 
		[RED("upperBodyState")] 
		public CEnum<gamePSMUpperBodyStates> UpperBodyState
		{
			get => GetPropertyValue<CEnum<gamePSMUpperBodyStates>>();
			set => SetPropertyValue<CEnum<gamePSMUpperBodyStates>>(value);
		}

		public IronsightGameController()
		{
			Dot = new inkWidgetReference();
			Ammo = new inkTextWidgetReference();
			AmmoSpareCount = new inkTextWidgetReference();
			Range = new inkTextWidgetReference();
			TargetAttitudeFriendly = new inkWidgetReference();
			TargetAttitudeHostile = new inkWidgetReference();
			TargetAttitudeEnemyNonHostile = new inkWidgetReference();
			CurrentAmmo = -1;
			ActiveWeapon = new gameSlotWeaponData { WeaponID = new gameItemID(), AmmoCurrent = -1, MagazineCap = -1, AmmoId = new gameItemID(), TriggerModeCurrent = Enums.gamedataTriggerMode.Invalid, TriggerModeList = new(), Evolution = Enums.gamedataWeaponEvolution.Invalid, IsFirstEquip = true };
			WeaponItemData = new gameInventoryItemData { ID = new gameItemID(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = uint.MaxValue, IsRequirementMet = true, IsEquippable = true, Requirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new gameInventoryItemSortData() };
			TargetRangeDecimalPrecision = 2;
			TargetAttitudeContainer = new inkWidgetReference();
			CompassContainer = new inkWidgetReference();
			CompassContainer2 = new inkWidgetReference();
			AltimeterContainer = new inkWidgetReference();
			ChargebarContainer = new inkWidgetReference();
			ADSContainer = new inkWidgetReference();
			PerfectChargeIndicator = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
