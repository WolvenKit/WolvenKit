using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RecipeData : IScriptable
	{
		private CString _label;
		private CArray<IngredientData> _ingredients;
		private CString _icon;
		private CEnum<gameItemIconGender> _iconGender;
		private CString _description;
		private CString _type;
		private CHandle<gamedataItem_Record> _id;
		private CBool _isCraftable;
		private InventoryItemData _inventoryItem;
		private CHandle<gameItemData> _gameItemData;
		private CInt32 _amount;

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
		[RED("ingredients")] 
		public CArray<IngredientData> Ingredients
		{
			get
			{
				if (_ingredients == null)
				{
					_ingredients = (CArray<IngredientData>) CR2WTypeManager.Create("array:IngredientData", "ingredients", cr2w, this);
				}
				return _ingredients;
			}
			set
			{
				if (_ingredients == value)
				{
					return;
				}
				_ingredients = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("description")] 
		public CString Description
		{
			get
			{
				if (_description == null)
				{
					_description = (CString) CR2WTypeManager.Create("String", "description", cr2w, this);
				}
				return _description;
			}
			set
			{
				if (_description == value)
				{
					return;
				}
				_description = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("type")] 
		public CString Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CString) CR2WTypeManager.Create("String", "type", cr2w, this);
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("isCraftable")] 
		public CBool IsCraftable
		{
			get
			{
				if (_isCraftable == null)
				{
					_isCraftable = (CBool) CR2WTypeManager.Create("Bool", "isCraftable", cr2w, this);
				}
				return _isCraftable;
			}
			set
			{
				if (_isCraftable == value)
				{
					return;
				}
				_isCraftable = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("inventoryItem")] 
		public InventoryItemData InventoryItem
		{
			get
			{
				if (_inventoryItem == null)
				{
					_inventoryItem = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "inventoryItem", cr2w, this);
				}
				return _inventoryItem;
			}
			set
			{
				if (_inventoryItem == value)
				{
					return;
				}
				_inventoryItem = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("gameItemData")] 
		public CHandle<gameItemData> GameItemData
		{
			get
			{
				if (_gameItemData == null)
				{
					_gameItemData = (CHandle<gameItemData>) CR2WTypeManager.Create("handle:gameItemData", "gameItemData", cr2w, this);
				}
				return _gameItemData;
			}
			set
			{
				if (_gameItemData == value)
				{
					return;
				}
				_gameItemData = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("amount")] 
		public CInt32 Amount
		{
			get
			{
				if (_amount == null)
				{
					_amount = (CInt32) CR2WTypeManager.Create("Int32", "amount", cr2w, this);
				}
				return _amount;
			}
			set
			{
				if (_amount == value)
				{
					return;
				}
				_amount = value;
				PropertySet(this);
			}
		}

		public RecipeData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
