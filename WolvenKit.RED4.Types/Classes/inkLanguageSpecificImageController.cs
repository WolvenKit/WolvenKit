using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLanguageSpecificImageController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("textureAtlasForLanguage")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlasForLanguage
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(2)] 
		[RED("partNameForLanguage")] 
		public CName PartNameForLanguage
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("languages")] 
		public CArray<CEnum<inkLanguageId>> Languages
		{
			get => GetPropertyValue<CArray<CEnum<inkLanguageId>>>();
			set => SetPropertyValue<CArray<CEnum<inkLanguageId>>>(value);
		}

		[Ordinal(4)] 
		[RED("fallbackTextureAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> FallbackTextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(5)] 
		[RED("fallbackPartName")] 
		public CName FallbackPartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkLanguageSpecificImageController()
		{
			Languages = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
