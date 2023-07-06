
namespace WolvenKit.RED4.Types
{
	public abstract partial class naviINavmeshGenerationSystem : gameIGameSystem
	{
		public naviINavmeshGenerationSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
