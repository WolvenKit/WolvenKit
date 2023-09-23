using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioStationListItemController : inkVirtualCompoundItemController
	{
		[Ordinal(18)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("typeIcon")] 
		public inkImageWidgetReference TypeIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(20)] 
		[RED("equilizerIcon")] 
		public inkHorizontalPanelWidgetReference EquilizerIcon
		{
			get => GetPropertyValue<inkHorizontalPanelWidgetReference>();
			set => SetPropertyValue<inkHorizontalPanelWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("codeTLicon")] 
		public inkImageWidgetReference CodeTLicon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("trackName")] 
		public inkTextWidgetReference TrackName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("playerVehicle")] 
		public CWeakHandle<vehicleBaseObject> PlayerVehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(24)] 
		[RED("stationData")] 
		public CHandle<RadioListItemData> StationData
		{
			get => GetPropertyValue<CHandle<RadioListItemData>>();
			set => SetPropertyValue<CHandle<RadioListItemData>>(value);
		}

		[Ordinal(25)] 
		[RED("currentRadioStationId")] 
		public CInt32 CurrentRadioStationId
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public RadioStationListItemController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
