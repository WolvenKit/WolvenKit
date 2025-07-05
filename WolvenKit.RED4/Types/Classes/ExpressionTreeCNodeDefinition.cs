
namespace WolvenKit.RED4.Types
{
	public abstract partial class ExpressionTreeCNodeDefinition : LibTreeINodeDefinition
	{
		public ExpressionTreeCNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
