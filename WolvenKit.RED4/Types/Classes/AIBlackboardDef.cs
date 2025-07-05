
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIBlackboardDef : gamebbScriptDefinition
	{
		public AIBlackboardDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
