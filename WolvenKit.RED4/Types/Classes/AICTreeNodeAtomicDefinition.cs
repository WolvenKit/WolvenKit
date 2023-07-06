
namespace WolvenKit.RED4.Types
{
	public abstract partial class AICTreeNodeAtomicDefinition : AICTreeNodeDefinition
	{
		public AICTreeNodeAtomicDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
