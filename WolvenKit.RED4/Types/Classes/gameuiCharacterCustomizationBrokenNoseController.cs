using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationBrokenNoseController : gameuiICharacterCustomizationComponent
	{
		[Ordinal(3)] 
		[RED("stage1App")] 
		public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance Stage1App
		{
			get => GetPropertyValue<gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance>();
			set => SetPropertyValue<gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance>(value);
		}

		[Ordinal(4)] 
		[RED("stage2App")] 
		public gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance Stage2App
		{
			get => GetPropertyValue<gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance>();
			set => SetPropertyValue<gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance>(value);
		}

		[Ordinal(5)] 
		[RED("finalSceneGroup")] 
		public CName FinalSceneGroup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiCharacterCustomizationBrokenNoseController()
		{
			Name = "Component";
			Stage1App = new gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance();
			Stage2App = new gameuiCharacterCustomizationBrokenNoseControllerBrokenNoseAppearance();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
