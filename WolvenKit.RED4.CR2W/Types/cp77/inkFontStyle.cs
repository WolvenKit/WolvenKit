using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkFontStyle : CVariable
	{
		private CName _styleName;
		private rRef<rendFont> _font;

		[Ordinal(0)] 
		[RED("styleName")] 
		public CName StyleName
		{
			get
			{
				if (_styleName == null)
				{
					_styleName = (CName) CR2WTypeManager.Create("CName", "styleName", cr2w, this);
				}
				return _styleName;
			}
			set
			{
				if (_styleName == value)
				{
					return;
				}
				_styleName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("font")] 
		public rRef<rendFont> Font
		{
			get
			{
				if (_font == null)
				{
					_font = (rRef<rendFont>) CR2WTypeManager.Create("rRef:rendFont", "font", cr2w, this);
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

		public inkFontStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
