using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkStyleTheme : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("themeID")] 
		public CName ThemeID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("styleResource")] 
		public CResourceReference<inkStyleResource> StyleResource
		{
			get => GetPropertyValue<CResourceReference<inkStyleResource>>();
			set => SetPropertyValue<CResourceReference<inkStyleResource>>(value);
		}

		public inkStyleTheme()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
