
namespace WolvenKit.RED4.Types
{
	public partial class gamedataUIIcon_Record
	{
		[RED("atlasPartName")]
		[REDProperty(IsIgnored = true)]
		public CName AtlasPartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("atlasResourcePath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> AtlasResourcePath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
