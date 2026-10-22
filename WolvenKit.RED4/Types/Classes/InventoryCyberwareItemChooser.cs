using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryCyberwareItemChooser : InventoryGenericItemChooser
	{
		[Ordinal(17)] 
		[RED("leftSlotsContainer")] 
		public inkCompoundWidgetReference LeftSlotsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("rightSlotsContainer")] 
		public inkCompoundWidgetReference RightSlotsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("itemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		public InventoryCyberwareItemChooser()
		{
			LeftSlotsContainer = new inkCompoundWidgetReference();
			RightSlotsContainer = new inkCompoundWidgetReference();
			ItemData = new gameInventoryItemData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
