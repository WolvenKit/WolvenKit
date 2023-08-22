
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIITrafficMovementSystem : gameIGameSystem
	{
		public AIITrafficMovementSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
