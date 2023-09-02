using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkHighwaySignLogicController : inkIStreetNameSignLogicController
	{
		[Ordinal(1)] 
		[RED("districtName")] 
		public inkTextWidgetReference DistrictName
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
		[RED("metroStationIconLeft")] 
		public inkImageWidgetReference MetroStationIconLeft
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("metroStationIconRight")] 
		public inkImageWidgetReference MetroStationIconRight
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public inkHighwaySignLogicController()
		{
			DistrictName = new inkTextWidgetReference();
			SubDistrictName = new inkTextWidgetReference();
			MetroStationIconLeft = new inkImageWidgetReference();
			MetroStationIconRight = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
