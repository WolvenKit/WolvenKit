using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemChooserItemChanged : redEvent
	{
		[Ordinal(0)] [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(1)] [RED("itemEquipmentArea")] public CEnum<gamedataEquipmentArea> ItemEquipmentArea { get; set; }
		[Ordinal(2)] [RED("slotIndex")] public CInt32 SlotIndex { get; set; }
		[Ordinal(3)] [RED("slotID")] public TweakDBID SlotID { get; set; }

		public ItemChooserItemChanged(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
