
namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationBodyController : gameuiICharacterCustomizationBodyController
	{
		public gameuiCharacterCustomizationBodyController()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
