
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIISmartCoverManager : gameIGameSystem
	{
		public AIISmartCoverManager()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
