using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkStyleResource : CResource
	{
		private CArray<inkStyle> _styles;
		private CArray<CResourceReference<inkStyleResource>> _styleImports;
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
		public CArray<CResourceReference<inkStyleResource>> StyleImports
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
	}
}
