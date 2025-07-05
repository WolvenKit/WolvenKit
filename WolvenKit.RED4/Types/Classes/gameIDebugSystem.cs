
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIDebugSystem : gameIGameSystem
	{
		public gameIDebugSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
