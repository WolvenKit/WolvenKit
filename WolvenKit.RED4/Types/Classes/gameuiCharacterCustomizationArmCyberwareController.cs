using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationArmCyberwareController : gameuiCharacterCustomizationBodyPartsController
	{
		[Ordinal(4)] 
		[RED("defaultGroupName")] 
		public CName DefaultGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("additionalCyberArmAppearances")] 
		public CArray<CResourceAsyncReference<appearanceAppearanceResource>> AdditionalCyberArmAppearances
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<appearanceAppearanceResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<appearanceAppearanceResource>>>(value);
		}

		public gameuiCharacterCustomizationArmCyberwareController()
		{
			Name = "Component";
			AdditionalCyberArmAppearances = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
