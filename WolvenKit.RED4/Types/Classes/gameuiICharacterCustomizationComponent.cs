
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiICharacterCustomizationComponent : entIComponent
	{
		public gameuiICharacterCustomizationComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
