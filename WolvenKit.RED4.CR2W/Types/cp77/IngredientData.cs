using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IngredientData : CVariable
	{
		private CString _label;
		private CInt32 _quantity;
		private CInt32 _baseQuantity;
		private CInt32 _inventoryQuantity;
		private CHandle<gamedataItem_Record> _id;
		private CString _icon;
		private CEnum<gameItemIconGender> _iconGender;
		private CBool _playerSelectableIngredient;
		private CBool _buyableIngredient;
		private CBool _hasEnoughQuantity;

		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get
			{
				if (_label == null)
				{
					_label = (CString) CR2WTypeManager.Create("String", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
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
		[RED("baseQuantity")] 
		public CInt32 BaseQuantity
		{
			get
			{
				if (_baseQuantity == null)
				{
					_baseQuantity = (CInt32) CR2WTypeManager.Create("Int32", "baseQuantity", cr2w, this);
				}
				return _baseQuantity;
			}
			set
			{
				if (_baseQuantity == value)
				{
					return;
				}
				_baseQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("inventoryQuantity")] 
		public CInt32 InventoryQuantity
		{
			get
			{
				if (_inventoryQuantity == null)
				{
					_inventoryQuantity = (CInt32) CR2WTypeManager.Create("Int32", "inventoryQuantity", cr2w, this);
				}
				return _inventoryQuantity;
			}
			set
			{
				if (_inventoryQuantity == value)
				{
					return;
				}
				_inventoryQuantity = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("id")] 
		public CHandle<gamedataItem_Record> Id
		{
			get
			{
				if (_id == null)
				{
					_id = (CHandle<gamedataItem_Record>) CR2WTypeManager.Create("handle:gamedataItem_Record", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("icon")] 
		public CString Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (CString) CR2WTypeManager.Create("String", "icon", cr2w, this);
				}
				return _icon;
			}
			set
			{
				if (_icon == value)
				{
					return;
				}
				_icon = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("iconGender")] 
		public CEnum<gameItemIconGender> IconGender
		{
			get
			{
				if (_iconGender == null)
				{
					_iconGender = (CEnum<gameItemIconGender>) CR2WTypeManager.Create("gameItemIconGender", "iconGender", cr2w, this);
				}
				return _iconGender;
			}
			set
			{
				if (_iconGender == value)
				{
					return;
				}
				_iconGender = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("playerSelectableIngredient")] 
		public CBool PlayerSelectableIngredient
		{
			get
			{
				if (_playerSelectableIngredient == null)
				{
					_playerSelectableIngredient = (CBool) CR2WTypeManager.Create("Bool", "playerSelectableIngredient", cr2w, this);
				}
				return _playerSelectableIngredient;
			}
			set
			{
				if (_playerSelectableIngredient == value)
				{
					return;
				}
				_playerSelectableIngredient = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("buyableIngredient")] 
		public CBool BuyableIngredient
		{
			get
			{
				if (_buyableIngredient == null)
				{
					_buyableIngredient = (CBool) CR2WTypeManager.Create("Bool", "buyableIngredient", cr2w, this);
				}
				return _buyableIngredient;
			}
			set
			{
				if (_buyableIngredient == value)
				{
					return;
				}
				_buyableIngredient = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("hasEnoughQuantity")] 
		public CBool HasEnoughQuantity
		{
			get
			{
				if (_hasEnoughQuantity == null)
				{
					_hasEnoughQuantity = (CBool) CR2WTypeManager.Create("Bool", "hasEnoughQuantity", cr2w, this);
				}
				return _hasEnoughQuantity;
			}
			set
			{
				if (_hasEnoughQuantity == value)
				{
					return;
				}
				_hasEnoughQuantity = value;
				PropertySet(this);
			}
		}

		public IngredientData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
