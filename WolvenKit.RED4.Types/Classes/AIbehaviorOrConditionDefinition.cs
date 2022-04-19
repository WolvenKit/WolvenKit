
namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorOrConditionDefinition : AIbehaviorCompositeConditionDefinition
	{
		public AIbehaviorOrConditionDefinition()
		{
			Conditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
