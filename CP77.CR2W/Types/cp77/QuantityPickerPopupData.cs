using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuantityPickerPopupData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("maxValue")] public CInt32 MaxValue { get; set; }
		[Ordinal(7)] [RED("gameItemData")] public InventoryItemData GameItemData { get; set; }
		[Ordinal(8)] [RED("actionType")] public CEnum<QuantityPickerActionType> ActionType { get; set; }
		[Ordinal(9)] [RED("vendor")] public wCHandle<gameObject> Vendor { get; set; }
		[Ordinal(10)] [RED("isBuyback")] public CBool IsBuyback { get; set; }

		public QuantityPickerPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
