using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationPersonalLinkController : gameuiICharacterCustomizationComponent
	{
		[Ordinal(3)] 
		[RED("simpleLinkGroup")] 
		public CName SimpleLinkGroup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameuiCharacterCustomizationPersonalLinkController()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
