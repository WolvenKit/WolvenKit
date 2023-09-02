
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIComponentsStateSystem : gameIGameSystem
	{
		public gameIComponentsStateSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
