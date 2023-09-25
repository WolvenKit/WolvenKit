using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemCompareBuilder : IScriptable
	{
		[Ordinal(0)] 
		[RED("sortData1")] 
		public gameInventoryItemSortData SortData1
		{
			get => GetPropertyValue<gameInventoryItemSortData>();
			set => SetPropertyValue<gameInventoryItemSortData>(value);
		}

		[Ordinal(1)] 
		[RED("sortData2")] 
		public gameInventoryItemSortData SortData2
		{
			get => GetPropertyValue<gameInventoryItemSortData>();
			set => SetPropertyValue<gameInventoryItemSortData>(value);
		}

		[Ordinal(2)] 
		[RED("compareBuilder")] 
		public CHandle<CompareBuilder> CompareBuilder
		{
			get => GetPropertyValue<CHandle<CompareBuilder>>();
			set => SetPropertyValue<CHandle<CompareBuilder>>(value);
		}

		public ItemCompareBuilder()
		{
			SortData1 = new gameInventoryItemSortData();
			SortData2 = new gameInventoryItemSortData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
