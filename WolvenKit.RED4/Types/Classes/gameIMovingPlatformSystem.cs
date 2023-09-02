
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIMovingPlatformSystem : gameIGameSystem
	{
		public gameIMovingPlatformSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
