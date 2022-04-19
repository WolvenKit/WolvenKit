using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemCompareBuilder : IScriptable
	{
		[Ordinal(0)] 
		[RED("sortData1")] 
		public InventoryItemSortData SortData1
		{
			get => GetPropertyValue<InventoryItemSortData>();
			set => SetPropertyValue<InventoryItemSortData>(value);
		}

		[Ordinal(1)] 
		[RED("sortData2")] 
		public InventoryItemSortData SortData2
		{
			get => GetPropertyValue<InventoryItemSortData>();
			set => SetPropertyValue<InventoryItemSortData>(value);
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
			SortData1 = new();
			SortData2 = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
