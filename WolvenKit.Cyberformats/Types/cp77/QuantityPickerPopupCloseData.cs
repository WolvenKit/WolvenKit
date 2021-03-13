using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class QuantityPickerPopupCloseData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("choosenQuantity")] public CInt32 ChoosenQuantity { get; set; }
		[Ordinal(7)] [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(8)] [RED("actionType")] public CEnum<QuantityPickerActionType> ActionType { get; set; }
		[Ordinal(9)] [RED("isBuyback")] public CBool IsBuyback { get; set; }

		public QuantityPickerPopupCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
