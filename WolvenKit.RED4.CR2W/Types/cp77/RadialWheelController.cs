using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadialWheelController : gameuiHUDGameController
	{
		private CArray<CHandle<WeaponRadialSlot>> _radialWeapons;
		private CHandle<RadialSlot> _inputHintController;
		private CHandle<RadialSlot> _activeSlotTooltip;
		private CHandle<RadialSlot> _statusEffects;
		private inkWidgetReference _pointerRef;
		private CHandle<WeaponRadialSlot> _activeSlot;
		private CHandle<PointerController> _pointer;
		private CInt32 _activeIndex;
		private CBool _initialized;
		private CBool _isActive;
		private InventoryItemData _consSlotCachedData;
		private InventoryItemData _gadgetSlotCachedData;
		private CName _cyclingActionRegistered;
		private CArray<gameuiInputHintData> _registeredInputHints;
		private gameuiInputHintData _applyInputHint;
		private gameuiInputHintData _cycleInputHintDataLeft;
		private gameuiInputHintData _cycleInputHintDataRight;
		private CEnum<ERadialMode> _radialMode;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<EquipmentSystem> _equipmentSystem;
		private wCHandle<gameTransactionSystem> _transactionSystem;
		private CHandle<gameIBlackboard> _quickSlotBlackboard;
		private CHandle<UI_QuickSlotsDataDef> _quickSlotBlackboardDef;
		private CUInt32 _axisInputCallbackID;
		private CHandle<gameIBlackboard> _uISystemBB;
		private CHandle<UI_SystemDef> _uISystemDef;
		private CUInt32 _isInMenuCallbackID;
		private CHandle<gameIBlackboard> _equipmentUIBlackboard;
		private CHandle<UI_EquipmentDef> _equipmentBlackboardDef;
		private CUInt32 _equipmentUICallbackID;
		private CInt32 _dbg_int;
		private CArray<CUInt32> _dbg_layers;
		private CArray<CUInt32> _dbg_activeSlotLayers;

		[Ordinal(9)] 
		[RED("radialWeapons")] 
		public CArray<CHandle<WeaponRadialSlot>> RadialWeapons
		{
			get => GetProperty(ref _radialWeapons);
			set => SetProperty(ref _radialWeapons, value);
		}

		[Ordinal(10)] 
		[RED("inputHintController")] 
		public CHandle<RadialSlot> InputHintController
		{
			get => GetProperty(ref _inputHintController);
			set => SetProperty(ref _inputHintController, value);
		}

		[Ordinal(11)] 
		[RED("activeSlotTooltip")] 
		public CHandle<RadialSlot> ActiveSlotTooltip
		{
			get => GetProperty(ref _activeSlotTooltip);
			set => SetProperty(ref _activeSlotTooltip, value);
		}

		[Ordinal(12)] 
		[RED("statusEffects")] 
		public CHandle<RadialSlot> StatusEffects
		{
			get => GetProperty(ref _statusEffects);
			set => SetProperty(ref _statusEffects, value);
		}

		[Ordinal(13)] 
		[RED("pointerRef")] 
		public inkWidgetReference PointerRef
		{
			get => GetProperty(ref _pointerRef);
			set => SetProperty(ref _pointerRef, value);
		}

		[Ordinal(14)] 
		[RED("activeSlot")] 
		public CHandle<WeaponRadialSlot> ActiveSlot
		{
			get => GetProperty(ref _activeSlot);
			set => SetProperty(ref _activeSlot, value);
		}

		[Ordinal(15)] 
		[RED("pointer")] 
		public CHandle<PointerController> Pointer
		{
			get => GetProperty(ref _pointer);
			set => SetProperty(ref _pointer, value);
		}

		[Ordinal(16)] 
		[RED("activeIndex")] 
		public CInt32 ActiveIndex
		{
			get => GetProperty(ref _activeIndex);
			set => SetProperty(ref _activeIndex, value);
		}

		[Ordinal(17)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetProperty(ref _initialized);
			set => SetProperty(ref _initialized, value);
		}

		[Ordinal(18)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(19)] 
		[RED("consSlotCachedData")] 
		public InventoryItemData ConsSlotCachedData
		{
			get => GetProperty(ref _consSlotCachedData);
			set => SetProperty(ref _consSlotCachedData, value);
		}

		[Ordinal(20)] 
		[RED("gadgetSlotCachedData")] 
		public InventoryItemData GadgetSlotCachedData
		{
			get => GetProperty(ref _gadgetSlotCachedData);
			set => SetProperty(ref _gadgetSlotCachedData, value);
		}

		[Ordinal(21)] 
		[RED("cyclingActionRegistered")] 
		public CName CyclingActionRegistered
		{
			get => GetProperty(ref _cyclingActionRegistered);
			set => SetProperty(ref _cyclingActionRegistered, value);
		}

		[Ordinal(22)] 
		[RED("registeredInputHints")] 
		public CArray<gameuiInputHintData> RegisteredInputHints
		{
			get => GetProperty(ref _registeredInputHints);
			set => SetProperty(ref _registeredInputHints, value);
		}

		[Ordinal(23)] 
		[RED("applyInputHint")] 
		public gameuiInputHintData ApplyInputHint
		{
			get => GetProperty(ref _applyInputHint);
			set => SetProperty(ref _applyInputHint, value);
		}

		[Ordinal(24)] 
		[RED("cycleInputHintDataLeft")] 
		public gameuiInputHintData CycleInputHintDataLeft
		{
			get => GetProperty(ref _cycleInputHintDataLeft);
			set => SetProperty(ref _cycleInputHintDataLeft, value);
		}

		[Ordinal(25)] 
		[RED("cycleInputHintDataRight")] 
		public gameuiInputHintData CycleInputHintDataRight
		{
			get => GetProperty(ref _cycleInputHintDataRight);
			set => SetProperty(ref _cycleInputHintDataRight, value);
		}

		[Ordinal(26)] 
		[RED("radialMode")] 
		public CEnum<ERadialMode> RadialMode
		{
			get => GetProperty(ref _radialMode);
			set => SetProperty(ref _radialMode, value);
		}

		[Ordinal(27)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(28)] 
		[RED("equipmentSystem")] 
		public wCHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetProperty(ref _equipmentSystem);
			set => SetProperty(ref _equipmentSystem, value);
		}

		[Ordinal(29)] 
		[RED("transactionSystem")] 
		public wCHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(30)] 
		[RED("quickSlotBlackboard")] 
		public CHandle<gameIBlackboard> QuickSlotBlackboard
		{
			get => GetProperty(ref _quickSlotBlackboard);
			set => SetProperty(ref _quickSlotBlackboard, value);
		}

		[Ordinal(31)] 
		[RED("QuickSlotBlackboardDef")] 
		public CHandle<UI_QuickSlotsDataDef> QuickSlotBlackboardDef
		{
			get => GetProperty(ref _quickSlotBlackboardDef);
			set => SetProperty(ref _quickSlotBlackboardDef, value);
		}

		[Ordinal(32)] 
		[RED("axisInputCallbackID")] 
		public CUInt32 AxisInputCallbackID
		{
			get => GetProperty(ref _axisInputCallbackID);
			set => SetProperty(ref _axisInputCallbackID, value);
		}

		[Ordinal(33)] 
		[RED("UISystemBB")] 
		public CHandle<gameIBlackboard> UISystemBB
		{
			get => GetProperty(ref _uISystemBB);
			set => SetProperty(ref _uISystemBB, value);
		}

		[Ordinal(34)] 
		[RED("UISystemDef")] 
		public CHandle<UI_SystemDef> UISystemDef
		{
			get => GetProperty(ref _uISystemDef);
			set => SetProperty(ref _uISystemDef, value);
		}

		[Ordinal(35)] 
		[RED("isInMenuCallbackID")] 
		public CUInt32 IsInMenuCallbackID
		{
			get => GetProperty(ref _isInMenuCallbackID);
			set => SetProperty(ref _isInMenuCallbackID, value);
		}

		[Ordinal(36)] 
		[RED("equipmentUIBlackboard")] 
		public CHandle<gameIBlackboard> EquipmentUIBlackboard
		{
			get => GetProperty(ref _equipmentUIBlackboard);
			set => SetProperty(ref _equipmentUIBlackboard, value);
		}

		[Ordinal(37)] 
		[RED("EquipmentBlackboardDef")] 
		public CHandle<UI_EquipmentDef> EquipmentBlackboardDef
		{
			get => GetProperty(ref _equipmentBlackboardDef);
			set => SetProperty(ref _equipmentBlackboardDef, value);
		}

		[Ordinal(38)] 
		[RED("equipmentUICallbackID")] 
		public CUInt32 EquipmentUICallbackID
		{
			get => GetProperty(ref _equipmentUICallbackID);
			set => SetProperty(ref _equipmentUICallbackID, value);
		}

		[Ordinal(39)] 
		[RED("dbg_int")] 
		public CInt32 Dbg_int
		{
			get => GetProperty(ref _dbg_int);
			set => SetProperty(ref _dbg_int, value);
		}

		[Ordinal(40)] 
		[RED("dbg_layers")] 
		public CArray<CUInt32> Dbg_layers
		{
			get => GetProperty(ref _dbg_layers);
			set => SetProperty(ref _dbg_layers, value);
		}

		[Ordinal(41)] 
		[RED("dbg_activeSlotLayers")] 
		public CArray<CUInt32> Dbg_activeSlotLayers
		{
			get => GetProperty(ref _dbg_activeSlotLayers);
			set => SetProperty(ref _dbg_activeSlotLayers, value);
		}

		public RadialWheelController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
