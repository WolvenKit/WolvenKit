
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameITargetingSystem : gameIGameSystem
	{
		public gameITargetingSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
