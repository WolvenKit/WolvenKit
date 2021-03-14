using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class textTextBlockFontStyle : CVariable
	{
		private CName _fontStyle;
		private CInt32 _outlineSize;
		private HDRColor _outlineColor;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("outlineSize")] 
		public CInt32 OutlineSize
		{
			get
			{
				if (_outlineSize == null)
				{
					_outlineSize = (CInt32) CR2WTypeManager.Create("Int32", "outlineSize", cr2w, this);
				}
				return _outlineSize;
			}
			set
			{
				if (_outlineSize == value)
				{
					return;
				}
				_outlineSize = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("outlineColor")] 
		public HDRColor OutlineColor
		{
			get
			{
				if (_outlineColor == null)
				{
					_outlineColor = (HDRColor) CR2WTypeManager.Create("HDRColor", "outlineColor", cr2w, this);
				}
				return _outlineColor;
			}
			set
			{
				if (_outlineColor == value)
				{
					return;
				}
				_outlineColor = value;
				PropertySet(this);
			}
		}

		public textTextBlockFontStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
