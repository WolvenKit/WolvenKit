using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalInternetImage : gameJournalInternetBase
	{
		[Ordinal(4)] 
		[RED("textureAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(5)] 
		[RED("texturePart")] 
		public CName TexturePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameJournalInternetImage()
		{
			TintColor = new CColor { Red = 255, Green = 255, Blue = 255 };
			HoverTintColor = new CColor { Red = 255, Green = 255, Blue = 255 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
