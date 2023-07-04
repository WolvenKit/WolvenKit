using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLanguageSpecificImagData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("textureAtlasForLanguage")] 
		public CResourceAsyncReference<inkTextureAtlas> TextureAtlasForLanguage
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(1)] 
		[RED("partNameForLanguage")] 
		public CName PartNameForLanguage
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("languageID")] 
		public CEnum<inkLanguageId> LanguageID
		{
			get => GetPropertyValue<CEnum<inkLanguageId>>();
			set => SetPropertyValue<CEnum<inkLanguageId>>(value);
		}

		public inkLanguageSpecificImagData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
