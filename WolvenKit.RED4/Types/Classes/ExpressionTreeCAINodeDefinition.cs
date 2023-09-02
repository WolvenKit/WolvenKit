
namespace WolvenKit.RED4.Types
{
	public abstract partial class ExpressionTreeCAINodeDefinition : ExpressionTreeCNodeDefinition
	{
		public ExpressionTreeCAINodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
