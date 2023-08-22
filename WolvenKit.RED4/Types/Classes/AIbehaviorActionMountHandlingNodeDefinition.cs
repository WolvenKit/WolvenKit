
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIbehaviorActionMountHandlingNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		public AIbehaviorActionMountHandlingNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
