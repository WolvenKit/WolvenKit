
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIStatusEffectSystem : gameIGameSystem
	{
		public gameIStatusEffectSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
