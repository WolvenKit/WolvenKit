
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIItemFactorySystem : gameIGameSystem
	{
		public gameIItemFactorySystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
