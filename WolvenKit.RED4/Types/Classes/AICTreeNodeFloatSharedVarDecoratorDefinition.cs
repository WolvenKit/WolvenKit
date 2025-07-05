
namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeFloatSharedVarDecoratorDefinition : AICTreeNodeSingleSharedVarDecoratorDefinition
	{
		public AICTreeNodeFloatSharedVarDecoratorDefinition()
		{
			SharedVarName = new LibTreeSharedVarRegistrationName();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
