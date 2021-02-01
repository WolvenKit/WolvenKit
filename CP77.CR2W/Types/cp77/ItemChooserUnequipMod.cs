using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ItemChooserUnequipMod : redEvent
	{
		[Ordinal(0)]  [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(1)]  [RED("slotID")] public TweakDBID SlotID { get; set; }

		public ItemChooserUnequipMod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
