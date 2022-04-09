using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLanguageFont : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("font")] 
		public CResourceAsyncReference<inkFontFamilyResource> Font
		{
			get => GetPropertyValue<CResourceAsyncReference<inkFontFamilyResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkFontFamilyResource>>(value);
		}

		[Ordinal(1)] 
		[RED("mapper")] 
		public CHandle<inkLanguageFontMapper> Mapper
		{
			get => GetPropertyValue<CHandle<inkLanguageFontMapper>>();
			set => SetPropertyValue<CHandle<inkLanguageFontMapper>>(value);
		}

		public inkLanguageFont()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
