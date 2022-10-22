
namespace WolvenKit.RED4.Types
{
	public partial class gamedataArcadeObject_Record
	{
		[RED("animation")]
		[REDProperty(IsIgnored = true)]
		public CName Animation
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
		
		[RED("imageAnchorPoint")]
		[REDProperty(IsIgnored = true)]
		public Vector2 ImageAnchorPoint
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
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
		
		[RED("name")]
		[REDProperty(IsIgnored = true)]
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
