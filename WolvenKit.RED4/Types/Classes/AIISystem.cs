
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIISystem : gameIGameSystem
	{
		public AIISystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
