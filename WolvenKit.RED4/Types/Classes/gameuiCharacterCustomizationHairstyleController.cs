using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationHairstyleController : gameuiCharacterCustomizationBodyPartsController
	{
		[Ordinal(4)] 
		[RED("headGroupName")] 
		public CName HeadGroupName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiCharacterCustomizationHairstyleController()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
