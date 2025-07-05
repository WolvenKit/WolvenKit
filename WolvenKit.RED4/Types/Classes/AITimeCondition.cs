
namespace WolvenKit.RED4.Types
{
	public abstract partial class AITimeCondition : AIbehaviorconditionScript
	{
		public AITimeCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
