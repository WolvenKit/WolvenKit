using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkTypographyResource : CResource
	{
		[Ordinal(1)] 
		[RED("languages")] 
		public CArray<inkLanguageDefinition> Languages
		{
			get => GetPropertyValue<CArray<inkLanguageDefinition>>();
			set => SetPropertyValue<CArray<inkLanguageDefinition>>(value);
		}

		public inkTypographyResource()
		{
			Languages = new() { new inkLanguageDefinition { LanguageCode = "en-us", IsoScriptCode = "Latn", Fonts = new() { new inkLanguageFont { Font = new CResourceAsyncReference<inkFontFamilyResource>(12877316844558660473) } } } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
