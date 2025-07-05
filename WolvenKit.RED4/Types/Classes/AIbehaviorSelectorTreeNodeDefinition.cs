
namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorSelectorTreeNodeDefinition : AIbehaviorCompositeTreeNodeDefinition
	{
		public AIbehaviorSelectorTreeNodeDefinition()
		{
			Children = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
