
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIWorkspotGameSystem : gameIGameSystem
	{
		public gameIWorkspotGameSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
