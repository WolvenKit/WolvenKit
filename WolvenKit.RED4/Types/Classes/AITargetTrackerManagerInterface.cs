
namespace WolvenKit.RED4.Types
{
	public abstract partial class AITargetTrackerManagerInterface : gameIGameSystem
	{
		public AITargetTrackerManagerInterface()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
