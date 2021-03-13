using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackpackEquipSlotChooserData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("item")] public InventoryItemData Item { get; set; }
		[Ordinal(7)] [RED("inventoryManager")] public CHandle<InventoryDataManagerV2> InventoryManager { get; set; }

		public BackpackEquipSlotChooserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
