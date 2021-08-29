using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemDataWrapper : IScriptable
	{
		private InventoryItemData _itemData;
		private InventoryItemSortData _sortData;
		private CBool _hasSortDataBuilt;

		[Ordinal(0)] 
		[RED("ItemData")] 
		public InventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(1)] 
		[RED("SortData")] 
		public InventoryItemSortData SortData
		{
			get => GetProperty(ref _sortData);
			set => SetProperty(ref _sortData, value);
		}

		[Ordinal(2)] 
		[RED("HasSortDataBuilt")] 
		public CBool HasSortDataBuilt
		{
			get => GetProperty(ref _hasSortDataBuilt);
			set => SetProperty(ref _hasSortDataBuilt, value);
		}
	}
}
