using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryWeaponSlot : InventoryEquipmentSlot
	{
		[Ordinal(0)]  [RED("EquipSlotRef")] public inkWidgetReference EquipSlotRef { get; set; }
		[Ordinal(1)]  [RED("EmptySlotButtonRef")] public inkWidgetReference EmptySlotButtonRef { get; set; }
		[Ordinal(2)]  [RED("BackgroundShape")] public inkImageWidgetReference BackgroundShape { get; set; }
		[Ordinal(3)]  [RED("BackgroundHighlight")] public inkImageWidgetReference BackgroundHighlight { get; set; }
		[Ordinal(4)]  [RED("BackgroundFrame")] public inkImageWidgetReference BackgroundFrame { get; set; }
		[Ordinal(5)]  [RED("unavailableIcon")] public inkWidgetReference UnavailableIcon { get; set; }
		[Ordinal(6)]  [RED("toggleHighlight")] public inkImageWidgetReference ToggleHighlight { get; set; }
		[Ordinal(7)]  [RED("CurrentItemView")] public wCHandle<InventoryItemDisplayController> CurrentItemView { get; set; }
		[Ordinal(8)]  [RED("Empty")] public CBool Empty { get; set; }
		[Ordinal(9)]  [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(10)]  [RED("equipmentArea")] public CEnum<gamedataEquipmentArea> EquipmentArea { get; set; }
		[Ordinal(11)]  [RED("slotName")] public CString SlotName { get; set; }
		[Ordinal(12)]  [RED("slotIndex")] public CInt32 SlotIndex { get; set; }
		[Ordinal(13)]  [RED("DisableSlot")] public CBool DisableSlot { get; set; }
		[Ordinal(14)]  [RED("smallSize")] public Vector2 SmallSize { get; set; }
		[Ordinal(15)]  [RED("bigSize")] public Vector2 BigSize { get; set; }
		[Ordinal(16)]  [RED("DamageIndicatorRef")] public inkWidgetReference DamageIndicatorRef { get; set; }
		[Ordinal(17)]  [RED("DPSRef")] public inkWidgetReference DPSRef { get; set; }
		[Ordinal(18)]  [RED("DPSValueLabel")] public inkTextWidgetReference DPSValueLabel { get; set; }
		[Ordinal(19)]  [RED("DamageTypeIndicator")] public wCHandle<DamageTypeIndicator> DamageTypeIndicator { get; set; }
		[Ordinal(20)]  [RED("IntroPlayed")] public CBool IntroPlayed { get; set; }

		public InventoryWeaponSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
