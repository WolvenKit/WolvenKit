
namespace WolvenKit.RED4.Types
{
	public abstract partial class PassiveAutonomousCondition : AIbehaviorexpressionScript
	{
		public PassiveAutonomousCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
