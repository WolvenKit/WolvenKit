using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemStatList : inkWidgetLogicController
	{
		private CName _libraryItemName;
		private CWeakHandle<inkCompoundWidget> _container;
		private CArray<InventoryTooltipData_StatData> _data;
		private CArray<CWeakHandle<inkWidget>> _itemsList;

		[Ordinal(1)] 
		[RED("libraryItemName")] 
		public CName LibraryItemName
		{
			get => GetProperty(ref _libraryItemName);
			set => SetProperty(ref _libraryItemName, value);
		}

		[Ordinal(2)] 
		[RED("container")] 
		public CWeakHandle<inkCompoundWidget> Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(3)] 
		[RED("data")] 
		public CArray<InventoryTooltipData_StatData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(4)] 
		[RED("itemsList")] 
		public CArray<CWeakHandle<inkWidget>> ItemsList
		{
			get => GetProperty(ref _itemsList);
			set => SetProperty(ref _itemsList, value);
		}
	}
}
