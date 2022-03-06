
namespace WolvenKit.RED4.Types
{
	public partial class gamedataItemQuery_Record
	{
		[RED("recordType")]
		[REDProperty(IsIgnored = true)]
		public CName RecordType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("tags")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> Tags
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
		
		[RED("tagsToExclude")]
		[REDProperty(IsIgnored = true)]
		public CArray<CName> TagsToExclude
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}
	}
}
