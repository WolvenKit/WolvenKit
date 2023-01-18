using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkStreetNameSignLogicController : inkIStreetNameSignLogicController
	{
		[Ordinal(1)] 
		[RED("streetName")] 
		public inkTextWidgetReference StreetName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("districtName")] 
		public inkTextWidgetReference DistrictName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("subdistrictName")] 
		public inkTextWidgetReference SubdistrictName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public inkStreetNameSignLogicController()
		{
			StreetName = new();
			DistrictName = new();
			SubdistrictName = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
