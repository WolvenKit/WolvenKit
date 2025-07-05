
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameinfluenceISystem : gameIGameSystem
	{
		public gameinfluenceISystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
