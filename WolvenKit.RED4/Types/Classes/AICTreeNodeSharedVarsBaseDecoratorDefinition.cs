
namespace WolvenKit.RED4.Types
{
	public abstract partial class AICTreeNodeSharedVarsBaseDecoratorDefinition : AICTreeNodeDecoratorDefinition
	{
		public AICTreeNodeSharedVarsBaseDecoratorDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
