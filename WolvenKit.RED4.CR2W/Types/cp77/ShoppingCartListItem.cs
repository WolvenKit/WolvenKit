using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShoppingCartListItem : inkWidgetLogicController
	{
		private inkTextWidgetReference _label;
		private inkTextWidgetReference _quantity;
		private inkTextWidgetReference _value;
		private inkWidgetReference _removeBtn;
		private InventoryItemData _data;

		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get
			{
				if (_label == null)
				{
					_label = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "label", cr2w, this);
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

		[Ordinal(2)] 
		[RED("quantity")] 
		public inkTextWidgetReference Quantity
		{
			get
			{
				if (_quantity == null)
				{
					_quantity = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "quantity", cr2w, this);
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

		[Ordinal(3)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get
			{
				if (_value == null)
				{
					_value = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("removeBtn")] 
		public inkWidgetReference RemoveBtn
		{
			get
			{
				if (_removeBtn == null)
				{
					_removeBtn = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "removeBtn", cr2w, this);
				}
				return _removeBtn;
			}
			set
			{
				if (_removeBtn == value)
				{
					return;
				}
				_removeBtn = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		public ShoppingCartListItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
