
namespace WolvenKit.RED4.Types
{
	public partial class gamedataGenericStreetNameSign_Record
	{
		[RED("districtName")]
		[REDProperty(IsIgnored = true)]
		public CString DistrictName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("streetName")]
		[REDProperty(IsIgnored = true)]
		public CString StreetName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("subDistrictName")]
		[REDProperty(IsIgnored = true)]
		public CString SubDistrictName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
	}
}
