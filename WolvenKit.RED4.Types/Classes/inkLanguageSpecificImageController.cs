using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLanguageSpecificImageController : inkWidgetLogicController
	{
		private CResourceAsyncReference<inkTextureAtlas> _textureAtlasForLanguage;
		private CName _partNameForLanguage;
		private CArray<CEnum<inkLanguageId>> _languages;
		private CResourceAsyncReference<inkTextureAtlas> _fallbackTextureAtlas;
		private CName _fallbackPartName;

		[Ordinal(1)] 
		[RED("textureAtlasForLanguage")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlasForLanguage
		{
			get => GetProperty(ref _textureAtlasForLanguage);
			set => SetProperty(ref _textureAtlasForLanguage, value);
		}

		[Ordinal(2)] 
		[RED("partNameForLanguage")] 
		public CName PartNameForLanguage
		{
			get => GetProperty(ref _partNameForLanguage);
			set => SetProperty(ref _partNameForLanguage, value);
		}

		[Ordinal(3)] 
		[RED("languages")] 
		public CArray<CEnum<inkLanguageId>> Languages
		{
			get => GetProperty(ref _languages);
			set => SetProperty(ref _languages, value);
		}

		[Ordinal(4)] 
		[RED("fallbackTextureAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> FallbackTextureAtlas
		{
			get => GetProperty(ref _fallbackTextureAtlas);
			set => SetProperty(ref _fallbackTextureAtlas, value);
		}

		[Ordinal(5)] 
		[RED("fallbackPartName")] 
		public CName FallbackPartName
		{
			get => GetProperty(ref _fallbackPartName);
			set => SetProperty(ref _fallbackPartName, value);
		}
	}
}
