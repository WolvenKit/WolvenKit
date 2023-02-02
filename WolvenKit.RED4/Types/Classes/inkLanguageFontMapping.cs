using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkLanguageFontMapping : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("languageCode")] 
		public CName LanguageCode
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("font")] 
		public CResourceAsyncReference<inkFontFamilyResource> Font
		{
			get => GetPropertyValue<CResourceAsyncReference<inkFontFamilyResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkFontFamilyResource>>(value);
		}

		[Ordinal(2)] 
		[RED("fontSizeModifier")] 
		public CInt16 FontSizeModifier
		{
			get => GetPropertyValue<CInt16>();
			set => SetPropertyValue<CInt16>(value);
		}

		[Ordinal(3)] 
		[RED("trackingModifier")] 
		public CUInt32 TrackingModifier
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("lineHeightModifier")] 
		public CFloat LineHeightModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("fontSizeModifierFloat")] 
		public CFloat FontSizeModifierFloat
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("styleModifer")] 
		public CName StyleModifer
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkLanguageFontMapping()
		{
			LineHeightModifier = 1.000000F;
			FontSizeModifierFloat = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
