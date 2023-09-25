using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryItemModSlotDisplay : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("slotBorder")] 
		public inkWidgetReference SlotBorder
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("slotBackground")] 
		public inkWidgetReference SlotBackground
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		public InventoryItemModSlotDisplay()
		{
			SlotBorder = new inkWidgetReference();
			SlotBackground = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
