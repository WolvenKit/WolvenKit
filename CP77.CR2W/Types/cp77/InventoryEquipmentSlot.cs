using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryEquipmentSlot : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("BackgroundFrame")] public inkImageWidgetReference BackgroundFrame { get; set; }
		[Ordinal(1)]  [RED("BackgroundHighlight")] public inkImageWidgetReference BackgroundHighlight { get; set; }
		[Ordinal(2)]  [RED("BackgroundShape")] public inkImageWidgetReference BackgroundShape { get; set; }
		[Ordinal(3)]  [RED("CurrentItemView")] public wCHandle<InventoryItemDisplayController> CurrentItemView { get; set; }
		[Ordinal(4)]  [RED("DisableSlot")] public CBool DisableSlot { get; set; }
		[Ordinal(5)]  [RED("Empty")] public CBool Empty { get; set; }
		[Ordinal(6)]  [RED("EmptySlotButtonRef")] public inkWidgetReference EmptySlotButtonRef { get; set; }
		[Ordinal(7)]  [RED("EquipSlotRef")] public inkWidgetReference EquipSlotRef { get; set; }
		[Ordinal(8)]  [RED("bigSize")] public Vector2 BigSize { get; set; }
		[Ordinal(9)]  [RED("equipmentArea")] public CEnum<gamedataEquipmentArea> EquipmentArea { get; set; }
		[Ordinal(10)]  [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(11)]  [RED("slotIndex")] public CInt32 SlotIndex { get; set; }
		[Ordinal(12)]  [RED("slotName")] public CString SlotName { get; set; }
		[Ordinal(13)]  [RED("smallSize")] public Vector2 SmallSize { get; set; }
		[Ordinal(14)]  [RED("toggleHighlight")] public inkImageWidgetReference ToggleHighlight { get; set; }
		[Ordinal(15)]  [RED("unavailableIcon")] public inkWidgetReference UnavailableIcon { get; set; }

		public InventoryEquipmentSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
