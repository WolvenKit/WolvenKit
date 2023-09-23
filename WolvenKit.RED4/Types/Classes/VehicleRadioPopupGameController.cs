using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleRadioPopupGameController : BaseModalListPopupGameController
	{
		[Ordinal(14)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetPropertyValue<inkScrollAreaWidgetReference>();
			set => SetPropertyValue<inkScrollAreaWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("trackName")] 
		public inkTextWidgetReference TrackName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("dataView")] 
		public CHandle<RadioStationsDataView> DataView
		{
			get => GetPropertyValue<CHandle<RadioStationsDataView>>();
			set => SetPropertyValue<CHandle<RadioStationsDataView>>(value);
		}

		[Ordinal(19)] 
		[RED("dataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> DataSource
		{
			get => GetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>();
			set => SetPropertyValue<CHandle<inkScriptableDataSourceWrapper>>(value);
		}

		[Ordinal(20)] 
		[RED("quickSlotsManager")] 
		public CWeakHandle<QuickSlotsManager> QuickSlotsManager
		{
			get => GetPropertyValue<CWeakHandle<QuickSlotsManager>>();
			set => SetPropertyValue<CWeakHandle<QuickSlotsManager>>(value);
		}

		[Ordinal(21)] 
		[RED("playerVehicle")] 
		public CWeakHandle<vehicleBaseObject> PlayerVehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(22)] 
		[RED("startupIndex")] 
		public CUInt32 StartupIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(23)] 
		[RED("currentRadioId")] 
		public CInt32 CurrentRadioId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(24)] 
		[RED("selectedItem")] 
		public CWeakHandle<RadioStationListItemController> SelectedItem
		{
			get => GetPropertyValue<CWeakHandle<RadioStationListItemController>>();
			set => SetPropertyValue<CWeakHandle<RadioStationListItemController>>(value);
		}

		[Ordinal(25)] 
		[RED("scrollController")] 
		public CWeakHandle<inkScrollController> ScrollController
		{
			get => GetPropertyValue<CWeakHandle<inkScrollController>>();
			set => SetPropertyValue<CWeakHandle<inkScrollController>>(value);
		}

		public VehicleRadioPopupGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
