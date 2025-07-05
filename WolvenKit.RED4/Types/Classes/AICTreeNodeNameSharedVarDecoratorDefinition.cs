
namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeNameSharedVarDecoratorDefinition : AICTreeNodeSingleSharedVarDecoratorDefinition
	{
		public AICTreeNodeNameSharedVarDecoratorDefinition()
		{
			SharedVarName = new LibTreeSharedVarRegistrationName();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
