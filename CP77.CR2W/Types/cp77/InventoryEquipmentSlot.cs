using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryEquipmentSlot : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("EquipSlotRef")] public inkWidgetReference EquipSlotRef { get; set; }
		[Ordinal(2)] [RED("EmptySlotButtonRef")] public inkWidgetReference EmptySlotButtonRef { get; set; }
		[Ordinal(3)] [RED("BackgroundShape")] public inkImageWidgetReference BackgroundShape { get; set; }
		[Ordinal(4)] [RED("BackgroundHighlight")] public inkImageWidgetReference BackgroundHighlight { get; set; }
		[Ordinal(5)] [RED("BackgroundFrame")] public inkImageWidgetReference BackgroundFrame { get; set; }
		[Ordinal(6)] [RED("unavailableIcon")] public inkWidgetReference UnavailableIcon { get; set; }
		[Ordinal(7)] [RED("toggleHighlight")] public inkImageWidgetReference ToggleHighlight { get; set; }
		[Ordinal(8)] [RED("CurrentItemView")] public wCHandle<InventoryItemDisplayController> CurrentItemView { get; set; }
		[Ordinal(9)] [RED("Empty")] public CBool Empty { get; set; }
		[Ordinal(10)] [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(11)] [RED("equipmentArea")] public CEnum<gamedataEquipmentArea> EquipmentArea { get; set; }
		[Ordinal(12)] [RED("slotName")] public CString SlotName { get; set; }
		[Ordinal(13)] [RED("slotIndex")] public CInt32 SlotIndex { get; set; }
		[Ordinal(14)] [RED("DisableSlot")] public CBool DisableSlot { get; set; }
		[Ordinal(15)] [RED("smallSize")] public Vector2 SmallSize { get; set; }
		[Ordinal(16)] [RED("bigSize")] public Vector2 BigSize { get; set; }

		public InventoryEquipmentSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
