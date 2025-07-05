
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIMinimapSystem : gameIGameSystem
	{
		public gameIMinimapSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
