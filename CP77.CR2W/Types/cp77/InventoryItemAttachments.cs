using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InventoryItemAttachments : CVariable
	{
		[Ordinal(0)]  [RED("SlotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(1)]  [RED("ItemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(2)]  [RED("SlotName")] public CString SlotName { get; set; }
		[Ordinal(3)]  [RED("SlotType")] public CEnum<gameInventoryItemAttachmentType> SlotType { get; set; }

		public InventoryItemAttachments(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
