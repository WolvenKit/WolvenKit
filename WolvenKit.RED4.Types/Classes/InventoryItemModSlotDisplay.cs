using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemModSlotDisplay : inkWidgetLogicController
	{
		private inkWidgetReference _slotBorder;
		private inkWidgetReference _slotBackground;

		[Ordinal(1)] 
		[RED("slotBorder")] 
		public inkWidgetReference SlotBorder
		{
			get => GetProperty(ref _slotBorder);
			set => SetProperty(ref _slotBorder, value);
		}

		[Ordinal(2)] 
		[RED("slotBackground")] 
		public inkWidgetReference SlotBackground
		{
			get => GetProperty(ref _slotBackground);
			set => SetProperty(ref _slotBackground, value);
		}
	}
}
