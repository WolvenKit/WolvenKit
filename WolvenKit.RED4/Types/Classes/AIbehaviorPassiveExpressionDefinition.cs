
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIbehaviorPassiveExpressionDefinition : IScriptable
	{
		public AIbehaviorPassiveExpressionDefinition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
