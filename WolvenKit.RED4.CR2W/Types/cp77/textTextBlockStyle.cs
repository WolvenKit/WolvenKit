using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class textTextBlockStyle : CVariable
	{
		private HDRColor _tintColor;
		private Vector2 _shadowOffset;
		private HDRColor _shadowColor;
		private textTextBlockFontStyle _fontStyle;
		private CUInt16 _fontSize;

		[Ordinal(0)] 
		[RED("tintColor")] 
		public HDRColor TintColor
		{
			get
			{
				if (_tintColor == null)
				{
					_tintColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "tintColor", cr2w, this);
				}
				return _tintColor;
			}
			set
			{
				if (_tintColor == value)
				{
					return;
				}
				_tintColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("shadowOffset")] 
		public Vector2 ShadowOffset
		{
			get
			{
				if (_shadowOffset == null)
				{
					_shadowOffset = (Vector2) CR2WTypeManager.Create("Vector2", "shadowOffset", cr2w, this);
				}
				return _shadowOffset;
			}
			set
			{
				if (_shadowOffset == value)
				{
					return;
				}
				_shadowOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("shadowColor")] 
		public HDRColor ShadowColor
		{
			get
			{
				if (_shadowColor == null)
				{
					_shadowColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "shadowColor", cr2w, this);
				}
				return _shadowColor;
			}
			set
			{
				if (_shadowColor == value)
				{
					return;
				}
				_shadowColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("fontStyle")] 
		public textTextBlockFontStyle FontStyle
		{
			get
			{
				if (_fontStyle == null)
				{
					_fontStyle = (textTextBlockFontStyle) CR2WTypeManager.Create("textTextBlockFontStyle", "fontStyle", cr2w, this);
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

		[Ordinal(4)] 
		[RED("fontSize")] 
		public CUInt16 FontSize
		{
			get
			{
				if (_fontSize == null)
				{
					_fontSize = (CUInt16) CR2WTypeManager.Create("Uint16", "fontSize", cr2w, this);
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

		public textTextBlockStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
