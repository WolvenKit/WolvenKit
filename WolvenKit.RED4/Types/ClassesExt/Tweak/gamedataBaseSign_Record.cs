
namespace WolvenKit.RED4.Types
{
	public partial class gamedataBaseSign_Record
	{
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
		
		[RED("styleStateName")]
		[REDProperty(IsIgnored = true)]
		public CName StyleStateName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
