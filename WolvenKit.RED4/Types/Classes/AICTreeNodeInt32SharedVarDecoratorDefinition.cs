
namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeInt32SharedVarDecoratorDefinition : AICTreeNodeSingleSharedVarDecoratorDefinition
	{
		public AICTreeNodeInt32SharedVarDecoratorDefinition()
		{
			SharedVarName = new LibTreeSharedVarRegistrationName();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
