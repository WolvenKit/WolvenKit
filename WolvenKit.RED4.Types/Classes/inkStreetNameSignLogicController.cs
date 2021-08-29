using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkStreetNameSignLogicController : inkIStreetNameSignLogicController
	{
		private inkTextWidgetReference _streetName;
		private inkTextWidgetReference _districtName;
		private inkTextWidgetReference _subdistrictName;

		[Ordinal(1)] 
		[RED("streetName")] 
		public inkTextWidgetReference StreetName
		{
			get => GetProperty(ref _streetName);
			set => SetProperty(ref _streetName, value);
		}

		[Ordinal(2)] 
		[RED("districtName")] 
		public inkTextWidgetReference DistrictName
		{
			get => GetProperty(ref _districtName);
			set => SetProperty(ref _districtName, value);
		}

		[Ordinal(3)] 
		[RED("subdistrictName")] 
		public inkTextWidgetReference SubdistrictName
		{
			get => GetProperty(ref _subdistrictName);
			set => SetProperty(ref _subdistrictName, value);
		}
	}
}
