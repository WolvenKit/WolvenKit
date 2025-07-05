
namespace WolvenKit.RED4.Types
{
	public abstract partial class questIWorldStateSystem : gameIGameSystem
	{
		public questIWorldStateSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
