
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
		
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public CName DisplayName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("imagePartName")]
		[REDProperty(IsIgnored = true)]
		public CName ImagePartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("locked")]
		[REDProperty(IsIgnored = true)]
		public CBool Locked
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
