using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkMetroSignLogicController : inkIStreetNameSignLogicController
	{
		[Ordinal(1)] 
		[RED("stationName")] 
		public inkTextWidgetReference StationName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("subDistrictName")] 
		public inkTextWidgetReference SubDistrictName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("metroStationsContainer")] 
		public inkCompoundWidgetReference MetroStationsContainer
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("metroStationLibraryName")] 
		public CName MetroStationLibraryName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("metroStationTextWidgetName")] 
		public CName MetroStationTextWidgetName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkMetroSignLogicController()
		{
			StationName = new();
			SubDistrictName = new();
			MetroStationsContainer = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
