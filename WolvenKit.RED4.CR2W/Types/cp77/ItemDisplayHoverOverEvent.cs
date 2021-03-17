using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayHoverOverEvent : redEvent
	{
		private InventoryItemData _itemData;
		private wCHandle<InventoryItemDisplayController> _display;
		private wCHandle<inkWidget> _widget;
		private CBool _isBuybackStack;

		[Ordinal(0)] 
		[RED("itemData")] 
		public InventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(1)] 
		[RED("display")] 
		public wCHandle<InventoryItemDisplayController> Display
		{
			get => GetProperty(ref _display);
			set => SetProperty(ref _display, value);
		}

		[Ordinal(2)] 
		[RED("widget")] 
		public wCHandle<inkWidget> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		[Ordinal(3)] 
		[RED("isBuybackStack")] 
		public CBool IsBuybackStack
		{
			get => GetProperty(ref _isBuybackStack);
			set => SetProperty(ref _isBuybackStack, value);
		}

		public ItemDisplayHoverOverEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
