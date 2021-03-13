using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorConfirmationPopupCloseData : inkGameNotificationData
	{
		[Ordinal(6)] [RED("confirm")] public CBool Confirm { get; set; }
		[Ordinal(7)] [RED("itemData")] public InventoryItemData ItemData { get; set; }
		[Ordinal(8)] [RED("quantity")] public CInt32 Quantity { get; set; }

		public VendorConfirmationPopupCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
