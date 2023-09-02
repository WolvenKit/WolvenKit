
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIINavigationSystem : gameIGameSystem
	{
		public AIINavigationSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
