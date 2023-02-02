
namespace WolvenKit.RED4.Types
{
	public partial class AICTreeNodeFloatSharedVarDecoratorDefinition : AICTreeNodeSingleSharedVarDecoratorDefinition
	{
		public AICTreeNodeFloatSharedVarDecoratorDefinition()
		{
			SharedVarName = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
