using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLanguageDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("languageCode")] 
		public CName LanguageCode
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("isoScriptCode")] 
		public CName IsoScriptCode
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("textDirection")] 
		public CEnum<inkETextDirection> TextDirection
		{
			get => GetPropertyValue<CEnum<inkETextDirection>>();
			set => SetPropertyValue<CEnum<inkETextDirection>>(value);
		}

		[Ordinal(3)] 
		[RED("fonts")] 
		public CArray<inkLanguageFont> Fonts
		{
			get => GetPropertyValue<CArray<inkLanguageFont>>();
			set => SetPropertyValue<CArray<inkLanguageFont>>(value);
		}

		public inkLanguageDefinition()
		{
			LanguageCode = "en-us";
			IsoScriptCode = "Latn";
			Fonts = new() { new inkLanguageFont() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
