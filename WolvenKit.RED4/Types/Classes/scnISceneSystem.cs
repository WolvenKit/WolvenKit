
namespace WolvenKit.RED4.Types
{
	public abstract partial class scnISceneSystem : gameISceneSystem
	{
		public scnISceneSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
