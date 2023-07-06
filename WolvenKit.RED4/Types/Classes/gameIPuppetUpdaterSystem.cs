
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIPuppetUpdaterSystem : gameIGameSystem
	{
		public gameIPuppetUpdaterSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
