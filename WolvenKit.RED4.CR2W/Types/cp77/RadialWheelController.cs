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
			get
			{
				if (_radialWeapons == null)
				{
					_radialWeapons = (CArray<CHandle<WeaponRadialSlot>>) CR2WTypeManager.Create("array:handle:WeaponRadialSlot", "radialWeapons", cr2w, this);
				}
				return _radialWeapons;
			}
			set
			{
				if (_radialWeapons == value)
				{
					return;
				}
				_radialWeapons = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("inputHintController")] 
		public CHandle<RadialSlot> InputHintController
		{
			get
			{
				if (_inputHintController == null)
				{
					_inputHintController = (CHandle<RadialSlot>) CR2WTypeManager.Create("handle:RadialSlot", "inputHintController", cr2w, this);
				}
				return _inputHintController;
			}
			set
			{
				if (_inputHintController == value)
				{
					return;
				}
				_inputHintController = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("activeSlotTooltip")] 
		public CHandle<RadialSlot> ActiveSlotTooltip
		{
			get
			{
				if (_activeSlotTooltip == null)
				{
					_activeSlotTooltip = (CHandle<RadialSlot>) CR2WTypeManager.Create("handle:RadialSlot", "activeSlotTooltip", cr2w, this);
				}
				return _activeSlotTooltip;
			}
			set
			{
				if (_activeSlotTooltip == value)
				{
					return;
				}
				_activeSlotTooltip = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("statusEffects")] 
		public CHandle<RadialSlot> StatusEffects
		{
			get
			{
				if (_statusEffects == null)
				{
					_statusEffects = (CHandle<RadialSlot>) CR2WTypeManager.Create("handle:RadialSlot", "statusEffects", cr2w, this);
				}
				return _statusEffects;
			}
			set
			{
				if (_statusEffects == value)
				{
					return;
				}
				_statusEffects = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("pointerRef")] 
		public inkWidgetReference PointerRef
		{
			get
			{
				if (_pointerRef == null)
				{
					_pointerRef = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "pointerRef", cr2w, this);
				}
				return _pointerRef;
			}
			set
			{
				if (_pointerRef == value)
				{
					return;
				}
				_pointerRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("activeSlot")] 
		public CHandle<WeaponRadialSlot> ActiveSlot
		{
			get
			{
				if (_activeSlot == null)
				{
					_activeSlot = (CHandle<WeaponRadialSlot>) CR2WTypeManager.Create("handle:WeaponRadialSlot", "activeSlot", cr2w, this);
				}
				return _activeSlot;
			}
			set
			{
				if (_activeSlot == value)
				{
					return;
				}
				_activeSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("pointer")] 
		public CHandle<PointerController> Pointer
		{
			get
			{
				if (_pointer == null)
				{
					_pointer = (CHandle<PointerController>) CR2WTypeManager.Create("handle:PointerController", "pointer", cr2w, this);
				}
				return _pointer;
			}
			set
			{
				if (_pointer == value)
				{
					return;
				}
				_pointer = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("activeIndex")] 
		public CInt32 ActiveIndex
		{
			get
			{
				if (_activeIndex == null)
				{
					_activeIndex = (CInt32) CR2WTypeManager.Create("Int32", "activeIndex", cr2w, this);
				}
				return _activeIndex;
			}
			set
			{
				if (_activeIndex == value)
				{
					return;
				}
				_activeIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get
			{
				if (_initialized == null)
				{
					_initialized = (CBool) CR2WTypeManager.Create("Bool", "initialized", cr2w, this);
				}
				return _initialized;
			}
			set
			{
				if (_initialized == value)
				{
					return;
				}
				_initialized = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get
			{
				if (_isActive == null)
				{
					_isActive = (CBool) CR2WTypeManager.Create("Bool", "isActive", cr2w, this);
				}
				return _isActive;
			}
			set
			{
				if (_isActive == value)
				{
					return;
				}
				_isActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("consSlotCachedData")] 
		public InventoryItemData ConsSlotCachedData
		{
			get
			{
				if (_consSlotCachedData == null)
				{
					_consSlotCachedData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "consSlotCachedData", cr2w, this);
				}
				return _consSlotCachedData;
			}
			set
			{
				if (_consSlotCachedData == value)
				{
					return;
				}
				_consSlotCachedData = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("gadgetSlotCachedData")] 
		public InventoryItemData GadgetSlotCachedData
		{
			get
			{
				if (_gadgetSlotCachedData == null)
				{
					_gadgetSlotCachedData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "gadgetSlotCachedData", cr2w, this);
				}
				return _gadgetSlotCachedData;
			}
			set
			{
				if (_gadgetSlotCachedData == value)
				{
					return;
				}
				_gadgetSlotCachedData = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("cyclingActionRegistered")] 
		public CName CyclingActionRegistered
		{
			get
			{
				if (_cyclingActionRegistered == null)
				{
					_cyclingActionRegistered = (CName) CR2WTypeManager.Create("CName", "cyclingActionRegistered", cr2w, this);
				}
				return _cyclingActionRegistered;
			}
			set
			{
				if (_cyclingActionRegistered == value)
				{
					return;
				}
				_cyclingActionRegistered = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("registeredInputHints")] 
		public CArray<gameuiInputHintData> RegisteredInputHints
		{
			get
			{
				if (_registeredInputHints == null)
				{
					_registeredInputHints = (CArray<gameuiInputHintData>) CR2WTypeManager.Create("array:gameuiInputHintData", "registeredInputHints", cr2w, this);
				}
				return _registeredInputHints;
			}
			set
			{
				if (_registeredInputHints == value)
				{
					return;
				}
				_registeredInputHints = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("applyInputHint")] 
		public gameuiInputHintData ApplyInputHint
		{
			get
			{
				if (_applyInputHint == null)
				{
					_applyInputHint = (gameuiInputHintData) CR2WTypeManager.Create("gameuiInputHintData", "applyInputHint", cr2w, this);
				}
				return _applyInputHint;
			}
			set
			{
				if (_applyInputHint == value)
				{
					return;
				}
				_applyInputHint = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("cycleInputHintDataLeft")] 
		public gameuiInputHintData CycleInputHintDataLeft
		{
			get
			{
				if (_cycleInputHintDataLeft == null)
				{
					_cycleInputHintDataLeft = (gameuiInputHintData) CR2WTypeManager.Create("gameuiInputHintData", "cycleInputHintDataLeft", cr2w, this);
				}
				return _cycleInputHintDataLeft;
			}
			set
			{
				if (_cycleInputHintDataLeft == value)
				{
					return;
				}
				_cycleInputHintDataLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("cycleInputHintDataRight")] 
		public gameuiInputHintData CycleInputHintDataRight
		{
			get
			{
				if (_cycleInputHintDataRight == null)
				{
					_cycleInputHintDataRight = (gameuiInputHintData) CR2WTypeManager.Create("gameuiInputHintData", "cycleInputHintDataRight", cr2w, this);
				}
				return _cycleInputHintDataRight;
			}
			set
			{
				if (_cycleInputHintDataRight == value)
				{
					return;
				}
				_cycleInputHintDataRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("radialMode")] 
		public CEnum<ERadialMode> RadialMode
		{
			get
			{
				if (_radialMode == null)
				{
					_radialMode = (CEnum<ERadialMode>) CR2WTypeManager.Create("ERadialMode", "radialMode", cr2w, this);
				}
				return _radialMode;
			}
			set
			{
				if (_radialMode == value)
				{
					return;
				}
				_radialMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get
			{
				if (_inventoryManager == null)
				{
					_inventoryManager = (CHandle<InventoryDataManagerV2>) CR2WTypeManager.Create("handle:InventoryDataManagerV2", "inventoryManager", cr2w, this);
				}
				return _inventoryManager;
			}
			set
			{
				if (_inventoryManager == value)
				{
					return;
				}
				_inventoryManager = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("equipmentSystem")] 
		public wCHandle<EquipmentSystem> EquipmentSystem
		{
			get
			{
				if (_equipmentSystem == null)
				{
					_equipmentSystem = (wCHandle<EquipmentSystem>) CR2WTypeManager.Create("whandle:EquipmentSystem", "equipmentSystem", cr2w, this);
				}
				return _equipmentSystem;
			}
			set
			{
				if (_equipmentSystem == value)
				{
					return;
				}
				_equipmentSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("transactionSystem")] 
		public wCHandle<gameTransactionSystem> TransactionSystem
		{
			get
			{
				if (_transactionSystem == null)
				{
					_transactionSystem = (wCHandle<gameTransactionSystem>) CR2WTypeManager.Create("whandle:gameTransactionSystem", "transactionSystem", cr2w, this);
				}
				return _transactionSystem;
			}
			set
			{
				if (_transactionSystem == value)
				{
					return;
				}
				_transactionSystem = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("quickSlotBlackboard")] 
		public CHandle<gameIBlackboard> QuickSlotBlackboard
		{
			get
			{
				if (_quickSlotBlackboard == null)
				{
					_quickSlotBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "quickSlotBlackboard", cr2w, this);
				}
				return _quickSlotBlackboard;
			}
			set
			{
				if (_quickSlotBlackboard == value)
				{
					return;
				}
				_quickSlotBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("QuickSlotBlackboardDef")] 
		public CHandle<UI_QuickSlotsDataDef> QuickSlotBlackboardDef
		{
			get
			{
				if (_quickSlotBlackboardDef == null)
				{
					_quickSlotBlackboardDef = (CHandle<UI_QuickSlotsDataDef>) CR2WTypeManager.Create("handle:UI_QuickSlotsDataDef", "QuickSlotBlackboardDef", cr2w, this);
				}
				return _quickSlotBlackboardDef;
			}
			set
			{
				if (_quickSlotBlackboardDef == value)
				{
					return;
				}
				_quickSlotBlackboardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("axisInputCallbackID")] 
		public CUInt32 AxisInputCallbackID
		{
			get
			{
				if (_axisInputCallbackID == null)
				{
					_axisInputCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "axisInputCallbackID", cr2w, this);
				}
				return _axisInputCallbackID;
			}
			set
			{
				if (_axisInputCallbackID == value)
				{
					return;
				}
				_axisInputCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("UISystemBB")] 
		public CHandle<gameIBlackboard> UISystemBB
		{
			get
			{
				if (_uISystemBB == null)
				{
					_uISystemBB = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "UISystemBB", cr2w, this);
				}
				return _uISystemBB;
			}
			set
			{
				if (_uISystemBB == value)
				{
					return;
				}
				_uISystemBB = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("UISystemDef")] 
		public CHandle<UI_SystemDef> UISystemDef
		{
			get
			{
				if (_uISystemDef == null)
				{
					_uISystemDef = (CHandle<UI_SystemDef>) CR2WTypeManager.Create("handle:UI_SystemDef", "UISystemDef", cr2w, this);
				}
				return _uISystemDef;
			}
			set
			{
				if (_uISystemDef == value)
				{
					return;
				}
				_uISystemDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("isInMenuCallbackID")] 
		public CUInt32 IsInMenuCallbackID
		{
			get
			{
				if (_isInMenuCallbackID == null)
				{
					_isInMenuCallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "isInMenuCallbackID", cr2w, this);
				}
				return _isInMenuCallbackID;
			}
			set
			{
				if (_isInMenuCallbackID == value)
				{
					return;
				}
				_isInMenuCallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("equipmentUIBlackboard")] 
		public CHandle<gameIBlackboard> EquipmentUIBlackboard
		{
			get
			{
				if (_equipmentUIBlackboard == null)
				{
					_equipmentUIBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "equipmentUIBlackboard", cr2w, this);
				}
				return _equipmentUIBlackboard;
			}
			set
			{
				if (_equipmentUIBlackboard == value)
				{
					return;
				}
				_equipmentUIBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("EquipmentBlackboardDef")] 
		public CHandle<UI_EquipmentDef> EquipmentBlackboardDef
		{
			get
			{
				if (_equipmentBlackboardDef == null)
				{
					_equipmentBlackboardDef = (CHandle<UI_EquipmentDef>) CR2WTypeManager.Create("handle:UI_EquipmentDef", "EquipmentBlackboardDef", cr2w, this);
				}
				return _equipmentBlackboardDef;
			}
			set
			{
				if (_equipmentBlackboardDef == value)
				{
					return;
				}
				_equipmentBlackboardDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("equipmentUICallbackID")] 
		public CUInt32 EquipmentUICallbackID
		{
			get
			{
				if (_equipmentUICallbackID == null)
				{
					_equipmentUICallbackID = (CUInt32) CR2WTypeManager.Create("Uint32", "equipmentUICallbackID", cr2w, this);
				}
				return _equipmentUICallbackID;
			}
			set
			{
				if (_equipmentUICallbackID == value)
				{
					return;
				}
				_equipmentUICallbackID = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("dbg_int")] 
		public CInt32 Dbg_int
		{
			get
			{
				if (_dbg_int == null)
				{
					_dbg_int = (CInt32) CR2WTypeManager.Create("Int32", "dbg_int", cr2w, this);
				}
				return _dbg_int;
			}
			set
			{
				if (_dbg_int == value)
				{
					return;
				}
				_dbg_int = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("dbg_layers")] 
		public CArray<CUInt32> Dbg_layers
		{
			get
			{
				if (_dbg_layers == null)
				{
					_dbg_layers = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "dbg_layers", cr2w, this);
				}
				return _dbg_layers;
			}
			set
			{
				if (_dbg_layers == value)
				{
					return;
				}
				_dbg_layers = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("dbg_activeSlotLayers")] 
		public CArray<CUInt32> Dbg_activeSlotLayers
		{
			get
			{
				if (_dbg_activeSlotLayers == null)
				{
					_dbg_activeSlotLayers = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "dbg_activeSlotLayers", cr2w, this);
				}
				return _dbg_activeSlotLayers;
			}
			set
			{
				if (_dbg_activeSlotLayers == value)
				{
					return;
				}
				_dbg_activeSlotLayers = value;
				PropertySet(this);
			}
		}

		public RadialWheelController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
