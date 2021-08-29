using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkTextWidget : inkLeafWidget
	{
		private LocalizationString _localizationString;
		private CName _textIdKey;
		private CString _text;
		private CResourceAsyncReference<inkFontFamilyResource> _fontFamily;
		private CName _fontStyle;
		private CUInt32 _fontSize;
		private CHandle<rendFont> _font;
		private CEnum<textLetterCase> _letterCase;
		private CUInt32 _tracking;
		private CBool _lockFontInGame;
		private textWrappingInfo _wrappingInfo;
		private CFloat _lineHeightPercentage;
		private CEnum<textJustificationType> _justification;
		private CEnum<textHorizontalAlignment> _textHorizontalAlignment;
		private CEnum<textVerticalAlignment> _textVerticalAlignment;
		private CEnum<textOverflowPolicy> _textOverflowPolicy;
		private CFloat _scrollTextSpeed;
		private CUInt16 _scrollDelay;
		private CEnum<inkEHorizontalAlign> _contentHAlign;
		private CEnum<inkEVerticalAlign> _contentVAlign;

		[Ordinal(20)] 
		[RED("localizationString")] 
		public LocalizationString LocalizationString
		{
			get => GetProperty(ref _localizationString);
			set => SetProperty(ref _localizationString, value);
		}

		[Ordinal(21)] 
		[RED("textIdKey")] 
		public CName TextIdKey
		{
			get => GetProperty(ref _textIdKey);
			set => SetProperty(ref _textIdKey, value);
		}

		[Ordinal(22)] 
		[RED("text")] 
		public CString Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
		}

		[Ordinal(23)] 
		[RED("fontFamily")] 
		public CResourceAsyncReference<inkFontFamilyResource> FontFamily
		{
			get => GetProperty(ref _fontFamily);
			set => SetProperty(ref _fontFamily, value);
		}

		[Ordinal(24)] 
		[RED("fontStyle")] 
		public CName FontStyle
		{
			get => GetProperty(ref _fontStyle);
			set => SetProperty(ref _fontStyle, value);
		}

		[Ordinal(25)] 
		[RED("fontSize")] 
		public CUInt32 FontSize
		{
			get => GetProperty(ref _fontSize);
			set => SetProperty(ref _fontSize, value);
		}

		[Ordinal(26)] 
		[RED("font")] 
		public CHandle<rendFont> Font
		{
			get => GetProperty(ref _font);
			set => SetProperty(ref _font, value);
		}

		[Ordinal(27)] 
		[RED("letterCase")] 
		public CEnum<textLetterCase> LetterCase
		{
			get => GetProperty(ref _letterCase);
			set => SetProperty(ref _letterCase, value);
		}

		[Ordinal(28)] 
		[RED("tracking")] 
		public CUInt32 Tracking
		{
			get => GetProperty(ref _tracking);
			set => SetProperty(ref _tracking, value);
		}

		[Ordinal(29)] 
		[RED("lockFontInGame")] 
		public CBool LockFontInGame
		{
			get => GetProperty(ref _lockFontInGame);
			set => SetProperty(ref _lockFontInGame, value);
		}

		[Ordinal(30)] 
		[RED("wrappingInfo")] 
		public textWrappingInfo WrappingInfo
		{
			get => GetProperty(ref _wrappingInfo);
			set => SetProperty(ref _wrappingInfo, value);
		}

		[Ordinal(31)] 
		[RED("lineHeightPercentage")] 
		public CFloat LineHeightPercentage
		{
			get => GetProperty(ref _lineHeightPercentage);
			set => SetProperty(ref _lineHeightPercentage, value);
		}

		[Ordinal(32)] 
		[RED("justification")] 
		public CEnum<textJustificationType> Justification
		{
			get => GetProperty(ref _justification);
			set => SetProperty(ref _justification, value);
		}

		[Ordinal(33)] 
		[RED("textHorizontalAlignment")] 
		public CEnum<textHorizontalAlignment> TextHorizontalAlignment
		{
			get => GetProperty(ref _textHorizontalAlignment);
			set => SetProperty(ref _textHorizontalAlignment, value);
		}

		[Ordinal(34)] 
		[RED("textVerticalAlignment")] 
		public CEnum<textVerticalAlignment> TextVerticalAlignment
		{
			get => GetProperty(ref _textVerticalAlignment);
			set => SetProperty(ref _textVerticalAlignment, value);
		}

		[Ordinal(35)] 
		[RED("textOverflowPolicy")] 
		public CEnum<textOverflowPolicy> TextOverflowPolicy
		{
			get => GetProperty(ref _textOverflowPolicy);
			set => SetProperty(ref _textOverflowPolicy, value);
		}

		[Ordinal(36)] 
		[RED("scrollTextSpeed")] 
		public CFloat ScrollTextSpeed
		{
			get => GetProperty(ref _scrollTextSpeed);
			set => SetProperty(ref _scrollTextSpeed, value);
		}

		[Ordinal(37)] 
		[RED("scrollDelay")] 
		public CUInt16 ScrollDelay
		{
			get => GetProperty(ref _scrollDelay);
			set => SetProperty(ref _scrollDelay, value);
		}

		[Ordinal(38)] 
		[RED("contentHAlign")] 
		public CEnum<inkEHorizontalAlign> ContentHAlign
		{
			get => GetProperty(ref _contentHAlign);
			set => SetProperty(ref _contentHAlign, value);
		}

		[Ordinal(39)] 
		[RED("contentVAlign")] 
		public CEnum<inkEVerticalAlign> ContentVAlign
		{
			get => GetProperty(ref _contentVAlign);
			set => SetProperty(ref _contentVAlign, value);
		}
	}
}
