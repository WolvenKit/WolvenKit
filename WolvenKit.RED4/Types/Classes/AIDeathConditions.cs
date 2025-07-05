
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIDeathConditions : AIbehaviorconditionScript
	{
		public AIDeathConditions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
