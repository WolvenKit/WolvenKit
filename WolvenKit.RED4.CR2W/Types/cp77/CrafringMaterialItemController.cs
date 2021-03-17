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
			get => GetProperty(ref _nameText);
			set => SetProperty(ref _nameText, value);
		}

		[Ordinal(3)] 
		[RED("quantityText")] 
		public inkTextWidgetReference QuantityText
		{
			get => GetProperty(ref _quantityText);
			set => SetProperty(ref _quantityText, value);
		}

		[Ordinal(4)] 
		[RED("quantityChangeText")] 
		public inkTextWidgetReference QuantityChangeText
		{
			get => GetProperty(ref _quantityChangeText);
			set => SetProperty(ref _quantityChangeText, value);
		}

		[Ordinal(5)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(6)] 
		[RED("frame")] 
		public inkWidgetReference Frame
		{
			get => GetProperty(ref _frame);
			set => SetProperty(ref _frame, value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public InventoryItemData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(8)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(9)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetProperty(ref _hovered);
			set => SetProperty(ref _hovered, value);
		}

		[Ordinal(10)] 
		[RED("lastState")] 
		public CEnum<CrafringMaterialItemHighlight> LastState
		{
			get => GetProperty(ref _lastState);
			set => SetProperty(ref _lastState, value);
		}

		public CrafringMaterialItemController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
