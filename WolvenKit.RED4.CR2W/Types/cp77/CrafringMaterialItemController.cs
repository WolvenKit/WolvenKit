using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrafringMaterialItemController : BaseButtonView
	{
		private inkTextWidgetReference _nameText;
		private inkTextWidgetReference _quantityText;
		private inkTextWidgetReference _quantityChangeText;
		private inkImageWidgetReference _icon;
		private inkWidgetReference _frame;
		private InventoryItemData _data;
		private CInt32 _quantity;
		private CBool _hovered;
		private CEnum<CrafringMaterialItemHighlight> _lastState;

		[Ordinal(2)] 
		[RED("nameText")] 
		public inkTextWidgetReference NameText
		{
			get
			{
				if (_nameText == null)
				{
					_nameText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "nameText", cr2w, this);
				}
				return _nameText;
			}
			set
			{
				if (_nameText == value)
				{
					return;
				}
				_nameText = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("quantityText")] 
		public inkTextWidgetReference QuantityText
		{
			get
			{
				if (_quantityText == null)
				{
					_quantityText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "quantityText", cr2w, this);
				}
				return _quantityText;
			}
			set
			{
				if (_quantityText == value)
				{
					return;
				}
				_quantityText = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("quantityChangeText")] 
		public inkTextWidgetReference QuantityChangeText
		{
			get
			{
				if (_quantityChangeText == null)
				{
					_quantityChangeText = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "quantityChangeText", cr2w, this);
				}
				return _quantityChangeText;
			}
			set
			{
				if (_quantityChangeText == value)
				{
					return;
				}
				_quantityChangeText = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get
			{
				if (_icon == null)
				{
					_icon = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "icon", cr2w, this);
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
		[RED("frame")] 
		public inkWidgetReference Frame
		{
			get
			{
				if (_frame == null)
				{
					_frame = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "frame", cr2w, this);
				}
				return _frame;
			}
			set
			{
				if (_frame == value)
				{
					return;
				}
				_frame = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("data")] 
		public InventoryItemData Data
		{
			get
			{
				if (_data == null)
				{
					_data = (InventoryItemData) CR2WTypeManager.Create("InventoryItemData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
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

		[Ordinal(9)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get
			{
				if (_hovered == null)
				{
					_hovered = (CBool) CR2WTypeManager.Create("Bool", "hovered", cr2w, this);
				}
				return _hovered;
			}
			set
			{
				if (_hovered == value)
				{
					return;
				}
				_hovered = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("lastState")] 
		public CEnum<CrafringMaterialItemHighlight> LastState
		{
			get
			{
				if (_lastState == null)
				{
					_lastState = (CEnum<CrafringMaterialItemHighlight>) CR2WTypeManager.Create("CrafringMaterialItemHighlight", "lastState", cr2w, this);
				}
				return _lastState;
			}
			set
			{
				if (_lastState == value)
				{
					return;
				}
				_lastState = value;
				PropertySet(this);
			}
		}

		public CrafringMaterialItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
