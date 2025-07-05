
namespace WolvenKit.RED4.Types
{
	public abstract partial class CustomBlackboardDef : gamebbScriptDefinition
	{
		public CustomBlackboardDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
