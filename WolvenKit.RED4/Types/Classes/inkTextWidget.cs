using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkTextWidget : inkLeafWidget
	{
		[Ordinal(20)] 
		[RED("localizationString")] 
		public LocalizationString LocalizationString
		{
			get => GetPropertyValue<LocalizationString>();
			set => SetPropertyValue<LocalizationString>(value);
		}

		[Ordinal(21)] 
		[RED("textIdKey")] 
		public CName TextIdKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("text")] 
		public CString Text
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(23)] 
		[RED("fontFamily")] 
		public CResourceAsyncReference<inkFontFamilyResource> FontFamily
		{
			get => GetPropertyValue<CResourceAsyncReference<inkFontFamilyResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkFontFamilyResource>>(value);
		}

		[Ordinal(24)] 
		[RED("fontStyle")] 
		public CName FontStyle
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("fontSize")] 
		public CUInt32 FontSize
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(26)] 
		[RED("font")] 
		public CHandle<rendFont> Font
		{
			get => GetPropertyValue<CHandle<rendFont>>();
			set => SetPropertyValue<CHandle<rendFont>>(value);
		}

		[Ordinal(27)] 
		[RED("letterCase")] 
		public CEnum<textLetterCase> LetterCase
		{
			get => GetPropertyValue<CEnum<textLetterCase>>();
			set => SetPropertyValue<CEnum<textLetterCase>>(value);
		}

		[Ordinal(28)] 
		[RED("tracking")] 
		public CUInt32 Tracking
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(29)] 
		[RED("lockFontInGame")] 
		public CBool LockFontInGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(30)] 
		[RED("wrappingInfo")] 
		public textWrappingInfo WrappingInfo
		{
			get => GetPropertyValue<textWrappingInfo>();
			set => SetPropertyValue<textWrappingInfo>(value);
		}

		[Ordinal(31)] 
		[RED("lineHeightPercentage")] 
		public CFloat LineHeightPercentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("justification")] 
		public CEnum<textJustificationType> Justification
		{
			get => GetPropertyValue<CEnum<textJustificationType>>();
			set => SetPropertyValue<CEnum<textJustificationType>>(value);
		}

		[Ordinal(33)] 
		[RED("textHorizontalAlignment")] 
		public CEnum<textHorizontalAlignment> TextHorizontalAlignment
		{
			get => GetPropertyValue<CEnum<textHorizontalAlignment>>();
			set => SetPropertyValue<CEnum<textHorizontalAlignment>>(value);
		}

		[Ordinal(34)] 
		[RED("textVerticalAlignment")] 
		public CEnum<textVerticalAlignment> TextVerticalAlignment
		{
			get => GetPropertyValue<CEnum<textVerticalAlignment>>();
			set => SetPropertyValue<CEnum<textVerticalAlignment>>(value);
		}

		[Ordinal(35)] 
		[RED("textOverflowPolicy")] 
		public CEnum<textOverflowPolicy> TextOverflowPolicy
		{
			get => GetPropertyValue<CEnum<textOverflowPolicy>>();
			set => SetPropertyValue<CEnum<textOverflowPolicy>>(value);
		}

		[Ordinal(36)] 
		[RED("scrollTextSpeed")] 
		public CFloat ScrollTextSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(37)] 
		[RED("scrollDelay")] 
		public CUInt16 ScrollDelay
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		[Ordinal(38)] 
		[RED("contentHAlign")] 
		public CEnum<inkEHorizontalAlign> ContentHAlign
		{
			get => GetPropertyValue<CEnum<inkEHorizontalAlign>>();
			set => SetPropertyValue<CEnum<inkEHorizontalAlign>>(value);
		}

		[Ordinal(39)] 
		[RED("contentVAlign")] 
		public CEnum<inkEVerticalAlign> ContentVAlign
		{
			get => GetPropertyValue<CEnum<inkEVerticalAlign>>();
			set => SetPropertyValue<CEnum<inkEVerticalAlign>>(value);
		}

		public inkTextWidget()
		{
			FitToContent = true;
			LocalizationString = new() { Unk1 = 0, Value = "" };
			FontSize = 22;
			WrappingInfo = new();
			LineHeightPercentage = 1.000000F;
			ScrollTextSpeed = 0.200000F;
			ScrollDelay = 30;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
