using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemCompareBuilder : IScriptable
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

		public ItemCompareBuilder(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
