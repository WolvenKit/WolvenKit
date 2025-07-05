
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIProjectileSystem : gameIGameSystem
	{
		public gameIProjectileSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
