
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIISquadManager : gameIGameSystem
	{
		public AIISquadManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
