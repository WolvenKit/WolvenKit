using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BackpackEquipSlotChooserCloseData : inkGameNotificationData
	{
		[Ordinal(0)]  [RED("confirm")] public CBool Confirm { get; set; }
		[Ordinal(1)]  [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(2)]  [RED("slotIndex")] public CInt32 SlotIndex { get; set; }

		public BackpackEquipSlotChooserCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
