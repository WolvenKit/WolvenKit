using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("resource")] 
		public CResourceAsyncReference<appearanceAppearanceResource> Resource
		{
			get => GetPropertyValue<CResourceAsyncReference<appearanceAppearanceResource>>();
			set => SetPropertyValue<CResourceAsyncReference<appearanceAppearanceResource>>(value);
		}

		[Ordinal(1)] 
		[RED("definition")] 
		public CName Definition
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
