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
			get => GetProperty(ref _styles);
			set => SetProperty(ref _styles, value);
		}

		[Ordinal(2)] 
		[RED("styleImports")] 
		public CArray<rRef<inkStyleResource>> StyleImports
		{
			get => GetProperty(ref _styleImports);
			set => SetProperty(ref _styleImports, value);
		}

		[Ordinal(3)] 
		[RED("themes")] 
		public CArray<inkStyleTheme> Themes
		{
			get => GetProperty(ref _themes);
			set => SetProperty(ref _themes, value);
		}

		[Ordinal(4)] 
		[RED("hideInInheritingStyles")] 
		public CBool HideInInheritingStyles
		{
			get => GetProperty(ref _hideInInheritingStyles);
			set => SetProperty(ref _hideInInheritingStyles, value);
		}

		public inkStyleResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
