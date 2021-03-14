using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorSellJunkPopupData : inkGameNotificationData
	{
		private CArray<wCHandle<gameItemData>> _items;
		private CArray<CHandle<VendorJunkSellItem>> _limitedItems;
		private CInt32 _itemsQuantity;
		private CInt32 _limitedItemsQuantity;
		private CFloat _totalPrice;
		private CInt32 _limitedTotalPrice;

		[Ordinal(6)] 
		[RED("items")] 
		public CArray<wCHandle<gameItemData>> Items
		{
			get
			{
				if (_items == null)
				{
					_items = (CArray<wCHandle<gameItemData>>) CR2WTypeManager.Create("array:whandle:gameItemData", "items", cr2w, this);
				}
				return _items;
			}
			set
			{
				if (_items == value)
				{
					return;
				}
				_items = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("limitedItems")] 
		public CArray<CHandle<VendorJunkSellItem>> LimitedItems
		{
			get
			{
				if (_limitedItems == null)
				{
					_limitedItems = (CArray<CHandle<VendorJunkSellItem>>) CR2WTypeManager.Create("array:handle:VendorJunkSellItem", "limitedItems", cr2w, this);
				}
				return _limitedItems;
			}
			set
			{
				if (_limitedItems == value)
				{
					return;
				}
				_limitedItems = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("itemsQuantity")] 
		public CInt32 ItemsQuantity
		{
			get
			{
				if (_itemsQuantity == null)
				{
					_itemsQuantity = (CInt32) CR2WTypeManager.Create("Int32", "itemsQuantity", cr2w, this);
				}
				return _itemsQuantity;
			}
			set
			{
				if (_itemsQuantity == value)
				{
					return;
				}
				_itemsQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("limitedItemsQuantity")] 
		public CInt32 LimitedItemsQuantity
		{
			get
			{
				if (_limitedItemsQuantity == null)
				{
					_limitedItemsQuantity = (CInt32) CR2WTypeManager.Create("Int32", "limitedItemsQuantity", cr2w, this);
				}
				return _limitedItemsQuantity;
			}
			set
			{
				if (_limitedItemsQuantity == value)
				{
					return;
				}
				_limitedItemsQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("totalPrice")] 
		public CFloat TotalPrice
		{
			get
			{
				if (_totalPrice == null)
				{
					_totalPrice = (CFloat) CR2WTypeManager.Create("Float", "totalPrice", cr2w, this);
				}
				return _totalPrice;
			}
			set
			{
				if (_totalPrice == value)
				{
					return;
				}
				_totalPrice = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("limitedTotalPrice")] 
		public CInt32 LimitedTotalPrice
		{
			get
			{
				if (_limitedTotalPrice == null)
				{
					_limitedTotalPrice = (CInt32) CR2WTypeManager.Create("Int32", "limitedTotalPrice", cr2w, this);
				}
				return _limitedTotalPrice;
			}
			set
			{
				if (_limitedTotalPrice == value)
				{
					return;
				}
				_limitedTotalPrice = value;
				PropertySet(this);
			}
		}

		public VendorSellJunkPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
