
namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorAndConditionDefinition : AIbehaviorCompositeConditionDefinition
	{
		public AIbehaviorAndConditionDefinition()
		{
			Conditions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
