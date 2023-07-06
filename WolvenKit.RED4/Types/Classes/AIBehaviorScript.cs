
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIBehaviorScript : IScriptable
	{
		public AIBehaviorScript()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
