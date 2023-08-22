
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIDebugVisualizerSystem : gameIGameSystem
	{
		public gameIDebugVisualizerSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
