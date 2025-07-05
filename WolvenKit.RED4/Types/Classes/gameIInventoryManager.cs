
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIInventoryManager : gameIGameSystem
	{
		public gameIInventoryManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
