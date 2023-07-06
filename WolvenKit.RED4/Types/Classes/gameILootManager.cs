
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameILootManager : gameIGameSystem
	{
		public gameILootManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
