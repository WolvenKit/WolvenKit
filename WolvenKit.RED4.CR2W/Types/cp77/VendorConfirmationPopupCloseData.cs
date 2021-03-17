using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorConfirmationPopupCloseData : inkGameNotificationData
	{
		private CBool _confirm;
		private InventoryItemData _itemData;
		private CInt32 _quantity;

		[Ordinal(6)] 
		[RED("confirm")] 
		public CBool Confirm
		{
			get => GetProperty(ref _confirm);
			set => SetProperty(ref _confirm, value);
		}

		[Ordinal(7)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(8)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		public VendorConfirmationPopupCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
