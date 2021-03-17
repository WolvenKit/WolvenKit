using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleRadioPopupGameController : BaseModalListPopupGameController
	{
		private inkImageWidgetReference _icon;
		private inkScrollAreaWidgetReference _scrollArea;
		private inkWidgetReference _scrollControllerWidget;
		private CHandle<RadioStationsDataView> _dataView;
		private CHandle<inkScriptableDataSourceWrapper> _dataSource;
		private wCHandle<QuickSlotsManager> _quickSlotsManager;
		private wCHandle<vehicleBaseObject> _playerVehicle;
		private CUInt32 _startupIndex;
		private wCHandle<RadioStationListItemController> _selectedItem;
		private wCHandle<inkScrollController> _scrollController;

		[Ordinal(11)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(12)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetProperty(ref _scrollArea);
			set => SetProperty(ref _scrollArea, value);
		}

		[Ordinal(13)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get => GetProperty(ref _scrollControllerWidget);
			set => SetProperty(ref _scrollControllerWidget, value);
		}

		[Ordinal(14)] 
		[RED("dataView")] 
		public CHandle<RadioStationsDataView> DataView
		{
			get => GetProperty(ref _dataView);
			set => SetProperty(ref _dataView, value);
		}

		[Ordinal(15)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetProperty(ref _dataSource);
			set => SetProperty(ref _dataSource, value);
		}

		[Ordinal(16)] 
		[RED("quickSlotsManager")] 
		public wCHandle<QuickSlotsManager> QuickSlotsManager
		{
			get => GetProperty(ref _quickSlotsManager);
			set => SetProperty(ref _quickSlotsManager, value);
		}

		[Ordinal(17)] 
		[RED("playerVehicle")] 
		public wCHandle<vehicleBaseObject> PlayerVehicle
		{
			get => GetProperty(ref _playerVehicle);
			set => SetProperty(ref _playerVehicle, value);
		}

		[Ordinal(18)] 
		[RED("startupIndex")] 
		public CUInt32 StartupIndex
		{
			get => GetProperty(ref _startupIndex);
			set => SetProperty(ref _startupIndex, value);
		}

		[Ordinal(19)] 
		[RED("selectedItem")] 
		public wCHandle<RadioStationListItemController> SelectedItem
		{
			get => GetProperty(ref _selectedItem);
			set => SetProperty(ref _selectedItem, value);
		}

		[Ordinal(20)] 
		[RED("scrollController")] 
		public wCHandle<inkScrollController> ScrollController
		{
			get => GetProperty(ref _scrollController);
			set => SetProperty(ref _scrollController, value);
		}

		public VehicleRadioPopupGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
