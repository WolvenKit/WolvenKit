
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameuiICharacterCustomizationSystem : gameIGameSystem
	{
		public gameuiICharacterCustomizationSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
