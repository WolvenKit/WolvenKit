
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIBreachSystem : gameIGameSystem
	{
		public gameIBreachSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
