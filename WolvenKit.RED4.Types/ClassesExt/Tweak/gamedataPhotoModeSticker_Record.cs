
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPhotoModeSticker_Record
	{
		[RED("atlasName")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> AtlasName
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("imagePartName")]
		[REDProperty(IsIgnored = true)]
		public CName ImagePartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
