
namespace WolvenKit.RED4.Types
{
	public partial class gamedataGenericMetroSign_Record
	{
		[RED("iconName")]
		[REDProperty(IsIgnored = true)]
		public CName IconName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("isUnique")]
		[REDProperty(IsIgnored = true)]
		public CBool IsUnique
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("metroLineName")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> MetroLineName
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("resource")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> Resource
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("stationName")]
		[REDProperty(IsIgnored = true)]
		public CString StationName
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
