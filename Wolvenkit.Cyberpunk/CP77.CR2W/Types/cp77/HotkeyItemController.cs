using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HotkeyItemController : GenericHotkeyController
	{
		[Ordinal(0)]  [RED("currentItem")] public InventoryItemData CurrentItem { get; set; }
		[Ordinal(1)]  [RED("equipmentSystem")] public wCHandle<EquipmentSystem> EquipmentSystem { get; set; }
		[Ordinal(2)]  [RED("hotkeyBlackboard")] public CHandle<gameIBlackboard> HotkeyBlackboard { get; set; }
		[Ordinal(3)]  [RED("hotkeyCallbackID")] public CUInt32 HotkeyCallbackID { get; set; }
		[Ordinal(4)]  [RED("hotkeyItemController")] public CHandle<InventoryItemDisplayController> _HotkeyItemController { get; set; }
		[Ordinal(5)]  [RED("hotkeyItemSlot")] public inkWidgetReference HotkeyItemSlot { get; set; }
		[Ordinal(6)]  [RED("inventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }

		public HotkeyItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
