
namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodePositionSharedVarDecoratorDefinition : AICTreeNodeSingleSharedVarDecoratorDefinition
	{
		public AICTreeNodePositionSharedVarDecoratorDefinition()
		{
			SharedVarName = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
