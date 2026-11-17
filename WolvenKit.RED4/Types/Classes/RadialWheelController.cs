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
		[RED("toPatternTabHideWidgetRef", 6)] 
		public CArrayFixedSize<inkWidgetReference> ToPatternTabHideWidgetRef
		{
			get => GetPropertyValue<CArrayFixedSize<inkWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkWidgetReference>>(value);
		}

		[Ordinal(16)] 
		[RED("patternPanelWidgetRef")] 
		public inkWidgetReference PatternPanelWidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("prevTabButtonRef")] 
		public inkWidgetReference PrevTabButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("nextTabButtonRef")] 
		public inkWidgetReference NextTabButtonRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("tabButtonRef", 2)] 
		public CArrayFixedSize<inkWidgetReference> TabButtonRef
		{
			get => GetPropertyValue<CArrayFixedSize<inkWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkWidgetReference>>(value);
		}

		[Ordinal(20)] 
		[RED("tabButtonLabelRef", 2)] 
		public CArrayFixedSize<inkTextWidgetReference> TabButtonLabelRef
		{
			get => GetPropertyValue<CArrayFixedSize<inkTextWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkTextWidgetReference>>(value);
		}

		[Ordinal(21)] 
		[RED("tabButtonBkgRef", 2)] 
		public CArrayFixedSize<inkWidgetReference> TabButtonBkgRef
		{
			get => GetPropertyValue<CArrayFixedSize<inkWidgetReference>>();
			set => SetPropertyValue<CArrayFixedSize<inkWidgetReference>>(value);
		}

		[Ordinal(22)] 
		[RED("prevTabButton")] 
		public CWeakHandle<inkButtonController> PrevTabButton
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(23)] 
		[RED("nextTabButton")] 
		public CWeakHandle<inkButtonController> NextTabButton
		{
			get => GetPropertyValue<CWeakHandle<inkButtonController>>();
			set => SetPropertyValue<CWeakHandle<inkButtonController>>(value);
		}

		[Ordinal(24)] 
		[RED("activeTab")] 
		public CInt32 ActiveTab
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(25)] 
		[RED("patternWheelInkWidget")] 
		public CWeakHandle<inkWidget> PatternWheelInkWidget
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(26)] 
		[RED("activeSlot")] 
		public CHandle<WeaponRadialSlot> ActiveSlot
		{
			get => GetPropertyValue<CHandle<WeaponRadialSlot>>();
			set => SetPropertyValue<CHandle<WeaponRadialSlot>>(value);
		}

		[Ordinal(27)] 
		[RED("pointer")] 
		public CWeakHandle<PointerController> Pointer
		{
			get => GetPropertyValue<CWeakHandle<PointerController>>();
			set => SetPropertyValue<CWeakHandle<PointerController>>(value);
		}

		[Ordinal(28)] 
		[RED("activeIndex")] 
		public CInt32 ActiveIndex
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(29)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(31)] 
		[RED("pendingRadialSlotAsyncSpawnCount")] 
		public CInt32 PendingRadialSlotAsyncSpawnCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(32)] 
		[RED("consSlotCachedData")] 
		public gameInventoryItemData ConsSlotCachedData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(33)] 
		[RED("gadgetSlotCachedData")] 
		public gameInventoryItemData GadgetSlotCachedData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(34)] 
		[RED("cyclingActionRegistered")] 
		public CName CyclingActionRegistered
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(35)] 
		[RED("registeredInputHints")] 
		public CArray<gameuiInputHintData> RegisteredInputHints
		{
			get => GetPropertyValue<CArray<gameuiInputHintData>>();
			set => SetPropertyValue<CArray<gameuiInputHintData>>(value);
		}

		[Ordinal(36)] 
		[RED("applyInputHint")] 
		public gameuiInputHintData ApplyInputHint
		{
			get => GetPropertyValue<gameuiInputHintData>();
			set => SetPropertyValue<gameuiInputHintData>(value);
		}

		[Ordinal(37)] 
		[RED("cycleInputHintDataLeft")] 
		public gameuiInputHintData CycleInputHintDataLeft
		{
			get => GetPropertyValue<gameuiInputHintData>();
			set => SetPropertyValue<gameuiInputHintData>(value);
		}

		[Ordinal(38)] 
		[RED("cycleInputHintDataRight")] 
		public gameuiInputHintData CycleInputHintDataRight
		{
			get => GetPropertyValue<gameuiInputHintData>();
			set => SetPropertyValue<gameuiInputHintData>(value);
		}

		[Ordinal(39)] 
		[RED("UI_MoveUpInputHint")] 
		public gameuiInputHintData UI_MoveUpInputHint
		{
			get => GetPropertyValue<gameuiInputHintData>();
			set => SetPropertyValue<gameuiInputHintData>(value);
		}

		[Ordinal(40)] 
		[RED("UI_MoveDownInputHint")] 
		public gameuiInputHintData UI_MoveDownInputHint
		{
			get => GetPropertyValue<gameuiInputHintData>();
			set => SetPropertyValue<gameuiInputHintData>(value);
		}

		[Ordinal(41)] 
		[RED("inspectWeaponsInputHint")] 
		public gameuiInputHintData InspectWeaponsInputHint
		{
			get => GetPropertyValue<gameuiInputHintData>();
			set => SetPropertyValue<gameuiInputHintData>(value);
		}

		[Ordinal(42)] 
		[RED("radialMode")] 
		public CEnum<ERadialMode> RadialMode
		{
			get => GetPropertyValue<CEnum<ERadialMode>>();
			set => SetPropertyValue<CEnum<ERadialMode>>(value);
		}

		[Ordinal(43)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetPropertyValue<CHandle<InventoryDataManagerV2>>();
			set => SetPropertyValue<CHandle<InventoryDataManagerV2>>(value);
		}

		[Ordinal(44)] 
		[RED("equipmentSystem")] 
		public CWeakHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetPropertyValue<CWeakHandle<EquipmentSystem>>();
			set => SetPropertyValue<CWeakHandle<EquipmentSystem>>(value);
		}

		[Ordinal(45)] 
		[RED("transactionSystem")] 
		public CWeakHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetPropertyValue<CWeakHandle<gameTransactionSystem>>();
			set => SetPropertyValue<CWeakHandle<gameTransactionSystem>>(value);
		}

		[Ordinal(46)] 
		[RED("playerPuppet")] 
		public CWeakHandle<PlayerPuppet> PlayerPuppet
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(47)] 
		[RED("quickSlotBlackboard")] 
		public CWeakHandle<gameIBlackboard> QuickSlotBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(48)] 
		[RED("QuickSlotBlackboardDef")] 
		public CHandle<UI_QuickSlotsDataDef> QuickSlotBlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_QuickSlotsDataDef>>();
			set => SetPropertyValue<CHandle<UI_QuickSlotsDataDef>>(value);
		}

		[Ordinal(49)] 
		[RED("axisInputCallbackID")] 
		public CHandle<redCallbackObject> AxisInputCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(50)] 
		[RED("UISystemBB")] 
		public CWeakHandle<gameIBlackboard> UISystemBB
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(51)] 
		[RED("UISystemDef")] 
		public CHandle<UI_SystemDef> UISystemDef
		{
			get => GetPropertyValue<CHandle<UI_SystemDef>>();
			set => SetPropertyValue<CHandle<UI_SystemDef>>(value);
		}

		[Ordinal(52)] 
		[RED("isInMenuCallbackID")] 
		public CHandle<redCallbackObject> IsInMenuCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(53)] 
		[RED("equipmentUIBlackboard")] 
		public CWeakHandle<gameIBlackboard> EquipmentUIBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(54)] 
		[RED("EquipmentBlackboardDef")] 
		public CHandle<UI_EquipmentDef> EquipmentBlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_EquipmentDef>>();
			set => SetPropertyValue<CHandle<UI_EquipmentDef>>(value);
		}

		[Ordinal(55)] 
		[RED("equipmentUICallbackID")] 
		public CHandle<redCallbackObject> EquipmentUICallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(56)] 
		[RED("cineCamUIBlackboard")] 
		public CWeakHandle<gameIBlackboard> CineCamUIBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(57)] 
		[RED("AutodriveBlackboardDef")] 
		public CHandle<UI_AutodriveDataDef> AutodriveBlackboardDef
		{
			get => GetPropertyValue<CHandle<UI_AutodriveDataDef>>();
			set => SetPropertyValue<CHandle<UI_AutodriveDataDef>>(value);
		}

		[Ordinal(58)] 
		[RED("cineCamUICallbackID")] 
		public CHandle<redCallbackObject> CineCamUICallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(59)] 
		[RED("dbg_int")] 
		public CInt32 Dbg_int
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(60)] 
		[RED("dbg_layers")] 
		public CArray<CUInt32> Dbg_layers
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		[Ordinal(61)] 
		[RED("dbg_activeSlotLayers")] 
		public CArray<CUInt32> Dbg_activeSlotLayers
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public RadialWheelController()
		{
			RadialWeapons = new();
			PointerRef = new inkWidgetReference();
			ToPatternTabHideWidgetRef = new(6);
			PatternPanelWidgetRef = new inkWidgetReference();
			PrevTabButtonRef = new inkWidgetReference();
			NextTabButtonRef = new inkWidgetReference();
			TabButtonRef = new(2);
			TabButtonLabelRef = new(2);
			TabButtonBkgRef = new(2);
			ActiveTab = -1;
			ConsSlotCachedData = new gameInventoryItemData();
			GadgetSlotCachedData = new gameInventoryItemData();
			RegisteredInputHints = new();
			ApplyInputHint = new gameuiInputHintData();
			CycleInputHintDataLeft = new gameuiInputHintData();
			CycleInputHintDataRight = new gameuiInputHintData();
			UI_MoveUpInputHint = new gameuiInputHintData();
			UI_MoveDownInputHint = new gameuiInputHintData();
			InspectWeaponsInputHint = new gameuiInputHintData();
			RadialMode = Enums.ERadialMode.ApplyActiveSlotAndConsumables;
			Dbg_layers = new();
			Dbg_activeSlotLayers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
