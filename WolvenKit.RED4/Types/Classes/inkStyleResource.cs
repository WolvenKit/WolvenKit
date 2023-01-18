using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkStyleResource : CResource
	{
		[Ordinal(1)] 
		[RED("styles")] 
		public CArray<inkStyle> Styles
		{
			get => GetPropertyValue<CArray<inkStyle>>();
			set => SetPropertyValue<CArray<inkStyle>>(value);
		}

		[Ordinal(2)] 
		[RED("styleImports")] 
		public CArray<CResourceReference<inkStyleResource>> StyleImports
		{
			get => GetPropertyValue<CArray<CResourceReference<inkStyleResource>>>();
			set => SetPropertyValue<CArray<CResourceReference<inkStyleResource>>>(value);
		}

		[Ordinal(3)] 
		[RED("themes")] 
		public CArray<inkStyleTheme> Themes
		{
			get => GetPropertyValue<CArray<inkStyleTheme>>();
			set => SetPropertyValue<CArray<inkStyleTheme>>(value);
		}

		[Ordinal(4)] 
		[RED("hideInInheritingStyles")] 
		public CBool HideInInheritingStyles
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkStyleResource()
		{
			Styles = new();
			StyleImports = new();
			Themes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
