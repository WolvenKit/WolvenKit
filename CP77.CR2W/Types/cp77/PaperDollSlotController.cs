using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PaperDollSlotController : inkButtonDpadSupportedController
	{
		[Ordinal(26)] [RED("equipArea")] public CEnum<gamedataEquipmentArea> EquipArea { get; set; }
		[Ordinal(27)] [RED("slotIndex")] public CInt32 SlotIndex { get; set; }
		[Ordinal(28)] [RED("areaTags")] public CArray<CName> AreaTags { get; set; }
		[Ordinal(29)] [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(30)] [RED("slotName")] public CString SlotName { get; set; }
		[Ordinal(31)] [RED("itemData")] public CHandle<gameItemData> ItemData { get; set; }
		[Ordinal(32)] [RED("locked")] public CBool Locked { get; set; }

		public PaperDollSlotController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
