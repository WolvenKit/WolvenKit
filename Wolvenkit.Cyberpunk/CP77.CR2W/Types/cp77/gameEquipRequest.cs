using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEquipRequest : gamePlayerScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("addToInventory")] public CBool AddToInventory { get; set; }
		[Ordinal(1)]  [RED("equipToCurrentActiveSlot")] public CBool EquipToCurrentActiveSlot { get; set; }
		[Ordinal(2)]  [RED("itemID")] public gameItemID ItemID { get; set; }
		[Ordinal(3)]  [RED("slotIndex")] public CInt32 SlotIndex { get; set; }

		public gameEquipRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
