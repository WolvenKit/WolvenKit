
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameICommunitySystem : gameIGameSystem
	{
		public gameICommunitySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
