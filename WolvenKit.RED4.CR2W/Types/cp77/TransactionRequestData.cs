using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TransactionRequestData : CVariable
	{
		private gameItemID _itemID;
		private CInt32 _quantity;
		private CFloat _powerLevel;

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
		[RED("powerLevel")] 
		public CFloat PowerLevel
		{
			get
			{
				if (_powerLevel == null)
				{
					_powerLevel = (CFloat) CR2WTypeManager.Create("Float", "powerLevel", cr2w, this);
				}
				return _powerLevel;
			}
			set
			{
				if (_powerLevel == value)
				{
					return;
				}
				_powerLevel = value;
				PropertySet(this);
			}
		}

		public TransactionRequestData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
