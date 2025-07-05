
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIbehaviorActionItemHandlingNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		public AIbehaviorActionItemHandlingNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
