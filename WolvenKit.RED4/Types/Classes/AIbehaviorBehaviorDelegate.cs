
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIbehaviorBehaviorDelegate : AIbehaviorBehaviorBlackboard
	{
		public AIbehaviorBehaviorDelegate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
