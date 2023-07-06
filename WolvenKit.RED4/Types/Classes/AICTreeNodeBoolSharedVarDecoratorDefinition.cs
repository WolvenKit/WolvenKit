
namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeBoolSharedVarDecoratorDefinition : AICTreeNodeSingleSharedVarDecoratorDefinition
	{
		public AICTreeNodeBoolSharedVarDecoratorDefinition()
		{
			SharedVarName = new LibTreeSharedVarRegistrationName();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
