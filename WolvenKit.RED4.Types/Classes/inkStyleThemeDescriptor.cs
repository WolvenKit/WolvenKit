using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkStyleThemeDescriptor : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("themeID")] 
		public CName ThemeID
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("themeNameLocKey")] 
		public CName ThemeNameLocKey
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkStyleThemeDescriptor()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
