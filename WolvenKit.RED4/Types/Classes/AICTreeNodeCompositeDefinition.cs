
namespace WolvenKit.RED4.Types
{
	public abstract partial class AICTreeNodeCompositeDefinition : AICTreeNodeDefinition
	{
		public AICTreeNodeCompositeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
