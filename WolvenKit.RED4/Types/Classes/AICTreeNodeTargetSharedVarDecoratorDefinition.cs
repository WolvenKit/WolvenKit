
namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeTargetSharedVarDecoratorDefinition : AICTreeNodeSingleSharedVarDecoratorDefinition
	{
		public AICTreeNodeTargetSharedVarDecoratorDefinition()
		{
			SharedVarName = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
