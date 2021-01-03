using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class RadialWheelController : gameuiHUDGameController
	{
		[Ordinal(0)]  [RED("EquipmentBlackboardDef")] public CHandle<UI_EquipmentDef> EquipmentBlackboardDef { get; set; }
		[Ordinal(1)]  [RED("QuickSlotBlackboardDef")] public CHandle<UI_QuickSlotsDataDef> QuickSlotBlackboardDef { get; set; }
		[Ordinal(2)]  [RED("UISystemBB")] public CHandle<gameIBlackboard> UISystemBB { get; set; }
		[Ordinal(3)]  [RED("UISystemDef")] public CHandle<UI_SystemDef> UISystemDef { get; set; }
		[Ordinal(4)]  [RED("activeIndex")] public CInt32 ActiveIndex { get; set; }
		[Ordinal(5)]  [RED("activeSlot")] public CHandle<WeaponRadialSlot> ActiveSlot { get; set; }
		[Ordinal(6)]  [RED("activeSlotTooltip")] public CHandle<RadialSlot> ActiveSlotTooltip { get; set; }
		[Ordinal(7)]  [RED("applyInputHint")] public gameuiInputHintData ApplyInputHint { get; set; }
		[Ordinal(8)]  [RED("axisInputCallbackID")] public CUInt32 AxisInputCallbackID { get; set; }
		[Ordinal(9)]  [RED("consSlotCachedData")] public InventoryItemData ConsSlotCachedData { get; set; }
		[Ordinal(10)]  [RED("cycleInputHintDataLeft")] public gameuiInputHintData CycleInputHintDataLeft { get; set; }
		[Ordinal(11)]  [RED("cycleInputHintDataRight")] public gameuiInputHintData CycleInputHintDataRight { get; set; }
		[Ordinal(12)]  [RED("cyclingActionRegistered")] public CName CyclingActionRegistered { get; set; }
		[Ordinal(13)]  [RED("dbg_activeSlotLayers")] public CArray<CUInt32> Dbg_activeSlotLayers { get; set; }
		[Ordinal(14)]  [RED("dbg_int")] public CInt32 Dbg_int { get; set; }
		[Ordinal(15)]  [RED("dbg_layers")] public CArray<CUInt32> Dbg_layers { get; set; }
		[Ordinal(16)]  [RED("equipmentSystem")] public wCHandle<EquipmentSystem> EquipmentSystem { get; set; }
		[Ordinal(17)]  [RED("equipmentUIBlackboard")] public CHandle<gameIBlackboard> EquipmentUIBlackboard { get; set; }
		[Ordinal(18)]  [RED("equipmentUICallbackID")] public CUInt32 EquipmentUICallbackID { get; set; }
		[Ordinal(19)]  [RED("gadgetSlotCachedData")] public InventoryItemData GadgetSlotCachedData { get; set; }
		[Ordinal(20)]  [RED("initialized")] public CBool Initialized { get; set; }
		[Ordinal(21)]  [RED("inputHintController")] public CHandle<RadialSlot> InputHintController { get; set; }
		[Ordinal(22)]  [RED("inventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }
		[Ordinal(23)]  [RED("isActive")] public CBool IsActive { get; set; }
		[Ordinal(24)]  [RED("isInMenuCallbackID")] public CUInt32 IsInMenuCallbackID { get; set; }
		[Ordinal(25)]  [RED("pointer")] public CHandle<PointerController> Pointer { get; set; }
		[Ordinal(26)]  [RED("pointerRef")] public inkWidgetReference PointerRef { get; set; }
		[Ordinal(27)]  [RED("quickSlotBlackboard")] public CHandle<gameIBlackboard> QuickSlotBlackboard { get; set; }
		[Ordinal(28)]  [RED("radialMode")] public CEnum<ERadialMode> RadialMode { get; set; }
		[Ordinal(29)]  [RED("radialWeapons")] public CArray<CHandle<WeaponRadialSlot>> RadialWeapons { get; set; }
		[Ordinal(30)]  [RED("registeredInputHints")] public CArray<gameuiInputHintData> RegisteredInputHints { get; set; }
		[Ordinal(31)]  [RED("statusEffects")] public CHandle<RadialSlot> StatusEffects { get; set; }
		[Ordinal(32)]  [RED("transactionSystem")] public wCHandle<gameTransactionSystem> TransactionSystem { get; set; }

		public RadialWheelController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
