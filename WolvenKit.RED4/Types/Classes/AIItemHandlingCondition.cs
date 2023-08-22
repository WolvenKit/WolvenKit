
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIItemHandlingCondition : AIbehaviorconditionScript
	{
		public AIItemHandlingCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
