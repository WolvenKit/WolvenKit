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
			TintColor = new();
			HoverTintColor = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
