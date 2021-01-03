using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PaperDollSlotController : inkButtonDpadSupportedController
	{
		[Ordinal(0)]  [RED("areaTags")] public CArray<CName> AreaTags { get; set; }
		[Ordinal(1)]  [RED("equipArea")] public CEnum<gamedataEquipmentArea> EquipArea { get; set; }
		[Ordinal(2)]  [RED("itemData")] public CHandle<gameItemData> ItemData { get; set; }
		[Ordinal(3)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(4)]  [RED("locked")] public CBool Locked { get; set; }
		[Ordinal(5)]  [RED("slotIndex")] public CInt32 SlotIndex { get; set; }
		[Ordinal(6)]  [RED("slotName")] public CString SlotName { get; set; }

		public PaperDollSlotController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
