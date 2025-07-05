
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIbehaviorDriveTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		public AIbehaviorDriveTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
