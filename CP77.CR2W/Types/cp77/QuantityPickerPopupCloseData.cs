using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuantityPickerPopupCloseData : inkGameNotificationData
	{
		[Ordinal(0)]  [RED("actionType")] public CEnum<QuantityPickerActionType> ActionType { get; set; }
		[Ordinal(1)]  [RED("choosenQuantity")] public CInt32 ChoosenQuantity { get; set; }
		[Ordinal(2)]  [RED("isBuyback")] public CBool IsBuyback { get; set; }
		[Ordinal(3)]  [RED("itemData")] public InventoryItemData ItemData { get; set; }

		public QuantityPickerPopupCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
