using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSItemStack : CVariable
	{
		private gameItemID _itemID;
		private CInt32 _quantity;
		private CInt32 _powerLevel;
		private TweakDBID _vendorItemID;
		private CBool _isAvailable;
		private gameSItemStackRequirementData _requirement;

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
		public CInt32 PowerLevel
		{
			get
			{
				if (_powerLevel == null)
				{
					_powerLevel = (CInt32) CR2WTypeManager.Create("Int32", "powerLevel", cr2w, this);
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

		[Ordinal(3)] 
		[RED("vendorItemID")] 
		public TweakDBID VendorItemID
		{
			get
			{
				if (_vendorItemID == null)
				{
					_vendorItemID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "vendorItemID", cr2w, this);
				}
				return _vendorItemID;
			}
			set
			{
				if (_vendorItemID == value)
				{
					return;
				}
				_vendorItemID = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("isAvailable")] 
		public CBool IsAvailable
		{
			get
			{
				if (_isAvailable == null)
				{
					_isAvailable = (CBool) CR2WTypeManager.Create("Bool", "isAvailable", cr2w, this);
				}
				return _isAvailable;
			}
			set
			{
				if (_isAvailable == value)
				{
					return;
				}
				_isAvailable = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("requirement")] 
		public gameSItemStackRequirementData Requirement
		{
			get
			{
				if (_requirement == null)
				{
					_requirement = (gameSItemStackRequirementData) CR2WTypeManager.Create("gameSItemStackRequirementData", "requirement", cr2w, this);
				}
				return _requirement;
			}
			set
			{
				if (_requirement == value)
				{
					return;
				}
				_requirement = value;
				PropertySet(this);
			}
		}

		public gameSItemStack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
