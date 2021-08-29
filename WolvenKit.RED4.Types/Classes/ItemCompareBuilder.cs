using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemCompareBuilder : IScriptable
	{
		private InventoryItemSortData _sortData1;
		private InventoryItemSortData _sortData2;
		private CHandle<CompareBuilder> _compareBuilder;

		[Ordinal(0)] 
		[RED("sortData1")] 
		public InventoryItemSortData SortData1
		{
			get => GetProperty(ref _sortData1);
			set => SetProperty(ref _sortData1, value);
		}

		[Ordinal(1)] 
		[RED("sortData2")] 
		public InventoryItemSortData SortData2
		{
			get => GetProperty(ref _sortData2);
			set => SetProperty(ref _sortData2, value);
		}

		[Ordinal(2)] 
		[RED("compareBuilder")] 
		public CHandle<CompareBuilder> CompareBuilder
		{
			get => GetProperty(ref _compareBuilder);
			set => SetProperty(ref _compareBuilder, value);
		}
	}
}
