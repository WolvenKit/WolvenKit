
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIEffectSystem : gameIGameSystem
	{
		public gameIEffectSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
