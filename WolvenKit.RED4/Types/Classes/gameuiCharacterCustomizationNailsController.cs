using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationNailsController : gameuiCharacterCustomizationBodyPartsController
	{
		[Ordinal(4)] 
		[RED("nailsGroupName")] 
		public CName NailsGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiCharacterCustomizationNailsController()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
