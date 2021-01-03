using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class QuantityPickerPopupData : inkGameNotificationData
	{
		[Ordinal(0)]  [RED("actionType")] public CEnum<QuantityPickerActionType> ActionType { get; set; }
		[Ordinal(1)]  [RED("gameItemData")] public InventoryItemData GameItemData { get; set; }
		[Ordinal(2)]  [RED("isBuyback")] public CBool IsBuyback { get; set; }
		[Ordinal(3)]  [RED("maxValue")] public CInt32 MaxValue { get; set; }
		[Ordinal(4)]  [RED("vendor")] public wCHandle<gameObject> Vendor { get; set; }

		public QuantityPickerPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
