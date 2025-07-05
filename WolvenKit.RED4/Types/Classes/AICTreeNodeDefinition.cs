
namespace WolvenKit.RED4.Types
{
	public abstract partial class AICTreeNodeDefinition : LibTreeINodeDefinition
	{
		public AICTreeNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
