using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorConfirmationPopupData : inkGameNotificationData
	{
		private InventoryItemData _itemData;
		private CInt32 _quantity;
		private CEnum<VendorConfirmationPopupType> _type;
		private CInt32 _price;

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
		[RED("type")] 
		public CEnum<VendorConfirmationPopupType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<VendorConfirmationPopupType>) CR2WTypeManager.Create("VendorConfirmationPopupType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("price")] 
		public CInt32 Price
		{
			get
			{
				if (_price == null)
				{
					_price = (CInt32) CR2WTypeManager.Create("Int32", "price", cr2w, this);
				}
				return _price;
			}
			set
			{
				if (_price == value)
				{
					return;
				}
				_price = value;
				PropertySet(this);
			}
		}

		public VendorConfirmationPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
