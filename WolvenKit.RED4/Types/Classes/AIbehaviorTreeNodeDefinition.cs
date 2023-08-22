
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIbehaviorTreeNodeDefinition : AIbehaviorBehaviorComponentDefinition
	{
		public AIbehaviorTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
