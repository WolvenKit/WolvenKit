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
			get
			{
				if (_confirm == null)
				{
					_confirm = (CBool) CR2WTypeManager.Create("Bool", "confirm", cr2w, this);
				}
				return _confirm;
			}
			set
			{
				if (_confirm == value)
				{
					return;
				}
				_confirm = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get
			{
				if (_itemData == null)
				{
					_itemData = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "itemData", cr2w, this);
				}
				return _itemData;
			}
			set
			{
				if (_itemData == value)
				{
					return;
				}
				_itemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get
			{
				if (_quantity == null)
				{
					_quantity = (CInt32) CR2WTypeManager.Create("Int32", "quantity", cr2w, this);
				}
				return _quantity;
			}
			set
			{
				if (_quantity == value)
				{
					return;
				}
				_quantity = value;
				PropertySet(this);
			}
		}

		public VendorConfirmationPopupCloseData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
