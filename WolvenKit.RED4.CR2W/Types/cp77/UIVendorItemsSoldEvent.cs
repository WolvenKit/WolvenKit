using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIVendorItemsSoldEvent : redEvent
	{
		private CArray<gameItemID> _itemsID;
		private CArray<CInt32> _quantity;
		private CArray<CInt32> _piecesPrice;

		[Ordinal(0)] 
		[RED("itemsID")] 
		public CArray<gameItemID> ItemsID
		{
			get
			{
				if (_itemsID == null)
				{
					_itemsID = (CArray<gameItemID>) CR2WTypeManager.Create("array:gameItemID", "itemsID", cr2w, this);
				}
				return _itemsID;
			}
			set
			{
				if (_itemsID == value)
				{
					return;
				}
				_itemsID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("quantity")] 
		public CArray<CInt32> Quantity
		{
			get
			{
				if (_quantity == null)
				{
					_quantity = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "quantity", cr2w, this);
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

		[Ordinal(2)] 
		[RED("piecesPrice")] 
		public CArray<CInt32> PiecesPrice
		{
			get
			{
				if (_piecesPrice == null)
				{
					_piecesPrice = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "piecesPrice", cr2w, this);
				}
				return _piecesPrice;
			}
			set
			{
				if (_piecesPrice == value)
				{
					return;
				}
				_piecesPrice = value;
				PropertySet(this);
			}
		}

		public UIVendorItemsSoldEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
