
namespace WolvenKit.RED4.Types
{
	public abstract partial class ExpressionTreeCGeneralNodeDefinition : ExpressionTreeCNodeDefinition
	{
		public ExpressionTreeCGeneralNodeDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
