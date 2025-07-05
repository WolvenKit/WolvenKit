
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIIWorkspotManager : gameIGameSystem
	{
		public AIIWorkspotManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
