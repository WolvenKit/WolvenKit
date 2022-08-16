
namespace WolvenKit.RED4.Types
{
	public partial class gamedataLayout_Record
	{
		[RED("enumName")]
		[REDProperty(IsIgnored = true)]
		public CName EnumName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("libraryPath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> LibraryPath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
