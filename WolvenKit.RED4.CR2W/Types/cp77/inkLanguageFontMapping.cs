using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLanguageFontMapping : CVariable
	{
		private CName _languageCode;
		private raRef<inkFontFamilyResource> _font;
		private CInt16 _fontSizeModifier;
		private CUInt32 _trackingModifier;
		private CFloat _lineHeightModifier;
		private CFloat _fontSizeModifierFloat;
		private CName _styleModifer;

		[Ordinal(0)] 
		[RED("languageCode")] 
		public CName LanguageCode
		{
			get
			{
				if (_languageCode == null)
				{
					_languageCode = (CName) CR2WTypeManager.Create("CName", "languageCode", cr2w, this);
				}
				return _languageCode;
			}
			set
			{
				if (_languageCode == value)
				{
					return;
				}
				_languageCode = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("font")] 
		public raRef<inkFontFamilyResource> Font
		{
			get
			{
				if (_font == null)
				{
					_font = (raRef<inkFontFamilyResource>) CR2WTypeManager.Create("raRef:inkFontFamilyResource", "font", cr2w, this);
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

		[Ordinal(2)] 
		[RED("fontSizeModifier")] 
		public CInt16 FontSizeModifier
		{
			get
			{
				if (_fontSizeModifier == null)
				{
					_fontSizeModifier = (CInt16) CR2WTypeManager.Create("Int16", "fontSizeModifier", cr2w, this);
				}
				return _fontSizeModifier;
			}
			set
			{
				if (_fontSizeModifier == value)
				{
					return;
				}
				_fontSizeModifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("trackingModifier")] 
		public CUInt32 TrackingModifier
		{
			get
			{
				if (_trackingModifier == null)
				{
					_trackingModifier = (CUInt32) CR2WTypeManager.Create("Uint32", "trackingModifier", cr2w, this);
				}
				return _trackingModifier;
			}
			set
			{
				if (_trackingModifier == value)
				{
					return;
				}
				_trackingModifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("lineHeightModifier")] 
		public CFloat LineHeightModifier
		{
			get
			{
				if (_lineHeightModifier == null)
				{
					_lineHeightModifier = (CFloat) CR2WTypeManager.Create("Float", "lineHeightModifier", cr2w, this);
				}
				return _lineHeightModifier;
			}
			set
			{
				if (_lineHeightModifier == value)
				{
					return;
				}
				_lineHeightModifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("fontSizeModifierFloat")] 
		public CFloat FontSizeModifierFloat
		{
			get
			{
				if (_fontSizeModifierFloat == null)
				{
					_fontSizeModifierFloat = (CFloat) CR2WTypeManager.Create("Float", "fontSizeModifierFloat", cr2w, this);
				}
				return _fontSizeModifierFloat;
			}
			set
			{
				if (_fontSizeModifierFloat == value)
				{
					return;
				}
				_fontSizeModifierFloat = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("styleModifer")] 
		public CName StyleModifer
		{
			get
			{
				if (_styleModifer == null)
				{
					_styleModifer = (CName) CR2WTypeManager.Create("CName", "styleModifer", cr2w, this);
				}
				return _styleModifer;
			}
			set
			{
				if (_styleModifer == value)
				{
					return;
				}
				_styleModifer = value;
				PropertySet(this);
			}
		}

		public inkLanguageFontMapping(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
