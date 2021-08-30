using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkLanguageFontMapping : RedBaseClass
	{
		private CName _languageCode;
		private CResourceAsyncReference<inkFontFamilyResource> _font;
		private CInt16 _fontSizeModifier;
		private CUInt32 _trackingModifier;
		private CFloat _lineHeightModifier;
		private CFloat _fontSizeModifierFloat;
		private CName _styleModifer;

		[Ordinal(0)] 
		[RED("languageCode")] 
		public CName LanguageCode
		{
			get => GetProperty(ref _languageCode);
			set => SetProperty(ref _languageCode, value);
		}

		[Ordinal(1)] 
		[RED("font")] 
		public CResourceAsyncReference<inkFontFamilyResource> Font
		{
			get => GetProperty(ref _font);
			set => SetProperty(ref _font, value);
		}

		[Ordinal(2)] 
		[RED("fontSizeModifier")] 
		public CInt16 FontSizeModifier
		{
			get => GetProperty(ref _fontSizeModifier);
			set => SetProperty(ref _fontSizeModifier, value);
		}

		[Ordinal(3)] 
		[RED("trackingModifier")] 
		public CUInt32 TrackingModifier
		{
			get => GetProperty(ref _trackingModifier);
			set => SetProperty(ref _trackingModifier, value);
		}

		[Ordinal(4)] 
		[RED("lineHeightModifier")] 
		public CFloat LineHeightModifier
		{
			get => GetProperty(ref _lineHeightModifier);
			set => SetProperty(ref _lineHeightModifier, value);
		}

		[Ordinal(5)] 
		[RED("fontSizeModifierFloat")] 
		public CFloat FontSizeModifierFloat
		{
			get => GetProperty(ref _fontSizeModifierFloat);
			set => SetProperty(ref _fontSizeModifierFloat, value);
		}

		[Ordinal(6)] 
		[RED("styleModifer")] 
		public CName StyleModifer
		{
			get => GetProperty(ref _styleModifer);
			set => SetProperty(ref _styleModifer, value);
		}

		public inkLanguageFontMapping()
		{
			_lineHeightModifier = 1.000000F;
			_fontSizeModifierFloat = 1.000000F;
		}
	}
}
