using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryComboBoxData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("Message")] 
		public CString Message
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("ItemsToDisplay")] 
		public CArray<gameInventoryItemData> ItemsToDisplay
		{
			get => GetPropertyValue<CArray<gameInventoryItemData>>();
			set => SetPropertyValue<CArray<gameInventoryItemData>>(value);
		}

		[Ordinal(2)] 
		[RED("ShowUnequipButton")] 
		public CBool ShowUnequipButton
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("ShowcaseItem")] 
		public gameInventoryItemData ShowcaseItem
		{
			get => GetPropertyValue<gameInventoryItemData>();
			set => SetPropertyValue<gameInventoryItemData>(value);
		}

		[Ordinal(4)] 
		[RED("DisplayShowcase")] 
		public CBool DisplayShowcase
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("ForceDouble")] 
		public CBool ForceDouble
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InventoryComboBoxData()
		{
			ItemsToDisplay = new();
			ShowcaseItem = new gameInventoryItemData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
