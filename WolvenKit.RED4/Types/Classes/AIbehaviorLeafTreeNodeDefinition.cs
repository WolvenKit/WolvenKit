
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIbehaviorLeafTreeNodeDefinition : AIbehaviorTreeNodeDefinition
	{
		public AIbehaviorLeafTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
