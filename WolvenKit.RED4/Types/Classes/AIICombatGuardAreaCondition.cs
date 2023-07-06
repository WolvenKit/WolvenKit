
namespace WolvenKit.RED4.Types
{
	public abstract partial class AIICombatGuardAreaCondition : IScriptable
	{
		public AIICombatGuardAreaCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
