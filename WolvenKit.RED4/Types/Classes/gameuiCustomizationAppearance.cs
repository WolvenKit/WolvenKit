using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCustomizationAppearance : gameuiCensorshipInfo
	{
		[Ordinal(2)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("resource")] 
		public CResourceAsyncReference<appearanceAppearanceResource> Resource
		{
			get => GetPropertyValue<CResourceAsyncReference<appearanceAppearanceResource>>();
			set => SetPropertyValue<CResourceAsyncReference<appearanceAppearanceResource>>(value);
		}

		[Ordinal(4)] 
		[RED("definition")] 
		public CName Definition
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiCustomizationAppearance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
