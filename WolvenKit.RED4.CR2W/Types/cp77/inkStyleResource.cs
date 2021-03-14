using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStyleResource : CResource
	{
		private CArray<inkStyle> _styles;
		private CArray<rRef<inkStyleResource>> _styleImports;
		private CArray<inkStyleTheme> _themes;
		private CBool _hideInInheritingStyles;

		[Ordinal(1)] 
		[RED("styles")] 
		public CArray<inkStyle> Styles
		{
			get
			{
				if (_styles == null)
				{
					_styles = (CArray<inkStyle>) CR2WTypeManager.Create("array:inkStyle", "styles", cr2w, this);
				}
				return _styles;
			}
			set
			{
				if (_styles == value)
				{
					return;
				}
				_styles = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("styleImports")] 
		public CArray<rRef<inkStyleResource>> StyleImports
		{
			get
			{
				if (_styleImports == null)
				{
					_styleImports = (CArray<rRef<inkStyleResource>>) CR2WTypeManager.Create("array:rRef:inkStyleResource", "styleImports", cr2w, this);
				}
				return _styleImports;
			}
			set
			{
				if (_styleImports == value)
				{
					return;
				}
				_styleImports = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("themes")] 
		public CArray<inkStyleTheme> Themes
		{
			get
			{
				if (_themes == null)
				{
					_themes = (CArray<inkStyleTheme>) CR2WTypeManager.Create("array:inkStyleTheme", "themes", cr2w, this);
				}
				return _themes;
			}
			set
			{
				if (_themes == value)
				{
					return;
				}
				_themes = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hideInInheritingStyles")] 
		public CBool HideInInheritingStyles
		{
			get
			{
				if (_hideInInheritingStyles == null)
				{
					_hideInInheritingStyles = (CBool) CR2WTypeManager.Create("Bool", "hideInInheritingStyles", cr2w, this);
				}
				return _hideInInheritingStyles;
			}
			set
			{
				if (_hideInInheritingStyles == value)
				{
					return;
				}
				_hideInInheritingStyles = value;
				PropertySet(this);
			}
		}

		public inkStyleResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
