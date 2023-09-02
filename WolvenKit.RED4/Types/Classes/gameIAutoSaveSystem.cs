
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIAutoSaveSystem : gameIGameSystem
	{
		public gameIAutoSaveSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
