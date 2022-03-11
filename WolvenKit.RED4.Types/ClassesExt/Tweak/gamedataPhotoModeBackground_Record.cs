
namespace WolvenKit.RED4.Types
{
	public partial class gamedataPhotoModeBackground_Record
	{
		[RED("displayName")]
		[REDProperty(IsIgnored = true)]
		public CName DisplayName
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
		
		[RED("textureName")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> TextureName
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
	}
}
