
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIWorldBoundarySystem : gameIGameSystem
	{
		public gameIWorldBoundarySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
