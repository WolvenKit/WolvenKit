
namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationBeardController : gameuiCharacterCustomizationHeadPartsController
	{
		public gameuiCharacterCustomizationBeardController()
		{
			Name = "Component";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
