using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackpackEquipSlotChooserCloseData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("confirm")] public CBool Confirm { get; set; }
		[Ordinal(7)] [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(8)] [RED("slotIndex")] public CInt32 SlotIndex { get; set; }

		public BackpackEquipSlotChooserCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
