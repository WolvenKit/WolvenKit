
namespace WolvenKit.RED4.Types
{
	public abstract partial class AICTreeNodeDynamicDefinition : AICTreeNodeDefinition
	{
		public AICTreeNodeDynamicDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
