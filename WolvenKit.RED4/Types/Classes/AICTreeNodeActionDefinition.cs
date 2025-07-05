
namespace WolvenKit.RED4.Types
{
	public abstract partial class AICTreeNodeActionDefinition : AICTreeExtendableNodeDefinition
	{
		public AICTreeNodeActionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
