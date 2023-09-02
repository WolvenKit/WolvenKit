
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameISceneSystem : gameIGameSystem
	{
		public gameISceneSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
