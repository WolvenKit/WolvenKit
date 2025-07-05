
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIAutonomousConditions : AIbehaviorconditionScript
	{
		public AIAutonomousConditions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
