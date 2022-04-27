
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
		
		[RED("isUnique")]
		[REDProperty(IsIgnored = true)]
		public CBool IsUnique
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("resource")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Resource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("streetName")]
		[REDProperty(IsIgnored = true)]
		public CString StreetName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}
		
		[RED("styleStateName")]
		[REDProperty(IsIgnored = true)]
		public CName StyleStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
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
