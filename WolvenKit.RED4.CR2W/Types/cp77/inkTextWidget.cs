using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextWidget : inkLeafWidget
	{
		private LocalizationString _localizationString;
		private CName _textIdKey;
		private CString _text;
		private raRef<inkFontFamilyResource> _fontFamily;
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
			get
			{
				if (_localizationString == null)
				{
					_localizationString = (LocalizationString) CR2WTypeManager.Create("LocalizationString", "localizationString", cr2w, this);
				}
				return _localizationString;
			}
			set
			{
				if (_localizationString == value)
				{
					return;
				}
				_localizationString = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("textIdKey")] 
		public CName TextIdKey
		{
			get
			{
				if (_textIdKey == null)
				{
					_textIdKey = (CName) CR2WTypeManager.Create("CName", "textIdKey", cr2w, this);
				}
				return _textIdKey;
			}
			set
			{
				if (_textIdKey == value)
				{
					return;
				}
				_textIdKey = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("text")] 
		public CString Text
		{
			get
			{
				if (_text == null)
				{
					_text = (CString) CR2WTypeManager.Create("String", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("fontFamily")] 
		public raRef<inkFontFamilyResource> FontFamily
		{
			get
			{
				if (_fontFamily == null)
				{
					_fontFamily = (raRef<inkFontFamilyResource>) CR2WTypeManager.Create("raRef:inkFontFamilyResource", "fontFamily", cr2w, this);
				}
				return _fontFamily;
			}
			set
			{
				if (_fontFamily == value)
				{
					return;
				}
				_fontFamily = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("fontStyle")] 
		public CName FontStyle
		{
			get
			{
				if (_fontStyle == null)
				{
					_fontStyle = (CName) CR2WTypeManager.Create("CName", "fontStyle", cr2w, this);
				}
				return _fontStyle;
			}
			set
			{
				if (_fontStyle == value)
				{
					return;
				}
				_fontStyle = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("fontSize")] 
		public CUInt32 FontSize
		{
			get
			{
				if (_fontSize == null)
				{
					_fontSize = (CUInt32) CR2WTypeManager.Create("Uint32", "fontSize", cr2w, this);
				}
				return _fontSize;
			}
			set
			{
				if (_fontSize == value)
				{
					return;
				}
				_fontSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("font")] 
		public CHandle<rendFont> Font
		{
			get
			{
				if (_font == null)
				{
					_font = (CHandle<rendFont>) CR2WTypeManager.Create("handle:rendFont", "font", cr2w, this);
				}
				return _font;
			}
			set
			{
				if (_font == value)
				{
					return;
				}
				_font = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("letterCase")] 
		public CEnum<textLetterCase> LetterCase
		{
			get
			{
				if (_letterCase == null)
				{
					_letterCase = (CEnum<textLetterCase>) CR2WTypeManager.Create("textLetterCase", "letterCase", cr2w, this);
				}
				return _letterCase;
			}
			set
			{
				if (_letterCase == value)
				{
					return;
				}
				_letterCase = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("tracking")] 
		public CUInt32 Tracking
		{
			get
			{
				if (_tracking == null)
				{
					_tracking = (CUInt32) CR2WTypeManager.Create("Uint32", "tracking", cr2w, this);
				}
				return _tracking;
			}
			set
			{
				if (_tracking == value)
				{
					return;
				}
				_tracking = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("lockFontInGame")] 
		public CBool LockFontInGame
		{
			get
			{
				if (_lockFontInGame == null)
				{
					_lockFontInGame = (CBool) CR2WTypeManager.Create("Bool", "lockFontInGame", cr2w, this);
				}
				return _lockFontInGame;
			}
			set
			{
				if (_lockFontInGame == value)
				{
					return;
				}
				_lockFontInGame = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("wrappingInfo")] 
		public textWrappingInfo WrappingInfo
		{
			get
			{
				if (_wrappingInfo == null)
				{
					_wrappingInfo = (textWrappingInfo) CR2WTypeManager.Create("textWrappingInfo", "wrappingInfo", cr2w, this);
				}
				return _wrappingInfo;
			}
			set
			{
				if (_wrappingInfo == value)
				{
					return;
				}
				_wrappingInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("lineHeightPercentage")] 
		public CFloat LineHeightPercentage
		{
			get
			{
				if (_lineHeightPercentage == null)
				{
					_lineHeightPercentage = (CFloat) CR2WTypeManager.Create("Float", "lineHeightPercentage", cr2w, this);
				}
				return _lineHeightPercentage;
			}
			set
			{
				if (_lineHeightPercentage == value)
				{
					return;
				}
				_lineHeightPercentage = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("justification")] 
		public CEnum<textJustificationType> Justification
		{
			get
			{
				if (_justification == null)
				{
					_justification = (CEnum<textJustificationType>) CR2WTypeManager.Create("textJustificationType", "justification", cr2w, this);
				}
				return _justification;
			}
			set
			{
				if (_justification == value)
				{
					return;
				}
				_justification = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("textHorizontalAlignment")] 
		public CEnum<textHorizontalAlignment> TextHorizontalAlignment
		{
			get
			{
				if (_textHorizontalAlignment == null)
				{
					_textHorizontalAlignment = (CEnum<textHorizontalAlignment>) CR2WTypeManager.Create("textHorizontalAlignment", "textHorizontalAlignment", cr2w, this);
				}
				return _textHorizontalAlignment;
			}
			set
			{
				if (_textHorizontalAlignment == value)
				{
					return;
				}
				_textHorizontalAlignment = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("textVerticalAlignment")] 
		public CEnum<textVerticalAlignment> TextVerticalAlignment
		{
			get
			{
				if (_textVerticalAlignment == null)
				{
					_textVerticalAlignment = (CEnum<textVerticalAlignment>) CR2WTypeManager.Create("textVerticalAlignment", "textVerticalAlignment", cr2w, this);
				}
				return _textVerticalAlignment;
			}
			set
			{
				if (_textVerticalAlignment == value)
				{
					return;
				}
				_textVerticalAlignment = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("textOverflowPolicy")] 
		public CEnum<textOverflowPolicy> TextOverflowPolicy
		{
			get
			{
				if (_textOverflowPolicy == null)
				{
					_textOverflowPolicy = (CEnum<textOverflowPolicy>) CR2WTypeManager.Create("textOverflowPolicy", "textOverflowPolicy", cr2w, this);
				}
				return _textOverflowPolicy;
			}
			set
			{
				if (_textOverflowPolicy == value)
				{
					return;
				}
				_textOverflowPolicy = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("scrollTextSpeed")] 
		public CFloat ScrollTextSpeed
		{
			get
			{
				if (_scrollTextSpeed == null)
				{
					_scrollTextSpeed = (CFloat) CR2WTypeManager.Create("Float", "scrollTextSpeed", cr2w, this);
				}
				return _scrollTextSpeed;
			}
			set
			{
				if (_scrollTextSpeed == value)
				{
					return;
				}
				_scrollTextSpeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("scrollDelay")] 
		public CUInt16 ScrollDelay
		{
			get
			{
				if (_scrollDelay == null)
				{
					_scrollDelay = (CUInt16) CR2WTypeManager.Create("Uint16", "scrollDelay", cr2w, this);
				}
				return _scrollDelay;
			}
			set
			{
				if (_scrollDelay == value)
				{
					return;
				}
				_scrollDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("contentHAlign")] 
		public CEnum<inkEHorizontalAlign> ContentHAlign
		{
			get
			{
				if (_contentHAlign == null)
				{
					_contentHAlign = (CEnum<inkEHorizontalAlign>) CR2WTypeManager.Create("inkEHorizontalAlign", "contentHAlign", cr2w, this);
				}
				return _contentHAlign;
			}
			set
			{
				if (_contentHAlign == value)
				{
					return;
				}
				_contentHAlign = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("contentVAlign")] 
		public CEnum<inkEVerticalAlign> ContentVAlign
		{
			get
			{
				if (_contentVAlign == null)
				{
					_contentVAlign = (CEnum<inkEVerticalAlign>) CR2WTypeManager.Create("inkEVerticalAlign", "contentVAlign", cr2w, this);
				}
				return _contentVAlign;
			}
			set
			{
				if (_contentVAlign == value)
				{
					return;
				}
				_contentVAlign = value;
				PropertySet(this);
			}
		}

		public inkTextWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
