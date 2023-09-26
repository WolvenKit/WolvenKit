
namespace WolvenKit.RED4.Types
{
	public partial class gamedataShooterLayerInfo_Record
	{
		[RED("imageName")]
		[REDProperty(IsIgnored = true)]
		public CName ImageName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("imageTextureAtlas")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> ImageTextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("imageTexturePart")]
		[REDProperty(IsIgnored = true)]
		public CName ImageTexturePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
