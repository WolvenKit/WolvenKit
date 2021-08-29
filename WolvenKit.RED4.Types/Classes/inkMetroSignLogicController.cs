using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkMetroSignLogicController : inkIStreetNameSignLogicController
	{
		private inkTextWidgetReference _stationName;
		private inkTextWidgetReference _subDistrictName;
		private inkCompoundWidgetReference _metroStationsContainer;
		private CName _metroStationLibraryName;
		private CName _metroStationTextWidgetName;

		[Ordinal(1)] 
		[RED("stationName")] 
		public inkTextWidgetReference StationName
		{
			get => GetProperty(ref _stationName);
			set => SetProperty(ref _stationName, value);
		}

		[Ordinal(2)] 
		[RED("subDistrictName")] 
		public inkTextWidgetReference SubDistrictName
		{
			get => GetProperty(ref _subDistrictName);
			set => SetProperty(ref _subDistrictName, value);
		}

		[Ordinal(3)] 
		[RED("metroStationsContainer")] 
		public inkCompoundWidgetReference MetroStationsContainer
		{
			get => GetProperty(ref _metroStationsContainer);
			set => SetProperty(ref _metroStationsContainer, value);
		}

		[Ordinal(4)] 
		[RED("metroStationLibraryName")] 
		public CName MetroStationLibraryName
		{
			get => GetProperty(ref _metroStationLibraryName);
			set => SetProperty(ref _metroStationLibraryName, value);
		}

		[Ordinal(5)] 
		[RED("metroStationTextWidgetName")] 
		public CName MetroStationTextWidgetName
		{
			get => GetProperty(ref _metroStationTextWidgetName);
			set => SetProperty(ref _metroStationTextWidgetName, value);
		}
	}
}
