using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLanguageSpecificImageController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("languages")] 
		public CArray<inkLanguageSpecificImagData> Languages
		{
			get => GetPropertyValue<CArray<inkLanguageSpecificImagData>>();
			set => SetPropertyValue<CArray<inkLanguageSpecificImagData>>(value);
		}

		[Ordinal(2)] 
		[RED("fallbackTextureAtlas")] 
		public CResourceAsyncReference<inkTextureAtlas> FallbackTextureAtlas
		{
			get => GetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>();
			set => SetPropertyValue<CResourceAsyncReference<inkTextureAtlas>>(value);
		}

		[Ordinal(3)] 
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
