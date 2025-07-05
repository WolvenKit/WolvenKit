
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIbehaviorBehaviorBlackboard : IScriptable
	{
		public AIbehaviorBehaviorBlackboard()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
