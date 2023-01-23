
namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorSequenceTreeNodeDefinition : AIbehaviorCompositeTreeNodeDefinition
	{
		public AIbehaviorSequenceTreeNodeDefinition()
		{
			Children = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
