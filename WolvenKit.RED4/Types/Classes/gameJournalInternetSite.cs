using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameJournalInternetSite : gameJournalFileEntry
	{
		[Ordinal(2)] 
		[RED("shortName")] 
		public LocalizationString ShortName
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(3)] 
		[RED("mainPagePath")] 
		public CHandle<gameJournalPath> MainPagePath
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(4)] 
		[RED("ignoredAtDesktop")] 
		public CBool IgnoredAtDesktop
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("textureAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(6)] 
		[RED("texturePart")] 
		public CName TexturePart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameJournalInternetSite()
		{
			Entries = new();
			ShortName = new() { Unk1 = 0, Value = "" };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
