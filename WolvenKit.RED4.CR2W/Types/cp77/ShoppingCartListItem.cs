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
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(2)] 
		[RED("quantity")] 
		public inkTextWidgetReference Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(3)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(4)] 
		[RED("removeBtn")] 
		public inkWidgetReference RemoveBtn
		{
			get => GetProperty(ref _removeBtn);
			set => SetProperty(ref _removeBtn, value);
		}

		[Ordinal(5)] 
		[RED("data")] 
		public InventoryItemData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public ShoppingCartListItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
