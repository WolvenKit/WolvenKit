using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemDisplayVirtualController : inkVirtualCompoundItemController
	{
		private inkWidgetReference _itemDisplayWidget;
		private CName _widgetToSpawn;
		private CHandle<WrappedInventoryItemData> _wrappedData;
		private InventoryItemData _data;
		private CWeakHandle<inkWidget> _spawnedWidget;

		[Ordinal(15)] 
		[RED("itemDisplayWidget")] 
		public inkWidgetReference ItemDisplayWidget
		{
			get => GetProperty(ref _itemDisplayWidget);
			set => SetProperty(ref _itemDisplayWidget, value);
		}

		[Ordinal(16)] 
		[RED("widgetToSpawn")] 
		public CName WidgetToSpawn
		{
			get => GetProperty(ref _widgetToSpawn);
			set => SetProperty(ref _widgetToSpawn, value);
		}

		[Ordinal(17)] 
		[RED("wrappedData")] 
		public CHandle<WrappedInventoryItemData> WrappedData
		{
			get => GetProperty(ref _wrappedData);
			set => SetProperty(ref _wrappedData, value);
		}

		[Ordinal(18)] 
		[RED("data")] 
		public InventoryItemData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(19)] 
		[RED("spawnedWidget")] 
		public CWeakHandle<inkWidget> SpawnedWidget
		{
			get => GetProperty(ref _spawnedWidget);
			set => SetProperty(ref _spawnedWidget, value);
		}
	}
}
