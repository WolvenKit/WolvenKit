using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadialWheelController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("radialWeapons")] 
		public CArray<CHandle<WeaponRadialSlot>> RadialWeapons
		{
			get => GetPropertyValue<CArray<CHandle<WeaponRadialSlot>>>();
			set => SetPropertyValue<CArray<CHandle<WeaponRadialSlot>>>(value);
		}

		[Ordinal(10)] 
		[RED("inputHintController")] 
		public CHandle<RadialSlot> InputHintController
		{
			get => GetPropertyValue<CHandle<RadialSlot>>();
			set => SetPropertyValue<CHandle<RadialSlot>>(value);
		}

		[Ordinal(11)] 
		[RED("activeSlotTooltip")] 
		public CHandle<RadialSlot> ActiveSlotTooltip
		{
			get => GetPropertyValue<CHandle<RadialSlot>>();
			set => SetPropertyValue<CHandle<RadialSlot>>(value);
		}

		[Ordinal(12)] 
		[RED("activeWeaponSlotTooltip")] 
		public CHandle<RadialSlot> ActiveWeaponSlotTooltip
		{
			get => GetPropertyValue<CHandle<RadialSlot>>();
			set => SetPropertyValue<CHandle<RadialSlot>>(value);
		}

		[Ordinal(13)] 
		[RED("statusEffects")] 
		public CHandle<RadialSlot> StatusEffects
		{
			get => GetPropertyValue<CHandle<RadialSlot>>();
			set => SetPropertyValue<CHandle<RadialSlot>>(value);
		}

		[Ordinal(14)] 
		[RED("pointerRef")] 
		public inkWidgetReference PointerRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("activeSlot")] 
		public CHandle<WeaponRadialSlot> ActiveSlot
		{
			get => GetPropertyValue<CHandle<WeaponRadialSlot>>();
			set => SetPropertyValue<CHandle<WeaponRadialSlot>>(value);
		}

		[Ordinal(16)] 
		[RED("pointer")] 
		public CWeakHandle<PointerController> Pointer
		{
			get => GetPropertyValue<CWeakHandle<PointerController>>();
			set => SetPropertyValue<CWeakHandle<PointerController>>(value);
		}

		[Ordinal(17)] 
		[RED("activeIndex")] 
		public CInt32 ActiveIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(19)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("pendingRadialSlotAsyncSpawnCount")] 
		public CInt32 PendingRadialSlotAsyncSpawnCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(21)] 
		[RED("consSlotCachedData")] 
		public gameInventoryItemData ConsSlotCachedData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(22)] 
		[RED("gadgetSlotCachedData")] 
		public gameInventoryItemData GadgetSlotCachedData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(23)] 
		[RED("cyclingActionRegistered")] 
		public CName CyclingActionRegistered
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("registeredInputHints")] 
		public CArray<gameuiInputHintData> RegisteredInputHints
		{
			get => GetPropertyValue<CArray<gameuiInputHintData>>();
			set => SetPropertyValue<CArray<gameuiInputHintData>>(value);
		}

		[Ordinal(25)] 
		[RED("applyInputHint")] 
		public gameuiInputHintData ApplyInputHint
		{
			get => GetPropertyValue<gameuiInputHintData>();
			set => SetPropertyValue<gameuiInputHintData>(value);
		}

		[Ordinal(26)] 
		[RED("cycleInputHintDataLeft")] 
		public gameuiInputHintData CycleInputHintDataLeft
		{
			get => GetPropertyValue<gameuiInputHintData>();
			set => SetPropertyValue<gameuiInputHintData>(value);
		}

		[Ordinal(27)] 
		[RED("cycleInputHintDataRight")] 
		public gameuiInputHintData CycleInputHintDataRight
		{
			get => GetPropertyValue<gameuiInputHintData>();
			set => SetPropertyValue<gameuiInputHintData>(value);
		}

		[Ordinal(28)] 
		[RED("radialMode")] 
		public CEnum<ERadialMode> RadialMode
		{
			get => GetPropertyValue<CEnum<ERadialMode>>();
			set => SetPropertyValue<CEnum<ERadialMode>>(value);
		}

		[Ordinal(29)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(30)] 
		[RED("equipmentSystem")] 
		public CWeakHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetPropertyValue<CWeakHandle<EquipmentSystem>>();
			set => SetPropertyValue<CWeakHandle<EquipmentSystem>>(value);
		}

		[Ordinal(31)] 
		[RED("transactionSystem")] 
		public CWeakHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CWeakHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CWeakHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(32)] 
		[RED("quickSlotBlackboard")] 
		public CWeakHandle<gameIBlackboard> QuickSlotBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(33)] 
		[RED("QuickSlotBlackboardDef")] 
		public CHandle<UI_QuickSlotsDataDef> QuickSlotBlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_QuickSlotsDataDef>>();
			set => SetPropertyValue<CHandle<UI_QuickSlotsDataDef>>(value);
		}

		[Ordinal(34)] 
		[RED("axisInputCallbackID")] 
		public CHandle<redCallbackObject> AxisInputCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(35)] 
		[RED("UISystemBB")] 
		public CWeakHandle<gameIBlackboard> UISystemBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(36)] 
		[RED("UISystemDef")] 
		public CHandle<UI_SystemDef> UISystemDef
		{
			get => GetPropertyValue<CHandle<UI_SystemDef>>();
			set => SetPropertyValue<CHandle<UI_SystemDef>>(value);
		}

		[Ordinal(37)] 
		[RED("isInMenuCallbackID")] 
		public CHandle<redCallbackObject> IsInMenuCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(38)] 
		[RED("equipmentUIBlackboard")] 
		public CWeakHandle<gameIBlackboard> EquipmentUIBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(39)] 
		[RED("EquipmentBlackboardDef")] 
		public CHandle<UI_EquipmentDef> EquipmentBlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_EquipmentDef>>();
			set => SetPropertyValue<CHandle<UI_EquipmentDef>>(value);
		}

		[Ordinal(40)] 
		[RED("equipmentUICallbackID")] 
		public CHandle<redCallbackObject> EquipmentUICallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public RadialWheelController()
		{
			RadialWeapons = new();
			PointerRef = new inkWidgetReference();
			ConsSlotCachedData = new gameInventoryItemData { ID = new gameItemID(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = uint.MaxValue, IsRequirementMet = true, IsEquippable = true, Requirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new gameInventoryItemSortData() };
			GadgetSlotCachedData = new gameInventoryItemData { ID = new gameItemID(), DamageType = Enums.gamedataDamageType.Invalid, EquipmentArea = Enums.gamedataEquipmentArea.Invalid, ComparedQuality = Enums.gamedataQuality.Invalid, Empty = true, IsAvailable = true, PositionInBackpack = uint.MaxValue, IsRequirementMet = true, IsEquippable = true, Requirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirement = new gameSItemStackRequirementData { StatType = Enums.gamedataStatType.Invalid }, EquipRequirements = new(), Attachments = new(), Abilities = new(), PlacementSlots = new(), PrimaryStats = new(), SecondaryStats = new(), SortData = new gameInventoryItemSortData() };
			RegisteredInputHints = new();
			ApplyInputHint = new gameuiInputHintData { HoldIndicationType = Enums.inkInputHintHoldIndicationType.Press };
			CycleInputHintDataLeft = new gameuiInputHintData { HoldIndicationType = Enums.inkInputHintHoldIndicationType.Press };
			CycleInputHintDataRight = new gameuiInputHintData { HoldIndicationType = Enums.inkInputHintHoldIndicationType.Press };
			RadialMode = Enums.ERadialMode.ApplyActiveSlotAndConsumables;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
