using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class OpenInventoryQuantityPickerRequest : redEvent
	{
		[Ordinal(0)]  [RED("actionType")] public CEnum<QuantityPickerActionType> ActionType { get; set; }
		[Ordinal(1)]  [RED("itemData")] public InventoryItemData ItemData { get; set; }

		public OpenInventoryQuantityPickerRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
