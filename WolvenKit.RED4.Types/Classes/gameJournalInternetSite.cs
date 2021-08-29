using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameJournalInternetSite : gameJournalFileEntry
	{
		private LocalizationString _shortName;
		private CHandle<gameJournalPath> _mainPagePath;
		private CBool _ignoredAtDesktop;
		private CResourceAsyncReference<inkTextureAtlas> _textureAtlas;
		private CName _texturePart;

		[Ordinal(2)] 
		[RED("shortName")] 
		public LocalizationString ShortName
		{
			get => GetProperty(ref _shortName);
			set => SetProperty(ref _shortName, value);
		}

		[Ordinal(3)] 
		[RED("mainPagePath")] 
		public CHandle<gameJournalPath> MainPagePath
		{
			get => GetProperty(ref _mainPagePath);
			set => SetProperty(ref _mainPagePath, value);
		}

		[Ordinal(4)] 
		[RED("ignoredAtDesktop")] 
		public CBool IgnoredAtDesktop
		{
			get => GetProperty(ref _ignoredAtDesktop);
			set => SetProperty(ref _ignoredAtDesktop, value);
		}

		[Ordinal(5)] 
		[RED("textureAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlas
		{
			get => GetProperty(ref _textureAtlas);
			set => SetProperty(ref _textureAtlas, value);
		}

		[Ordinal(6)] 
		[RED("texturePart")] 
		public CName TexturePart
		{
			get => GetProperty(ref _texturePart);
			set => SetProperty(ref _texturePart, value);
		}
	}
}
