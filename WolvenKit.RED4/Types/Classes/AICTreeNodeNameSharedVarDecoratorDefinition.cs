
namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeNameSharedVarDecoratorDefinition : AICTreeNodeSingleSharedVarDecoratorDefinition
	{
		public AICTreeNodeNameSharedVarDecoratorDefinition()
		{
			SharedVarName = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
