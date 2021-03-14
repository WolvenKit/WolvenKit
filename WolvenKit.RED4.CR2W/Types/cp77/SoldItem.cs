using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SoldItem : IScriptable
	{
		private gameItemID _itemID;
		private CInt32 _quantity;
		private CInt32 _piecePrice;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get
			{
				if (_itemID == null)
				{
					_itemID = (gameItemID) CR2WTypeManager.Create("gameItemID", "itemID", cr2w, this);
				}
				return _itemID;
			}
			set
			{
				if (_itemID == value)
				{
					return;
				}
				_itemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("piecePrice")] 
		public CInt32 PiecePrice
		{
			get
			{
				if (_piecePrice == null)
				{
					_piecePrice = (CInt32) CR2WTypeManager.Create("Int32", "piecePrice", cr2w, this);
				}
				return _piecePrice;
			}
			set
			{
				if (_piecePrice == value)
				{
					return;
				}
				_piecePrice = value;
				PropertySet(this);
			}
		}

		public SoldItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
