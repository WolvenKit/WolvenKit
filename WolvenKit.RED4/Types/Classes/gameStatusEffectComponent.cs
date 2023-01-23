
namespace WolvenKit.RED4.Types
{
	public partial class gameStatusEffectComponent : gameComponent
	{
		public gameStatusEffectComponent()
		{
			Name = "StatusEffect";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
