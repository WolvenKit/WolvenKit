using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkHighwaySignLogicController : inkIStreetNameSignLogicController
	{
		private inkTextWidgetReference _districtName;
		private inkTextWidgetReference _subDistrictName;
		private inkImageWidgetReference _metroStationIconLeft;
		private inkImageWidgetReference _metroStationIconRight;

		[Ordinal(1)] 
		[RED("districtName")] 
		public inkTextWidgetReference DistrictName
		{
			get => GetProperty(ref _districtName);
			set => SetProperty(ref _districtName, value);
		}

		[Ordinal(2)] 
		[RED("subDistrictName")] 
		public inkTextWidgetReference SubDistrictName
		{
			get => GetProperty(ref _subDistrictName);
			set => SetProperty(ref _subDistrictName, value);
		}

		[Ordinal(3)] 
		[RED("metroStationIconLeft")] 
		public inkImageWidgetReference MetroStationIconLeft
		{
			get => GetProperty(ref _metroStationIconLeft);
			set => SetProperty(ref _metroStationIconLeft, value);
		}

		[Ordinal(4)] 
		[RED("metroStationIconRight")] 
		public inkImageWidgetReference MetroStationIconRight
		{
			get => GetProperty(ref _metroStationIconRight);
			set => SetProperty(ref _metroStationIconRight, value);
		}
	}
}
